------------------------Đơn giá nguyên liệu hiệu lực-------------
If Object_ID('dbo.Dongianguyenlieuhieuluc','P') is not null
	Drop Procedure dbo.Dongianguyenlieuhieuluc;
Go

Create Procedure dbo.Dongianguyenlieuhieuluc
	@Ngaytinhgia		DATE,
	@Manguyenlieu		NVARCHAR(50)
As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	SELECT dmnl.*
	FROM dbo.Dmnguyenlieu dmnl	
		RIGHT JOIN			
			(SELECT Manl, MAX(Ngay) AS Ngay FROM dbo.Dmnguyenlieu WHERE Ngay<=@Ngaytinhgia GROUP BY Manl) dghl			
		ON dghl.Manl = dmnl.Manl AND dghl.Ngay = dmnl.Ngay	
	WHERE (dmnl.Manl=@Manguyenlieu OR @Manguyenlieu='')
		
Go

Exec Dongianguyenlieuhieuluc '12/01/2022', 'NL.00001'

--SELECT * FROM dbo.Danhmucnguyenlieu WHERE Mahieu='NL.00001'
