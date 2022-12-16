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
		, IsNull((SELECT SUM(ISNULL(Sldukien,0)) FROM dbo.Kehoachchia Where Solenhsx=lsx.Solenhsx AND Ngaychay >= @Tungay),0) AS Dalapkh
		--, qc.Nhomqcthanhpham, CharIndex('N11,',qc.Nhomqcthanhpham)
	Into #Nhucau0
	From Lenhsanxuat lsx Left Join dmhang sp On sp.Masp=lsx.Masanpham
		Left Join Dmquycach qc On sp.Maqcthanhpham=qc.Maquycach
	Where Ngaydat<=@v_Ngaycuoithang
		And (CharIndex('N11,',qc.Nhomqcthanhpham)=0)				-----Túi 3 biên không cần chia
		And ((CharIndex('N12,',qc.Nhomqcthanhpham)>0 And sp.Sohinh>=2)	-----Túi 4 biên (số hình>=2) cần chia
			Or (CharIndex('N15,',qc.Nhomqcthanhpham)>0)					-----Túi hàn lưng cần chia
			Or (CharIndex('N16,',qc.Nhomqcthanhpham)>0))				-----Túi xếp hông cần chia
--select * from #Nhucau0

	-----Lấy số lượng trong đơn trừ đi kết quả đã chia
	Select Solenhsx, Ngayphatlenh, Ngaybatdausx, Ngayhoanthanhsx
		, Madon, Ngaydat, Makhach, Tenkhach
		, Madonhangchitiet, Masanpham, Tensanpham, Ngaygiao, Soluong
		, IsNull(Sometdachia,0) As Sometdatua
		, Soluong/Sohinh*Dai/1000 As Sometquydoi
		, Soluong/Sohinh*Dai/1000 - Sometdachia As Sometconlai
		, Round((Soluong/Sohinh*Dai/1000 - Sometdachia - Dalapkh),0) As Sometcanlap
	Into #Nhucau
	From #Nhucau0
	
	--SELECT * FROM #Nhucau WHERE Soluong>0 ORDER BY Ngaygiao
	SELECT * FROM #Nhucau WHERE Sometconlai>0 ORDER BY Ngaygiao
	
Go

Exec Nhucaulapkehoachchia '12/15/2022', '12/30/2022', 'TRUE'


