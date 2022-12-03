------------------------Chi tiết nhu cầu in-------------
If Object_ID('dbo.Nhucaulapkehoachin','P') is not null
	Drop Procedure dbo.Nhucaulapkehoachin;
Go
Create Procedure dbo.Nhucaulapkehoachin
	@Tungay		DATETIME,
	@Denngay	DATETIME,
	@Daphatlenh	BIT
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	DECLARE @v_Ngaydauthang	DATE,
			@v_Ngaycuoithang DATE,
			@v_Ngaydauthangtruoc	DATE,
			@v_Ngaycuoithangtruoc	DATE,
			@v_Thang		NVARCHAR(20),
			@v_Ngaybatdau	DATE,
			@v_Sothangxetnhucau		INT,
			@v_Ngayxetnhucau		DATE

	SELECT	@v_Sothangxetnhucau = REPLACE(Giatri,',','.') FROM Thamso WHERE Mahieu='Sothangxetnhucau'
	SET @v_Sothangxetnhucau=1-@v_Sothangxetnhucau
	
	SET @v_Ngaydauthang = DATEADD(DAY,-DAY(@Tungay)+1,@Tungay)
	SET @v_Ngaycuoithang = DATEADD(DAY,-DAY(DATEADD(MONTH,1,@Denngay)),DATEADD(MONTH,1,@Denngay)) --DATEADD(DAY,-1,DATEADD(MONTH,1,@v_Ngaydauthang))
	SET @v_Ngaydauthangtruoc = DATEADD(MONTH,-1,@v_Ngaydauthang)
	SET @v_Ngaycuoithangtruoc = DATEADD(DAY,-1,@v_Ngaydauthang)
	SET @v_Thang = RIGHT(CONVERT(NVARCHAR(20),@Tungay,103),7)
	
	SET @v_Ngayxetnhucau = CONVERT(Date,'01/07/2020',103) --DATEADD(MONTH,@v_Sothangxetnhucau,@v_Ngaydauthang)
	

	SET	@v_Ngaybatdau = CONVERT(Date,'01/07/2020',103)

	-----Turning
	SELECT Mahang, SUM(ISNULL(Soluong,0)) As Dasanxuat
	Into #fTinhmanhdain
	FROM dbo.Ketquain LEFT JOIN dbo.Manhsudungin ON Manhsudungin.Maketquain = Ketquain.Id
	WHERE Ngay BETWEEN @v_Ngaybatdau And DATEADD(DAY,-1,@Tungay)
	Group by Mahang
	
	
	--SELECT * FROM #Dasanxuat
	Select Madonhang, Tenkhachhang, Mahang, Mauin, Id, Mamanh, Ngaygiao, SUM(ISNULL(Soluong,0)) Soluong
		, CONVERT(numeric(20,2),0.00) Dasanxuat
		, Ngaydat
		, ISNULL((SELECT SUM(ISNULL(Sldukien,0)) FROM dbo.Kehoachin 
			WHERE Madonhangct = dbo.Dondathangchitiet.Id 
				AND ((Ngaychay BETWEEN @Tungay AND @Denngay) OR (Ngaychay<@Tungay AND Daphatlenh='TRUE' AND @Daphatlenh='TRUE'))
			),0) AS Dalapkh
		, CONVERT(numeric(20,2),0.00) Tongnhucau
	INTO #Nhucau0
	FROM Dondathangchitiet 
	Where Ngaydat <= @v_Ngaycuoithang AND Ngaygiao >= @v_Ngaydauthang AND Thang=@v_Thang
	GROUP BY Madonhang, Tenkhachhang, Mahang, Mauin, Id, Mamanh, Ngaygiao, Ngaydat
	UNION
	Select Madonhang, Tenkhachhang, dh.Mahang, Mauin, Id, Mamanh, Ngaygiao, SUM(ISNULL(Soluong,0)) Soluong
		, isNull(di.Dasanxuat,0) Dasanxuat--dbo.fTinhmanhdain(Mahang,@v_Ngaybatdau, DATEADD(DAY,-1,@Tungay)) Dasanxuat-- Thay Ngaygiao bang @Tungay?
		, Ngaydat
		, ISNULL((SELECT SUM(ISNULL(Sldukien,0)) FROM dbo.Kehoachin 
			WHERE Madonhangct = dh.Id 
				AND ((Ngaychay >= @Tungay) Or (Ngaychay<@Tungay AND Daphatlenh='TRUE' AND @Daphatlenh='TRUE'))
			),0) AS Dalapkh
		, dbo.fTinhluykenhucauintheoId(dh.Mahang,Id) Tongnhucau --fTinhluykenhucauin(Mahang,@v_Ngaybatdau, Ngaygiao) Tongnhucau
	From Dondathangchitiet dh
		left join #fTinhmanhdain di on dh.Mahang=di.Mahang
	Where Ngaydat <= @v_Ngaycuoithang AND Ngaygiao >= @v_Ngaydauthang AND ISNULL(Thang,'')=''
		AND Ngaydat>=@v_Ngaydauthang
	GROUP BY Madonhang, Tenkhachhang, dh.Mahang, Mauin, Id, Mamanh, Ngaygiao, Ngaydat, Dasanxuat
	UNION
	Select Madonhang, Tenkhachhang, dh.Mahang, Mauin, Id, Mamanh, Ngaygiao, SUM(ISNULL(Soluong,0)) Soluong
		, isNull(di.Dasanxuat,0) Dasanxuat--dbo.fTinhmanhdain(Mahang,@v_Ngaybatdau, DATEADD(DAY,-1,@Tungay)) Dasanxuat-- Thay Ngaygiao bang @Tungay?
		, Ngaydat
		, ISNULL((SELECT SUM(ISNULL(Sldukien,0)) FROM dbo.Kehoachin 
			WHERE Madonhangct = dh.Id 
				AND ((Ngaychay >= @Tungay) Or (Ngaychay<@Tungay AND Daphatlenh='TRUE' AND @Daphatlenh='TRUE'))
			),0) AS Dalapkh
		, dbo.fTinhluykenhucauintheoId(dh.Mahang,Id) Tongnhucau --fTinhluykenhucauin(Mahang,@v_Ngaybatdau, Ngaygiao) Tongnhucau
	From Dondathangchitiet dh
		left join #fTinhmanhdain di on dh.Mahang=di.Mahang
	Where /*Ngaydat <= @v_Ngaycuoithang AND Ngaygiao >= @v_Ngaydauthang AND*/ ISNULL(Thang,'')=''
		AND Ngaydat BETWEEN @v_Ngaybatdau AND @v_Ngaycuoithangtruoc
		AND dh.Mahang IN (SELECT DISTINCT Mahang FROM dbo.Dondathangchitiet WHERE Ngaydat BETWEEN @v_Ngayxetnhucau AND @v_Ngaycuoithang)
	GROUP BY Madonhang, Tenkhachhang, dh.Mahang, Mauin, Id, Mamanh, Ngaygiao, Ngaydat, Dasanxuat
--SELECT * FROM #Nhucau WHERE Mauin='611'

	SELECT Madonhangct, MAX(Ngaychay) AS Ngaychay
	INTO #Kehoachin
	FROM dbo.Kehoachin
	GROUP BY Madonhangct

--Giảm trừ phần nhu cầu đã được lập kế hoạch
	SELECT Madonhang, Makhach, Tenkhachhang, Mahang, nc.Mauin, Id, nc.Mamanh, ISNULL(Ngaygiao,@Denngay) AS Ngaygiao, Chieudaicat, Dorong, Loaimayin, Kieugap
		, CASE WHEN Tongnhucau>Dasanxuat AND Tongnhucau-Dasanxuat > Soluong THEN Soluong-nc.Dalapkh
			WHEN Tongnhucau>Dasanxuat AND Tongnhucau-Dasanxuat <= Soluong THEN ROUND(Tongnhucau-Dasanxuat-nc.Dalapkh,0) 
			ELSE 0 END AS Soluong
		, Ngaydat
		, khi.Ngaychay AS Ngayhoanthanh
	INTO #Nhucau
	FROM #Nhucau0 nc LEFT JOIN dbo.Danhmuchanghoa ON Danhmuchanghoa.Mahieu = nc.Mahang
		LEFT JOIN dbo.Danhmucmanh ON Danhmucmanh.Mahieu = Danhmuchanghoa.Mamanh
		LEFT JOIN #Kehoachin khi ON khi.Madonhangct = nc.Id 
	WHERE  ISNULL(Loaimayin,'00') <> '00' --AND ISNULL(#Nhucau.Mauin,'') <> ''
		--AND #Nhucau.Mauin='611'
	GROUP BY Madonhang, Makhach, Tenkhachhang, Mahang, nc.Mauin, Id, nc.Mamanh, Ngaygiao, Chieudaicat, Dorong, Loaimayin, Kieugap
		, Ngaydat, khi.Ngaychay
		, Tongnhucau, Dasanxuat, Soluong
		, nc.Dalapkh
	--ORDER BY Ngaygiao
	
	SELECT * FROM #Nhucau WHERE Soluong>0 ORDER BY Ngaygiao
	
Go

Exec Nhucaulapkehoachin '04/01/2022', '04/30/2022', 'TRUE'


