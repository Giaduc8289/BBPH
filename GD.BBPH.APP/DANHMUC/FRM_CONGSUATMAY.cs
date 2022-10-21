using System;
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
    public partial class FRM_CONGSUATMAY : FRM_DMPARENT
    {
        private CongsuatmayManager _CongsuatmayManager = new CongsuatmayManager();
        private CongsuatmayEntity _CongsuatmayEntity = new CongsuatmayEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_CONGSUATMAY = new DataTable();
        private BindingSource BS_CONGSUATMAY = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_CONGSUATMAY = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";

        private DataTable DT_DMMAY = new DataTable(), DT_DMDONGMAY = new DataTable(), DT_DMCONGDOAN = new DataTable()
            , DT_SOMAU = new DataTable(), DT_SOHINH = new DataTable(), DT_LOAIMANG = new DataTable(), DT_QCTHANHPHAM = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_CONGSUATMAY");
                        DT_CONGSUATMAY = LIB.SESSION_START.DT_CONGSUATMAY;

                        DT_SOMAU = new DmquycachManager().SelectByManhomRDT("N01");
                        DT_SOHINH = new DmquycachManager().SelectByManhomRDT("N03");
                        DT_LOAIMANG = new DmquycachManager().SelectByManhomRDT("N09");
                        DT_QCTHANHPHAM = new DmquycachManager().SelectByManhomRDT("N06");
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

        public FRM_CONGSUATMAY()
        {
            InitializeComponent();
            CongsuatmayManager _CongsuatmayManager = new CongsuatmayManager();
            DataTable dt111 = _CongsuatmayManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_CONGSUATMAY.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_CONGSUATMAY.xml", GRID_CONGSUATMAY, uiPanel0Container);
            //GRID_CONGSUATMAY.RootTable.SortKeys.Add(CongsuatmayFields.Sothutucongdoan.Name, Janus.Windows.GridEX.SortOrder.Ascending);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_CONGSUATMAY);
            BS_CONGSUATMAY = new BindingSource();
            BS_CONGSUATMAY.DataSource = Source_View;
            GRID_CONGSUATMAY.DataSource = BS_CONGSUATMAY;
            BS_CONGSUATMAY.CurrentChanged += new EventHandler(BS_CONGSUATMAY_CurrentChanged);
            BS_CONGSUATMAY_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = false;
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_CONGSUATMAY_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_CONGSUATMAY.UpdateData();
                if (BS_CONGSUATMAY.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_CONGSUATMAY.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[CongsuatmayFields.Macongsuat.Name].ToString();
                    txt_MACONGSUAT.Text = _Rowview.Row[CongsuatmayFields.Macongsuat.Name].ToString();
                    txt_TENCONGSUAT.Text = _Rowview.Row[CongsuatmayFields.Tencongsuat.Name].ToString();
                    txt_MAMAY.Text = _Rowview.Row[CongsuatmayFields.Mamay.Name].ToString();
                    txt_MADONGMAY.Text = _Rowview.Row[CongsuatmayFields.Madongmay.Name].ToString();
                    txt_MACONGDOAN.Text = _Rowview.Row[CongsuatmayFields.Macongdoan.Name].ToString();
                    txt_DODAYTU.Text = _Rowview.Row[CongsuatmayFields.Dodaytu.Name].ToString();
                    txt_DODAYDEN.Text = _Rowview.Row[CongsuatmayFields.Dodayden.Name].ToString();
                    txt_KHOTU.Text = _Rowview.Row[CongsuatmayFields.Khotu.Name].ToString();
                    txt_KHODEN.Text = _Rowview.Row[CongsuatmayFields.Khoden.Name].ToString();
                    txt_CHIEUDAITU.Text = _Rowview.Row[CongsuatmayFields.Chieudaitu.Name].ToString();
                    txt_CHIEUDAIDEN.Text = _Rowview.Row[CongsuatmayFields.Chieudaiden.Name].ToString();
                    txt_SOMAUMA.Text = _Rowview.Row[CongsuatmayFields.Somauma.Name].ToString();
                    txt_SOHINHMA.Text = _Rowview.Row[CongsuatmayFields.Sohinhma.Name].ToString();
                    txt_MALOAIMANG.Text = _Rowview.Row[CongsuatmayFields.Maloaimang.Name].ToString();
                    txt_MAQCTHANHPHAM.Text = _Rowview.Row[CongsuatmayFields.Maqcthanhpham.Name].ToString();
                    txt_TOCDO.Text = _Rowview.Row[CongsuatmayFields.Tocdo.Name].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_CONGSUATMAY_CurrentChanged"); }
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            CongsuatmayManager _CongsuatmayManager = new CongsuatmayManager();
            CongsuatmayEntity _CongsuatmayEntity = new CongsuatmayEntity();
            r_Insert = DT_CONGSUATMAY.NewRow();
            DT_CONGSUATMAY.Rows.Add(r_Insert);
            BS_CONGSUATMAY.Position = DT_CONGSUATMAY.Rows.Count;
            MAHIEU_PK = "";
            txt_MACONGSUAT.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_CONGSUATMAY.Enabled = false;
            btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = true;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MACONGSUAT }));
                txt_TENCONGSUAT.Focus();
            }
            GRID_CONGSUATMAY.Enabled = false;
            btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_CONGSUATMAY.Rows.Remove(r_Insert);
            }
            BS_CONGSUATMAY_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_CONGSUATMAY.Enabled = true;
            btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = false;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            CongsuatmayManager _CongsuatmayManager = new CongsuatmayManager();
            CongsuatmayEntity _CongsuatmayEntity = new CongsuatmayEntity();
            _CongsuatmayEntity = _CongsuatmayManager.SelectOne(MAHIEU_PK);
            if (_CongsuatmayEntity != null && MessageBox.Show("Xóa công đoạn: " + MAHIEU_PK + " - " + txt_TENCONGSUAT.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _CongsuatmayManager.Delete(MAHIEU_PK);
                    GRID_CONGSUATMAY.CurrentRow.Delete();
                    BS_CONGSUATMAY_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CongsuatmayManager.Convert(_CongsuatmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công đoạn " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_CONGSUATMAY.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _CongsuatmayManager.SelectOne(txt_MACONGSUAT.Text.Trim()) != null)
            {
                MessageBox.Show("Mã công đoạn bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MACONGSUAT.Focus();
                return;
            }
            else if (txt_MACONGSUAT.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã công đoạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MACONGSUAT.Focus();
                return;
            }
            else if (txt_TENCONGSUAT.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên công đoạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENCONGSUAT.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_CONGSUATMAY.Enabled = true;
                btn_THEMMOI.Focus();
                btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = false;
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            CongsuatmayEntity _congsuatmayEntity = new CongsuatmayEntity();

            _congsuatmayEntity.Macongsuat = txt_MACONGSUAT.Text.Trim();
            _congsuatmayEntity.Tencongsuat = txt_TENCONGSUAT.Text.Trim();
            _congsuatmayEntity.Mamay = txt_MAMAY.Text.Trim();
            _congsuatmayEntity.Madongmay = txt_MADONGMAY.Text.Trim();
            _congsuatmayEntity.Macongdoan = txt_MACONGDOAN.Text.Trim();
            _congsuatmayEntity.Khotu = LIB.ConvertString.NumbertoDB(txt_KHOTU.Text.Trim());
            _congsuatmayEntity.Khoden = LIB.ConvertString.NumbertoDB(txt_KHODEN.Text.Trim());
            _congsuatmayEntity.Chieudaitu = LIB.ConvertString.NumbertoDB(txt_CHIEUDAITU.Text.Trim());
            _congsuatmayEntity.Chieudaiden = LIB.ConvertString.NumbertoDB(txt_CHIEUDAIDEN.Text.Trim());
            _congsuatmayEntity.Dodaytu = LIB.ConvertString.NumbertoDB(txt_DODAYTU.Text.Trim());
            _congsuatmayEntity.Dodayden = LIB.ConvertString.NumbertoDB(txt_DODAYDEN.Text.Trim());
            _congsuatmayEntity.Somauma = txt_SOMAUMA.Text.Trim();
            _congsuatmayEntity.Sohinhma = txt_SOHINHMA.Text.Trim();
            _congsuatmayEntity.Maloaimang = txt_MALOAIMANG.Text.Trim();
            _congsuatmayEntity.Maqcthanhpham = txt_MAQCTHANHPHAM.Text.Trim();
            _congsuatmayEntity.Tocdo = LIB.ConvertString.NumbertoDB(txt_TOCDO.Text.Trim());

            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _CongsuatmayEntity.Ngaytao = DateTime.Now;
                _CongsuatmayEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_DMCHUONG_PK = _CongsuatmayManager.InsertV2(_CongsuatmayEntity, r_Insert, DT_CONGSUATMAY, BS_CONGSUATMAY);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CongsuatmayManager.Convert(_CongsuatmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = false;
                BS_CONGSUATMAY.ResetCurrentItem();
            }
            else
            {
                _CongsuatmayEntity.Ngaysua = DateTime.Now;
                _CongsuatmayEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _CongsuatmayManager.Update(_CongsuatmayEntity);
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Macongsuat.Name].Value = _congsuatmayEntity.Macongsuat;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Tencongsuat.Name].Value = _congsuatmayEntity.Tencongsuat;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Mamay.Name].Value = _congsuatmayEntity.Mamay;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Madongmay.Name].Value = _congsuatmayEntity.Madongmay;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Macongdoan.Name].Value = _congsuatmayEntity.Macongdoan;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Khotu.Name].Value = _congsuatmayEntity.Khotu;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Khoden.Name].Value = _congsuatmayEntity.Khoden;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Chieudaitu.Name].Value = _congsuatmayEntity.Chieudaitu;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Chieudaiden.Name].Value = _congsuatmayEntity.Chieudaiden;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Dodaytu.Name].Value = _congsuatmayEntity.Dodaytu;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Dodayden.Name].Value = _congsuatmayEntity.Dodayden;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Somauma.Name].Value = _congsuatmayEntity.Somauma;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Sohinhma.Name].Value = _congsuatmayEntity.Sohinhma;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Maloaimang.Name].Value = _congsuatmayEntity.Maloaimang;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Maqcthanhpham.Name].Value = _congsuatmayEntity.Maqcthanhpham;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Tocdo.Name].Value = _congsuatmayEntity.Tocdo;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CongsuatmayManager.Convert(_CongsuatmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = false;
            }
            return _str_DMCHUONG_PK;
        }

        #region Validate
        private void txt_MAMAY_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAMAY.Text.Trim()) || DT_DMMAY == null || DT_DMMAY.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAMAY.Text.Trim().ToUpper();
            _RowViewSelect = checkmamay(Str_MASIEUTHI, DT_DMMAY);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMAY.xml",
                        DT_DMMAY, DmmayFields.Mamay.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAMAY.Text = _RowViewSelect[DmmayFields.Mamay.Name].ToString();
                txt_TENMAY.Text = _RowViewSelect[DmmayFields.Tenmay.Name].ToString();
            }
            else
            {
                txt_TENMAY.Text = _RowViewSelect[DmmayFields.Tenmay.Name].ToString();
            }
        }

        private DataRow checkmamay(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmmayFields.Mamay.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MADONGMAY_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MADONGMAY.Text.Trim()) || DT_DMDONGMAY == null || DT_DMDONGMAY.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MADONGMAY.Text.Trim().ToUpper();
            _RowViewSelect = checkmaDongmay(Str_MASIEUTHI, DT_DMDONGMAY);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMDONGMAY.xml",
                        DT_DMDONGMAY, DmdongmayFields.Madm.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MADONGMAY.Text = _RowViewSelect[DmdongmayFields.Madm.Name].ToString();
                txt_TENDONGMAY.Text = _RowViewSelect[DmdongmayFields.Tendongmay.Name].ToString();
            }
            else
                txt_TENDONGMAY.Text = _RowViewSelect[DmdongmayFields.Tendongmay.Name].ToString();
        }
        private DataRow checkmaDongmay(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmdongmayFields.Madm.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_CONGDOAN_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MACONGDOAN.Text.Trim()) || DT_DMCONGDOAN == null || DT_DMCONGDOAN.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MACONGDOAN.Text.Trim().ToUpper();
            _RowViewSelect = checkmaCongdoan(Str_MASIEUTHI, DT_DMCONGDOAN);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCONGDOAN.xml",
                        DT_DMCONGDOAN, DmcongdoanFields.Macd.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MACONGDOAN.Text = _RowViewSelect[DmcongdoanFields.Macd.Name].ToString();
                txt_TENCONGDOAN.Text = _RowViewSelect[DmcongdoanFields.Tencongdoan.Name].ToString();
            }
            else
                txt_TENCONGDOAN.Text = _RowViewSelect[DmcongdoanFields.Tencongdoan.Name].ToString();
        }
        private DataRow checkmaCongdoan(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmcongdoanFields.Macd.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void btn_CHONSOMAU_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH_CHON.xml", DT_SOMAU, DmquycachFields.Maquycach.Name, txt_SOMAUMA.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmquycachFields.Maquycach.Name].ToString() + ",";

            txt_SOMAUMA.Text = str;
        }

        private void btn_CHONSOHINH_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH_CHON.xml", DT_SOHINH, DmquycachFields.Maquycach.Name, txt_SOHINHMA.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmquycachFields.Maquycach.Name].ToString() + ",";

            txt_SOHINHMA.Text = str;
        }

        private void btn_CHONLOAIMANG_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH_CHON.xml", DT_LOAIMANG, DmquycachFields.Maquycach.Name, txt_MALOAIMANG.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmquycachFields.Maquycach.Name].ToString() + ",";

            txt_MALOAIMANG.Text = str;
        }

        private void btn_CHONQCTHANHPHAM_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH_CHON.xml", DT_QCTHANHPHAM, DmquycachFields.Maquycach.Name, txt_MAQCTHANHPHAM.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmquycachFields.Maquycach.Name].ToString() + ",";

            txt_MAQCTHANHPHAM.Text = str;
        }

        #endregion

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_CONGSUATMAY.ColumnAutoResize = true;
            else
                GRID_CONGSUATMAY.ColumnAutoResize = false;
        }

        private void FRM_CONGSUATMAY_FormClosing(object sender, FormClosingEventArgs e)
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
