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

    }
}
