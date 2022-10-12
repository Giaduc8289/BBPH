------------------------Danh sach ket qua in-------------
If Object_ID('dbo.Danhsachketquain','P') is not null
	Drop Procedure dbo.Danhsachketquain;
Go

Create Procedure dbo.Danhsachketquain
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Masp		NVARCHAR(20)
	--@Mahang			Nvarchar(20)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Distinct Ngay, Ca, kq.Mamay
	From dbo.Ketquain kq left join dbo.dmmay dm on kq.Mamay = dm.Mamay
	Where Ngay Between @Tungay And @Denngay
		AND	(Masanpham = @Masp Or @Masp='')
		
GO

Exec Danhsachketquain '10/01/2020', '10/30/2020', ''


