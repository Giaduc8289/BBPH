------------------------Danh sách phiếu giao hàng-------------
If Object_ID('dbo.Danhsachthongkenguyenlieu','P') is not null
	Drop Procedure dbo.Danhsachthongkenguyenlieu;
Go

Create Procedure dbo.Danhsachthongkenguyenlieu
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Manguyenlieu	Nvarchar(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	Select distinct Ngay, Ca
	From dbo.Tknguyenlieuthoi
	Where Ngay BETWEEN @Tungay AND @Denngay
		AND (Manguyenlieu=@Manguyenlieu OR @Manguyenlieu='')	

Go

Exec Danhsachthongkenguyenlieu '10/01/2022', '10/31/2022',''
