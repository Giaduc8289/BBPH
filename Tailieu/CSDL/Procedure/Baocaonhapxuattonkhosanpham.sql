------------------------Báo cáo nhập xuất tồn kho sản phẩm-------------
If Object_ID('dbo.Baocaonhapxuattonkhosanpham','P') is not null
	Drop Procedure dbo.Baocaonhapxuattonkhosanpham;
Go
Create Procedure dbo.Baocaonhapxuattonkhosanpham
	@Tungay			DATE,
	@Denngay		DATE,
	@Masanpham			NVARCHAR(50),
	@Makho				NVARCHAR(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	--Tính tồn đầu
	
	DECLARE @v_Ngaykiemke	DATE
	
	SET @v_Ngaykiemke = dbo.fNgaykiemkesanpham(@Tungay)
	
	SELECT Masanpham, Makho, Tenkho, SUM(Somet) AS Somet, SUM(Soluong) AS Soluong, SUM(Sokg) AS Khoiluong 
	INTO #Tondau0
	FROM dbo.Sodusanpham
	WHERE Ngaykiemke=@v_Ngaykiemke
		AND (Masanpham=@Masanpham OR @Masanpham='')
		AND (Makho=@Makho OR @Makho='')
	GROUP BY Masanpham, Makho, Tenkho
	UNION
	SELECT Masanpham, Makho, Tenkho,SUM(Somet) AS Somet, SUM(Soluong) AS Soluong, SUM(Sokg) AS Khoiluong  
	FROM dbo.Nhapkhosanpham
	WHERE Ngaynhap BETWEEN @v_Ngaykiemke AND DATEADD(DAY,-1,@Tungay)
		AND (Masanpham = @Masanpham OR @Masanpham = '') 
		AND (Makho=@Makho OR @Makho='')
	GROUP BY Masanpham, Makho, Tenkho
	UNION
	SELECT Masanpham, Makho, Tenkho,-SUM(Somet) AS Somet, -SUM(Soluong) AS Soluong, -SUM(Sokg) AS Khoiluong  
	FROM dbo.Xuatkhosanpham
	WHERE Ngayxuat BETWEEN @v_Ngaykiemke AND DATEADD(DAY,-1,@Tungay)
		AND (Masanpham = @Masanpham OR @Masanpham = '') 
		AND (Makho=@Makho OR @Makho='')
	GROUP BY Masanpham, Makho, Tenkho
	

	SELECT Masanpham, Makho, Tenkho,SUM(Somet) AS Somet, SUM(Soluong) AS Soluong, SUM(Khoiluong) AS Khoiluong
	INTO #Tondau
	FROM #Tondau0 
	GROUP BY Masanpham, Makho, Tenkho
	ORDER BY Masanpham
	
	--Tính nhập kho
	
	SELECT Masanpham, nk.Makho, Tenkho,SUM(Somet) AS Somet, SUM(Soluong) AS Soluong, SUM(Sokg) AS Khoiluong
	INTO #nhapkho0
	FROM dbo.Nhapkhosanpham nk LEFT JOIN dbo.dmhang hh ON nk.Masanpham=hh.Masp
	WHERE Ngaynhap BETWEEN @Tungay AND @Denngay
		AND (Masanpham = @Masanpham OR @Masanpham = '') 
		AND (nk.Makho=@Makho OR @Makho='')
	GROUP BY Masanpham, nk.Makho, Tenkho
	ORDER BY Masanpham
	
	SELECT Masanpham, Makho, Tenkho,SUM(Somet) AS Somet, SUM(Soluong) AS Soluong, SUM(Khoiluong) AS Khoiluong
	INTO #nhapkho
	FROM #nhapkho0
	GROUP BY Masanpham, Makho, Tenkho
	ORDER BY Masanpham
	
	--Tính xuất kho
	
	SELECT Masanpham, Makho, Tenkho,SUM(Somet) AS Somet, SUM(Soluong) AS Soluong, SUM(Sokg) AS Khoiluong 
	INTO #xuatkho0
	FROM dbo.Xuatkhosanpham
	WHERE Ngayxuat BETWEEN @Tungay AND @Denngay
		AND (Masanpham = @Masanpham OR @Masanpham = '') 
		AND (Makho=@Makho OR @Makho='')
	GROUP BY Masanpham, Makho, Tenkho
	ORDER BY Masanpham
	
	SELECT Masanpham, Makho, Tenkho,SUM(Somet) AS Somet, SUM(Soluong) AS Soluong, SUM(Khoiluong) AS Khoiluong
	INTO #xuatkho
	FROM #xuatkho0
	GROUP BY Masanpham, Makho, Tenkho
	ORDER BY Masanpham
	
	--Tính tồn cuối
	
	Select Masanpham, Makho, Somet As Somet, Soluong As Soluong, Khoiluong As Khoiluong
		, convert(numeric(20,2),0.00) As Sometnhapkho, convert(numeric(20,2),0.00) As Soluongnhapkho, convert(numeric(20,2),0.00) As Khoiluongnhapkho
		, convert(numeric(20,2),0.00) As Sometxuatkho, convert(numeric(20,2),0.00) As Soluongxuatkho , convert(numeric(20,2),0.00) As Khoiluongxuatkho
	Into #Ketqua0
	From #Tondau
	Union
	Select Masanpham, Makho, convert(numeric(20,2),0.00) As Somettondau, convert(numeric(20,2),0.00) As Soluongtondau, convert(numeric(20,2),0.00) As Khoiluongtondau
		, Somet As Somet, Soluong As Soluong, Khoiluong As Khoiluong
		, convert(numeric(20,2),0.00) As Sometxuatkho, convert(numeric(20,2),0.00) As Soluongxuatkho, convert(numeric(20,2),0.00) As Khoiluongxuatkho  
	From #Nhapkho
	Union
	Select Masanpham, Makho, convert(numeric(20,2),0.00) As Somettondau, convert(numeric(20,2),0.00) As Soluongtondau, convert(numeric(20,2),0.00) As Khoiluongtondau
		, convert(numeric(20,2),0.00) As Sometnhapkho, convert(numeric(20,2),0.00) As Soluongnhapkho, convert(numeric(20,2),0.00) As Khoiluongnhapkho
		,Somet As Somet, Soluong As Soluong, Khoiluong As Khoiluong 
	From #Xuatkho	

	Select Masanpham, Makho, SUM(Somet) As Somettondau, SUM(Soluong) As Soluongtondau, SUM(Khoiluong) As Khoiluongtondau
		, SUM(Sometnhapkho) As Sometnhapkho, SUM(Soluongnhapkho) As Soluongnhapkho, SUM(Khoiluongnhapkho) As Khoiluongnhapkho
		, SUM(Sometxuatkho) As Sometxuatkho, SUM(Soluongxuatkho) As Soluongxuatkho, SUM(Khoiluongxuatkho) As Khoiluongxuatkho
	Into #Ketqua
	From #Ketqua0
	Group By Masanpham, Makho
	
	Select Masanpham, dm.Tensp As Tensanpham, kq.Makho, Tenkho, Somettondau, Soluongtondau, Khoiluongtondau
			,Sometnhapkho, Soluongnhapkho, Khoiluongnhapkho
			,Sometxuatkho, Soluongxuatkho, Khoiluongxuatkho
	From #Ketqua kq Left Join dmhang dm on kq.Masanpham = dm.Masp
		Left Join dmkho kho on kho.Makho=kq.Makho
	Where abs(Khoiluongtondau)+abs(Khoiluongnhapkho)+abs(Khoiluongxuatkho)>0
		or abs(Somettondau)+abs(Sometnhapkho)+abs(Sometxuatkho)>0

	
Go

Exec Baocaonhapxuattonkhosanpham '01/01/2022', '08/30/2022', '', ''