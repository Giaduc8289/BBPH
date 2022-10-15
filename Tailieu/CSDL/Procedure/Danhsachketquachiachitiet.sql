------------------------Danh sach Danh sach ket qua chia chi tiet-------------
If Object_ID('dbo.Danhsachketquachiachitiet','P') is not null
	Drop Procedure dbo.Danhsachketquachiachitiet;
Go

Create Procedure dbo.Danhsachketquachiachitiet
	@Maketquathoi	NVARCHAR(50),
	@Ca				Int,
	@Masp		NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select * 
	FROM dbo.Ketquachia
	WHERE (Id = @Maketquathoi OR @Maketquathoi = '')
		AND (Ca = @Ca OR @Ca = 0)
		AND (Masanpham=@Masp OR @Masp='')

GO

Exec Danhsachketquachiachitiet  '', 0, ''