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
        #region PHUTLAPKH
        private static Decimal _TS_PHUTLAPKH = Convert.ToDecimal(Procedures.Laygiatrithamso("Sophutlapkh"));
        public static Decimal TS_PHUTLAPKH
        {
            get
            {
                return _TS_PHUTLAPKH;
            }
            set { _TS_PHUTLAPKH = value; }
        }
        #endregion

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



        #region DT_DMNGUYENLIEU
        private static DataTable _DT_DMNGUYENLIEU = null;
        public static DataTable DT_DMNGUYENLIEU
        {
            get
            {
                _DT_DMNGUYENLIEU = LIB.Procedures.Danhsachnguyenlieu(string.Empty, string.Empty, LIB.SESSION_START.TS_NGAYCUOITHANG); //new DmnguyenlieuManager().SelectAllRDT();
                return _DT_DMNGUYENLIEU;
            }
            set { _DT_DMNGUYENLIEU = value; }
        }
        #endregion

    }
}
