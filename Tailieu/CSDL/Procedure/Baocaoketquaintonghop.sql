------------------------Kết quả in tổng hợp-------------
If Object_ID('dbo.Baocaoketquaintonghop','P') is not null
	Drop Procedure dbo.Baocaoketquaintonghop;
Go
Create Procedure dbo.Baocaoketquaintonghop
	@Tungay			Date,
	@Denngay		DATE,
	@Mamay			NVARCHAR(50),
	@Makhach		NVARCHAR(50),
	@Masanpham		Nvarchar(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Makhach, Tenkhach, Masanpham, Tensanpham, Ngay, Sum(SometLSX) As SoluongLSX 
		, Sum(Sometcap) As Dauvaomet, Sum(Sokgcap) As Dauvaokg
		, Sum(Thuctein) As Dauramet, Sum(Sokgin) As Daurakg
		, Avg(Nangsuat) As Nangsuat, Avg(Tylesaihong) As Tylesaihong
	FROM dbo.Ketquain kq Left Join dmhang sp on kq.Masanpham=sp.Masp
	WHERE Ngay BETWEEN @Tungay AND @Denngay 
		AND (Mamay = @Mamay OR @Mamay='')
		AND (Makhach = @Makhach OR @Makhach = '')
		AND (kq.Masanpham = @Masanpham OR @Masanpham = '')
	Group By Makhach, Tenkhach, Masanpham, Tensanpham, Ngay
	ORDER BY Makhach, Tenkhach, Masanpham, Tensanpham, Ngay
	
GO

EXEC Baocaoketquaintonghop '10/01/2022', '11/30/2022','','',''


