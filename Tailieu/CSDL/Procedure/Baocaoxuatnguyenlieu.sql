------------------------Báo cáo xuất kho nguyên liệu-------------
If Object_ID('dbo.Baocaoxuatnguyenlieu','P') is not null
	Drop Procedure dbo.Baocaoxuatnguyenlieu;
Go
Create Procedure dbo.Baocaoxuatnguyenlieu
	@Tungay			Date,
	@Denngay		DATE,
	@Makho			NVARCHAR(50),
	@Manguyenlieu		Nvarchar(50),
	@Manhomnguyenlieu		Nvarchar(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngayxuat As Ngay, Makho, Tenkho, Manguyenlieu, Tennguyenlieu,
		   Soluong, Donvitinh, Malydo, Tenlydo, Lenhxuat,
		   nl.Manhom, nl.Tennhom
	FROM dbo.Xuatkhonguyenlieu xk Left Join dbo.dmnguyenlieu nl on xk.Manguyenlieu = nl.Manl
	WHERE Ngayxuat BETWEEN @Tungay AND @Denngay 
		AND (Makho = @Makho OR @Makho='')
		AND (Manguyenlieu = @Manguyenlieu OR @Manguyenlieu = '')
		AND (Manhom = @Manhomnguyenlieu OR @Manhomnguyenlieu = '')
	ORDER BY Ngay, Tenkho,Tennhom, Tennguyenlieu
	
GO

EXEC Baocaoxuatnguyenlieu '10/01/2022', '11/30/2022','','',''


