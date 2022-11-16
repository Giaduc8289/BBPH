------------------------Báo cáo tổng hợp lương tổ tua-------------
If Object_ID('dbo.Baocaoluongtotua','P') is not null
	Drop Procedure dbo.Baocaoluongtotua
Go

Create Procedure Baocaoluongtotua
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

	Select Ngay, Macongnhan, Tencongnhan,Masanpham, Tensanpham
			, SoMetvao/Socongnhan As Dauvaomet, SoKgvao/Socongnhan As Dauvaokg
			, SoMetra/Socongnhan As Dauramet, SoKgra/Socongnhan As Daurakg
	From #Ketquatua
	Order By Macongnhan, Masanpham
	
GO

EXEC Baocaoluongtotua '10/01/2022', '11/30/2022', ''
