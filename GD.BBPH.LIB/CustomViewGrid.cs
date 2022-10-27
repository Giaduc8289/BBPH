using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Xml;
using System.Drawing;
using Janus.Data;
using Janus.Windows.GridEX;
using Janus.Windows.Common;

namespace GD.BBPH.LIB
{
    public class CustomViewGrid : ViewGridBase
    {
        //-----Danh sách các cột số nguyên
        private static string[] _colInt = {
            "Sotien", "Soluong", "Tongsoluong", "Gia", "Tien", "TienNsnn", "Dutoan", "DutoanNsnn", "Dutoanbosung", "DutoanbosungNsnn", "Dutoanhuy", "DutoanhuyNsnn"
                , "Dunoluongdau", "Ducoluongdau", "Dunodauky", "Ducodauky", "Luykenoluong", "Luykecoluong", "Luykeno", "Luykeco", "Luykenotukhoidau", "Luykecotukhoidau"
                , "DunoNsnn", "DucoNsnn", "LuykenoNsnn", "LuykecoNsnn", "Phatsinhno", "Phatsinhco", "Phatsinhnoluong", "Phatsinhcoluong", "PhatsinhnoNsnn", "PhatsinhcoNsnn"
                , "Thu", "Chi", "Tiennopthue", "Tienthanhtoandvh"
                , "Dorong", "Trongluong", "Congsuat", "Ca", "Lanha", "Sodau", "Socuoi", "Chieudai", "Luong", "Songaytruluisoi", "Songaytruluidet", "Trongluongphoi"
                , "TrongluongkhongPE", "Tongtrongluong", "Chieudaicat", "Khoiluongsoi", "Khoiluongmanh", "Soluong", "Trangthai", "Klsoihoanthanh"
                , "Klmanhhoanthanh", "Kldukien", "Tongnhucausoi", "Catrong", "Congsuattrong", "Chieudaixuat", "Khoiluongxuat", "Cong", "Congthaykho"
                , "Dongia", "Thanhtien", "Soluongconlai", "Khoiluongconlai", "Tongsonhapkho", "Tongsohieuchinh", "Soluonghieuchinh", "Soluongtinhluong"
                , "Soluongchuatinhluong", "Sometchuain", "Sosanpham1", "Sosanpham2", "Somet1", "Somet2", "Tientamung"
        };

        //-----Danh sách các cột số thập phân
        private static string[] _colDecimal = {
            "Tylehaomon", "Khoiluong", "Sokg", "Sokgdukien", "Doben", "Dodandai", "Khoiluongphe", "Tylephantram"
        };

        //-----Danh sách các cột ngày
        private static string[] _colDate = {
            "Ngaychungtu", "Ngayhachtoan", "Ngaydat", "Ngaygiao", "Ngaychay", "Ngay", "Ngayapdung", "Ngaymarket", "Ngayha", "Ngaynhap"
                , "Ngayhoanthanh", "Ngaycuoink", "Ngaytrang", "Ngayin1", "Ngayin2", "Ngayxuat", "Ngaykiemke", "Ngaydieuchuyen"
                , "Ngaybaogia", "Ngayhieuluc", "Ngayhoadon", "Ngayctkt"
        };

        public static DataTable RebindRotator(string path)
        {
            DataTable rotatorData = new DataTable();
            rotatorData.Columns.Add("FileName");
            rotatorData.Columns.Add("Attributes");
            rotatorData.Columns.Add("Length");
            rotatorData.Columns.Add("PathFileName");
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            try
            {
                FileInfo[] gf = dirInfo.GetFiles("*.*");
                if (gf.Length > 0)
                {
                    for (int i = 0; i < gf.Length; i++)
                    {//.gif,.jpg,.jpeg,.bmp                                                
                        if (gf[i].ToString().Split('.')[1].ToUpper() == "XML")
                        {
                            DataRow r = rotatorData.NewRow();
                            r["PathFileName"] = path + gf[i].ToString();
                            r["Attributes"] = gf[i].LastWriteTime.ToString();
                            r["Length"] = gf[i].Length.ToString();
                            r["FileName"] = gf[i].ToString().Split('.')[0];
                            rotatorData.Rows.Add(r);
                        }
                    }
                }
            }
            catch { };
            return rotatorData;
        }
        public static int numberday = 0;
        public static int Maxgiaban = 150;
        //public static string Numbersole_gianhap = "#,##0.0000";
        //public static string Numbersole_giaban_le = "#,##0";
        //public static string Numbersole_giaban_buon = "#,##0.0000";
        public static string Numbersole_ty_le = "#,##0.0";
        public static string Numbersole_vat = "#,##0.00";
        public static string Numbersole_triet_khau = "#,##0.00";
        //public static string Numbersole_gianhap = "#,##0.0000";
        //public static string Numbersole_gianhap
        //{
        //    get
        //    {
        //        string NUMBERSOLE_GIANHAP = "#,##0.00";
        //        ThamsohethongEntity _ThamsohethongEntity = (new ThamsohethongManager()).SelectOne(TBNet.Mart.Common.Staticparam.TEN_NUMBERSOLE_GIANHAP);
        //        if (_ThamsohethongEntity != null) NUMBERSOLE_GIANHAP = _ThamsohethongEntity.Giatri1;
        //        return NUMBERSOLE_GIANHAP;
        //    }
        //}

        ////public static string Numbersole_giaban_le = "#,##0";
        //public static string Numbersole_giaban_le
        //{
        //    get
        //    {
        //        string NUMBERSOLE_GIA_BAN_LE = "#,##0.00";
        //        ThamsohethongEntity _ThamsohethongEntity = (new ThamsohethongManager()).SelectOne(TBNet.Mart.Common.Staticparam.TEN_NUMBERSOLE_GIA_BAN_LE);
        //        if (_ThamsohethongEntity != null) NUMBERSOLE_GIA_BAN_LE = _ThamsohethongEntity.Giatri1;
        //        return NUMBERSOLE_GIA_BAN_LE;
        //    }
        //}

        //public static string Numbersole_giaban_buon = "#,##0.0000";
        //public static string Numbersole_giaban_buon
        //{
        //    get
        //    {
        //        string NUMBERSOLE_GIA_BAN_BUON = "#,##0.00";
        //        ThamsohethongEntity _ThamsohethongEntity = (new ThamsohethongManager()).SelectOne(TBNet.Mart.Common.Staticparam.TEN_NUMBERSOLE_GIA_BAN_BUON);
        //        if (_ThamsohethongEntity != null) NUMBERSOLE_GIA_BAN_BUON = _ThamsohethongEntity.Giatri1;
        //        return NUMBERSOLE_GIA_BAN_BUON;
        //    }
        //}

        //public static string TABLE_NAME
        //{
        //    get
        //    {
        //        return "Xnt_" + TBNet.Mart.SessionConfig.Ngayphatsinh.Year + "_" + TBNet.Mart.SessionConfig.Ngayphatsinh.Month + "_" + TBNet.Mart.SessionConfig.Ngayphatsinh.Day;
        //    }
        //}
        public static DataRow CheckData(string strparam, DataTable dt, string Fieldname)
        {
            DataTable dttemp = new DataTable();
            try
            {
                dttemp = dt.Select(Fieldname + " ='" + strparam + "'").CopyToDataTable();
            }
            catch { }
            if (dttemp.Rows.Count > 0)
            {
                return dttemp.Rows[0];
            }
            return null;
        }
        public static DataTable BuildviewgridJanus_UIPanel(string xmlfile, Janus.Windows.GridEX.GridEX _GridEX, Janus.Windows.UI.Dock.UIPanelInnerContainer _Panel)
        {
            DataTable dttemplate = IO.ReadXMLTOW(xmlfile);
            try
            {
                dttemplate = dttemplate.Select("value='1'").CopyToDataTable();
            }
            catch { }
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["name"].ToString() == "Ngayphatsinh" || dv[i]["name"].ToString() == "Ngaytao")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>dd/MM/yyyy</FormatString>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                               + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                               + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                               + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                                + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                               + "<FilterRowComparison>Contains</FilterRowComparison>"
                                               + "<Position>" + i + "</Position></Column" + i + ">";
                }

            }
            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            // _GridEXLayout.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection='true'>" +
            //"<Column0 ID='ID'><Caption>ID</Caption><DataMember>ID</DataMember><Key>ID</Key><Position>0</Position></Column0>"
            //+ "<Column1 ID='Name'><Caption>Name</Caption><DataMember>Name</DataMember><Key>Name</Key><Position>1</Position></Column1></Columns>"
            //+ "<GroupCondition ID='' /></RootTable></GridEXLayoutData>";

            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            _GridEX.Height = _Panel.Height;
            _GridEX.Width = _Panel.Width;
            _GridEX.RecordNavigator = true;
            //_GridEX.AllowAddNew = InheritableBoolean.False;
            //_GridEX.AllowEdit = InheritableBoolean.True;
            //_GridEX.AllowDelete = InheritableBoolean.False;
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.FilterRowButtonStyle = FilterRowButtonStyle.None;
            _GridEX.FilterMode = FilterMode.Automatic;
            _Panel.Controls.Add(_GridEX);
            return dttemplate;
        }

        public static DataTable BuildviewgridJanus(string xmlfile, Janus.Windows.GridEX.GridEX _GridEX, Janus.Windows.UI.Dock.UIPanelInnerContainer _Panel)
        {
            DataTable dttemplate = IO.ReadXMLTOW(xmlfile);
            try
            {
                dttemplate = dttemplate.Select("value='1'").CopyToDataTable();
            }
            catch { }
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["name"].ToString() == "Ngayphatsinh" || dv[i]["name"].ToString() == "Ngaytao")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>dd/MM/yyyy</FormatString>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                               + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                               + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                               + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                                + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                               + "<FilterRowComparison>Contains</FilterRowComparison>"
                                               + "<Position>" + i + "</Position></Column" + i + ">";
                }

            }
            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            // _GridEXLayout.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection='true'>" +
            //"<Column0 ID='ID'><Caption>ID</Caption><DataMember>ID</DataMember><Key>ID</Key><Position>0</Position></Column0>"
            //+ "<Column1 ID='Name'><Caption>Name</Caption><DataMember>Name</DataMember><Key>Name</Key><Position>1</Position></Column1></Columns>"
            //+ "<GroupCondition ID='' /></RootTable></GridEXLayoutData>";

            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            _GridEX.Height = _Panel.Height;
            _GridEX.Width = _Panel.Width;
            _GridEX.RecordNavigator = true;
            //_GridEX.AllowAddNew = InheritableBoolean.False;
            //_GridEX.AllowEdit = InheritableBoolean.True;
            //_GridEX.AllowDelete = InheritableBoolean.False;
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.FilterRowButtonStyle = FilterRowButtonStyle.None;
            _GridEX.FilterMode = FilterMode.Automatic;
            _Panel.Controls.Add(_GridEX);
            return dttemplate;
        }

        public static DataTable BuildviewgridJanus(string xmlfile, Janus.Windows.GridEX.GridEX _GridEX, TabPage _TabPage)
        {
            DataTable dttemplate = IO.ReadXMLTOW(xmlfile);

            try
            {
                dttemplate = dttemplate.Select("value='1'").CopyToDataTable();
            }
            catch { }
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["value"].ToString().Trim().Equals("1"))
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                               + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                               + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                               + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Position>" + i + "</Position></Column" + i + ">";
                }


            }
            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            // _GridEXLayout.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection='true'>" +
            //"<Column0 ID='ID'><Caption>ID</Caption><DataMember>ID</DataMember><Key>ID</Key><Position>0</Position></Column0>"
            //+ "<Column1 ID='Name'><Caption>Name</Caption><DataMember>Name</DataMember><Key>Name</Key><Position>1</Position></Column1></Columns>"
            //+ "<GroupCondition ID='' /></RootTable></GridEXLayoutData>";

            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            _GridEX.Height = _TabPage.Height;
            _GridEX.Width = _TabPage.Width;
            _GridEX.RecordNavigator = true;
            //_GridEX.AllowAddNew = InheritableBoolean.False;
            //_GridEX.AllowEdit = InheritableBoolean.True;
            //_GridEX.AllowDelete = InheritableBoolean.False;
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _TabPage.AutoScroll = true;
            _TabPage.Controls.Add(_GridEX);
            return dttemplate;
        }
        public static DataTable BuildviewgridJanus_C(string xmlfile, Janus.Windows.GridEX.GridEX _GridEX, System.Windows.Forms.Panel _Panel)
        {
            DataTable dttemplate = IO.ReadXMLTOW(xmlfile);
            try
            {
                dttemplate = dttemplate.Select("value='1'").CopyToDataTable();
            }
            catch { }
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            int i = 0;
            for (i = 0; i < dv.Count; i++)
            {
                if (dv[i]["value"].ToString() == "2")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>S</FormatString>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position><Visible>FALSE</Visible></Column" + i + ">";
                }
                if (dv[i]["name"].ToString().Trim().Equals("C"))
                {
                    CCollection = CCollection + "<Column" + 0 + " ID='C'>"
                                               + "<AllowGroup>" + "False" + "</AllowGroup>"
                                               + "<Caption>Chọn</Caption>"
                                               + "<ColumnType>" + "CheckBox" + "</ColumnType>"
                                               + "<Key>" + "Chon" + "</Key>"
                                               + "<Position>" + "0" + "</Position>"
                                               + "<Width>" + 20 + "</Width>"
                                               + "<ActAsSelector>" + "True" + "</ActAsSelector>"
                                               + "</Column" + 0 + ">";
                }
                if (Array.Exists(_colDate, gtri => gtri == dv[i]["name"].ToString()))
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>dd/MM/yyyy</FormatString>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                if (Array.Exists(_colInt, gtri => gtri == dv[i]["name"].ToString()))
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + STATIC_PARAM.FormatNumber_Grid + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                              + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else if (Array.Exists(_colDecimal, gtri => gtri == dv[i]["name"].ToString()))
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + "#,##0.00" + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                              + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else if (dv[i]["name"].ToString() == "Somet")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + "#,###" + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                              + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                               + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                               + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                               + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                                + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                               + "<FilterRowComparison>Contains</FilterRowComparison>"
                                               + "<Position>" + i + "</Position></Column" + i + ">";
                }


            }
            CCollection = CCollection + "<Column" + i + " ID='T'>"
                                        + "<Caption>Time</Caption>"
                                        + "<DataMember>Time</DataMember>"
                                        + "<Key>" + "T" + "</Key>"
                                        + "<FormatString>S</FormatString>"
                                        + "<Position>" + i + "</Position>"
                                        //+ "<Width>" + 150 + "</Width>"
                                        + "<Visible>FALSE</Visible>"
                                        + "</Column" + i + ">";

            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            // _GridEXLayout.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection='true'>" +
            //"<Column0 ID='ID'><Caption>ID</Caption><DataMember>ID</DataMember><Key>ID</Key><Position>0</Position></Column0>"
            //+ "<Column1 ID='Name'><Caption>Name</Caption><DataMember>Name</DataMember><Key>Name</Key><Position>1</Position></Column1></Columns>"
            //+ "<GroupCondition ID='' /></RootTable></GridEXLayoutData>";

            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            _GridEX.Height = _Panel.Height;
            _GridEX.Width = _Panel.Width;
            _GridEX.RecordNavigator = true;
            //_GridEX.AllowAddNew = InheritableBoolean.False;
            //_GridEX.AllowEdit = InheritableBoolean.True;
            //_GridEX.AllowDelete = InheritableBoolean.False;
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.FilterRowButtonStyle = FilterRowButtonStyle.None;
            _GridEX.FilterMode = FilterMode.Automatic;
            _Panel.Controls.Add(_GridEX);
            return dttemplate;
        }
        //public static DataTable BuildviewgridJanus_C(string xmlfile, Janus.Windows.GridEX.GridEX _GridEX, System.Windows.Forms.Panel _Panel)
        //{
        //    DataTable dttemplate = IO.ReadXMLTOW(xmlfile);
        //    try
        //    {
        //        dttemplate = dttemplate.Select("value='1'").CopyToDataTable();
        //    }
        //    catch { }
        //    DataView dv = dttemplate.DefaultView;
        //    string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
        //    string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
        //    string CCollection = string.Empty;
        //    for (int i = 0; i < dv.Count; i++)
        //    {
        //        if (dv[i]["name"].ToString().Trim().Equals("C"))
        //        {
        //            CCollection = "<Column" + 0 + " ID='C'>"
        //                                           + "<AllowGroup>" + "False" + "</AllowGroup>"
        //                                           + "<Caption>Chọn</Caption>"
        //                                           + "<ColumnType>" + "CheckBox" + "</ColumnType>"
        //                                           + "<Key>" + "Chon" + "</Key>"
        //                                           + "<Position>" + "0" + "</Position>"
        //                                           + "<Width>" + 20 + "</Width>"
        //                                           + "<ActAsSelector>" + "True" + "</ActAsSelector>"
        //                                           + "</Column" + 0 + ">";
        //        }

        //        if (dv[i]["name"].ToString().Trim().Equals("Ngayphatsinh") || dv[i]["name"].ToString().Trim().Equals("Ngaytao")
        //            || dv[i]["name"].ToString().Trim().Equals("Ngaybatdau") || dv[i]["name"].ToString().Trim().Equals("Ngayketthuc")
        //            || dv[i]["name"].ToString().Trim().Equals("Datebegin") || dv[i]["name"].ToString().Trim().Equals("Datefinish"))
        //        {
        //            CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
        //                                     + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
        //                                     + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
        //                                     + "<Key>" + dv[i]["name"].ToString() + "</Key>"
        //                                     + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
        //                                     + "<FormatString>dd/MM/yyyy</FormatString>"
        //                                     + "<Position>" + i + "</Position></Column" + i + ">";
        //        }
        //        if (dv[i]["name"].ToString().Trim().Equals("TTiencovat") || dv[i]["name"].ToString().Trim().Equals("TTienchuavat")
        //            || dv[i]["name"].ToString().Trim().Equals("Giabinhquancovat") || dv[i]["name"].ToString().Trim().Equals("Giabinhquanchuavat")
        //            || dv[i]["name"].ToString().Trim().Equals("Giamuacovat") || dv[i]["name"].ToString().Trim().Equals("Giabanlechuavat")
        //            || dv[i]["name"].ToString().Trim().Equals("Giabanlechuavat") || dv[i]["name"].ToString().Trim().Equals("Giabanbuonchuavat")
        //            || dv[i]["name"].ToString().Trim().Equals("Giabanbuoncovat") || dv[i]["name"].ToString().Trim().Equals("Giabanlecovat")
        //            )
        //        {
        //            CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
        //                                     + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
        //                                     + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
        //                                     + "<Key>" + dv[i]["name"].ToString() + "</Key>"
        //                                     + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
        //                                     + "<FormatString>#,##0.0000</FormatString>"
        //                                      + "<CellStyle><ForeColor>Red</ForeColor><FontBold>True</FontBold><FontItalic>True</FontItalic><TextAlignment>Center</TextAlignment></CellStyle>"
        //                                     + "<Position>" + i + "</Position></Column" + i + ">";
        //        }
        //        if (dv[i]["name"].ToString().Trim().Equals("Soluong") || dv[i]["name"].ToString().Trim().Equals("SL_TON_NHAN")
        //       || dv[i]["name"].ToString().Trim().Equals("SL_TON_XUAT") || dv[i]["name"].ToString().Trim().Equals("Sltontoida") || dv[i]["name"].ToString().Trim().Equals("Sltontoithieu"))
        //        {
        //            CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
        //                                     + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
        //                                     + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
        //                                     + "<Key>" + dv[i]["name"].ToString() + "</Key>"
        //                                     + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
        //                                     + "<FormatString>#,##0</FormatString>"
        //                                     + "<CellStyle><BackColor>128,128,255</BackColor><ForeColor>Yellow</ForeColor><FontBold>True</FontBold><FontItalic>True</FontItalic><TextAlignment>Center</TextAlignment></CellStyle>"
        //                                     + "<Position>" + i + "</Position></Column" + i + ">";
        //        }
        //        else
        //        {
        //            CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
        //                                       + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
        //                                       + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
        //                                       + "<Key>" + dv[i]["name"].ToString() + "</Key>"
        //                                       + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
        //                                       + "<Position>" + i + "</Position></Column" + i + ">";
        //        }


        //    }
        //    string layout = BeginLayout + CCollection + EndLayout;
        //    GridEXLayout _GridEXLayout = new GridEXLayout();
        //    // _GridEXLayout.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection='true'>" +
        //    //"<Column0 ID='ID'><Caption>ID</Caption><DataMember>ID</DataMember><Key>ID</Key><Position>0</Position></Column0>"
        //    //+ "<Column1 ID='Name'><Caption>Name</Caption><DataMember>Name</DataMember><Key>Name</Key><Position>1</Position></Column1></Columns>"
        //    //+ "<GroupCondition ID='' /></RootTable></GridEXLayoutData>";

        //    _GridEXLayout.LayoutString = layout;
        //    _GridEX.DesignTimeLayout = _GridEXLayout;
        //    _GridEX.Height = _Panel.Height;
        //    _GridEX.Width = _Panel.Width;
        //    _GridEX.RecordNavigator = true;
        //    //_GridEX.AllowAddNew = InheritableBoolean.False;
        //    //_GridEX.AllowEdit = InheritableBoolean.True;
        //    //_GridEX.AllowDelete = InheritableBoolean.False;
        //    _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
        //    _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
        //    _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
        //    _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
        //    _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        //    _GridEX.FilterRowButtonStyle = FilterRowButtonStyle.None;
        //    _GridEX.FilterMode = FilterMode.Automatic;
        //    _Panel.Controls.Add(_GridEX);
        //    return dttemplate;
        //}
        public static DataTable BuildviewgridJanus(string xmlfile, Janus.Windows.GridEX.GridEX _GridEX, System.Windows.Forms.Panel _Panel)
        {
            DataTable dttemplate = IO.ReadXMLTOW(xmlfile);
            try
            {
                dttemplate = dttemplate.Select("value='1'").CopyToDataTable();
            }
            catch { }
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            for (int i = 0; i < dv.Count; i++)
            {
                if (Array.Exists(_colDate, gtri => gtri == dv[i]["name"].ToString()))
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>dd/MM/yyyy</FormatString>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                if (Array.Exists(_colInt, gtri => gtri == dv[i]["name"].ToString()))
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + STATIC_PARAM.FormatNumber_Grid + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                              + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else if (Array.Exists(_colDecimal, gtri => gtri == dv[i]["name"].ToString()))
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + "#,##0.00" + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                              + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else if (dv[i]["name"].ToString() == "Somet")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + "#,###" + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                              + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                               + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                               + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                               + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                                + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                               + "<FilterRowComparison>Contains</FilterRowComparison>"
                                               + "<Position>" + i + "</Position></Column" + i + ">";
                }
            }
            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            // _GridEXLayout.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection='true'>" +
            //"<Column0 ID='ID'><Caption>ID</Caption><DataMember>ID</DataMember><Key>ID</Key><Position>0</Position></Column0>"
            //+ "<Column1 ID='Name'><Caption>Name</Caption><DataMember>Name</DataMember><Key>Name</Key><Position>1</Position></Column1></Columns>"
            //+ "<GroupCondition ID='' /></RootTable></GridEXLayoutData>";

            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            _GridEX.Height = _Panel.Height;
            _GridEX.Width = _Panel.Width;
            _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.RecordNavigator = true;

            //_GridEX.AllowAddNew = InheritableBoolean.False;
            //_GridEX.AllowEdit = InheritableBoolean.True;
            //_GridEX.AllowDelete = InheritableBoolean.False;
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _Panel.AutoScroll = true;
            _Panel.Controls.Add(_GridEX);
            return dttemplate;
        }
        public static DataTable LOAD_GRID_UIPanel_Format(string xmlfile, Janus.Windows.GridEX.GridEX _GridEX, System.Windows.Forms.Panel _Panel)
        {
            //DmkhachhangManager _TablecolumnManager = new DmkhachhangManager();
            //DataTable dt111 = _TablecolumnManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, GD.BBPH.LIB.PATH.ERP_PATH + @"\XMLCONFIG\FRM_DMKHACHHANG.xml");

            DataTable dttemplate = IO.ReadXMLTOW(xmlfile);
            try
            {
                dttemplate = dttemplate.Select("value='1'").CopyToDataTable();
            }
            catch { }
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["Type"].ToString() == "D")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<EditType>CalendarCombo</EditType>"
                                              + "<FormatString>" + dv[i]["Format"].ToString() + "</FormatString>"
                                              + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                                              + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                              + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                if (dv[i]["Type"].ToString() == "N")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + dv[i]["Format"].ToString() + "</FormatString>"
                                              + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                                              + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                              + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                                + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                                + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                                + "<FormatString>" + dv[i]["Format"].ToString() + "</FormatString>"
                                                + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                                                + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                                + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                                + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                                 + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                                + "<Position>" + i + "</Position></Column" + i + ">";
                }
            }
            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            // _GridEXLayout.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection='true'>" +
            //"<Column0 ID='ID'><Caption>ID</Caption><DataMember>ID</DataMember><Key>ID</Key><Position>0</Position></Column0>"
            //+ "<Column1 ID='Name'><Caption>Name</Caption><DataMember>Name</DataMember><Key>Name</Key><Position>1</Position></Column1></Columns>"
            //+ "<GroupCondition ID='' /></RootTable></GridEXLayoutData>";

            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            _GridEX.Height = _Panel.Height;
            _GridEX.Width = _Panel.Width;
            _GridEX.RecordNavigator = true;
            //_GridEX.AllowAddNew = InheritableBoolean.False;
            //_GridEX.AllowEdit = InheritableBoolean.True;
            //_GridEX.AllowDelete = InheritableBoolean.False;
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.FilterRowButtonStyle = FilterRowButtonStyle.None;
            _GridEX.FilterMode = FilterMode.Automatic;
            _GridEX.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            _Panel.AutoScroll = true;
            _Panel.Controls.Add(_GridEX);
            return dttemplate;
        }
        public static DataTable LOAD_GRID_UIPanel_Format_C(string xmlfile, Janus.Windows.GridEX.GridEX _GridEX, System.Windows.Forms.Panel _Panel)
        {
            //DmkhachhangManager _TablecolumnManager = new DmkhachhangManager();
            //DataTable dt111 = _TablecolumnManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, GD.BBPH.LIB.PATH.ERP_PATH + @"\XMLCONFIG\FRM_DMKHACHHANG.xml");

            DataTable dttemplate = IO.ReadXMLTOW(xmlfile);
            try
            {
                dttemplate = dttemplate.Select("value='1'").CopyToDataTable();
            }
            catch { }
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;

            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["name"].ToString().Trim().Equals("C"))
                {
                    CCollection = "<Column" + 0 + " ID='C'>"
                                                   + "<AllowGroup>" + "False" + "</AllowGroup>"
                                                   + "<Caption>Chọn</Caption>"
                                                   + "<ColumnType>" + "CheckBox" + "</ColumnType>"
                                                   + "<Key>" + "Chon" + "</Key>"
                                                   + "<Position>" + "0" + "</Position>"
                                                   + "<Width>" + 20 + "</Width>"
                                                   + "<ActAsSelector>" + "True" + "</ActAsSelector>"
                                                   + "</Column" + 0 + ">";
                }
                if (dv[i]["Type"].ToString() == "D")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<EditType>CalendarCombo</EditType>"
                                              + "<FormatString>" + dv[i]["Format"].ToString() + "</FormatString>"
                                              + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                                              + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                              + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                if (dv[i]["Type"].ToString() == "N")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + dv[i]["Format"].ToString() + "</FormatString>"
                                              + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                                              + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                              + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                                + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                                + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                                + "<FormatString>" + dv[i]["Format"].ToString() + "</FormatString>"
                                                + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                                                + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                                + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                                + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                                 + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                                + "<Position>" + i + "</Position></Column" + i + ">";
                }
            }
            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            // _GridEXLayout.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection='true'>" +
            //"<Column0 ID='ID'><Caption>ID</Caption><DataMember>ID</DataMember><Key>ID</Key><Position>0</Position></Column0>"
            //+ "<Column1 ID='Name'><Caption>Name</Caption><DataMember>Name</DataMember><Key>Name</Key><Position>1</Position></Column1></Columns>"
            //+ "<GroupCondition ID='' /></RootTable></GridEXLayoutData>";

            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            _GridEX.Height = _Panel.Height;
            _GridEX.Width = _Panel.Width;
            _GridEX.RecordNavigator = true;
            //_GridEX.AllowAddNew = InheritableBoolean.False;
            //_GridEX.AllowEdit = InheritableBoolean.True;
            //_GridEX.AllowDelete = InheritableBoolean.False;
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.FilterRowButtonStyle = FilterRowButtonStyle.None;
            _GridEX.FilterMode = FilterMode.Automatic;
            _GridEX.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            _Panel.AutoScroll = true;
            _Panel.Controls.Add(_GridEX);
            return dttemplate;
        }

        public static void Loadcontrol(UserControl _UserControl, GD.BBPH.CONTROL.FORM _Form)
        {
            _UserControl.Width = _Form.Width;
            _UserControl.Height = _Form.Height;
            _UserControl.Dock = DockStyle.Fill;
            _Form.Controls.Add(_UserControl);
        }
        public static DataTable Buildviewgrid_NEW(string xmlfile, DataGridView _DataGridView, System.Windows.Forms.Panel _Panel)
        {
            _DataGridView.Columns.Clear();

            DataTable dttemplate = IO.ReadXMLTOW(xmlfile);
            //DataSet ds = IO.ReadXML2(xmlfile);
            //DataTable dttemplate = ds.Tables[0];
            try
            {
                dttemplate = dttemplate.Select("value='1'").CopyToDataTable();
            }
            catch { }
            for (int i = 0; i < dttemplate.Rows.Count; i++)
            {
                DataGridViewTextBoxColumn Colum = new DataGridViewTextBoxColumn();
                Colum.Name = dttemplate.Rows[i]["name"].ToString();
                Colum.HeaderText = dttemplate.Rows[i]["headerText"].ToString();
                Colum.DataPropertyName = dttemplate.Rows[i]["name"].ToString();
                if (dttemplate.Rows[i]["value"].ToString().Trim().Equals("0") || dttemplate.Rows[i]["value"].ToString().Trim().Equals("2"))
                {
                    Colum.Visible = false;
                }
                Colum.Width = int.Parse(dttemplate.Rows[i]["Width"].ToString());
                _DataGridView.Columns.Add(Colum);
                _DataGridView.AutoGenerateColumns = false;
                _DataGridView.AutoSize = true;
                _DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
                _DataGridView.AllowUserToAddRows = false;
                _DataGridView.ReadOnly = true;
                _DataGridView.Location = new System.Drawing.Point(22, 42);
                _DataGridView.Size = new System.Drawing.Size(905, 368);

                _DataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            string strtest = string.Empty;
            for (int j = 0; j < _DataGridView.Columns.Count; j++)
            {
                for (int k = 0; k < dttemplate.Rows.Count; k++)
                {
                    if (_DataGridView.Columns[j].Name == dttemplate.Rows[k]["name"].ToString())
                    {
                        try
                        {
                            _DataGridView.Columns[j].DisplayIndex = int.Parse(dttemplate.Rows[k]["Thutu"].ToString());
                            break;
                        }
                        catch { }
                    }
                }
            }
            _DataGridView.Refresh();
            _Panel.AutoScroll = true;
            _Panel.Controls.Add(_DataGridView);
            return dttemplate;
        }
        public static DataTable Buildviewgrid_NEW_C(string xmlfile, DataGridView _DataGridView, System.Windows.Forms.Panel _Panel)
        {
            _DataGridView.Columns.Clear();
            DataTable dttemplate = IO.ReadXMLTOW(xmlfile);
            try
            {
                dttemplate = dttemplate.Select("value='1'").CopyToDataTable();
            }
            catch { }
            DataGridViewCheckBoxColumn Checkcolume = new DataGridViewCheckBoxColumn();
            Checkcolume.Name = "C";
            Checkcolume.HeaderText = "Chọn";
            Checkcolume.Width = 40;
            _DataGridView.Columns.Add(Checkcolume);

            for (int i = 0; i < dttemplate.Rows.Count; i++)
            {
                DataGridViewTextBoxColumn Colum = new DataGridViewTextBoxColumn();
                Colum.Name = dttemplate.Rows[i]["name"].ToString();
                Colum.HeaderText = dttemplate.Rows[i]["headerText"].ToString();
                Colum.DataPropertyName = dttemplate.Rows[i]["name"].ToString();
                if (dttemplate.Rows[i]["value"].ToString().Trim().Equals("0") || dttemplate.Rows[i]["value"].ToString().Trim().Equals("2"))
                {
                    Colum.Visible = false;
                }
                Colum.Width = int.Parse(dttemplate.Rows[i]["Width"].ToString());
                _DataGridView.Columns.Add(Colum);
                _DataGridView.AutoGenerateColumns = false;
                _DataGridView.AutoSize = true;
                _DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
                _DataGridView.AllowUserToAddRows = false;
                _DataGridView.ReadOnly = true;
                _DataGridView.Location = new System.Drawing.Point(22, 42);
                _DataGridView.Size = new System.Drawing.Size(905, 368);

                _DataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            string strtest = string.Empty;
            for (int j = 0; j < _DataGridView.Columns.Count; j++)
            {
                for (int k = 0; k < dttemplate.Rows.Count; k++)
                {
                    if (_DataGridView.Columns[j].Name == dttemplate.Rows[k]["name"].ToString())
                    {
                        try
                        {
                            _DataGridView.Columns[j].DisplayIndex = int.Parse(dttemplate.Rows[k]["Thutu"].ToString());
                            break;
                        }
                        catch { }
                    }
                }
            }
            _DataGridView.Refresh();
            _Panel.AutoScroll = true;
            _Panel.Controls.Add(_DataGridView);

            return dttemplate;
        }
        public static void cratexml(DataTable dt, string filename)
        {
            DataTable dtemp = new DataTable("viewgrid");
            dtemp.Columns.Add("value", typeof(String));
            dtemp.Columns.Add("name", typeof(String));
            dtemp.Columns.Add("headerText");
            dtemp.Columns.Add("BackColor");
            dtemp.Columns.Add("SelectionBackColor");
            dtemp.Columns.Add("Width");
            dtemp.Columns.Add("Thutu");
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                DataRow r = dtemp.NewRow();
                r["value"] = "1";
                r["name"] = dt.Columns[j].ColumnName;
                r["headerText"] = dt.Columns[j].ColumnName;
                r["BackColor"] = "0";
                r["SelectionBackColor"] = "0";
                r["Width"] = "100";
                r["Thutu"] = "100";
                dtemp.Rows.Add(r);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dtemp);
            IO.GenXML(filename, ds);

        }
        public static void cratexml_C(DataTable dt, string filename)
        {
            DataTable dtemp = new DataTable("viewgrid");
            dtemp.Columns.Add("value", typeof(String));
            dtemp.Columns.Add("name", typeof(String));
            dtemp.Columns.Add("headerText");
            dtemp.Columns.Add("BackColor");
            dtemp.Columns.Add("SelectionBackColor");
            dtemp.Columns.Add("Width");
            dtemp.Columns.Add("Thutu");
            DataRow r_c = dtemp.NewRow();
            r_c["value"] = "1";
            r_c["name"] = "C";
            r_c["headerText"] = "Chọn";
            r_c["BackColor"] = "0";
            r_c["SelectionBackColor"] = "0";
            r_c["Width"] = "50";
            r_c["Thutu"] = "100";
            dtemp.Rows.Add(r_c);

            for (int j = 0; j < dt.Columns.Count; j++)
            {
                DataRow r = dtemp.NewRow();
                r["value"] = "1";
                r["name"] = dt.Columns[j].ColumnName;
                r["headerText"] = dt.Columns[j].ColumnName;
                r["BackColor"] = "0";
                r["SelectionBackColor"] = "0";
                r["Width"] = "100";
                r["Thutu"] = "100";
                dtemp.Rows.Add(r);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dtemp);
            IO.GenXML(filename, ds);

        }
        public static string rootpath = Application.StartupPath;
        //public static string prjpath()
        //{
        //    return TBNet.Filexmlconfig.apppath;
        //    //DirectoryInfo _DirectoryInfo = new DirectoryInfo(rootpath);
        //    //return _DirectoryInfo.Parent.Parent.FullName.ToString();
        //}
        //public static string rootpathReport(string thumuc)
        //{
        //    return prjpath() + @"\Report\" + thumuc + @"\dm" + thumuc + ".rpt";
        //}
        //public static string pathReportPhieuNhap(string LoaiGiaoDich)
        //{
        //    return prjpath() + @"\Report\phieunhap\" + LoaiGiaoDich;
        //}
        //public static string pathBaoCaoTongHopKhoHang()
        //{
        //    return prjpath() + @"\Baocao\khohang";
        //}
        //public static string pathReportPhieuGiaoDich(string LoaiGiaoDich)
        //{
        //    return prjpath() + @"\Report\phieugiaodich\"+ LoaiGiaoDich ;
        //}
        //public static string ShowMsg(string Maloiid, string type)
        //{
        //    string tieude = string.Empty, err = "";
        //    string patherr = TBNet.Filexmlconfig.ErrorData;
        //    DataTable dt = IO.ReadXMLTOW(patherr);
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        if (dt.Rows[i]["value"].ToString().Equals(Maloiid))
        //        {
        //            tieude = dt.Rows[i]["headerText"].ToString();
        //            err = dt.Rows[i]["name"].ToString();
        //            TBNet.Mart.TrayPopup.PoupStringMessage(tieude, err, type);
        //            return err;
        //        }
        //    }
        //    TBNet.Mart.TrayPopup.PoupStringMessage("Định nghĩa lỗi ErrorData.xml", "Mã lỗi:" + Maloiid + " Định nghĩa mô tả lỗi", "E");
        //    return err;
        //}
        public static string CreateImagesFolder(string PathFolder, string name)
        {
            string strImagePath = name;

            try
            {
                if (!Directory.Exists(PathFolder + strImagePath))
                {
                    Directory.CreateDirectory(PathFolder + strImagePath);
                }
            }
            catch { }
            return strImagePath;
        }
        //public static DataSet GenMenuXML(string Madanhmuc)
        //{
        //    DataTable drTmp = new DataTable("Menu");
        //    drTmp.Columns.Add("MenuID", typeof(string));
        //    drTmp.Columns.Add("MenuName", typeof(string));
        //    drTmp.Columns.Add("MenuParent", typeof(string));
        //    drTmp.Columns.Add("MenuEnable", typeof(string));
        //    drTmp.Columns.Add("Icon1", typeof(string));
        //    drTmp.Columns.Add("Icon2", typeof(string));
        //    drTmp.Columns.Add(DanhmucchungFields.Madanhmucphu.Name, typeof(string));
        //    drTmp.Columns.Add(DanhmucchungFields.Thutu.Name, typeof(int));
        //    EntityCollection _Collection = new EntityCollection();
        //    //Read XML           
        //    string OutXML = TBNet.Filexmlconfig.Nguoidungform_xml;
        //    System.IO.StreamReader reader = new System.IO.StreamReader(OutXML);
        //    string CollectionXML = reader.ReadToEnd();
        //    reader.Close();
        //    _Collection.ReadXml(CollectionXML);

        //    //filter=Madanhmuc
        //    SD.LLBLGen.Pro.ORMSupportClasses.IEntityView2 _CollectionVIEW = _Collection.DefaultView;
        //    SD.LLBLGen.Pro.ORMSupportClasses.IPredicate filter = (NguoidungformFields.Madanhmuc == Madanhmuc);
        //    _CollectionVIEW.Filter = filter;

        //    DataTable dt = new DataTable();
        //    try
        //    {

        //        DataTable dtdmucchung = IO.ReadXMLTOW(TBNet.Filexmlconfig.Danhmucchung);
        //        dt = dtdmucchung.Select(DanhmucchungFields.Loaidmuc.Name + " ='" + DanhmucchungManager.TBNetForm + "' and " + DanhmucchungFields.Loaimenu.Name + " =1").CopyToDataTable();
        //    }
        //    catch { }
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        DataRow r = drTmp.NewRow();
        //        r["MenuID"] = dt.Rows[i][DanhmucchungFields.Madanhmuc.Name].ToString();
        //        r["MenuName"] = dt.Rows[i][DanhmucchungFields.Tendanhmuc.Name].ToString();
        //        r["MenuParent"] = dt.Rows[i][DanhmucchungFields.Madanhmuccha.Name].ToString();
        //        r["Icon1"] = dt.Rows[i][DanhmucchungFields.Icon1.Name].ToString();
        //        r["Icon2"] = dt.Rows[i][DanhmucchungFields.Icon2.Name].ToString();
        //        r[DanhmucchungFields.Madanhmucphu.Name] = dt.Rows[i][DanhmucchungFields.Madanhmucphu.Name].ToString();
        //        r["MenuEnable"] = "N";
        //        r[DanhmucchungFields.Thutu.Name] = dt.Rows[i][DanhmucchungFields.Thutu.Name].ToString();
        //        for (int j = 0; j < _CollectionVIEW.Count; j++)
        //        {
        //            NguoidungformEntity _NguoidungformEntity = (NguoidungformEntity)_CollectionVIEW[j];
        //            if (r["MenuID"].ToString() == _NguoidungformEntity.Machucnang)
        //            {
        //                if (_NguoidungformEntity.Xem)
        //                {
        //                    r["MenuEnable"] = "Y"; break;
        //                }
        //            }
        //        }
        //        if (Madanhmuc == "NU01" || r["MenuParent"].ToString() == "0" || dt.Rows[i][DanhmucchungFields.Madanhmucphu.Name].ToString() == "0")
        //        {
        //            r["MenuEnable"] = "Y";
        //        }
        //        drTmp.Rows.Add(r);
        //    }
        //    DataSet ds = new DataSet();
        //    ds.Tables.Add(drTmp);
        //    return ds;
        //}
        public static void SaveFileDialog(DataTable dt, System.Windows.Forms.SaveFileDialog saveExcelFDialog)
        {
            saveExcelFDialog.InitialDirectory = @"C:\";
            saveExcelFDialog.ShowDialog();
            string strFilename = saveExcelFDialog.FileName;
            if (strFilename != null && strFilename.Trim() != string.Empty)
            {
                DataSet ds = new DataSet();
                if (ds.Tables.Contains(dt.TableName))
                { ds.Tables.Remove(dt.TableName); }
                ds.Tables.Add(dt);
                GD.BBPH.LIB.ExcelFunctions.WriteToExcel(ds, strFilename, false);
                string filname = System.IO.Path.GetFileName(strFilename);
                string folder = strFilename.Replace(filname, "");
            }
        }
        public static void SaveFileDialog(DataSet ds, System.Windows.Forms.SaveFileDialog saveExcelFDialog)
        {
            saveExcelFDialog.InitialDirectory = @"C:\";
            saveExcelFDialog.ShowDialog();
            string strFilename = saveExcelFDialog.FileName;
            if (strFilename != null && strFilename.Trim() != string.Empty)
            {
                GD.BBPH.LIB.ExcelFunctions.WriteToExcel(ds, strFilename, false);
                string filname = System.IO.Path.GetFileName(strFilename);
                string folder = strFilename.Replace(filname, "");
            }
        }
        public static int GetDateTime(int Thang, int Nam)
        {
            int songay;
            switch (Thang)
            {
                case 4:
                    songay = 30;
                    break;
                case 6:
                    songay = 30;
                    break;
                case 9:
                    songay = 30;
                    break;
                case 11:
                    songay = 30;
                    break;
                case 2:
                    if (((Nam % 4 == 0) && (Nam % 100 != 0)) || (Nam % 400 == 0)) songay = 29;
                    else songay = 28;
                    break;
                default:
                    songay = 31;
                    break;

            }
            return songay;
        }
        public static string ConvertDateString(DateTime dDate)
        {
            //Format: "11-Jan-1983";
            string values;

            string day, month, year;
            day = dDate.Day.ToString();
            if (day.Length == 1)
                day = "0" + day;
            month = dDate.Month.ToString();
            year = dDate.Year.ToString();

            switch (int.Parse(month))
            {
                case 1:
                    month = "Jan";
                    break;
                case 2:
                    month = "Feb";
                    break;
                case 3:
                    month = "Mar";
                    break;
                case 4:
                    month = "Apr";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "Jun";
                    break;
                case 7:
                    month = "Jul";
                    break;
                case 8:
                    month = "Aug";
                    break;
                case 9:
                    month = "Sep";
                    break;
                case 10:
                    month = "Oct";
                    break;
                case 11:
                    month = "Nov";
                    break;
                case 12:
                    month = "Dec";
                    break;
            }
            values = day + "-" + month + "-" + year;
            return values;
        }
        public static DataTable GetDistinct(string table, DataTable source, string field)
        {
            //new DataTable to hold the distinct values
            DataTable newDT = new DataTable(table);

            //add a new column to the DataTable (column we are searching in)
            newDT.Columns.Add(field, source.Columns[field].DataType);

            //get an array of DataRows that match the search criteria
            DataRow[] rows = source.Select("", field);

            object value = null;

            //loop through all the rows
            foreach (DataRow row in rows)
            {
                if (value == null || !(AreEqual(value, row[field])))
                {
                    value = row[field];
                    newDT.Rows.Add(new object[] { value });
                }
            }
            return newDT;
        }
        private static bool AreEqual(object obj1, object obj2)
        {
            //both columns are DBNull.Value
            if (object.ReferenceEquals(obj1, DBNull.Value) & object.ReferenceEquals(obj2, DBNull.Value))
                return true;
            //only one column is DBNull.Value
            if (object.ReferenceEquals(obj1, DBNull.Value) | object.ReferenceEquals(obj2, DBNull.Value))
                return false;

            //if we make it this far then we just do a standard comparison
            return obj1 == obj2;
        }
        public static DataRow Check_Masieuthi(string masieuthi, DataTable dtMatHang)
        {
            DataRow _RowViewSelect = null;
            try
            {
                dtMatHang = dtMatHang.Select("Barcode =" + "'" + masieuthi + "' OR Barcodethung ='" + masieuthi + "' OR Masieuthi ='" + masieuthi + "' OR Mathung='" + masieuthi + "' OR Mahangcuancc ='" + masieuthi + "' OR Masieuthiphu like '%;" + masieuthi + ";%'").CopyToDataTable();
            }
            catch { dtMatHang.Clear(); }
            if (dtMatHang.Rows.Count > 0)
            {
                _RowViewSelect = dtMatHang.Rows[0];
                return _RowViewSelect;
            }
            return null;
        }
        //public static DataRow Check_masieuthi_REMOVE(string masieuthi, DataTable dt)
        //{
        //    try
        //    {
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            if (dt.Rows[i][MathangFields.Masieuthi.Name].ToString() == masieuthi) return dt.Rows[i];
        //        }
        //    }
        //    catch { }
        //    return null;
        //}
    }
}

