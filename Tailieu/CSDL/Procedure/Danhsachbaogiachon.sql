------------------------Danh sách báo giá chọn-------------
If Object_ID('dbo.Danhsachbaogiachon','P') is not null
	Drop Procedure dbo.Danhsachbaogiachon;
Go

Create Procedure dbo.Danhsachbaogiachon
	@Sobaogia		nvarchar(250)
As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
--Select * from baogia_d	
	Select Id, h.Sobaogia, h.Ngaybaogia, h.Ngayhieuluc, d.Trongluong
		, d.Dongiakhongvat, d.Dongiavat
		, d.Mota
		, Masp, Tensp, Maspcuakhach, Doday, Rong, Dai, Loaimuc, Cautruc
		--, dmhh.Mahieu AS Mahang, Mauin, dmhh.Loai
		--, dmhh.Makhach, dmhh.Ngaymarket, 0 AS Loaihang
	From Baogia_d d LEFT JOIN dbo.Baogia_h h ON h.Sobaogia = d.Sobaogia
		--left join Danhmuchanghoa dmhh on bg.Chungloai = dmhh.Chungloai AND Baogia_h.Makhach = dmhh.Makhach
	Where d.Sobaogia = @Sobaogia --AND ISNULL(bg.Loaihang,0)=0
	--UNION
	--Select Id, bg.Sobaogia, bg.Ngaybaogia, bg.Ngayhieuluc, bg.Chungloai, bg.Kichthuoc, bg.Trongluongbao, bg.Trongluongpe
	--	, bg.Dongiabaochuavat, bg.Dongiabaocovat, bg.Dongiapechuavat, bg.Dongiapecovat, bg.Dongiatongchuavat, bg.Dongiatongcovat
	--	, bg.Ghichu, bg.Giavon
	--	, pe.Mahieu AS Mahang, pe.Mahieu AS Mauin, N'Túi' AS Loai
	--	, bgh.Makhach, NULL AS Ngaymarket, bg.Loaihang
	--From Baogia_d bg left join Danhmucpe pe ON pe.Mahieu=bg.Mahang
	--	LEFT JOIN dbo.Baogia_h bgh ON bgh.Sobaogia = bg.Sobaogia 
	--Where bg.Sobaogia = @Sobaogia AND bg.Loaihang=1
	--UNION
	--Select Id, bg.Sobaogia, bg.Ngaybaogia, bg.Ngayhieuluc, bg.Chungloai, bg.Kichthuoc, bg.Trongluongbao, bg.Trongluongpe
	--	, bg.Dongiabaochuavat, bg.Dongiabaocovat, bg.Dongiapechuavat, bg.Dongiapecovat, bg.Dongiatongchuavat, bg.Dongiatongcovat
	--	, bg.Ghichu, bg.Giavon
	--	, dmm.Mahieu AS Mahang, dmm.Mahieu AS Mauin, N'Manh' AS Loai
	--	, bgh.Makhach, NULL AS Ngaymarket, bg.Loaihang
	--From Baogia_d bg left join dbo.Danhmucmanh dmm on dmm.Mahieu = bg.Mahang
	--	LEFT JOIN dbo.Baogia_h bgh ON bgh.Sobaogia = bg.Sobaogia 
	--Where bg.Sobaogia = @Sobaogia AND bg.Loaihang=2
	
Go

Exec Danhsachbaogiachon 'BG002'
--SELECT * FROM dbo.Baogia_d WHERE Sobaogia='001'
--SELECT * FROM dbo.Baogia_h
