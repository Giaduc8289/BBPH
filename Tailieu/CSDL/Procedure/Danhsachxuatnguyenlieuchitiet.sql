------------------------Danh sach Danhsachxuatnguyenlieuchitiet-------------
If Object_ID('dbo.Danhsachxuatnguyenlieuchitiet','P') is not null
	Drop Procedure dbo.Danhsachxuatnguyenlieuchitiet;
Go

Create Procedure dbo.Danhsachxuatnguyenlieuchitiet
	@Manhapkho	NVARCHAR(50),
	@Manguyenlieu		NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select * 
	FROM dbo.Xuatkhonguyenlieu
	WHERE (Id = @Manhapkho OR @Manhapkho = '')
		AND (Manguyenlieu=@Manguyenlieu OR @Manguyenlieu='')

GO

Exec Danhsachxuatnguyenlieuchitiet  '',''