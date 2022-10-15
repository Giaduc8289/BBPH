------------------------Danh sach nhap kho nguyên liệu-------------
If Object_ID('dbo.Danhsachketquatua','P') is not null
	Drop Procedure dbo.Danhsachketquatua;
Go

Create Procedure dbo.Danhsachketquatua
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Ca			Int,
	@Lenhtua	NVARCHAR(50)
	--@Mahang			Nvarchar(20)
As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Distinct Ngay, Ca, Lenhtua
	From dbo.Ketquatua sp left join dbo.dmmay dm on sp.Mamay = dm.Mamay
	Where Ngay Between @Tungay And @Denngay
		AND	(Ca = @Ca Or @Ca= 0)
		AND	(Lenhtua = @Lenhtua Or @Lenhtua='')
		
GO

Exec Danhsachketquatua '10/01/2022', '10/30/2022', 0 , ''


