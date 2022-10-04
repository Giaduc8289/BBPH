------------------------Danh sach cong thuc phoi tron-------------
If Object_ID('dbo.Danhsachctpt','P') is not null
	Drop Procedure dbo.Danhsachctpt;
Go

Create Procedure dbo.Danhsachctpt
--With Encryption As
As	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Distinct Mactpt, Tenctpt
	From ctptmang_h 

Go

Exec Danhsachctpt

