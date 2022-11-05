------------------------Báo cáo hàng trả lại-------------
If Object_ID('dbo.Baocaohangtralai','P') is not null
	Drop Procedure dbo.Baocaohangtralai;
Go
Create Procedure dbo.Baocaohangtralai
	@Tungay			Date,
	@Denngay		DATE,
	@Makhach		NVARCHAR(50),
	@Masanpham		Nvarchar(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngaygiao As Ngay, Sophieugiao, Madon, 
		   Makhach, Tenkhach, Masp, Tenhang, Ngaydat, Ngaytra, 
		   Soluonggiao As Soluong, Soluongtralai As Soluongtra, Nguyennhan As Ghichuchung
	FROM dbo.hangtralai
	WHERE Ngaygiao BETWEEN @Tungay AND @Denngay 
		AND (Makhach = @Makhach OR @Makhach='')
		AND (Masp = @Masanpham OR @Masanpham = '')
	ORDER BY Ngay, Tenkhach, Tenhang
	
GO

EXEC Baocaohangtralai '10/01/2022', '11/30/2022','',''


