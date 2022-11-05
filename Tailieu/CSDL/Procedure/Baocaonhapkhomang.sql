------------------------Báo cáo nhập kho màng-------------
If Object_ID('dbo.Baocaonhapkhomang','P') is not null
	Drop Procedure dbo.Baocaonhapkhomang;
Go
Create Procedure dbo.Baocaonhapkhomang
	@Tungay			Date,
	@Denngay		DATE,
	@Makho			NVARCHAR(50),
	@Malydo			NVARCHAR(50),
	@Mamang		Nvarchar(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngaynhap As Ngay, Makho, Tenkho, Mamang, Tenmang,
		   Somet, Sokg, Malydo, Tenlydo, Lenhsx As Lenhsanxuat,
		   Sohopdongmua
	FROM dbo.Nhapkhomang xk
	WHERE Ngaynhap BETWEEN @Tungay AND @Denngay 
		AND (Makho = @Makho OR @Makho='')
		AND (Malydo = @Malydo OR @Malydo = '')
		AND (Mamang = @Mamang OR @Mamang = '')
	ORDER BY Ngay, Tenkho, Tenmang
	
GO

EXEC Baocaonhapkhomang '10/01/2022', '11/30/2022','','',''

