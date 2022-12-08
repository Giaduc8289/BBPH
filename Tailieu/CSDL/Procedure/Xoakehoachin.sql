------------------------Xóa kế hoạch in-------------
If Object_ID('dbo.Xoakehoachin','P') is not null
	Drop Procedure dbo.Xoakehoachin
Go

Create Procedure dbo.Xoakehoachin
	@Solenhsx		Nvarchar(50),
	@Tungay			DATE,
	@Denngay		DATE
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Delete Kehoachin 
	Where Ngaychay Between @Tungay And @Denngay
		And (Solenhsx=@Solenhsx Or @Solenhsx='')

Go


Exec Xoakehoachin '112/2022', '12/01/2022', '12/31/2022'

SELECT * FROM dbo.Kehoachin
--DELETE  Kehoachin
