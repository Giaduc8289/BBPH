------------------------Danh sach Danhsachnhapsanphamchitiet-------------
If Object_ID('dbo.Danhsachnhapsanphamchitiet','P') is not null
	Drop Procedure dbo.Danhsachnhapsanphamchitiet;
Go

Create Procedure dbo.Danhsachnhapsanphamchitiet
	@Manhapkho	NVARCHAR(50),
	@Masp		NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select * 
	FROM dbo.Nhapkhosanpham
	WHERE (Id = @Manhapkho OR @Manhapkho = '')
		AND (Masanpham=@Masp OR @Masp='')

GO

Exec Danhsachnhapsanphamchitiet  '',''