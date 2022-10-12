------------------------Danh sách báo giá chi tiết-------------
If Object_ID('dbo.Danhsachbaogiachitiet','P') is not null
	Drop Procedure dbo.Danhsachbaogiachitiet;
Go

Create Procedure dbo.Danhsachbaogiachitiet
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Sobaogia		NVARCHAR(50),
	@Makhachhang	NVARCHAR(50),
	@Mahang			Nvarchar(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select dbo.Baogia_d.*, dmhang.Makhach Makhach
	From dbo.Baogia_d LEFT JOIN dbo.dmhang ON dmhang.Masp = Baogia_d.Masp
	Where Baogia_d.Ngaytao BETWEEN @Tungay AND @Denngay
		AND (Sobaogia=@Sobaogia OR @Sobaogia='')
		AND	(Baogia_d.Masp=@Mahang OR @Mahang='')
		AND	(Makhach=@Makhachhang OR @Makhachhang='')

Go

Exec Danhsachbaogiachitiet '03/01/2021', '03/30/2021','','',''
