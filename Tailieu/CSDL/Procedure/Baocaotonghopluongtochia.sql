------------------------Báo cáo tổng hợp lương tổ chia-------------
If Object_ID('dbo.Baocaotonghopluongtochia','P') is not null
	Drop Procedure dbo.Baocaotonghopluongtochia
Go

Create Procedure Baocaotonghopluongtochia
	@Tungay			Date,
	@Denngay		Date,
	@Macongnhan		Nvarchar(50)
--WITH Encryption As
As	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngay, Macongnhan, Tencongnhan
		, Masanpham, Tensanpham, SUM(ISNULL(Sometra,0)) Sometra, SUM(ISNULL(Sokgra,0)) Sokgra, SUM(ISNULL(Sometvao,0)) Sometvao, SUM(ISNULL(Sokgvao,0)) Sokgvao
	INTO #Ketquain0 
	FROM dbo.Ketquachia
	WHERE Ngay BETWEEN @Tungay AND @Denngay
	GROUP BY Ngay, Macongnhan,Tencongnhan, Masanpham, Tensanpham

	Select Ngay, Masanpham, Tensanpham
			, Sometra, Sokgra, Sometvao, Sokgvao
			, (Select COUNT(*) From dbo.SplitString(kq.Macongnhan,',')) As Socongnhan
			, cn.Value As Macongnhan
	Into #Ketquain1
	From #Ketquain0 kq 
		Cross Apply (Select * From dbo.SplitString(kq.Macongnhan,',')) As cn

	Select Ngay, Macongnhan, Tencongnhan, Masanpham, Tensanpham
			, SUM(Sometvao/Socongnhan) Sometvao, SUM(Sokgvao/Socongnhan) Sokgvao
			, SUM(ISNULL(Sometra,0)) Sometra, SUM(ISNULL(Sokgra,0)) Sokgra
			, Socongnhan
	Into #Ketquain
	From #Ketquain1 kq Inner Join dmcongnhan dm On dm.Macn=kq.Macongnhan
	Where (Macongnhan=@Macongnhan Or @Macongnhan='')
	GROUP BY Ngay, Macongnhan, Tencongnhan, Masanpham, Tensanpham, Socongnhan
	
	Select Macongnhan, Tencongnhan
			, SUM(Sometvao/Socongnhan) Dauvaomet, SUM(Sokgvao/Socongnhan) Dauvaokg
			, SUM(Sometra/Socongnhan ) Dauramet, SUM(Sokgra/Socongnhan) Daurakg
	From #Ketquain
	GROUP BY Macongnhan, Tencongnhan, Socongnhan
	Order By Macongnhan 
	
GO

EXEC Baocaotonghopluongtochia '08/01/2022', '11/17/2022', ''
