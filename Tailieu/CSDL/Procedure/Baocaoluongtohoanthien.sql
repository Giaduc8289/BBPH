------------------------Báo cáo tổng hợp lương tổ hoàn thiện-------------
If Object_ID('dbo.Baocaoluongtohoanthien','P') is not null
	Drop Procedure dbo.Baocaoluongtohoanthien
Go

Create Procedure Baocaoluongtohoanthien
	@Tungay			Date,
	@Denngay		Date,
	@Macongnhan		Nvarchar(50)
--WITH Encryption As
As	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngay, Macongnhan, Tencongnhan
		, Masanpham, Tensanpham, SUM(ISNULL(Ketquatui,0)) Ketquatui, Dauvaomet, Dauvaokg
	INTO #Ketquain0 
	FROM dbo.Ketquahoanthien
	WHERE Ngay BETWEEN @Tungay AND @Denngay
	GROUP BY Ngay, Macongnhan,Tencongnhan, Masanpham, Tensanpham, Dauvaomet, Dauvaokg


	Select Ngay, Masanpham, Tensanpham
			,  Dauvaomet, Dauvaokg, Ketquatui
			, (Select COUNT(*) From dbo.SplitString(kq.Macongnhan,',')) As Socongnhan
			, cn.Value As Macongnhan
	Into #Ketquain1
	From #Ketquain0 kq 
		Cross Apply (Select * From dbo.SplitString(kq.Macongnhan,',')) As cn

	Select Ngay, Macongnhan, Tencongnhan, Macv, Masanpham, Tensanpham
			, SUM(ISNULL(Ketquatui,0)) Ketquatui, Dauvaomet, Dauvaokg
			, Socongnhan
	Into #Ketquain
	From #Ketquain1 kq Inner Join dmcongnhan dm On dm.Macn=kq.Macongnhan
	Where (Macongnhan=@Macongnhan Or @Macongnhan='')
	GROUP BY Ngay, Macongnhan, Tencongnhan, Macv, Masanpham, Tensanpham, Socongnhan, Dauvaomet, Dauvaokg
	
	Select Ngay, Macongnhan, Tencongnhan,Masanpham, Tensanpham , Ketquatui/Socongnhan As Ketquatui
			, Dauvaomet/Socongnhan As Dauramet, Dauvaokg/Socongnhan As Daurakg, Dauvaomet, Dauvaokg
			, Heso
	From #Ketquain kq Left Join dmchucvu cv on cv.Macv=kq.Macv
	Order By Macongnhan, Masanpham, Dauvaomet, Dauvaokg, Ketquatui
	
GO

EXEC Baocaoluongtohoanthien '08/01/2022', '11/30/2022', ''
