------------------------Danh sach Danh sach ket qua hoan thien chi tiet-------------
If Object_ID('dbo.Danhsachketquahoanthienchitiet','P') is not null
	Drop Procedure dbo.Danhsachketquahoanthienchitiet;
Go

Create Procedure dbo.Danhsachketquahoanthienchitiet
	@Ngay		Datetime,
	@Ca				Int,
	@Mamay		Nvarchar(50),
	@Masp		NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select * 
	FROM dbo.Ketquahoanthien
	WHERE Ngay = @Ngay
		AND (Ca = @Ca OR @Ca = 0)
		AND	(Mamay = @Mamay Or @Mamay='')
		AND (Masanpham = @Masp OR @Masp='')

GO

Exec Danhsachketquahoanthienchitiet  '10/15/2022', 0, '', ''