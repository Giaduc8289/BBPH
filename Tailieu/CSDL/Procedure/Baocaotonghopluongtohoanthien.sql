------------------------Báo cáo tổng hợp lương tổ hoàn thiện-------------
If Object_ID('dbo.Baocaotonghopluongtohoanthien','P') is not null
	Drop Procedure dbo.Baocaotonghopluongtohoanthien
Go

Create Procedure Baocaotonghopluongtohoanthien
	@Tungay			Date,
	@Denngay		Date,
	@Macongnhan		Nvarchar(50)
--WITH Encryption As
As	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngay, Macongnhan, Tencongnhan, Masanpham, Tensanpham,
		  SUM(ISNULL(Dauvaomet,0)) Dauvaomet, SUM(ISNULL(Dauvaokg,0)) Dauvaokg, SUM(ISNULL(Ketquatui,0)) Ketquatui
	INTO #Ketquahoanthien0 
	FROM dbo.Ketquahoanthien
	WHERE Ngay BETWEEN @Tungay AND @Denngay
	GROUP BY Ngay, Macongnhan,Tencongnhan, Masanpham, Tensanpham

	Select Ngay, Masanpham, Tensanpham
			, Dauvaomet, Dauvaokg, Ketquatui
			, (Select COUNT(*) From dbo.SplitString(kq.Macongnhan,',')) As Socongnhan
			, cn.Value As Macongnhan
	Into #Ketquahoanthien1
	From #Ketquahoanthien0 kq 
		Cross Apply (Select * From dbo.SplitString(kq.Macongnhan,',')) As cn

	Select Ngay, Macongnhan, Tencongnhan, Masanpham, Tensanpham
			, SUM(ISNULL(Dauvaomet,0)) Dauvaomet, SUM(ISNULL(Dauvaokg,0)) Dauvaokg, SUM(ISNULL(Ketquatui,0)) Ketquatui
			, Socongnhan
	Into #Ketquahoanthien
	From #Ketquahoanthien1 kq Inner Join dmcongnhan dm On dm.Macn=kq.Macongnhan
	Where (Macongnhan=@Macongnhan Or @Macongnhan='')
	GROUP BY Ngay, Macongnhan, Tencongnhan, Masanpham, Tensanpham, Socongnhan
	
	Select Macongnhan, Tencongnhan
			, SUM(Dauvaomet/Socongnhan)  Dauvaomet, SUM(Dauvaokg/Socongnhan) Dauvaokg, SUM(Ketquatui/Socongnhan) Ketquatui
	From #Ketquahoanthien
	GROUP BY Macongnhan, Tencongnhan, Socongnhan
	Order By Macongnhan 
	
GO

EXEC Baocaotonghopluongtohoanthien '08/01/2022', '11/30/2022', ''
