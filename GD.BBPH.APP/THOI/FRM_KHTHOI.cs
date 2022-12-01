﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using GD.BBPH.BLL;
using GD.BBPH.DAL;
using GD.BBPH.DAL.EntityClasses;
using GD.BBPH.DAL.FactoryClasses;
using GD.BBPH.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using GD.BBPH.LIB;
using Janus.Data;
using Janus.Windows.GridEX;
using Janus.Windows.Common;
using GD.BBPH.APP.DANHMUC;

namespace GD.BBPH.APP.THOI
{
    public partial class FRM_KHTHOI : FRM_DMPARENT
    {
        private KehoachthoiManager _KehoachthoiManager = new KehoachthoiManager();
        private KehoachthoiEntity _KehoachthoiEntity = new KehoachthoiEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_LENHSANXUAT = new DataTable();
        private BindingSource BS_LENHSANXUAT = new BindingSource(), BS_DMMAYIN_TEMP = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_LENHSANXUAT = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_DMMAY = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";

        private DataTable DT_KEHOACH = new DataTable(), DT_DMMAY = new DataTable(), DT_DMMAY_TEMP = new DataTable();
        private DateTime Tungay = new DateTime(), Denngay = new DateTime();
        private int songaynghi = 0;

        private int Tongsoca = 0, Tongsomay = 0;
        private decimal Tongnhucauin = 0, LuuTongnhucauin = 0, Tongsongayvuot = 0;
        private DataTable DT_Nhucauin = new DataTable(), DT_DGKQ = new DataTable(), DT_DGKQ_CX = new DataTable();
        Int32 phuongan = 0, Socatrongngay = 0;
        private DataTable DT_DMMANH = new DataTable(), DT_KEHOACH_FULL = new DataTable(), DT_KEHOACH_KQ = new DataTable();
        private DateTime start = new DateTime();
        private DataTable DT_CSMAYIN = new DataTable();

        private DataTable dtKehoachthoi = new DataTable(), DT_DMHANGHOA = new DataTable(), DT_DONDATHANGCHITIET = new DataTable();
        private DataTable dtKehoachdalap = new DataTable();
        private int Lanthaylo = 0;
        private decimal luongphe = 0;
        private bool hetcongsuat = true;
        private bool ngaychuaphatlenh = false, ncdaphatlenh = false;
        private void TEXTBOX_Only_Control(bool _isbool, GD.BBPH.CONTROL.TEXTBOX _Textbox)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(!_isbool, uiPanel1Container, new List<Control>(new Control[] { _Textbox }));
        }

        private void FORM_PROCESS()
        {
            using (System.Windows.Forms.Form f = new System.Windows.Forms.Form())
            using (PictureBox _PictureBox = new PictureBox())
            using (BackgroundWorker worker = new BackgroundWorker())
            {
                Image _image = Image.FromFile(LIB.PATH.BBPH_PATH + @"\IMG\waiting.xml");
                _PictureBox.Image = _image;
                _PictureBox.Width = _image.Width;
                _PictureBox.Height = _image.Height;
                worker.DoWork += delegate
                {
                    if (FUNCTION == "LOAD")
                    {
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_KHTHOI");
                        DT_LENHSANXUAT = LIB.Procedures.Loclenhsanxuat(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG); // LIB.Procedures.Nhucauintheodondathangchitiet(Tungay, Denngay);//.Nhucausoitheokehoachdet(Tungay, Denngay);
                        for (DateTime date = Tungay; date <= Denngay; date = date.AddDays(1))
                        {
                            if (date.DayOfWeek == DayOfWeek.Sunday)
                                songaynghi++;
                        }

                        //Socatrongngay = Convert.ToInt32((Convert.ToInt32(LIB.Procedures.Laygiatrithamso("Socongnhanin"))-4)/2);
                        DT_DMMAY = new DmmayManager().SelectByMadmRDT("THOI"); // LIB.SESSION_START.DT_DMMAY.Select("",DmmayFields.Madm.Name).CopyToDataTable();
                        //DT_DMMANH = LIB.SESSION_START.DT_DMMANH;
                        ////GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(DT_LENHSANXUAT, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KHTHOI.xml");

                        //DT_DMHANGHOA = LIB.SESSION_START.DT_DMHANGHOA;
                        //DT_DONDATHANGCHITIET = LIB.SESSION_START.DT_DONDATHANGCHITIET;
                    }
                };
                worker.RunWorkerCompleted += delegate
                {
                    f.Dispose();   // exit the modal dialog
                };
                f.Load += delegate
                {
                    worker.RunWorkerAsync();
                };
                Point a = new Point(10, 10);
                _PictureBox.Location = a;
                f.Controls.Add(_PictureBox);
                f.Text = "Chờ xử lý";
                f.ShowIcon = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.ShowInTaskbar = false;
                f.ControlBox = false;
                //f.BackColor = Color.Blue;
                f.MaximumSize = new System.Drawing.Size(_PictureBox.Width + 20, _PictureBox.Height + 20);
                f.MinimumSize = new System.Drawing.Size(_PictureBox.Width + 20, _PictureBox.Height + 20);
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog();
            };
        }
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //  ErrorTrapper.ErrorHandler.HandleError(e.Exception);
        }
        public FRM_KHTHOI(string _Tungay, string _Denngay)
        {
            Tungay = Convert.ToDateTime(_Tungay);
            Denngay = Convert.ToDateTime(_Denngay);

            InitializeComponent();

            GRID_DMMAY.FormattingRow += GRID_DMMAY_FormattingRow;
            GRID_DMMAY.CellEdited += new ColumnActionEventHandler(GRID_DMMAY_CellEdited);
            GRID_DMMAY.Click += GRID_DMMAY_Click;

            //KehoachthoiManager _KehoachthoiManager = new KehoachthoiManager();
            //DataTable dt111 = _KehoachthoiManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(DT_LENHSANXUAT, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KHTHOI.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_LENHSANXUAT.xml", GRID_LENHSANXUAT, uiPanel0Container);
            //GRID_LENHSANXUAT.RootTable.Groups.Add(GRID_LENHSANXUAT.Tables[0].Columns[KehoachthoiFields.Thang.Name]);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_LENHSANXUAT);
            BS_LENHSANXUAT = new BindingSource();
            BS_LENHSANXUAT.DataSource = Source_View;
            GRID_LENHSANXUAT.DataSource = BS_LENHSANXUAT;
            BS_LENHSANXUAT.CurrentChanged += new EventHandler(BS_LENHSANXUAT_CurrentChanged);
            BS_LENHSANXUAT_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }
        void BS_LENHSANXUAT_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_LENHSANXUAT.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_LENHSANXUAT.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[LenhsanxuatFields.Solenhsx.Name].ToString();

                    txt_MADONHANG.Text = _Rowview.Row[LenhsanxuatFields.Madon.Name].ToString();
                    txt_TENKHACH.Text = _Rowview.Row[LenhsanxuatFields.Tenkhach.Name].ToString();
                    txt_MAHANG.Text = _Rowview.Row[LenhsanxuatFields.Masp.Name].ToString();
                    //txt_MAUIN.Text = _Rowview.Row[LenhsanxuatFields.Mauin.Name].ToString();
                    //txt_MAMANH.Text = _Rowview.Row[LenhsanxuatFields.Mamanh.Name].ToString();
                    txt_NGAYGIAO.Text = _Rowview.Row[LenhsanxuatFields.Ngaygiao.Name].ToString();
                    try { txt_SOLUONG.Text = double.Parse(_Rowview.Row[LenhsanxuatFields.Soluong.Name].ToString()).ToString("#,###", new System.Globalization.CultureInfo("vi-VN")); }
                    catch { }

                    //txt_MAMANH_Validating(new object(), new CancelEventArgs());

                    SHOWGRID(MAHIEU_PK);
                }
                else
                {
                    SHOWGRID("");
                    GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_LENHSANXUAT_CurrentChanged"); }
        }
        private void SHOWGRID(string MAHIEU_PK)
        {
            #region Tạo bảng dữ liệu
            DT_DMMAY_TEMP = LIB.Procedures.Ngaysudungmay(Tungay, Denngay, "TH", "");
            DT_DMMAY_TEMP.Columns.Add("Congsuat", Type.GetType("System.Decimal"));
            DT_DMMAY_TEMP.Columns.Add("Congsuattrong", Type.GetType("System.Decimal"));
            for (DateTime date = Tungay; date <= Denngay; date = date.AddDays(1))
            {
                string sDate = date.ToString("dd/MM");
                DataColumn dc1 = new DataColumn();
                dc1.ColumnName = sDate + "_K1";
                dc1.DataType = System.Type.GetType("System.Decimal");
                DT_DMMAY_TEMP.Columns.Add(dc1);
                DataColumn dc2 = new DataColumn();
                dc2.ColumnName = sDate + "_K2";
                dc2.DataType = System.Type.GetType("System.Decimal");
                DT_DMMAY_TEMP.Columns.Add(dc2);
            }
            for (DateTime date = Tungay; date <= Denngay; date = date.AddDays(1))
            {
                string sDate = date.ToString("dd/MM");
                foreach (DataRow dr in DT_DMMAY_TEMP.Rows)
                {
                    dr[sDate + "_K1"] = false;
                    dr[sDate + "_K2"] = false;
                }
            }
            #endregion

            #region Điền công suất và công suất trống 
            if (!string.IsNullOrEmpty(MAHIEU_PK))
            {
                foreach (DataRow dr in DT_DMMAY_TEMP.Rows)
                {
                    try
                    {
                        Decimal _tocdo = 0, _congsuat = 0;
                        _tocdo = LIB.Procedures.fTinhtocdomay(dr[DmmayFields.Mamay.Name].ToString(), txt_MAHANG.Text);
                        _congsuat = _tocdo * 60 * 12;//-----Công suất của 1 ca
                        dr["Congsuattrong"] = _congsuat * Convert.ToDecimal(dr["Catrong"]);
                    }
                    catch { }
                }
            }
            #endregion

            #region Ke hoach san xuat soi theo loai soi
            Decimal _tongcongsuat = 0;
            DataTable dtKH = new KehoachthoiManager().SelectBySolenhsxRDT(MAHIEU_PK);
            if (dtKH.Rows.Count > 0)
            {
                DataRow[] arrDr = dtKH.Select(KehoachthoiFields.Ngaychay.Name + ">='" + Tungay.ToString() + "' And "
                    + KehoachthoiFields.Ngaychay.Name + "<='" + Denngay.ToString() + "'");
                if (arrDr.Length > 0)
                {
                    dtKH = arrDr.CopyToDataTable();
                    if (dtKH.Rows.Count > 0)
                    {
                        foreach (DataRow dr in DT_DMMAY_TEMP.Rows)
                        {
                            DataRow[] arrDrMay = dtKH.Select(KehoachthoiFields.Mamay.Name + "='" + dr[DmmayFields.Mamay.Name].ToString() + "'");
                            if (arrDrMay.Length > 0)
                            {
                                foreach (DataRow drMay in arrDrMay)
                                {
                                    decimal kluong = 0;
                                    try { kluong = Convert.ToDecimal(drMay[KehoachthoiFields.Sokg.Name].ToString()); }
                                    catch { }
                                    dr[Convert.ToDateTime(drMay[KehoachthoiFields.Ngaychay.Name].ToString()).ToString("dd/MM")
                                        + (drMay[KehoachthoiFields.Ca.Name].ToString() == "1" ? "_K1" : "_K2")] = kluong;
                                    _tongcongsuat += kluong;
                                }
                            }
                        }
                    }
                }
            }
            try { txt_SLDUKIEN.Text = double.Parse(_tongcongsuat.ToString()).ToString("#,###", new System.Globalization.CultureInfo("vi-VN")); }
            catch { }
            #endregion

            #region Cấu hình Grid
            GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(DT_DMMAY_TEMP, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KHTHOI_D_" + LIB.SESSION_START.TS_USER_LOGIN + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KHTHOI_D_" + LIB.SESSION_START.TS_USER_LOGIN + ".xml", GRID_DMMAY, pne_CHITIET);
            //GRID_DMMAY.RootTable.Groups.Add(GRID_DMMAY.Tables[0].Columns[DmmayFields.Manhamay.Name]);
            GRID_DMMAY.RootTable.Columns[DmmayFields.Mamay.Name].Visible = false;
            //GRID_DMMAY.RootTable.Columns[DmmayFields.Manhamay.Name].Visible = false;
            //GRID_DMMAY.RootTable.Columns[DmmayFields.Nhamay.Name].Visible = false;
            //GRID_DMMAY.RootTable.Columns[DmmayFields.Vitri.Name].Visible = false;
            GRID_DMMAY.RootTable.Columns[DmmayFields.Madm.Name].Visible = false;
            GRID_DMMAY.RootTable.Columns[DmmayFields.Tenmay.Name].Caption = "Máy"; 
            //GRID_DMMAY.RootTable.Columns[DmmayFields.Tendongmay.Name].Caption = "Dòng máy";
            GRID_DMMAY.RootTable.Columns[DmmayFields.Tenmay.Name].EditType = EditType.NoEdit;
            //GRID_DMMAY.RootTable.Columns[DmmayFields.Tendongmay.Name].EditType = EditType.NoEdit;
            GRID_DMMAY.RootTable.Columns[DmmayFields.Tenmay.Name].Width = 80;
            //GRID_DMMAY.RootTable.Columns[DmmayFields.Tendongmay.Name].Width = 80;
            GRID_DMMAY.RootTable.Columns["Catrong"].Caption = "Ca trống";
            GRID_DMMAY.RootTable.Columns["Congsuat"].Caption = "Công suất";
            GRID_DMMAY.RootTable.Columns["Congsuattrong"].Caption = "Công suất trống";
            GRID_DMMAY.RootTable.Columns["Catrong"].EditType = EditType.NoEdit;
            GRID_DMMAY.RootTable.Columns["Congsuat"].EditType = EditType.NoEdit;
            GRID_DMMAY.RootTable.Columns["Congsuattrong"].EditType = EditType.NoEdit;
            GRID_DMMAY.RootTable.Columns["Catrong"].Width = 55;
            GRID_DMMAY.RootTable.Columns["Congsuat"].Width = 60;
            GRID_DMMAY.RootTable.Columns["Congsuattrong"].Width = 90;
            GRID_DMMAY.DataSource = DT_DMMAY_TEMP;
            GRID_DMMAY.FilterMode = FilterMode.None;
            GRID_DMMAY.GroupByBoxVisible = false;
            for (DateTime date = Tungay; date <= Denngay; date = date.AddDays(1))
            {
                string sDate = date.ToString("dd/MM");
                GRID_DMMAY.RootTable.Columns[sDate + "_K1"].EditType = EditType.TextBox;
                GRID_DMMAY.RootTable.Columns[sDate + "_K1"].ColumnType = ColumnType.Text;
                GRID_DMMAY.RootTable.Columns[sDate + "_K1"].Width = 60;
                GRID_DMMAY.RootTable.Columns[sDate + "_K1"].FormatString = "#,###";

                GRID_DMMAY.RootTable.Columns[sDate + "_K2"].EditType = EditType.TextBox;
                GRID_DMMAY.RootTable.Columns[sDate + "_K2"].ColumnType = ColumnType.Text;
                GRID_DMMAY.RootTable.Columns[sDate + "_K2"].Width = 60;
                GRID_DMMAY.RootTable.Columns[sDate + "_K2"].FormatString = "#,###";

                if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    Janus.Windows.GridEX.GridEXFormatStyle style1 = new GridEXFormatStyle();
                    style1.BackColor = Color.Pink; //Fuchsia;
                    GRID_DMMAY.RootTable.Columns[sDate + "_K1"].CellStyle = style1;
                    //GRID_DMMAY.RootTable.Columns[sDate + "_K1"].EditType = EditType.NoEdit;
                    Janus.Windows.GridEX.GridEXFormatStyle style2 = new GridEXFormatStyle();
                    style2.BackColor = Color.Pink; //Fuchsia;
                    GRID_DMMAY.RootTable.Columns[sDate + "_K2"].CellStyle = style2;
                    GRID_DMMAY.RootTable.Columns[sDate + "_K2"].EditType = EditType.NoEdit;
                }
                //else
                //{
                //    Janus.Windows.GridEX.GridEXFormatStyle style1 = new GridEXFormatStyle();
                //    style1.BackColor = Color.White; 
                //    GRID_DMMAY.RootTable.Columns[sDate + "_K1"].CellStyle = style1;
                //    Janus.Windows.GridEX.GridEXFormatStyle style2 = new GridEXFormatStyle();
                //    style2.BackColor = Color.White; 
                //    GRID_DMMAY.RootTable.Columns[sDate + "_K2"].CellStyle = style2;
                //}
            }
            #endregion

            //DT_KEHOACH_FULL = new KehoachthoiManager().SelectByCondition(Tungay, Denngay);
        }

        #region Event GRID_DMMAY
        private void GRID_DMMAY_Click(object sender, EventArgs e)
        {
            try
            {
                Color currentColor = GRID_DMMAY.CurrentRow.Cells[GRID_DMMAY.CurrentColumn.Key].FormatStyle.BackColor;
                GRID_DMMAY.CurrentRow.Cells[GRID_DMMAY.CurrentColumn.Key].FormatStyle.BackColor = Color.Green;

                string sCol = GRID_DMMAY.CurrentColumn.Key;
                DateTime _Ngay = Convert.ToDateTime(sCol.Substring(0, 5) + "/" + Tungay.ToString("yyyy"));
                int _Ca = Convert.ToInt32(sCol.Substring(sCol.Length - 1));
                string _May = GRID_DMMAY.CurrentRow.Cells[DmmayFields.Mamay.Name].Value.ToString();

                //FRM_VIEWKHIN frm = new FRM_VIEWKHIN(_Ngay, _Ca, _May);
                //frm.StartPosition = FormStartPosition.Manual;
                //frm.Left = Cursor.Position.X + frm.Width + GRID_DMMAY.CurrentColumn.Width < Screen.PrimaryScreen.WorkingArea.Width
                //    ? Cursor.Position.X + GRID_DMMAY.CurrentColumn.Width
                //    : Cursor.Position.X - frm.Width - GRID_DMMAY.CurrentColumn.Width;
                //frm.Top = Cursor.Position.Y + frm.Height < Screen.PrimaryScreen.WorkingArea.Height
                //    ? Cursor.Position.Y
                //    : Cursor.Position.Y - frm.Height;
                //frm.ShowDialog();

                GRID_DMMAY.CurrentRow.Cells[GRID_DMMAY.CurrentColumn.Key].FormatStyle.BackColor = currentColor;
            }
            catch { }
        }

        private void GRID_DMMAY_FormattingRow(object sender, RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.Cells[DmmayFields.Mamay.Name] == null || string.IsNullOrEmpty(e.Row.Cells[DmmayFields.Mamay.Name].Text)) return;
                string s_mamayin = e.Row.Cells[DmmayFields.Mamay.Name].Value.ToString();

                if (DT_KEHOACH_FULL.Rows.Count > 0)
                {
                    DataRow[] arrDr = DT_KEHOACH_FULL.Select(KehoachthoiFields.Mamay.Name + "='" + s_mamayin + "'");
                    if (arrDr.Length > 0)
                    {
                        foreach (DataRow dr in arrDr)
                        {
                            string sDate = Convert.ToDateTime(dr[KehoachthoiFields.Ngaychay.Name].ToString()).ToString("dd/MM");
                            if (dr[KehoachthoiFields.Solenhsx.Name].ToString() != MAHIEU_PK)
                            {
                                Janus.Windows.GridEX.GridEXFormatStyle style = new GridEXFormatStyle();
                                style.ForeColor = Color.Black;
                                style.BackColor = Color.CornflowerBlue;
                                e.Row.Cells[sDate + (dr[KehoachthoiFields.Ca.Name].ToString() == "1" ? "_K1" : "_K2")].FormatStyle = style;
                            }
                            else
                            {
                                Janus.Windows.GridEX.GridEXFormatStyle style = new GridEXFormatStyle();
                                e.Row.Cells[sDate + (dr[KehoachthoiFields.Ca.Name].ToString() == "1" ? "_K1" : "_K2")].FormatStyle = style;
                            }
                        }
                    }
                }
            }
            catch { }
        }
        private void GRID_DMMAY_FormattingRow()
        {
            try
            {
                for (int i = 0; i < GRID_DMMAY.RowCount; i++)
                {
                    GridEXRow _GridEXRow = GRID_DMMAY.GetRow(i);
                    for (DateTime date = Tungay; date <= Denngay; date = date.AddDays(1))
                    {
                        string sDate = date.ToString("dd/MM");
                        if(date.DayOfWeek != DayOfWeek.Sunday)
                        {
                            Janus.Windows.GridEX.GridEXFormatStyle style = new GridEXFormatStyle();
                            style.ForeColor = Color.Black;
                            style.BackColor = Color.White;
                            _GridEXRow.Cells[sDate + "_K1"].FormatStyle = _GridEXRow.Cells[sDate + "_K2"].FormatStyle = style;
                        }
                        else
                        {
                            Janus.Windows.GridEX.GridEXFormatStyle style = new GridEXFormatStyle();
                            style.BackColor = Color.Pink;
                            _GridEXRow.Cells[sDate + "_K1"].FormatStyle = _GridEXRow.Cells[sDate + "_K2"].FormatStyle = style;
                        }
                    }

                    string s_mamayin = _GridEXRow.Cells[DmmayFields.Mamay.Name].Value.ToString();
                    if (DT_KEHOACH_FULL.Rows.Count > 0)
                    {
                        DataRow[] arrDr = DT_KEHOACH_FULL.Select(KehoachthoiFields.Mamay.Name + "='" + s_mamayin + "'");
                        if (arrDr.Length > 0)
                        {
                            foreach (DataRow dr in arrDr)
                            {
                                string sDate = Convert.ToDateTime(dr[KehoachthoiFields.Ngaychay.Name].ToString()).ToString("dd/MM");
                                if (dr[KehoachthoiFields.Solenhsx.Name].ToString() != MAHIEU_PK)
                                {
                                    Janus.Windows.GridEX.GridEXFormatStyle style = new GridEXFormatStyle();
                                    style.ForeColor = Color.Black;
                                    style.BackColor = Color.CornflowerBlue;
                                    _GridEXRow.Cells[sDate + (dr[KehoachthoiFields.Ca.Name].ToString() == "1" ? "_K1" : "_K2")].FormatStyle = style;
                                }
                            }
                        }
                    }
                }
            }
            catch { }
        }
        //---cos ve on
        void GRID_DMMAY_CellUpdated(object sender, ColumnActionEventArgs e)
        {
            //Tinhkhoiluongdukien();
        }
        //---cos ve on
        void GRID_DMMAY_CellEdited(object sender, ColumnActionEventArgs e)
        {
            try
            {
                //----Tinh khoi luong da sap xep trong ca
                string sngay = e.Column.DataMember.Substring(0, 5) + "/" + LIB.SESSION_START.TS_NGAYLAMVIEC.Year.ToString();
                DateTime ngay = Convert.ToDateTime(sngay);
                string s_mamayin = GRID_DMMAY.CurrentRow.Cells[DmmayFields.Mamay.Name].Value.ToString();
                decimal congsuat = Convert.ToDecimal(GRID_DMMAY.CurrentRow.Cells["Congsuat"].Value.ToString());
                decimal kluongdachay = 0;
                decimal gtri = Convert.ToDecimal(GRID_DMMAY.CurrentRow.Cells[e.Column.DataMember].Value.ToString());

                if (DT_KEHOACH_FULL.Rows.Count > 0)
                {
                    DataRow[] arrDr = DT_KEHOACH_FULL.Select(KehoachthoiFields.Mamay.Name + "='" + s_mamayin + "' And "
                        + KehoachthoiFields.Ngaychay.Name + "='" + sngay + "' And "
                        + KehoachthoiFields.Ca.Name + "='" + e.Column.DataMember.Substring(7, 1) + "' And "
                        + KehoachthoiFields.Solenhsx.Name + "<>'" + MAHIEU_PK + "'");
                    if (arrDr.Length > 0)
                    {
                        foreach (DataRow dr in arrDr)
                        {
                            try { kluongdachay += Convert.ToDecimal(dr[KehoachthoiFields.Sokg.Name].ToString()); }
                            catch { }
                        }
                    }
                }

                if (kluongdachay >= congsuat)
                {
                    //----da sap xep du cong suat, chuyen o du lieu ve 0
                    MessageBox.Show("Máy đã được bố trí sử dụng hết công suất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (gtri > congsuat - kluongdachay)
                {
                    //----thong bao khong vuot qua congsuat-kluongdachay
                    MessageBox.Show("Không nhập giá trị vượt " + (congsuat - kluongdachay).ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Tinhkhoiluongdukien();
                }
            }
            catch { }
        }
        void Tinhkhoiluongdukien()
        {
            try
            {
                GRID_DMMAY.Update();
                Decimal _tongcongsuat = 0;
                for (int i = 0; i < GRID_DMMAY.RowCount; i++)
                {
                    for (DateTime date = Tungay; date <= Denngay; date = date.AddDays(1))
                    {
                        string sDate = date.ToString("dd/MM");
                        try { _tongcongsuat += Convert.ToDecimal(GRID_DMMAY.GetRow(i).Cells[sDate + "_K1"].Value); }
                        catch { }
                        try { _tongcongsuat += Convert.ToDecimal(GRID_DMMAY.GetRow(i).Cells[sDate + "_K2"].Value); }
                        catch { }
                    }
                }
                txt_SLDUKIEN.Text = double.Parse(_tongcongsuat.ToString()).ToString("#,###", new System.Globalization.CultureInfo("vi-VN"));
            }
            catch { }
        }
        #endregion

        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            try
            {
                //FRM_LUACHONNGAYCHUAPHATLENH frm = new IN.FRM_LUACHONNGAYCHUAPHATLENH();
                //frm.ShowDialog();
                //if (frm._DialogResult == DialogResult.No) return;
                //ngaychuaphatlenh = frm.Ngaychuaphatlenh;
                //ncdaphatlenh = frm.Ncdaphatlenh;

                //Cursor _cur = Cursor.Current;
                //Cursor.Current = Cursors.WaitCursor;
                //if (Lapkehoachin())
                //    BS_LENHSANXUAT_CurrentChanged(new object(), new EventArgs());

                //Cursor.Current = _cur;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        
        #region Lập kế hoạch in cho đơn đặt hàng
        private bool Lapkehoachin()
        {
            try
            {
                ////----Tinh Tongsoca, Tongsomay, Tongnhucauin (Nhucausoitheokehoachdet), Tao bang Kehoachsanxuatsoi
                //dtKehoachthoi = new DataTable();
                ////dtKehoachthoi.Columns.Add(KehoachthoiFields.Id.Name, Type.GetType("System.Int64"));
                //dtKehoachthoi.Columns.Add(KehoachthoiFields.Ca.Name, Type.GetType("System.Int32"));
                //dtKehoachthoi.Columns.Add(KehoachthoiFields.Mamay.Name, Type.GetType("System.String"));
                //dtKehoachthoi.Columns.Add(KehoachthoiFields.Solenhsx.Name, Type.GetType("System.Int64"));
                //dtKehoachthoi.Columns.Add(KehoachthoiFields.Sokg.Name, Type.GetType("System.Int32"));
                //dtKehoachthoi.Columns.Add(DonhangDFields.Masp.Name, Type.GetType("System.String"));
                //dtKehoachthoi.Columns.Add(DmhangFields.Makhach.Name, Type.GetType("System.String"));

                //DT_Nhucauin = LIB.Procedures.Nhucaulapkehoachintheodondathangchitiet(Tungay, Denngay, ncdaphatlenh);
                //DT_Nhucauin.Columns.Add("Dasanxuat", Type.GetType("System.Decimal"));
                //foreach (DataRow dr in DT_Nhucauin.Rows)
                //{
                //    dr["Dasanxuat"] = 0;
                //    Tongnhucauin += Convert.ToDecimal(dr["Soluong"].ToString()) > 0 ? Convert.ToDecimal(dr["Soluong"].ToString()) : 0;
                //}
                //Tongsomay = DT_DMMAY_TEMP.Rows.Count;
                //Tongsoca = ((Denngay - Tungay).Days + 1) * 2;
                ////-----Tính công suất máy sợi cho từng loại sợi thuộc kế hoạch dệt
                //DT_CSMAYIN = LIB.Procedures.Congsuatmayinchotungmauin(Tungay, Denngay);
                ////-----Kế hoạch in đã lập
                //dtKehoachdalap = LIB.Procedures.Kehoachthoidalap(Tungay, Denngay);// new KehoachthoiManager().SelectByCondition(Tungay, Denngay);
                //foreach(DataRow dr in dtKehoachdalap.Rows)
                //{
                //    DataRow drKhin = dtKehoachthoi.NewRow();
                //    //drKhin[KehoachthoiFields.Id.Name] = dr[KehoachthoiFields.Id.Name];
                //    drKhin[KehoachthoiFields.Ca.Name] = (Convert.ToDateTime(dr[KehoachthoiFields.Ngaychay.Name].ToString())-Tungay).Days*2 + Convert.ToInt32(dr[KehoachthoiFields.Ca.Name].ToString())-1;
                //    drKhin[KehoachthoiFields.Mamay.Name] = dr[KehoachthoiFields.Mamay.Name];
                //    drKhin[KehoachthoiFields.Solenhsx.Name] = dr[KehoachthoiFields.Solenhsx.Name];
                //    drKhin[KehoachthoiFields.Sokg.Name] = dr[KehoachthoiFields.Sokg.Name];
                //    drKhin[DonhangDFields.Masp.Name] = dr[DonhangDFields.Masp.Name];
                //    drKhin[DmhangFields.Makhach.Name] = dr[DmhangFields.Makhach.Name];
                //    dtKehoachthoi.Rows.Add(drKhin);
                //}

                ////-----Phục vụ đánh giá kết quả----------------------
                //Tongsongayvuot = decimal.MaxValue;
                //LuuTongnhucauin = Tongnhucauin;
                //DT_DGKQ = DT_Nhucauin.Copy(); 
                //DT_DGKQ.Columns.Add("Ngayht", Type.GetType("System.DateTime"));

                //start = DateTime.Now;
                //Cursor _cur = Cursor.Current;
                //Cursor.Current = Cursors.WaitCursor;
                //Duyetkehoachin(0, 0);
                //Cursor.Current = _cur;

                //#region Ghi kết quả
                //if (Tongsongayvuot < Int32.MaxValue)
                //{
                //    if (MessageBox.Show( (hetcongsuat?"Toàn bộ công suất các máy đã được bố trí.\n":"") 
                //        + "Số ngày vượt kế hoạch giao hàng là: " + Convert.ToInt32(Tongsongayvuot).ToString() + " (ngày)." + '\n'
                //        //+ "Lượng phế là: " + Convert.ToInt32(luongphe).ToString() + " (kg)." + '\n'
                //        + "Là phương án tối ưu trong " + phuongan.ToString() + " phương án.", "Lưu kế hoạch in", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                //           System.Windows.Forms.DialogResult.Yes)
                //    {
                //        try
                //        {
                //            foreach (DataRow dr in DT_KEHOACH_KQ.Rows)
                //            {
                //                if (dtKehoachdalap.Select(KehoachthoiFields.Ngaychay.Name + "='" + Tungay.AddDays(Convert.ToInt32(dr[KehoachthoiFields.Ca.Name].ToString()) / 2).ToString()
                //                    + "' And " + KehoachthoiFields.Ca.Name + "='" + Convert.ToInt32(Convert.ToInt32(dr[KehoachthoiFields.Ca.Name].ToString()) % 2 + 1)
                //                    + "' And " + KehoachthoiFields.Mamay.Name + "='" + dr[KehoachthoiFields.Mamay.Name].ToString()
                //                    + "' And " + KehoachthoiFields.Solenhsx.Name + "='" + dr[KehoachthoiFields.Solenhsx.Name].ToString() + "'").Length == 0)
                //                {
                //                    KehoachthoiEntity _KehoachthoiEntity = new KehoachthoiEntity();
                //                    _KehoachthoiEntity.Ngaychay = Tungay.AddDays(Convert.ToInt32(dr[KehoachthoiFields.Ca.Name].ToString()) / 2);
                //                    _KehoachthoiEntity.Ca = Convert.ToInt32(Convert.ToInt32(dr[KehoachthoiFields.Ca.Name].ToString()) % 2 + 1);
                //                    _KehoachthoiEntity.Mamayin = dr[KehoachthoiFields.Mamay.Name].ToString();
                //                    _KehoachthoiEntity.Mauin = DT_Nhucauin.Select(DonhangDFields.Id.Name + "='"+dr[KehoachthoiFields.Solenhsx.Name].ToString()+"'")[0][KehoachthoiFields.Mamang.Name].ToString();
                //                    _KehoachthoiEntity.Mamanh = DT_Nhucauin.Select(DonhangDFields.Id.Name + "='" + dr[KehoachthoiFields.Solenhsx.Name].ToString() + "'")[0][KehoachthoiFields.Mamanh.Name].ToString();
                //                    _KehoachthoiEntity.Madonhangct = Convert.ToInt64(dr[KehoachthoiFields.Solenhsx.Name].ToString());
                //                    _KehoachthoiEntity.Sldukien = Convert.ToInt32(dr[KehoachthoiFields.Sokg.Name].ToString());

                //                    new KehoachthoiManager().Insert(_KehoachthoiEntity);
                //                }
                //            }
                //            //------Xóa kế hoạch chưa phát lệnh trước ngày bắt đầu lập
                //            new KehoachthoiManager().DeleteByChuaphatlenhtruocngay(Tungay);

                //            GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                //            return true;
                //        }
                //        catch (Exception ex){ MessageBox.Show("Lỗi ghi kế hoạch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                //    }
                //}
                //#endregion

            }
            catch { MessageBox.Show("Lỗi lập kế hoạch in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            return false;
        }
        private void Danhgiaketqua()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DT_DGKQ.Copy();
                decimal songayvuot = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    string sMadonhangct = dr[DonhangDFields.Id.Name].ToString();
                    DateTime _Ngaygiao;
                    string sNgaygiao = dr[KehoachthoiFields.Ngaygiao.Name].ToString();
                    if (string.IsNullOrEmpty(sNgaygiao)) _Ngaygiao = Denngay;
                    else _Ngaygiao = Convert.ToDateTime(sNgaygiao).AddDays(-4);
                    DataRow[] arrDr = dtKehoachthoi.Select(KehoachthoiFields.Solenhsx.Name + "='" + sMadonhangct + "'", KehoachthoiFields.Ca.Name + " Desc");
                    if (arrDr.Length > 0)
                    {
                        DateTime _Ngayht = Tungay.AddDays(Convert.ToInt32(arrDr[0][KehoachthoiFields.Ca.Name].ToString())/2);
                        dr["Ngayht"] = _Ngayht;
                        songayvuot += _Ngayht > _Ngaygiao ? (_Ngayht-_Ngaygiao).Days * Convert.ToDecimal(dr["Soluong"].ToString())/LuuTongnhucauin : 0;
                    }
                }

                if (songayvuot < Tongsongayvuot)
                {
                    Tongsongayvuot = songayvuot;
                    DT_KEHOACH_KQ = dtKehoachthoi.Copy();
                }
            }
            catch { MessageBox.Show("Lỗi đánh giá kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private decimal Tinhluongphe()
        {
            try
            {
                Lanthaylo = 0;
                foreach (DataRow dr in DT_DMMAY_TEMP.Rows)
                {
                    string soiluu = "", sNgay = "", sMay = "", sCa = "";
                    for (int Ca = 0; Ca < Tongsoca; Ca++)
                    {
                        sNgay = Tungay.AddDays(Ca / 2).ToString("dd/MM/yyyy");
                        sCa = Convert.ToInt32(Ca % 2 + 1).ToString();
                        sMay = dr[DmmayFields.Mamay.Name].ToString();

                        DataRow[] arrDr = dtKehoachthoi.Select(KehoachthoiFields.Ngaychay.Name + "='" + sNgay + "' And " + KehoachthoiFields.Ca.Name + "='" + sCa + "' And "
                            + KehoachthoiFields.Mamay.Name + "='" + sMay + "'");
                        if (arrDr.Length > 0)
                        {
                            if (arrDr[0][KehoachthoiFields.Mamang.Name].ToString() != soiluu)
                            {
                                Lanthaylo++;
                                soiluu = arrDr[0][KehoachthoiFields.Mamang.Name].ToString();
                            }
                        }
                    }
                }
            }
            catch { MessageBox.Show("Lỗi tính lượng phế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            return Lanthaylo * 150;
        }
        private void Duyetkehoachin(int Ca, int May)
        {
            try
            {
                if (Tongsongayvuot == 0 || (DateTime.Now - start).Minutes >= LIB.SESSION_START.TS_PHUTLAPKH) return;

                string sMay = "";
                bool ktra = true;
                if (May < Tongsomay)
                    sMay = DT_DMMAY_TEMP.Rows[May][DmmayFields.Mamay.Name].ToString();//May.ToString().PadLeft(2,'0');
                if (Tungay.AddDays(Ca / 2).DayOfWeek == DayOfWeek.Sunday && Convert.ToInt32(Ca % 2 + 1).ToString() == "2")
                    Duyetkehoachin(Ca + 1, 0);

                if (Tongnhucauin <= 0)
                {
                    hetcongsuat = false;
                    phuongan++;
                    Danhgiaketqua();
                }
                else if (May == Tongsomay)
                {
                    if (Ca >= Tongsoca - 1)
                    {
                        phuongan++;
                        Danhgiaketqua();
                    }
                    else
                    {
                        //-----Duyệt ca tiếp, nếu không thỏa mãn thì sao?
                        //if (Ktradkuutien(dtKehoachthoi, Ca))
                        Duyetkehoachin(Ca + 1, 0);
                    }
                }
                else if (Ktradkmaychay(Ca, sMay, May))
                {
                    ktra = true;
                    foreach (DataRow dr in DT_Nhucauin.Rows)
                    {
                        decimal _Csdabotri = 0;
                        if (Ktradksapxep(dr, Ca, May, ref _Csdabotri))
                        {
                            ktra = false;
                            //-----Thông tin tính Kldukien
                            Decimal _Congsuat = Convert.ToDecimal(DT_CSMAYIN.Rows[May][dr[DonhangDFields.Masp.Name].ToString()].ToString()) - _Csdabotri;// Convert.ToDecimal(DT_DMMAY_TEMP.Rows[May][CongsuatmaysoiFields.Congsuat.Name].ToString());
                            Decimal _Nhucauconlai = Convert.ToDecimal(dr["Soluong"].ToString()) - Convert.ToDecimal(dr["Dasanxuat"].ToString());
                            Decimal _Kldukien = 0;

                            if (_Congsuat < _Nhucauconlai) _Kldukien = _Congsuat;
                            else _Kldukien = _Nhucauconlai;

                            DataRow drKehoachthoi = dtKehoachthoi.NewRow();
                            //drKehoachthoi[KehoachthoiFields.Ngaychay.Name] = sNgay;
                            drKehoachthoi[KehoachthoiFields.Ca.Name] = Ca;// sCa;
                            drKehoachthoi[KehoachthoiFields.Mamay.Name] = sMay;
                            drKehoachthoi[KehoachthoiFields.Solenhsx.Name] = dr[DonhangDFields.Id.Name];
                            drKehoachthoi[DonhangDFields.Masp.Name] = dr[DonhangDFields.Masp.Name];
                            drKehoachthoi[DmhangFields.Makhach.Name] = dr[DmhangFields.Makhach.Name];
                            drKehoachthoi[KehoachthoiFields.Sokg.Name] = _Kldukien;
                            dtKehoachthoi.Rows.Add(drKehoachthoi);
                            dr["Dasanxuat"] = Convert.ToDecimal(dr["Dasanxuat"].ToString()) + _Kldukien;
                            Tongnhucauin -= _Kldukien;

                            if (_Kldukien == _Congsuat)
                                Duyetkehoachin(Ca, May + 1);
                            else
                                Duyetkehoachin(Ca, May);

                            Tongnhucauin += _Kldukien;
                            dr["Dasanxuat"] = Convert.ToDecimal(dr["Dasanxuat"].ToString()) - _Kldukien;
                            dtKehoachthoi.Rows.Remove(dtKehoachthoi.Select(KehoachthoiFields.Ca.Name + "='" + Ca + "' And " + KehoachthoiFields.Mamay.Name + "='" + sMay + "' And "
                                + KehoachthoiFields.Solenhsx.Name + "='" + dr[DonhangDFields.Id.Name].ToString() + "'")[0]);
                        }
                    }
                    if (ktra) Duyetkehoachin(Ca, May + 1);
                }
                else
                    Duyetkehoachin(Ca, May + 1);
            }
            catch { MessageBox.Show("Lỗi duyệt kế hoạch in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private bool Ktradksapxep(DataRow dr, int Ca, int May, ref decimal _Csdabotri)
        {
            try
            {
                //string sMay = "", sDongmay = "";
                //string sFillter = "";
                ////sFillter = "(" + KehoachthoiFields.Ca.Name + "='" + ((int)(Ca / 2))*2 + "' Or " + KehoachthoiFields.Ca.Name + "='" + (((int)(Ca / 2))*2 + 1) + "') ";
                //sFillter = KehoachthoiFields.Ca.Name + "='" + Ca + "'";
                //string sFilterNgay = "";
                //sFilterNgay = KehoachthoiFields.Ca.Name + "<='" + Ca + "' And " + KehoachthoiFields.Ca.Name + ">='"
                //    + (Ca - 3 < 0 ? "0" : (Ca - 3).ToString()) + "'";
                //sMay = DT_DMMAY_TEMP.Rows[May][DmmayFields.Mamay.Name].ToString();
                //sDongmay = DT_DMMAY_TEMP.Rows[May][DmmayFields.Madm.Name].ToString();

                //Decimal _Nhucauconlai = Convert.ToDecimal(dr["Soluong"].ToString()) - Convert.ToDecimal(dr["Dasanxuat"].ToString());
                //string sMadonhangct = dr[DonhangDFields.Id.Name].ToString();
                //string sMahang = dr[DonhangDFields.Masp.Name].ToString();

                ////----Đã sản xuất xong không sắp xếp chạy
                //if (_Nhucauconlai <= 0) return false;
                ////----Công suất = 0 không chạy
                //decimal _Congsuat = LIB.ConvertString.NumbertoDB(DT_CSMAYIN.Rows[May][dr[DonhangDFields.Masp.Name].ToString()].ToString());
                //if (_Congsuat == 0) return false;
                //else
                //{
                //    //-----Đã bố trí hết công suất không chạy tiếp
                //    _Csdabotri = Csdabotri(Ca, sMay);
                //    if (_Csdabotri >= _Congsuat) return false;
                //}
                ////----Cùng ca không sản xuất cùng mã hàng
                ////if (dtKehoachthoi.Select(sFillter + " And " + DonhangDFields.Masp.Name + "='" + sMahang + "'").Length > 0) return false;
                //if (dtKehoachthoi.Select(sFilterNgay + " And " + DonhangDFields.Masp.Name + "='" + sMahang + "' And "
                //     + KehoachthoiFields.Mamay.Name + "<>'" + sMay + "'").Length > 0) return false;

                ////string sMahang = DT_DONDATHANGCHITIET.Select(DonhangDFields.Id.Name + "='" + dr[DonhangDFields.Id.Name].ToString() + "'")[0][DonhangDFields.Masp.Name].ToString();
                ////DataRow drHang = DT_DMHANGHOA.Select(DmhangFields.Masp.Name + "='" + sMahang + "'")[0];
                ////string sMamanh = drHang[DmhangFields.Mamanh.Name].ToString().Trim();

                //////----Ngày sau có mã hàng sản xuất Ngày trước không sử dụng khác máy
                ////if (Ca > 0)
                ////{
                ////    string sFillterCatruoc = "";
                ////    sFillterCatruoc = KehoachthoiFields.Ca.Name + "='" + (Ca - 1) + "'";
                ////    if (dtKehoachthoi.Select(sFillterCatruoc + " And " + KehoachthoiFields.Mamay.Name + "<>'" + sMay
                ////        + "' And " + DonhangDFields.Masp.Name + "='" + sMahang + "'").Length > 0) return false; 
                ////    //----trước 2 ca sản xuất, trước 1 ca để trống
                ////    DataRow[] arrDr = dtKehoachthoi.Select(KehoachthoiFields.Ca.Name + "='" + (Ca - 2) + "' And " + KehoachthoiFields.Mamay.Name + "<>'" + sMay
                ////        + "' And " + DonhangDFields.Masp.Name + "='" + sMahang + "'");
                ////    foreach (DataRow _dr in arrDr)
                ////    {
                ////        if (dtKehoachthoi.Select(sFillterCatruoc + " And " + KehoachthoiFields.Mamay.Name + "='" + _dr[KehoachthoiFields.Mamay.Name].ToString() + "'").Length == 0)
                ////            return false;
                ////    }
                ////}

                ////----CPHN và CPHD sử dụng cùng mẫu in 
                //string sKhachhang = dr[DmhangFields.Makhach.Name].ToString();
                //string sMauin = DT_DMHANGHOA.Select(DmhangFields.Masp.Name + "='" + sMahang + "'")[0][DmhangFields.Mauin.Name].ToString();
                //if (sKhachhang == "CPHN" || sKhachhang == "CPHD")
                //{
                //    //----Cùng ca không sản xuất cùng mẫu in
                //    DataRow[] arrDr = dtKehoachthoi.Select(sFillter + " And ("
                //            + DmhangFields.Makhach.Name + "='CPHN' OR " + DmhangFields.Makhach.Name + "='CPHD') And "
                //            + KehoachthoiFields.Mamay.Name + "<>'" + sMay + "'");
                //    foreach(DataRow _dr in arrDr)
                //    {
                //        if (sMauin == DT_DMHANGHOA.Select(DmhangFields.Masp.Name + "='" + _dr[DonhangDFields.Masp.Name].ToString() + "'")[0][DmhangFields.Mauin.Name].ToString())
                //            return false;
                //    }
                //    //----Ca sau có mẫu in sản xuất ca trước không sử dụng khác máy
                //    if (Ca > 0)
                //    {
                //        string sFillterCatruoc = "";
                //        sFillterCatruoc = KehoachthoiFields.Ca.Name + "='" + (Ca - 1) + "'";
                //        DataRow[] arrDr1 = dtKehoachthoi.Select(sFillterCatruoc + " And ("
                //            + DmhangFields.Makhach.Name + "='CPHN' OR " + DmhangFields.Makhach.Name + "='CPHD') And "
                //            + KehoachthoiFields.Mamay.Name + "<>'" + sMay + "'");
                //        foreach (DataRow _dr in arrDr1)
                //        {
                //            if (sMauin == DT_DMHANGHOA.Select(DmhangFields.Masp.Name + "='" + _dr[DonhangDFields.Masp.Name].ToString() + "'")[0][DmhangFields.Mauin.Name].ToString())
                //                return false;
                //        }
                //        //----trước 2 ca sản xuất, trước 1 ca để trống
                //        arrDr1 = dtKehoachthoi.Select(KehoachthoiFields.Ca.Name + "='" + (Ca - 2) + "' And ("
                //            + DmhangFields.Makhach.Name + "='CPHN' OR " + DmhangFields.Makhach.Name + "='CPHD') And "
                //            + KehoachthoiFields.Mamay.Name + "<>'" + sMay + "'");
                //        foreach (DataRow _dr in arrDr1)
                //        {
                //            if (sMauin == DT_DMHANGHOA.Select(DmhangFields.Masp.Name + "='" + _dr[DonhangDFields.Masp.Name].ToString() + "'")[0][DmhangFields.Mauin.Name].ToString())
                //                if (dtKehoachthoi.Select(sFillterCatruoc + " And " + KehoachthoiFields.Mamay.Name + "='" + _dr[KehoachthoiFields.Mamay.Name].ToString() + "'").Length == 0)
                //                    return false;
                //        }
                //    }
                //}

                ////----Cùng ca 1 khách hàng không chạy quá 3 máy
                //DataView view = dtKehoachthoi.DefaultView;
                //view.RowFilter = KehoachthoiFields.Ca.Name + "='" + Ca + "' And " 
                //    + DmhangFields.Makhach.Name + "='" + sKhachhang + "'";
                //DataTable dt = view.ToTable(true, KehoachthoiFields.Mamay.Name);
                //if(dt.Rows.Count==3)
                //{
                //    if (dt.Rows[0][0].ToString() != sMay && dt.Rows[1][0].ToString() != sMay && dt.Rows[2][0].ToString() != sMay) return false;
                //}

                ////----Máy in trực tiếp trong 1 ngày chạy cùng 1 chiều dài cắt trừ khi hết yêu cầu
                //if (sDongmay == "01")
                //{
                //    string chieudaicat = dr["Chieudaicat"].ToString();
                //    DataRow[] arrDr = dtKehoachthoi.Select(sFillter + " And " + KehoachthoiFields.Mamay.Name + "='" + sMay + "'");
                //    foreach (DataRow _dr in arrDr)
                //    {
                //        string _chieudaicat = DT_DMHANGHOA.Select(DmhangFields.Masp.Name + "='" + _dr[DonhangDFields.Masp.Name].ToString() + "'")[0][DmhangFields.Chieudaicat.Name].ToString();
                //        if (chieudaicat != _chieudaicat)
                //        {
                //            DataRow[] arrDrNhucau = DT_Nhucauin.Select("Chieudaicat='" + _chieudaicat + "' And " + DmhangFields.Loaimayin.Name + "='01'"
                //                + " And Soluong>Dasanxuat And Id<>'" + sMadonhangct + "'");
                //            if (arrDrNhucau.Length > 0) return false;
                //        }
                //    }
                //}
                ////-------Trong phạm vi 02 ngày, cùng khách, cùng chiều dài cắt, ngày giao +-05 ngày không chạy máy khác
                //if (sDongmay == "01")
                //{
                //    decimal chieudaicat = Convert.ToDecimal(dr["Chieudaicat"].ToString());
                //    DateTime ngaygiao = Convert.ToDateTime(dr[DonhangDFields.Ngaygiao.Name].ToString());

                //    DataRow[] arrDr = dtKehoachthoi.Select(sFilterNgay + " And "
                //        + DmhangFields.Makhach.Name + "='" + dr[DmhangFields.Makhach.Name].ToString() + "' And "
                //        + KehoachthoiFields.Mamay.Name + "<>'" + sMay + "'");
                //    foreach (DataRow _dr in arrDr)
                //    {
                //        decimal _chieudaicat = Convert.ToDecimal(DT_DMHANGHOA.Select(DmhangFields.Masp.Name + "='" + _dr[DonhangDFields.Masp.Name].ToString()
                //            + "'")[0][DmhangFields.Chieudaicat.Name].ToString());

                //        if (chieudaicat == _chieudaicat)
                //        {
                //            DateTime _ngaygiao = Convert.ToDateTime(DT_DONDATHANGCHITIET.Select(DonhangDFields.Id.Name + "='" + dr[DonhangDFields.Id.Name].ToString() + "'")[0][DonhangDFields.Ngaygiao.Name].ToString());
                //            if ((ngaygiao.AddDays(5) > _ngaygiao && ngaygiao < _ngaygiao)
                //                || (ngaygiao.AddDays(-5) < _ngaygiao && ngaygiao > _ngaygiao)) return false;
                //        }
                //    }
                //}

                ////----Máy in gián tiếp trong 1 ngày chạy cùng 1 cỡ khổ bao (50->59, 60->)
                //if (sDongmay == "02")
                //{
                //    bool _dorongtu60 = true;
                //    if (Convert.ToDecimal(dr["Dorong"].ToString()) < 60)
                //        _dorongtu60 = false;

                //    sFilterNgay = "(" + KehoachthoiFields.Ca.Name + "='" + Ca + "' OR " + KehoachthoiFields.Ca.Name + "='"
                //        + (Ca % 2 == 0 ? (Ca + 1).ToString() : (Ca - 1).ToString()) + "') ";
                //    DataRow[] arrDr = dtKehoachthoi.Select(sFilterNgay + " And " + KehoachthoiFields.Mamay.Name + "='" + sMay + "'");
                //    foreach(DataRow _dr in arrDr)
                //    {
                //        decimal dorong = Convert.ToDecimal(DT_DMMANH.Select(DanhmucmanhFields.Mahieu.Name + "='" + 
                //            DT_DMHANGHOA.Select(DmhangFields.Masp.Name + "='" + _dr[DonhangDFields.Masp.Name].ToString() + "'")[0][DmhangFields.Mamanh.Name].ToString()
                //            + "'")[0][DanhmucmanhFields.Dorong.Name].ToString());
                //        if ( (_dorongtu60 && dorong<60) || (!_dorongtu60 && dorong >= 60) )
                //        {
                //            DataRow[] arrDrNhucau = DT_Nhucauin.Select(_dorongtu60? "Dorong<'60'" : "Dorong>='60'"
                //                + " And Soluong>Dasanxuat And Id<>'" + sMadonhangct + "' And " + DmhangFields.Loaimayin.Name + "='02'");
                //            if (arrDrNhucau.Length > 0) return false;
                //        }
                //    }
                //}
                ////-------Trong phạm vi 02 ngày, cùng khách, cùng khổ, ngày giao +-05 ngày không chạy máy khác
                //if (sDongmay == "02")
                //{
                //    bool _dorongtu60 = true;
                //    if (Convert.ToDecimal(dr["Dorong"].ToString()) < 60)
                //        _dorongtu60 = false;
                //    DateTime ngaygiao = Convert.ToDateTime(dr[DonhangDFields.Ngaygiao.Name].ToString());

                //    sFilterNgay = KehoachthoiFields.Ca.Name + "<='" + Ca + "' And " + KehoachthoiFields.Ca.Name + ">='"
                //        + (Ca - 3 < 0 ? "0" : (Ca - 3).ToString()) + "' ";
                //    DataRow[] arrDr = dtKehoachthoi.Select(sFilterNgay + " And "
                //        + DmhangFields.Makhach.Name + "='" + dr[DmhangFields.Makhach.Name].ToString() + "' And "
                //        + KehoachthoiFields.Mamay.Name + "<>'" + sMay + "'");
                //    foreach (DataRow _dr in arrDr)
                //    {
                //        decimal dorong = Convert.ToDecimal(DT_DMMANH.Select(DanhmucmanhFields.Mahieu.Name + "='" +
                //            DT_DMHANGHOA.Select(DmhangFields.Masp.Name + "='" + _dr[DonhangDFields.Masp.Name].ToString() + "'")[0][DmhangFields.Mamanh.Name].ToString()
                //            + "'")[0][DanhmucmanhFields.Dorong.Name].ToString());
                //        if ((_dorongtu60 && dorong >= 60) || (!_dorongtu60 && dorong < 60))
                //        {
                //            DateTime _ngaygiao = Convert.ToDateTime(DT_DONDATHANGCHITIET.Select(DonhangDFields.Id.Name + "='" + dr[DonhangDFields.Id.Name].ToString() + "'")[0][DonhangDFields.Ngaygiao.Name].ToString());
                //            if ((ngaygiao.AddDays(5)>_ngaygiao && ngaygiao<_ngaygiao) 
                //                || (ngaygiao.AddDays(-5) < _ngaygiao && ngaygiao > _ngaygiao)) return false;
                //        }
                //    }
                //}

                ////-------Máy in cuộn 2 3 (IC02, IC03) không in được sản phẩm lệch sườn, lệch đáy nhưng in được toàn bộ dehus lệch đáy
                //string sMakhach = dr[DmhangFields.Makhach.Name].ToString().ToUpper();
                //string sMamanh = dr[DonhangDFields.Mamanh.Name].ToString().ToUpper();
                //if (sMay=="IC02" || sMay=="IC03")
                //{
                //    string sKieugap = dr[DmhangFields.Kieugap.Name].ToString().ToUpper();
                //    //sKieugap = sKieugap.Length >= 2 ? sKieugap.Substring(0, 2) : "";
                //    if (sKieugap == "G05" && !((sMakhach == "DHHP" || sMakhach == "DHVP") && sKieugap == "G05")) return false;
                //}
                ////------Manh tráng lộn (TL) của Deheu chỉ in máy số 2 hoặc máy số 5
                //if ((sMay != "IC02" && sMay != "IC05") && (sMakhach == "DHHP" || sMakhach == "DHVP") && sMamanh.Substring(sMamanh.Length - 2) == "TL") return false;

                ////------Bao TONGWEI (TWHB, TWHD) khổ 62 tráng lộn chỉ chạy máy IC07
                //if ((sMakhach == "TWHB" || sMakhach == "TWHD")
                //    && Convert.ToDecimal(dr["Dorong"].ToString()) == 62
                //    && sMamanh.Substring(sMamanh.Length - 2) == "TL" && sMay != "IC07") return false;
            }
            catch { MessageBox.Show("Lỗi kiểm tra điều kiện sắp xếp!"+'\n'+"Ca "+Ca+", Máy "+May+", Mã hàng "+ dr[DonhangDFields.Masp.Name].ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }
        private bool Ktradkmaychay(int Ca, string sMay, int May)
        {
            try
            {
                ////-----Kiểm tra với lựa chọn ngày chưa phát lệnh
                //if (ngaychuaphatlenh)
                //{
                //    string sDkloc = "";
                //    sDkloc = KehoachthoiFields.Ngaychay.Name + "='" + Tungay.AddDays(Ca/2).ToString() + "' And "
                //                           + KehoachthoiFields.Mamay.Name + "='" + sMay + "' And "
                //                           + KehoachthoiFields.Daphatlenh.Name + "='True'";
                //    DataRow[] arrPhatlenh = dtKehoachdalap.Select(sDkloc);
                //    if (arrPhatlenh.Length > 0) return false;
                //}

                //decimal _Congsuat = 0, Csdabotri = 0;
                //_Congsuat = Convert.ToDecimal(DT_DMMAY_TEMP.Rows[May][CongsuatmaysoiFields.Congsuat.Name].ToString());
                //if (_Congsuat == 0) return false;
                ////-----Đã bố trí hết công suất không chạy tiếp
                //DataRow[] arrDr = dtKehoachthoi.Select(KehoachthoiFields.Ca.Name + "='" + Ca + "' And "
                //                       + KehoachthoiFields.Mamay.Name + "='" + sMay + "'");
                //if (arrDr.Length > 0)
                //{
                //    foreach (DataRow drx in arrDr)
                //        Csdabotri += LIB.ConvertString.NumbertoDB(drx[KehoachthoiFields.Sokg.Name].ToString());
                //}
                //if (Csdabotri >= _Congsuat) return false;
                ////-----Số ca máy trong ngày không được vượt (Số công nhân in - 4)/2
                //if (sMay == "IM1") return true;//-----Máy in màu không cần công nhân
                //string sFillter = "";
                //sFillter = KehoachthoiFields.Ca.Name + "='" + ((int)(Ca / 2))*2 + "' Or " + KehoachthoiFields.Ca.Name + "='" + (((int)(Ca / 2))*2 + 1) + "'";
                //DataRow[] arrDr1 = dtKehoachthoi.Select(sFillter);
                //if(arrDr1.Length>0)
                //{
                //    DataView view = new DataView(arrDr1.CopyToDataTable());
                //    string[] cols = { KehoachthoiFields.Ca.Name, KehoachthoiFields.Mamay.Name };
                //    DataTable dt = view.ToTable(true, cols);
                //    if (dt.Rows.Count >= Socatrongngay && arrDr.Length == 0) return false;
                //}
            }
            catch { MessageBox.Show("Lỗi kiểm tra điều kiện máy chạy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }
        private bool Thuocdanhsach(string Mauin, DataTable DsSoi)
        {
            foreach (DataRow dr in DsSoi.Rows)
                if (dr[0].ToString() == Mauin) return true;
            return false;
        }
        private decimal Csdabotri(int Ca, string sMay)
        {
            decimal _Congsuat = 0;
            foreach (DataRow dr in dtKehoachthoi.Rows)
            {
                if (Convert.ToInt32(dr[KehoachthoiFields.Ca.Name].ToString()) == Ca
                    && dr[KehoachthoiFields.Mamay.Name].ToString() == sMay)
                    _Congsuat += LIB.ConvertString.NumbertoDB(dr[KehoachthoiFields.Sokg.Name].ToString());
            }
            return _Congsuat;
        }
        #endregion

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            try
            {
                ////-------Xóa các kế hoạch cho mã đơn hàng chi tiết trong tháng
                //LIB.Procedures.Xoakehoachtrang(_str_DMCHUONG_PK, Tungay, Denngay);

                ////-------Thêm các row cho các cell có giá trị true
                //for (DateTime date = Tungay; date <= Denngay; date = date.AddDays(1))
                //{
                //    string sDate = date.ToString("dd/MM");
                //    foreach (DataRow dr in DT_DMMAY_TEMP.Rows)
                //    {
                //        int kluong = 0;
                //        try { kluong = Convert.ToInt32(dr[sDate + "_K1"]); }
                //        catch { }
                //        if (kluong > 0)
                //        {
                //            KehoachthoiEntity _KehoachthoiEntity = new KehoachthoiEntity();
                //            _KehoachthoiEntity.Mamanh = txt_MAMANH.Text;
                //            try { _KehoachthoiEntity.Ngaygiao = Convert.ToDateTime(txt_NGAYGIAO.Text); }
                //            catch { }
                //            try { _KehoachthoiEntity.Madonhangct = Convert.ToInt64(_str_DMCHUONG_PK); }
                //            catch { }
                //            _KehoachthoiEntity.Mamayin = dr[DmmayFields.Mamay.Name].ToString();
                //            _KehoachthoiEntity.Ngaychay = date;
                //            _KehoachthoiEntity.Ca = 1;
                //            _KehoachthoiEntity.Sldukien = kluong;

                //            new KehoachthoiManager().Insert(_KehoachthoiEntity);
                //        }
                //        kluong = 0;
                //        try { kluong = Convert.ToInt32(dr[sDate + "_K2"]); }
                //        catch { }
                //        if (kluong > 0)
                //        {
                //            KehoachthoiEntity _KehoachthoiEntity = new KehoachthoiEntity();
                //            _KehoachthoiEntity.Mamanh = txt_MAMANH.Text;
                //            try { _KehoachthoiEntity.Ngaygiao = Convert.ToDateTime(txt_NGAYGIAO.Text); }
                //            catch { }
                //            try { _KehoachthoiEntity.Madonhangct = Convert.ToInt64(_str_DMCHUONG_PK); }
                //            catch { }
                //            _KehoachthoiEntity.Mamayin = dr[DmmayFields.Mamay.Name].ToString();
                //            _KehoachthoiEntity.Ngaychay = date;
                //            _KehoachthoiEntity.Ca = 2;
                //            _KehoachthoiEntity.Sldukien = kluong;

                //            new KehoachthoiManager().Insert(_KehoachthoiEntity);
                //        }
                //    }
                //}
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            catch (Exception ex) { }
            return _str_DMCHUONG_PK;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
                else
                {
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    //GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_DONHANG }));
                    //txt_MAHANG.Focus();
                    GRID_DMMAY.Enabled = true;
                    GRID_DMMAY.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
                }
                GRID_LENHSANXUAT.Enabled = false;
            }
            catch { }
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            try
            {
                BS_LENHSANXUAT_CurrentChanged(new object(), new EventArgs());
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
                GRID_LENHSANXUAT.Enabled = true;
            }
            catch { }
            GRID_DMMAY.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            try
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                if (string.IsNullOrEmpty(MAHIEU_PK)) return;
                if (_KehoachthoiEntity != null && MessageBox.Show("Xóa kế hoạch in: từ ngày " + Tungay.ToString("dd/MM/yyyy")+" đến ngày " + Denngay.ToString("dd/MM/yyyy"), "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        LIB.Procedures.Xoakehoachin("", Tungay, Denngay);
                        BS_LENHSANXUAT_CurrentChanged(new object(), new EventArgs());
                        GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                        GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KehoachthoiManager.Convert(_KehoachthoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa kế hoạch in từ ngày " + Tungay.ToString("dd/MM/yyyy") + " đến ngày " + Denngay.ToString("dd/MM/yyyy") + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                GRID_LENHSANXUAT.Enabled = true;
            }
            catch { }
            GRID_DMMAY.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(MAHIEU_PK) && _KehoachthoiManager.SelectOne(txt_DONHANG.Text.Trim()) != null)
            //{
            //    MessageBox.Show("Mã kế hoạch kéo sợi bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txt_DONHANG.Focus();
            //    return;
            //}
            //else if (txt_DONHANG.Text == "")
            //{
            //    MessageBox.Show("Yêu cầu nhập mã kế hoạch kéo sợi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txt_DONHANG.Focus();
            //    return;
            //}
            //else if (txt_MAHANG.Text == "")
            //{
            //    MessageBox.Show("Yêu cầu nhập tên kế hoạch kéo sợi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txt_MAHANG.Focus();
            //    return;
            //}
            //else
            try
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_LENHSANXUAT.Enabled = true;
                btn_THEMMOI.Focus();
            }
            catch { }
            GRID_DMMAY.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
        }

        #region Validate
        private void txt_MAMANH_Validating(object sender, CancelEventArgs e)
        {
            //_RowViewSelect = null;
            //if (string.IsNullOrEmpty(txt_MAMANH.Text.Trim()) || DT_DMMANH == null || DT_DMMANH.Rows.Count == 0) return;
            //string Str_MASIEUTHI = txt_MAMANH.Text.Trim().ToUpper();
            //_RowViewSelect = checkmaManh(Str_MASIEUTHI, DT_DMMANH);
            //if (_RowViewSelect == null)
            //{
            //    ListviewJanus _frm_SingerRows_Select =
            //        new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMANH.xml",
            //            DT_DMMANH, DanhmucmanhFields.Mahieu.Name, Str_MASIEUTHI);
            //    _frm_SingerRows_Select.ShowDialog();
            //    if (_frm_SingerRows_Select._RowViewSelect == null) return;
            //    _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
            //    txt_MAMANH.Text = _RowViewSelect[DanhmucmanhFields.Mahieu.Name].ToString();
            //    txt_TENMANH.Text = _RowViewSelect[DanhmucmanhFields.Tenhieu.Name].ToString();
            //}
            //else
            //    txt_TENMANH.Text = _RowViewSelect[DanhmucmanhFields.Tenhieu.Name].ToString();
        }

        //private DataRow checkmaManh(string masieuthi, DataTable dt)
        //{
        //    try
        //    {
        //        return dt.Select(DanhmucmanhFields.Mahieu.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
        //    }
        //    catch { return null; }
        //}
        #endregion

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_LENHSANXUAT.ColumnAutoResize = true;
            else
                GRID_LENHSANXUAT.ColumnAutoResize = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_KHTHOI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btn_LUULAI.Enabled)
            {
                DialogResult Dlog = MessageBox.Show("Dữ liệu đã được thay đổi! Bạn có muốn lưu lại không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (Dlog == DialogResult.Yes)
                {
                    btn_LUULAI_Click(new object(), new EventArgs());
                    return;
                }
                if (Dlog == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}
