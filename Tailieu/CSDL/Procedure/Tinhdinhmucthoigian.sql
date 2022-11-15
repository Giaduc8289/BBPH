------------------------Hàm tính định mức thời gian-------------
If Object_ID('dbo.fTinhdinhmucthoigian','FN') is not null
	Drop FUNCTION dbo.fTinhdinhmucthoigian
Go

Create FUNCTION dbo.fTinhdinhmucthoigian(@Mamay Nvarchar(50), @Masanpham Nvarchar(50), @Tentruong Nvarchar(50)) RETURNS DECIMAL(20,2)
AS
BEGIN

	Declare @v_Madongmay	Nvarchar(50),
			@v_Doday		Decimal(20,3),
			@v_Rong				Decimal(20,3),
			@v_Dai				Decimal(20,3),
			@v_Somauma				Nvarchar(50),
			@v_Sohinhma				Nvarchar(50),
			@v_Maloaimang			Nvarchar(MAX),
			@v_Maqcthanhpham		Nvarchar(50),
			@v_Makhach				Nvarchar(50),
			@v_Thoigian			Decimal(20,3)

	-----Tạo bảng định mức thời gian chứa cột tên trường
	DECLARE @Dinhmuctg TABLE (
		Madmtg			Nvarchar(50),
		Tendinhmuc		Nvarchar(250) Not null,
		Mamay			Nvarchar(50),
		Madongmay		Nvarchar(50),
		Macongdoan		Nvarchar(50),
		Dodaytu			Decimal(20,3),
		Dodayden		Decimal(20,3),
		Khotu			Decimal(20,3),
		Khoden			Decimal(20,3),
		Chieudaitu		Decimal(20,3),
		Chieudaiden		Decimal(20,3),
		Somauma				Nvarchar(MAX),
		Sohinhma			Nvarchar(MAX),
		Maloaimang			Nvarchar(MAX),
		Maqcthanhpham		Nvarchar(MAX),
		Tentruong		Nvarchar(50),
		Giatri			Decimal(20,3))
				
	INSERT INTO @Dinhmuctg(Madmtg, Tendinhmuc, Mamay, Madongmay, Macongdoan, Dodaytu, Dodayden, Khotu, Khoden, Chieudaitu, Chieudaiden, Somauma, Sohinhma, Maloaimang, Maqcthanhpham, Tentruong, Giatri)
		Select Madmtg, Tendinhmuc, Mamay, Madongmay, Macongdoan, Dodaytu, Dodayden, Khotu, Khoden, Chieudaitu, Chieudaiden, Somauma, Sohinhma, Maloaimang, Maqcthanhpham
			, 'Dauca', Dauca
		From dinhmucthoigian
		Union
		Select Madmtg, Tendinhmuc, Mamay, Madongmay, Macongdoan, Dodaytu, Dodayden, Khotu, Khoden, Chieudaitu, Chieudaiden, Somauma, Sohinhma, Maloaimang, Maqcthanhpham
			, 'Chuanbi', Chuanbi
		From dinhmucthoigian
		Union
		Select Madmtg, Tendinhmuc, Mamay, Madongmay, Macongdoan, Dodaytu, Dodayden, Khotu, Khoden, Chieudaitu, Chieudaiden, Somauma, Sohinhma, Maloaimang, Maqcthanhpham
			, 'Daucuon', Daucuon
		From dinhmucthoigian
		Union
		Select Madmtg, Tendinhmuc, Mamay, Madongmay, Macongdoan, Dodaytu, Dodayden, Khotu, Khoden, Chieudaitu, Chieudaiden, Somauma, Sohinhma, Maloaimang, Maqcthanhpham
			, 'Doilenh', Doilenh
		From dinhmucthoigian
		Union
		Select Madmtg, Tendinhmuc, Mamay, Madongmay, Macongdoan, Dodaytu, Dodayden, Khotu, Khoden, Chieudaitu, Chieudaiden, Somauma, Sohinhma, Maloaimang, Maqcthanhpham
			, 'Lencuon', Lencuon
		From dinhmucthoigian
		Union
		Select Madmtg, Tendinhmuc, Mamay, Madongmay, Macongdoan, Dodaytu, Dodayden, Khotu, Khoden, Chieudaitu, Chieudaiden, Somauma, Sohinhma, Maloaimang, Maqcthanhpham
			, 'Xuongcuon', Xuongcuon
		From dinhmucthoigian
		Union
		Select Madmtg, Tendinhmuc, Mamay, Madongmay, Macongdoan, Dodaytu, Dodayden, Khotu, Khoden, Chieudaitu, Chieudaiden, Somauma, Sohinhma, Maloaimang, Maqcthanhpham
			, 'Thaythietbi', Thaythietbi
		From dinhmucthoigian
		Union
		Select Madmtg, Tendinhmuc, Mamay, Madongmay, Macongdoan, Dodaytu, Dodayden, Khotu, Khoden, Chieudaitu, Chieudaiden, Somauma, Sohinhma, Maloaimang, Maqcthanhpham
			, 'Dungmay', Dungmay
		From dinhmucthoigian
	
	If (@v_Madongmay='TH')
	Begin
		Select @v_Doday=Doday From Dmmang Where Mamang=@Masanpham	

		Select @v_Thoigian=Giatri
		From @Dinhmuctg
		Where Tentruong = @Tentruong
			And (Mamay=@Mamay Or Mamay='')
			And ((Dodaytu<=@v_Doday And Dodayden>=@v_Doday) Or (Dodaytu=0 And Dodayden=0))	
	End
	Else
	Begin
		Select @v_Rong=Rong, @v_Dai=Dai
			, @v_Somauma=Somauma, @v_Sohinhma=Sohinhma, @v_Maqcthanhpham=Maqcthanhpham
			, @v_Makhach=Makhach
			, @v_Doday=IsNull((Select top 1 Doday 
				From mangcuahang 
				Where Masp=sp.Masp And Mangin=1),0)
		From dmhang sp 			
		Where sp.Masp=@Masanpham
	
		DECLARE @Loaimang TABLE (Maloaimang Nvarchar(50))
		INSERT INTO @Loaimang(Maloaimang)
			Select Distinct Maloaimang
			From mangcuahang 
			Where Masp=@Masanpham 

		Select @v_Maloaimang
			= STUFF((Select ',' + Maloaimang
					From @Loaimang t1
					For XML Path('')), 1, Len(','), '')

		Select @v_Thoigian=Min(Giatri)
		From @Dinhmuctg dm, (Select Value As Maloaimang From dbo.SplitString(@v_Maloaimang,',')) a
		Where Tentruong = @Tentruong
			And (CHARINDEX(@Mamay+',',Mamay)>0 OR ISNULL(Mamay,'') = '')
			--And (CHARINDEX(@Macongdoan+',',Macongdoans)>0 OR ISNULL(Macongdoans,'') = '')
			And ((Dodaytu<=@v_Doday And Dodayden>=@v_Doday) Or (Dodaytu=0 And Dodayden=0))	
			And ((Khotu<=@v_Rong And Khoden>=@v_Rong) Or (Khotu=0 And Khoden=0))	
			And ((Chieudaitu<=@v_Dai And Chieudaiden>=@v_Dai) Or (Chieudaitu=0 And Chieudaiden=0))	
			AND	(CHARINDEX(@v_Sohinhma+',',Sohinhma)>0 OR ISNULL(Sohinhma,'') = '')
			AND	(CHARINDEX(@v_Somauma+',',Somauma)>0 OR ISNULL(Somauma,'') = '')
			AND (CHARINDEX(@v_Maqcthanhpham+',',Maqcthanhpham)>0 OR ISNULL(Maqcthanhpham,'') = '')			
			AND	(CHARINDEX(a.Maloaimang+',',dm.Maloaimang)>0 OR ISNULL(dm.Maloaimang,'') = '')
			--AND (CHARINDEX(@v_Makhach+',',Makhach)>0 OR ISNULL(Makhach,'') = '')			
			--AND (CHARINDEX(@Masanpham+',',Mahang)>0 OR ISNULL(Mahang,'') = '')			
	End

	RETURN ISNULL(@v_Thoigian,0);
END
	
Go

SELECT dbo.fTinhdinhmucthoigian('L1', 'SP 1450', 'Chuanbi') --('T1', 'CPP50x1120')

GO	

