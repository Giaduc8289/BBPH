------------------------Chi tiết nhu cầu hoàn thiện-------------
If Object_ID('dbo.Nhucaulapkehoachhoanthien','P') is not null
	Drop Procedure dbo.Nhucaulapkehoachhoanthien;
Go
Create Procedure dbo.Nhucaulapkehoachhoanthien
	@Tungay			DATETIME,
	@Denngay		DATETIME,
	@Daphatlenh		BIT
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
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
		, IsNull((SELECT SUM(ISNULL(Sldukien,0)) FROM dbo.Kehoachhoanthien Where Solenhsx=lsx.Solenhsx AND Ngaychay >= @Tungay),0) AS Dalapkh

	Into #Nhucau0
	From Lenhsanxuat lsx Left Join dmhang sp On sp.Masp=lsx.Masanpham
	Where Ngaydat<=@v_Ngaycuoithang
	 
	-----Lấy số lượng trong đơn trừ đi kết quả đã tua
	Select Solenhsx, Ngayphatlenh, Ngaybatdausx, Ngayhoanthanhsx
		, Madon, Ngaydat, Makhach, Tenkhach
		, Madonhangchitiet, Masanpham, Tensanpham, Ngaygiao, Soluong
		, Sotuidahoanthien
		, Soluong - Sotuidahoanthien As Sotuiconlai
		, Round(((Soluong - Sotuidahoanthien)/Sohinh*Dai/1000 - Dalapkh),0 )As Somet  -- số mét còn lại cần làm

	Into #Nhucau
	From #Nhucau0
	
	--SELECT * FROM #Nhucau WHERE Soluong>0 ORDER BY Ngaygiao
	SELECT * FROM #Nhucau WHERE Sotuiconlai>0 ORDER BY Ngaygiao
	
Go

Exec Nhucaulapkehoachhoanthien '12/01/2022', '12/30/2022', 'TRUE'


