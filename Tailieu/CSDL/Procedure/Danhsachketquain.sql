------------------------Danh sach ket qua in-------------
If Object_ID('dbo.Danhsachketquain','P') is not null
	Drop Procedure dbo.Danhsachketquain;
Go

Create Procedure dbo.Danhsachketquain
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Ca			Int,
	@Mamay		Nvarchar(50),
	@Masp		NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Distinct Ngay, Ca, Mamay
	From dbo.Ketquain kq 
	Where Ngay Between @Tungay And @Denngay
		AND (Ca = @Ca OR @Ca = 0)
		AND	(Mamay = @Mamay Or @Mamay='')
		AND	(Masanpham = @Masp Or @Masp='')
		
GO

Exec Danhsachketquain '10/01/2022', '10/30/2022', 0, '', ''


