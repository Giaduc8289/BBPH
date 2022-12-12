------------------------Thời gian chuẩn bị máy hoàn thiện cho từng sản phẩm------------
If Object_ID('dbo.Thoigianchuanbimayhoanthienchotungsanpham','P') is not null
	Drop Procedure dbo.Thoigianchuanbimayhoanthienchotungsanpham;
Go
Create Procedure dbo.Thoigianchuanbimayhoanthienchotungsanpham
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
			
	-----Lệnh sản xuất với Ngày đặt <= Ngày cuối tháng, và kết quả tua theo Lệnh		
	Select Solenhsx, Ngayphatlenh, Ngaybatdausx, Ngayhoanthanhsx
		, Madon, Ngaydat, sp.Makhach, sp.Tenkhach
		, Madonhangchitiet, lsx.Masanpham, sp.Tensp As Tensanpham, Ngaygiao 
		, Soluong
		, IsNull((Select Sum(Ketquatui) From Ketquahoanthien Where Solenhsx=lsx.Solenhsx), CONVERT(Decimal(20,2),0.00)) As Sotuidahoanthien
		, sp.Sohinh, sp.Dai
	Into #Nhucau0
	From Lenhsanxuat lsx Left Join dmhang sp On sp.Masp=lsx.Masanpham
	Where Ngaydat<=@v_Ngaycuoithang
	 
	-----Lấy số lượng trong đơn trừ đi kết quả đã tua
	Select Solenhsx, Ngayphatlenh, Ngaybatdausx, Ngayhoanthanhsx
		, Madon, Ngaydat, Makhach, Tenkhach
		, Madonhangchitiet, Masanpham, Tensanpham, Ngaygiao 
		, Sotuidahoanthien
		, Soluong - Sotuidahoanthien As Sotuiconlai
		, (Soluong - Sotuidahoanthien)/Sohinh*Dai/1000 As Somet  -- số mét còn lại cần làm
	Into #Nhucau1
	From #Nhucau0
	
	
	SELECT * 
	Into #Nhucau
	FROM #Nhucau1 WHERE Sotuiconlai>0 ORDER BY Ngaygiao


	SELECT Mamay, Madm As Madongmay
		, Masanpham, Makhach, Solenhsx
		, (dbo.fTinhdinhmucthoigian(Mamay,Masanpham,'Dauca')
		 + dbo.fTinhdinhmucthoigian(Mamay,Masanpham,'Daucuon')
		 + dbo.fTinhdinhmucthoigian(Mamay,Masanpham,'Doilenh'))
		 As Thoigianchuanbi
	INTO #CbMay_Lenhsx
	FROM (Select * From Dmmay Where Madm = 'CA')m 
		,(Select DISTINCT Masanpham, Makhach, Solenhsx
					FROM #Nhucau) nc

	SET @v_columns = N''
	SELECT @v_columns += N', ' + QUOTENAME(Solenhsx) FROM (SELECT Solenhsx FROM #CbMay_Lenhsx GROUP BY Solenhsx) AS x ORDER BY x.Solenhsx
	SET	@v_sql = N'Select Mamay,' 
		+ STUFF(@v_columns,1, 2, '') 
		+ ' From (Select Mamay, Madongmay, Solenhsx, Thoigianchuanbi From #CbMay_Lenhsx) As j '
		+ ' PIVOT ('
		+ ' SUM(Thoigianchuanbi) FOR Solenhsx IN ('
		+ STUFF(REPLACE(@v_columns,', [',',['),1,1,'')
		+ ') 
		) As p Order by Madongmay'

	EXEC sp_executesql @v_sql;
	
Go

Exec Thoigianchuanbimayhoanthienchotungsanpham '12/03/2022', '12/31/2022'

