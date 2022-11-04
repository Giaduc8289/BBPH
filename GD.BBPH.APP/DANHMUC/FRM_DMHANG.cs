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

namespace GD.BBPH.APP.DANHMUC
{
    public partial class FRM_DMHANG : FRM_DMPARENT
    {
        private DmhangManager _DmhangManager = new DmhangManager();
        private DmhangEntity _DmhangEntity = new DmhangEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMHANGHOA = new DataTable(), DT_MAUCUAHANG = new DataTable(), DT_TRUCCUAHANG = new DataTable(), DT_MANGCUAHANG = new DataTable();
        private BindingSource BS_DMHANGHOA = new BindingSource(), BS_MAUCUAHANG = new BindingSource(), BS_TRUCCUAHANG = new BindingSource(), BS_MANGCUAHANG = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DMHANGHOA = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_MAUCUAHANG = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_TRUCCUAHANG = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_MANGCUAHANG = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MAMAUCHITIET = "", MATRUCCHITIET = "", MAMANGCHITIET = "";

        private DataTable DT_DMKHACH = new DataTable(), DT_DMCHUNGLOAI = new DataTable(), DT_DMMANG = new DataTable(), DT_DMMAU = new DataTable()
            , DT_LOAIMUC = new DataTable(), DT_SOMAU = new DataTable(), DT_SOHINH = new DataTable(), DT_SOLOP = new DataTable()
            , DT_CAUTRUCIN = new DataTable(), DT_QCTHANHPHAM = new DataTable(), DT_QCDONGGOI = new DataTable(), DT_QCLOAITHUNG = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMHANG");
                        DT_DMHANGHOA = LIB.SESSION_START.DM_HANG;

                        DT_DMKHACH = LIB.SESSION_START.DT_DMKHACH;
                        DT_DMCHUNGLOAI = LIB.SESSION_START.DT_DMCHUNGLOAI;
                        DT_DMMANG = LIB.SESSION_START.DT_DMMANG;
                        DT_DMMAU = LIB.SESSION_START.DT_DMMAU;
                        DT_LOAIMUC = new DmquycachManager().SelectByManhomRDT("N04");
                        DT_SOMAU = new DmquycachManager().SelectByManhomRDT("N01");
                        DT_SOHINH = new DmquycachManager().SelectByManhomRDT("N03");
                        DT_SOLOP = new DmquycachManager().SelectByManhomRDT("N05");
                        DT_CAUTRUCIN = new DmquycachManager().SelectByManhomRDT("N02");
                        DT_QCTHANHPHAM = new DmquycachManager().SelectByManhomRDT("N06");
                        DT_QCDONGGOI = new DmquycachManager().SelectByManhomRDT("N07");
                        DT_QCLOAITHUNG = new DmquycachManager().SelectByManhomRDT("N08");
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

        private void LoadDanhMuc()
        {
            DT_DMKHACH = LIB.SESSION_START.DT_DMKHACH;
            DT_DMCHUNGLOAI = LIB.SESSION_START.DT_DMCHUNGLOAI;
            DT_DMMANG = LIB.SESSION_START.DT_DMMANG;
            DT_DMMAU = LIB.SESSION_START.DT_DMMAU;
            DT_LOAIMUC = new DmquycachManager().SelectByManhomRDT("N04");
            DT_SOMAU = new DmquycachManager().SelectByManhomRDT("N01");
            DT_SOHINH = new DmquycachManager().SelectByManhomRDT("N03");
            DT_SOLOP = new DmquycachManager().SelectByManhomRDT("N05");
            DT_CAUTRUCIN = new DmquycachManager().SelectByManhomRDT("N02");
            DT_QCTHANHPHAM = new DmquycachManager().SelectByManhomRDT("N06");
            DT_QCDONGGOI = new DmquycachManager().SelectByManhomRDT("N07");
            DT_QCLOAITHUNG = new DmquycachManager().SelectByManhomRDT("N08");
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //  ErrorTrapper.ErrorHandler.HandleError(e.Exception);
        }

        public FRM_DMHANG()
        {
            InitializeComponent();
            //DataTable dt111 = new DmhangManager().Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMHANG.xml");
            //dt111 = new MaucuahangManager().Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_MAUCUAHANG.xml");
            //dt111 = new TruccuahangManager().Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_TRUCCUAHANG.xml");
            //dt111 = new MangcuahangManager().Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_MANGCUAHANG.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LAMMOI, btn_LAMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SAOCHEP, btn_SAOCHEP.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMHANG.xml", GRID_DMHANGHOA, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_MAUCUAHANG.xml", GRID_MAUCUAHANG, pne_DSMAU);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_TRUCCUAHANG.xml", GRID_TRUCCUAHANG, pne_DSTRUC);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_MANGCUAHANG.xml", GRID_MANGCUAHANG, pne_DSMANG);
            FORM_PROCESS();
            GRID_MAUCUAHANG.FilterMode = FilterMode.None;
            GRID_MAUCUAHANG.GroupByBoxVisible = false;
            GRID_TRUCCUAHANG.FilterMode = FilterMode.None;
            GRID_TRUCCUAHANG.GroupByBoxVisible = false;
            GRID_MANGCUAHANG.FilterMode = FilterMode.None;
            GRID_MANGCUAHANG.GroupByBoxVisible = false;
            GRID_MAUCUAHANG.COMBO_MULTICOLUMN(GRID_MAUCUAHANG, MaucuahangFields.Mamau.Name, DmmauFields.Tenmau.Name, DmmauFields.Mamau.Name, DmmauFields.Mamau.Name, DT_DMMAU);
            GRID_MAUCUAHANG.CellEdited += GRID_MAUCUAHANG_CellEdited;
            GRID_MAUCUAHANG.DeletingRecord += GRID_MAUCUAHANG_DeletingRecord;
            GRID_MAUCUAHANG.FormattingRow += GRID_MAUCUAHANG_FormattingRow;
            GRID_MAUCUAHANG.RootTable.Columns[MaucuahangFields.Tenmau.Name].EditType = EditType.NoEdit;
            GRID_MAUCUAHANG.KeyDown += GRID_MAUCUAHANG_KeyDown;
            GRID_TRUCCUAHANG.DeletingRecord += GRID_TRUCCUAHANG_DeletingRecord;
            DataView Source_View = new DataView(DT_DMHANGHOA);
            BS_DMHANGHOA = new BindingSource();
            BS_DMHANGHOA.DataSource = Source_View;
            GRID_DMHANGHOA.DataSource = BS_DMHANGHOA;
            BS_DMHANGHOA.CurrentChanged += new EventHandler(BS_DMHANGHOA_CurrentChanged);
            BS_DMHANGHOA_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        #region Xử lý Grid chi tiết
        private void GRID_MAUCUAHANG_CellEdited(object sender, ColumnActionEventArgs e)
        {
            if (e.Column.DataMember == MaucuahangFields.Mamau.Name)
            {
                DmmauEntity _DmmauEntity = new DmmauManager().SelectOne(GRID_MAUCUAHANG.CurrentRow.Cells[MaucuahangFields.Mamau.Name].Value.ToString());
                if (_DmmauEntity!=null)
                {
                    GRID_MAUCUAHANG.CurrentRow.Cells[MaucuahangFields.Tenmau.Name].Value = _DmmauEntity.Tenmau;
                    GRID_MAUCUAHANG.CurrentRow.Cells[MaucuahangFields.MaArgb.Name].Value = _DmmauEntity.MaArgb;
                }
            }
        }
        private void GRID_MAUCUAHANG_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_MAUCUAHANG.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[MaucuahangFields.Id.Name].ToString();
            string _TENMAU = _view[MaucuahangFields.Tenmau.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK)) return;
            MaucuahangManager _MaucuahangManager = new MaucuahangManager();
            MaucuahangEntity _MaucuahangEntity = new MaucuahangEntity();
            try { _MaucuahangEntity = _MaucuahangManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
            catch { }
            if (_MaucuahangEntity != null && MessageBox.Show("Xóa dòng màu: " + _TENMAU, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _MaucuahangManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                    DataRow[] drArr = DT_MAUCUAHANG.Select(MaucuahangFields.Id.Name + "='" + _MAHIEU_PK + "'");
                    DT_MAUCUAHANG.Rows.Remove(drArr[0]);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa dòng màu: " + _TENMAU + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                BS_MAUCUAHANG.ResetCurrentItem();
                GRID_MAUCUAHANG.DataSource = BS_MAUCUAHANG;
            }
            GRID_MAUCUAHANG.Enabled = true;
        }
        private void GRID_TRUCCUAHANG_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_TRUCCUAHANG.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[TruccuahangFields.Id.Name].ToString();
            string _MATRUC = _view[TruccuahangFields.Matruc.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK)) return;
            TruccuahangManager _TruccuahangManager = new TruccuahangManager();
            TruccuahangEntity _TruccuahangEntity = new TruccuahangEntity();
            try { _TruccuahangEntity = _TruccuahangManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
            catch { }
            if (_TruccuahangEntity != null && MessageBox.Show("Xóa dòng trục: " + _MATRUC, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _TruccuahangManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                    DataRow[] drArr = DT_TRUCCUAHANG.Select(TruccuahangFields.Id.Name + "='" + _MAHIEU_PK + "'");
                    DT_TRUCCUAHANG.Rows.Remove(drArr[0]);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa dòng trục: " + _MATRUC + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                BS_TRUCCUAHANG.ResetCurrentItem();
                GRID_TRUCCUAHANG.DataSource = BS_TRUCCUAHANG;
            }
            GRID_TRUCCUAHANG.Enabled = true;
        }
        //-----Hiện thị màu theo mã màu
        private void GRID_MAUCUAHANG_FormattingRow(object sender, RowLoadEventArgs e)
        {
            try
            {
                int argb = Convert.ToInt32(e.Row.Cells[MaucuahangFields.MaArgb.Name].Value.ToString());
                Color mau = Color.FromArgb(argb);
                Janus.Windows.GridEX.GridEXFormatStyle style = new GridEXFormatStyle();
                style.ForeColor = mau;
                style.BackColor = mau;
                e.Row.Cells[MaucuahangFields.MaArgb.Name].FormatStyle = style;
            }
            catch { }
        }
        //-----Hiện form danh mục màu để xem tỷ lệ màu pha
        private void GRID_MAUCUAHANG_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.F4)
            {
                FRM_DMMAU frm_Dm = new FRM_DMMAU();
                frm_Dm.Text = "Danh mục màu";
                frm_Dm.ShowDialog();
                DT_DMMAU = new DmmauManager().SelectAllRDT();
            }
        }

        #endregion

        #region Load dữ liệu
        void BS_DMHANGHOA_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_DMHANGHOA.UpdateData();
                if (BS_DMHANGHOA.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMHANGHOA.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DmhangFields.Masp.Name].ToString();

                    txt_MASP.Text = _Rowview.Row[DmhangFields.Masp.Name].ToString();
                    txt_TENSP.Text = _Rowview.Row[DmhangFields.Tensp.Name].ToString();
                    txt_MAKHACH.Text = _Rowview.Row[DmhangFields.Makhach.Name].ToString();
                    txt_TENKHACH.Text = _Rowview.Row[DmhangFields.Tenkhach.Name].ToString();
                    txt_MASPCUAKHACH.Text = _Rowview.Row[DmhangFields.Maspcuakhach.Name].ToString();
                    txt_TRONGLUONG.Text = _Rowview.Row[DmhangFields.Trongluong.Name].ToString();
                    txt_RONG.Text = _Rowview.Row[DmhangFields.Rong.Name].ToString();
                    txt_DAI.Text = _Rowview.Row[DmhangFields.Dai.Name].ToString();
                    txt_MALOAIMUC.Text = _Rowview.Row[DmhangFields.Maloaimuc.Name].ToString();
                    txt_SOMAUMA.Text = _Rowview.Row[DmhangFields.Somauma.Name].ToString();
                    txt_SOHINHMA.Text = _Rowview.Row[DmhangFields.Sohinhma.Name].ToString();
                    txt_SOLOPGHEPMA.Text = _Rowview.Row[DmhangFields.Solopghepma.Name].ToString();
                    txt_KHOILUONGMUC.Text = _Rowview.Row[DmhangFields.Khoiluongmuc.Name].ToString();
                    txt_KICHTHUOCTRUC.Text = _Rowview.Row[DmhangFields.Kichthuoctruc.Name].ToString();
                    txt_VITRI.Text = _Rowview.Row[DmhangFields.Vitri.Name].ToString();
                    txt_MAQCTHANHPHAM.Text = _Rowview.Row[DmhangFields.Maqcthanhpham.Name].ToString();
                    txt_MAQCDONGGOI.Text = _Rowview.Row[DmhangFields.Maqcdonggoi.Name].ToString();
                    txt_MAQCLOAITHUNG.Text = _Rowview.Row[DmhangFields.Maqcloaithung.Name].ToString();
                    txt_KHOMANG.Text = _Rowview.Row[DmhangFields.Khomang.Name].ToString();
                    txt_RONGCUON.Text = _Rowview.Row[DmhangFields.Rongcuon.Name].ToString();
                    txt_DAICUON.Text = _Rowview.Row[DmhangFields.Daicuon.Name].ToString();
                    txt_HONG.Text = _Rowview.Row[DmhangFields.Hong.Name].ToString();
                    txt_BANGDINHDAN.Text = _Rowview.Row[DmhangFields.Bangdinhdan.Name].ToString();
                    txt_CAUTRUC.Text = _Rowview.Row[DmhangFields.Cautruc.Name].ToString();

                    txt_MAKHACH_Validating(new object(), new CancelEventArgs());
                    //txt_MACHUNGLOAI_Validating(new object(), new CancelEventArgs());
                    txt_MALOAIMUC_Validating(new object(), new CancelEventArgs());
                    txt_SOMAUMA_Validating(new object(), new CancelEventArgs());
                    txt_SOHINHMA_Validating(new object(), new CancelEventArgs());
                    txt_SOLOPGHEPMA_Validating(new object(), new CancelEventArgs());
                    txt_MAQCTHANHPHAM_Validating(new object(), new CancelEventArgs());
                    txt_MAQCDONGGOI_Validating(new object(), new CancelEventArgs());
                    txt_MAQCLOAITHUNG_Validating(new object(), new CancelEventArgs());

                    SHOWGRID(MAHIEU_PK);
                }
                else
                {
                    SHOWGRID("");
                    GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmhang_CurrentChanged"); }
        }
        void BS_MAUCUAHANG_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_MAUCUAHANG.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_MAUCUAHANG.Current;
                    if (_Rowview != null)
                        MAMAUCHITIET = _Rowview.Row[MaucuahangFields.Id.Name].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập vào chưa đúng, xin mời nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void BS_TRUCCUAHANG_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_TRUCCUAHANG.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_TRUCCUAHANG.Current;
                    if (_Rowview != null)
                        MATRUCCHITIET = _Rowview.Row[TruccuahangFields.Id.Name].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập vào chưa đúng, xin mời nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void BS_MANGCUAHANG_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_MANGCUAHANG.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_MANGCUAHANG.Current;
                    if (_Rowview != null)
                        MAMANGCHITIET = _Rowview.Row[MangcuahangFields.Id.Name].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập vào chưa đúng, xin mời nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SHOWGRID(string MAHIEU_PK)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK))
            {
                DT_MAUCUAHANG = new MaucuahangManager().Clone();
                BS_MAUCUAHANG = new BindingSource(DT_MAUCUAHANG, null);
                GRID_MAUCUAHANG.DataSource = BS_MAUCUAHANG;

                DT_TRUCCUAHANG = new TruccuahangManager().Clone();
                BS_TRUCCUAHANG = new BindingSource(DT_TRUCCUAHANG, null);
                GRID_TRUCCUAHANG.DataSource = BS_TRUCCUAHANG;

                DT_MANGCUAHANG = new MangcuahangManager().Clone();
                BS_MANGCUAHANG = new BindingSource(DT_MANGCUAHANG, null);
                GRID_MANGCUAHANG.DataSource = BS_MANGCUAHANG;
            }
            else
            {
                DT_MAUCUAHANG = new MaucuahangManager().SelectByMaspRDT(MAHIEU_PK);
                DataView Source_View_Mau = new DataView(DT_MAUCUAHANG);
                BS_MAUCUAHANG = new BindingSource();
                BS_MAUCUAHANG.DataSource = Source_View_Mau;
                GRID_MAUCUAHANG.DataSource = BS_MAUCUAHANG;

                DT_TRUCCUAHANG = new TruccuahangManager().SelectByMaspRDT(MAHIEU_PK);
                DataView Source_View_Truc = new DataView(DT_TRUCCUAHANG);
                BS_TRUCCUAHANG = new BindingSource();
                BS_TRUCCUAHANG.DataSource = Source_View_Truc;
                GRID_TRUCCUAHANG.DataSource = BS_TRUCCUAHANG;

                DT_MANGCUAHANG = new MangcuahangManager().SelectByMaspRDT(MAHIEU_PK);
                DataView Source_View_Mang = new DataView(DT_MANGCUAHANG);
                BS_MANGCUAHANG = new BindingSource();
                BS_MANGCUAHANG.DataSource = Source_View_Truc;
                GRID_MANGCUAHANG.DataSource = BS_MANGCUAHANG;
            }
            BS_MAUCUAHANG.CurrentChanged += new EventHandler(BS_MAUCUAHANG_CurrentChanged);
            BS_MAUCUAHANG_CurrentChanged((new object()), (new EventArgs()));
            BS_TRUCCUAHANG.CurrentChanged += new EventHandler(BS_TRUCCUAHANG_CurrentChanged);
            BS_TRUCCUAHANG_CurrentChanged((new object()), (new EventArgs()));
            BS_MANGCUAHANG.CurrentChanged += new EventHandler(BS_MANGCUAHANG_CurrentChanged);
            BS_MANGCUAHANG_CurrentChanged((new object()), (new EventArgs()));
        }
        #endregion

        private string Save_Data(string _str_MAHIEU_PK)
        {
            DmhangEntity _DmhangEntity = new DmhangEntity();

            _DmhangEntity.Masp = txt_MASP.Text.Trim();
            _DmhangEntity.Tensp = txt_TENSP.Text.Trim();
            _DmhangEntity.Makhach = txt_MAKHACH.Text.Trim();
            _DmhangEntity.Tenkhach = txt_TENKHACH.Text.Trim();
            _DmhangEntity.Maspcuakhach = txt_MASPCUAKHACH.Text.Trim();
            //_DmhangEntity.Machungloai = txt_MACHUNGLOAI.Text.Trim();
            //_DmhangEntity.Tenchungloai = txt_TENCHUNGLOAI.Text.Trim();
            _DmhangEntity.Trongluong = LIB.ConvertString.NumbertoDB(txt_TRONGLUONG.Text.Trim());
            _DmhangEntity.Khoiluongmuc = LIB.ConvertString.NumbertoDB(txt_KHOILUONGMUC.Text.Trim());
            _DmhangEntity.Rong = LIB.ConvertString.NumbertoDB(txt_RONG.Text.Trim());
            _DmhangEntity.Dai = LIB.ConvertString.NumbertoDB(txt_DAI.Text.Trim());
            _DmhangEntity.Maloaimuc = txt_MALOAIMUC.Text.Trim();
            _DmhangEntity.Loaimuc = txt_LOAIMUC.Text.Trim();
            _DmhangEntity.Somauma = txt_SOMAUMA.Text.Trim();
            try { _DmhangEntity.Somau = Int32.Parse(txt_SOMAU.Text.Trim()); }
            catch { }
            _DmhangEntity.Sohinhma = txt_SOHINHMA.Text.Trim();
            try { _DmhangEntity.Sohinh = Int32.Parse(txt_SOHINH.Text.Trim()); }
            catch { }
            _DmhangEntity.Solopghepma = txt_SOLOPGHEPMA.Text.Trim();
            try { _DmhangEntity.Solopghep = Int32.Parse(txt_SOLOPGHEP.Text.Trim()); }
            catch { }
            _DmhangEntity.Cautruc = txt_CAUTRUC.Text.Trim();
            _DmhangEntity.Khoiluongmuc = LIB.ConvertString.NumbertoDB(txt_KHOILUONGMUC.Text.Trim());
            _DmhangEntity.Kichthuoctruc = txt_KICHTHUOCTRUC.Text.Trim();
            _DmhangEntity.Vitri = txt_VITRI.Text.Trim();
            _DmhangEntity.Maqcthanhpham = txt_MAQCTHANHPHAM.Text.Trim();
            _DmhangEntity.Tenqcthanhpham = txt_TENQCTHANHPHAM.Text.Trim();
            _DmhangEntity.Maqcdonggoi = txt_MAQCDONGGOI.Text.Trim();
            _DmhangEntity.Tenqcdonggoi = txt_TENQCDONGGOI.Text.Trim();
            _DmhangEntity.Maqcloaithung = txt_MAQCLOAITHUNG.Text.Trim();
            _DmhangEntity.Tenqcloaithung = txt_TENQCLOAITHUNG.Text.Trim();
            _DmhangEntity.Khomang = LIB.ConvertString.NumbertoDB(txt_KHOMANG.Text.Trim());
            _DmhangEntity.Rongcuon = LIB.ConvertString.NumbertoDB(txt_RONGCUON.Text.Trim());
            _DmhangEntity.Daicuon = LIB.ConvertString.NumbertoDB(txt_DAICUON.Text.Trim());
            _DmhangEntity.Hong = LIB.ConvertString.NumbertoDB(txt_HONG.Text.Trim());
            _DmhangEntity.Bangdinhdan = LIB.ConvertString.NumbertoDB(txt_BANGDINHDAN.Text.Trim());
            _DmhangEntity.Cautruc = txt_CAUTRUC.Text.Trim();

            #region Lấy dữ liệu lưới chi tiết
            EntityCollection _MaucuahangEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_MAUCUAHANG.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                MaucuahangEntity _MaucuahangEntity = new MaucuahangEntity();
                _MaucuahangEntity.Masp = txt_MASP.Text.Trim();
                _MaucuahangEntity.Tensp = txt_TENSP.Text.Trim();
                _MaucuahangEntity.Mamau = _view[MaucuahangFields.Mamau.Name].ToString();
                _MaucuahangEntity.Tenmau = _view[MaucuahangFields.Tenmau.Name].ToString();
                _MaucuahangEntity.Klmau = LIB.ConvertString.NumbertoDB(_view[MaucuahangFields.Klmau.Name].ToString());
                _MaucuahangEntity.Tylebaophu = LIB.ConvertString.NumbertoDB(_view[MaucuahangFields.Tylebaophu.Name].ToString());
                try { _MaucuahangEntity.MaArgb = int.Parse(_view[MaucuahangFields.MaArgb.Name].ToString()); }
                catch { }
                try { _MaucuahangEntity.Id = Convert.ToInt64(_view[MaucuahangFields.Id.Name].ToString()); }
                catch { }

                _MaucuahangEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_MaucuahangEntity.IsNew)
                {
                    EntityCollection drDHCT = (new MaucuahangManager()).SelectById(_MaucuahangEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _MaucuahangEntity.Ngaysua = DateTime.Now;
                        _MaucuahangEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _MaucuahangEntity.IsNew = false;
                    }
                    else
                    {
                        _MaucuahangEntity.Ngaytao = DateTime.Now;
                        _MaucuahangEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }

                _MaucuahangEntityCol.Add(_MaucuahangEntity);
            }
            EntityCollection _TruccuahangEntityCol = new EntityCollection();
            GridEXRow[] listGridTruc = GRID_TRUCCUAHANG.GetDataRows();
            foreach (GridEXRow _grid in listGridTruc)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                TruccuahangEntity _TruccuahangEntity = new TruccuahangEntity();

                _TruccuahangEntity.Masp = txt_MASP.Text.Trim();
                _TruccuahangEntity.Tensp = txt_TENSP.Text.Trim();
                try { _TruccuahangEntity.Stttruc = Convert.ToInt32(_view[TruccuahangFields.Stttruc.Name].ToString()); }
                catch { }
                _TruccuahangEntity.Matruc = _view[TruccuahangFields.Matruc.Name].ToString();
                try { _TruccuahangEntity.Id = Convert.ToInt64(_view[TruccuahangFields.Id.Name].ToString()); }
                catch { }

                _TruccuahangEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_TruccuahangEntity.IsNew)
                {
                    EntityCollection drDHCT = (new TruccuahangManager()).SelectById(_TruccuahangEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _TruccuahangEntity.Ngaysua = DateTime.Now;
                        _TruccuahangEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _TruccuahangEntity.IsNew = false;
                    }
                    else
                    {
                        _TruccuahangEntity.Ngaytao = DateTime.Now;
                        _TruccuahangEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }

                _TruccuahangEntityCol.Add(_TruccuahangEntity);
            }
            EntityCollection _MangcuahangEntityCol = new EntityCollection();
            GridEXRow[] listGridMang = GRID_MANGCUAHANG.GetDataRows();
            foreach (GridEXRow _grid in listGridMang)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                MangcuahangEntity _MangcuahangEntity = new MangcuahangEntity();

                _MangcuahangEntity.Masp = txt_MASP.Text.Trim();
                _MangcuahangEntity.Tensp = txt_TENSP.Text.Trim();
                _MangcuahangEntity.Mangin = Convert.ToBoolean(_view[MangcuahangFields.Mangin.Name].ToString());
                _MangcuahangEntity.Mamang = _view[MangcuahangFields.Mamang.Name].ToString();
                _MangcuahangEntity.Tenmang = _view[MangcuahangFields.Tenmang.Name].ToString();
                _MangcuahangEntity.Maloaikeo = _view[MangcuahangFields.Maloaikeo.Name].ToString();
                _MangcuahangEntity.Tenloaikeo = _view[MangcuahangFields.Tenloaikeo.Name].ToString();
                _MangcuahangEntity.Maloaidongran = _view[MangcuahangFields.Maloaidongran.Name].ToString();
                _MangcuahangEntity.Tenloaidongran = _view[MangcuahangFields.Tenloaidongran.Name].ToString();
                _MangcuahangEntity.Dinhmuckeokho = LIB.ConvertString.NumbertoDB(_view[MangcuahangFields.Dinhmuckeokho.Name].ToString());
                _MangcuahangEntity.Dinhmucdongrankho = LIB.ConvertString.NumbertoDB(_view[MangcuahangFields.Dinhmucdongrankho.Name].ToString());
                _MangcuahangEntity.Tylekeokho = LIB.ConvertString.NumbertoDB(_view[MangcuahangFields.Tylekeokho.Name].ToString());
                _MangcuahangEntity.Tyledongrankho = LIB.ConvertString.NumbertoDB(_view[MangcuahangFields.Tyledongrankho.Name].ToString());
                _MangcuahangEntity.Tylekeo = LIB.ConvertString.NumbertoDB(_view[MangcuahangFields.Tylekeo.Name].ToString());
                _MangcuahangEntity.Tyledongran = LIB.ConvertString.NumbertoDB(_view[MangcuahangFields.Tyledongran.Name].ToString());
                _MangcuahangEntity.Dinhmuckeouot = LIB.ConvertString.NumbertoDB(_view[MangcuahangFields.Dinhmuckeouot.Name].ToString());
                _MangcuahangEntity.Dinhmucdongranuot = LIB.ConvertString.NumbertoDB(_view[MangcuahangFields.Dinhmucdongranuot.Name].ToString());
                _MangcuahangEntity.Dinhmucdungmoi = LIB.ConvertString.NumbertoDB(_view[MangcuahangFields.Dinhmucdungmoi.Name].ToString());

                _MangcuahangEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_MangcuahangEntity.IsNew)
                {
                    EntityCollection drDHCT = (new MangcuahangManager()).SelectById(_MangcuahangEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _MangcuahangEntity.Ngaysua = DateTime.Now;
                        _MangcuahangEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _MangcuahangEntity.IsNew = false;
                    }
                    else
                    {
                        _MangcuahangEntity.Ngaytao = DateTime.Now;
                        _MangcuahangEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }

                _MangcuahangEntityCol.Add(_MangcuahangEntity);
            }
            #endregion

            if (string.IsNullOrEmpty(_str_MAHIEU_PK))
            {
                _DmhangEntity.Ngaytao = DateTime.Now;
                _DmhangEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_MAHIEU_PK = _DmhangManager.InsertV2(_DmhangEntity, r_Insert, DT_DMHANGHOA, BS_DMHANGHOA);
                new MaucuahangManager().InsertCollection(_MaucuahangEntityCol);
                new TruccuahangManager().InsertCollection(_TruccuahangEntityCol);
                new MangcuahangManager().InsertCollection(_MangcuahangEntityCol);
                GRID_MAUCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_MAUCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_MAUCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TRUCCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TRUCCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TRUCCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_MANGCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_MANGCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_MANGCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmhangManager.Convert(_DmhangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMHANGHOA.ResetCurrentItem();
                BS_DMHANGHOA_CurrentChanged(new object(), new EventArgs());
            }
            else
            {
                _DmhangEntity.Ngaysua = DateTime.Now;
                _DmhangEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DmhangManager.Update(_DmhangEntity);
                foreach (MaucuahangEntity _MaucuahangEntity in _MaucuahangEntityCol)
                {
                    if (_MaucuahangEntity.IsNew)
                    {
                        DataRow _r_Insert = DT_MAUCUAHANG.NewRow();
                        DT_MAUCUAHANG.Rows.Add(_r_Insert);
                        new MaucuahangManager().InsertV2(_MaucuahangEntity, _r_Insert, DT_MAUCUAHANG, BS_MAUCUAHANG);
                    }
                    else new MaucuahangManager().Update(_MaucuahangEntity);
                }
                foreach (TruccuahangEntity _TruccuahangEntity in _TruccuahangEntityCol)
                {
                    if (_TruccuahangEntity.IsNew)
                    {
                        DataRow _r_Insert = DT_TRUCCUAHANG.NewRow();
                        DT_TRUCCUAHANG.Rows.Add(_r_Insert);
                        new TruccuahangManager().InsertV2(_TruccuahangEntity, _r_Insert, DT_TRUCCUAHANG, BS_TRUCCUAHANG);
                    }
                    else new TruccuahangManager().Update(_TruccuahangEntity);
                }
                foreach (MangcuahangEntity _MangcuahangEntity in _MangcuahangEntityCol)
                {
                    if (_MangcuahangEntity.IsNew)
                    {
                        DataRow _r_Insert = DT_MANGCUAHANG.NewRow();
                        DT_MANGCUAHANG.Rows.Add(_r_Insert);
                        new MangcuahangManager().InsertV2(_MangcuahangEntity, _r_Insert, DT_MANGCUAHANG, BS_MANGCUAHANG);
                    }
                    else new MangcuahangManager().Update(_MangcuahangEntity);
                }
                #region Update lưới chính
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Masp.Name].Value = _DmhangEntity.Masp;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Tensp.Name].Value = _DmhangEntity.Tensp;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Maspcuakhach.Name].Value = _DmhangEntity.Maspcuakhach;
                //GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Machungloai.Name].Value = _DmhangEntity.Machungloai;
                //GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Tenchungloai.Name].Value = _DmhangEntity.Tenchungloai;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Makhach.Name].Value = _DmhangEntity.Makhach;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Tenkhach.Name].Value = _DmhangEntity.Tenkhach;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Trongluong.Name].Value = _DmhangEntity.Trongluong;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Sohinh.Name].Value = _DmhangEntity.Sohinh;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Somau.Name].Value = _DmhangEntity.Somau;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Loaimuc.Name].Value = _DmhangEntity.Loaimuc;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Khoiluongmuc.Name].Value = _DmhangEntity.Khoiluongmuc;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Kichthuoctruc.Name].Value = _DmhangEntity.Kichthuoctruc;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Vitri.Name].Value = _DmhangEntity.Vitri;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Maqcdonggoi.Name].Value = _DmhangEntity.Maqcdonggoi;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Tenqcdonggoi.Name].Value = _DmhangEntity.Tenqcdonggoi;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Maqcloaithung.Name].Value = _DmhangEntity.Maqcloaithung;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Tenqcloaithung.Name].Value = _DmhangEntity.Tenqcloaithung;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Maqcthanhpham.Name].Value = _DmhangEntity.Maqcthanhpham;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Tenqcthanhpham.Name].Value = _DmhangEntity.Tenqcthanhpham;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Rong.Name].Value = _DmhangEntity.Rong;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Dai.Name].Value = _DmhangEntity.Dai;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Somauma.Name].Value = _DmhangEntity.Somauma;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Sohinhma.Name].Value = _DmhangEntity.Sohinhma;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Maloaimuc.Name].Value = _DmhangEntity.Maloaimuc;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Solopghepma.Name].Value = _DmhangEntity.Solopghepma;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Solopghep.Name].Value = _DmhangEntity.Solopghep;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Khomang.Name].Value = _DmhangEntity.Khomang;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Rongcuon.Name].Value = _DmhangEntity.Rongcuon;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Daicuon.Name].Value = _DmhangEntity.Daicuon;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Hong.Name].Value = _DmhangEntity.Hong;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Bangdinhdan.Name].Value = _DmhangEntity.Bangdinhdan;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Cautruc.Name].Value = _DmhangEntity.Cautruc;
                #endregion
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmhangManager.Convert(_DmhangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GRID_MAUCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_MAUCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_MAUCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TRUCCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TRUCCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TRUCCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_MANGCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_MANGCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_MANGCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                BS_DMHANGHOA.ResetCurrentItem();
                BS_DMHANGHOA_CurrentChanged(new object(), new EventArgs());
            }
            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_TENKHACH.Text = string.Empty;
            r_Insert = DT_DMHANGHOA.NewRow();
            DT_DMHANGHOA.Rows.Add(r_Insert);
            BS_DMHANGHOA.Position = DT_DMHANGHOA.Rows.Count;
            GRID_MAUCUAHANG.Enabled = true;
            GRID_MAUCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_MAUCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_MAUCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_MAUCUAHANG.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_TRUCCUAHANG.Enabled = true;
            GRID_TRUCCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TRUCCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TRUCCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TRUCCUAHANG.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_MANGCUAHANG.Enabled = true;
            GRID_MANGCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_MANGCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_MANGCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_MANGCUAHANG.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            MAHIEU_PK = "";
            txt_MASP.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENKHACH, txt_LOAIMUC, txt_SOMAU, txt_SOHINH, txt_SOLOPGHEP, txt_TENQCTHANHPHAM, txt_TENQCDONGGOI, txt_TENQCLOAITHUNG }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMHANGHOA.Enabled = false;
        }

        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MASP, txt_TENKHACH, txt_LOAIMUC, txt_SOMAU, txt_SOHINH, txt_SOLOPGHEP, txt_TENQCTHANHPHAM, txt_TENQCDONGGOI, txt_TENQCLOAITHUNG }));
                txt_TENSP.Focus();
                //txt_MAKHO.Focus();

            }
            GRID_DMHANGHOA.Enabled = false;
            GRID_MAUCUAHANG.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_MAUCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_MAUCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_MAUCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_MAUCUAHANG.Enabled = true;
            GRID_TRUCCUAHANG.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_TRUCCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TRUCCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TRUCCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TRUCCUAHANG.Enabled = true;
            GRID_MANGCUAHANG.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_MANGCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_MANGCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_MANGCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_MANGCUAHANG.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMHANGHOA.Rows.Remove(r_Insert);
            }
            BS_DMHANGHOA_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMHANGHOA.Enabled = true;
            GRID_MAUCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_MAUCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_MAUCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_TRUCCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_TRUCCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_TRUCCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_MANGCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_MANGCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_MANGCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DmhangManager _DmhangManager = new DmhangManager();
            DmhangEntity _DmhangEntity = new DmhangEntity();
            _DmhangEntity = _DmhangManager.SelectOne(MAHIEU_PK);
            if (_DmhangEntity != null && MessageBox.Show("Xóa hàng: " + MAHIEU_PK + " - " + txt_TENSP.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DmhangManager.Delete(MAHIEU_PK);
                    GRID_DMHANGHOA.CurrentRow.Delete();
                    BS_DMHANGHOA_CurrentChanged(new object(), new EventArgs());
                    //GD.BBPH.LIB.TrayPopup.PoupStringMessage(GD.BBPH.APP.Properties.Resources.MessageTitle, GD.BBPH.APP.Properties.Resources.MessageContent_T);
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmhangManager.Convert(_DmhangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa hàng " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMHANGHOA.Enabled = true;
            GRID_MAUCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_MAUCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_MAUCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_TRUCCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_TRUCCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_TRUCCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_MANGCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_MANGCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_MANGCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DmhangManager.SelectOne(txt_MASP.Text.Trim()) != null)
            {
                MessageBox.Show("Mã hàng bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MASP.Focus();
                return;
            }
            else if (txt_MASP.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MASP.Focus();
                return;
            }
            else if (txt_TENSP.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENSP.Focus();
                return;
            }
            else if (txt_MAKHACH.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAKHACH.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMHANGHOA.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_MAUCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_MAUCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_MAUCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TRUCCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TRUCCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TRUCCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_MANGCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_MANGCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_MANGCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            }
        }
        private void btn_SAOCHEP_Click(object sender, EventArgs e)
        {
            try
            {
                BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                DmhangManager _DmhangManager = new DmhangManager();
                DmhangEntity _DmhangEntity = new DmhangEntity();
                r_Insert = DT_DMHANGHOA.NewRow();
                DT_DMHANGHOA.Rows.Add(r_Insert);
                DataRow[] drCopy = DT_DMHANGHOA.Select(DmhangFields.Masp.Name + "= '" + MAHIEU_PK + "'");
                BS_DMHANGHOA.Position = DT_DMHANGHOA.Rows.Count;
                GRID_MAUCUAHANG.Enabled = true;
                GRID_MAUCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_MAUCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_MAUCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_MAUCUAHANG.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
                GRID_TRUCCUAHANG.Enabled = true;
                GRID_TRUCCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_TRUCCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_TRUCCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_TRUCCUAHANG.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
                GRID_MANGCUAHANG.Enabled = true;
                GRID_MANGCUAHANG.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_MANGCUAHANG.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_MANGCUAHANG.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_MANGCUAHANG.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;

                txt_MASP.Text = drCopy[0][DmhangFields.Masp.Name].ToString();
                txt_TENSP.Text = drCopy[0][DmhangFields.Tensp.Name].ToString();
                txt_MAKHACH.Text = drCopy[0][DmhangFields.Makhach.Name].ToString();
                txt_MASPCUAKHACH.Text = drCopy[0][DmhangFields.Maspcuakhach.Name].ToString();
                //txt_MACHUNGLOAI.Text = drCopy[0][DmhangFields.Machungloai.Name].ToString();
                txt_TRONGLUONG.Text = drCopy[0][DmhangFields.Trongluong.Name].ToString();
                txt_HONG.Text = drCopy[0][DmhangFields.Hong.Name].ToString();
                txt_RONG.Text = drCopy[0][DmhangFields.Rong.Name].ToString();
                txt_DAI.Text = drCopy[0][DmhangFields.Dai.Name].ToString();
                txt_MALOAIMUC.Text = drCopy[0][DmhangFields.Maloaimuc.Name].ToString();
                txt_SOMAUMA.Text = drCopy[0][DmhangFields.Somauma.Name].ToString();
                txt_SOHINHMA.Text = drCopy[0][DmhangFields.Sohinhma.Name].ToString();
                //txt_MACAUTRUCIN.Text = drCopy[0][DmhangFields.Macautrucin.Name].ToString();
                txt_KHOILUONGMUC.Text = drCopy[0][DmhangFields.Khoiluongmuc.Name].ToString();
                //txt_MAMANG1.Text = drCopy[0][DmhangFields.Mamang1.Name].ToString();
                //txt_TLMANG1.Text = drCopy[0][DmhangFields.Tlmanglop1.Name].ToString();
                //txt_TLKEO1.Text = drCopy[0][DmhangFields.Tlkeolop1.Name].ToString();
                //txt_MAMANG2.Text = drCopy[0][DmhangFields.Mamang2.Name].ToString();
                //txt_TLMANG2.Text = drCopy[0][DmhangFields.Tlmanglop2.Name].ToString();
                //txt_TLKEO2.Text = drCopy[0][DmhangFields.Tlkeolop2.Name].ToString();
                //txt_DINHLUONGKEO.Text = drCopy[0][DmhangFields.Dinhluongkeo.Name].ToString();
                txt_KICHTHUOCTRUC.Text = drCopy[0][DmhangFields.Kichthuoctruc.Name].ToString();
                txt_VITRI.Text = drCopy[0][DmhangFields.Vitri.Name].ToString();
                txt_MAQCTHANHPHAM.Text = drCopy[0][DmhangFields.Maqcthanhpham.Name].ToString();
                txt_MAQCDONGGOI.Text = drCopy[0][DmhangFields.Maqcdonggoi.Name].ToString();
                txt_MAQCLOAITHUNG.Text = drCopy[0][DmhangFields.Maqcloaithung.Name].ToString();

                txt_MAKHACH_Validating(new object(), new CancelEventArgs());
                //txt_MACHUNGLOAI_Validating(new object(), new CancelEventArgs());
                txt_MALOAIMUC_Validating(new object(), new CancelEventArgs());
                txt_SOMAUMA_Validating(new object(), new CancelEventArgs());
                txt_SOHINHMA_Validating(new object(), new CancelEventArgs());
                txt_MAQCTHANHPHAM_Validating(new object(), new CancelEventArgs());
                txt_MAQCDONGGOI_Validating(new object(), new CancelEventArgs());
                txt_MAQCLOAITHUNG_Validating(new object(), new CancelEventArgs());

                MAHIEU_PK = "";
                txt_MASP.Focus();
                //TEXTBOX_Only_Control(false, null);
                // txt_MAHIEU.Text = DmcapmaManager.GET_MA_INT(DmcapmaManager.LOAI_MA_HIEU, false, KTXPT.DATA);
                BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                BBPH.BLL.MenuroleManager.set_Enable_controls(BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GRID_DMHANGHOA.Enabled = false;
            }
            catch { }
        }
        private void btn_LAMMOI_Click(object sender, EventArgs e)
        {
            LoadDanhMuc();
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validate
        private void txt_MAKHACH_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAKHACH.Text.Trim()) || DT_DMKHACH == null || DT_DMKHACH.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAKHACH.Text.Trim().ToUpper();
            _RowViewSelect = checkmaKhach(Str_MASIEUTHI, DT_DMKHACH);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMKHACH.xml",
                        DT_DMKHACH, DmkhachFields.Makhach.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAKHACH.Text = _RowViewSelect[DmkhachFields.Makhach.Name].ToString();
                txt_TENKHACH.Text = _RowViewSelect[DmkhachFields.Tenkhach.Name].ToString();
            }
            else
                txt_TENKHACH.Text = _RowViewSelect[DmkhachFields.Tenkhach.Name].ToString();
        }
        private DataRow checkmaKhach(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmkhachFields.Makhach.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MACHUNGLOAI_Validating(object sender, CancelEventArgs e)
        {
            //_RowViewSelect = null;
            //if (string.IsNullOrEmpty(txt_MACHUNGLOAI.Text.Trim()) || DT_DMCHUNGLOAI == null || DT_DMCHUNGLOAI.Rows.Count == 0) return;
            //string Str_MASIEUTHI = txt_MACHUNGLOAI.Text.Trim().ToUpper();
            //_RowViewSelect = checkmaChungloai(Str_MASIEUTHI, DT_DMCHUNGLOAI);
            //if (_RowViewSelect == null)
            //{
            //    ListviewJanus _frm_SingerRows_Select =
            //        new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCHUNGLOAI.xml",
            //            DT_DMCHUNGLOAI, DmchungloaiFields.Machungloai.Name, Str_MASIEUTHI);
            //    _frm_SingerRows_Select.ShowDialog();
            //    if (_frm_SingerRows_Select._RowViewSelect == null) return;
            //    _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
            //    txt_MACHUNGLOAI.Text = _RowViewSelect[DmchungloaiFields.Machungloai.Name].ToString();
            //    txt_TENCHUNGLOAI.Text = _RowViewSelect[DmchungloaiFields.Tenchungloai.Name].ToString();
            //}
            //else
            //    txt_TENCHUNGLOAI.Text = _RowViewSelect[DmchungloaiFields.Tenchungloai.Name].ToString();
        }
        private DataRow checkmaChungloai(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmchungloaiFields.Machungloai.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MALOAIMUC_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MALOAIMUC.Text.Trim()) || DT_LOAIMUC == null || DT_LOAIMUC.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MALOAIMUC.Text.Trim().ToUpper();
            _RowViewSelect = checkmaQuycach(Str_MASIEUTHI, DT_LOAIMUC);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH.xml",
                        DT_LOAIMUC, DmquycachFields.Maquycach.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MALOAIMUC.Text = _RowViewSelect[DmquycachFields.Maquycach.Name].ToString();
                txt_LOAIMUC.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
            }
            else
                txt_LOAIMUC.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
        }
        private DataRow checkmaQuycach(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmquycachFields.Maquycach.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_SOMAUMA_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_SOMAUMA.Text.Trim()) || DT_SOMAU == null || DT_SOMAU.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_SOMAUMA.Text.Trim().ToUpper();
            _RowViewSelect = checkmaQuycach(Str_MASIEUTHI, DT_SOMAU);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH.xml",
                        DT_SOMAU, DmquycachFields.Maquycach.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_SOMAUMA.Text = _RowViewSelect[DmquycachFields.Maquycach.Name].ToString();
                txt_SOMAU.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
            }
            else
                txt_SOMAU.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
        }

        private void txt_SOHINHMA_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_SOHINHMA.Text.Trim()) || DT_SOHINH == null || DT_SOHINH.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_SOHINHMA.Text.Trim().ToUpper();
            _RowViewSelect = checkmaQuycach(Str_MASIEUTHI, DT_SOHINH);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH.xml",
                        DT_SOHINH, DmquycachFields.Maquycach.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_SOHINHMA.Text = _RowViewSelect[DmquycachFields.Maquycach.Name].ToString();
                txt_SOHINH.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
            }
            else
                txt_SOHINH.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
        }
        private void txt_SOLOPGHEPMA_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_SOLOPGHEPMA.Text.Trim()) || DT_SOLOP == null || DT_SOLOP.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_SOLOPGHEPMA.Text.Trim().ToUpper();
            _RowViewSelect = checkmaQuycach(Str_MASIEUTHI, DT_SOLOP);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH.xml",
                        DT_SOLOP, DmquycachFields.Maquycach.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_SOLOPGHEPMA.Text = _RowViewSelect[DmquycachFields.Maquycach.Name].ToString();
                txt_SOLOPGHEP.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
            }
            else
                txt_SOLOPGHEP.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
        }

        private void txt_MAQCTHANHPHAM_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAQCTHANHPHAM.Text.Trim()) || DT_QCTHANHPHAM == null || DT_QCTHANHPHAM.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAQCTHANHPHAM.Text.Trim().ToUpper();
            _RowViewSelect = checkmaQuycach(Str_MASIEUTHI, DT_QCTHANHPHAM);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH.xml",
                        DT_QCTHANHPHAM, DmquycachFields.Maquycach.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAQCTHANHPHAM.Text = _RowViewSelect[DmquycachFields.Maquycach.Name].ToString();
                txt_TENQCTHANHPHAM.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
            }
            else
                txt_TENQCTHANHPHAM.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
        }

        private void txt_MAQCDONGGOI_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAQCDONGGOI.Text.Trim()) || DT_QCDONGGOI == null || DT_QCDONGGOI.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAQCDONGGOI.Text.Trim().ToUpper();
            _RowViewSelect = checkmaQuycach(Str_MASIEUTHI, DT_QCDONGGOI);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH.xml",
                        DT_QCDONGGOI, DmquycachFields.Maquycach.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAQCDONGGOI.Text = _RowViewSelect[DmquycachFields.Maquycach.Name].ToString();
                txt_TENQCDONGGOI.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
            }
            else
                txt_TENQCDONGGOI.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
        }

        private void txt_MAQCLOAITHUNG_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAQCLOAITHUNG.Text.Trim()) || DT_QCLOAITHUNG == null || DT_QCLOAITHUNG.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAQCLOAITHUNG.Text.Trim().ToUpper();
            _RowViewSelect = checkmaQuycach(Str_MASIEUTHI, DT_QCLOAITHUNG);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH.xml",
                        DT_QCLOAITHUNG, DmquycachFields.Maquycach.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAQCLOAITHUNG.Text = _RowViewSelect[DmquycachFields.Maquycach.Name].ToString();
                txt_TENQCLOAITHUNG.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
            }
            else
                txt_TENQCLOAITHUNG.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
        }

        #endregion

        #region Text Changed
        private void txt_KICHTHUOC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_HONG.Text.Length > 0)
                {
                    int vtriX = txt_HONG.Text.ToUpper().IndexOf('X');
                    if (vtriX <= 0) return;
                    txt_RONG.Text = txt_HONG.Text.Substring(0, vtriX);
                    txt_DAI.Text = txt_HONG.Text.Substring(vtriX+1);
                }
            }
            catch { }
        }

        #endregion

        #region Shortcut Key
        private void txt_MAKHACH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMKHACH frm_Dm = new FRM_DMKHACH();
                frm_Dm.Text = "Danh mục khách hàng";
                frm_Dm.ShowDialog();
                DT_DMKHACH = new DmkhachManager().SelectAllRDT();
            }
        }
        private void txt_MACHUNGLOAI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMCHUNGLOAI frm_Dm = new FRM_DMCHUNGLOAI();
                frm_Dm.Text = "Danh mục chủng loại";
                frm_Dm.ShowDialog();
                DT_DMCHUNGLOAI = new DmchungloaiManager().SelectAllRDT();
            }
        }
        private void txt_MALOAIMUC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMQUYCACH frm_Dm = new FRM_DMQUYCACH();
                frm_Dm.Text = "Danh mục quy cách";
                frm_Dm.ShowDialog();
                DT_LOAIMUC = new DmquycachManager().SelectByManhomRDT("N04");
            }
        }
        private void txt_SOMAUMA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMQUYCACH frm_Dm = new FRM_DMQUYCACH();
                frm_Dm.Text = "Danh mục quy cách";
                frm_Dm.ShowDialog();
                DT_SOMAU = new DmquycachManager().SelectByManhomRDT("N01");
            }
        }
        private void txt_SOHINHMA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMQUYCACH frm_Dm = new FRM_DMQUYCACH();
                frm_Dm.Text = "Danh mục quy cách";
                frm_Dm.ShowDialog();
                DT_SOHINH = new DmquycachManager().SelectByManhomRDT("N03");
            }
        }
        private void txt_MAQCTHANHPHAM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMQUYCACH frm_Dm = new FRM_DMQUYCACH();
                frm_Dm.Text = "Danh mục quy cách";
                frm_Dm.ShowDialog();
                DT_QCTHANHPHAM = new DmquycachManager().SelectByManhomRDT("N06");
            }
        }
        private void txt_MAQCDONGGOI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMQUYCACH frm_Dm = new FRM_DMQUYCACH();
                frm_Dm.Text = "Danh mục quy cách";
                frm_Dm.ShowDialog();
                DT_QCDONGGOI = new DmquycachManager().SelectByManhomRDT("N07");
            }
        }
        private void txt_MAQCLOAITHUNG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMQUYCACH frm_Dm = new FRM_DMQUYCACH();
                frm_Dm.Text = "Danh mục quy cách";
                frm_Dm.ShowDialog();
                DT_QCLOAITHUNG = new DmquycachManager().SelectByManhomRDT("N08");
            }
        }
        private void txt_MAMANG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMMANG frm_Dm = new FRM_DMMANG();
                frm_Dm.Text = "Danh mục màng";
                frm_Dm.ShowDialog();
                DT_DMMANG = new DmmangManager().SelectAllRDT();
            }
        }
        #endregion

        private void FRM_DMHANG_FormClosing(object sender, FormClosingEventArgs e)
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
