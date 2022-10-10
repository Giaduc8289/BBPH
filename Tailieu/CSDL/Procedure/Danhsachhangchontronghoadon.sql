------------------------Danh sách hàng chọn trong hóa đơn (phiếu xuất hàng bán)-------------
If Object_ID('dbo.Danhsachhangchontronghoadon','P') is not null
	Drop Procedure dbo.Danhsachhangchontronghoadon;
Go

Create Procedure dbo.Danhsachhangchontronghoadon
	@Makhach		NVARCHAR(250),
	@Ngay			DATE
As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT DISTINCT dh.Masp, /*dh.Mauin,*/ dh.Loaihang, /*hh.Kichthuocbao,*/ ISNULL(Loaihang,0) AS Loaihang
	FROM dbo.Donhang_d dh LEFT JOIN dbo.dmhang hh ON dh.Masp=hh.Masp
	WHERE dh.Makhach=@Makhach AND Ngaydat<=@Ngay
	ORDER BY dh.Loaihang
	
Go

Exec Danhsachhangchontronghoadon 'DHVP', '10/30/2021'
--SELECT * FROM dbo.Baogia_d WHERE Sobaogia='001'
--SELECT * FROM dbo.Baogia_h