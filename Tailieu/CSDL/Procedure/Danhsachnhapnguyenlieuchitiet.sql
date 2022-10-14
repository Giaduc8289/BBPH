------------------------Danh sach Danhsachnhapkhonguyenlieuchitiet-------------
If Object_ID('dbo.Danhsachnhapkhonguyenlieuchitiet','P') is not null
	Drop Procedure dbo.Danhsachnhapkhonguyenlieuchitiet;
Go

Create Procedure dbo.Danhsachnhapkhonguyenlieuchitiet
	@Ngay		Datetime,
	@Makho		NVARCHAR(20),
	@Manguyenlieu		NVARCHAR(50),
	@Malydo				NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select * 
	FROM dbo.Nhapkhonguyenlieu
	WHERE Ngaynhap = @Ngay
		AND (Makho=@Makho OR @Makho='')
		AND (Manguyenlieu=@Manguyenlieu OR @Manguyenlieu='')
		AND (Malydo=@Malydo OR @Malydo='')

GO

Exec Danhsachnhapkhonguyenlieuchitiet  '10/10/2022', '', '', ''

