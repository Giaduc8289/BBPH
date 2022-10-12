------------------------Danh sach Danhsachketquainchitiet-------------
If Object_ID('dbo.Danhsachketquainchitiet','P') is not null
	Drop Procedure dbo.Danhsachketquainchitiet;
Go

Create Procedure dbo.Danhsachketquainchitiet
	@Maketquain	NVARCHAR(50),
	@Masp		NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select * 
	FROM dbo.Ketquain
	WHERE (Id = @Maketquain OR @Maketquain = '')
		AND (Masanpham=@Masp OR @Masp='')

GO

Exec Danhsachketquainchitiet  '',''