------------------------Báo cáo tổng hợp lương tổ in-------------
If Object_ID('dbo.Baocaoluongtoghep','P') is not null
	Drop Procedure dbo.Baocaoluongtoghep
Go

Create Procedure Baocaoluongtoghep
	@Tungay			Date,
	@Denngay		Date,
	@Macongnhan		Nvarchar(50)
--WITH Encryption As
As	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngay, Macongnhan, Tencongnhan
		, Masanpham, Tensanpham
		--, SUM(ISNULL(ManginMet,0)) Sometin, SUM(ISNULL(ManginKg,0)) Sokgin
		, SUM(ISNULL(MangcapMet,0)) Sometcap, SUM(ISNULL(MangcapKg,0)) Sokgcap
		, SUM(ISNULL(ThucteMet,0)) Somet, SUM(ISNULL(ThucteKg,0)) Sokg
	INTO #Ketquaghep0 
	FROM dbo.Ketquaghep
	WHERE Ngay BETWEEN @Tungay AND @Denngay
	GROUP BY Ngay, Macongnhan,Tencongnhan, Masanpham, Tensanpham

	Select Ngay, Masanpham, Tensanpham
			--, Sometin, Sokgin
			, Sometcap, Sokgcap, Somet, Sokg
			, (Select COUNT(*) From dbo.SplitString(kq.Macongnhan,',')) As Socongnhan
			, cn.Value As Macongnhan
	Into #Ketquaghep1
	From #Ketquaghep0 kq 
		Cross Apply (Select * From dbo.SplitString(kq.Macongnhan,',')) As cn

	Select Ngay, Macongnhan, Tencongnhan, Macv, Masanpham, Tensanpham
			--, SUM(ISNULL(Sometin,0)) Sometin, SUM(ISNULL(Sokgin,0)) Sokgin
			, SUM(ISNULL(Sometcap,0)) Sometcap, SUM(ISNULL(Sokgcap,0)) Sokgcap
			, SUM(ISNULL(Somet,0)) Somet, SUM(ISNULL(Sokg,0)) Sokg
			, Socongnhan
	Into #Ketquaghep
	From #Ketquaghep1 kq Inner Join dmcongnhan dm On dm.Macn=kq.Macongnhan
	Where (Macongnhan=@Macongnhan Or @Macongnhan='')
	GROUP BY Ngay, Macongnhan, Tencongnhan, Macv, Masanpham, Tensanpham, Socongnhan
	
	Select Ngay, Macongnhan, Tencongnhan, Masanpham, Tensanpham
			--, Sometin/Socongnhan As Sometin, Sokgin/Socongnhan As Sokgin
			, Sometcap/Socongnhan As Dauvaomet, Sokgcap/Socongnhan As Dauvaokg
			, Somet/Socongnhan As Dauramet, Sokg/Socongnhan As Daurakg
			, Heso
	From #Ketquaghep kq Left Join dmchucvu cv on cv.Macv=kq.Macv
	Order By Macongnhan, Masanpham
	
GO

EXEC Baocaoluongtoghep '08/01/2022', '11/30/2022', ''
