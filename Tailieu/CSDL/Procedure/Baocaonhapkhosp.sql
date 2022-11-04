------------------------Báo cáo nhập kho sản phẩm-------------
If Object_ID('dbo.Baocaonhapkhosp','P') is not null
	Drop Procedure dbo.Baocaonhapkhosp;
Go
Create Procedure dbo.Baocaonhapkhosp
	@Tungay			Date,
	@Denngay		DATE,
	@Makho			NVARCHAR(50),
	@Malydo			NVARCHAR(50),
	@Masanpham		Nvarchar(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngaynhap As Ngay, Makho, Tenkho, Masanpham, Tensanpham,
		   Soluong, Somet, Sokg, Malydo, Tenlydo, Lenhsx As Lenhsanxuat,
		   Sohopdongmua
	FROM dbo.Nhapkhosanpham xk
	WHERE Ngaynhap BETWEEN @Tungay AND @Denngay 
		AND (Makho = @Makho OR @Makho='')
		AND (Malydo = @Malydo OR @Malydo = '')
		AND (Masanpham = @Masanpham OR @Masanpham = '')
	ORDER BY Ngay, Tenkho, Tensanpham
	
GO

EXEC Baocaonhapkhosp '10/01/2022', '11/30/2022','','',''

