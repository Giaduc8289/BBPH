------------------------Danh sach ket qua hoan thien-------------
If Object_ID('dbo.Danhsachketquahoanthien','P') is not null
	Drop Procedure dbo.Danhsachketquahoanthien;
Go

Create Procedure dbo.Danhsachketquahoanthien
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Ca			Int,
	@Mamay		Nvarchar(50),
	@Masp		NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Distinct Ngay, Ca, Mamay
	From dbo.Ketquahoanthien kq 
	Where Ngay Between @Tungay And @Denngay
		AND (Ca = @Ca OR @Ca = 0)
		AND	(Mamay = @Mamay Or @Mamay='')
		And (Masanpham = @Masp Or @Masp='')
		
GO

Exec Danhsachketquahoanthien '10/01/2022', '10/30/2022', 0, '', ''