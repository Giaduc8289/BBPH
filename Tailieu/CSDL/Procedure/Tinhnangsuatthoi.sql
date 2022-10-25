------------------------Hàm tính năng suất thổi-------------
If Object_ID('dbo.fTinhnangsuatthoi','FN') is not null
	Drop FUNCTION dbo.fTinhnangsuatthoi
Go

Create FUNCTION dbo.fTinhnangsuatthoi(@Ketquathoi_Id Bigint) RETURNS DECIMAL(20,2)
AS
BEGIN

	Declare @v_Mamay		Nvarchar(50),
			@v_Madongmay	Nvarchar(50),
			@v_Mamang		Nvarchar(50),
			@v_Doday		Decimal(20,3),
			@v_Rong				Decimal(20,3),
			@v_Sokgdukien		Decimal(20,3),
			@v_Sokgthucte		Decimal(20,3),
			@v_Somet			Decimal(20,3),
			@v_Thoigianchay		Decimal(20,3),
			@v_Tocdo			Decimal(20,3),
			@v_Nangsuat			DECIMAL(20,3)

	Select @v_Mamay=Mamay, @v_Mamang=Mamang, @v_Sokgthucte=Sokg, @v_Somet=Somet 
		, @v_Thoigianchay=DATEDIFF(Minute,Thoigianbatdau,Thoigianketthuc)-Thoigianchuanbi-Thoigiansuco
	From Ketquathoi 
	Where Id=@Ketquathoi_Id
--Select * from Ketquathoi
	--Select @v_Madongmay=Madm From dmmay Where Mamay=@v_Mamay
	
	--Truy vấn thông tin sản phẩm
	Select @v_Doday=Doday, @v_Rong=Rong From Dmmang Where Mamang=@v_Mamang	
--Select * from dmmang

	--Tính chất lượng căn cứ: Độ dày * Rộng * Số mét * 0,925/1000000
	
	--Tính năng suất căn cứ: Thời gian chạy * Tốc độ
	--Độ dày màng và Mã máy tính ra Công suất máy
	Select @v_Tocdo=Tocdo
	From congsuatmay
	Where (Mamay=@v_Mamay Or Mamay='')
		--And (Madongmay=@v_Madongmay Or Madongmay='')
		And ((@v_Doday>=Dodaytu And @v_Doday<Dodayden) Or (Dodaytu=0 And Dodayden=0))	
--Select * from congsuatmay

	Set @v_Sokgdukien=@v_Thoigianchay*@v_Tocdo
	Set @v_Nangsuat=@v_Sokgthucte/@v_Sokgdukien
		
	RETURN ISNULL(@v_Nangsuat,0);
END
	
Go

SELECT dbo.fTinhnangsuatthoi(1)

GO	

