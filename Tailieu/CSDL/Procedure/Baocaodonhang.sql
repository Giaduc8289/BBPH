------------------------Báo cáo ??n hàng-------------
If Object_ID('dbo.Baocaodonhang','P') is not null
	Drop Procedure dbo.Baocaodonhang;
Go
Create Procedure dbo.Baocaodonhang
	@Tungay			Date,
	@Denngay		DATE,
	@Makhach		NVARCHAR(50),
	@Masanpham		Nvarchar(50),
	@Manhanvien		Nvarchar(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT dhh.Ngaydat As Ngay, dhh.Madon As Madon, Userid As Macongnhan, dhh.Tennv As Tencongnhan, dhh.Tenkhach As Tenkhach, dhh.Sobaogia As Sobaogia, dhh.Ghichu As Ghichuchung, dhh.Makhach As Makhach,
		   dhd.Masp As Masanpham, dhd.Tenhang As Tensanpham, Soluong, Dongia, dhd.Ghichu As Ghichusp
	FROM dbo.donhang_h dhh Left Join donhang_d dhd on dhh.Madon = dhd.Madon
						   Left Join dmhang sp on dhd.Masp = sp.Masp
	WHERE dhh.Ngaydat BETWEEN @Tungay AND @Denngay 
		AND (dhh.Makhach = @Makhach OR @Makhach = '')
		AND (dhd.Masp = @Masanpham OR @Masanpham = '')
		And (Userid = @Manhanvien OR @Manhanvien = '')
	ORDER BY Ngay, Tencongnhan, Madon
	
GO

EXEC Baocaodonhang '10/01/2022', '11/30/2022','','', ''


