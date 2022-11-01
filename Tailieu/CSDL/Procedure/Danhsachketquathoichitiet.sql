------------------------Danh sach Danhsachketquathoichitiet-------------
If Object_ID('dbo.Danhsachketquathoichitiet','P') is not null
	Drop Procedure dbo.Danhsachketquathoichitiet;
Go

Create Procedure dbo.Danhsachketquathoichitiet
	@Ngay		Datetime,
	@Ca				Int,
	@Mamay		Nvarchar(50),
	@Mamang			NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select * 
	FROM dbo.Ketquathoi
	WHERE Ngay = @Ngay
		AND (Ca = @Ca OR @Ca = 0)
		AND	(Mamay = @Mamay Or @Mamay='')
		AND (Mamang=@Mamang OR @Mamang='')

GO

Exec Danhsachketquathoichitiet  '10/15/2022', 0, '', ''