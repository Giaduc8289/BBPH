------------------------Báo cáo nhu cầu mực theo đơn hàng-------------
If Object_ID('dbo.Baocaonhucaumuctheodonhang','P') is not null
	Drop Procedure dbo.Baocaonhucaumuctheodonhang;
Go
Create Procedure dbo.Baocaonhucaumuctheodonhang
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
	
	Select dh.*, sp.Tensp, sp.Rong, sp.Dai, sp.Khoiluongmuc
		, mh.Mamau, mh.Tenmau, mh.Tylebaophu
		, tp.Mausudung, tp.Tenmausudung, tp.Tyle
		, Soluong/Sohinh*Dai/1000 As Somet
	Into #Nhucau
	From #Dathang dh Left Join dmhang sp On sp.Masp=dh.Masp
		Left Join maucuahang mh On mh.Masp=dh.Masp
		Left Join thanhphanmau tp On tp.Mamau=mh.Mamau
		
	Select Madon, Ngaydat, Makhach, Masp, Tensp, Ngaygiao, Soluong, Somet
		, Mausudung, Tenmausudung, (Soluong*Rong/1000*Dai/1000) * (Tyle*Tylebaophu/10000*Khoiluongmuc) As Sokg
	Into #Ketqua
	From #Nhucau

	Select Mausudung As Mamau, Tenmausudung As Tenmau, Masp As Masanpham, Tensp As Tensanpham, Soluong, SUM(Sokg) As Sokg
	From #Ketqua
	Group By Mausudung, Tenmausudung, Masp, Tensp, Soluong	
	
GO

EXEC Baocaonhucaumuctheodonhang '', '', 'DH002', '', ''


