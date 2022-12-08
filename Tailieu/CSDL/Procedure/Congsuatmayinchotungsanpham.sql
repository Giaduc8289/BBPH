------------------------Công suất máy in cho từng sản phẩm------------
If Object_ID('dbo.Congsuatmayinchotungsanpham','P') is not null
	Drop Procedure dbo.Congsuatmayinchotungsanpham;
Go
Create Procedure dbo.Congsuatmayinchotungsanpham
	@Tungay		DATETIME,
	@Denngay	DATETIME
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	DECLARE @v_columns	NVARCHAR(MAX), 
			@v_sql		NVARCHAR(MAX)
			
	DECLARE @v_Ngaydauthang			DATE,
			@v_Ngaycuoithang		DATE,
			@v_Sothangxetnhucau		INT

	SELECT	@v_Sothangxetnhucau = REPLACE(Giatri,',','.') FROM Thamso WHERE Mahieu='Sothangxetnhucau'
	SET @v_Sothangxetnhucau=1-@v_Sothangxetnhucau

	SET @v_Ngaydauthang = DATEADD(DAY,-DAY(@Tungay)+1,@Tungay)
	SET @v_Ngaycuoithang = DATEADD(DAY,-DAY(DATEADD(MONTH,1,@Denngay)),DATEADD(MONTH,1,@Denngay)) 
			
	-----Lệnh sản xuất với Ngày đặt <= Ngày cuối tháng, và kết quả in theo Lệnh		
	Select Solenhsx, Ngayphatlenh, Ngaybatdausx, Ngayhoanthanhsx
		, Madon, Ngaydat, sp.Makhach, sp.Tenkhach
		, Madonhangchitiet, lsx.Masp As Masanpham, sp.Tensp As Tensanpham, Ngaygiao 
		, Soluong
		, IsNull((Select Sum(Thuctein) From Ketquain Where Solenhsx=lsx.Solenhsx), CONVERT(Decimal(20,2),0.00)) As Sometdain
		, sp.Sohinh, sp.Dai
	Into #Nhucau0
	From Lenhsanxuat lsx Left Join dmhang sp On sp.Masp=lsx.Masp
	Where Ngaydat<=@v_Ngaycuoithang
	 
	-----Lấy số lượng trong đơn trừ đi kết quả đã in
	Select Solenhsx, Ngayphatlenh, Ngaybatdausx, Ngayhoanthanhsx
		, Madon, Ngaydat, Makhach, Tenkhach
		, Madonhangchitiet, Masanpham, Tensanpham, Ngaygiao 
		--, Soluong - Sometin*1000/Dai*Sohinh As Soluong
		, Soluong/Sohinh*Dai/1000 - Sometdain As Somet
	Into #Nhucau1
	From #Nhucau0
	
	--SELECT * FROM #Nhucau WHERE Soluong>0 ORDER BY Ngaygiao
	SELECT * 
	Into #Nhucau
	FROM #Nhucau1 WHERE Somet>0 ORDER BY Ngaygiao


	SELECT Mamay, Madm As Madongmay
		, Masanpham, Makhach, Solenhsx
		, dbo.fTinhtocdomay(Mamay,Masanpham,'')*60*12 As Congsuat
	INTO #CsMay_Lenhsx
	FROM (Select * From Dmmay Where Madm='IN')m 
		,(Select DISTINCT Masanpham, Makhach, Solenhsx
					FROM #Nhucau) nc


	SET @v_columns = N''
	SELECT @v_columns += N', ' + QUOTENAME(Solenhsx) FROM (SELECT Solenhsx FROM #CsMay_Lenhsx GROUP BY Solenhsx) AS x ORDER BY x.Solenhsx
	SET	@v_sql = N'Select Mamay,' 
		+ STUFF(@v_columns,1, 2, '') 
		+ ' From (Select Mamay, Madongmay, Solenhsx, Congsuat From #CsMay_Lenhsx) As j '
		+ ' PIVOT ('
		+ ' SUM(Congsuat) FOR Solenhsx IN ('
		+ STUFF(REPLACE(@v_columns,', [',',['),1,1,'')
		+ ') 
		) As p Order by Madongmay'

	EXEC sp_executesql @v_sql;
	
Go

Exec Congsuatmayinchotungsanpham '12/03/2022', '12/31/2022'

