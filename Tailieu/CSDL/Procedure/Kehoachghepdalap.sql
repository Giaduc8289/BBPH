------------------------Kế hoạch ghép theo ca máy-------------
If Object_ID('dbo.Kehoachghepdalap','P') is not null
	Drop Procedure dbo.Kehoachghepdalap;
Go
Create Procedure dbo.Kehoachghepdalap
	@Tungay		DATETIME,
	@Denngay	DATETIME
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT kh.Id, Mamay, Ngaychay, Ca
		, Madonhangchitiet, Makhach--, Madonhang, Tenkhachhang
		, kh.Masanpham
		, kh.Solenhsx
		--, Ngaydat, Ngaygiao 
		, Sldukien 
		--, ddh.Chieudaicat, dmm.Dorong
		--, Daphatlenh
	FROM dbo.Kehoachghep kh LEFT JOIN Lenhsanxuat lsx ON lsx.Solenhsx = kh.Solenhsx
	WHERE  Ngaychay BETWEEN @Tungay AND @Denngay
	
Go

Exec Kehoachindalap '12/01/2022', '12/30/2022'

--SELECT * FROM dbo.Donhang_d
--SELECT * FROM dbo.Kehoachin
