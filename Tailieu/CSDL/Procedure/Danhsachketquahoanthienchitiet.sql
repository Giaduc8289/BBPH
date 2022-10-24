------------------------Danh sach Danh sach ket qua hoan thien chi tiet-------------
If Object_ID('dbo.Danhsachketquahoanthienchitiet','P') is not null
	Drop Procedure dbo.Danhsachketquahoanthienchitiet;
Go

Create Procedure dbo.Danhsachketquahoanthienchitiet
	@Maketquathoi	NVARCHAR(50),
	@Ca				Int,
	@Masp		NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select * 
	FROM dbo.Ketquathanhpham
	WHERE (Id = @Maketquathoi OR @Maketquathoi = '')
		AND (Ca = @Ca OR @Ca = 0)
		AND (Masanpham=@Masp OR @Masp='')

GO

Exec Danhsachketquahoanthienchitiet  '', 0, ''