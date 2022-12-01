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

--Bang MenuRoles
Create table Menurole(
Menuid			Nvarchar(50) not null,
Rolesid			Nvarchar(50) not null,
constraint Menurole_Roles_FK Foreign Key (Rolesid) References Roles (Rolesid) On Delete No Action On Update Cascade,
constraint Menurole_Menu_FK Foreign Key (Menuid) References Menu (Menuid) On Delete No Action On Update Cascade,
constraint Menurole_PK primary key (Menuid, Rolesid)) ON [PRIMARY]

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

--Danh mục chủng loại
Create table Dmchungloai(
--Id				Bigint Identity Not null,
Machungloai		Nvarchar(50) Not null,
Tenchungloai	Nvarchar(250),
Kichthuoc		Nvarchar(50),
Trongluong		Decimal(20,3),
Rong			Decimal(20,3),
Dai				Decimal(20,3),
Somauma			Nvarchar(50),
Sohinhma		Nvarchar(50),
Somau			Int,
Sohinh			Int,
Maloaimuc		Nvarchar(50),
Loaimuc			Nvarchar(250),
Maqcdonggoi			Nvarchar(50),--Đưa vào quy cách
Tenqcdonggoi		Nvarchar(250),--Đưa vào quy cách
Maqcloaithung		Nvarchar(50),--Đưa vào quy cách
Tenqcloaithung		Nvarchar(250),--Đưa vào quy cách
Maqcthanhpham		Nvarchar(50),--Đưa vào quy cách
Tenqcthanhpham		Nvarchar(250),--Đưa vào quy cách
Ghichu			Nvarchar(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Dmchungloai_PK primary key (Machungloai)) ON [PRIMARY]

--Danh muc hang hoa
Create table dmhang(
Masp			Nvarchar(50) Not null,
Tensp			Nvarchar(250) Not null,
Maspcuakhach	Nvarchar(250),---
Machungloai		Nvarchar(50), --Bigint,---
Tenchungloai	Nvarchar(250),---
Makhach			Nvarchar(50),
Tenkhach		Nvarchar(250),
--Kichthuoc		nvarchar(50),--Đưa vào quy cách?
--Doday			Decimal(20,3),
Khomang			Decimal(20,3),---
Rongcuon		Decimal(20,3),---
Daicuon			Decimal(20,3),---
Rong			Decimal(20,3),
Dai				Decimal(20,3),
Hong			Decimal(20,3),---
Trongluong		Decimal(20,3),---
-----Thông tin phục vụ in
Somauma			Nvarchar(50),
Sohinhma		Nvarchar(50),
Somau			Int,
Sohinh			Int,
Maloaimuc		Nvarchar(50),
Loaimuc			Nvarchar(250),--Đưa vào quy cách được không?
Khoiluongmuc	Decimal(20,3),--Trường phụ thuộc
--Macautrucin		Nvarchar(50),
--Cautrucin		Nvarchar(250),--Liệu có phải trường phụ thuộc vào Loạimực+Kíchthước không?
Cautruc			Nvarchar(250), -----Ghép các cấu trúc (loại, độ rộng) lại
--các màu in của sp liên kết với bảng maucuahang
-----Thông tin phục vụ ghép
Solopghepma			Nvarchar(50),
Solopghep			Int,
--Mamang1			Nvarchar(50),---
--Tenmang1		Nvarchar(250),---
--Tlmanglop1		Decimal(20,3),---
--Tlkeolop1		Decimal(20,3),---
--Mamang2			Nvarchar(50),---
--Tenmang2		Nvarchar(250),---
--Tlmanglop2		Decimal(20,3),---
--Tlkeolop2		Decimal(20,3),---
--Dinhluongkeo	Decimal(20,3),---
Kichthuoctruc	Nvarchar(100),--Kiểm tra lại dữ liệu
Vitri			Nvarchar(100),--Kiểm tra lại dữ liệu
-----Thông tin phục vụ hoàn thiện
Maqcdonggoi			Nvarchar(50),--Đưa vào quy cách
Tenqcdonggoi		Nvarchar(250),--Đưa vào quy cách
Maqcloaithung		Nvarchar(50),--Đưa vào quy cách
Tenqcloaithung		Nvarchar(250),--Đưa vào quy cách
Maqcthanhpham		Nvarchar(50),--Đưa vào quy cách
Tenqcthanhpham		Nvarchar(250),--Đưa vào quy cách
Bangdinhdan		Decimal(20,3),
Hesoquydoi		Decimal(20,3),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint dmhang_PK primary key (Masp)) ON [PRIMARY]

Create table maucuahang(
Id				Bigint Identity Not null,
Masp			Nvarchar(50) Not null,
Tensp			Nvarchar(250),
Mamau		Nvarchar(50),
Tenmau		Nvarchar(250),
Tylebaophu	Decimal(20,3),
Klmau		Decimal(20,3),
MaARGB			Bigint,
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

Create table mangcuahang(
Id				Bigint Identity Not null,
Masp			Nvarchar(50) Not null,
Tensp			Nvarchar(250),
Mangin				Bit default 0,		--1: Là màng in, 0: Là màng ghép
Thutulopghep		Int,
Mamang				Nvarchar(50),
Tenmang				Nvarchar(250),
Doday			Decimal(20,3),
Maloaimang		Nvarchar(50),
Tenloaimang		Nvarchar(250),
Maloaikeo			Nvarchar(50),
Tenloaikeo			Nvarchar(250),
Maloaidongran		Nvarchar(50),
Tenloaidongran		Nvarchar(250),
Dinhmuckeokho			Decimal(20,3),
Dinhmucdongrankho		Decimal(20,3),
Tylekeokho			Decimal(20,3),
Tyledongrankho		Decimal(20,3),
Tylekeo				Decimal(20,3),
Tyledongran			Decimal(20,3),
Dinhmuckeouot			Decimal(20,3),
Dinhmucdongranuot		Decimal(20,3),
Dinhmucdungmoi		Decimal(20,3),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint mangcuahang_PK primary key (Id)) ON [PRIMARY]

Create table Keocuahang(
Id				Bigint Identity Not null,
Masp			Nvarchar(50) Not null,
Tensp			Nvarchar(250),
Makeo_dongran			Nvarchar(50),
Tenkeo_dongran			Nvarchar(250),
Dinhmuckeo_dongran		Decimal(20,3),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Keocuahang_PK primary key (Id)) ON [PRIMARY]

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

--Danh muc bo phan
Create table dmbophan(
Mabp			Nvarchar(50) Not null, 
Tenbophan		Nvarchar(250) Not null,
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint dmbophan_PK primary key (Mabp)) ON [PRIMARY]

--Danh muc chuc vu
Create table dmchucvu(
Macv			Nvarchar(50) Not null, 
Tenchucvu		Nvarchar(250) Not null,
Heso			Decimal(20,3) Default 1,
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint dmchucvu_PK primary key (Macv)) ON [PRIMARY]

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
Hesorieng			Decimal(20,3),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint quycach_congdoan_FK Foreign Key (Macd) References dmcongdoan (Macd) On Delete No Action On Update Cascade,
constraint Dmquycach_PK primary key (Maquycach)) ON [PRIMARY]

--Cong suat may: khổ, dài túi, độ dày, số màu, số hình, cấu trúc, dán dựng, cắt nhiệt, mã khách
Create table congsuatmay(
Macongsuat		Nvarchar(50) Not null, 
Tencongsuat		Nvarchar(250),
Dodaytu			Decimal(20,3),
Dodayden		Decimal(20,3),
Khotu			Decimal(20,3),
Khoden			Decimal(20,3),
Chieudaitu		Decimal(20,3),
Chieudaiden		Decimal(20,3),
Mamays				Nvarchar(MAX),
Macongdoans			Nvarchar(MAX),
Somaumas			Nvarchar(MAX),
Sohinhmas			Nvarchar(MAX),
Maloaimangs1		Nvarchar(MAX),
Maloaimangs2		Nvarchar(MAX),
Maqcthanhphams		Nvarchar(MAX),
Makhachs			Nvarchar(MAX),
Mahangs				Nvarchar(MAX),
Tocdo			Decimal(20,3),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint congsuatmay_congdoan_FK Foreign Key (Macd) References dmcongdoan (Macd) On Delete No Action On Update Cascade,
constraint congsuatmay_PK primary key (Macongsuat)) ON [PRIMARY]

--dinh muc thoi gian
Create table Dinhmucthoigian(
Madinhmuc		Nvarchar(50) Not null,
Tendinhmuc		Nvarchar(250) Not null,
Dodaytu			Decimal(20,3),
Dodayden		Decimal(20,3),
Khotu			Decimal(20,3),
Khoden			Decimal(20,3),
Chieudaitu		Decimal(20,3),
Chieudaiden		Decimal(20,3),
Mamays				Nvarchar(MAX),
Macongdoans			Nvarchar(MAX),
Somaumas			Nvarchar(MAX),
Sohinhmas			Nvarchar(MAX),
Maloaimangs			Nvarchar(MAX),
Maqcthanhphams		Nvarchar(MAX),
Makhachs			Nvarchar(MAX),
Mahangs				Nvarchar(MAX),
Dauca			Decimal(20,3),
Chuanbi			Decimal(20,3),
Daucuon			Decimal(20,3),
Doilenh			Decimal(20,3),
Lencuon			Decimal(20,3),
Xuongcuon		Decimal(20,3),
Thaythietbi		Decimal(20,3),
Dungmay			Decimal(20,3),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Dinhmucthoigian_PK primary key (Madinhmuc)) ON [PRIMARY]

--dinh muc vật tư & sai hỏng
Create table dinhmucvattu(
Madinhmuc		Nvarchar(50) Not null,
Tendinhmuc		Nvarchar(250) Not null,
Manhom			Nvarchar(50),--v
Tennhom			Nvarchar(250),--v
Mamay			Nvarchar(50),--v
Madongmay		Nvarchar(50),--v
Macongdoan		Nvarchar(50),--v
--Dodaytu			Decimal(20,3),
--Dodayden		Decimal(20,3),
--Khotu			Decimal(20,3),
--Khoden			Decimal(20,3),
--Chieudaitu		Decimal(20,3),
--Chieudaiden		Decimal(20,3),
Somauma				Nvarchar(MAX),--v
Maloaimuc			Nvarchar(MAX),--v
Mamau				Nvarchar(MAX),--v
--Sohinhma			Nvarchar(MAX),
Maloaimang			Nvarchar(MAX),--v
Maqcthanhpham		Nvarchar(MAX),--v
Dinhmuc			Decimal(20,3),--v
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint dinhmucvattu_PK primary key (Madinhmuc)) ON [PRIMARY]

Create table dmnhomdinhmuc(
Manhom			Nvarchar(50) Not null, 
Tennhom			Nvarchar(250),
Tenrutgon		Nvarchar(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint dmnhomdinhmuc_PK primary key (Manhom)) ON [PRIMARY]


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

--Danh muc nguyen lieu
Create table Dmnguyenlieu(
Id			BigInt Identity Not null,
Manl			Nvarchar(50) Not null,
Tennl			Nvarchar(100),
Tenrutgon		Nvarchar(250),
Manhom			Nvarchar(50),
Tennhom			Nvarchar(250),
Tonkhotoithieu		Decimal(20,3),
Gia				Decimal(20,3),
Ngay			DATE,
Giahientai		Decimal(20,3),
Tang			Decimal(20,3),
Giam			Decimal(20,3),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Dmnguyenlieu_nhom_FK Foreign Key (Manhom) References dmnhomnguyenlieu (Manhom) On Delete No Action On Update Cascade,
constraint Dmnguyenlieu_PK primary key (Id)) ON [PRIMARY]

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

--Danh muc cong thuc phoi tron
Create table ctptmang_d(
id				BigInt Identity Not null,
id_h			BigInt,
Mact			Nvarchar(50) Not null,
Tenct			Nvarchar(250) Not null,
Manl			Nvarchar(50) Not null,
Tennguyenlieu	Nvarchar(250) Not null,
Trongluong		Decimal(20,3),
Tyle			Decimal(20,3),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint ctptmangd_ctptmangh_FK Foreign Key (id_h) References ctptmang_h (id) On Delete No Action On Update Cascade,
--constraint ctptmangd_nl_FK Foreign Key (Manl) References dmnguyenlieu (Manl) On Delete No Action On Update Cascade,
constraint ctptmangd_PK primary key (id)) ON [PRIMARY]

--Danh muc mang
Create table dmmang(
Mamang			Nvarchar(50) Not null,
Tenmang			Nvarchar(250) Not null,
Makhach			Nvarchar(50),
Tenkhach		Nvarchar(250),
Kichthuoc		Nvarchar(250),
Trongluong		Decimal(20,3),
Doday			Decimal(20,3),
Rong			Decimal(20,3),
Maloaimang		Nvarchar(50),
Tenloaimang		Nvarchar(250),
Maqcmang		Nvarchar(50),
Tenqcmang		Nvarchar(250),
Mactpt			Nvarchar(50),
Hesoquydoi			Decimal(20,3),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint mang_ctpt_FK Foreign Key (Mactpt) References ctptmang_h (Mactpt) On Delete No Action On Update Cascade,
constraint mang_PK primary key (Mamang)) ON [PRIMARY]

--Danh muc mau
Create table dmmau(
Mamau			Nvarchar(50) Not null,
Tenmau			Nvarchar(250) Not null,
Ghichu			Nvarchar(250),
Kyhieu			Nvarchar(50),		
Masanphams		Nvarchar(MAX),
Tensanphams		Nvarchar(MAX),
MaARGB			Bigint,
Lamaugoc		Bit default 0, --0: Là màu pha; 1: Là màu gốc
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint mau_PK primary key (Mamau)) ON [PRIMARY]

Create table thanhphanmau(
Id			BigInt Identity Not null,
Mamau		Nvarchar(50),
Tenmau		Nvarchar(250),
Mausudung		Nvarchar(50),
Tenmausudung	Nvarchar(250),
Tyle			Decimal(20,3),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint thanhphanmau_dmmau_FK Foreign Key (Mamau) References dmmau (Mamau) On Delete No Action On Update Cascade,
constraint thanhphanmau_PK primary key (Id)) ON [PRIMARY]

Create table Dinhmuckeo(
Madinhmuc	Nvarchar(50) Not null,
Tendinhmuc	Nvarchar(250),
Tenrutgon	NVarchar(250),
Makeo			Nvarchar(50),--Từ bảng danh mục nguyên liệu (dmnguyenlieu), Nhóm nguyên liệu: KEO
Tenkeo			Nvarchar(250),
Madongran		Nvarchar(50),--Từ bảng danh mục nguyên liệu (dmnguyenlieu), Nhóm nguyên liệu: DONGRAN
Tendongran		Nvarchar(250),
Hamluongkeo			Decimal(20,3),
Hamluongdongran		Decimal(20,3),
Tylephakeo			Decimal(20,3),
Tylephadongran		Decimal(20,3),
Dungmoi				Decimal(20,3),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Dinhmuckeo_PK primary key (Madinhmuc)) ON [PRIMARY]

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

--Bao gia 
Create table baogia_h(
Sobaogia		Nvarchar(50) Not null,
Ngaybaogia		DATE,
Ngayhieuluc		DATE,
Makhach			Nvarchar(50) Not null,
Tenkhach		Nvarchar(250),
Noidung			Nvarchar(MAX),
Phuongthuctt	Nvarchar(MAX),
Phuongthucgiao		Nvarchar(MAX),
Thoigiangiao		Nvarchar(MAX),
Xacnhanbaogia		Bit,
Lydo				Nvarchar(MAX),
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
Masp			Nvarchar(50),
Tensp			Nvarchar(250),
Maspcuakhach	Nvarchar(250),---
Doday			Decimal(20,3),
Rong			Decimal(20,3),
Dai				Decimal(20,3),
Trongluong		Decimal(20,3),
Loaimuc			Nvarchar(250),--Đưa vào quy cách được không?
Cautruc			Nvarchar(250),--Liệu có phải trường phụ thuộc vào Loạimực+Kíchthước không?
Tenqcdonggoi		Nvarchar(250),--Đưa vào quy cách
Tenqcloaithung		Nvarchar(250),--Đưa vào quy cách
Tenqcthanhpham		Nvarchar(250),--Đưa vào quy cách
Mota			Nvarchar(MAX),
DongiakhongVAT	INT,
DongiaVAT		INT,
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint baogiad_hang_FK Foreign Key (Masp) References dmhang (Masp) On Delete No Action On Update Cascade,
constraint baogiad_baogiah_FK Foreign Key (Sobaogia) References baogia_h (Sobaogia) On Delete No Action On Update Cascade,
constraint baogiad_PK primary key (Id)) ON [PRIMARY]

--Don hang
Create table donhang_h(
Madon			Nvarchar(50) Not null,
Ngaydat			DATE,
Makhach			Nvarchar(50) Not null,
Tenkhach		Nvarchar(250) Not null,
--Sobaogia		Nvarchar(50),
--Ngaybaogia		DATE,
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

alter table donhang_h drop column Sobaogia
alter table donhang_h drop column Ngaybaogia

--Don hang chi tiet
Create table donhang_d(
Id 				BigInt Identity Not null,
Madon			Nvarchar(50) Not null,
Ngaydat			DATE,
Makhach			Nvarchar(50) Not null,
Sobaogia		Nvarchar(50),
Ngaybaogia		DATE,
Loaihang		INT,	--0: Túi (hàng hóa); 1: Màng (PE); 
Masp			Nvarchar(50),
Tenhang			Nvarchar(250),
Soluong 		Decimal(20,3),
Dongia			Decimal(20,3),
--Thanhtien		Decimal(20,3),
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

alter table donhang_d add Ngaybaogia		DATE,

Create table Lenhsanxuat(
Solenhsx		Nvarchar(50) Not Null,
Ngayphatlenh		Date,
Ngaybatdausx		Date,
Ngayhoanthanhsx		Date,
--Thông tin đơn hàng (donhang_h)
Madon			Nvarchar(50) Not null,		--Liên kết với trường Madon trong Donhang_h
Ngaydat			DATE,
Makhach			Nvarchar(50) Not null,
Tenkhach		Nvarchar(250) Not null,
--Thông tin đơn hàng chi tiết (donhang_d)
Madonhangchitiet	BigInt,					--Liên kết với trường Id trong Donhang_d
Loaihang			INT,	--0: Túi (hàng hóa); 1: Màng (PE); 
Masp			Nvarchar(50),
Tenhang			Nvarchar(250),
Soluong 		Decimal(20,3),
Ngaygiao		DATE,

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Lenhsanxuat_PK primary key (Solenhsx)) ON [PRIMARY]

Create table Mangtheolenh(
Id 				BigInt Identity Not null,
Solenhsx		Nvarchar(50),
Ngayphatlenh		Date,

constraint Mangtheolenh_PK primary key (Id)) ON [PRIMARY]

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
Soluong 		Decimal(20,3),
Dongia			Decimal(20,3),
Thanhtien		Decimal(20,3),
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

--Hang tra lai
Create table Hangtralai(
Id 				BigInt Identity Not null,
Ngaytra			DATE,
Makhach			Nvarchar(50),
Tenkhach		Nvarchar(250),
Masanpham		Nvarchar(MAX),
Tensanpham		Nvarchar(MAX),
Soluongtra		Decimal(20,3),
Nguyennhan		Nvarchar(MAX),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Hangtralai_PK primary key (Id)) ON [PRIMARY]


/* Thổi */
CREATE TABLE Kehoachthoi(
Id					BigInt Identity Not null,
Solenhsx		Nvarchar(50),
Ngaydat				DATE,
Ngaygiao			DATE,
Mamang				Nvarchar(50),
--Lenhthoi			Nvarchar(50),
Mamay				Nvarchar(50),
Ngaychay			DATE,
Ca					Int,
Somet				Decimal(20,3),
Sokg				Decimal(20,3),
Sometdukien			Decimal(20,3),
Sokgdukien			Decimal(20,3),
Soluong				Int,
Sldukien			Int,
Tgdukien			Int,	--Số phút dự kiến
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Kehoachthoi_Maythoi_FK Foreign Key (Mamay) References Dmmay (Mamay) On Delete No Action On Update Cascade,
constraint Kehoachthoi_PK primary key (Id)) ON [PRIMARY]

Alter table Kehoachthoi add Sometdukien			Decimal(20,3),
Sokgdukien			Decimal(20,3),
Soluong				Int,
Sldukien			Int,
Tgdukien			Int,	--Số phút dự kiến

CREATE TABLE Ketquathoi(
Id					BigInt Identity Not null,
Ngay				DATE,
Ca					Int,
Mamay				Nvarchar(50),
Lenhthoi			Nvarchar(50),
Mamang				Nvarchar(50),
Macongnhan			Nvarchar(MAX),
Tencongnhan			Nvarchar(MAX),
Matruongca			Nvarchar(50),		--Tự động hiện sau khi chọn: Macongnhan
Tentruongca			Nvarchar(250),		--Tự động hiện sau khi chọn: Macongnhan
Tenmang			Nvarchar(250),
Tenmay			Nvarchar(250),
Somet				Decimal(20,3),
Sokg				Decimal(20,3),
--Sokgquydoi			Decimal(20,3),
--Chenhlechkg			Decimal(20,3),
--Chatluong			Nvarchar(250),
Phelieuthucte		Decimal(20,3),
--Tongsp				Decimal(20,3),
--Dinhmucsaihong				Decimal(20,3),
--Dinhmucthoigianchuanbi		Decimal(20,3),
--Dinhmuckg					Decimal(20,3), /*định mức kg/giờ */
Thoigianbatdau		DATETIME,
Thoigianketthuc		DATETIME,
Thoigianchuanbi		Decimal(20,3),
Thoigiansuco		Decimal(20,3),
--Giomaychay			Decimal(20,3),
Chatluong			Decimal(20,3),
Nangsuat			Decimal(20,3),
Tocdodinhmuc		Decimal(20,3),
Lydosuco			Nvarchar(MAX),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Ketquathoi_Maythoi_FK Foreign Key (Mamay) References Dmmay (Mamay) On Delete No Action On Update Cascade,
constraint Ketquathoi_PK primary key (Id)) ON [PRIMARY]

Create table Tknguyenlieuthoi(
Id				BigInt Identity Not null,
Ngay			DATE,
Ca				Int,
Manguyenlieu	Nvarchar(50),
Tennguyenlieu	Nvarchar(250),
Klnhap			Decimal(20,3),
Klxuat			Decimal(20,3),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Tknguyenlieuthoi_PK primary key (Id)) ON [PRIMARY]

/* In */
CREATE TABLE Kehoachin(
Id					BigInt Identity Not null,
Solenhsx		Nvarchar(50),
Ngaydat				DATE,
Ngaygiao			DATE,
Masanpham			Nvarchar(50),
--Lenhin				Nvarchar(50),
Mamay				Nvarchar(50),
Ngaychay			DATE,
Ca					Int,
Somet				Decimal(20,3),
Sokg				Decimal(20,3),
Sometdukien			Decimal(20,3),
Sokgdukien			Decimal(20,3),
Soluong				Int,
Sldukien			Int,
Tgdukien			Int,	--Số phút dự kiến
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Kehoachin_Mayin_FK Foreign Key (Mamay) References Dmmay (Mamay) On Delete No Action On Update Cascade,
constraint Kehoachin_PK primary key (Id)) ON [PRIMARY]

CREATE TABLE Ketquain(
Id					BigInt Identity Not null,
Ngay				DATE,
Ca					Int,
Mamay				Nvarchar(50),
Lenhin				Nvarchar(50),
Masanpham			Nvarchar(50),
Macongnhan				Nvarchar(MAX),
Tencongnhan				Nvarchar(MAX),
Matruongca				Nvarchar(50),
Tentruongca				Nvarchar(250),
Tensanpham		Nvarchar(250),
Tenmay			Nvarchar(250),
SometLSX			Decimal(20,3), /* số m lệnh sản xuất */
Sometcap			Decimal(20,3), /* số m cấp */
Sokgcap				Decimal(20,3), /* số kg cấp */
Thuctein			Decimal(20,3),
Sokgin				Decimal(20,3), /* số kg in */
Saihongthucte		Decimal(20,3),
--Dinhmucinmet				Decimal(20,3),
--Dinhmucsaihongkg			Decimal(20,3),
--Dinhmucthoigianchuanbi		Decimal(20,3),
Thoigianbatdau		DATETIME,
Thoigianketthuc		DATETIME,
Thoigianchuanbi		Decimal(20,3),
Thoigiansuco		Decimal(20,3),
--Giomaychay			Decimal(20,3),
--Tocdomaydinhmuc		Decimal(20,3),
--Tocdomaythucte		Decimal(20,3),
Tylesaihong			Decimal(20,3),
Nangsuat			Decimal(20,3),
Tocdodinhmuc		Decimal(20,3),
Lydosuco			Nvarchar(MAX),
PheNCC				Decimal(20,3), /* phế NCC */
PheSX				Decimal(20,3), /* phế sản xuất */
----Sohinh				Decimal(20,3),
----Chieudaitui			Decimal(20,3),
----Tongmdm				Decimal(20,3), /*tổng m định mức */
--Tongm2dm			Decimal(20,3), /*tổng m2 định mức */
----M2saihongdm			Decimal(20,3), /*m2 sai hỏng định mức */
--M2saihongtt			Decimal(20,3), /*m2 sai hỏng thực tế */
----Nangsuattrungbinh	Decimal(20,3), 
----M2daura				Decimal(20,3),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Ketquain_Mayin_FK Foreign Key (Mamay) References Dmmay (Mamay) On Delete No Action On Update Cascade,
constraint Ketquain_PK primary key (Id)) ON [PRIMARY]

Create table Ketquainmau(
Id				Bigint Identity Not null,
KetquainId		Bigint,
Masp			Nvarchar(50) Not null,
Tensp			Nvarchar(250),
Mamau		Nvarchar(50),
Tenmau		Nvarchar(250),
Xuatdodang		Decimal(20,3),
Xuatnguyen		Decimal(20,3),
Nhapdodang		Decimal(20,3),
Nhapnguyen		Decimal(20,3),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Ketquainmau_PK primary key (Id)) ON [PRIMARY]

/* lọc */
CREATE TABLE Kehoachloc (
Id					BigInt Identity Not null,
Solenhsx		Nvarchar(50),
Ngaydat				DATE,
Ngaygiao			DATE,
Masanpham			Nvarchar(50),
--Lenhloc				Nvarchar(50),
Mamay				Nvarchar(50),
Ngaychay			DATE,
Ca					Int,
Somet				Decimal(20,3),
Sokg				Decimal(20,3),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Kehoachloc_Mayloc_FK Foreign Key (Mamay) References Dmmay (Mamay) On Delete No Action On Update Cascade,
constraint Kehoachloc_PK primary key (Id)) ON [PRIMARY]

/* ghép */
CREATE TABLE Kehoachghep (
Id					BigInt Identity Not null,
Solenhsx		Nvarchar(50),
Ngaydat				DATE,
Ngaygiao			DATE,
Masanpham			Nvarchar(50),
--Lenhghep			Nvarchar(50),
Mamay				Nvarchar(50),
Ngaychay			DATE,
Ca					Int,
Somet				Decimal(20,3),
Sokg				Decimal(20,3),
Sometdukien			Decimal(20,3),
Sokgdukien			Decimal(20,3),
Soluong				Int,
Sldukien			Int,
Tgdukien			Int,	--Số phút dự kiến
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
Macongnhan				Nvarchar(MAX),
Tencongnhan				Nvarchar(MAX),
Matruongca				Nvarchar(50),
Tentruongca				Nvarchar(250),
Tensanpham		Nvarchar(250),
Tenmay			Nvarchar(250),
Mamang			Nvarchar(50),
Tenmang			Nvarchar(250),
Dauratua			Decimal(20,3),
ManginMet			Decimal(20,3), /* Màng in M */
ManginKg			Decimal(20,3), /* Màng in kg */
MangcapMet			Decimal(20,3), /* Màng cấp M */
MangcapKg			Decimal(20,3), /* Màng cấp kg */
Solopghep			Int,								-----Liệu có đưa vào hồ sơ sản phẩm được không?
ThucteMet			Decimal(20,3), /* Thực tế M */
ThucteKg			Decimal(20,3), /* Thực tế Kg */
Thoigianbatdau		DATETIME,
Thoigianketthuc		DATETIME,
Thoigianchuanbi		Decimal(20,3),
Thoigiansuco		Decimal(20,3),
--Giomaychay			Decimal(20,3),
--Tocdomaydinhmuc		Decimal(20,3),
--Tocdomaythucte		Decimal(20,3),
--Kichthuocmang		Decimal(20,3),
--Dinhmuckeo			Decimal(20,3),
--Dinhmucdongran		Decimal(20,3),
--Dinhmucdungmoi		Decimal(20,3),
Thuctekeo			Decimal(20,3),
Thuctedongran		Decimal(20,3),
Thuctedungmoi		Decimal(20,3),
Phein				Decimal(20,3),
Pheghep				Decimal(20,3),
PheNCC				Decimal(20,3),
PheSX				Decimal(20,3),
Phethoi				Decimal(20,3),
--Pheintui			Decimal(20,3),
--Phegheptui			Decimal(20,3),
--Phethoi_NCC			Decimal(20,3), /* phế thổi + nhà cung cấp*/
--Phesxtui			Decimal(20,3),
Nangsuat			Decimal(20,3),
Tocdodinhmuc		Decimal(20,3),
Lydosuco			Nvarchar(MAX),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Ketquaghep_Mayghep_FK Foreign Key (Mamay) References Dmmay (Mamay) On Delete No Action On Update Cascade,
constraint Ketquaghep_PK primary key (Id)) ON [PRIMARY]

/* Tua */
CREATE TABLE Kehoachtua (
Id					BigInt Identity Not null,
Solenhsx		Nvarchar(50),
Ngaydat				DATE,
Ngaygiao			DATE,
Masanpham			Nvarchar(50),
--Lenhtua				Nvarchar(50),
Mamay				Nvarchar(50),
Ngaychay			DATE,
Ca					Int,
Somet				Decimal(20,3),
Sokg				Decimal(20,3),
Sometdukien			Decimal(20,3),
Sokgdukien			Decimal(20,3),
Soluong				Int,
Sldukien			Int,
Tgdukien			Int,	--Số phút dự kiến
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
Tenmay				Nvarchar(250),
Lenhtua				Nvarchar(50),
Masanpham			Nvarchar(50),
Tensanpham			Nvarchar(250),
Macongnhan				Nvarchar(MAX),
Tencongnhan				Nvarchar(MAX),
Matruongca				Nvarchar(50),
Tentruongca				Nvarchar(250),
Daurain				Decimal(20,3),
SoMetvao			Decimal(20,3), /* số M vào */
SoKgvao				Decimal(20,3), /* số Kg vào */
SoMetra				Decimal(20,3), /* số M ra */
SoKgra				Decimal(20,3), /* số Kg ra */
--Saihongthucte		Decimal(20,3),
--Dinhmucsaihong		Decimal(20,3),
Thoigianbatdau		DATETIME,
Thoigianketthuc		DATETIME,
--Thoigianchuanbi		Decimal(20,3),
Thoigianhacuon		Decimal(20,3),
Thoigiancatdau		Decimal(20,3),
Thoigiandoilenh		Decimal(20,3),
Thoigiansuco		Decimal(20,3),
--Giomaychay			Decimal(20,3),
--Tocdomaydinhmuc		Decimal(20,3),
--Tocdomaythucte		Decimal(20,3),
Phein				Decimal(20,3),
Pheghep				Decimal(20,3),
Phethoi				Decimal(20,3),
Phesx				Decimal(20,3),
Chenhlechkg			Decimal(20,3),
Nangsuat			Decimal(20,3),
Tocdodinhmuc		Decimal(20,3),
Lydosuco			Nvarchar(MAX),
--Sohinh				Decimal(20,3),
--SoluongM2			Decimal(20,3), /* số lượng m2 */
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Ketquatua_Maytua_FK Foreign Key (Mamay) References Dmmay (Mamay) On Delete No Action On Update Cascade,
constraint Ketquatua_PK primary key (Id)) ON [PRIMARY]

/* Chia */
CREATE TABLE Kehoachchia(
Id					BigInt Identity Not null,
Solenhsx		Nvarchar(50),
Ngaydat				DATE,
Ngaygiao			DATE,
Masanpham			Nvarchar(50),
--Lenhchia			Nvarchar(50),
Mamay				Nvarchar(50),
Ngaychay			DATE,
Ca					Int,
Somet				Decimal(20,3),
Sokg				Decimal(20,3),
Sometdukien			Decimal(20,3),
Sokgdukien			Decimal(20,3),
Soluong				Int,
Sldukien			Int,
Tgdukien			Int,	--Số phút dự kiến
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
Macongnhan				Nvarchar(MAX),
Tencongnhan				Nvarchar(MAX),
Matruongca				Nvarchar(50),
Tentruongca				Nvarchar(250),
Tensanpham		Nvarchar(250),
Tenmay			Nvarchar(250),
Dauraghep			Decimal(20,3),
Sometvao			Decimal(20,3),
Sokgvao				Decimal(20,3),
Sometra			Decimal(20,3),
Sokgra			Decimal(20,3),
--Sohinh				Int,
--Socon				Int,
Thoigianbatdau		DATETIME,
Thoigianketthuc		DATETIME,
Thoigianlencuon		Decimal(20,3),
Thoigianhacuon		Decimal(20,3),	--Thời gian hạ cuộn--
Solanhacuon			Int,			--Số lần hạ cuộn--	
Thoigiancatdau		Decimal(20,3),
Thoigiandoilenh		Decimal(20,3),
Thoigiansuco		Decimal(20,3),
--Giochaymay			DATETIME,
--Tocdomaydinhmuc		Decimal(20,3),	--Tốc độ máy định mức--
--Tocdomaythucte		Decimal(20,3),	--Tốc độ máy thực tế--
Nangsuat			Decimal(20,3),
Tocdodinhmuc		Decimal(20,3),
Lydosuco			Nvarchar(MAX),
Tylesaihong			Decimal(20,3),	
Socuon				Int,		--Số cuộn mang chia--			
Phein				Decimal(20,3),
Pheghep				Decimal(20,3),
Phechia				Decimal(20,3),
PhethoiNCC			Decimal(20,3),	--Phế thổi + Ncc--
Phesx				Decimal(20,3),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint Ketquachia_Kehoachchia_FK Foreign Key (Masanpham) References Kehoachchia (Id) On Delete No Action On Update Cascade,
constraint Ketquachia_PK primary key (Id)) ON [PRIMARY]

/* Hoàn thiện */
CREATE TABLE Kehoachhoanthien(
Id					BigInt Identity Not null,
Solenhsx		Nvarchar(50),
Ngaydat				DATE,
Ngaygiao			DATE,
Masanpham			Nvarchar(50),
--Lenhhoanthien		Nvarchar(50),
Mamay				Nvarchar(50),
Ngaychay			DATE,
Ca					Int,
Soluong			Int,
Somet				Decimal(20,3),
Sokg				Decimal(20,3),
Sometdukien			Decimal(20,3),
Sokgdukien			Decimal(20,3),
Sldukien			Int,
Tgdukien			Int,	--Số phút dự kiến
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Kehoachhoanthien_PK primary key (Id)) ON [PRIMARY]

CREATE TABLE Ketquahoanthien (
Id					BigInt Identity Not null,
Ngay				DATE,
Ca					Int,
Mamay				Nvarchar(50),
Tenmay			Nvarchar(250),
Lenhhoanthien		Nvarchar(50),
Masanpham			Nvarchar(50),
Tensanpham		Nvarchar(250),
Macongnhan				Nvarchar(MAX),
Tencongnhan				Nvarchar(MAX),
Matruongca				Nvarchar(50),
Tentruongca				Nvarchar(250),
--Socon			Int,

Daurachiaghep		Decimal(20,3),
Dauvaomet			Decimal(20,3), /* số M vào */
Dauvaokg			Decimal(20,3), /* số Kg vào */

Thoigianbatdau		DATETIME,
Thoigianketthuc		DATETIME,
Thoigianchuanbi		Decimal(20,3),
Thoigianlenhacuon	Decimal(20,3),
Thoigiancatdau		Decimal(20,3),
Thoigiansuco		Decimal(20,3),
--Giomaychay			Decimal(20,3),
--Tocdomaydinhmuc		Decimal(20,3),
--Tocdomaythucte		Decimal(20,3),

--Dmtui				Decimal(20,3),
Ketquatui			Decimal(20,3),
Phein				Decimal(20,3),
Pheghep				Decimal(20,3),
Phechia				Decimal(20,3),
Phebien				Decimal(20,3),
Phethoi				Decimal(20,3),
Phechinhmay			Decimal(20,3),
Phekhac				Decimal(20,3),
--Tytrongtui			Decimal(20,3),
--Sohinh				Decimal(20,3),
--SoluongM2			Decimal(20,3), /* số lượng m2 */
Kiemtra				Decimal(20,3),
Chatluongtui		Decimal(20,3),
Nangsuat			Decimal(20,3),
Tocdodinhmuc		Decimal(20,3),
Lydosuco			Nvarchar(MAX),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Ketquahoanthien_May_FK Foreign Key (Mamay) References Dmmay (Mamay) On Delete No Action On Update Cascade,
constraint Ketquahoanthien_PK primary key (Id)) ON [PRIMARY]


---------------Nghiệp vụ kho-------------------------
CREATE TABLE Sodusanpham(
Id					BigInt Identity Not null,
Ngaykiemke			DATE,
Makho				Nvarchar(50),
Tenkho				Nvarchar(250),
Masanpham			Nvarchar(50),
Tensanpham			Nvarchar(250),
Somet				Decimal(20,3),
Sokg				Decimal(20,3),
Soluong				Decimal(20,3),	--số lượng--
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
Somet				Decimal(20,3),
Sokg				Decimal(20,3),	--số lượng--
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
Soluong				Decimal(20,3),	--số lượng--
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
Soluong				Decimal(20,3),
Somet				Decimal(20,3),
Sokg				Decimal(20,3),
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
Somet				Decimal(20,3),
Sokg				Decimal(20,3),
Malydo				Nvarchar(50),
Tenlydo				Nvarchar(250),
Lenhsx				Nvarchar(50),
Sohopdongmua		Nvarchar(50),	--số hợp đồng mua--
Cuondo				Bit default 0,	--Cuộn màng dở
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
Soluong				Decimal(20,3),	--số lượng--
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
Soluong				Decimal(20,3),
Somet				Decimal(20,3),
Sokg				Decimal(20,3),
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
Somet				Decimal(20,3),
Sokg				Decimal(20,3),
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
Soluong				Decimal(20,3),	--số lượng--
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
Kichthuoc			Decimal(20,3),
Trongluong			Decimal(20,3),
Chiphinguyenlieutui	Decimal(20,3),
Chiphimucin			Decimal(20,3),
Chiphikeo			Decimal(20,3),
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
Kichthuoc			Decimal(20,3),
Trongluong			Decimal(20,3),
Chiphithoi			Decimal(20,3),
Chiphiin			Decimal(20,3),
Chiphiloc			Decimal(20,3),
Chiphighep			Decimal(20,3),
Chiphitua			Decimal(20,3),
Chiphichia			Decimal(20,3),
Chiphihoanthien		Decimal(20,3),
Chiphidonggoi		Decimal(20,3),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Chiphigiacong_PK primary key (Id)) ON [PRIMARY]

/* Chi phí chung */

/* Công suất nhà máy */
CREATE TABLE Congsuatnhamay(
Thang				DATE,
Congsuatdukien		Decimal(20,3),
Congsuatthucte		Decimal(20,3),
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
Kichthuoc			Decimal(20,3),
Trongluong			Decimal(20,3),
Congsuatthoi		Decimal(20,3),
Congsuatin			Decimal(20,3),
Congsuatloc			Decimal(20,3),
Congsuatchia		Decimal(20,3),
Congsuathoanthien	Decimal(20,3),
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
Kichthuoc			Decimal(20,3),
Trongluong			Decimal(20,3),
Hieusuatthoi		Decimal(20,3),
Hieusuatin			Decimal(20,3),
Hieusuatghep		Decimal(20,3),
Hieusuatloc			Decimal(20,3),
Hieusuatchia		Decimal(20,3),
Hieusuathoanthien	Decimal(20,3),
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
Kichthuoc			Decimal(20,3),
Trongluong			Decimal(20,3),
Sanluongthoi		Decimal(20,3),
Sanluongin			Decimal(20,3),
Sanluongghep		Decimal(20,3),
Sanluongloc			Decimal(20,3),
Sanluongchia		Decimal(20,3),
Sanluonghoanthien	Decimal(20,3),
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
Tongchiphi			Decimal(20,3),
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
Kichthuoc			Decimal(20,3),
Trongluong			Decimal(20,3),
Machiphi			Nvarchar(50),
Chiphitheotui		Decimal(20,3),	--Chi phí theo túi--
Chiphitheokg		Decimal(20,3),
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
Kichthuoc			Decimal(20,3),
Trongluong			Decimal(20,3),
Chiphinguyenlieutui	Decimal(20,3),	--Chi phí nguyên liệu túi--
Chiphigiacongtui	Decimal(20,3),	--Chi phí gia công túi--
Chiphichungtui		Decimal(20,3),	
Giavontui			Decimal(20,3),
Giavonkg			Decimal(20,3),
Tyleloinhuan		Decimal(20,3),
Loinhuantui			Decimal(20,3),	--Lợi nhuận túi--
Loinhuankg			Decimal(20,3),
Giabantui			Decimal(20,3),	--Giá bán túi--
Giabankg			Decimal(20,3),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Giavonhangban_PK primary key (Id)) ON [PRIMARY]