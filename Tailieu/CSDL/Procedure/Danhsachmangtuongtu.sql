------------------------Danh sach màng theo tương tự-------------
If Object_ID('dbo.Danhsachmangtuongtu','P') is not null
	Drop Procedure dbo.Danhsachmangtuongtu;
Go

Create Procedure dbo.Danhsachmangtuongtu
	@Ngayphatlenh		Date,
	@Doday				Decimal (20,3),
	@Rong				Decimal (20,3),
	@Tenloaimang		NVARCHAR(250)
As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	
	DECLARE @v_Dungsaikho	Decimal(20,3)
	
	SELECT	@v_Dungsaikho = REPLACE(Giatri,',','.') FROM Thamso WHERE Mahieu='Dungsaikho'
	
	Select Mamang, Tenmang, dbo.fTinhtonmang(@Ngayphatlenh, Mamang) As Ton
		, IsNull((Select Sum(Sokgsudung) From Mangtheolenh Where Mamangquydinh=Mamang and Mamangsudung=Mamang), convert(numeric(20,2),0.00)) As Sokgsudung
		, IsNull((Select Top 1 Id From Mangtheolenh Where Mamangquydinh=Mamang and Mamangsudung=Mamang), NULL) As Id
	FROM dbo.dmmang 
	WHERE Doday = @Doday 
		  And Rong - @Rong <= @v_Dungsaikho	
		  And Rong - @Rong >= 0	
		  And Tenloaimang = @Tenloaimang
GO

Exec Danhsachmangtuongtu  '12/01/2022', 85, 800, 'MPET'
