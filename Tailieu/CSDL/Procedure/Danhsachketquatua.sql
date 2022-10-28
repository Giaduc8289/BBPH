------------------------Danh sach nhap kho nguyên liệu-------------
If Object_ID('dbo.Danhsachketquatua','P') is not null
	Drop Procedure dbo.Danhsachketquatua;
Go

Create Procedure dbo.Danhsachketquatua
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Ca			Int,
	@Mamay		Nvarchar(50),
	@Lenhtua	NVARCHAR(50)
As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Distinct Ngay, Ca, Mamay
	From dbo.Ketquatua sp 
	Where Ngay Between @Tungay And @Denngay
		AND	(Ca = @Ca Or @Ca= 0)
		AND	(Mamay = @Mamay Or @Mamay='')
		AND	(Lenhtua = @Lenhtua Or @Lenhtua='')
		
GO

Exec Danhsachketquatua '10/01/2022', '10/30/2022', 0 , '', ''


