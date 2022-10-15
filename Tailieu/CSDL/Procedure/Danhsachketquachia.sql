------------------------Danh sach ket qua chia-------------
If Object_ID('dbo.Danhsachketquachia','P') is not null
	Drop Procedure dbo.Danhsachketquachia;
Go

Create Procedure dbo.Danhsachketquachia
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Ca			Int,
	@Masp		NVARCHAR(20)
	--@Mahang			Nvarchar(20)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Distinct Ngay, Ca, kq.Mamay, Masanpham
	From dbo.Ketquachia kq left join dbo.dmmay dm on kq.Mamay = dm.Mamay left join dbo.dmhang hang on kq.Masanpham = hang.Masp left join dbo.dmcongnhan cn on kq.Macongnhan = cn.Macn
	Where Ngay Between @Tungay And @Denngay
		AND (Ca = @Ca OR @Ca = 0)
		AND	(Masanpham = @Masp Or @Masp='')
		
GO

Exec Danhsachketquachia '10/01/2022', '10/30/2022', 0, ''