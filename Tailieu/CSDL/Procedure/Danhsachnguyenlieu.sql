------------------------Danh sách nguyên liệu-------------
If Object_ID('dbo.Danhsachnguyenlieu','P') is not null
	Drop Procedure dbo.Danhsachnguyenlieu;
Go

Create Procedure dbo.Danhsachnguyenlieu
	@Manguyenlieu		NVARCHAR(50),
	@Ngay				DATE
As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	Select DISTINCT Manl, Tennl, Tenrutgon
		, ISNULL((SELECT TOP 1 Gia FROM dbo.Dmnguyenlieu WHERE Manl=dm.Manl AND Ngay<=@Ngay ORDER BY Ngay DESC),NULL) AS Gia
		, ISNULL((SELECT TOP 1 Ngay FROM dbo.Dmnguyenlieu WHERE Manl=dm.Manl AND Ngay<=@Ngay ORDER BY Ngay DESC),NULL) AS Ngay
		--, ISNULL((SELECT TOP 2 Gia FROM dbo.Dmnguyenlieu WHERE Manl=dm.Manl ORDER BY Ngay DESC),NULL) AS Giacu
	INTO #Ketqua0
	From dbo.Dmnguyenlieu dm
	WHERE (dm.Manl=@Manguyenlieu OR @Manguyenlieu='')
		AND dm.Ngay<=@Ngay

	SELECT Manl, Tennl, Tenrutgon, Gia, Ngay
		, ISNULL((SELECT TOP 1 Gia FROM dbo.Dmnguyenlieu WHERE Manl=kq.Manl AND Ngay<kq.Ngay ORDER BY Ngay DESC),NULL) AS Giacu
		, ISNULL((SELECT TOP 1 Manhom FROM dbo.Dmnguyenlieu WHERE Manl=kq.Manl AND ISNULL(Manhom,'')<>''),NULL) AS Manhom
	INTO #Ketqua
	FROM #Ketqua0 kq
	
	SELECT kq.Manl, kq.Tennl, kq.Tenrutgon, Gia, Ngay
		, CASE WHEN ISNULL(Giacu,0)>0 AND ISNULL(Gia,0)>ISNULL(Giacu,0) THEN (Gia/Giacu-1)*100 ELSE NULL END AS Tang
		, CASE WHEN ISNULL(Gia,0)<ISNULL(Giacu,0) THEN (1-Gia/Giacu)*100 ELSE NULL END AS Giam
		, kq.Manhom, nnl.Tennhomnguyenlieu AS Tennhom
	FROM #Ketqua kq LEFT JOIN dbo.dmnhomnguyenlieu nnl ON nnl.Manhom=kq.Manhom
	
Go

Exec Danhsachnguyenlieu '', '11/30/2022'

--SELECT * FROM dbo.Dmnguyenlieu Where Manl='NL.00068'
