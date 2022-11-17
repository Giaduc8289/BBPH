------------------------Báo cáo tổng hợp lương tổ thổi-------------
If Object_ID('dbo.Baocaotonghopluongtothoi','P') is not null
	Drop Procedure dbo.Baocaotonghopluongtothoi
Go

Create Procedure Baocaotonghopluongtothoi
	@Tungay			Date,
	@Denngay		Date,
	@Macongnhan		Nvarchar(50)
--WITH Encryption As
As	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngay, Macongnhan, Tencongnhan
		, Mamang, Tenmang, SUM(ISNULL(Somet,0)) Somet, SUM(ISNULL(Sokg,0)) Sokg
	INTO #Ketquathoi0 
	FROM dbo.Ketquathoi
	WHERE Ngay BETWEEN @Tungay AND @Denngay
	GROUP BY Ngay, Macongnhan,Tencongnhan, Mamang, Tenmang

	Select Ngay, Mamang, Tenmang
			, Somet, Sokg
			, (Select COUNT(*) From dbo.SplitString(kq.Macongnhan,',')) As Socongnhan
			, cn.Value As Macongnhan
	Into #Ketquathoi1
	From #Ketquathoi0 kq 
		Cross Apply (Select * From dbo.SplitString(kq.Macongnhan,',')) As cn

	Select Ngay, Macongnhan, Tencongnhan, Mamang, Tenmang
			, SUM(ISNULL(Somet,0)) Somet, SUM(ISNULL(Sokg,0)) Sokg
			, Socongnhan
	Into #Ketquathoi
	From #Ketquathoi1 kq Inner Join dmcongnhan dm On dm.Macn=kq.Macongnhan
	Where (Macongnhan=@Macongnhan Or @Macongnhan='')
	GROUP BY Ngay, Macongnhan, Tencongnhan, Mamang, Tenmang, Socongnhan
	
	Select Macongnhan, Tencongnhan
			, SUM(Somet/Socongnhan) As Dauramet , SUM(Sokg/Socongnhan) As Daurakg
	From #Ketquathoi
	GROUP BY Macongnhan, Tencongnhan, Socongnhan
	Order By Macongnhan
	
GO

EXEC Baocaotonghopluongtothoi '08/01/2022', '11/30/2022', ''
