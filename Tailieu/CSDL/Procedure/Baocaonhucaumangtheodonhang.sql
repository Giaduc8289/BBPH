------------------------Báo cáo nhu cầu màng theo đơn hàng-------------
If Object_ID('dbo.Baocaonhucaumangtheodonhang','P') is not null
	Drop Procedure dbo.Baocaonhucaumangtheodonhang;
Go
Create Procedure dbo.Baocaonhucaumangtheodonhang
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
	
	Select dh.*, sp.Tensp, ma.Mamang, ma.Tenmang, sp.Sohinh, sp.Dai
		, Soluong/Sohinh*Dai/1000 As Somet
	Into #Nhucau
	From #Dathang dh Left Join mangcuahang ma On ma.Masp=dh.Masp
		Left Join dmhang sp On sp.Masp=dh.Masp
	
	Select Madon, Ngaydat, nc.Makhach, kh.Tenkhach, Masp, Tensp, Ngaygiao, Soluong
		 , Mamang, Tenmang, Somet	
		 , Sohinh, Dai	 
	Into #Ketqua
	From #Nhucau nc Left Join dmkhach kh On nc.Makhach=kh.Makhach
	
	Select Mamang, Tenmang, Masp As Masanpham, Tensp As Tensanpham, Sohinh, Dai, Tenkhach, SUM(Soluong) As Soluong, SUM(Somet) As Somet
	From #Ketqua
	Group By Mamang, Tenmang, Masp, Tensp, Sohinh, Dai, Tenkhach	
	
GO

EXEC Baocaonhucaumangtheodonhang '', '', 'DH002', '', ''


