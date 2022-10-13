using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GD.BBPH.BLL;
using GD.BBPH.DAL;
using GD.BBPH.DAL.EntityClasses;
using GD.BBPH.DAL.FactoryClasses;
using GD.BBPH.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Data;
namespace GD.BBPH.APP.LIB
{
    class SESSION_START
    {
        public static string TS_USER_LOGIN;

        private static string _ConnectionStringKeyName = "";
        public static string ConnectionStringKeyName
        {
            get
            {
                _ConnectionStringKeyName = System.Configuration.ConfigurationManager.AppSettings.Get(DAL.DatabaseSpecific.DataAccessAdapter.ConnectionStringKeyName);
                return _ConnectionStringKeyName;
            }
            set { _ConnectionStringKeyName = value; }
        }

        #region NGAYLAMVIEC
        private static DateTime _TS_NGAYLAMVIEC = DateTime.Now;
        public static DateTime TS_NGAYLAMVIEC
        {
            get
            {
                return _TS_NGAYLAMVIEC;
            }
            set { _TS_NGAYLAMVIEC = value; }
        }
        #endregion
        #region NGAYDAUTHANG
        private static DateTime _TS_NGAYDAUTHANG = DateTime.Now; 
        public static DateTime TS_NGAYDAUTHANG
        {
            get
            {
                return _TS_NGAYDAUTHANG;
            }
            set { _TS_NGAYDAUTHANG = value; }
        }
        #endregion
        #region NGAYCUOITHANG
        private static DateTime _TS_NGAYCUOITHANG = DateTime.Now;
        public static DateTime TS_NGAYCUOITHANG
        {
            get
            {
                return _TS_NGAYCUOITHANG;
            }
            set { _TS_NGAYCUOITHANG = value; }
        }
        #endregion
        #region NGAYDAUNAM
        private static DateTime _TS_NGAYDAUNAM = DateTime.Now;
        public static DateTime TS_NGAYDAUNAM
        {
            get
            {
                return _TS_NGAYDAUNAM;
            }
            set { _TS_NGAYDAUNAM = value; }
        }
        #endregion
        #region NGAYCUOINAM
        private static DateTime _TS_NGAYCUOINAM = DateTime.Now;
        public static DateTime TS_NGAYCUOINAM
        {
            get
            {
                return _TS_NGAYCUOINAM;
            }
            set { _TS_NGAYCUOINAM = value; }
        }
        #endregion
        #region NGAYDAUQUY
        private static DateTime _TS_NGAYDAUQUY = DateTime.Now;
        public static DateTime TS_NGAYDAUQUY
        {
            get
            {
                return _TS_NGAYDAUQUY;
            }
            set { _TS_NGAYDAUQUY = value; }
        }
        #endregion
        #region NGAYCUOIQUY
        private static DateTime _TS_NGAYCUOIQUY = DateTime.Now;
        public static DateTime TS_NGAYCUOIQUY
        {
            get
            {
                return _TS_NGAYCUOIQUY;
            }
            set { _TS_NGAYCUOIQUY = value; }
        }
        #endregion

        //#region GIOLAMVIEC
        //private static Decimal _TS_GIOLAMVIEC = Convert.ToDecimal(Procedures.Laygiatrithamso("Sogiolamviec"));
        //public static Decimal TS_GIOLAMVIEC
        //{
        //    get
        //    {
        //        return _TS_GIOLAMVIEC;
        //    }
        //    set { _TS_GIOLAMVIEC = value; }
        //}
        //#endregion
        //#region PHUTLAPKH
        //private static Decimal _TS_PHUTLAPKH = Convert.ToDecimal(Procedures.Laygiatrithamso("Sophutlapkh"));
        //public static Decimal TS_PHUTLAPKH
        //{
        //    get
        //    {
        //        return _TS_PHUTLAPKH;
        //    }
        //    set { _TS_PHUTLAPKH = value; }
        //}
        //#endregion

        #region USER
        private static DataTable _DT_USER = null;
        public static DataTable DM_USER
        {
            get
            {
                _DT_USER = new UsersManager().SelectAllRDT();
                return _DT_USER;
            }
            set { _DT_USER = value; }
        }
        #endregion
        #region MENU
        private static DataTable _DT_MENU = null;
        public static DataTable DM_MENU
        {
            get
            {
                _DT_MENU = new MenuManager().SelectAllRDT();
                return _DT_MENU;
            }
            set { _DT_MENU = value; }
        }
        #endregion
        #region DTROLES
        private static DataTable _DT_ROLES = null;
        public static DataTable DT_ROLES
        {
            get
            {
                _DT_ROLES = new RolesManager().SelectAllRDT();
                return _DT_ROLES;
            }
            set { _DT_ROLES = value; }
        }
        #endregion
        #region DTROLE
        // quản lý nhóm quyền
        private static DataTable _DT_ROLE = null;
        public static DataTable DT_ROLE
        {
            get
            {
                _DT_ROLE = new RolesManager().SelectAllRDT();
                return _DT_ROLE;
            }
            set { _DT_ROLE = value; }
        }
        #endregion

        //#region THAMSO
        //private static DataTable _DT_THAMSO = null;
        //public static DataTable DT_THAMSO
        //{
        //    get
        //    {
        //        _DT_THAMSO = new ThamsoManager().SelectAllRDT();
        //        return _DT_THAMSO;
        //    }
        //    set { _DT_THAMSO = value; }
        //}
        //#endregion

        #region DT_DMKHACH
        private static DataTable _DT_DMKHACH = null;
        public static DataTable DT_DMKHACH
        {
            get
            {
                _DT_DMKHACH = new DmkhachManager().SelectAllRDT();
                return _DT_DMKHACH;
            }
            set { _DT_DMKHACH = value; }
        }
        #endregion
        #region DT_DMBOPHAN
        private static DataTable _DT_DMBOPHAN = null;
        public static DataTable DT_DMBOPHAN
        {
            get
            {
                _DT_DMBOPHAN = new DmbophanManager().SelectAllRDT();
                return _DT_DMBOPHAN;
            }
            set { _DT_DMBOPHAN = value; }
        }
        #endregion
        #region DT_DMDONGMAY
        private static DataTable _DT_DMDONGMAY = null;
        public static DataTable DT_DMDONGMAY
        {
            get
            {
                _DT_DMDONGMAY = new DmdongmayManager().SelectAllRDT();
                return _DT_DMDONGMAY;
            }
            set { _DT_DMDONGMAY = value; }
        }
        #endregion
        #region DT_DMMAY
        private static DataTable _DT_DMMAY = null;
        public static DataTable DT_DMMAY
        {
            get
            {
                _DT_DMMAY = new DmmayManager().SelectAllRDT();
                return _DT_DMMAY;
            }
            set { _DT_DMMAY = value; }
        }
        #endregion
        #region DMCONGDOAN
        private static DataTable _DT_DMCONGDOAN = null;
        public static DataTable DT_DMCONGDOAN
        {
            get
            {
                _DT_DMCONGDOAN = new DmcongdoanManager().SelectAllRDT();
                return _DT_DMCONGDOAN;
            }
            set { _DT_DMCONGDOAN = value; }
        }
        #endregion
        #region DT_DMMANG
        private static DataTable _DT_DMMANG = null;
        public static DataTable DT_DMMANG
        {
            get
            {
                _DT_DMMANG = new DmmangManager().SelectAllRDT();
                return _DT_DMMANG;
            }
            set { _DT_DMMANG = value; }
        }
        #endregion

        #region DMNHOMQUYCACH
        private static DataTable _DT_DMNHOMQUYCACH = null;
        public static DataTable DT_DMNHOMQUYCACH
        {
            get
            {
                _DT_DMNHOMQUYCACH = new DmnhomquycachManager().SelectAllRDT();
                return _DT_DMNHOMQUYCACH;
            }
            set { _DT_DMNHOMQUYCACH = value; }
        }
        #endregion
        #region DMQUYCACH
        private static DataTable _DT_DMQUYCACH = null;
        public static DataTable DT_DMQUYCACH
        {
            get
            {
                _DT_DMQUYCACH = new DmquycachManager().SelectAllRDT();
                return _DT_DMQUYCACH;
            }
            set { _DT_DMQUYCACH = value; }
        }
        #endregion

        #region DMKHO
        private static DataTable _DT_DMKHO = null;
        public static DataTable DT_DMKHO
        {
            get
            {
                _DT_DMKHO = new DmkhoManager().SelectAllRDT();
                return _DT_DMKHO;
            }
            set { _DT_DMKHO = value; }
        }
        #endregion
        #region DMLYDONHAPXUAT
        private static DataTable _DT_DMLYDONHAPXUAT = null;
        public static DataTable DT_DMLYDONHAPXUAT
        {
            get
            {
                _DT_DMLYDONHAPXUAT = new DmlydonhapxuatManager().SelectAllRDT();
                return _DT_DMLYDONHAPXUAT;
            }
            set { _DT_DMLYDONHAPXUAT = value; }
        }
        #endregion

        #region DMCONGNHAN
        private static DataTable _DT_DMCONGNHAN = null;
        public static DataTable DT_DMCONGNHAN
        {
            get
            {
                _DT_DMCONGNHAN = new DmcongnhanManager().SelectAllRDT();
                return _DT_DMCONGNHAN;
            }
            set { _DT_DMCONGNHAN = value; }
        }
        #endregion

        #region CTPTMANG_H
        private static DataTable _DT_CTPTMANG_H = null;
        public static DataTable DT_CTPTMANG_H
        {
            get
            {
                _DT_CTPTMANG_H = new CtptmangHManager().SelectAllRDT();
                return _DT_CTPTMANG_H;
            }
            set { _DT_CTPTMANG_H = value; }
        }
        #endregion
        #region CTPTMANG_D
        private static DataTable _DT_CTPTMANG_D = null;
        public static DataTable DT_CTPTMANG_D
        {
            get
            {
                _DT_CTPTMANG_D = new CtptmangDManager().SelectAllRDT();
                return _DT_CTPTMANG_D;
            }
            set { _DT_CTPTMANG_D = value; }
        }
        #endregion

        #region DMMAU
        private static DataTable _DT_DMMAU = null;
        public static DataTable DT_DMMAU
        {
            get
            {
                _DT_DMMAU = new DmmauManager().SelectAllRDT();
                return _DT_DMMAU;
            }
            set { _DT_DMMAU = value; }
        }
        #endregion
        #region TPMAU
        private static DataTable _DT_TPMAU = null;
        public static DataTable DT_TPMAU
        {
            get
            {
                _DT_TPMAU = new ThanhphanmauManager().SelectAllRDT();
                return _DT_TPMAU;
            }
            set { _DT_TPMAU = value; }
        }
        #endregion

        #region HANG
        private static DataTable _DT_HANG = null;
        public static DataTable DM_HANG
        {
            get
            {
                _DT_HANG = new DmhangManager().SelectAllRDT();
                return _DT_HANG;
            }
            set { _DT_HANG = value; }
        }
        #endregion

        #region DT_DMNHOMNGUYENLIEU
        private static DataTable _DT_DMNHOMNGUYENLIEU = null;
        public static DataTable DT_DMNHOMNGUYENLIEU
        {
            get
            {
                _DT_DMNHOMNGUYENLIEU = new DmnhomnguyenlieuManager().SelectAllRDT();
                return _DT_DMNHOMNGUYENLIEU;
            }
            set { _DT_DMNHOMNGUYENLIEU = value; }
        }
        #endregion
        #region DT_DMNGUYENLIEU
        private static DataTable _DT_DMNGUYENLIEU = null;
        public static DataTable DT_DMNGUYENLIEU
        {
            get
            {
                _DT_DMNGUYENLIEU = new DmnguyenlieuManager().SelectAllRDT();
                return _DT_DMNGUYENLIEU;
            }
            set { _DT_DMNGUYENLIEU = value; }
        }
        #endregion

        #region DT_DMCHUCVU
        private static DataTable _DT_DMCHUCVU = null;
        public static DataTable DT_DMCHUCVU
        {
            get
            {
                _DT_DMCHUCVU = new DmchucvuManager().SelectAllRDT();
                return _DT_DMCHUCVU;
            }
            set { _DT_DMCHUCVU = value; }
        }
        #endregion

        #region DONHANG_H
        private static DataTable _DT_DONHANG_H = null;
        public static DataTable DT_DONHANG_H
        {
            get
            {
                _DT_DONHANG_H = new DonhangHManager().SelectAllRDT();
                return _DT_DONHANG_H;
            }
            set { _DT_DONHANG_H = value; }
        }
        #endregion
        #region DONHANG_D
        private static DataTable _DT_DONHANG_D = null;
        public static DataTable DT_DONHANG_D
        {
            get
            {
                _DT_DONHANG_D = new DonhangDManager().SelectAllRDT();
                return _DT_DONHANG_D;
            }
            set { _DT_DONHANG_D = value; }
        }
        #endregion

        #region PHIEUGIAOHANG_H
        private static DataTable _DT_PHIEUGIAOHANG_H = null;
        public static DataTable DT_PHIEUGIAOHANG_H
        {
            get
            {
                _DT_PHIEUGIAOHANG_H = new PhieugiaohangHManager().SelectAllRDT();
                return _DT_PHIEUGIAOHANG_H;
            }
            set { _DT_PHIEUGIAOHANG_H = value; }
        }
        #endregion
        #region PHIEUGIAOHANG_D
        private static DataTable _DT_PHIEUGIAOHANG_D = null;
        public static DataTable DT_PHIEUGIAOHANG_D
        {
            get
            {
                _DT_PHIEUGIAOHANG_D = new PhieugiaohangHManager().SelectAllRDT();
                return _DT_PHIEUGIAOHANG_D;
            }
            set { _DT_PHIEUGIAOHANG_D = value; }
        }
        #endregion

        #region KQTHOI
        private static DataTable _DT_KQTHOI = null;
        public static DataTable DT_KQTHOI
        {
            get
            {
                _DT_KQTHOI = new KetquathoiManager().SelectAllRDT();
                return _DT_KQTHOI;
            }
            set { _DT_KQTHOI = value; }
        }
        #endregion

        #region KQIN
        private static DataTable _DT_KQIN = null;
        public static DataTable DT_KQIN
        {
            get
            {
                _DT_KQIN = new KetquainManager().SelectAllRDT();
                return _DT_KQIN;
            }
            set { _DT_KQIN = value; }
        }
        #endregion
        #region HANGTRALAI
        private static DataTable _DT_HANGTRALAI = null;
        public static DataTable DT_HANGTRALAI
        {
            get
            {
                _DT_HANGTRALAI = new HangtralaiManager().SelectAllRDT();
                return _DT_HANGTRALAI;
            }
            set { _DT_HANGTRALAI = value; }
        }
        #endregion

        #region Thổi
        #region TKNLTHOI
        private static DataTable _DT_TKNLTHOI = null;
        public static DataTable DT_TKNLTHOI
        {
            get
            {
                _DT_TKNLTHOI = new TknguyenlieuthoiManager().SelectAllRDT();
                return _DT_TKNLTHOI;
            }
            set { _DT_TKNLTHOI = value; }
        }
        #endregion

        #endregion

        #region Kho

        #region NHAPSANPHAM
        private static DataTable _DT_NHAPSANPHAM = null;
        public static DataTable DT_NHAPSANPHAM
        {
            get
            {
                _DT_NHAPSANPHAM = new NhapkhosanphamManager().SelectAllRDT();
                return _DT_NHAPSANPHAM;
            }
            set { _DT_NHAPSANPHAM = value; }
        }
        #endregion

        #region XUATSANPHAM
        private static DataTable _DT_XUATSANPHAM = null;
        public static DataTable DT_XUATSANPHAM
        {
            get
            {
                _DT_XUATSANPHAM = new XuatkhosanphamManager().SelectAllRDT();
                return _DT_XUATSANPHAM;
            }
            set { _DT_XUATSANPHAM = value; }
        }
        #endregion

        #region NHAPMANG
        private static DataTable _DT_NHAPMANG = null;
        public static DataTable DT_NHAPMANG
        {
            get
            {
                _DT_NHAPMANG = new NhapkhomangManager().SelectAllRDT();
                return _DT_NHAPMANG;
            }
            set { _DT_NHAPMANG = value; }
        }
        #endregion

        #endregion

    }
}
