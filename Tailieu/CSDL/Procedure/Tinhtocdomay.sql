------------------------Hàm tính tốc độ máy-------------
If Object_ID('dbo.fTinhtocdomay','FN') is not null
	Drop FUNCTION dbo.fTinhtocdomay
Go

Create FUNCTION dbo.fTinhtocdomay(@Mamay Nvarchar(50), @Masanpham Nvarchar(50), @Mamang Nvarchar(50)) RETURNS DECIMAL(20,2)
AS
BEGIN

	Declare @v_Madongmay	Nvarchar(50),
			@v_Doday		Decimal(20,3),
			@v_Rong				Decimal(20,3),
			@v_Dai				Decimal(20,3),
			@v_Somauma				Nvarchar(50),
			@v_Sohinhma				Nvarchar(50),
			@v_Maloaimang			Nvarchar(MAX),
			@v_Maloaimangghep1		Nvarchar(50),
			@v_Maloaimangghep2		Nvarchar(MAX),
			@v_Maqcthanhpham		Nvarchar(50),
			@v_Makhach				Nvarchar(50),
			@v_Tocdo			Decimal(20,3)

	Select @v_Madongmay=Madm From dmmay Where Mamay=@Mamay
	
	If (@v_Madongmay='TH')
	Begin
		Select @v_Doday=Doday From Dmmang Where Mamang=@Masanpham	

		Select @v_Tocdo=Tocdo
		From congsuatmay
		Where (CHARINDEX(@Mamay+',',Mamays)>0 OR ISNULL(Mamays,'') = '')
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
		
		Set @v_Maloaimangghep1 = IsNull((Select Top 1 Maloaimang From dmmang Where Mamang=@Mamang),'')

		DECLARE @Loaimang2 TABLE (Maloaimang Nvarchar(50))
		INSERT INTO @Loaimang2(Maloaimang)
			Select Distinct Maloaimang
			From mangcuahang 
			Where Masp=@Masanpham And Mamang != @Mamang

		Select @v_Maloaimangghep2
			= STUFF((Select ',' + Maloaimang
					From @Loaimang2 t1
					For XML Path('')), 1, Len(','), '')
	
		DECLARE @Loaimang TABLE (Maloaimang Nvarchar(50))
		INSERT INTO @Loaimang(Maloaimang)
			Select Distinct Maloaimang
			From mangcuahang 
			Where Masp=@Masanpham 

		Select @v_Maloaimang
			= STUFF((Select ',' + Maloaimang
					From @Loaimang t1
					For XML Path('')), 1, Len(','), '')

		Select @v_Tocdo=Min(Tocdo)
		From congsuatmay cs, (Select Value As Maloaimang From dbo.SplitString(@v_Maloaimang,',')) a
			, (Select Value As Maloaimang2 From dbo.SplitString(@v_Maloaimangghep2,',')) b
		Where (CHARINDEX(@Mamay+',',Mamays)>0 OR ISNULL(Mamays,'') = '')
			--And (CHARINDEX(@Macongdoan+',',Macongdoans)>0 OR ISNULL(Macongdoans,'') = '')
			And ((Dodaytu<=@v_Doday And Dodayden>=@v_Doday) Or (Dodaytu=0 And Dodayden=0))	
			And ((Khotu<=@v_Rong And Khoden>=@v_Rong) Or (Khotu=0 And Khoden=0))	
			And ((Chieudaitu<=@v_Dai And Chieudaiden>=@v_Dai) Or (Chieudaitu=0 And Chieudaiden=0))	
			AND	(CHARINDEX(@v_Sohinhma+',',Sohinhmas)>0 OR ISNULL(Sohinhmas,'') = '')
			AND	(CHARINDEX(@v_Somauma+',',Somaumas)>0 OR ISNULL(Somaumas,'') = '')
			AND (CHARINDEX(@v_Maqcthanhpham+',',Maqcthanhphams)>0 OR ISNULL(Maqcthanhphams,'') = '')			
			AND	(CHARINDEX(a.Maloaimang+',',cs.Maloaimangs1)>0 OR ISNULL(cs.Maloaimangs1,'') = '')
			AND (CHARINDEX(@v_Makhach+',',Makhachs)>0 OR ISNULL(Makhachs,'') = '')			
			AND (CHARINDEX(@Masanpham+',',Mahangs)>0 OR ISNULL(Mahangs,'') = '')	
			AND (
					(
						(CHARINDEX(@v_Maloaimangghep1+',',cs.Maloaimangs1)>0 OR ISNULL(cs.Maloaimangs1,'') = '') 
						And 
						(CHARINDEX(b.Maloaimang2+',',cs.Maloaimangs2)>0	OR IsNull(cs.Maloaimangs2,'') = '')
					)
					OR
					(
						(CHARINDEX(@v_Maloaimangghep1+',',cs.Maloaimangs2)>0 OR ISNULL(cs.Maloaimangs2,'') = '') 
						And 
						(CHARINDEX(b.Maloaimang2+',',cs.Maloaimangs1)>0	OR IsNull(cs.Maloaimangs1,'') = '')
					)
				)

	End

	RETURN ISNULL(@v_Tocdo,0);
END
	
Go

SELECT dbo.fTinhtocdomay('G2', 'SP 1566', 'PE 85x800') --('T1', 'CPP50x1120')

GO	

