------------------------Danh sach Danh sach ket qua ghep chi tiet-------------
If Object_ID('dbo.Danhsachketquaghepchitiet','P') is not null
	Drop Procedure dbo.Danhsachketquaghepchitiet;
Go

Create Procedure dbo.Danhsachketquaghepchitiet
	@Ngay		Datetime,
	@Ca				Int,
	@Mamay		Nvarchar(50),
	@Masp		NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select * 
	FROM dbo.Ketquaghep
	WHERE Ngay = @Ngay
		AND (Ca = @Ca OR @Ca = 0)
		AND	(Mamay = @Mamay Or @Mamay='')
		AND (Masanpham = @Masp OR @Masp='')

GO

Exec Danhsachketquaghepchitiet  '10/15/2022', 0, '', ''