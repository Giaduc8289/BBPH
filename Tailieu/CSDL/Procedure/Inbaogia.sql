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
	
	Select ct.Sobaogia, Masp As Masanpham, Tensp As Tensanpham
		, Cautruc, Rong, Dai, Trongluong, Tenqcthanhpham, Tenqcloaithung, Tenqcdonggoi
		, Mota
		, DongiakhongVAT, DongiaVAT As Dongia
	From baogia_d ct Left Join baogia_h th On th.Sobaogia=ct.Sobaogia
	Where ct.Sobaogia = @Sobaogia AND Ngaybaogia = @Ngaybaogia

GO

EXEC dbo.Inbaogia '11/08/2022','BG002'

SELECT * FROM dbo.Baogia_h