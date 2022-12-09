------------------------Kế hoạch chia theo ca máy-------------
If Object_ID('dbo.Kehoachchiatheocamay','P') is not null
	Drop Procedure dbo.Kehoachchiatheocamay;
Go
Create Procedure dbo.Kehoachchiatheocamay
	@Ngay		DATETIME,
	@Ca			INT,
	@May		Nvarchar(20)	
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT kh.Id, lsx.Solenhsx, Madon, Makhach, Tenkhach
		, lsx.Masanpham, lsx.Ngaydat, lsx.Ngaygiao 
		, Sldukien, Tgdukien 
	FROM dbo.Kehoachchia kh LEFT JOIN Lenhsanxuat lsx On lsx.Solenhsx=kh.Solenhsx
	WHERE  Ngaychay = @Ngay
		AND Ca = @Ca
		AND Mamay = @May
	
Go

Exec Kehoachchiatheocamay '12/09/2022', 1, 'L2'

--SELECT * FROM dbo.Lenhsanxuat
SELECT * FROM dbo.Kehoachchia
