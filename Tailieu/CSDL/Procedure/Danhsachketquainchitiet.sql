------------------------Danh sach Danhsachketquainchitiet-------------
If Object_ID('dbo.Danhsachketquainchitiet','P') is not null
	Drop Procedure dbo.Danhsachketquainchitiet;
Go

Create Procedure dbo.Danhsachketquainchitiet
	@Ngay		Datetime,
	@Ca				Int,
	@Mamay		Nvarchar(50),
	@Masp		NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select * 
	FROM dbo.Ketquain
	WHERE Ngay = @Ngay
		AND (Ca = @Ca OR @Ca = 0)
		AND	(Mamay = @Mamay Or @Mamay='')
		AND (Masanpham = @Masp OR @Masp='')

GO

Exec Danhsachketquainchitiet  '10/15/2022', 0, '', ''