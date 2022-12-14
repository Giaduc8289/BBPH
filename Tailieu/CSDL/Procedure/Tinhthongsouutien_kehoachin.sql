------------------------Danh sách đơn hàng-------------
If Object_ID('dbo.Tinhthongsouutien_kehoachin','P') is not null
	Drop Procedure dbo.Tinhthongsouutien_kehoachin;
Go

Create Procedure dbo.Tinhthongsouutien_kehoachin
	@Masanpham			NVARCHAR(50),
	@Masanphamtruoc		NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	Declare @v_Solanthayhemuc	Int,
			@v_Solanthaylo		Int,
			@v_Solanthaymau		Int,
			@v_Solanthaytruc	Int,
			@v_Hemuc			Nvarchar(50),
			@v_Hemuctruoc		Nvarchar(50),
			@v_Khomang			Decimal(20,3),
			@v_Khomangtruoc		Decimal(20,3)
	
	-----Tính số lần thay hệ mực
	Select @v_Hemuc=Maloaimuc From dmhang Where Masp=@Masanpham
	Select @v_Hemuctruoc=Maloaimuc From dmhang Where Masp=@Masanphamtruoc
	Set @v_Solanthayhemuc=1
	If(@v_Hemuc=@v_Hemuctruoc) Set @v_Solanthayhemuc=0
	
	-----Tính số lần thay lô
	Select @v_Khomang=Khomang From dmhang Where Masp=@Masanpham
	Select @v_Khomangtruoc=Khomang From dmhang Where Masp=@Masanphamtruoc
	Set @v_Solanthaylo=1
	If(@v_Khomang=@v_Khomangtruoc) Set @v_Solanthaylo=0
	
	-----Tính số lần thay mực
	Select @v_Solanthaymau=Count(*)
	From Maucuahang 
	Where Masp=@Masanpham
		And Mamau Not In (Select Mamau From maucuahang Where Masp=@Masanphamtruoc)
	
	-----Tính số lần thay trục
	Select @v_Solanthaytruc=Count(*)
	From Truccuahang 
	Where Masp=@Masanpham
		And Matruc Not In (Select Matruc From Truccuahang Where Masp=@Masanphamtruoc)
	
	Select @v_Solanthayhemuc As Solanthayhemuc, @v_Solanthaylo As Solanthaylo
		, @v_Solanthaymau As Solanthaymau, @v_Solanthaytruc As Solanthaytruc
		--, @v_Hemuc, @v_Hemuctruoc, @v_Khomang, @v_Khomangtruoc
	
Go

Exec Tinhthongsouutien_kehoachin 'Sp 1450', ''
Exec Tinhthongsouutien_kehoachin 'Sp 1566', ''
Exec Tinhthongsouutien_kehoachin 'Sp 1450', 'Sp 1566'
Exec Tinhthongsouutien_kehoachin 'Sp 1450', 'Sp 1450'
Exec Tinhthongsouutien_kehoachin 'Sp 1566', 'Sp 1566'

Select * from dmhang where masp in ('Sp 1450', 'Sp 1566')
--Select * from truccuahang