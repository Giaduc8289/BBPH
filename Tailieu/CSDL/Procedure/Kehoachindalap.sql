------------------------Kế hoạch in theo ca máy-------------
If Object_ID('dbo.Kehoachindalap','P') is not null
	Drop Procedure dbo.Kehoachindalap;
Go
Create Procedure dbo.Kehoachindalap
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
		, Sldukien, Tgdukien 
		--, ddh.Chieudaicat, dmm.Dorong
		--, Daphatlenh
	FROM dbo.Kehoachin kh LEFT JOIN Lenhsanxuat lsx ON lsx.Solenhsx = kh.Solenhsx
	WHERE  Ngaychay BETWEEN @Tungay AND @Denngay
	
Go

Exec Kehoachindalap '12/01/2022', '12/30/2022'

--SELECT * FROM dbo.Donhang_d
--SELECT * FROM dbo.Kehoachin
