------------------------Báo cáo tổng hợp lương tổ in-------------
If Object_ID('dbo.Baocaotonghopluongtoin','P') is not null
	Drop Procedure dbo.Baocaotonghopluongtoin
Go

Create Procedure Baocaotonghopluongtoin
	@Tungay			Date,
	@Denngay		Date,
	@Macongnhan		Nvarchar(50)
--WITH Encryption As
As	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngay, Macongnhan, Tencongnhan
		, Masanpham, Tensanpham, SUM(ISNULL(SometLSX,0)) SometLSX, SUM(ISNULL(Sometcap,0)) Sometcap, SUM(ISNULL(Sokgcap,0)) Sokgcap
		, SUM(ISNULL(Thuctein,0)) Thuctein, SUM(ISNULL(Sokgin,0)) Sokgin
	INTO #Ketquain0 
	FROM dbo.Ketquain
	WHERE Ngay BETWEEN @Tungay AND @Denngay
	GROUP BY Ngay, Macongnhan,Tencongnhan, Masanpham, Tensanpham

	Select Ngay, Masanpham, Tensanpham
			, SometLSX, Sometcap, Sokgcap, Thuctein, Sokgin
			, (Select COUNT(*) From dbo.SplitString(kq.Macongnhan,',')) As Socongnhan
			, cn.Value As Macongnhan
	Into #Ketquain1
	From #Ketquain0 kq 
		Cross Apply (Select * From dbo.SplitString(kq.Macongnhan,',')) As cn

	Select Ngay, Macongnhan, Tencongnhan, Masanpham, Tensanpham
			, SUM(ISNULL(SometLSX,0)) SometLSX, SUM(ISNULL(Sometcap,0)) Sometcap, SUM(ISNULL(Sokgcap,0)) Sokgcap
			, SUM(ISNULL(Thuctein,0)) Thuctein, SUM(ISNULL(Sokgin,0)) Sokgin
			, Socongnhan
	Into #Ketquain
	From #Ketquain1 kq Inner Join dmcongnhan dm On dm.Macn=kq.Macongnhan
	Where (Macongnhan=@Macongnhan Or @Macongnhan='')
	GROUP BY Ngay, Macongnhan, Tencongnhan, Masanpham, Tensanpham, Socongnhan
	
	Select Macongnhan, Tencongnhan
			, SUM(SometLSX/Socongnhan)  SoluongLSX, SUM(Sometcap/Socongnhan) Dauvaomet, SUM(Sokgcap/Socongnhan) Dauvaokg
			, SUM(Thuctein/Socongnhan ) Dauramet, SUM(Sokgin/Socongnhan) Daurakg
	From #Ketquain
	GROUP BY Macongnhan, Tencongnhan, Socongnhan
	Order By Macongnhan 
	
GO

EXEC Baocaotonghopluongtoin '08/01/2022', '11/30/2022', ''
