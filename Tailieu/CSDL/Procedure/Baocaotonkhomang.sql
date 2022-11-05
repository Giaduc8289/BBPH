------------------------Báo cáo tồn kho màng-------------
If Object_ID('dbo.Baocaotonkhomang','P') is not null
	Drop Procedure dbo.Baocaotonkhomang;
Go
Create Procedure dbo.Baocaotonkhomang
	@Ngay		Date,
	@Mamang		NVARCHAR(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	DECLARE @v_Ngaykiemke	DATE
	
	SET @v_Ngaykiemke = dbo.fNgaykiemkemang(@Ngay)
	
	SELECT Mamang, SUM(Somet) AS Somet, SUM(Sokg) AS Sokg 
	INTO #Ketqua
	FROM dbo.Sodumang
	WHERE Ngaykiemke=@v_Ngaykiemke
		AND (Mamang=@Mamang OR @Mamang='')
	GROUP BY Mamang
	UNION
	SELECT Mamang, SUM(Somet) AS Somet, SUM(Sokg) AS Sokg 
	FROM dbo.Nhapkhomang
	WHERE Ngaynhap BETWEEN @v_Ngaykiemke AND DATEADD(DAY,-1,@Ngay)
		AND (Mamang=@Mamang OR @Mamang='')
	GROUP BY Mamang
	UNION
	SELECT Mamang, -SUM(Somet) AS Somet, -SUM(Sokg) AS Sokg 
	FROM dbo.Xuatkhomang
	WHERE Ngayxuat BETWEEN @v_Ngaykiemke AND DATEADD(DAY,-1,@Ngay)
		AND (Mamang=@Mamang OR @Mamang='')
	GROUP BY Mamang
	

	SELECT kq.Mamang, Makhach, Tenkhach, Tenmang, SUM(ISNULL(Somet,0)) AS Somet, SUM(ISNULL(Sokg,0)) AS Sokg 
	FROM #Ketqua kq LEFT JOIN dbo.dmmang dm ON dm.Mamang = kq.Mamang
	GROUP BY kq.Mamang, Makhach, Tenkhach, Tenmang
	ORDER BY Mamang, Makhach
	
Go

Exec Baocaotonkhomang '04/01/2022', ''
