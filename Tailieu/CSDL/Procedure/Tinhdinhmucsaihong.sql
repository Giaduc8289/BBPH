------------------------Hàm tính định mức sai hỏng-------------
If Object_ID('dbo.fTinhdinhmucsaihong','FN') is not null
	Drop FUNCTION dbo.fTinhdinhmucsaihong
Go

Create FUNCTION dbo.fTinhdinhmucsaihong(@Mamay Nvarchar(50), @Masanpham Nvarchar(50), @Manhomdinhmuc Nvarchar(50)) RETURNS DECIMAL(20,2)
AS
BEGIN

	Declare @v_Madongmay	Nvarchar(50),
			@v_Somauma				Nvarchar(50),
			@v_Maloaimuc			Nvarchar(50),
			@v_Maloaimang			Nvarchar(50),
			@v_Maqcthanhpham		Nvarchar(50),
			@v_Dinhmuc			Decimal(20,3)

	Select @v_Madongmay=Madm From dmmay Where Mamay=@Mamay
	
	If (@v_Madongmay='TH')
	Begin
		Select @v_Dinhmuc=Dinhmuc
		From dinhmucvattu
		Where Manhom = @Manhomdinhmuc
			And (Mamay=@Mamay Or Mamay='')
			And (Madongmay=@v_Madongmay Or Madongmay='')	
	End
	Else
	Begin
		Select @v_Somauma=Somauma, @v_Maloaimuc=Maloaimuc, @v_Maqcthanhpham=Maqcthanhpham
		From dmhang Where Masp=@Masanpham
	
		Select @v_Dinhmuc=Dinhmuc
		From dinhmucvattu
		Where Manhom = @Manhomdinhmuc
			And (Mamay=@Mamay Or Mamay='')
			And (Madongmay=@v_Madongmay Or Madongmay='')
			AND	(CHARINDEX(@v_Somauma+',',Somauma)>0 OR ISNULL(Somauma,'') = '')
			AND	(CHARINDEX(@v_Maloaimuc+',',Maloaimuc)>0 OR ISNULL(Maloaimuc,'') = '')
			AND (CHARINDEX(@v_Maqcthanhpham+',',Maqcthanhpham)>0 OR ISNULL(Maqcthanhpham,'') = '')			
	End
	
	RETURN ISNULL(@v_Dinhmuc,0);
END
	
Go

SELECT dbo.fTinhdinhmucsaihong('I2', 'sp 1042', 'DM02')

GO	

