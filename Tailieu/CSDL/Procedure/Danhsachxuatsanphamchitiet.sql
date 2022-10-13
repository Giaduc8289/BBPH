------------------------Danh sach Danhsachxuatsanphamchitiet-------------
If Object_ID('dbo.Danhsachxuatsanphamchitiet','P') is not null
	Drop Procedure dbo.Danhsachxuatsanphamchitiet;
Go

Create Procedure dbo.Danhsachxuatsanphamchitiet
	@Manhapkho	NVARCHAR(50),
	@Masp		NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select * 
	FROM dbo.Xuatkhosanpham
	WHERE (Id = @Manhapkho OR @Manhapkho = '')
		AND (Masanpham=@Masp OR @Masp='')

GO

Exec Danhsachxuatsanphamchitiet  '',''