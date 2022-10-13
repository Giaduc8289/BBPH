------------------------Danh sach xuat san pham-------------
If Object_ID('dbo.Danhsachxuatsanpham','P') is not null
	Drop Procedure dbo.Danhsachxuatsanpham;
Go

Create Procedure dbo.Danhsachxuatsanpham
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Makho		NVARCHAR(20)
	--@Mahang			Nvarchar(20)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Distinct Ngayxuat, sp.Makho
	From dbo.Xuatkhosanpham sp left join dbo.dmkho dm on sp.Makho = dm.Makho
	Where Ngayxuat Between @Tungay And @Denngay
		AND	(sp.Makho = @Makho Or @Makho='')
		
GO

Exec Danhsachxuatsanpham '10/01/2020', '10/30/2020', ''


