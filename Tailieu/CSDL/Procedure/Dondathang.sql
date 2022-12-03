------------------------Báo giá -------------
If Object_ID('dbo.Dondathang','P') is not null
	Drop Procedure dbo.Dondathang;
Go
Create Procedure dbo.Dondathang
	--@Ngaydathang		DATETIME,
	@Madondathang	NVARCHAR(20)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select ct.Madon, Masp As Masanpham, Tenhang As Tensanpham
		, Soluong, Dongia, Ngaygiao
	From donhang_d ct Left Join donhang_h th On th.Madon=ct.Madon
	Where ct.Madon = @Madondathang 
		--AND ct.Ngaydat = @Ngaydathang

GO

EXEC dbo.Dondathang 'DH002'

SELECT * FROM dbo.donhang_d