------------------------Danh sách báo giá-------------
If Object_ID('dbo.Danhsachbaogia','P') is not null
	Drop Procedure dbo.Danhsachbaogia;
Go

Create Procedure dbo.Danhsachbaogia
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Sobaogia		NVARCHAR(50),
	@Makhachhang	NVARCHAR(50),
	@Mahang			Nvarchar(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	Select *
	From dbo.Baogia_h
	Where Ngayhieuluc BETWEEN @Tungay AND @Denngay
		AND (Sobaogia=@Sobaogia OR @Sobaogia='')
		AND	(Makhach=@Makhachhang OR @Makhachhang='')
		AND	((Sobaogia IN (SELECT DISTINCT Sobaogia FROM dbo.Baogia_d WHERE  Masp=@Mahang)) OR @Mahang='')

Go

Exec Danhsachbaogia '01/01/2022', '12/30/2022','','',''
