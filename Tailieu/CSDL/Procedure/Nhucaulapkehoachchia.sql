------------------------Chi tiết nhu cầu chia-------------
If Object_ID('dbo.Nhucaulapkehoachchia','P') is not null
	Drop Procedure dbo.Nhucaulapkehoachchia;
Go
Create Procedure dbo.Nhucaulapkehoachchia
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
		, IsNull((Select Sum(Sometra) From Ketquachia Where Solenhsx=lsx.Solenhsx), CONVERT(Decimal(20,2),0.00)) As Sometdachia
		, sp.Sohinh, sp.Dai
	Into #Nhucau0
	From Lenhsanxuat lsx Left Join dmhang sp On sp.Masp=lsx.Masanpham
	Where Ngaydat<=@v_Ngaycuoithang
	 
	-----Lấy số lượng trong đơn trừ đi kết quả đã chia
	Select Solenhsx, Ngayphatlenh, Ngaybatdausx, Ngayhoanthanhsx
		, Madon, Ngaydat, Makhach, Tenkhach
		, Madonhangchitiet, Masanpham, Tensanpham, Ngaygiao, Soluong
		, IsNull(Sometdachia,0) As Sometdatua
		, Soluong/Sohinh*Dai/1000 As Sometquydoi
		, Soluong/Sohinh*Dai/1000 - Sometdachia As Somet
	Into #Nhucau
	From #Nhucau0
	
	--SELECT * FROM #Nhucau WHERE Soluong>0 ORDER BY Ngaygiao
	SELECT * FROM #Nhucau WHERE Somet>0 ORDER BY Ngaygiao
	
Go

Exec Nhucaulapkehoachchia '12/01/2022', '12/30/2022', 'TRUE'


