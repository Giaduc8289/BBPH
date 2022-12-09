------------------------Kế hoạch tua theo ca máy-------------
If Object_ID('dbo.Kehoachtuatheocamay','P') is not null
	Drop Procedure dbo.Kehoachtuatheocamay;
Go
Create Procedure dbo.Kehoachtuatheocamay
	@Ngay		DATETIME,
	@Ca			INT,
	@May		Nvarchar(20)	
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT kh.Id, lsx.Solenhsx, Madon, Makhach, Tenkhach
		, lsx.Masanpham, lsx.Ngaydat, lsx.Ngaygiao 
		, Sldukien , Tgdukien
	FROM dbo.Kehoachtua kh LEFT JOIN Lenhsanxuat lsx On lsx.Solenhsx=kh.Solenhsx
	WHERE  Ngaychay = @Ngay
		AND Ca = @Ca
		AND Mamay = @May
	
Go

Exec Kehoachtuatheocamay '12/09/2022', '1', 'L1'

--select * from Kehoachtua

