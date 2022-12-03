------------------------Chi tiết nhu cầu in-------------
If Object_ID('dbo.Nhucaulapkehoachin','P') is not null
	Drop Procedure dbo.Nhucaulapkehoachin;
Go
Create Procedure dbo.Nhucaulapkehoachin
	@Tungay			DATETIME,
	@Denngay		DATETIME,
	@Daphatlenh		BIT
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	DECLARE @v_Ngaydauthang			DATE,
			@v_Ngaycuoithang		DATE,
			@v_Sothangxetnhucau		INT,
			@v_Ngaydauthangtruoc	DATE,
			@v_Ngaycuoithangtruoc	DATE,
			@v_Thang				NVARCHAR(20),
			@v_Ngaybatdau			DATE,
			@v_Ngayxetnhucau		DATE

	SELECT	@v_Sothangxetnhucau = REPLACE(Giatri,',','.') FROM Thamso WHERE Mahieu='Sothangxetnhucau'
	SET @v_Sothangxetnhucau=1-@v_Sothangxetnhucau

	SET @v_Ngaydauthang = DATEADD(DAY,-DAY(@Tungay)+1,@Tungay)
	SET @v_Ngaycuoithang = DATEADD(DAY,-DAY(DATEADD(MONTH,1,@Denngay)),DATEADD(MONTH,1,@Denngay)) 
			
	-----Lệnh sản xuất với Ngày đặt <= Ngày cuối tháng			
	Select Solenhsx, Ngayphatlenh, Ngaybatdausx, Ngayhoanthanhsx
		, Madon, Ngaydat, Makhach, Tenkhach
		, Madonhangchitiet, Masp, Tenhang, Ngaygiao 
		, Soluong - (Select * From Ketquain Where )
	From Lenhsanxuat
	Where Ngaydat<=@v_Ngaycuoithang
	 
	-----Kết quả sản xuất theo lệnh
	Select * from Ketquain


	
	--SELECT * FROM #Nhucau WHERE Soluong>0 ORDER BY Ngaygiao
	
Go

Exec Nhucaulapkehoachin '12/01/2022', '12/30/2022', 'TRUE'


