------------------------Danh sach Danhsachnhapkhonguyenlieuchitiet-------------
If Object_ID('dbo.Danhsachketquatuachitiet','P') is not null
	Drop Procedure dbo.Danhsachketquatuachitiet;
Go

Create Procedure dbo.Danhsachketquatuachitiet
	@Ngay		Datetime,
	@Ca				NVARCHAR(50),
	@Mamay			Nvarchar(50),
	@Lenhtua		NVARCHAR(50),
	@Masanpham		NVARCHAR(50)
As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select * 
	FROM dbo.Ketquatua
	WHERE Ngay = @Ngay
		AND (Ca=@Ca OR @Ca= 0 )
		AND (Mamay=@Mamay OR @Mamay='')
		AND (Lenhtua=@Lenhtua OR @Lenhtua='')
		AND (Masanpham=@Masanpham OR @Masanpham='')

GO

Exec Danhsachketquatuachitiet  '10/10/2022', 1, 'L1', '', ''

