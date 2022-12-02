------------------------Hàm tính tồn màng-------------
If Object_ID('dbo.fTinhtonmang','FN') is not null
	Drop FUNCTION dbo.fTinhtonmang
Go

Create FUNCTION dbo.fTinhtonmang(@Ngay DATE, @Mamang NVARCHAR(50)) RETURNS DECIMAL(20,2)
AS
BEGIN

	Declare @v_Nhapmang		DECIMAL(20,2),
			@v_Xuatmang		DECIMAL(20,2),
			@v_Ngaykiemke	DATE,
			@v_Sodu			DECIMAL(20,2)
			
	SET @v_Ngaykiemke = dbo.fNgaykiemkemang(@Ngay)

	SELECT @v_Sodu = Sum(Sokg) FROM dbo.Sodumang WHERE Ngaykiemke = @v_Ngaykiemke AND Mamang = @Mamang 
	SELECT @v_Nhapmang = SUM(ISNULL(Sokg,0)) FROM dbo.Nhapkhomang WHERE Ngaynhap BETWEEN @v_Ngaykiemke AND DATEADD(DAY,-1,@Ngay) AND Mamang = @Mamang 
	SELECT @v_Xuatmang = SUM(ISNULL(Sokg,0)) FROM dbo.Xuatkhomang WHERE Ngayxuat BETWEEN @v_Ngaykiemke AND DATEADD(DAY,-1,@Ngay) AND Mamang = @Mamang 
	
	RETURN ISNULL(@v_Sodu,0) + ISNULL(@v_Nhapmang,0) - ISNULL(@v_Xuatmang,0)
END
	
Go

SELECT dbo.fTinhtonmang('12/01/2022','CPP 50x840')

GO	


