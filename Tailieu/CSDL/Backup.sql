If Object_ID('dbo.BackupDataBBPH','P') is not null
	Drop Procedure dbo.BackupDataBBPH
Go

CREATE Procedure dbo.BackupDataBBPH
	@FileName	NVarchar(2000)
With Encryption as
	BACKUP DATABASE BBPH TO DISK = @FileName;	