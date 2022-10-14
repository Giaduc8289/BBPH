------------------------Danh sach ket qua thổi-------------
If Object_ID('dbo.Danhsachketquathoi','P') is not null
	Drop Procedure dbo.Danhsachketquathoi;
Go

Create Procedure dbo.Danhsachketquathoi
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Ca			Int,
	@Mamang		NVARCHAR(20)
	--@Mahang			Nvarchar(20)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Distinct Ngay, Ca, kq.Mamay
	From dbo.Ketquathoi kq left join dbo.dmmay dm on kq.Mamay = dm.Mamay
	Where Ngay Between @Tungay And @Denngay
		AND (Ca = @Ca OR @Ca = 0)
		AND	(Mamang = @Mamang Or @Mamang='')
		
GO

Exec Danhsachketquathoi '10/01/2022', '10/30/2022', 0, ''


