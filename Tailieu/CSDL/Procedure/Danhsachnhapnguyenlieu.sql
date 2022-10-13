------------------------Danh sach nhap kho nguyên liệu-------------
If Object_ID('dbo.Danhsachnhapkhonguyenlieu','P') is not null
	Drop Procedure dbo.Danhsachnhapkhonguyenlieu;
Go

Create Procedure dbo.Danhsachnhapkhonguyenlieu
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Makho		NVARCHAR(20)
	--@Mahang			Nvarchar(20)
As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Distinct Ngaynhap, sp.Makho, sp.Tenkho, Malydo, Tenlydo
	From dbo.Nhapkhonguyenlieu sp left join dbo.dmkho dm on sp.Makho = dm.Makho
	Where Ngaynhap Between @Tungay And @Denngay
		AND	(sp.Makho = @Makho Or @Makho='')
		
GO

Exec Danhsachnhapkhonguyenlieu '10/01/2022', '10/30/2022', ''


