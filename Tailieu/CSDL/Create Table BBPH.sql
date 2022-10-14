Create table Dmcapma(
	Macappk	Nvarchar(50) NOT NULL,
	Loaima	Nvarchar(50) NOT NULL,
	Mastart	Nvarchar(50) NULL,
 CONSTRAINT Dmcapma_PK PRIMARY KEY (Loaima) 
) ON [PRIMARY]

--Bang Roles
Create table Roles(
Rolesid			Nvarchar(50) Not null,
Rolesname		Nvarchar(50),
Description		Nvarchar(200),
constraint Roles_PK primary key (Rolesid)) ON [PRIMARY]

--Bang users
Create table Users(
	Userid		Nvarchar(50) NOT NULL,
	Rolesid		Nvarchar(50) NOT NULL,
	Username	Nvarchar(150) NOT NULL,
	Fullname	Nvarchar(500) NULL,
	Phone		Nvarchar(50) NULL,
	Address		Nvarchar(500) NULL,
	Password	Nvarchar(50) NOT NULL,
	Active		Bit default 1,
 constraint Users_Roles_FK Foreign Key (Rolesid) References Roles (Rolesid) On Delete No Action On Update Cascade,	
 constraint Users_PK PRIMARY KEY (Userid)  
) ON [PRIMARY]

--Bang Menu
Create table Menu(
	MenuId		Nvarchar(50) NOT NULL,
	MenuName	Nvarchar(500) NULL,
	Icon		Nvarchar(500) NULL,
	Issudung	int NULL,
	Istrangthai int NULL,
	Menuparent	Nvarchar(50) NULL,
	Thutu		int NULL,
	FormName	Nvarchar(1000) NULL,
	LoaiMenu	int NULL,
	Param		Nvarchar(500) NULL,
	Maphanhe	Nvarchar(50) NULL,
 constraint Menu_PK PRIMARY KEY (MenuId) 
) ON [PRIMARY]

alter table Menu alter column MenuId Nvarchar(50) Not Null

--Bang MenuRoles
Create table Menurole(
Menuid			Nvarchar(50) not null,
Rolesid			Nvarchar(50) not null,
constraint Menurole_Roles_FK Foreign Key (Rolesid) References Roles (Rolesid) On Delete No Action On Update Cascade,
constraint Menurole_Menu_FK Foreign Key (Menuid) References Menu (Menuid) On Delete No Action On Update Cascade,
constraint Menurole_PK primary key (Menuid, Rolesid)) ON [PRIMARY]

alter table Menurole drop constraint Menurole_Menu_FK
alter table Menurole alter column Menuid Nvarchar(50) Not Null
alter table Menurole add constraint Menurole_Menu_FK Foreign Key (Menuid) References Menu (Menuid) On Delete No Action On Update Cascade

--Bang tham so
Create table Thamso(
Mahieu			Nvarchar(50) not null,
Stt				Int not null,
Tenthamso		Nvarchar(200) not null,
Giatri			Nvarchar(200),
Thaydoi			Bit default 1 not null,
Kieudulieu		Int not null, --1: Ký tự, 2: Số, 3: Ngày tháng, 4: Boolean, 
Ghichu			Nvarchar(200),
Loaithamso		Int,
An 				Bit default 0,
constraint Thamso_PK primary key (Mahieu)) ON [PRIMARY]

alter table Thamso alter column Mahieu Nvarchar(50) Not Null

--Ghi log
Create table Logbackup(
	Mahieu		bigint IDENTITY(1,1) NOT NULL,
	Nam			int NULL,
	Duongdan	nvarchar(250) NULL,
	Ngay		datetime NULL,
constraint Logbackup_PK PRIMARY KEY (Mahieu) 
) ON [PRIMARY]

--Danh muc khach
Create table dmkhach(
Makhach			Nvarchar(50) Not null,
Tenkhach		Nvarchar(250) Not null,
Tenrutgon		Nvarchar(250),
Truyenthong		Bit default 1,
Diachi			Nvarchar(250),
Sodienthoai		Nvarchar(100),
Email			Nvarchar(100),
Tknganhang		Nvarchar(100),
Tennganhang		Nvarchar(100),
Noidia			Bit default 0,
Tennguoilh		Nvarchar(250),
Chucvu			Nvarchar(100),
Sodienthoailh	Nvarchar(100),
Thongtinbosung	Nvarchar(250),
Lanhacungcap		Bit default 0, --0: Khách hàng, 1: Nhà cung cấp
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint khach_PK primary key (Makhach)) ON [PRIMARY]

Alter table dmkhach alter column Makhach			Nvarchar(50) Not null
Alter table dmkhach add Lanhacungcap		Bit default 0, --0: Khách hàng, 1: Nhà cung cấp
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),

--Danh mục chủng loại
Create table Dmchungloai(
--Id				Bigint Identity Not null,
Machungloai		Nvarchar(50) Not null,
Tenchungloai	Nvarchar(250),
Kichthuoc		Nvarchar(50),
Trongluong		Decimal(20,2),
Somau			Int,
Sohinh			Int,
Loaimuc			Nvarchar(50),
Ghichu			Nvarchar(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Dmchungloai_PK primary key (Machungloai)) ON [PRIMARY]

Drop table Dmchungloai
Alter table Dmchungloai add Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),


--Danh muc hang hoa
Create table dmhang(
Masp			Nvarchar(50) Not null,
Tensp			Nvarchar(250) Not null,
Maspcuakhach	Nvarchar(250),---
Machungloai		Bigint,---
Tenchungloai	Nvarchar(250),---
Makhach			Nvarchar(50),
Tenkhach		Nvarchar(250),
Kichthuoc		nvarchar(50),--Đưa vào quy cách?
Trongluong		Decimal(20,2),---
-----Thông tin phục vụ in
Sohinh			Int,
Somau			Int,
Loaimuc			Nvarchar(50),--Đưa vào quy cách được không?
Khoiluongmuc	Decimal(20,2),--Trường phụ thuộc
Cautrucin		Nvarchar(250),--Liệu có phải trường phụ thuộc vào Loạimực+Kíchthước không?
--các màu in của sp liên kết với bảng maucuahang
-----Thông tin phục vụ ghép
Mamang1			Nvarchar(50),---
Tenmang1		Nvarchar(250),---
Tlmanglop1		Decimal(20,2),---
Tlkeolop1		Decimal(20,2),---
Mamang2			Nvarchar(50),---
Tenmang2		Nvarchar(250),---
Tlmanglop2		Decimal(20,2),---
Tlkeolop2		Decimal(20,2),---
Dinhluongkeo	Decimal(20,2),---
Kichthuoctruc	Nvarchar(100),--Kiểm tra lại dữ liệu
Vitri			Nvarchar(100),--Kiểm tra lại dữ liệu
-----Thông tin phục vụ hoàn thiện
Maqcdonggoi			Nvarchar(50),--Đưa vào quy cách
Tenqcdonggoi		Nvarchar(250),--Đưa vào quy cách
Maqcloaithung		Nvarchar(50),--Đưa vào quy cách
Tenqcloaithung		Nvarchar(250),--Đưa vào quy cách
Maqcthanhpham		Nvarchar(50),--Đưa vào quy cách
Tenqcthanhpham		Nvarchar(250),--Đưa vào quy cách

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint dmhang_PK primary key (Masp)) ON [PRIMARY]

drop table dmhang
alter table dmhang alter column Loaimuc nvarchar(50)
alter table dmhang alter column Khoiluongmuc decimal(20,2)
alter table dmhang alter column Masp	Nvarchar(50) Not null
Alter table dmhang add Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),

Create table maucuahang(
Id				Bigint Identity Not null,
Masp			Nvarchar(50) Not null,
Tensp			Nvarchar(250),
Mamau		Nvarchar(50),
Tenmau		Nvarchar(250),
Klmau		Decimal(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint maucuahang_PK primary key (Id)) ON [PRIMARY]

Create table truccuahang(
Id				Bigint Identity Not null,
Masp			Nvarchar(50) Not null,
Tensp			Nvarchar(250),
Stttruc		Int,
Matruc		Nvarchar(50),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint truccuahang_PK primary key (Id)) ON [PRIMARY]


--Danh muc cong doan
Create table dmcongdoan(
Macd				Nvarchar(50) Not null, 
Tencongdoan			Nvarchar(250) Not null, 
Sothutucongdoan		Int,
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint dmcongdoan_PK primary key (Macd)) ON [PRIMARY]

alter table dmcongdoan alter column Macd	Nvarchar(50) Not null
Alter table dmcongdoan add Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),

--Danh muc bo phan
Create table dmbophan(
Mabp			Nvarchar(50) Not null, 
Tenbophan		Nvarchar(250) Not null,
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint dmbophan_PK primary key (Mabp)) ON [PRIMARY]

alter table dmbophan alter column Mabp	Nvarchar(50) Not null
Alter table dmbophan add Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),

--Danh muc chuc vu
Create table dmchucvu(
Macv			Nvarchar(50) Not null, 
Tenchucvu		Nvarchar(250) Not null,
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint dmchucvu_PK primary key (Macv)) ON [PRIMARY]

alter table dmchucvu alter column Macv	Nvarchar(50) Not null
Alter table dmchucvu add Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),

--Danh muc cong nhan
Create table dmcongnhan(
Macn				Nvarchar(50) Not null, 
Hovatencongnhan		Nvarchar(250) Not null,
Tencongnhan			Nvarchar(50),
Mabp				Nvarchar(50),
Macv				Nvarchar(50),
Sodienthoai			Nvarchar(100),
Tinhtrang			Nvarchar(100),
Phongban		Nvarchar(250), 
Chucvu			Nvarchar(250), 
Danghi			Bit,
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint congnhan_bophan_FK Foreign Key (Mabp) References dmbophan (Mabp) On Delete No Action On Update Cascade,
--constraint congnhan_chucvu_FK Foreign Key (Macv) References dmchucvu (Macv) On Delete No Action On Update Cascade,
constraint dmcongnhan_PK primary key (Macn)) ON [PRIMARY]

alter table dmcongnhan alter column Macn	Nvarchar(50) Not null
alter table dmcongnhan drop constraint congnhan_bophan_FK
alter table dmcongnhan drop constraint congnhan_chucvu_FK
alter table dmcongnhan alter column Mabp	Nvarchar(50)
alter table dmcongnhan alter column Macv	Nvarchar(50)
alter table dmcongnhan alter column Tencongnhan	Nvarchar(50)
alter table dmcongnhan add constraint congnhan_bophan_FK Foreign Key (Mabp) References dmbophan (Mabp) On Delete No Action On Update Cascade
alter table dmcongnhan add constraint congnhan_chucvu_FK Foreign Key (Macv) References dmchucvu (Macv) On Delete No Action On Update Cascade
Alter table dmcongnhan add Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),

alter table dmcongnhan add 
Phongban		Nvarchar(250), 
Chucvu			Nvarchar(250), 
Danghi			Bit


--Danh muc dong may
Create table dmdongmay(
Madm			Nvarchar(50) Not null, 
Tendongmay		Nvarchar(250) Not null,
Macd			Nvarchar(50),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint dongmay_congdoan_FK Foreign Key (Macd) References dmcongdoan (Macd) On Delete No Action On Update Cascade,
constraint dmdongmay_PK primary key (Madm)) ON [PRIMARY]

alter table dmdongmay drop constraint dongmay_congdoan_FK
alter table dmdongmay alter column Madm	Nvarchar(50) Not null
alter table dmdongmay alter column Macd	Nvarchar(50)
alter table dmdongmay add constraint dongmay_congdoan_FK Foreign Key (Macd) References dmcongdoan (Macd) On Delete No Action On Update Cascade
Alter table dmdongmay add Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),

--Danh muc may
Create table dmmay(
Mamay			Nvarchar(50) Not null, 
Tenmay			Nvarchar(250) Not null,
Madm			Nvarchar(50),
Vitri			Nvarchar(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint may_dongmay_FK Foreign Key (Madm) References dmdongmay (Madm) On Delete No Action On Update Cascade,
constraint dmmay_PK primary key (Mamay)) ON [PRIMARY]

alter table dmmay drop constraint may_dongmay_FK
alter table dmmay alter column Mamay	Nvarchar(50) Not null
alter table dmmay alter column Madm	Nvarchar(50)
alter table dmmay alter column Vitri	Nvarchar(250)
alter table dmmay add constraint may_dongmay_FK Foreign Key (Madm) References dmdongmay (Madm) On Delete No Action On Update Cascade
Alter table dmmay add Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),

--Danh mục nhóm quy cách
Create table Dmnhomquycach(
Manhom			Nvarchar(50) Not null, 
Tennhom			Nvarchar(250),
Tenrutgon		Nvarchar(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint quycach_congdoan_FK Foreign Key (Macd) References dmcongdoan (Macd) On Delete No Action On Update Cascade,
constraint Dmnhomquycach_PK primary key (Manhom)) ON [PRIMARY]

--Danh mục quy cách
Create table Dmquycach(
Maquycach		Nvarchar(50) Not null, 
Tenquycach		Nvarchar(250) Not null,
Macongdoan			Nvarchar(50),
Tencongdoan			Nvarchar(250),
Manhom			Nvarchar(50),
Tennhom			Nvarchar(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint quycach_congdoan_FK Foreign Key (Macd) References dmcongdoan (Macd) On Delete No Action On Update Cascade,
constraint Dmquycach_PK primary key (Maquycach)) ON [PRIMARY]

drop table dmquycach

--Cong suat may: số màu, cấu trúc, số hình chia, khổ, dài túi, dán dựng, cắt nhiệt, độ dày
Create table congsuatmay(
Macongsuat		Nvarchar(50) Not null, 
Tencongsuat		Nvarchar(250),
Mamay			Nvarchar(50),
Madongmay		Nvarchar(50),
Macongdoan		Nvarchar(50),
Maquycach1		Nvarchar(50),
Maquycach2		Nvarchar(50),
Maquycach3		Nvarchar(50),
Khotu			Decimal(20,2),
Khoden			Decimal(20,2),
Chieudaitu		Decimal(20,2),
Chieudaiden		Decimal(20,2),
Dodaytu			Decimal(20,2),
Dodayden		Decimal(20,2),
Tocdo			Decimal(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint congsuatmay_congdoan_FK Foreign Key (Macd) References dmcongdoan (Macd) On Delete No Action On Update Cascade,
constraint congsuatmay_PK primary key (Macs)) ON [PRIMARY]

drop table congsuatmay
alter table congsuatmay drop constraint congsuatmay_congdoan_FK
alter table congsuatmay alter column Macs	Nvarchar(50) Not null
alter table congsuatmay alter column Macd	Nvarchar(50)
alter table congsuatmay drop column Maqccha
alter table congsuatmay add Maqc	Nvarchar(50)
alter table congsuatmay add constraint congsuatmay_congdoan_FK Foreign Key (Macd) References dmcongdoan (Macd) On Delete No Action On Update Cascade
Alter table congsuatmay add Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),

--dinh muc thoi gian
Create table dinhmucthoigian(
Madmtg			Nvarchar(50) Not null,
Tendinhmuc		Nvarchar(250) Not null,
Mamay			Nvarchar(50),
Madm			Nvarchar(50),
Dauca			Decimal(20,2),
Doilenh			Decimal(20,2),
Lencuon			Decimal(20,2),
Xuongcuon		Decimal(20,2),
Thaythietbi		Decimal(20,2),
Dungmay			Decimal(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint dinhmucthoigian_PK primary key (Madmtg)) ON [PRIMARY]

Drop table dinhmucthoigian
Alter table dinhmucthoigian add Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),

--Danh muc kho
Create table dmkho(
Makho			Nvarchar(50) Not null,
Tenkho			Nvarchar(250) Not null,
Tenrutgon		Nvarchar(250),
Loaikho			Int,--0: Kho sản phẩm; 1: Kho màng; 2: Kho vật tư; 3: Kho khác
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint kho_PK primary key (Makho)) ON [PRIMARY]

Drop table dmkho
Alter table dmkho add Loaikho			Int,--0: Kho sản phẩm; 1: Kho màng; 2: Kho vật tư; 3: Kho khác
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),

--Danh muc nhom
Create table dmnhomnguyenlieu(
Manhom				Nvarchar(50) Not null,
Tennhomnguyenlieu	Nvarchar(250) Not null,
Tenrutgon			Nvarchar(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint nhomnguyenlieu_PK primary key (Manhom)) ON [PRIMARY]

alter table dmnhomnguyenlieu alter column Manhom	Nvarchar(50) Not null
alter table dmnhomnguyenlieu alter column Tenrutgon	Nvarchar(250)
Alter table dmnhomnguyenlieu add Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),

--Danh muc li do nhap xuat
Create table dmlydonhapxuat(
Malydo			Nvarchar(50) Not null,
Tenlydo			Nvarchar(250) Not null,
Manhom			Nvarchar(50),
Tennhom			Nvarchar(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint lydonhapxuat_PK primary key (Malydo)) ON [PRIMARY]

alter table dmlydonhapxuat drop constraint lydonhapxuat_nhom_FK
alter table dmlydonhapxuat alter column Malydo	Nvarchar(50) Not null
alter table dmlydonhapxuat alter column Manhom	Nvarchar(50)
alter table dmlydonhapxuat alter column Tennhom	Nvarchar(250)
Alter table dmlydonhapxuat add Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),

--Danh muc nguyen lieu
Create table dmnguyenlieu(
Manl			Nvarchar(50) Not null,
Tenrutgon		Nvarchar(250) Not null,
Tennl			Nvarchar(100),
Manhom			Nvarchar(50) Not null,
Tennhom			Nvarchar(250) Not null,
Gia				DECIMAL(20,2),
Ngay			DATE,
Giahientai		DECIMAL(20,2),
Tang			DECIMAL(20,2),
Giam			DECIMAL(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint nguyenlieu_nhom_FK Foreign Key (Manhom) References dmnhomnguyenlieu (Manhom) On Delete No Action On Update Cascade,
constraint nguyenlieu_PK primary key (Manl)) ON [PRIMARY]

alter table dmnguyenlieu add Tennl		Nvarchar(100),
Gia			DECIMAL(20,2),
Ngay		DATE,
Giahientai		DECIMAL(20,2),
Tang			DECIMAL(20,2),
Giam			DECIMAL(20,2)
Alter table dmnguyenlieu add Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),

alter table dmnguyenlieu drop constraint nguyenlieu_nhom_FK
alter table dmnguyenlieu alter column Manl	Nvarchar(50) Not null
alter table dmnguyenlieu alter column Manhom	Nvarchar(50)
alter table dmnguyenlieu alter column Tennhom	Nvarchar(250)
alter table dmnguyenlieu add constraint nguyenlieu_nhom_FK Foreign Key (Manhom) References dmnhomnguyenlieu (Manhom) On Delete No Action On Update Cascade

--Danh muc phoi tron
Create table ctptmang_h(
id				BigInt Identity Not null,
Mactpt			Nvarchar(50) Not null,
Tenctpt			Nvarchar(250) Not null,
Ngayapdung		DATE,
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint ctptmangh_PK primary key (id)) ON [PRIMARY]

drop table dmmang
drop table ctptmang_d
drop table ctptmang_h
alter table ctptmang_h drop constraint ctptmangh_PK
alter table ctptmang_h add constraint ctptmangh_PK primary key (id)
alter table ctptmang_h alter column Mactpt	Nvarchar(50) Not null
Alter table ctptmang_h add Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),

--Danh muc cong thuc phoi tron
Create table ctptmang_d(
id				BigInt Identity Not null,
id_h			BigInt,
Mact			Nvarchar(50) Not null,
Tenct			Nvarchar(250) Not null,
Manl			Nvarchar(50) Not null,
Tennguyenlieu	Nvarchar(250) Not null,
Trongluong		Decimal(20,2),
Tyle			Decimal(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint ctptmangd_ctptmangh_FK Foreign Key (id_h) References ctptmang_h (id) On Delete No Action On Update Cascade,
constraint ctptmangd_nl_FK Foreign Key (Manl) References dmnguyenlieu (Manl) On Delete No Action On Update Cascade,
constraint ctptmangd_PK primary key (id)) ON [PRIMARY]

alter table ctptmang_d drop constraint ctptmangd_ctptmangh_FK
alter table ctptmang_d add constraint ctptmangd_ctptmangh_FK Foreign Key (id_h) References ctptmang_h (id) On Delete No Action On Update Cascade
alter table ctptmang_d drop constraint ctptmangd_nl_FK
alter table ctptmang_d alter column Manl	Nvarchar(50) Not null
alter table ctptmang_d alter column Mact	Nvarchar(50) Not null
alter table ctptmang_d alter column Trongluong		Decimal(20,2)
alter table ctptmang_d add Tyle			Decimal(20,2)
alter table ctptmang_d add constraint ctptmangd_nl_FK Foreign Key (Manl) References dmnguyenlieu (Manl) On Delete No Action On Update Cascade
Alter table ctptmang_d add Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),

--Danh muc mang
Create table dmmang(
Mamang			Nvarchar(50) Not null,
Tenmang			Nvarchar(250) Not null,
Makhach			Nvarchar(50),
Tenkhach		Nvarchar(250),
Kichthuoc		Nvarchar(250),
Trongluong		Nvarchar(250) Not null,
Mactpt			Nvarchar(50) Not null,
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint mang_ctpt_FK Foreign Key (Mactpt) References ctptmang_h (Mactpt) On Delete No Action On Update Cascade,
constraint mang_PK primary key (Mamang)) ON [PRIMARY]

Drop table dmmang

--Danh muc mau
Create table dmmau(
Mamau			Nvarchar(50) Not null,
Tenmau			Nvarchar(250) Not null,
Lamaugoc		Bit default 0, --0: Là màu pha; 1: Là màu gốc
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint mau_PK primary key (Mamau)) ON [PRIMARY]

Drop table dmmau

Create table thanhphanmau(
Id			BigInt Identity Not null,
Mamau		Nvarchar(50),
Tenmau		Nvarchar(250),
Mausudung		Nvarchar(50),
Tenmausudung	Nvarchar(250),
Tyle			Decimal(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint thanhphanmau_dmmau_FK Foreign Key (Mamau) References dmmau (Mamau) On Delete No Action On Update Cascade,
constraint thanhphanmau_PK primary key (Id)) ON [PRIMARY]

Drop table thanhphanmau

--Danh muc tai khoan
Create table dmtaikhoan(
Matk			Nvarchar(50) Not null,
Tentk			Nvarchar(250) Not null,
Bactk			Nvarchar(250),
Tinhchattk		Nvarchar(250),
Matkcha			Nvarchar(50),
Trongbang		Bit,
Doituongtd		Nvarchar(50),
Khoanmuctd		Nvarchar(50),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint taikhoan_PK primary key (Matk)) ON [PRIMARY]

Drop table dmtaikhoan


--Bao gia 
Create table baogia_h(
Sobaogia		Nvarchar(50) Not null,
Ngaybaogia		DATE,
Ngayhieuluc		DATE,
Makhach			Nvarchar(50) Not null,
Tenkhach		Nvarchar(100) Not null,
Noidung			Nvarchar(250),
Phuongthuctt	Nvarchar(250),
Diadiemgiao		Nvarchar(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint baogiah_khachhang_FK Foreign Key (Makhach) References dmkhach (Makhach) On Delete No Action On Update Cascade,
constraint baogiah_PK primary key (sobaogia)) ON [PRIMARY]

--Bao gia chi tiet
Create table baogia_d(
Id 				BigInt Identity Not null,
Sobaogia		Nvarchar(50) Not null,
Machungloai		Bigint,
Tenchungloai	Nvarchar(250),
--Loaihang		Nvarchar(250),
Masp			Nvarchar(50),
Tenhang			Nvarchar(250),
Kichthuoc		Nvarchar(250),
Trongluong		Decimal(20,2),
Mota			Nvarchar(250),
DongiakhongVAT	INT,
DongiaVAT		INT,
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint baogiad_hang_FK Foreign Key (Masp) References dmhang (Masp) On Delete No Action On Update Cascade,
constraint baogiad_baogiah_FK Foreign Key (Sobaogia) References baogia_h (Sobaogia) On Delete No Action On Update Cascade,
constraint baogiad_PK primary key (Id)) ON [PRIMARY]

drop table baogia_d
alter table baogia_d drop constraint baogiad_hang_FK

--Don hang
Create table donhang_h(
Madon			Nvarchar(50) Not null,
Ngaydat			DATE,
Makhach			Nvarchar(50) Not null,
Tenkhach		Nvarchar(250) Not null,
Sobaogia		Nvarchar(50),
Ngaybaogia		DATE,
Userid 			Nvarchar(50),
Tennv			Nvarchar(250),
Ghichu			Nvarchar(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint donhangh_khach_FK Foreign Key (Makhach) References dmkhach (Makhach) On Delete No Action On Update Cascade,
--constraint donhangh_User_FK Foreign Key (Userid) References Users (Userid) On Delete No Action On Update Cascade,
constraint donhangh_PK primary key (Madon)) ON [PRIMARY]

--Don hang chi tiet
Create table donhang_d(
Id 				BigInt Identity Not null,
Madon			Nvarchar(50) Not null,
Ngaydat			DATE,
Makhach			Nvarchar(50) Not null,
Sobaogia		Nvarchar(50),
Loaihang		INT,	--0: Túi (hàng hóa); 1: Màng (PE); 
Masp			Nvarchar(50),
Tenhang			Nvarchar(250),
Soluong 		Decimal(20,2),
Dongia			Decimal(20,2),
--Thanhtien		Decimal(20,2),
Ngaygiao		DATE,
Ghichu			Nvarchar(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint donhangd_hang_FK Foreign Key (Masp) References dmhang (Masp) On Delete No Action On Update Cascade,
--constraint donhangd_khach_FK Foreign Key (Makhach) References dmkhach (Makhach) On Delete No Action On Update Cascade,
constraint donhangd_donhangh_FK Foreign Key (Madon) References donhang_h (Madon) On Delete No Action On Update Cascade,
constraint donhangd_PK primary key (Id)) ON [PRIMARY]

drop table donhang_d

--Phieu giao hang
Create table phieugiaohang_h(
Sophieu			Nvarchar(50) Not null,
Ngaygiao		DATE,
Madon			Nvarchar(50) Not null,
Ngaydat			DATE,
Makhach			Nvarchar(50) Not null,
Tenkhach		Nvarchar(250) Not null,
Tongtien		INT,
VAT				INT,
Ghichu			Nvarchar(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint phieuh_don_FK Foreign Key (Madon) References donhang_h (Madon) On Delete No Action On Update Cascade,
--constraint phieuh_khach_FK Foreign Key (Makhach) References dmkhach (Makhach) On Delete No Action On Update Cascade,
constraint phieuh_PK primary key (Sophieu)) ON [PRIMARY]

--Phieu giao hang chi tiet
Create table phieugiaohang_d(
Id 				BigInt Identity Not null,
Sophieu			Nvarchar(50) Not null,
Ngaygiao		DATE,
Madon			Nvarchar(50) Not null,
Donchitiet_Id	BigInt,
Ngaydat			DATE,
Makhach			Nvarchar(50),
Tenkhach		Nvarchar(250),
Loaihang		Nvarchar(250),
Masp			Nvarchar(50),
Tenhang			Nvarchar(250),
Soluong 		Decimal(20,2),
Dongia			Decimal(20,2),
Thanhtien		Decimal(20,2),
Ghichu			Nvarchar(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint phieud_hang_FK Foreign Key (Masp) References dmhang (Masp) On Delete No Action On Update Cascade,
--constraint phieud_khach_FK Foreign Key (Makhach) References dmkhach (Makhach) On Delete No Action On Update Cascade,
--constraint phieud_donhangh_FK Foreign Key (Madon) References donhang_h (Madon) On Delete No Action On Update Cascade,
--constraint phieud_donhangd_FK Foreign Key (Donchitiet_Id) References donhang_d (Id) On Delete No Action On Update Cascade,
constraint phieud_phieuh_FK Foreign Key (Sophieu) References phieugiaohang_h (Sophieu) On Delete No Action On Update Cascade,
constraint phieud_PK primary key (Id)) ON [PRIMARY]

drop table phieugiaohang_d

--Hang tra lai
Create table hangtralai(
Id 				BigInt Identity Not null,
Sophieugiao		Nvarchar(50) Not null,
Ngaygiao		DATE,
Madon			Nvarchar(50) Not null,
Makhach			Nvarchar(50),
Tenkhach		Nvarchar(250),
Ngaydat			DATE,
Masp			Nvarchar(50) Not null,
Tenhang			Nvarchar(250),
Soluonggiao			Decimal(20,2),
Soluongtralai		Decimal(20,2),
Ngaytra			DATE,
Nguyennhan		Nvarchar(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint hangtralai_don_FK Foreign Key (Madon) References donhang_h (Madon) On Delete No Action On Update Cascade,
--constraint hangtralai_hang_FK Foreign Key (Masp) References dmhang (Masp) On Delete No Action On Update Cascade,
--constraint hangtralai_khach_FK Foreign Key (Makhach) References dmkhach (Makhach) On Delete No Action On Update Cascade,
constraint hangtralai_PK primary key (Id)) ON [PRIMARY]


/* Thổi */
CREATE TABLE Kehoachthoi(
Id					BigInt Identity Not null,
Madonhangchitiet	BigInt,
Ngaydat				DATE,
Ngaygiao			DATE,
Mamang				Nvarchar(50),
Lenhthoi			Nvarchar(50),
Mamay				Nvarchar(50),
Ngaychay			DATE,
Ca					Int,
Somet				Decimal(20,2),
Sokg				Decimal(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Kehoachthoi_Maythoi_FK Foreign Key (Mamay) References Dmmay (Mamay) On Delete No Action On Update Cascade,
constraint Kehoachthoi_PK primary key (Id)) ON [PRIMARY]

CREATE TABLE Ketquathoi(
Id					BigInt Identity Not null,
Ngay				DATE,
Ca					Int,
Mamay				Nvarchar(50),
Lenhthoi			Nvarchar(50),
Mamang				Nvarchar(50),
Macongnhan			Nvarchar(50),
Tenmang			Nvarchar(250),
Tenmay			Nvarchar(250),
Tencongnhan		Nvarchar(250),
Somet				Decimal(20,2),
Sokg				Decimal(20,2),
Sokgquydoi			Decimal(20,2),
Chenhlechkg			Decimal(20,2),
Chatluong			Nvarchar(250),
Phelieuthucte		Decimal(20,2),
Tongsp				Decimal(20,2),
--Dinhmucsaihong		Decimal(20,2),
Thoigianbatdau		DATETIME,
Thoigianketthuc		DATETIME,
Thoigianchuanbi		Decimal(20,2),
Thoigiansuco		Decimal(20,2),
--Giomaychay			Decimal(20,2),
--Dinhmuc				Decimal(20,2), /*định mức kg/giờ */
Sokgdukiendat		Decimal(20,2),
--Nangsuat			Decimal(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Ketquathoi_Maythoi_FK Foreign Key (Mamay) References Dmmay (Mamay) On Delete No Action On Update Cascade,
constraint Ketquathoi_PK primary key (Id)) ON [PRIMARY]

alter table Ketquathoi add Tenmang			Nvarchar(250),
Tenmay			Nvarchar(250),
Tencongnhan		Nvarchar(250),


Create table Tknguyenlieuthoi(
Id				BigInt Identity Not null,
Ngay			DATE,
Ca				Int,
Manguyenlieu	Nvarchar(50),
Tennguyenlieu	Nvarchar(250),
Klnhap			Decimal(20,2),
Klxuat			Decimal(20,2),
constraint Tknguyenlieuthoi_PK primary key (Id)) ON [PRIMARY]


/* In */
CREATE TABLE Kehoachin(
Id					BigInt Identity Not null,
Madonhangchitiet	BigInt,
Ngaydat				DATE,
Ngaygiao			DATE,
Masanpham			Nvarchar(50),
Lenhin				Nvarchar(50),
Mamay				Nvarchar(50),
Ngaychay			DATE,
Ca					Int,
Somet				Decimal(20,2),
Sokg				Decimal(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Kehoachin_Mayin_FK Foreign Key (Mamay) References Dmmay (Mamay) On Delete No Action On Update Cascade,
constraint Ketquain_PK primary key (Id)) ON [PRIMARY]

CREATE TABLE Ketquain(
Id					BigInt Identity Not null,
Ngay				DATE,
Ca					Int,
Mamay				Nvarchar(50),
Lenhin				Nvarchar(50),
Masanpham			Nvarchar(50),
Macongnhan			Nvarchar(50),
Tensanpham		Nvarchar(250),
Tenmay			Nvarchar(250),
Tencongnhan		Nvarchar(250),
SometLSX			Decimal(20,2), /* số m lệnh sản xuất */
Sometcap			Decimal(20,2), /* số m cấp */
Sokgcap				Decimal(20,2), /* số kg cấp */
Thuctein			Decimal(20,2),
Sokgin				Decimal(20,2), /* số kg in */
Saihongthucte		Decimal(20,2),
Thoigianbatdau		DATETIME,
Thoigianketthuc		DATETIME,
Thoigianchuanbi		Decimal(20,2),
Thoigiansuco		Decimal(20,2),
--Giomaychay			Decimal(20,2),
--Tocdomaydinhmuc		Decimal(20,2),
--Tocdomaythucte		Decimal(20,2),
--Nangsuat			Decimal(20,2),
PheNCC				Decimal(20,2), /* phế NCC */
PheSX				Decimal(20,2), /* phế sản xuất */
--Sohinh				Decimal(20,2),
--Chieudaitui			Decimal(20,2),
--Tongmdm				Decimal(20,2), /*tổng m định mức */
Tongm2dm			Decimal(20,2), /*tổng m2 định mức */
--M2saihongdm			Decimal(20,2), /*m2 sai hỏng định mức */
M2saihongtt			Decimal(20,2), /*m2 sai hỏng thực tế */
--Nangsuattrungbinh	Decimal(20,2), 
--M2daura				Decimal(20,2),
--Mamau1				Nvarchar(50),
--Xuatdodang1			Decimal(20,2),
--Xuatnguyen1			Decimal(20,2),
--Nhapdodang1			Decimal(20,2),
--Nhapnguyen1			Decimal(20,2),
--Mamau2				Nvarchar(50),
--Xuatdodang2			Decimal(20,2),
--Xuatnguyen2			Decimal(20,2),
--Nhapdodang2			Decimal(20,2),
--Nhapnguyen2			Decimal(20,2),
--Mamau3				Nvarchar(50),
--Xuatdodang3			Decimal(20,2),
--Xuatnguyen3			Decimal(20,2),
--Nhapdodang3			Decimal(20,2),
--Nhapnguyen3			Decimal(20,2),
--Mamau4				Nvarchar(50),
--Xuatdodang4			Decimal(20,2),
--Xuatnguyen4			Decimal(20,2),
--Nhapdodang4			Decimal(20,2),
--Nhapnguyen4			Decimal(20,2),
--Mamau5				Nvarchar(50),
--Xuatdodang5			Decimal(20,2),
--Xuatnguyen5			Decimal(20,2),
--Nhapdodang5			Decimal(20,2),
--Nhapnguyen5			Decimal(20,2),
--Mamau6				Nvarchar(50),
--Xuatdodang6			Decimal(20,2),
--Xuatnguyen6			Decimal(20,2),
--Nhapdodang6			Decimal(20,2),
--Nhapnguyen6			Decimal(20,2),
--Mamau7				Nvarchar(50),
--Xuatdodang7			Decimal(20,2),
--Xuatnguyen7			Decimal(20,2),
--Nhapdodang7			Decimal(20,2),
--Nhapnguyen7			Decimal(20,2),
--Mamau8				Nvarchar(50),
--Xuatdodang8			Decimal(20,2),
--Xuatnguyen8			Decimal(20,2),
--Nhapdodang8			Decimal(20,2),
--Nhapnguyen8			Decimal(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Ketquain_Mayin_FK Foreign Key (Mamay) References Dmmay (Mamay) On Delete No Action On Update Cascade,
constraint Ketquain_PK primary key (Id)) ON [PRIMARY]

alter table Ketquain add Tensanpham		Nvarchar(250),
Tenmay			Nvarchar(250),
Tencongnhan		Nvarchar(250),

Create table Ketquainmau(
Id				Bigint Identity Not null,
KetquainId		Bigint,
Masp			Nvarchar(50) Not null,
Tensp			Nvarchar(250),
Mamau		Nvarchar(50),
Tenmau		Nvarchar(250),
Xuatdodang		Decimal(20,2),
Xuatnguyen		Decimal(20,2),
Nhapdodang		Decimal(20,2),
Nhapnguyen		Decimal(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Ketquainmau_PK primary key (Id)) ON [PRIMARY]


/* lọc */
CREATE TABLE Kehoachloc (
Id					BigInt Identity Not null,
Madonhangchitiet	BigInt,
Ngaydat				DATE,
Ngaygiao			DATE,
Masanpham			Nvarchar(50),
Lenhloc				Nvarchar(50),
Mamay				Nvarchar(50),
Ngaychay			DATE,
Ca					Int,
Somet				Decimal(20,2),
Sokg				Decimal(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Kehoachloc_Mayloc_FK Foreign Key (Mamay) References Dmmay (Mamay) On Delete No Action On Update Cascade,
constraint Kehoachloc_PK primary key (Id)) ON [PRIMARY]

/* ghép */
CREATE TABLE Kehoachghep (
Id					BigInt Identity Not null,
Madonhangchitiet	BigInt,
Ngaydat				DATE,
Ngaygiao			DATE,
Masanpham			Nvarchar(50),
Lenhghep			Nvarchar(50),
Mamay				Nvarchar(50),
Ngaychay			DATE,
Ca					Int,
Somet				Decimal(20,2),
Sokg				Decimal(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Kehoachghep_Mayghep_FK Foreign Key (Mamay) References Dmmay (Mamay) On Delete No Action On Update Cascade,
constraint Kehoachghep_PK primary key (Id)) ON [PRIMARY]

CREATE TABLE Ketquaghep (
Id					BigInt Identity Not null,
Ngay				DATE,
Ca					Int,
Mamay				Nvarchar(50),
Lenhghep			Nvarchar(50),
Masanpham			Nvarchar(50),
Macongnhan			Nvarchar(50),
Tensanpham		Nvarchar(250),
Tenmay			Nvarchar(250),
Tencongnhan		Nvarchar(250),
Dauratua			Decimal(20,2),
ManginMet			Decimal(20,2), /* Màng in M */
ManginKg			Decimal(20,2), /* Màng in kg */
MangcapMet			Decimal(20,2), /* Màng cấp M */
MangcapKg			Decimal(20,2), /* Màng cấp kg */
Solopghep			Int,
ThucteMet			Decimal(20,2), /* Thực tế M */
ThucteKg			Decimal(20,2), /* Thực tế Kg */
Thoigianbatdau		DATETIME,
Thoigianketthuc		DATETIME,
Thoigianchuanbi		Decimal(20,2),
Thoigiansuco		Decimal(20,2),
--Giomaychay			Decimal(20,2),
--Tocdomaydinhmuc		Decimal(20,2),
--Tocdomaythucte		Decimal(20,2),
--Kichthuocmang		Decimal(20,2),
--Dinhmuckeo			Decimal(20,2),
--Dinhmucdongran		Decimal(20,2),
--Dinhmucdungmoi		Decimal(20,2),
Thuctekeo			Decimal(20,2),
Thuctedongran		Decimal(20,2),
Thuctedungmoi		Decimal(20,2),
Phein				Decimal(20,2),
Pheghep				Decimal(20,2),
PheNCC				Decimal(20,2),
PheSX				Decimal(20,2),
Phethoi				Decimal(20,2),
Pheintui			Decimal(20,2),
Phegheptui			Decimal(20,2),
Phethoi_NCC			Decimal(20,2), /* phế thổi + nhà cung cấp*/
Phesxtui			Decimal(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Ketquaghep_Mayghep_FK Foreign Key (Mamay) References Dmmay (Mamay) On Delete No Action On Update Cascade,
constraint Ketquaghep_PK primary key (Id)) ON [PRIMARY]

alter table ketquaghep add Tensanpham		Nvarchar(250),
Tenmay			Nvarchar(250),
Tencongnhan		Nvarchar(250),

/* Tua */
CREATE TABLE Kehoachtua (
Id					BigInt Identity Not null,
Madonhangchitiet	BigInt,
Ngaydat				DATE,
Ngaygiao			DATE,
Masanpham			Nvarchar(50),
Lenhtua				Nvarchar(50),
Mamay				Nvarchar(50),
Ngaychay			DATE,
Ca					Int,
Somet				Decimal(20,2),
Sokg				Decimal(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Kehoachtua_Maytua_FK Foreign Key (Mamay) References Dmmay (Mamay) On Delete No Action On Update Cascade,
constraint Kehoachtua_PK primary key (Id)) ON [PRIMARY]

CREATE TABLE Ketquatua (
Id					BigInt Identity Not null,
Ngay				DATE,
Ca					Int,
Mamay				Nvarchar(50),
Lenhtua				Nvarchar(50),
Masanpham			Nvarchar(50),
Macongnhan			Nvarchar(50),
Tensanpham		Nvarchar(250),
Tenmay			Nvarchar(250),
Tencongnhan		Nvarchar(250),
Daurain				Decimal(20,2),
SoMetvao			Decimal(20,2), /* số M vào */
SoKgvao				Decimal(20,2), /* số Kg vào */
SoMetra				Decimal(20,2), /* số M ra */
SoKgra				Decimal(20,2), /* số Kg ra */
Saihongthucte		Decimal(20,2),
--Dinhmucsaihong		Decimal(20,2),
Thoigianbatdau		DATETIME,
Thoigianketthuc		DATETIME,
Thoigianchuanbi		Decimal(20,2),
Thoigianhacuon		Decimal(20,2),
Thoigiancatdau		Decimal(20,2),
Thoigiandoilenh		Decimal(20,2),
Thoigiansuco		Decimal(20,2),
--Giomaychay			Decimal(20,2),
--Tocdomaydinhmuc		Decimal(20,2),
--Tocdomaythucte		Decimal(20,2),
--Nangsuat			Decimal(20,2),
Phein				Decimal(20,2),
Pheghep				Decimal(20,2),
Phethoi				Decimal(20,2),
Phesx				Decimal(20,2),
--Sohinh				Decimal(20,2),
--SoluongM2			Decimal(20,2), /* số lượng m2 */
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Ketquatua_Maytua_FK Foreign Key (Mamay) References Dmmay (Mamay) On Delete No Action On Update Cascade,
constraint Ketquatua_PK primary key (Id)) ON [PRIMARY]

alter table ketquatua add Tensanpham		Nvarchar(250),
Tenmay			Nvarchar(250),
Tencongnhan		Nvarchar(250),


CREATE TABLE Kehoachchia(
Id					BigInt Identity Not null,
Madonhangchitiet	BigInt,
Ngaydat				DATE,
Ngaygiao			DATE,
Masanpham			Nvarchar(50),
Lenhchia			Nvarchar(50),
Mamay				Nvarchar(50),
Ngaychay			DATE,
Ca					Int,
Somet				DECIMAL(20,2),
Sokg				DECIMAL(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Kehoachchia_PK primary key (Id)) ON [PRIMARY]

Create table Ketquachia(
Id					BigInt Identity Not null,
Ngay				Date,
Ca					Int,
Mamay				Nvarchar(50),
Lenh				Nvarchar(50),
Masanpham			Nvarchar(50),
Macongnhan			Nvarchar(50),
Tensanpham		Nvarchar(250),
Tenmay			Nvarchar(250),
Tencongnhan		Nvarchar(250),
Dauraghep			Nvarchar(100),
Sometvao			Decimal(20,2),
Sokgvao				Decimal(20,2),
--Sohinh				Int,
Socon				Int,
Thoigianbatdau		DATETIME,
Thoigianketthuc		DATETIME,
Thoigianlencuon		DATETIME,
Thoigianhacuon		DATETIME,	--Thời gian hạ cuộn--
Solanhacuon			Int,		--Số lần hạ cuộn--	
Thoigiancatdau		DATETIME,
Thoigiandoilenh		DATETIME,
Thoigiansuco		DATETIME,
--Giochaymay			DATETIME,
--Tocdomaydinhmuc		DECIMAL(20,2),	--Tốc độ máy định mức--
--Tocdomaythucte		DECIMAL(20,2),	--Tốc độ máy thực tế--
--Nangsuat			DECIMAL(20,2),
Phein				DECIMAL(20,2),
Pheghep				DECIMAL(20,2),
Phechia				DECIMAL(20,2),
PhethoiNCC			DECIMAL(20,2),	--Phế thổi + Ncc--
Phesx				DECIMAL(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint Ketquachia_Kehoachchia_FK Foreign Key (Masanpham) References Kehoachchia (Id) On Delete No Action On Update Cascade,
constraint Ketquachia_PK primary key (Id)) ON [PRIMARY]

alter table ketquachia add Mamay				Nvarchar(50),
Tensanpham		Nvarchar(250),
Tenmay			Nvarchar(250),
Tencongnhan		Nvarchar(250),




---------------Nghiệp vụ kho-------------------------
CREATE TABLE Sodusanpham(
Id					BigInt Identity Not null,
Ngaykiemke			DATE,
Makho				Nvarchar(50),
Tenkho				Nvarchar(250),
Masanpham			Nvarchar(50),
Tensanpham			Nvarchar(250),
Somet				DECIMAL(20,2),
Soluong				DECIMAL(20,2),	--số lượng--
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Sodusanpham_PK primary key (Id)) ON [PRIMARY]

CREATE TABLE Sodumang(
Id					BigInt Identity Not null,
Ngaykiemke			DATE,
Makho				Nvarchar(50),
Tenkho				Nvarchar(250),
Mamang			Nvarchar(50),
Tenmang			Nvarchar(250),
Somet				DECIMAL(20,2),
Sokg				DECIMAL(20,2),	--số lượng--
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Sodumang_PK primary key (Id)) ON [PRIMARY]

CREATE TABLE Sodunguyenlieu(
Id					BigInt Identity Not null,
Ngaykiemke			DATE,
Makho				Nvarchar(50),
Tenkho				Nvarchar(250),
Manguyenlieu		Nvarchar(50),
Tennguyenlieu		Nvarchar(250),
Donvitinh			Nvarchar(50),
Soluong				DECIMAL(20,2),	--số lượng--
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Sodunguyenlieu_PK primary key (Id)) ON [PRIMARY]


--------------------Nhập kho---------------
CREATE TABLE Nhapkhosanpham(
Id					BigInt Identity Not null,
Ngaynhap			DATE,
Makho				Nvarchar(50),
Tenkho				Nvarchar(250),
Masanpham			Nvarchar(50),
Tensanpham			Nvarchar(250),
Soluong				DECIMAL(20,2),
Somet				DECIMAL(20,2),
Sokg				DECIMAL(20,2),
Malydo				Nvarchar(50),
Tenlydo				Nvarchar(250),
Lenhsx				Nvarchar(50),
Sohopdongmua		Nvarchar(50),	--số hợp đồng mua--
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Nhapkhosanpham_PK primary key (Id)) ON [PRIMARY]

CREATE TABLE Nhapkhomang(
Id					BigInt Identity Not null,
Ngaynhap			DATE,
Makho				Nvarchar(50),
Tenkho				Nvarchar(250),
Mamang			Nvarchar(50),
Tenmang			Nvarchar(250),
Somet				DECIMAL(20,2),
Sokg				DECIMAL(20,2),
Malydo				Nvarchar(50),
Tenlydo				Nvarchar(250),
Lenhsx				Nvarchar(50),
Sohopdongmua		Nvarchar(50),	--số hợp đồng mua--
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Nhapkhomang_PK primary key (Id)) ON [PRIMARY]

CREATE TABLE Nhapkhonguyenlieu(
Id					BigInt Identity Not null,
Ngaynhap			DATE,
Makho				Nvarchar(50),
Tenkho				Nvarchar(250),
Manguyenlieu		Nvarchar(50),
Tennguyenlieu		Nvarchar(250),
Donvitinh			Nvarchar(50),
Soluong				DECIMAL(20,2),	--số lượng--
Malydo				Nvarchar(50),
Tenlydo				Nvarchar(250),
Sohopdongmua		Nvarchar(50),	--số hợp đồng mua--
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Nhapkhonguyenlieu_PK primary key (Id)) ON [PRIMARY]


/* Xuất kho */
CREATE TABLE Xuatkhosanpham(
Id					BigInt Identity Not null,
Ngayxuat			DATE,
Makho				Nvarchar(50),
Tenkho				Nvarchar(250),
Masanpham			Nvarchar(50),
Tensanpham			Nvarchar(250),
Soluong				DECIMAL(20,2),
Somet				DECIMAL(20,2),
Sokg				DECIMAL(20,2),
Malydo				Nvarchar(50),
Tenlydo				Nvarchar(250),
Lenhsx				Nvarchar(50),
Sophieugiao			Nvarchar(50),	--số hợp đồng mua--
Madonhang			Nvarchar(50),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Xuatkhosanpham_PK primary key (Id)) ON [PRIMARY]

CREATE TABLE Xuatkhomang(
Id					BigInt Identity Not null,
Ngayxuat			DATE,
Makho				Nvarchar(50),
Tenkho				Nvarchar(250),
Mamang			Nvarchar(50),
Tenmang			Nvarchar(250),
Somet				DECIMAL(20,2),
Sokg				DECIMAL(20,2),
Malydo				Nvarchar(50),
Tenlydo				Nvarchar(250),
Lenhsx				Nvarchar(50),
Sophieugiao			Nvarchar(50),	--số hợp đồng mua--
Madonhang			Nvarchar(50),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Xuatkhomang_PK primary key (Id)) ON [PRIMARY]

CREATE TABLE Xuatkhonguyenlieu(
Id					BigInt Identity Not null,
Ngayxuat			DATE,
Makho				Nvarchar(50),
Tenkho				Nvarchar(250),
Manguyenlieu		Nvarchar(50),
Tennguyenlieu		Nvarchar(250),
Donvitinh			Nvarchar(50),
Soluong				DECIMAL(20,2),	--số lượng--
Malydo				Nvarchar(50),
Tenlydo				Nvarchar(250),
Lenhxuat			Nvarchar(50),	--số hợp đồng mua--
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Xuatkhonguyenlieu_PK primary key (Id)) ON [PRIMARY]



------------------ Tính giá -----------------
/* Chi phí nguyên liệu */
CREATE TABLE Chiphinguyenlieu(
Id					BigInt Identity Not null,
Thang				DATE,
Masanpham			Nvarchar(50),
Tensanpham			Nvarchar(250),
Makhach				Nvarchar(50),
Kichthuoc			DECIMAL(20,2),
Trongluong			DECIMAL(20,2),
Chiphinguyenlieutui	DECIMAL(20,2),
Chiphimucin			DECIMAL(20,2),
Chiphikeo			DECIMAL(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Chiphinguyenlieu_PK primary key (Id)) ON [PRIMARY]

/* chi phí gia công */
CREATE TABLE Chiphigiacong(
Id					BigInt Identity Not null,
Thang				DATE,
Masanpham			Nvarchar(50),
Tensanpham			Nvarchar(250),
Makhach				Nvarchar(50),
Kichthuoc			DECIMAL(20,2),
Trongluong			DECIMAL(20,2),
Chiphithoi			DECIMAL(20,2),
Chiphiin			DECIMAL(20,2),
Chiphiloc			DECIMAL(20,2),
Chiphighep			DECIMAL(20,2),
Chiphitua			DECIMAL(20,2),
Chiphichia			DECIMAL(20,2),
Chiphihoanthien		DECIMAL(20,2),
Chiphidonggoi		DECIMAL(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Chiphigiacong_PK primary key (Id)) ON [PRIMARY]

/* Chi phí chung */

/* Công suất nhà máy */
CREATE TABLE Congsuatnhamay(
Thang				DATE,
Congsuatdukien		DECIMAL(20,2),
Congsuatthucte		DECIMAL(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Congsuatnhamay_PK primary key (Thang)) ON [PRIMARY]

/* Công suất theo hàng */
CREATE TABLE Congsuattheohang(
Id					BigInt Identity Not null,
Thang				DATE,
Masanpham			Nvarchar(50),
Tensanpham			Nvarchar(250),
Makhach				Nvarchar(50),
Kichthuoc			DECIMAL(20,2),
Trongluong			DECIMAL(20,2),
Congsuatthoi		DECIMAL(20,2),
Congsuatin			DECIMAL(20,2),
Congsuatloc			DECIMAL(20,2),
Congsuatchia		DECIMAL(20,2),
Congsuathoanthien	DECIMAL(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Congsuattheohang_PK primary key (Id)) ON [PRIMARY]

/* Hiệu suất sản xuất */
CREATE TABLE Hieusuatsanxuat(
Id					BigInt Identity Not null,
Thang				DATE,
Masanpham			Nvarchar(50),
Tensanpham			Nvarchar(250),
Makhach				Nvarchar(50),
Kichthuoc			DECIMAL(20,2),
Trongluong			DECIMAL(20,2),
Hieusuatthoi		DECIMAL(20,2),
Hieusuatin			DECIMAL(20,2),
Hieusuatghep		DECIMAL(20,2),
Hieusuatloc			DECIMAL(20,2),
Hieusuatchia		DECIMAL(20,2),
Hieusuathoanthien	DECIMAL(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Hieusuatsanxuat_PK primary key (Id)) ON [PRIMARY]

/* Sản lượng tối đa */
CREATE TABLE Sanluongtoida(
Id					BigInt Identity Not null,
Thang				DATE,
Masanpham			Nvarchar(50),
Tensanpham			Nvarchar(250),
Makhach				Nvarchar(50),
Kichthuoc			DECIMAL(20,2),
Trongluong			DECIMAL(20,2),
Sanluongthoi		DECIMAL(20,2),
Sanluongin			DECIMAL(20,2),
Sanluongghep		DECIMAL(20,2),
Sanluongloc			DECIMAL(20,2),
Sanluongchia		DECIMAL(20,2),
Sanluonghoanthien	DECIMAL(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Sanluongtoida_PK primary key (Id)) ON [PRIMARY]

/* Danh mục chi phí chung */
CREATE TABLE dmChiphichung(
Machiphi			Nvarchar(50),
Tenchiphi			Nvarchar(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint dmChiphichung_PK primary key (Machiphi)) ON [PRIMARY]

/* Chi phí chung */
CREATE TABLE Chiphichung(
Id					BigInt Identity Not null,
Thang				DATE,
Machiphi			Nvarchar(50),
Tenchiphi			Nvarchar(250),
Tongchiphi			DECIMAL(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Chiphichung_PK primary key (Id)) ON [PRIMARY]

/* Chi phí bán hàng */
CREATE TABLE dmChiphibanhang(
Machiphi			Nvarchar(50),
Tenchiphi			Nvarchar(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint dmChiphibanhang_PK primary key (Machiphi)) ON [PRIMARY]

CREATE TABLE Chiphibanhang(
Id					BigInt Identity Not null,
Thang				DATE,
Masanpham			Nvarchar(50),
Tensanpham			Nvarchar(250),
Makhach				Nvarchar(50),
Kichthuoc			DECIMAL(20,2),
Trongluong			DECIMAL(20,2),
Machiphi			Nvarchar(50),
Chiphitheotui		DECIMAL(20,2),	--Chi phí theo túi--
Chiphitheokg		DECIMAL(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Chiphibanhang_PK primary key (Id)) ON [PRIMARY]

/* Giá vốn hàng bán */
CREATE TABLE Giavonhangban(
Id					BigInt Identity Not null,
Thang				DATE,
Masanpham			Nvarchar(50),
Tensanpham			Nvarchar(250),
Makhach				Nvarchar(50),
Kichthuoc			DECIMAL(20,2),
Trongluong			DECIMAL(20,2),
Chiphinguyenlieutui	DECIMAL(20,2),	--Chi phí nguyên liệu túi--
Chiphigiacongtui	DECIMAL(20,2),	--Chi phí gia công túi--
Chiphichungtui		DECIMAL(20,2),	
Giavontui			DECIMAL(20,2),
Giavonkg			DECIMAL(20,2),
Tyleloinhuan		DECIMAL(20,2),
Loinhuantui			DECIMAL(20,2),	--Lợi nhuận túi--
Loinhuankg			DECIMAL(20,2),
Giabantui			DECIMAL(20,2),	--Giá bán túi--
Giabankg			DECIMAL(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Giavonhangban_PK primary key (Id)) ON [PRIMARY]