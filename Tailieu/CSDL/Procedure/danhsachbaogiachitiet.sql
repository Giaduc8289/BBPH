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
	
	Select d.*
	From dbo.Baogia_d d Left Join baogia_h h on d.Sobaogia=h.Sobaogia
	Where Ngaybaogia BETWEEN @Tungay AND @Denngay
		AND (d.Sobaogia=@Sobaogia OR @Sobaogia='')
		AND	(d.Masp=@Mahang OR @Mahang='')
		AND	(Makhach=@Makhachhang OR @Makhachhang='')

Go

Exec Danhsachbaogiachitiet '03/01/2021', '03/30/2021','','',''
