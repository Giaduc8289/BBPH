------------------------Danh sach lọc màng theo sản phẩm-------------
If Object_ID('dbo.Danhsachlocmangtheosp','P') is not null
	Drop Procedure dbo.Danhsachlocmangtheosp;
Go

Create Procedure dbo.Danhsachlocmangtheosp
	@Ngayphatlenh		Date,
	@Masanpham		NVARCHAR(50)
As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Masp, Tensp, Mamang, Tenmang, dbo.fTinhtonmang(@Ngayphatlenh, Mamang) As Ton
		, IsNull((Select Sum(Sokgsudung) From Mangtheolenh Where Mamangquydinh=Mamang and Mamangsudung=Mamang),convert(numeric(20,2),0.00)) As Sokgsudung
		, IsNull((Select Top 1 Id From Mangtheolenh Where Mamangquydinh=Mamang and Mamangsudung=Mamang),NULL) As Id
	FROM dbo.mangcuahang 
	WHERE Masp = @Masanpham
	
GO

Exec Danhsachlocmangtheosp  '12/01/2022','Sp 1566'
