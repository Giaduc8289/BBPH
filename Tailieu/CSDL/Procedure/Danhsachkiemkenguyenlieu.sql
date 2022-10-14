------------------------Danh sach kiem ke nguyên liệu-------------
If Object_ID('dbo.Danhsachkiemkenguyenlieu','P') is not null
	Drop Procedure dbo.Danhsachkiemkenguyenlieu;
Go

Create Procedure dbo.Danhsachkiemkenguyenlieu
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Makho		NVARCHAR(20)
	--@Mahang			Nvarchar(20)
As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Distinct Ngaykiemke, sp.Makho, sp.Tenkho
	From dbo.Sodunguyenlieu sp left join dbo.dmkho dm on sp.Makho = dm.Makho
	Where Ngaykiemke Between @Tungay And @Denngay
		AND	(sp.Makho = @Makho Or @Makho='')
		
GO

Exec Danhsachkiemkenguyenlieu '10/01/2022', '10/30/2022', ''