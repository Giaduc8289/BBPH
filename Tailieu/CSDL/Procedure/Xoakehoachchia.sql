------------------------Xóa kế hoạch chia-------------
If Object_ID('dbo.Xoakehoachchia','P') is not null
	Drop Procedure dbo.Xoakehoachchia
Go

Create Procedure dbo.Xoakehoachchia
	@Solenhsx		NVARCHAR(20),
	@Tungay			DATE,
	@Denngay		DATE
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Delete Kehoachchia 
	Where (Solenhsx = @Solenhsx OR @Solenhsx='')  
		And Ngaychay Between @Tungay And @Denngay

Go


Exec Xoakehoachchia '', '', ''

