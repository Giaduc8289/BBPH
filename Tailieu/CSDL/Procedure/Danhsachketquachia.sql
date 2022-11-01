------------------------Danh sach ket qua chia-------------
If Object_ID('dbo.Danhsachketquachia','P') is not null
	Drop Procedure dbo.Danhsachketquachia;
Go

Create Procedure dbo.Danhsachketquachia
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Ca			Int,
	@Mamay		Nvarchar(50),
	@Masp		NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Distinct Ngay, Ca, Mamay
	From dbo.Ketquachia kq 
	Where Ngay Between @Tungay And @Denngay
		AND (Ca = @Ca OR @Ca = 0)
		AND	(Mamay = @Mamay Or @Mamay='')
		AND	(Masanpham = @Masp Or @Masp='')
		
GO

Exec Danhsachketquachia '10/01/2022', '10/30/2022', 0, '', ''