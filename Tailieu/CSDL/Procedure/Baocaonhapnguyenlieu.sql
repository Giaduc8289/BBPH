------------------------Báo cáo nhập kho nguyên liệu-------------
If Object_ID('dbo.Baocaonhapnguyenlieu','P') is not null
	Drop Procedure dbo.Baocaonhapnguyenlieu;
Go
Create Procedure dbo.Baocaonhapnguyenlieu
	@Tungay			Date,
	@Denngay		DATE,
	@Makho			NVARCHAR(50),
	@Manguyenlieu		Nvarchar(50),
	@Manhomnguyenlieu		Nvarchar(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngaynhap As Ngay, Makho, Tenkho, Manguyenlieu, Tennguyenlieu,
		   Soluong, Donvitinh, Malydo, Tenlydo, Sohopdongmua
	FROM dbo.Nhapkhonguyenlieu xk Left Join dbo.dmnguyenlieu nl on xk.Manguyenlieu = nl.Manl
	WHERE Ngaynhap BETWEEN @Tungay AND @Denngay 
		AND (Makho = @Makho OR @Makho='')
		AND (Manguyenlieu = @Manguyenlieu OR @Manguyenlieu = '')
		AND (Manhom = @Manhomnguyenlieu OR @Manhomnguyenlieu = '')
	ORDER BY Ngay, Tenkho,Tennhom, Tennguyenlieu
	
GO

EXEC Baocaonhapnguyenlieu '10/01/2022', '11/30/2022','','',''