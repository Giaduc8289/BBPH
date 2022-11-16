------------------------Báo cáo tổng hợp lương tổ in-------------
If Object_ID('dbo.Baocaoluongtothoi','P') is not null
	Drop Procedure dbo.Baocaoluongtothoi
Go

Create Procedure Baocaoluongtothoi
	@Tungay			Date,
	@Denngay		Date,
	@Macongnhan		Nvarchar(50)
--WITH Encryption As
As	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngay, Macongnhan, Tencongnhan
		, Mamang, Tenmang, SUM(ISNULL(Somet,0)) Somet, SUM(ISNULL(Sokg,0)) Sokg
	INTO #Ketquain0 
	FROM dbo.Ketquathoi
	WHERE Ngay BETWEEN @Tungay AND @Denngay
	GROUP BY Ngay, Macongnhan,Tencongnhan, Mamang, Tenmang

	Select Ngay, Mamang, Tenmang
			, Somet, Sokg
			, (Select COUNT(*) From dbo.SplitString(kq.Macongnhan,',')) As Socongnhan
			, cn.Value As Macongnhan
	Into #Ketquain1
	From #Ketquain0 kq 
		Cross Apply (Select * From dbo.SplitString(kq.Macongnhan,',')) As cn

	Select Ngay, Macongnhan, Tencongnhan, Mamang, Tenmang
			, SUM(ISNULL(Somet,0)) Somet, SUM(ISNULL(Sokg,0)) Sokg
			, Socongnhan
	Into #Ketquain
	From #Ketquain1 kq Inner Join dmcongnhan dm On dm.Macn=kq.Macongnhan
	Where (Macongnhan=@Macongnhan Or @Macongnhan='')
	GROUP BY Ngay, Macongnhan, Tencongnhan, Mamang, Tenmang, Socongnhan
	
	Select Ngay, Macongnhan, Tencongnhan, Mamang, Tenmang
			, Somet/Socongnhan As Dauramet , Sokg/Socongnhan As Daurakg
	From #Ketquain
	Order By Macongnhan, Mamang
	
GO

EXEC Baocaoluongtothoi '08/01/2022', '11/30/2022', ''
