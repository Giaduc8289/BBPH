------------------------Báo cáo tổng hợp lương tổ chia-------------
If Object_ID('dbo.Baocaoluongtochia','P') is not null
	Drop Procedure dbo.Baocaoluongtochia
Go

Create Procedure Baocaoluongtochia
	@Tungay			Date,
	@Denngay		Date,
	@Macongnhan		Nvarchar(50)
--WITH Encryption As
As	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngay, Macongnhan, Tencongnhan
		, Masanpham, Tensanpham, SUM(ISNULL(Sometra,0)) Sometra, SUM(ISNULL(Sokgra,0)) Sokgra, Sometvao, Sokgvao
	INTO #Ketquain0 
	FROM dbo.Ketquachia
	WHERE Ngay BETWEEN @Tungay AND @Denngay
	GROUP BY Ngay, Macongnhan,Tencongnhan, Masanpham, Tensanpham, Sometvao, Sokgvao


	Select Ngay, Masanpham, Tensanpham
			,  Sometra, Sokgra, Sometvao, Sokgvao
			, (Select COUNT(*) From dbo.SplitString(kq.Macongnhan,',')) As Socongnhan
			, cn.Value As Macongnhan
	Into #Ketquain1
	From #Ketquain0 kq 
		Cross Apply (Select * From dbo.SplitString(kq.Macongnhan,',')) As cn

	Select Ngay, Macongnhan, Tencongnhan, Macv, Masanpham, Tensanpham
			,  SUM(ISNULL(Sometra,0)) Sometra, SUM(ISNULL(Sokgra,0)) Sokgra, Sometvao, Sokgvao
			, Socongnhan
	Into #Ketquain
	From #Ketquain1 kq Inner Join dmcongnhan dm On dm.Macn=kq.Macongnhan
	Where (Macongnhan=@Macongnhan Or @Macongnhan='')
	GROUP BY Ngay, Macongnhan, Tencongnhan, Macv, Masanpham, Tensanpham, Socongnhan, Sometvao, Sokgvao
	
	Select Ngay, Macongnhan, Tencongnhan, Masanpham, Tensanpham
			, Sometra/Socongnhan As Dauramet, Sokgra/Socongnhan As Daurakg, Sometvao AS Dauvaomet, Sokgvao AS Dauvaokg
			, Heso
	From #Ketquain kq Left Join dmchucvu cv on cv.Macv=kq.Macv
	Order By Macongnhan, Masanpham, Sometvao, Sokgvao
	
GO

EXEC Baocaoluongtochia '08/01/2022', '11/30/2022', ''
