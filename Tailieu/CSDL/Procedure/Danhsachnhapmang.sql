------------------------Danh sach nhap mang-------------
If Object_ID('dbo.Danhsachnhapmang','P') is not null
	Drop Procedure dbo.Danhsachnhapmang;
Go

Create Procedure dbo.Danhsachnhapmang
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Makho		NVARCHAR(20)
	--@Mahang			Nvarchar(20)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Distinct Ngaynhap, sp.Makho
	From dbo.Nhapkhomang sp left join dbo.dmkho dm on sp.Makho = dm.Makho
	Where Ngaynhap Between @Tungay And @Denngay
		AND	(sp.Makho = @Makho Or @Makho='')
		
GO

Exec Danhsachnhapmang '10/01/2020', '10/30/2020', ''


