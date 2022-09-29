using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using GD.BBPH.BLL;
//using GD.BBPH.DAL;
//using GD.BBPH.DAL.EntityClasses;
//using GD.BBPH.DAL.FactoryClasses;
//using GD.BBPH.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Microsoft.Win32;
using System.Data;
namespace GD.BBPH.DATA
{ 
    public class START
    {        
        public static void START_SESSION()
        {
        }
        //public static void START_SESSION_DMDONVI(string Madonvi)
        //{
        //    GD.BBPH.DATA.DMDONVI._Current = (new DmdonviManagerBase()).SelectOne(Madonvi);
        //    GD.BBPH.DATA.DMDONVI._Current_dt = (new DmdonviManagerBase()).SelectByMadonviRDT(Madonvi);
        //    if (GD.BBPH.DATA.DMDONVI._Current.Madonvicha == "0000") { GD.BBPH.DATA.DMDONVI.DV_TH = true; }
        //    DataTable DT_THONG_TIN_HT = new DataTable(); //GD.BBPH.DATA.SESSION_START.THONGTINHETHONG;
        //    for (int i = 0; i < DT_THONG_TIN_HT.Rows.Count; i++)
        //    {
        //        DataRow r = DT_THONG_TIN_HT.Rows[i];
        //        ThongtinhethongEntity _ThongtinhethongEntity = (new ThongtinhethongManagerBase()).Convert(r);
        //        if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_THAPPHAN_Tenma)
        //        {
        //            GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_THAPPHAN_VALUE = _ThongtinhethongEntity.Giatri;
        //            GD.BBPH.CONTROL.TEXTBOXNUMBER.chuoithapphan = GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_THAPPHAN_VALUE;
        //            WritRegistryKey("Control Panel\\International", "sDecimal", GD.BBPH.CONTROL.TEXTBOXNUMBER.chuoithapphan, RegistryValueKind.ExpandString);//dau thap phan
        //        }
        //        else if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_Tenma)
        //        {
        //            string s = _ThongtinhethongEntity.Giatri;
        //            if (s.ToString().Equals("[ ]"))
        //            {
        //                s = " ";
        //            }
        //            GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE = s;
        //            GD.BBPH.CONTROL.TEXTBOXNUMBER.sperator = GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE;
        //            WritRegistryKey("Control Panel\\International", "sThousand", GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE, RegistryValueKind.ExpandString);//dau phan cach
        //        }
        //        else if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.THAMSO_SO_AM_TREN_BAO_CAO_Tenma)
        //        {
        //            GD.BBPH.LIB.STATIC_PARAM.THAMSO_SO_AM_TREN_BAO_CAO_VALUE = _ThongtinhethongEntity.Giatri;
        //            GD.BBPH.CONTROL.TEXTBOXNUMBER.soambaocao = GD.BBPH.LIB.STATIC_PARAM.THAMSO_SO_AM_TREN_BAO_CAO_VALUE;
        //            WritRegistryKey("Control Panel\\International", "sNegativeSign", GD.BBPH.CONTROL.TEXTBOXNUMBER.soambaocao, RegistryValueKind.ExpandString);
        //        }
        //        else if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.THAMSO_SO_GIA_TRI_THAP_PHAN_Tenma)
        //        {
        //            GD.BBPH.LIB.STATIC_PARAM.THAMSO_GIA_TRI_THAP_PHAN_VALUE = int.Parse(_ThongtinhethongEntity.Giatri);
        //            GD.BBPH.CONTROL.TEXTBOXNUMBER.giatrithapphan = GD.BBPH.LIB.STATIC_PARAM.THAMSO_GIA_TRI_THAP_PHAN_VALUE;
        //            WritRegistryKey("Control Panel\\International", "iDigits", GD.BBPH.CONTROL.TEXTBOXNUMBER.giatrithapphan, RegistryValueKind.ExpandString);//No. of digit sau dau thap phan
        //        }
        //        else if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.DUYETCHUNGTU_TEN)
        //        {
        //            GD.BBPH.LIB.STATIC_PARAM.DUYETCHUNGTU_VALUE = int.Parse(_ThongtinhethongEntity.Giatri);
        //        }
        //        else if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.XUATHANGAM_TEN)
        //        {
        //            GD.BBPH.LIB.STATIC_PARAM.XUATHANGAM_VALUE = int.Parse(_ThongtinhethongEntity.Giatri);
        //        }
        //        else if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.THEODOIKHACHHANG_TEN)
        //        {
        //            GD.BBPH.LIB.STATIC_PARAM.THEODOIKHACHHANG_VALUE = int.Parse(_ThongtinhethongEntity.Giatri);
        //        }
        //        else if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.GIOIHAN_CONGNO_TEN)
        //        {
        //            GD.BBPH.LIB.STATIC_PARAM.GIOIHAN_CONGNO_VALUE = int.Parse(_ThongtinhethongEntity.Giatri);
        //        }
        //        else if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.GIOIHAN_CONGNONV_TEN)
        //        {
        //            GD.BBPH.LIB.STATIC_PARAM.GIOIHAN_CONGNONV_VALUE = int.Parse(_ThongtinhethongEntity.Giatri);
        //        }
        //        else if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.THEODOI_CONGNO_NV_TEN)
        //        {
        //            GD.BBPH.LIB.STATIC_PARAM.THEODOI_CONGNO_NV_VALUE = int.Parse(_ThongtinhethongEntity.Giatri);
        //        }
        //        else if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.THUQUYTHU_TEN)
        //        {
        //            GD.BBPH.LIB.STATIC_PARAM.THUQUYTHU_VALUE = _ThongtinhethongEntity.Giatri;
        //        }
        //        else if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.THUQUYCHI_TEN)
        //        {
        //            GD.BBPH.LIB.STATIC_PARAM.THUQUYCHI_VALUE = _ThongtinhethongEntity.Giatri;
        //        }
        //        else if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.FTP_URL_HOMEMART_TEN)
        //        {
        //            GD.BBPH.LIB.STATIC_PARAM.FTP_URL_HOMEMART_VALUE = _ThongtinhethongEntity.Giatri;
        //        }
        //        else if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.FTP_SERVER_TEN)
        //        {
        //            GD.BBPH.LIB.STATIC_PARAM.FTP_SERVER_VALUE = _ThongtinhethongEntity.Giatri;
        //        }
        //        else if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.FTP_USER_TEN)
        //        {
        //            GD.BBPH.LIB.STATIC_PARAM.FTP_USER_VALUE = _ThongtinhethongEntity.Giatri;
        //        }
        //        else if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.FTP_PASS_TEN)
        //        {
        //            GD.BBPH.LIB.STATIC_PARAM.FTP_PASS_VALUE = _ThongtinhethongEntity.Giatri;
        //        }
        //        else if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.GIATHANH_TEN)
        //        {
        //            GD.BBPH.LIB.STATIC_PARAM.GIATHANH_VALUE = _ThongtinhethongEntity.Giatri;
        //        }
        //        else if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.XUATKHO_KM)
        //        {
        //            GD.BBPH.LIB.STATIC_PARAM.XUATKHO_KM_VALUE = int.Parse(_ThongtinhethongEntity.Giatri);
        //        }
        //    }
        //    string NUMBER_FORMAT = "#"+ GD.BBPH.CONTROL.TEXTBOXNUMBER.sperator+"##0";
        //    if (GD.BBPH.CONTROL.TEXTBOXNUMBER.giatrithapphan > 0)
        //    {
        //        for (int k = 0; k < GD.BBPH.CONTROL.TEXTBOXNUMBER.giatrithapphan; k++)
        //        {
        //            if (k == 0) NUMBER_FORMAT = NUMBER_FORMAT + GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_THAPPHAN_VALUE + "0";
        //            else NUMBER_FORMAT = NUMBER_FORMAT + "0";
        //        }
        //        GD.BBPH.CONTROL.TEXTBOXNUMBER.NUMBER_FORMAR = GD.BBPH.CONTROL.TEXTBOXNUMBER.NUMBER_FORMAR_PERCENT = NUMBER_FORMAT;
        //    }
        //    else
        //    {
        //        GD.BBPH.CONTROL.TEXTBOXNUMBER.NUMBER_FORMAR_PERCENT = NUMBER_FORMAT + GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_THAPPHAN_VALUE + "0";
        //    }
            
           

        //    WritRegistryKey("Control Panel\\International", "sShortDate", "dd/MM/yyyy", RegistryValueKind.ExpandString);
        //    #region
        //    string ERP_CONFIG = GD.BBPH.LIB.PATH.ERP_DATA + "ERP_CONFIG.xml";
        //    DataTable dt = TBNet.Project.IO.ReadXMLTOW(ERP_CONFIG);
        //    if (dt.Rows.Count == 0) return;
        //    if (string.IsNullOrEmpty(dt.Rows[0]["SERVER_SQL"].ToString())==false) GD.BBPH.LIB.STATIC_PARAM.MART_SYNC_ERP = "1";
        //    // BINH DA CAP NHAT O LAP STARTSESSION

        //    //GD.BBPH.DATA.SESSION_START.DT_DMCTUDV = (new DmctudvManager()).SelectByIssudungRDT(GD.BBPH.LIB.STATIC_PARAM.Trangthai_Sudung);
        //    //GD.BBPH.DATA.SESSION_START.DT_DMTYGIA = (new DmtygiaManager()).SelectByIssudungRDT(GD.BBPH.LIB.STATIC_PARAM.Trangthai_Sudung);
        //    //GD.BBPH.DATA.SESSION_START.DMKHACHHANG_ALL=(new DmkhachhangManager()).SelectByMadonviRDT(GD.BBPH.DATA.DMDONVI._Current.Madonvi);
        //    //GD.BBPH.DATA.SESSION_START.THONGTINHETHONG = (new ThongtinhethongManager()).SelectByMadonviRDT(GD.BBPH.DATA.DMDONVI._Current.Madonvi);
        //    //GD.BBPH.DATA.SESSION_START.MENUFROMNEMCONTRO = TBNet.Project.IO.ReadXMLTOW(GD.BBPH.LIB.PATH.ERP_PATH + @"\XMLCONFIG\MENUFROMNEMCONTRO.xml");
        //    //GD.BBPH.DATA.SESSION_START.DT_MENU=(new MenuManager()).SelectByMadonviRDT(GD.BBPH.DATA.DMDONVI._Current.Madonvi);
        //    //EntityCollection _Collection = (new ThongtinhethongManagerBase()).SelectByMadonvi(Madonvi);
        //    //for (int i = 0; i < _Collection.Items.Count; i++)
        //    //{
        //    //    ThongtinhethongEntity _ThongtinhethongEntity = (ThongtinhethongEntity)_Collection[i];
        //    //    if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_THAPPHAN_Tenma)
        //    //    {
        //    //        GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_THAPPHAN_VALUE = _ThongtinhethongEntity.Giatri;
        //    //        GD.BBPH.CONTROL.TEXTBOXNUMBER.chuoithapphan = GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_THAPPHAN_VALUE;
        //    //        WritRegistryKey("Control Panel\\International", "sDecimal", GD.BBPH.CONTROL.TEXTBOXNUMBER.chuoithapphan, RegistryValueKind.ExpandString);//dau thap phan
        //    //    }
        //    //    if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_Tenma)
        //    //    {
        //    //        string s = _ThongtinhethongEntity.Giatri;
        //    //        if (s.ToString().Equals("[ ]"))
        //    //        {
        //    //            s = " ";
        //    //        }
        //    //        GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE = s;
        //    //        GD.BBPH.CONTROL.TEXTBOXNUMBER.sperator = GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE;
        //    //        WritRegistryKey("Control Panel\\International", "sThousand", GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE, RegistryValueKind.ExpandString);//dau phan cach
        //    //    }
        //    //    if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.THAMSO_SO_AM_TREN_BAO_CAO_Tenma)
        //    //    {
        //    //        GD.BBPH.LIB.STATIC_PARAM.THAMSO_SO_AM_TREN_BAO_CAO_VALUE = _ThongtinhethongEntity.Giatri;
        //    //        GD.BBPH.CONTROL.TEXTBOXNUMBER.soambaocao = GD.BBPH.LIB.STATIC_PARAM.THAMSO_SO_AM_TREN_BAO_CAO_VALUE;
        //    //        WritRegistryKey("Control Panel\\International", "sNegativeSign", GD.BBPH.CONTROL.TEXTBOXNUMBER.soambaocao , RegistryValueKind.ExpandString);
        //    //    }
        //    //    if (_ThongtinhethongEntity.Tenma == GD.BBPH.LIB.STATIC_PARAM.THAMSO_SO_GIA_TRI_THAP_PHAN_Tenma)
        //    //    {
        //    //        GD.BBPH.LIB.STATIC_PARAM.THAMSO_GIA_TRI_THAP_PHAN_VALUE = int.Parse(_ThongtinhethongEntity.Giatri);
        //    //        GD.BBPH.CONTROL.TEXTBOXNUMBER.giatrithapphan = GD.BBPH.LIB.STATIC_PARAM.THAMSO_GIA_TRI_THAP_PHAN_VALUE;
        //    //        WritRegistryKey("Control Panel\\International", "iDigits", GD.BBPH.CONTROL.TEXTBOXNUMBER.giatrithapphan, RegistryValueKind.ExpandString);//No. of digit sau dau thap phan
        //    //    }
        //    //}

        //    //WritRegistryKey("Control Panel\\International", "sNegativeSign", GD.BBPH.CONTROL.TEXTBOXNUMBER.soambaocao , RegistryValueKind.ExpandString); //so am
        //    //WritRegistryKey("Control Panel\\International", "sList", GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE, RegistryValueKind.ExpandString); //phan tach nhom
        //    //WritRegistryKey("Control Panel\\International", "sDate", "/", RegistryValueKind.ExpandString); //phan tach ngay thang
        //    //WritRegistryKey("Control Panel\\International", "sShortDate", "dd/MM/yyyy", RegistryValueKind.ExpandString); //dang ngay thang  
        //    //WritRegistryKey("Control Panel\\International", "sTime", ":", RegistryValueKind.ExpandString); //phan tach gio phut  
        //    //WritRegistryKey("Control Panel\\International", "sTimeFormat", "h:mms tt", RegistryValueKind.ExpandString); //dang thoi gian  
        //    ////string sDecimal = GetRegistryKey("Control Panel\\International", "sDecimal");
        //    ////string sThousand = GetRegistryKey("Control Panel\\International", "sThousand");
        //    ////if (sDecimal != GD.BBPH.CONTROL.TEXTBOXNUMBER.chuoithapphan || sThousand != GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE)
        //    ////{
        //    //    WritRegistryKey("Control Panel\\International", "sDecimal", GD.BBPH.CONTROL.TEXTBOXNUMBER.chuoithapphan, RegistryValueKind.ExpandString);
        //    //    WritRegistryKey("Control Panel\\International", "sThousand", GD.BBPH.LIB.STATIC_PARAM.THAMSO_KY_TU_PHANCACH_VALUE, RegistryValueKind.ExpandString);
        //    ////}
        //    #endregion
        //}
        public static bool WritRegistryKey(string subKey, string KeyName, object Value, RegistryValueKind RegistryValueKind_)
        {
            try
            {
                RegistryKey sk1 = Registry.CurrentUser.CreateSubKey(subKey);
                // Save the value
                sk1.SetValue(KeyName, Value, RegistryValueKind_);
                sk1.Close();
                return true;
            }
            catch { }
            return false;
        }
        public static string GetRegistryKey(string subKey, string KeyName)
        {
            try
            {
                RegistryKey sk1 = Registry.CurrentUser.OpenSubKey(subKey);
                if (sk1 == null) return "";
                // Save the value
                return (string)sk1.GetValue(KeyName);
            }
            catch { }
            return "";
        }
    }
}
