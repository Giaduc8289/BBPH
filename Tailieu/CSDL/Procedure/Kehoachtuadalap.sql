------------------------Kế hoạch tua theo ca máy-------------
If Object_ID('dbo.Kehoachtuadalap','P') is not null
	Drop Procedure dbo.Kehoachtuadalap;
Go
Create Procedure dbo.Kehoachtuadalap
	@Tungay		DATETIME,
	@Denngay	DATETIME
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT kh.Id, Mamay, Ngaychay, Ca
		, Madonhangchitiet, Makhach--, Madonhang, Tenkhachhang
		, lsx.Masanpham
		, kh.Solenhsx
		--, Ngaydat, Ngaygiao 
		, Sldukien 
		--, ddh.Chieudaicat, dmm.Dorong
		--, Daphatlenh
	FROM dbo.Kehoachtua kh LEFT JOIN Lenhsanxuat lsx ON lsx.Solenhsx = kh.Solenhsx
	WHERE  Ngaychay BETWEEN @Tungay AND @Denngay
	
Go

Exec Kehoachtuadalap '12/01/2022', '12/30/2022'

--SELECT * FROM dbo.Dondathangchitiet
--SELECT * FROM dbo.Kehoachin
