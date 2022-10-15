------------------------Danh sach Danhsachxuatmangchitiet-------------
If Object_ID('dbo.Danhsachxuatmangchitiet','P') is not null
	Drop Procedure dbo.Danhsachxuatmangchitiet;
Go

Create Procedure dbo.Danhsachxuatmangchitiet
	@Manhapkho	NVARCHAR(50),
	@Mamang		NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select * 
	FROM dbo.Xuatkhomang
	WHERE (Id = @Manhapkho OR @Manhapkho = '')
		AND (Mamang=@Mamang OR @Mamang='')

GO

Exec Danhsachxuatmangchitiet  '',''