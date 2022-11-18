------------------------Báo cáo tổng hợp lương tổ in-------------
If Object_ID('dbo.Baocaoluongtoin','P') is not null
	Drop Procedure dbo.Baocaoluongtoin
Go

Create Procedure Baocaoluongtoin
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

	Select Ngay, Macongnhan, Tencongnhan, Macv, Masanpham, Tensanpham
			, SUM(ISNULL(SometLSX,0)) SometLSX, SUM(ISNULL(Sometcap,0)) Sometcap, SUM(ISNULL(Sokgcap,0)) Sokgcap
			, SUM(ISNULL(Thuctein,0)) Thuctein, SUM(ISNULL(Sokgin,0)) Sokgin
			, Socongnhan
	Into #Ketquain
	From #Ketquain1 kq Inner Join dmcongnhan dm On dm.Macn=kq.Macongnhan
	Where (Macongnhan=@Macongnhan Or @Macongnhan='')
	GROUP BY Ngay, Macongnhan, Tencongnhan, Macv, Masanpham, Tensanpham, Socongnhan
	
	Select Ngay, Macongnhan, Tencongnhan, Masanpham, Tensanpham
			, SometLSX/Socongnhan As SoluongLSX, Sometcap/Socongnhan As Dauvaomet, Sokgcap/Socongnhan As Dauvaokg
			, Thuctein/Socongnhan As Dauramet, Sokgin/Socongnhan As Daurakg
			, Heso
	From #Ketquain kq Left Join dmchucvu cv on cv.Macv=kq.Macv
	Order By Macongnhan, Masanpham
	
GO

EXEC Baocaoluongtoin '08/01/2022', '11/30/2022', ''
