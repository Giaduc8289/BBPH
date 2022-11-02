------------------------K?t qu? chia chi ti?t-------------
If Object_ID('dbo.Baocaoketquachiachitiet','P') is not null
	Drop Procedure dbo.Baocaoketquachiachitiet;
Go
Create Procedure dbo.Baocaoketquachiachitiet
	@Tungay			Date,
	@Denngay		DATE,
	@Mamay			NVARCHAR(50),
	@Makhach		NVARCHAR(50),
	@Masanpham		Nvarchar(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngay, Ca, Mamay, Tenmay, Lenh As Lenhsanxuat
		, Masanpham, Tensanpham, Makhach, Tenkhach, Macongnhan, Tencongnhan
		, Dauraghep
		, Sometvao As Dauvaomet, Sokgvao As Dauvaokg, Phein, Phechia, Pheghep, PhethoiNCC As Phenhacungcap, Phesx As Phesanxuat, Socuon
	FROM dbo.Ketquachia kq Left Join dmhang sp on kq.Masanpham=sp.Masp
	WHERE Ngay BETWEEN @Tungay AND @Denngay 
		AND (Mamay = @Mamay OR @Mamay='')
		AND (Makhach = @Makhach OR @Makhach = '')
		AND (kq.Masanpham = @Masanpham OR @Masanpham = '')
	ORDER BY Ngay, Mamay, Ca
	
GO

EXEC Baocaoketquachiachitiet '10/01/2022', '11/30/2022','','',''


