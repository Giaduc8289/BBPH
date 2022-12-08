------------------------Kế hoạch in theo ca máy-------------
If Object_ID('dbo.Kehoachintheocamay','P') is not null
	Drop Procedure dbo.Kehoachintheocamay;
Go
Create Procedure dbo.Kehoachintheocamay
	@Ngay		DATETIME,
	@Ca			INT,
	@May		Nvarchar(20)	
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT kh.Id, lsx.Solenhsx, Madon, Makhach, Tenkhach
		, Masp As Masanpham, lsx.Ngaydat, lsx.Ngaygiao 
		, Sldukien 
	FROM dbo.Kehoachin kh LEFT JOIN Lenhsanxuat lsx On lsx.Solenhsx=kh.Solenhsx
	WHERE  Ngaychay = @Ngay
		AND Ca = @Ca
		AND Mamay = @May
	
Go

Exec Kehoachintheocamay '12/08/2022', 1, 'I1'

--SELECT * FROM dbo.Lenhsanxuat
SELECT * FROM dbo.Kehoachin
