------------------------Báo cáo xuất kho hàng-------------
If Object_ID('dbo.Baocaoxuathang','P') is not null
	Drop Procedure dbo.Baocaoxuathang;
Go
Create Procedure dbo.Baocaoxuathang
	@Tungay			Date,
	@Denngay		DATE,
	@Makho			NVARCHAR(50),
	@Malydo			NVARCHAR(50),
	@Masanpham		Nvarchar(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngayxuat As Ngay, Makho, Tenkho, Masanpham, Tensanpham,
		   Soluong, Somet, Sokg, Malydo, Tenlydo, Lenhsx As Lenhsanxuat,
		   Sophieugiao, Madonhang As Madon
	FROM dbo.Xuatkhosanpham xk
	WHERE Ngayxuat BETWEEN @Tungay AND @Denngay 
		AND (Makho = @Makho OR @Makho='')
		AND (Malydo = @Malydo OR @Malydo = '')
		AND (Masanpham = @Masanpham OR @Masanpham = '')
	ORDER BY Ngay, Tenkho, Tensanpham
	
GO

EXEC Baocaoxuathang '10/01/2022', '11/30/2022','','',''


