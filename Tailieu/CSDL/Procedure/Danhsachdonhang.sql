------------------------Danh sách đơn hàng-------------
If Object_ID('dbo.Danhsachdonhang','P') is not null
	Drop Procedure dbo.Danhsachdonhang;
Go

Create Procedure dbo.Danhsachdonhang
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
	From dbo.Donhang_h
	Where Ngaydat BETWEEN @Tungay AND @Denngay
		AND (Madon=@Madondathang OR @Madondathang='')
		AND (Sobaogia = @Sobaogia OR @Sobaogia = '')
		AND (Makhach=@Makhachhang OR @Makhachhang='')
		AND	((Madon IN (SELECT DISTINCT Madon FROM dbo.Donhang_d WHERE  Masp=@Mahang)) OR @Mahang='')
	ORDER BY Ngaydat DESC
Go

Exec Danhsachdonhang '03/01/2021', '03/30/2023','','','',''
