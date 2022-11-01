------------------------Danh sach Danhsachnhapkhonguyenlieuchitiet-------------
If Object_ID('dbo.Danhsachketquatuachitiet','P') is not null
	Drop Procedure dbo.Danhsachketquatuachitiet;
Go

Create Procedure dbo.Danhsachketquatuachitiet
	@Ngay		Datetime,
	@Ca				Int,
	@Mamay		Nvarchar(50),
	@Masp		NVARCHAR(50)
As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select * 
	FROM dbo.Ketquatua
	WHERE Ngay = @Ngay
		AND (Ca = @Ca OR @Ca = 0)
		AND	(Mamay = @Mamay Or @Mamay='')
		AND (Masanpham = @Masp OR @Masp='')

GO

Exec Danhsachketquatuachitiet  '10/15/2022', 0, '', ''

