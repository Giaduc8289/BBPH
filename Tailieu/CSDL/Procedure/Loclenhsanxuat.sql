------------------------Danh sach lọc lệnh sản xuất-------------
If Object_ID('dbo.Loclenhsanxuat','P') is not null
	Drop Procedure dbo.Loclenhsanxuat;
Go

Create Procedure dbo.Loclenhsanxuat
	@Tungay		Datetime,
	@Denngay	Datetime
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select *
	From dbo.Lenhsanxuat 
	Where Ngayphatlenh Between @Tungay And @Denngay
		
		
GO

Exec Loclenhsanxuat '10/01/2022', '10/30/2022'


