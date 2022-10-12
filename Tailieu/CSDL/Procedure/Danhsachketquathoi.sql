------------------------Danh sach ket qua in-------------
If Object_ID('dbo.Danhsachketquain','P') is not null
	Drop Procedure dbo.Danhsachketquain;
Go

Create Procedure dbo.Danhsachketquain
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Makhachhang	NVARCHAR(20),
	@Mahang			Nvarchar(20)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Distinct Id ,Ngay, Ca, Mamayin, Tenmay, Tendongmay, Phedet, Phecongnghe, Phein
	From dbo.Ketquain left join dbo.Mayin on Ketquain.Mamayin = Mayin.Mahieu
	Where Ngay Between @Tungay And @Denngay
		AND	(Id IN (SELECT DISTINCT Maketquain FROM dbo.Manhsudungin 
				WHERE (Makhachhang=@Makhachhang OR @Makhachhang='') AND (Mahang=@Mahang OR @Mahang=''))
			OR (@Makhachhang='' AND @Mahang=''))

GO

Exec Danhsachketquain '10/01/2020', '10/30/2020', '', ''