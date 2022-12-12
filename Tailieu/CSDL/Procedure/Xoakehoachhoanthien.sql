------------------------Xóa kế hoạch hoàn thiện-------------
If Object_ID('dbo.Xoakehoachhoanthien','P') is not null
	Drop Procedure dbo.Xoakehoachhoanthien
Go

Create Procedure dbo.Xoakehoachhoanthien
	@Solenhsx		NVARCHAR(20),
	@Tungay			DATE,
	@Denngay		DATE
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Delete Kehoachhoanthien 
	Where (Solenhsx = @Solenhsx OR @Solenhsx='')  
		And Ngaychay Between @Tungay And @Denngay

Go


Exec Xoakehoachhoanthien '113/2022', '12/01/2022', '12/31/2022'

--select * from Kehoachchia