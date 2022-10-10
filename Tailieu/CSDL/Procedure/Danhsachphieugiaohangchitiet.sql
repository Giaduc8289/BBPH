------------------------Danh sách phiếu giao hàng chi tiết-------------
If Object_ID('dbo.Danhsachphieugiaohangchitiet','P') is not null
	Drop Procedure dbo.Danhsachphieugiaohangchitiet;
Go

Create Procedure dbo.Danhsachphieugiaohangchitiet
	@Tungay			DATETIME,
	@Denngay		DATETIME,
	@Sophieugiao		NVARCHAR(50),
	@Madonhang		NVARCHAR(50),
	@Makhachhang	NVARCHAR(50),
	@Mahang			Nvarchar(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select ct.*--, dhct.Sopo, dhct.Ngayhethanpo
	From dbo.Phieugiaohang_d ct LEFT JOIN dbo.Phieugiaohang_h h ON h.Sophieu = ct.Sophieu 
		LEFT JOIN dbo.Donhang_d dhct ON ct.Donchitiet_Id = dhct.Id
	Where ct.Ngaygiao BETWEEN @Tungay AND @Denngay
		AND (ct.Sophieu=@Sophieugiao OR @Sophieugiao='')
		AND (ct.Madon=@Madonhang OR @Madonhang='')
		AND (ct.Makhach=@Makhachhang OR @Makhachhang='')
		AND (ct.Masp=@Mahang OR @Mahang='')

Go

Exec Danhsachphieugiaohangchitiet '04/01/2021', '04/30/2021','','','',''