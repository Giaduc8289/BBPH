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
		Madinhmuc			Nvarchar(50),
		Tendinhmuc		Nvarchar(250) Not null,
		Mamays			Nvarchar(MAX),
		Macongdoans		Nvarchar(MAX),
		Dodaytu			Decimal(20,3),
		Dodayden		Decimal(20,3),
		Khotu			Decimal(20,3),
		Khoden			Decimal(20,3),
		Chieudaitu		Decimal(20,3),
		Chieudaiden		Decimal(20,3),
		Somaumas			Nvarchar(MAX),
		Sohinhmas			Nvarchar(MAX),
		Maloaimangs			Nvarchar(MAX),
		Maqcthanhphams		Nvarchar(MAX),
		Makhachs			Nvarchar(MAX),
		Mahangs				Nvarchar(MAX),
		Tentruong		Nvarchar(50),
		Giatri			Decimal(20,3))
				
	INSERT INTO @Dinhmuctg(Madinhmuc, Tendinhmuc, Mamays, Macongdoans, Dodaytu, Dodayden, Khotu, Khoden, Chieudaitu, Chieudaiden, Somaumas, Sohinhmas, Maloaimangs, Maqcthanhphams, Makhachs, Mahangs, Tentruong, Giatri)
		Select Madinhmuc, Tendinhmuc, Mamays, Macongdoans, Dodaytu, Dodayden, Khotu, Khoden, Chieudaitu, Chieudaiden, Somaumas, Sohinhmas, Maloaimangs, Maqcthanhphams, Makhachs, Mahangs
			, 'Dauca', Dauca
		From dinhmucthoigian
		Union
		Select Madinhmuc, Tendinhmuc, Mamays, Macongdoans, Dodaytu, Dodayden, Khotu, Khoden, Chieudaitu, Chieudaiden, Somaumas, Sohinhmas, Maloaimangs, Maqcthanhphams, Makhachs, Mahangs
			, 'Chuanbi', Chuanbi
		From dinhmucthoigian
		Union
		Select Madinhmuc, Tendinhmuc, Mamays, Macongdoans, Dodaytu, Dodayden, Khotu, Khoden, Chieudaitu, Chieudaiden, Somaumas, Sohinhmas, Maloaimangs, Maqcthanhphams, Makhachs, Mahangs
			, 'Daucuon', Daucuon
		From dinhmucthoigian
		Union
		Select Madinhmuc, Tendinhmuc, Mamays, Macongdoans, Dodaytu, Dodayden, Khotu, Khoden, Chieudaitu, Chieudaiden, Somaumas, Sohinhmas, Maloaimangs, Maqcthanhphams, Makhachs, Mahangs
			, 'Doilenh', Doilenh
		From dinhmucthoigian
		Union
		Select Madinhmuc, Tendinhmuc, Mamays, Macongdoans, Dodaytu, Dodayden, Khotu, Khoden, Chieudaitu, Chieudaiden, Somaumas, Sohinhmas, Maloaimangs, Maqcthanhphams, Makhachs, Mahangs
			, 'Lencuon', Lencuon
		From dinhmucthoigian
		Union
		Select Madinhmuc, Tendinhmuc, Mamays, Macongdoans, Dodaytu, Dodayden, Khotu, Khoden, Chieudaitu, Chieudaiden, Somaumas, Sohinhmas, Maloaimangs, Maqcthanhphams, Makhachs, Mahangs
			, 'Xuongcuon', Xuongcuon
		From dinhmucthoigian
		Union
		Select Madinhmuc, Tendinhmuc, Mamays, Macongdoans, Dodaytu, Dodayden, Khotu, Khoden, Chieudaitu, Chieudaiden, Somaumas, Sohinhmas, Maloaimangs, Maqcthanhphams, Makhachs, Mahangs
			, 'Thaythietbi', Thaythietbi
		From dinhmucthoigian
		Union
		Select Madinhmuc, Tendinhmuc, Mamays, Macongdoans, Dodaytu, Dodayden, Khotu, Khoden, Chieudaitu, Chieudaiden, Somaumas, Sohinhmas, Maloaimangs, Maqcthanhphams, Makhachs, Mahangs
			, 'Dungmay', Dungmay
		From dinhmucthoigian
	
	If (@v_Madongmay='TH')
	Begin
		Select @v_Doday=Doday From Dmmang Where Mamang=@Masanpham	

		Select @v_Thoigian=Giatri
		From @Dinhmuctg
		Where Tentruong = @Tentruong
			And (CHARINDEX(@Mamay+',',Mamays)>0 OR ISNULL(Mamays,'') = '')
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
			And (CHARINDEX(@Mamay+',',Mamays)>0 OR ISNULL(Mamays,'') = '')
			--And (CHARINDEX(@Macongdoan+',',Macongdoans)>0 OR ISNULL(Macongdoans,'') = '')
			And ((Dodaytu<=@v_Doday And Dodayden>=@v_Doday) Or (Dodaytu=0 And Dodayden=0))	
			And ((Khotu<=@v_Rong And Khoden>=@v_Rong) Or (Khotu=0 And Khoden=0))	
			And ((Chieudaitu<=@v_Dai And Chieudaiden>=@v_Dai) Or (Chieudaitu=0 And Chieudaiden=0))	
			AND	(CHARINDEX(@v_Sohinhma+',',Sohinhmas)>0 OR ISNULL(Sohinhmas,'') = '')
			AND	(CHARINDEX(@v_Somauma+',',Somaumas)>0 OR ISNULL(Somaumas,'') = '')
			AND (CHARINDEX(@v_Maqcthanhpham+',',Maqcthanhphams)>0 OR ISNULL(Maqcthanhphams,'') = '')			
			AND	(CHARINDEX(a.Maloaimang+',',dm.Maloaimangs)>0 OR ISNULL(dm.Maloaimangs,'') = '')
			AND (CHARINDEX(@v_Makhach+',',Makhachs)>0 OR ISNULL(Makhachs,'') = '')			
			AND (CHARINDEX(@Masanpham+',',Mahangs)>0 OR ISNULL(Mahangs,'') = '')		
	End

	RETURN ISNULL(@v_Thoigian,0);
END
	
Go

SELECT dbo.fTinhdinhmucthoigian('L1', 'SP 1450', 'Dauca') --('T1', 'CPP50x1120')

GO	

