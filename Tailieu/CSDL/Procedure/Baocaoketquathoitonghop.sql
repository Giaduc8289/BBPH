------------------------Kết quả thổi tổng hợp-------------
If Object_ID('dbo.Baocaoketquathoitonghop','P') is not null
	Drop Procedure dbo.Baocaoketquathoitonghop;
Go
Create Procedure dbo.Baocaoketquathoitonghop
	@Tungay			Date,
	@Denngay		DATE,
	@Mamay			NVARCHAR(50),
	@Makhach		NVARCHAR(50),
	@Masanpham		Nvarchar(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngay, Mamay, Tenmay--, Lenhthoi As Lenhsanxuat
		, kq.Mamang As Masanpham, kq.Tenmang As Tensanpham--, Makhach, Tenkhach, Macongnhan, Tencongnhan
		--, Sometcap As Dauvaomet, Sokgcap As Dauvaokg
		, Sum(Somet) As Dauramet, Sum(Sokg) As Daurakg
		, Avg(Nangsuat) As Nangsuat, Avg(Chatluong) As Chatluong
	FROM dbo.Ketquathoi kq Left Join dmmang m on kq.Mamang=m.Mamang
	WHERE Ngay BETWEEN @Tungay AND @Denngay 
		AND (Mamay = @Mamay OR @Mamay='')
		AND (Makhach = @Makhach OR @Makhach = '')
		AND (kq.Mamang = @Masanpham OR @Masanpham = '')
	GROUP BY Ngay, Mamay, Tenmay, kq.Mamang, kq.Tenmang
	ORDER BY Ngay, Mamay, Tenmay--, kq.Mamang, kq.Tenmang
	
GO

EXEC Baocaoketquathoitonghop '10/01/2022', '11/30/2022','','',''


--select * from Ketquathoi
--select * from Tknguyenlieuthoi
--select * from dmmang