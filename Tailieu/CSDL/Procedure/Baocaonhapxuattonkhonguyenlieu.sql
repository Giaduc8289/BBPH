------------------------Báo cáo nhập xuất tồn kho sản phẩm-------------
If Object_ID('dbo.Baocaonhapxuattonkhonguyenlieu','P') is not null
	Drop Procedure dbo.Baocaonhapxuattonkhonguyenlieu;
Go
Create Procedure dbo.Baocaonhapxuattonkhonguyenlieu
	@Tungay			DATE,
	@Denngay		DATE,
	@Manguyenlieu		NVARCHAR(50),
	@Makho				NVARCHAR(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	--Tính tồn đầu
	
	DECLARE @v_Ngaykiemke	DATE
	
	SET @v_Ngaykiemke = dbo.fNgaykiemkesanpham(@Tungay)
	
	SELECT Manguyenlieu, Makho, Tenkho, SUM(Soluong) AS Soluong, Donvitinh
	INTO #Tondau0
	FROM dbo.Sodunguyenlieu
	WHERE Ngaykiemke=@v_Ngaykiemke
		AND (Manguyenlieu=@Manguyenlieu OR @Manguyenlieu='')
		AND (Makho=@Makho OR @Makho='')
	GROUP BY Manguyenlieu, Makho, Tenkho, Donvitinh
	UNION
	SELECT Manguyenlieu, Makho, Tenkho, SUM(Soluong) AS Soluong, Donvitinh
	FROM dbo.Nhapkhonguyenlieu
	WHERE Ngaynhap BETWEEN @v_Ngaykiemke AND DATEADD(DAY,-1,@Tungay)
		AND (Manguyenlieu = @Manguyenlieu OR @Manguyenlieu = '') 
		AND (Makho=@Makho OR @Makho='')
	GROUP BY Manguyenlieu, Makho, Tenkho, Donvitinh
	UNION
	SELECT Manguyenlieu, Makho, Tenkho, -SUM(Soluong) AS Soluong, Donvitinh
	FROM dbo.Xuatkhonguyenlieu
	WHERE Ngayxuat BETWEEN @v_Ngaykiemke AND DATEADD(DAY,-1,@Tungay)
		AND (Manguyenlieu = @Manguyenlieu OR @Manguyenlieu = '') 
		AND (Makho=@Makho OR @Makho='')
	GROUP BY Manguyenlieu, Makho, Tenkho, Donvitinh
	

	SELECT Manguyenlieu, Makho, Tenkho, SUM(Soluong) AS Soluong, Donvitinh
	INTO #Tondau
	FROM #Tondau0 
	GROUP BY Manguyenlieu, Makho, Tenkho, Donvitinh
	ORDER BY Manguyenlieu
	
	--Tính nhập kho
	
	SELECT Manguyenlieu, nk.Makho, Tenkho, SUM(Soluong) AS Soluong, Donvitinh
	INTO #nhapkho0
	FROM dbo.Nhapkhonguyenlieu nk LEFT JOIN dbo.dmnguyenlieu nl ON nk.Manguyenlieu=nl.Manl
	WHERE Ngaynhap BETWEEN @Tungay AND @Denngay
		AND (Manguyenlieu = @Manguyenlieu OR @Manguyenlieu = '') 
		AND (nk.Makho=@Makho OR @Makho='')
	GROUP BY Manguyenlieu, nk.Makho, Tenkho, Donvitinh
	ORDER BY Manguyenlieu
	
	SELECT Manguyenlieu, Makho, Tenkho, SUM(Soluong) AS Soluong, Donvitinh
	INTO #nhapkho
	FROM #nhapkho0
	GROUP BY Manguyenlieu, Makho, Tenkho, Donvitinh
	ORDER BY Manguyenlieu
	
	--Tính xuất kho
	
	SELECT Manguyenlieu, Makho, Tenkho, SUM(Soluong) AS Soluong, Donvitinh
	INTO #xuatkho0
	FROM dbo.Xuatkhonguyenlieu
	WHERE Ngayxuat BETWEEN @Tungay AND @Denngay
		AND (Manguyenlieu = @Manguyenlieu OR @Manguyenlieu = '') 
		AND (Makho=@Makho OR @Makho='')
	GROUP BY Manguyenlieu, Makho, Tenkho, Donvitinh
	ORDER BY Manguyenlieu
	
	SELECT Manguyenlieu, Makho, Tenkho, SUM(Soluong) AS Soluong, Donvitinh
	INTO #xuatkho
	FROM #xuatkho0
	GROUP BY Manguyenlieu, Makho, Tenkho, Donvitinh
	ORDER BY Manguyenlieu
	
	--Tính tồn cuối
	
	Select Manguyenlieu, Makho, Soluong As Soluong
		,convert(numeric(20,2),0.00) As Soluongnhapkho
		,convert(numeric(20,2),0.00) As Soluongxuatkho, Donvitinh
	Into #Ketqua0
	From #Tondau
	Union
	Select Manguyenlieu, Makho, convert(numeric(20,2),0.00) As Soluongtondau
		, Soluong As Soluong
		,convert(numeric(20,2),0.00) As Soluongxuatkho , Donvitinh
	From #Nhapkho
	Union
	Select Manguyenlieu, Makho, convert(numeric(20,2),0.00) As Soluongtondau
		, convert(numeric(20,2),0.00) As Soluongnhapkho
		, Soluong As Soluong, Donvitinh
	From #Xuatkho	

	Select Manguyenlieu, Makho, SUM(Soluong) As Soluongtondau
		, SUM(Soluongnhapkho) As Soluongnhapkho
		, SUM(Soluongxuatkho) As Soluongxuatkho
		, Donvitinh
	Into #Ketqua
	From #Ketqua0
	Group By Manguyenlieu, Makho, Donvitinh
	
	Select Manguyenlieu, dm.Tennl As Tennguyenlieu, kq.Makho As Makho, Tenkho As Tenkho, Soluongtondau
			,Soluongnhapkho
			,Soluongxuatkho, Donvitinh
	From #Ketqua kq Left Join dmnguyenlieu dm on kq.Manguyenlieu = dm.Manl
		Left Join dmkho kho on kho.Makho=kq.Makho
	Where abs(Soluongnhapkho) <> 0

	
Go

Exec Baocaonhapxuattonkhonguyenlieu '01/01/2022', '11/30/2022', '', ''