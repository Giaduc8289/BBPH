------------------------Danh sách đơn hàng chi tiết-------------
If Object_ID('dbo.Danhsachdonhangchitiet','P') is not null
	Drop Procedure dbo.Danhsachdonhangchitiet;
Go

Create Procedure dbo.Danhsachdonhangchitiet
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Madondathang		NVARCHAR(50),
	@Sobaogia			NVARCHAR(50),
	@Makhachhang	NVARCHAR(50),
	@Mahang			Nvarchar(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select *
	From dbo.Donhang_d
	Where Ngaydat BETWEEN @Tungay AND @Denngay
		AND (Madon=@Madondathang OR @Madondathang='')
		AND (Sobaogia = @Sobaogia OR @Sobaogia = '')
		AND (Masp=@Mahang OR @Mahang='')
		AND	(Makhach=@Makhachhang OR @Makhachhang='')

Go

Exec Danhsachdonhangchitiet '03/01/2021', '05/30/2021','','','',''
