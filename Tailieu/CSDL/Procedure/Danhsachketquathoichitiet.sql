------------------------Danh sach Danhsachketquathoichitiet-------------
If Object_ID('dbo.Danhsachketquathoichitiet','P') is not null
	Drop Procedure dbo.Danhsachketquathoichitiet;
Go

Create Procedure dbo.Danhsachketquathoichitiet
	@Maketquathoi	NVARCHAR(50),
	@Mamang			NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select * 
	FROM dbo.Ketquathoi
	WHERE (Id = @Maketquathoi OR @Maketquathoi = '')
		AND (Mamang=@Mamang OR @Mamang=''

GO

Exec Danhsachketquathoichitiet  '',''