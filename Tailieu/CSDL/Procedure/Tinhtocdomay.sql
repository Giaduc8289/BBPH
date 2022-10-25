------------------------Hàm tính tốc độ máy-------------
If Object_ID('dbo.fTinhtocdomay','FN') is not null
	Drop FUNCTION dbo.fTinhtocdomay
Go

Create FUNCTION dbo.fTinhtocdomay(@Mamay Nvarchar(50), @Masanpham Nvarchar(50)) RETURNS DECIMAL(20,2)
AS
BEGIN

	Declare @v_Madongmay	Nvarchar(50),
			@v_Doday		Decimal(20,3),
			@v_Rong				Decimal(20,3),
			@v_Dai				Decimal(20,3),
			@v_Somauma				Nvarchar(50),
			@v_Sohinhma				Nvarchar(50),
			@v_Maloaimang			Nvarchar(50),
			@v_Maqcthanhpham		Nvarchar(50),
			@v_Tocdo			Decimal(20,3)

	Select @v_Madongmay=Madm From dmmay Where Mamay=@Mamay
	
	If (@v_Madongmay='TH')
	Begin
		Select @v_Doday=Doday From Dmmang Where Mamang=@Masanpham	

		Select @v_Tocdo=Tocdo
		From congsuatmay
		Where (Mamay=@Mamay Or Mamay='')
			And ((Dodaytu<=@v_Doday And Dodayden>=@v_Doday) Or (Dodaytu=0 And Dodayden=0))	
	End
	Else
	Begin
		Select @v_Doday=Doday, @v_Rong=Rong, @v_Dai=Dai
			, @v_Somauma=Somauma, @v_Sohinhma=Sohinhma, @v_Maqcthanhpham=Maqcthanhpham
		From dmhang Where Masp=@Masanpham
		
		Select @v_Tocdo=Tocdo
		From congsuatmay
		Where (Mamay=@Mamay Or Mamay='')
			And (Madongmay=@v_Madongmay Or Madongmay='')
			And ((Dodaytu<=@v_Doday And Dodayden>=@v_Doday) Or (Dodaytu=0 And Dodayden=0))	
			And ((Khotu<=@v_Rong And Khoden>=@v_Rong) Or (Khotu=0 And Khoden=0))	
			And ((Chieudaitu<=@v_Dai And Chieudaiden>=@v_Dai) Or (Chieudaitu=0 And Chieudaiden=0))	
			AND	(CHARINDEX(@v_Sohinhma+',',Sohinhma)>0 OR ISNULL(Sohinhma,'') = '')
			AND	(CHARINDEX(@v_Somauma+',',Somauma)>0 OR ISNULL(Somauma,'') = '')
			AND (CHARINDEX(@v_Maqcthanhpham+',',Maqcthanhpham)>0 OR ISNULL(Maqcthanhpham,'') = '')			
	End

	RETURN ISNULL(@v_Tocdo,0);
END
	
Go

SELECT dbo.fTinhtocdomay('T1', 'PE20x850')

GO	

