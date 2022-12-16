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
using SD.LLBLGen.Pro.ORMSupportClasses;
namespace GD.BBPH.LIB
{
    public class GRID_COMM
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
                , "Dodaytu", "Dodayden", "Khotu", "Khoden", "Chieudaitu", "Chieudaiden", "Tocdo", "Tylebaophu"
                // DM màng của hàng
                ,"Khomang", "Rongcuon", "Daicuon", "Rong","Dai", "Hong"
                , "Bangdinhdan", "Dinhmuckeokho", "Dinhmucdongrankho" , "Dinhmuckeouot"
                ,"Dinhmucdongranuot", "Dinhmucdungmoi"
                 // DM màng
                , "Doday", "Rong"
                 // DONHANG
                ,"Soluong", "Soluongconlai"
                 // HANGTRALAI
                ,"Soluonggiao", "Soluongtralai"
                //KQinchitiet
                ,"Thoigianchuanbi", "Thoigiansuco"
                //KQghepchitiet
                ,"Thuctekeo", "Thuctedongran", "Thuctedungmoi"
                 //KQtuachitiet
                ,"Thoigianhacuon", "Thoigiancatdau", "Thoigiandoilenh"
                //KQchiachitiet
                ,"Thoigianlencuon"
                 //KQhoanthienchitiet
                ,"Thoigianlenhacuon", "Ketquatui"
                ,"Catrong", "Thoigiantrong"
        };

        //-----Danh sách các cột số thập phân
        private static string[] _colDecimal = {
            "Tylehaomon", "Khoiluong", "Sokg", "Sokgdukien", "Doben", "Dodandai", "Khoiluongphe", "Tylephantram", "Tylekeokho", "Tyledongran", "Tyledongrankho", "Tylekeo"
                 // DM nguyên liệu
                ,"Tang", "Giam"
                // DM màu
                ,"Tyle"
                // DM vật tư sai hỏng
                ,"Dinhmuc"
                // DM keo
                , "Hamluongkeo", "Hamluongdongran", "Tylephakeo", "Tylephadongran", "Dungmoi"
                //KQinchitiet
                ,"Nangsuat", "SometLSX", "Sometcap", "Sokgcap", "Thuctein", "Sokgin", "Saihongthucte"
                ,"PheNCC", "PheSX"
                 //KQghepchitiet
                ,"Dauratua", "ManginMet", "ManginKg", "MangcapMet", "MangcapKg", "ThucteMet", "ThucteKg"
                ,"Phethoi", "Pheghep", "Phein"
                //KQtuachitiet
                ,"SoMetvao", "SoKgvao", "SoMetra", "SoKgra", "Phesx"
                //KQchiachitiet
                ,"Tylesaihong", "Dauraghep", "Sometvao", "Sokgvao", "Phechia", "PhethoiNCC"
                //KQhoanthienchitiet
                ,"Chatluongtui", "Daurachiaghep", "Dauvaomet", "Dauvaokg", "Phebien", "Phechinhmay", "Phekhac"
                ,"Sometquydoi", "Sometdain", "Sometdatua", "Sometconlai", "SoMnhucau", "Sokgnhucau", "Sokgsudung"
        };

        //-----Danh sách các cột ngày
        private static string[] _colDate = {
            "Ngaychungtu", "Ngayhachtoan", "Ngaydat", "Ngaygiao", "Ngaychay", "Ngay", "Ngayapdung", "Ngaymarket", "Ngayha", "Ngaynhap"
                , "Ngayhoanthanh", "Ngaycuoink", "Ngaytrang", "Ngayin1", "Ngayin2", "Ngayxuat", "Ngaykiemke", "Ngaydieuchuyen"
                , "Ngaybaogia", "Ngayhieuluc", "Ngayhoadon", "Ngayctkt"
                , "Ngayphatlenh", "Ngaybatdausx", "Ngayhoanthanhsx"
        };


        

        public static DataTable XmlString2DataSet(string xmlString)
        {
            //create a new DataSet that will hold our values
            DataSet quoteDataSet = null;

            //check if the xmlString is not blank
            if (String.IsNullOrEmpty(xmlString))
            {
                //stop the processing
                return quoteDataSet.Tables[0];
            }

            try
            {
                //create a StringReader object to read our xml string
                using (StringReader stringReader = new StringReader(xmlString))
                {
                    //initialize our DataSet
                    quoteDataSet = new DataSet();

                    //load the StringReader to our DataSet
                    quoteDataSet.ReadXml(stringReader);
                }
            }
            catch
            {
                //return null
                quoteDataSet = null;
            }

            //return the DataSet containing the stock information
            return quoteDataSet.Tables[0];
        }
        public static DataTable GET_DATA_CONFIGXML(string FormName)
        {
            DataTable DT = new DataTable();
            string Content = "";
            //try
            //{
            //    Content = GD.BBPH.DATA.SESSION_START.TABLECONFIG.Select(TableconfigFields.Frmname.Name + " ='" + FormName + "'").CopyToDataTable().Rows[0][TableconfigFields.Dataconfig.Name].ToString(); //GD.BBPH.LIB.TextFiles.ReadFile(GD.BBPH.LIB.PATH.ERP_PATH + @"\XMLCONFIG\" + FormName + ".xml");
            //}
            //catch { }
            if (string.IsNullOrEmpty(Content) == false) DT = XmlString2DataSet(Content);
            if (string.IsNullOrEmpty(Content))
            {
                Content = GD.BBPH.LIB.TextFiles.ReadFile(FormName);// (GD.BBPH.LIB.PATH.ERP_PATH + @"\XMLCONFIG\" + FormName + ".xml");
                DT = XmlString2DataSet(Content);
                //try
                //{
                //    TableconfigEntity _TableconfigEntity = new TableconfigEntity();
                //    TableconfigManager _TableconfigManager = new TableconfigManager();
                //    _TableconfigEntity.Frmname = _TableconfigEntity.Tablename = FormName;
                //    _TableconfigEntity.Dataconfig = Content;
                //    _TableconfigEntity.Madonvi = GD.BBPH.DATA.DMDONVI._Current.Madonvi;
                //    _TableconfigManager.Insert(_TableconfigEntity);
                //}
                //catch { }
                //DT = TBNet.Project.IO.ReadXMLTOW(GD.BBPH.LIB.PATH.ERP_PATH + @"\XMLCONFIG\" + FormName + ".xml");
            }
            return DT;
        }
        public static DataTable LOAD_GRID_SYS_TabPage(string FormName, Janus.Windows.GridEX.GridEX _GridEX, TabPage _TabPage, bool isEditRows)
        {
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            try
            {
                dttemplate = dttemplate.Select("value='1' OR value='2'").CopyToDataTable();
            }
            catch { }
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["value"].ToString() == "2")
                {
                    //CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                    //                          + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                    //                          + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                    //                          + "<FormatString>" + dv[i]["Format"].ToString() + "</FormatString>"
                    //                          + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                    //                          + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                    //                          + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                    //                          + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                    //                           + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                    //                          + "<Position>" + i + "</Position></Column" + i + ">"
                    //                          +"<Visible>FALSE</Visible>";

                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>S</FormatString>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position><Visible>FALSE</Visible></Column" + i + ">";
                }
                if (dv.Table.Columns.Contains("Type") == true && dv[i]["Type"].ToString() == "D")
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
                if (dv.Table.Columns.Contains("Type") == true && dv[i]["Type"].ToString() == "N")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + STATIC_PARAM.FormatNumber_Grid + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                              + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else
                {
                    //CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                    //                            + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                    //                            + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                    //                            + "<FormatString>" + dv[i]["Format"].ToString() + "</FormatString>"
                    //                            + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                    //                            + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                    //                            + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                    //                            + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                    //                             + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                    //                            + "<Position>" + i + "</Position></Column" + i + ">";

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
            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            if (_TabPage != null)
            {
                _GridEX.Height = _TabPage.Height;
                _GridEX.Width = _TabPage.Width;
            }
            _GridEX.RecordNavigator = true;
            if (isEditRows)
            {
                _GridEX.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
                _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
                _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            }
            else
            {
                _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            }
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _GridEX.FilterRowButtonStyle = FilterRowButtonStyle.None;
            _GridEX.FilterMode = FilterMode.None;
            _GridEX.GroupByBoxVisible = false;
            if (_TabPage != null)
            {                
                _TabPage.Controls.Add(_GridEX);
            }
            return dttemplate;
        }

        public static DataTable LOAD_GRID_TabPage_Fomat(string FormName, Janus.Windows.GridEX.GridEX _GridEX, Janus.Windows.UI.Tab.UITabPage _TabPage, bool isEditRows)
        {
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            try
            {
                dttemplate = dttemplate.Select("value='1' OR value='2'").CopyToDataTable();
            }
            catch { }
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["value"].ToString() == "2")
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
                                              + "<Position>" + i + "</Position></Column" + i + ">"
                                              + "<Visible>FALSE</Visible>";
                }
                if (dv[i]["Type"].ToString() == "D")                
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
                if (dv[i]["Type"].ToString() == "N")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + STATIC_PARAM.FormatNumber_Grid + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
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
            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            if (_TabPage != null)
            {
                _GridEX.Height = _TabPage.Height;
                _GridEX.Width = _TabPage.Width;
            }            
            _GridEX.RecordNavigator = true;
            if (isEditRows)
            {
                _GridEX.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
                _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
                _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            }
            else
            {
                _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            }
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _GridEX.FilterRowButtonStyle = FilterRowButtonStyle.None;
            _GridEX.FilterMode = FilterMode.None;
            _GridEX.GroupByBoxVisible = false;
            if (_TabPage != null)
            {
                _TabPage.AutoScroll = true;
                _TabPage.Controls.Add(_GridEX);
            }            
            return dttemplate;
        }

        public static DataTable LOAD_GRID_UIPanel_Format_C(string xmlfile, Janus.Windows.GridEX.GridEX _GridEX, System.Windows.Forms.Panel _Panel)
        {
            DataTable dttemplate = GET_DATA_CONFIGXML(xmlfile);
            try
            {
                dttemplate = dttemplate.Select("value='1' OR value='2'").CopyToDataTable();
            }
            catch { }
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;

            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["value"].ToString().Trim().Equals("2"))
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + STATIC_PARAM.FormatNumber_Grid + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                              + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position>"
                                              + "<Visible>FALSE</Visible></Column" + i + ">";
                }
                if (dv[i]["name"].ToString().Trim().Equals("Tamung"))
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
                if (dv.Table.Columns.Contains("Type")==true && dv[i]["Type"].ToString() == "D")
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
                if (dv.Table.Columns.Contains("Type") == true && dv[i]["Type"].ToString() == "N")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + STATIC_PARAM.FormatNumber_Grid + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
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
                                                + "<Format>" + dv[i]["Format"].ToString() + "</Format>"
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

        public static DataTable LOAD_GRID_UIPanel(string FormName, Janus.Windows.GridEX.GridEX _GridEX, Janus.Windows.UI.Dock.UIPanelInnerContainer _Panel)
        {
            //DmkhachhangManager _TablecolumnManager = new DmkhachhangManager();
            //DataTable dt111 = _TablecolumnManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, GD.BBPH.LIB.PATH.ERP_PATH + @"\XMLCONFIG\FRM_DMKHACHHANG.xml");
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            for (int i = 0; i < dv.Count; i++)
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
                                              + "<FormatString>dd/MM/yy</FormatString>"
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
                else if (Array.Exists(_colDecimal, gtri => gtri==dv[i]["name"].ToString()))
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
                else if (dv[i]["name"].ToString() == "Somet" )
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

            _GridEX.GroupByBoxInfoText = "Nhóm dữ liệu theo cột";
            _Panel.AutoScroll = true;
            _Panel.Controls.Add(_GridEX);
            return dttemplate;
        }
        public static DataTable LOAD_GRID_UIPanel(string FormName, Janus.Windows.GridEX.GridEX _GridEX, System.Windows.Forms.Panel _Panel)
        {
            //DmkhachhangManager _TablecolumnManager = new DmkhachhangManager();
            //DataTable dt111 = _TablecolumnManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, GD.BBPH.LIB.PATH.ERP_PATH + @"\XMLCONFIG\FRM_DMKHACHHANG.xml");
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            for (int i = 0; i < dv.Count; i++)
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
                if (Array.Exists(_colDate, gtri => gtri == dv[i]["name"].ToString()))
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>dd/MM/yy</FormatString>"
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

            _GridEX.GroupByBoxInfoText = "Nhóm dữ liệu theo cột";
            _Panel.AutoScroll = true;
            _Panel.Controls.Add(_GridEX);
            return dttemplate;
        }
        public static DataTable LOAD_GRID_UIPanel_C(string FormName, Janus.Windows.GridEX.GridEX _GridEX, System.Windows.Forms.Panel _Panel)
        {
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
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

                if (dv[i]["name"].ToString().Trim().Equals("Ngayphatsinh") || dv[i]["name"].ToString().Trim().Equals("Ngaytao")
                    || dv[i]["name"].ToString().Trim().Equals("Ngayhachtoan")
                    || dv[i]["name"].ToString().Trim().Equals("Ngaybatdau") || dv[i]["name"].ToString().Trim().Equals("Ngayketthuc")
                    || dv[i]["name"].ToString().Trim().Equals("Datebegin") || dv[i]["name"].ToString().Trim().Equals("Datefinish"))
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                             + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                             + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                             + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                             + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                             + "<FormatString>dd/MM/yyyy</FormatString>"
                                             + "<Position>" + i + "</Position></Column" + i + ">";
                }
                if (dv[i]["name"].ToString().Trim().Equals("TTiencovat") || dv[i]["name"].ToString().Trim().Equals("TTienchuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Ttiencovat") || dv[i]["name"].ToString().Trim().Equals("Ttienchuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Giabinhquancovat") || dv[i]["name"].ToString().Trim().Equals("Giabinhquanchuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Giamuacovat") || dv[i]["name"].ToString().Trim().Equals("Giabanlechuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Giabanlechuavat") || dv[i]["name"].ToString().Trim().Equals("Giabanbuonchuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Giabanbuoncovat") || dv[i]["name"].ToString().Trim().Equals("Giabanlecovat")
                    )
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                             + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                             + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                             + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                             + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                             + "<FormatString>#,##0.0000</FormatString>"
                                             + "<Position>" + i + "</Position></Column" + i + ">";
                }
                if (dv[i]["name"].ToString().Trim().Equals("Soluong") || dv[i]["name"].ToString().Trim().Equals("Tongsoluong") || dv[i]["name"].ToString().Trim().Equals("SL_TON_NHAN")
               || dv[i]["name"].ToString().Trim().Equals("SL_TON_XUAT") || dv[i]["name"].ToString().Trim().Equals("Sltontoida") || dv[i]["name"].ToString().Trim().Equals("Sltontoithieu"))
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                             + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                             + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                             + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                             + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                             + "<FormatString>#,##0</FormatString>"
                                             + "<CellStyle><BackColor>128,128,255</BackColor><ForeColor>Yellow</ForeColor><FontBold>True</FontBold><FontItalic>True</FontItalic><TextAlignment>Center</TextAlignment></CellStyle>"
                                             + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                               + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                               + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                               + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                               + "<Position>" + i + "</Position></Column" + i + ">";
                }


            }
            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            _GridEX.Height = _Panel.Height;
            _GridEX.Width = _Panel.Width;
            _GridEX.RecordNavigator = true;
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
        public static DataTable LOAD_GRID_TabPage(string FormName, Janus.Windows.GridEX.GridEX _GridEX, Janus.Windows.UI.Tab.UITabPage _TabPage, bool isEditRows)
        {
            //DmkhachhangManager _TablecolumnManager = new DmkhachhangManager();
            //DataTable dt111 = _TablecolumnManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, GD.BBPH.LIB.PATH.ERP_PATH + @"\XMLCONFIG\FRM_DMKHACHHANG.xml");
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);

            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["value"].ToString() == "2")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + dv[i]["FORMAT"].ToString() + "</FormatString>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position><Visible>FALSE</Visible></Column" + i + ">";
                }
                if (dv[i]["name"].ToString().Trim().Equals("C"))
                {
                    CCollection = "<Column" + 0 + " ID='C'>"
                                                   + "<AllowGroup>" + "False" + "</AllowGroup>"
                                                   + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                                   + "<ColumnType>" + "CheckBox" + "</ColumnType>"
                                                   + "<Key>" + "Chon" + "</Key>"
                                                   + "<Position>" + "0" + "</Position>"
                                                   + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                                   + "<ActAsSelector>" + "True" + "</ActAsSelector>"
                                                   + "</Column" + 0 + ">";
                }
                else if (dv[i]["name"].ToString() == "Ngayhachtoan" || dv[i]["name"].ToString() == "Ngayhoadon" || dv[i]["name"].ToString() == "Ngayctkt")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>dd/MM/yyyy</FormatString>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else if (dv[i]["name"].ToString() == "Sotien")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + STATIC_PARAM.FormatNumber_Grid + "</FormatString>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                } if (dv.Table.Columns.Contains("Type") == true && dv[i]["Type"].ToString() == "N")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + STATIC_PARAM.FormatNumber_Grid + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
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
                                               + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                                + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                               + "<FilterRowComparison>Contains</FilterRowComparison>"
                                               + "<Position>" + i + "</Position></Column" + i + ">";
                }
            }
            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            if (_TabPage != null)
            {
                _GridEX.Height = _TabPage.Height;
                _GridEX.Width = _TabPage.Width;
            }            
            _GridEX.RecordNavigator = true;
            if (isEditRows)
            {
                _GridEX.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
                _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
                _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            }
            else
            {
                _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            }
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _GridEX.FilterRowButtonStyle = FilterRowButtonStyle.None;
            _GridEX.FilterMode = FilterMode.None;
            _GridEX.GroupByBoxVisible = false;
            if (_TabPage != null)
            {
                _TabPage.AutoScroll = true;
                _TabPage.Controls.Add(_GridEX);
            }            
            return dttemplate;
        }

        public static DataTable LOAD_GRID_Panel(string FormName, DataGridView _DataGridView, System.Windows.Forms.Panel _Panel)
        {
            _DataGridView.Columns.Clear();
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            try
            {
                dttemplate = dttemplate.Select("value='1' OR value='2'").CopyToDataTable();
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

        public static DataTable LOAD_GRID_Panel_CHECK(string FormName, DataGridView _DataGridView, System.Windows.Forms.Panel _Panel)
        {
            _DataGridView.Columns.Clear();
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            try
            {
                dttemplate = dttemplate.Select("value='1' OR value='2'").CopyToDataTable();
            }
            catch { }
            DataGridViewCheckBoxColumn Checkcolume = new DataGridViewCheckBoxColumn();
            Checkcolume.Name = "C";
            Checkcolume.HeaderText = "Chọn";
            Checkcolume.Width = 40;
            Checkcolume.ValueType=typeof(bool);
            //Checkcolume.ThreeState = true;
            //Checkcolume.TrueValue = true;
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

        public static void Create_GRID_CONIG(DataTable dt, string filename)
        {
            DataTable dtname = new DataTable("tablename");
            dtname.Columns.Add("name");
            dtname.Columns.Add("headerText");
            DataRow dr = dtname.NewRow();
            dr["name"] = "tablename";
            dr["headerText"] = "Danh sách tendanhsach";
            dtname.Rows.Add(dr);

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
            ds.Tables.Add(dtname);
            IO.GenXML(filename, ds);

        }

        public static void Create_GRID_CONIG_Fomat(DataTable dt, string filename)
        {
            DataTable dtemp = new DataTable("viewgrid");
            dtemp.Columns.Add("value", typeof(String));
            dtemp.Columns.Add("name", typeof(String));
            dtemp.Columns.Add("headerText");
            dtemp.Columns.Add("BackColor");
            dtemp.Columns.Add("SelectionBackColor");
            dtemp.Columns.Add("Width");
            dtemp.Columns.Add("Thutu");
            dtemp.Columns.Add("Type");
            dtemp.Columns.Add("Format");
            dtemp.Columns.Add("TextAlignment");
            dtemp.Columns.Add("FontBold");
            dtemp.Columns.Add("ForeColor");
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
                r["Type"] = "S";
                r["Format"] = "0";
                r["TextAlignment"] = "Near";
                r["FontBold"] = "False";
                r["ForeColor"] = "Black";
                dtemp.Rows.Add(r);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dtemp);
            IO.GenXML(GD.BBPH.LIB.PATH.ERP_PATH + @"\XMLCONFIG\" + filename + ".xml", ds);
        }

        public static DataTable LOAD_GRID_Panel_CHECK(string FormName, DataGridView _DataGridView, Janus.Windows.UI.Tab.UITabPage _TabPage)
        {
            _DataGridView.Columns.Clear();
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            try
            {
                dttemplate = dttemplate.Select("value='1' OR value='2'").CopyToDataTable();
            }
            catch { }
            DataGridViewCheckBoxColumn Checkcolume = new DataGridViewCheckBoxColumn();            
            Checkcolume.Name = "C";
            Checkcolume.HeaderText = "Chọn";            
            Checkcolume.Width = 40;            
            Checkcolume.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                //_DataGridView.ReadOnly = true;
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
            _TabPage.Controls.Add(_DataGridView);
            return dttemplate;
        }

        public static DataTable LOAD_GRID_UIPanel_Format(string FormName, Janus.Windows.GridEX.GridEX _GridEX, Janus.Windows.UI.Dock.UIPanelInnerContainer _Panel)
        {
            //DmkhachhangManager _TablecolumnManager = new DmkhachhangManager();
            //DataTable dt111 = _TablecolumnManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, GD.BBPH.LIB.PATH.ERP_PATH + @"\XMLCONFIG\FRM_DMKHACHHANG.xml");

            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            try
            {
                dttemplate = dttemplate.Select("value='1' OR value='2'").CopyToDataTable();
            }
            catch { }
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["value"].ToString() == "2")
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
                                              + "<Position>" + i + "</Position><Visible>FALSE</Visible></Column" + i + ">";
                }
                if (dv[i]["name"].ToString().Trim().Equals("C"))
                {
                    CCollection = "<Column" + 0 + " ID='C'>"
                                                   + "<AllowGroup>" + "False" + "</AllowGroup>"
                                                   + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                                   + "<ColumnType>" + "CheckBox" + "</ColumnType>"
                                                   + "<Key>" + "Chon" + "</Key>"
                                                   + "<Position>" + "0" + "</Position>"
                                                   + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                                   + "<ActAsSelector>" + "True" + "</ActAsSelector>"
                                                   + "</Column" + 0 + ">";
                }
                if (dv[i]["Type"].ToString() == "D")
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
                if (dv[i]["Type"].ToString() == "N")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + STATIC_PARAM.FormatNumber_Grid + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
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

        public static DataTable LOAD_JGRID_ROWSELECT_CHECK(string FormName, Janus.Windows.GridEX.GridEX _GridEX, System.Windows.Forms.Panel _Panel,bool check)
        {
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            try
            {
                dttemplate = dttemplate.Select("value='1'").CopyToDataTable();
            }
            catch { }
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            bool ischeck = false;
            int j = 0;
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["name"].ToString().Trim().Equals("C"))
                {
                    if (check)
                    {
                        ischeck = true;
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
                }
                if (!check)
                { j = i; }
                else { j = i; j++; }
                if (dv[i]["name"].ToString().Trim().Equals("Ngayphatsinh") || dv[i]["name"].ToString().Trim().Equals("Ngaytao")
                    || dv[i]["name"].ToString().Trim().Equals("Ngayhachtoan")
                    || dv[i]["name"].ToString().Trim().Equals("Ngaybatdau") || dv[i]["name"].ToString().Trim().Equals("Ngayketthuc")
                    || dv[i]["name"].ToString().Trim().Equals("Datebegin") || dv[i]["name"].ToString().Trim().Equals("Datefinish"))
                {
                    CCollection = CCollection + "<Column" + j + " ID='" + dv[i]["name"].ToString() + "'>"
                                             + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                             + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                             + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                             + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                             + "<FormatString>dd/MM/yyyy</FormatString>"
                                             + "<Position>" + j + "</Position></Column" + j + ">";
                }
                if (dv[i]["name"].ToString().Trim().Equals("TTiencovat") || dv[i]["name"].ToString().Trim().Equals("TTienchuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Ttiencovat") || dv[i]["name"].ToString().Trim().Equals("Ttienchuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Giabinhquancovat") || dv[i]["name"].ToString().Trim().Equals("Giabinhquanchuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Giamuacovat") || dv[i]["name"].ToString().Trim().Equals("Giabanlechuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Giabanlechuavat") || dv[i]["name"].ToString().Trim().Equals("Giabanbuonchuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Giabanbuoncovat") || dv[i]["name"].ToString().Trim().Equals("Giabanlecovat")
                    )
                {
                    CCollection = CCollection + "<Column" + j + " ID='" + dv[i]["name"].ToString() + "'>"
                                             + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                             + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                             + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                             + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                             + "<FormatString>#,##0.0000</FormatString>"
                                             + "<Position>" + j + "</Position></Column" + j + ">";
                }
                if (dv[i]["name"].ToString().Trim().Equals("Soluong") || dv[i]["name"].ToString().Trim().Equals("Tongsoluong") || dv[i]["name"].ToString().Trim().Equals("SL_TON_NHAN")
               || dv[i]["name"].ToString().Trim().Equals("SL_TON_XUAT") || dv[i]["name"].ToString().Trim().Equals("Sltontoida") || dv[i]["name"].ToString().Trim().Equals("Sltontoithieu"))
                {
                    CCollection = CCollection + "<Column" + j + " ID='" + dv[i]["name"].ToString() + "'>"
                                             + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                             + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                             + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                             + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                             + "<FormatString>#,##0</FormatString>"
                                             + "<CellStyle><BackColor>128,128,255</BackColor><ForeColor>Yellow</ForeColor><FontBold>True</FontBold><FontItalic>True</FontItalic><TextAlignment>Center</TextAlignment></CellStyle>"
                                             + "<Position>" + j + "</Position></Column" + j + ">";
                }
                else
                {
                    CCollection = CCollection + "<Column" + j + " ID='" + dv[i]["name"].ToString() + "'>"
                                               + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                               + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                               + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                               + "<Position>" + j + "</Position></Column" + j + ">";
                }                                

            }
            if (check && !ischeck) 
            {
                CCollection = "<Column" + 0 + " ID='C'>"
                                                   + "<AllowGroup>" + "False" + "</AllowGroup>"
                                                   + "<Caption>Chọn</Caption>"
                                                   + "<ColumnType>" + "CheckBox" + "</ColumnType>"
                                                   + "<Key>" + "Chon" + "</Key>"
                                                   + "<Position>" + "0" + "</Position>"
                                                   + "<Width>" + 20 + "</Width>"
                                                   + "<ActAsSelector>" + "True" + "</ActAsSelector>"
                                                   + "</Column" + 0 + ">" + CCollection;
            }
            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            _GridEX.Height = _Panel.Height;
            _GridEX.Width = _Panel.Width;
            _GridEX.RecordNavigator = true;
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
    }
}
