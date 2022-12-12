------------------------Xóa kế hoạch ghep-------------
If Object_ID('dbo.Xoakehoachghep','P') is not null
	Drop Procedure dbo.Xoakehoachghep
Go

Create Procedure dbo.Xoakehoachghep
	@Solenhsx		Nvarchar(50),
	@Tungay			DATE,
	@Denngay		DATE
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Delete Kehoachghep 
	Where Ngaychay Between @Tungay And @Denngay
		And (Solenhsx=@Solenhsx Or @Solenhsx='')

Go


Exec Xoakehoachghep '112/2022', '12/01/2022', '12/31/2022'

SELECT * FROM dbo.Kehoachghep
--DELETE  Kehoachghep
