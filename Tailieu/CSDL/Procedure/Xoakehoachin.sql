------------------------Xóa kế hoạch in-------------
If Object_ID('dbo.Xoakehoachin','P') is not null
	Drop Procedure dbo.Xoakehoachin
Go

Create Procedure dbo.Xoakehoachin
	@Madonhangchitiet		NVARCHAR(20),
	@Tungay			DATE,
	@Denngay		DATE
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Delete Kehoachin 
	Where (Madonhangct = @Madonhangchitiet OR @Madonhangchitiet='')  
		And Ngaychay Between @Tungay And @Denngay

Go


Exec Lapkehoachin '', 'DH015', '', '08/01/2020', '08/31/2020'

SELECT * FROM dbo.Kehoachin
--DELETE  Kehoachin
