------------------------Danh sách đơn đặt hàng không tồn-------------
If Object_ID('dbo.Danhsachdondathangchitietkhongton','P') is not null
	Drop Procedure dbo.Danhsachdondathangchitietkhongton;
Go

Create Procedure dbo.Danhsachdondathangchitietkhongton
	@Makhachhang	NVARCHAR(50),
	@Mahang			Nvarchar(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select *
	From dbo.donhang_d
	Where --(Soluongconlai > 0)
	(Makhach = @Makhachhang or @Makhachhang = '')
	and (Masp = @Mahang or @Mahang = '')
	order by Ngaydat
Go

Exec Danhsachdondathangchitietkhongton '', ''
