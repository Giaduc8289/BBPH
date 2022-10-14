------------------------Danh sach kiem ke san pham-------------
If Object_ID('dbo.Danhsachkiemkesanpham','P') is not null
	Drop Procedure dbo.Danhsachkiemkesanpham;
Go

Create Procedure dbo.Danhsachkiemkesanpham
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Makho		NVARCHAR(20)
	--@Mahang			Nvarchar(20)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Distinct Ngaykiemke, sp.Makho
	From dbo.Sodusanpham sp left join dbo.dmkho dm on sp.Makho = dm.Makho
	Where Ngaykiemke Between @Tungay And @Denngay
		AND	(sp.Makho = @Makho Or @Makho='')
		
GO

Exec Danhsachkiemkesanpham '10/01/2022', '10/30/2022', ''

