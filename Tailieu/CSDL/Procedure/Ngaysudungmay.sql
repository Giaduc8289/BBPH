------------------------Tính số ngày không sử dụng của máy-------------
If Object_ID('dbo.Ngaysudungmay','P') is not null
	Drop Procedure dbo.Ngaysudungmay
Go

Create Procedure dbo.Ngaysudungmay
	@Tungay		Date,
	@Denngay	Date,
	@Madongmay		Nvarchar(50),
	@Mamays			Nvarchar(MAX)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Declare @v_Songay		Int,
			@v_Songaynghi	Int;

	Set @v_Songay = DatedIff(Day,@Tungay,@Denngay) + 1
	
	Set @v_Songaynghi = @v_Songay / 7
	If( DATEPART(dw,@Tungay) = 1)
	Begin
		If( @v_Songay%7>0) 
		Begin
			Set @v_Songaynghi = @v_Songaynghi + 1
		End
	End
	Else
	Begin
		If( @v_Songay%7 + DATEPART(dw, @Tungay) > 8)
			Set @v_Songaynghi = @v_Songaynghi + 1
	End
	
	Select Mamay, Ngaychay, Ca
	Into #Kehoachmay
	From Kehoachthoi
	Where Ngaychay Between @Tungay And @Denngay 
	Union
	Select Mamay, Ngaychay, Ca
	From Kehoachin
	Where Ngaychay Between @Tungay And @Denngay 
	Union
	Select Mamay, Ngaychay, Ca
	From Kehoachghep
	Where Ngaychay Between @Tungay And @Denngay 
	Union
	Select Mamay, Ngaychay, Ca
	From Kehoachtua
	Where Ngaychay Between @Tungay And @Denngay 
	Union
	Select Mamay, Ngaychay, Ca
	From Kehoachchia
	Where Ngaychay Between @Tungay And @Denngay 
	Union
	Select Mamay, Ngaychay, Ca
	From Kehoachhoanthien
	Where Ngaychay Between @Tungay And @Denngay 
	
	Select Mamay, Tenmay, Madm
		, 2*(@v_Songay - @v_Songaynghi) + @v_Songaynghi
			- (Select Count(*) 
				From (SELECT DISTINCT Ngaychay, Ca FROM #Kehoachmay
				Where Ngaychay Between @Tungay And @Denngay 
					And Mamay = dbo.dmmay.Mamay) a) As Catrong
	From dbo.dmmay
	Where (Madm = @Madongmay Or @Madongmay='')	
		And (CHARINDEX(Mamay+',',@Mamays)>0 OR ISNULL(@Mamays,'') = '')
	ORDER BY Madm 
			
Go


Exec Ngaysudungmay '12/09/2022', '12/31/2022', 'GH', ''
Exec Ngaysudungmay '12/01/2022', '12/31/2022', '', 'G2, L1, L2, L3,'

