------------------------Hàm tính năng suất thổi-------------
If Object_ID('dbo.fTinhnangsuatthoi','FN') is not null
	Drop FUNCTION dbo.fTinhnangsuatthoi
Go

Create FUNCTION dbo.fTinhnangsuatthoi(@Ketquathoi_Id Bigint) RETURNS DECIMAL(20,2)
AS
BEGIN

	Declare @v_Mamay		Nvarchar(50),
			--@v_Madongmay	Nvarchar(50),
			@v_Mamang		Nvarchar(50),
			--@v_Doday		Decimal(20,3),
			--@v_Rong		Decimal(20,3),
			--@v_Dai		Decimal(20,3),
			@v_Sokgdukien		Decimal(20,3),
			@v_Sokgthucte		Decimal(20,3),
			--@v_Somet			Decimal(20,3),
			@v_Thoigianchay		Decimal(20,3),
			@v_Tocdo			Decimal(20,3),
			@v_Nangsuat			DECIMAL(20,3)

	Select @v_Mamay=Mamay, @v_Mamang=Mamang, @v_Sokgthucte=Sokg--, @v_Somet=Somet 
		, @v_Thoigianchay=DATEDIFF(Minute,Thoigianbatdau,Thoigianketthuc)-Thoigianchuanbi-Thoigiansuco
	From Ketquathoi 
	Where Id=@Ketquathoi_Id
	
	--Tính chất lượng căn cứ: Độ dày * Rộng * Số mét * 0,925/1000000
	--Tính năng suất căn cứ: Thời gian chạy * Tốc độ
	Select @v_Tocdo=dbo.fTinhcongsuatmay(@v_Mamay, @v_Mamang)

	Set @v_Sokgdukien=@v_Thoigianchay*@v_Tocdo
	If (@v_Sokgdukien <> 0) 
		Set @v_Nangsuat=@v_Sokgthucte/@v_Sokgdukien
		
	RETURN ISNULL(@v_Nangsuat,0);
END
	
Go

SELECT dbo.fTinhnangsuatthoi(1)

GO	

