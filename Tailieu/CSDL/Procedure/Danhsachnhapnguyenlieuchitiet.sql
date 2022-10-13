------------------------Danh sach Danhsachnhapmangchitiet-------------
If Object_ID('dbo.Danhsachnhapnguyenlieuchitiet','P') is not null
	Drop Procedure dbo.Danhsachnhapnguyenlieuchitiet;
Go

Create Procedure dbo.Danhsachnhapnguyenlieuchitiet
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

Exec Danhsachnhapnguyenlieuchitiet  '10/10/2022', '', '', ''

