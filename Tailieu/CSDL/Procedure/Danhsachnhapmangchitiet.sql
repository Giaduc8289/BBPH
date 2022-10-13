------------------------Danh sach Danhsachnhapmangchitiet-------------
If Object_ID('dbo.Danhsachnhapmangchitiet','P') is not null
	Drop Procedure dbo.Danhsachnhapmangchitiet;
Go

Create Procedure dbo.Danhsachnhapmangchitiet
	@Manhapkho	NVARCHAR(50),
	@Mamang		NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select * 
	FROM dbo.Nhapkhomang
	WHERE (Id = @Manhapkho OR @Manhapkho = '')
		AND (Mamang=@Mamang OR @Mamang='')

GO

Exec Danhsachnhapmangchitiet  '',''