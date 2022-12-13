------------------------Kế hoạch hoàn thiện theo ca máy-------------
If Object_ID('dbo.Kehoachhoanthientheocamay','P') is not null
	Drop Procedure dbo.Kehoachhoanthientheocamay;
Go
Create Procedure dbo.Kehoachhoanthientheocamay
	@Ngay		DATETIME,
	@Ca			INT,
	@May		Nvarchar(20)	
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT kh.Id, lsx.Solenhsx, Madon, Makhach, Tenkhach
		, lsx.Masanpham, lsx.Ngaydat, lsx.Ngaygiao 
		, Sldukien , Tgdukien
	FROM dbo.Kehoachhoanthien kh LEFT JOIN Lenhsanxuat lsx On lsx.Solenhsx=kh.Solenhsx
	WHERE  Ngaychay = @Ngay
		AND Ca = @Ca
		AND Mamay = @May
	
Go

Exec Kehoachhoanthientheocamay '12/09/2022', '1', 'L1'



