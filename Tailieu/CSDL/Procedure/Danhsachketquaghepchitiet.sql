------------------------Danh sach Danh sach ket qua ghep chi tiet-------------
If Object_ID('dbo.Danhsachketquaghepchitiet','P') is not null
	Drop Procedure dbo.Danhsachketquaghepchitiet;
Go

Create Procedure dbo.Danhsachketquaghepchitiet
	@Maketquaghep	NVARCHAR(50),
	@Ca				Int,
	@Masp		NVARCHAR(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select * 
	FROM dbo.Ketquaghep
	WHERE (Id = @Maketquaghep OR @Maketquaghep = '')
		AND (Ca = @Ca OR @Ca = 0)
		AND (Masanpham=@Masp OR @Masp='')

GO

Exec Danhsachketquaghepchitiet  '', 0, ''