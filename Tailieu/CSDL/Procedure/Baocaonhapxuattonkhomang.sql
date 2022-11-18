------------------------Báo cáo nhập xuất tồn kho màng-------------
If Object_ID('dbo.Baocaonhapxuattonkhomang','P') is not null
	Drop Procedure dbo.Baocaonhapxuattonkhomang;
Go
Create Procedure dbo.Baocaonhapxuattonkhomang
	@Tungay			DATE,
	@Denngay		DATE,
	@Mamang		NVARCHAR(50),
	@Makho				NVARCHAR(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	--Tính tồn đầu
	
	DECLARE @v_Ngaykiemke	DATE
	
	SET @v_Ngaykiemke = dbo.fNgaykiemkesanpham(@Tungay)
	
	SELECT Mamang, Makho, Tenkho, SUM(Somet) AS Somet, SUM(Sokg) AS Khoiluong
	INTO #Tondau0
	FROM dbo.Sodumang
	WHERE Ngaykiemke=@v_Ngaykiemke
		AND (Mamang=@Mamang OR @Mamang='')
		AND (Makho=@Makho OR @Makho='')
	GROUP BY Mamang, Makho, Tenkho
	UNION
	SELECT Mamang, Makho, Tenkho, SUM(Somet) AS Somet, SUM(Sokg) AS Khoiluong
	FROM dbo.Nhapkhomang
	WHERE Ngaynhap BETWEEN @v_Ngaykiemke AND DATEADD(DAY,-1,@Tungay)
		AND (Mamang = @Mamang OR @Mamang = '') 
		AND (Makho=@Makho OR @Makho='')
	GROUP BY Mamang, Makho, Tenkho
	UNION
	SELECT Mamang, Makho, Tenkho,  -SUM(Somet) AS Somet, -SUM(Sokg) AS Khoiluong
	FROM dbo.Xuatkhomang
	WHERE Ngayxuat BETWEEN @v_Ngaykiemke AND DATEADD(DAY,-1,@Tungay)
		AND (Mamang = @Mamang OR @Mamang = '') 
		AND (Makho=@Makho OR @Makho='')
	GROUP BY Mamang, Makho, Tenkho
	

	SELECT Mamang, Makho, Tenkho, SUM(Somet) AS Somet, SUM(Khoiluong) AS Khoiluong
	INTO #Tondau
	FROM #Tondau0 
	GROUP BY Mamang, Makho, Tenkho
	ORDER BY Mamang
	
	--Tính nhập kho 
	
	SELECT nk.Mamang, nk.Makho, Tenkho, SUM(Somet) AS Somet, SUM(Sokg) AS Khoiluong
	INTO #nhapkho0
	FROM dbo.Nhapkhomang nk LEFT JOIN dbo.dmmang nl ON nk.Mamang=nl.Mamang
	WHERE Ngaynhap BETWEEN @Tungay AND @Denngay
		AND (nk.Mamang = @Mamang OR @Mamang = '') 
		AND (nk.Makho=@Makho OR @Makho='')
	GROUP BY nk.Mamang, nk.Makho, Tenkho
	ORDER BY Mamang
	
	SELECT Mamang, Makho, Tenkho, SUM(Somet) AS Somet, SUM(Khoiluong) AS Khoiluong
	INTO #nhapkho
	FROM #nhapkho0
	GROUP BY Mamang, Makho, Tenkho
	ORDER BY Mamang
	
	--Tính xuất kho
	
	SELECT Mamang, Makho, Tenkho, SUM(Somet) AS Somet, SUM(Sokg) AS Khoiluong
	INTO #xuatkho0
	FROM dbo.Xuatkhomang
	WHERE Ngayxuat BETWEEN @Tungay AND @Denngay
		AND (Mamang = @Mamang OR @Mamang = '') 
		AND (Makho=@Makho OR @Makho='')
	GROUP BY Mamang, Makho, Tenkho
	ORDER BY Mamang
	
	SELECT Mamang, Makho, Tenkho, SUM(Somet) AS Somet, SUM(Khoiluong) AS Khoiluong
	INTO #xuatkho
	FROM #xuatkho0
	GROUP BY Mamang, Makho, Tenkho
	ORDER BY Mamang
	
	--Tính tồn cuối
	
	Select Mamang, Makho
		, Somet As Somet, Khoiluong As Khoiluong
		, convert(numeric(20,2),0.00) As Sometnhapkho, convert(numeric(20,2),0.00) As Khoiluongnhapkho
		, convert(numeric(20,2),0.00) As Sometxuatkho, convert(numeric(20,2),0.00) As Khoiluongxuatkho
	Into #Ketqua0
	From #Tondau
	Union
	Select Mamang, Makho
		, convert(numeric(20,2),0.00) As Somettondau, convert(numeric(20,2),0.00) As Khoiluongtondau
		, Somet As Somet, Khoiluong As Khoiluong
		, convert(numeric(20,2),0.00) As Sometxuatkho , convert(numeric(20,2),0.00) As Khoiluongxuatkho
	From #Nhapkho
	Union
	Select Mamang, Makho
		, convert(numeric(20,2),0.00) As Somettondau, convert(numeric(20,2),0.00) As Khoiluongtondau
		, convert(numeric(20,2),0.00) As Sometnhapkho, convert(numeric(20,2),0.00) As Khoiluongnhapkho
		, Somet As Somet, Khoiluong As Khoiluong
	From #Xuatkho	

	Select Mamang, Makho
		, SUM(Somet) As Somettondau, SUM(Khoiluong) As Khoiluongtondau
		, SUM(Sometnhapkho) As Sometnhapkho, SUM(Khoiluongnhapkho) As Khoiluongnhapkho
		, SUM(Sometxuatkho) As Sometxuatkho, SUM(Khoiluongxuatkho) As Khoiluongxuatkho
	Into #Ketqua
	From #Ketqua0
	Group By Mamang, Makho
	
	Select kq.Mamang, Tenmang As Tenmang, kq.Makho As Makho, Tenkho As Tenkho
			, Somettondau, Khoiluongtondau
			,Sometnhapkho, Khoiluongnhapkho
			,Sometxuatkho, Khoiluongxuatkho
	From #Ketqua kq Left Join dmmang dm on kq.Mamang = dm.Mamang
		Left Join dmkho kho on kho.Makho=kq.Makho
	Where abs(Khoiluongtondau + Khoiluongnhapkho + Khoiluongxuatkho) <> 0

	
Go

Exec Baocaonhapxuattonkhomang '10/01/2022', '11/30/2022', '', ''