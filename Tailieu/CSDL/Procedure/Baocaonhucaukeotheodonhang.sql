------------------------Báo cáo nhu cầu keo theo đơn hàng-------------
If Object_ID('dbo.Baocaonhucaukeotheodonhang','P') is not null
	Drop Procedure dbo.Baocaonhucaukeotheodonhang;
Go
Create Procedure dbo.Baocaonhucaukeotheodonhang
	@Tungay			Date,
	@Denngay		DATE,
	@Madon			Nvarchar(50),
	@Makhach		NVARCHAR(50),
	@Masanpham		Nvarchar(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Madon, Ngaydat, Makhach, Masp, Ngaygiao, Sum(isNull(Soluong,0)) As Soluong 
	Into #Dathang
	From donhang_d
	Where (Ngaydat between @Tungay And @Denngay Or (Ngaydat<=@Denngay And isNull(@Tungay,'')='') 
				Or (Ngaydat>=@Tungay And isNull(@Denngay,'')='') Or (isNull(@Tungay,'')='' And isNull(@Denngay,'')=''))
		And (Madon=@Madon Or @Madon='')
		And (Makhach=@Makhach Or @Makhach='')
		And (Masp=@Masanpham Or @Masanpham='')
	Group By Madon, Ngaydat, Makhach, Masp, Ngaygiao
	
	Select dh.*, sp.Tensp, ma.Mamang, ma.Tenmang, sp.Sohinh, sp.Dai, sp.Khomang
		, Maloaikeo, Tenloaikeo, Dinhmuckeouot, Maloaidongran, Tenloaidongran, Dinhmucdongranuot
		, Soluong/sp.Sohinh*sp.Khomang*2/1000 As Dientich
	Into #Nhucau
	From #Dathang dh Left Join mangcuahang ma On ma.Masp=dh.Masp
		Left Join dmhang sp On sp.Masp=dh.Masp
		
	Select 'Keo' As Loai
		, Masp, Tensp, Soluong
		, Maloaikeo As Mahieu, Tenloaikeo As Tenhieu, Dinhmuckeouot As Dinhmuc
		, Dientich*Dinhmuckeouot/10000 As Sokg
	Into #Ketqua
	From #Nhucau
	Union
	Select N'Đóng rắn' As Loai
		, Masp, Tensp, Soluong
		, Maloaidongran, Tenloaidongran, Dinhmucdongranuot
		, Dientich*Dinhmucdongranuot/10000 As Sokg
	From #Nhucau
		
	Select Loai, Mahieu, Tenhieu, Dinhmuc
		, Masp As Masanpham, Tensp As Tensanpham, Soluong
		, SUM(Sokg) As Sokg
	From #Ketqua
	Where ISNULL(Mahieu,'')<>''
	Group By Loai, Mahieu, Tenhieu, Dinhmuc, Masp, Tensp, Soluong
		
GO

EXEC Baocaonhucaukeotheodonhang '', '', 'DH002', '', ''
