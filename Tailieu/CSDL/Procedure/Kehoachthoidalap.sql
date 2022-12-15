------------------------Kế hoạch thổi theo ca máy-------------
If Object_ID('dbo.Kehoachthoidalap','P') is not null
	Drop Procedure dbo.Kehoachthoidalap;
Go
Create Procedure dbo.Kehoachthoidalap
	@Tungay		DATETIME,
	@Denngay	DATETIME
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT kh.Id, Mamay, Ngaychay, Ca
		, Madonhangchitiet, Makhach--, Madonhang, Tenkhachhang
		, kh.Mamang
		, kh.Solenhsx
		--, Ngaydat, Ngaygiao 
		, Sldukien, Tgdukien 
		--, ddh.Chieudaicat, dmm.Dorong
		--, Daphatlenh
	FROM dbo.Kehoachthoi kh LEFT JOIN Lenhsanxuat lsx ON lsx.Solenhsx = kh.Solenhsx
	WHERE  Ngaychay BETWEEN @Tungay AND @Denngay
	
Go

Exec Kehoachthoidalap '12/01/2022', '12/30/2022'

--SELECT * FROM dbo.Donhang_d
--SELECT * FROM dbo.Kehoachin
