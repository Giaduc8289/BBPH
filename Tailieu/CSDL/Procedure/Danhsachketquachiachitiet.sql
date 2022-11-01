------------------------Danh sach Danh sach ket qua chia chi tiet-------------
If Object_ID('dbo.Danhsachketquachiachitiet','P') is not null
	Drop Procedure dbo.Danhsachketquachiachitiet;
Go

Create Procedure dbo.Danhsachketquachiachitiet
	@Ngay		Datetime,
	@Ca				Int,
	@Mamay		Nvarchar(50),
	@Masp		NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select * 
	FROM dbo.Ketquachia
	WHERE Ngay = @Ngay
		AND (Ca = @Ca OR @Ca = 0)
		AND	(Mamay = @Mamay Or @Mamay='')
		AND (Masanpham = @Masp OR @Masp='')

GO

Exec Danhsachketquachiachitiet  '10/15/2022', 0, '', ''