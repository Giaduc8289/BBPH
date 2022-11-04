------------------------Báo cáo tồn kho sản phẩm-------------
If Object_ID('dbo.Baocaotonkhosp','P') is not null
	Drop Procedure dbo.Baocaotonkhosp;
Go
Create Procedure dbo.Baocaotonkhosp
	@Ngay			Date,
	@Makho			NVARCHAR(50),
	@Masanpham		Nvarchar(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Declare @v_Ngaykiemke		Date
	
	--Lấy ngày kiểm kê gần nhất
	Select @v_Ngaykiemke=dbo.fNgaykiemkesanpham(@Ngay)
	
	--Lấy số liệu tại thời điểm kiểm kê gần nhất
	Select Makho, Tenkho, Masanpham, Tensanpham
		, SUM(isNull(Somet,0)) As Somet, SUM(isNull(Sokg,0)) As Sokg, SUM(isNull(Soluong,0)) As Soluong
	Into #Sodu
	From Sodusanpham
	Where Ngaykiemke=@v_Ngaykiemke
		And (Makho=@Makho Or @Makho='')
		And (Masanpham=@Masanpham Or @Masanpham='')
	Group By Makho, Tenkho, Masanpham, Tensanpham
	
	--Lấy số liệu nhập kho từ ngày kiểm kê đến ngày báo cáo
	Select Makho, Tenkho, Masanpham, Tensanpham
		, SUM(isNull(Somet,0)) As Somet, SUM(isNull(Sokg,0)) As Sokg, SUM(isNull(Soluong,0)) As Soluong
	Into #Nhap
	From Nhapkhosanpham
	Where Ngaynhap BETWEEN @v_Ngaykiemke And @Ngay
		And (Makho=@Makho Or @Makho='')
		And (Masanpham=@Masanpham Or @Masanpham='')
	Group By Makho, Tenkho, Masanpham, Tensanpham
	
	--Lấy số liệu xuất kho từ ngày kiểm kê đến ngày báo cáo
	Select Makho, Tenkho, Masanpham, Tensanpham
		, SUM(isNull(Somet,0)) As Somet, SUM(isNull(Sokg,0)) As Sokg, SUM(isNull(Soluong,0)) As Soluong
	Into #Xuat
	From Xuatkhosanpham
	Where Ngayxuat BETWEEN @v_Ngaykiemke And @Ngay
		And (Makho=@Makho Or @Makho='')
		And (Masanpham=@Masanpham Or @Masanpham='')
	Group By Makho, Tenkho, Masanpham, Tensanpham
	
	Select Makho, Tenkho, Masanpham, Tensanpham
		, Somet, Sokg, Soluong
	Into #Ketqua
	From #Sodu
	UNION
	Select Makho, Tenkho, Masanpham, Tensanpham
		, Somet, Sokg, Soluong
	From #Nhap
	UNION
	Select Makho, Tenkho, Masanpham, Tensanpham
		, -Somet, -Sokg, -Soluong
	From #Xuat
	
	Select Makho, Tenkho, Masanpham, Tensanpham
		, SUM(Somet) As Somet, SUM(Sokg) As Sokg, SUM(Soluong) As Soluong
	From #Ketqua
	Group By Makho, Tenkho, Masanpham, Tensanpham
	
GO

EXEC Baocaotonkhosp '11/30/2022','',''

