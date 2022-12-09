------------------------Kế hoạch ghép theo ca máy-------------
If Object_ID('dbo.Kehoachgheptheocamay','P') is not null
	Drop Procedure dbo.Kehoachgheptheocamay;
Go
Create Procedure dbo.Kehoachgheptheocamay
	@Ngay		DATETIME,
	@Ca			INT,
	@May		Nvarchar(20)	
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT kh.Id, lsx.Solenhsx, Madon, Makhach, Tenkhach
		, lsx.Masanpham, lsx.Ngaydat, lsx.Ngaygiao 
		, Sldukien 
	FROM dbo.Kehoachghep kh LEFT JOIN Lenhsanxuat lsx On lsx.Solenhsx=kh.Solenhsx
	WHERE  Ngaychay = @Ngay
		AND Ca = @Ca
		AND Mamay = @May
	
Go

Exec Kehoachgheptheocamay '12/08/2022', 2, ''

--SELECT * FROM dbo.Lenhsanxuat
--SELECT * FROM dbo.Kehoachghep