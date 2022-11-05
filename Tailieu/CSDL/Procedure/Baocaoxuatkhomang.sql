------------------------Báo cáo xuất màng-------------
If Object_ID('dbo.Baocaoxuatkhomang','P') is not null
	Drop Procedure dbo.Baocaoxuatkhomang;
Go
Create Procedure dbo.Baocaoxuatkhomang
	@Tungay		Date,
	@Denngay	DATE,
	@Mamang		NVARCHAR(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT kh.Mamang, kh.Tenmang, kh.Tenkho, Tenkhach,  kh.Sophieugiao
		, Ngayxuat AS Ngay, Somet, Sokg
		, Lenhsx, Malydo, Tenlydo
	FROM dbo.Xuatkhomang kh Left Join dmmang dm on dm.Mamang=kh.Mamang
	WHERE Ngayxuat BETWEEN @Tungay AND @Denngay
		AND	(kh.Mamang=@Mamang OR @Mamang='')
	ORDER BY Mamang, Ngayxuat
	

Go

Exec Baocaoxuatkhomang '10/01/2022', '11/30/2022', ''

--SELECT * FROM dbo.Baocaoxuatkhomang