------------------------Báo cáo tồn kho nguyên liệu-------------
If Object_ID('dbo.Baocaotonkhonguyenlieu','P') is not null
	Drop Procedure dbo.Baocaotonkhonguyenlieu;
Go
Create Procedure dbo.Baocaotonkhonguyenlieu
	@Ngay			Date,
	@Makho			NVARCHAR(50),
	@Manguyenlieu		Nvarchar(50),
	@Manhomnguyenlieu		Nvarchar(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Declare @v_Ngaykiemke		Date
	
	--Lấy ngày kiểm kê gần nhất
	Select @v_Ngaykiemke=dbo.fNgaykiemkenguyenlieu(@Ngay)
	
	--Lấy số liệu tại thời điểm kiểm kê gần nhất
	Select Makho, Tenkho, Manguyenlieu, Tennguyenlieu
		   ,SUM(isNull(Soluong,0)) As Soluong, Donvitinh
	Into #Sodu
	From Sodunguyenlieu Left Join Dmnguyenlieu nl on nl.Manl = Manguyenlieu
	Where Ngaykiemke=@v_Ngaykiemke
		And (Makho=@Makho Or @Makho='')
		And (Manguyenlieu=@Manguyenlieu Or @Manguyenlieu='')
		AND (Manhom = @Manhomnguyenlieu OR @Manhomnguyenlieu = '')

	Group By Makho, Tenkho, Manguyenlieu, Tennguyenlieu, Donvitinh
	
	--Lấy số liệu nhập kho từ ngày kiểm kê đến ngày báo cáo
	Select Makho, Tenkho, Manguyenlieu, Tennguyenlieu
		, SUM(isNull(Soluong,0)) As Soluong, Donvitinh
	Into #Nhap
	From Nhapkhonguyenlieu Left Join Dmnguyenlieu nl on nl.Manl = Manguyenlieu
	Where Ngaynhap BETWEEN @v_Ngaykiemke And @Ngay
		And (Makho=@Makho Or @Makho='')
		And (Manguyenlieu=@Manguyenlieu Or @Manguyenlieu='')
		AND (Manhom = @Manhomnguyenlieu OR @Manhomnguyenlieu = '')

	Group By Makho, Tenkho, Manguyenlieu, Tennguyenlieu, Donvitinh
	
	--Lấy số liệu xuất kho từ ngày kiểm kê đến ngày báo cáo
	Select Makho, Tenkho, Manguyenlieu, Tennguyenlieu
		  , SUM(isNull(Soluong,0)) As Soluong, Donvitinh
	Into #Xuat
	From Xuatkhonguyenlieu Left Join Dmnguyenlieu nl on nl.Manl = Manguyenlieu
	Where Ngayxuat BETWEEN @v_Ngaykiemke And @Ngay
		And (Makho=@Makho Or @Makho='')
		And (Manguyenlieu=@Manguyenlieu Or @Manguyenlieu='')
		AND (Manhom = @Manhomnguyenlieu OR @Manhomnguyenlieu = '')

	Group By Makho, Tenkho, Manguyenlieu, Tennguyenlieu, Donvitinh
	
	Select Makho, Tenkho, Manguyenlieu, Tennguyenlieu
		  , Soluong, Donvitinh
	Into #Ketqua
	From #Sodu
	UNION
	Select Makho, Tenkho, Manguyenlieu, Tennguyenlieu
		  , Soluong, Donvitinh
	From #Nhap
	UNION
	Select Makho, Tenkho, Manguyenlieu, Tennguyenlieu
		, -Soluong, Donvitinh
	From #Xuat
	
	Select Makho, Tenkho, Manguyenlieu, Tennguyenlieu
		, SUM(Soluong) As Soluong, Donvitinh
	From #Ketqua
	Group By Makho, Tenkho, Manguyenlieu, Tennguyenlieu, Donvitinh
	
GO

EXEC Baocaotonkhonguyenlieu '11/30/2022','','',''

