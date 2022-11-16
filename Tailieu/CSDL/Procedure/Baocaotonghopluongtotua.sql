------------------------Báo cáo t?ng h?p l??ng t? tua-------------
If Object_ID('dbo.Baocaotonghopluongtotua','P') is not null
	Drop Procedure dbo.Baocaotonghopluongtotua
Go

Create Procedure Baocaotonghopluongtotua
	@Tungay			Date,
	@Denngay		Date,
	@Macongnhan		Nvarchar(50)
--WITH Encryption As
As	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngay, Macongnhan, Tencongnhan
		, Masanpham, Tensanpham, SUM(ISNULL(SoMetvao,0)) SoMetvao, SUM(ISNULL(SoKgvao,0)) SoKgvao
		, SUM(ISNULL(SoMetra,0)) SoMetra, SUM(ISNULL(SoKgra,0)) SoKgra
	INTO #Ketquatua0 
	FROM dbo.Ketquatua
	WHERE Ngay BETWEEN @Tungay AND @Denngay
	GROUP BY Ngay, Macongnhan, Tencongnhan, Masanpham, Tensanpham

	Select Ngay, Masanpham, Tensanpham
			, SoMetvao, SoKgvao, SoMetra, SoKgra
			, (Select COUNT(*) From dbo.SplitString(kq.Macongnhan,',')) As Socongnhan
			, cn.Value As Macongnhan
	Into #Ketquatua1
	From #Ketquatua0 kq 
		Cross Apply (Select * From dbo.SplitString(kq.Macongnhan,',')) As cn

	Select Ngay, Macongnhan, Tencongnhan, Masanpham, Tensanpham
			, SUM(ISNULL(SoMetvao,0)) SoMetvao, SUM(ISNULL(SoKgvao,0)) SoKgvao
			, SUM(ISNULL(SoMetra,0)) SoMetra, SUM(ISNULL(SoKgra,0)) SoKgra
			, Socongnhan
	Into #Ketquatua
	From #Ketquatua1 kq Inner Join dmcongnhan dm On dm.Macn=kq.Macongnhan
	Where (Macongnhan=@Macongnhan Or @Macongnhan='')
	GROUP BY Ngay, Macongnhan, Tencongnhan, Masanpham, Tensanpham, Socongnhan

	Select Macongnhan, Tencongnhan
			, SUM(SoMetvao/Socongnhan) Dauvaomet, SUM(SoKgvao/Socongnhan) Dauvaokg
			, SUM(SoMetra/Socongnhan) Dauramet, SUM(SoKgra/Socongnhan) Daurakg
	From #Ketquatua
	GROUP BY Macongnhan, Tencongnhan, Socongnhan
	Order By Macongnhan
	
GO

EXEC Baocaotonghopluongtotua '10/01/2022', '11/30/2022', ''
