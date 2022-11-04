------------------------Ngày kiểm kê sản phẩm-------------
If Object_ID('dbo.fNgaykiemkesanpham','FN') is not null
	Drop FUNCTION dbo.fNgaykiemkesanpham
Go

Create FUNCTION dbo.fNgaykiemkesanpham(@Ngay DATE) RETURNS DATE
AS
BEGIN
	DECLARE @v_Ngaykiemke		DATE
	
	SELECT @v_Ngaykiemke=MAX(Ngaykiemke)
	FROM dbo.Sodusanpham
	WHERE Ngaykiemke <= @Ngay 
	
	IF (ISNULL(@v_Ngaykiemke,'')='')
		SET @v_Ngaykiemke = CONVERT(DATE,'01/01/' + CONVERT(NVARCHAR(4),YEAR(@Ngay)), 103)
	
	RETURN @v_Ngaykiemke
END
	
Go

SELECT dbo.fNgaykiemkesanpham('01/06/2022')

GO	

------------------------Ngày kiểm kê màng-------------
If Object_ID('dbo.fNgaykiemkemang','FN') is not null
	Drop FUNCTION dbo.fNgaykiemkemang
Go

Create FUNCTION dbo.fNgaykiemkemang(@Ngay DATE) RETURNS DATE
AS
BEGIN
	DECLARE @v_Ngaykiemke		DATE
	
	SELECT @v_Ngaykiemke=MAX(Ngaykiemke)
	FROM dbo.Sodumang
	WHERE Ngaykiemke <= @Ngay 
	
	IF (ISNULL(@v_Ngaykiemke,'')='')
		SET @v_Ngaykiemke = CONVERT(DATE,'01/01/' + CONVERT(NVARCHAR(4),YEAR(@Ngay)), 103)
	
	RETURN @v_Ngaykiemke
END
	
Go

SELECT dbo.fNgaykiemkemang('01/06/2022')

GO	



------------------------Ngày kiểm kê nguyên liệu-------------
If Object_ID('dbo.fNgaykiemkenguyenlieu','FN') is not null
	Drop FUNCTION dbo.fNgaykiemkenguyenlieu
Go

Create FUNCTION dbo.fNgaykiemkenguyenlieu(@Ngay DATE) RETURNS DATE
AS
BEGIN
	DECLARE @v_Ngaykiemke		DATE
	
	SELECT @v_Ngaykiemke=MAX(Ngaykiemke)
	FROM dbo.Sodunguyenlieu
	WHERE Ngaykiemke <= @Ngay 
	
	IF (ISNULL(@v_Ngaykiemke,'')='')
		SET @v_Ngaykiemke = CONVERT(DATE,'01/01/' + CONVERT(NVARCHAR(4),YEAR(@Ngay)), 103)
	
	RETURN @v_Ngaykiemke
END
	
Go

SELECT dbo.fNgaykiemkenguyenlieu('01/06/2022')

GO	

