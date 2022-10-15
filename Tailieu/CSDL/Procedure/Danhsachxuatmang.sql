------------------------Danh sach xuat mang-------------
If Object_ID('dbo.Danhsachxuatmang','P') is not null
	Drop Procedure dbo.Danhsachxuatmang;
Go

Create Procedure dbo.Danhsachxuatmang
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Makho		NVARCHAR(20)
	--@Mahang			Nvarchar(20)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Distinct Ngayxuat, sp.Makho
	From dbo.Xuatkhomang sp left join dbo.dmkho dm on sp.Makho = dm.Makho
	Where Ngayxuat Between @Tungay And @Denngay
		AND	(sp.Makho = @Makho Or @Makho='')
		
GO

Exec Danhsachxuatmang '10/01/2022', '10/30/2022', ''



