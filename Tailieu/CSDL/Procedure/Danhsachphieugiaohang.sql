------------------------Danh sách phiếu giao hàng-------------
If Object_ID('dbo.Danhsachphieugiaohang','P') is not null
	Drop Procedure dbo.Danhsachphieugiaohang;
Go

Create Procedure dbo.Danhsachphieugiaohang
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Sophieugiao		NVARCHAR(50),
	@Madonhang		NVARCHAR(50),
	@Makhachhang	NVARCHAR(50),
	@Mahang			Nvarchar(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	Select *
	From dbo.Phieugiaohang_h
	Where Ngaygiao BETWEEN @Tungay AND @Denngay
		AND (Sophieu=@Sophieugiao OR @Sophieugiao='')	
		AND (Madon=@Madonhang OR @Madonhang='')
		AND (Makhach=@Makhachhang OR @Makhachhang='')
		AND	((Sophieu IN (SELECT DISTINCT Sophieu FROM dbo.Phieugiaohang_d WHERE Masp=@Mahang)) OR @Mahang='')

Go

Exec Danhsachphieugiaohang '03/01/2021', '03/31/2021','','','',''
--SELECT * FROM Phieugiaohang_h
--SELECT * FROM dbo.Phieugiaohang_d
