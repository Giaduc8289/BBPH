------------------------Chi tiết nhu cầu in-------------
If Object_ID('dbo.Nhucaulapkehoachin','P') is not null
	Drop Procedure dbo.Nhucaulapkehoachin;
Go
Create Procedure dbo.Nhucaulapkehoachin
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
			
	-----Lệnh sản xuất với Ngày đặt <= Ngày cuối tháng, và kết quả in theo Lệnh		
	Select Solenhsx, Ngayphatlenh, Ngaybatdausx, Ngayhoanthanhsx
		, Madon, Ngaydat, sp.Makhach, sp.Tenkhach
		, Madonhangchitiet, lsx.Masanpham, sp.Tensp As Tensanpham, Ngaygiao 
		, Soluong
		, IsNull((Select Sum(Thuctein) From Ketquain Where Solenhsx=lsx.Solenhsx), CONVERT(Decimal(20,2),0.00)) As Sometdain
		, sp.Sohinh, sp.Dai
		, IsNull((SELECT SUM(ISNULL(Sldukien,0)) FROM dbo.Kehoachin Where Solenhsx=lsx.Solenhsx AND Ngaychay >= @Tungay),0) AS Dalapkh
	Into #Nhucau0
	From Lenhsanxuat lsx Left Join dmhang sp On sp.Masp=lsx.Masanpham
	Where Ngaydat<=@v_Ngaycuoithang
	 
	-----Lấy số lượng trong đơn trừ đi kết quả đã in
	Select Solenhsx, Ngayphatlenh, Ngaybatdausx, Ngayhoanthanhsx
		, Madon, Ngaydat, Makhach, Tenkhach
		, Madonhangchitiet, Masanpham, Tensanpham, Ngaygiao 
		, Soluong
		, Soluong/Sohinh*Dai/1000 As Sometquydoi
		, Sometdain
		, Round((Soluong/Sohinh*Dai/1000 - Sometdain - Dalapkh),0) As Sometconlai	--Số mét còn lại cần lập kế hoạch
	Into #Nhucau
	From #Nhucau0
	
	SELECT * FROM #Nhucau WHERE Sometconlai>0 ORDER BY Ngaygiao
	
Go

Exec Nhucaulapkehoachin '12/13/2022', '12/30/2022', 'TRUE'


--select * from Ketquain
--select * from Kehoachin