------------------------Báo giá -------------
If Object_ID('dbo.Inbaogia','P') is not null
	Drop Procedure dbo.Inbaogia;
Go
Create Procedure dbo.Inbaogia
	@Ngaybaogia		DATETIME,
	@Sobaogia		NVARCHAR(20)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT bg.*, hh.Loai, hh.Chatluongkhachyeucau, hh.Chatluongnoibo
		, Diachi, Sodienthoai, Sofax, Masothue, Taikhoannganhang, Tennganhang, Email
		, Nguoilienhehoten, Nguoilienhechucvu, Nguoilienhesodienthoai, Nguoilienhethongtinbosung, Tenrutgon
	FROM dbo.Baogia_d bg LEFT JOIN dbo.Danhmuchanghoa hh ON hh.Mahieu=bg.Mahang
		LEFT join Danhmuckhach kh on kh.Mahieu = hh.Makhach
	WHERE Sobaogia = @Sobaogia AND Ngaybaogia = @Ngaybaogia

GO

EXEC dbo.Inbaogia '03/04/2021','bg001'

SELECT * FROM dbo.Baogia_d