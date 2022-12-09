------------------------Xóa kế hoạch tua-------------
If Object_ID('dbo.Xoakehoachtua','P') is not null
	Drop Procedure dbo.Xoakehoachtua
Go

Create Procedure dbo.Xoakehoachtua
	@Solenhsx		NVARCHAR(20),
	@Tungay			DATE,
	@Denngay		DATE
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Delete Kehoachtua
	Where (Solenhsx = @Solenhsx OR @Solenhsx='')  
		And Ngaychay Between @Tungay And @Denngay

Go


Exec Xoakehoachtua '', '', ''

