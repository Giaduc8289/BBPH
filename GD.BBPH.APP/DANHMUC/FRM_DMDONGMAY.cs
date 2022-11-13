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
    public partial class FRM_DMDONGMAY : FRM_DMPARENT
    {
        private DmdongmayManager _DmdongmayManager = new DmdongmayManager();
        private DmdongmayEntity _DmdongmayEntity = new DmdongmayEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMDONGMAY = new DataTable();
        private BindingSource BS_DMDONGMAY = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DMDONGMAY = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";

        private DataTable DT_DMCONGDOAN = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMDONGMAY");
                        DT_DMDONGMAY = LIB.SESSION_START.DT_DMDONGMAY;

                        DT_DMCONGDOAN = LIB.SESSION_START.DT_DMCONGDOAN;
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

        public FRM_DMDONGMAY()
        {
            InitializeComponent();
            DmdongmayManager _DmdongmayManager = new DmdongmayManager();
            DataTable dt111 = _DmdongmayManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMDONGMAY.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMDONGMAY.xml", GRID_DMDONGMAY, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMDONGMAY);
            BS_DMDONGMAY = new BindingSource();
            BS_DMDONGMAY.DataSource = Source_View;
            GRID_DMDONGMAY.DataSource = BS_DMDONGMAY;
            BS_DMDONGMAY.CurrentChanged += new EventHandler(BS_DMDONGMAY_CurrentChanged);
            BS_DMDONGMAY_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMDONGMAY_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_DMDONGMAY.UpdateData();
                if (BS_DMDONGMAY.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMDONGMAY.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DmdongmayFields.Madm.Name].ToString();
                    txt_MAHIEU.Text = _Rowview.Row[DmdongmayFields.Madm.Name].ToString();
                    txt_TENHIEU.Text = _Rowview.Row[DmdongmayFields.Tendongmay.Name].ToString();
                    txt_MACONGDOAN.Text = _Rowview.Row[DmdongmayFields.Macd.Name].ToString();

                    txt_CONGDOAN_Validating(new object(), new CancelEventArgs());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMDONGMAY_CurrentChanged"); }
        }

        private string Save_Data(string _str_MAHIEU_PK)
        {
            DmdongmayEntity _DmdongmayEntity = new DmdongmayEntity();
            _DmdongmayEntity.Madm = txt_MAHIEU.Text.Trim();
            _DmdongmayEntity.Tendongmay = txt_TENHIEU.Text.Trim();
            _DmdongmayEntity.Macd = txt_MACONGDOAN.Text.Trim();
            if (string.IsNullOrEmpty(_str_MAHIEU_PK))
            {
                _DmdongmayEntity.Ngaytao = DateTime.Now;
                _DmdongmayEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_MAHIEU_PK = _DmdongmayManager.InsertV2(_DmdongmayEntity, r_Insert, DT_DMDONGMAY, BS_DMDONGMAY);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmdongmayManager.Convert(_DmdongmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMDONGMAY.ResetCurrentItem();
            }
            else
            {
                _DmdongmayEntity.Ngaysua = DateTime.Now;
                _DmdongmayEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DmdongmayManager.Update(_DmdongmayEntity);
                GRID_DMDONGMAY.CurrentRow.Cells[DmdongmayFields.Madm.Name].Value = _DmdongmayEntity.Madm;
                GRID_DMDONGMAY.CurrentRow.Cells[DmdongmayFields.Tendongmay.Name].Value = _DmdongmayEntity.Tendongmay;
                GRID_DMDONGMAY.CurrentRow.Cells[DmdongmayFields.Macd.Name].Value = _DmdongmayEntity.Macd;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmdongmayManager.Convert(_DmdongmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            r_Insert = DT_DMDONGMAY.NewRow();
            DT_DMDONGMAY.Rows.Add(r_Insert);
            BS_DMDONGMAY.Position = DT_DMDONGMAY.Rows.Count;
            MAHIEU_PK = "";
            txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMDONGMAY.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MAHIEU }));
                txt_TENHIEU.Focus();
            }
            GRID_DMDONGMAY.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMDONGMAY.Rows.Remove(r_Insert);
            }
            BS_DMDONGMAY_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMDONGMAY.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DmdongmayManager _DmdongmayManager = new DmdongmayManager();
            DmdongmayEntity _DmdongmayEntity = new DmdongmayEntity();
            _DmdongmayEntity = _DmdongmayManager.SelectOne(MAHIEU_PK);
            if (_DmdongmayEntity != null && MessageBox.Show("Xóa khách hàng: " + MAHIEU_PK + " - " + txt_TENHIEU.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DmdongmayManager.Delete(MAHIEU_PK);
                    GRID_DMDONGMAY.CurrentRow.Delete();
                    BS_DMDONGMAY_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmdongmayManager.Convert(_DmdongmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa khách hàng " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMDONGMAY.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DmdongmayManager.SelectOne(txt_MAHIEU.Text.Trim()) != null)
            {
                MessageBox.Show("Mã khách hàng bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_MAHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_TENHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENHIEU.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMDONGMAY.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validate
        private void txt_CONGDOAN_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MACONGDOAN.Text.Trim()) || DT_DMCONGDOAN == null || DT_DMCONGDOAN.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MACONGDOAN.Text.Trim().ToUpper();
            _RowViewSelect = checkmaCongdoan(_str_MACANTIM, DT_DMCONGDOAN);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCONGDOAN.xml",
                        DT_DMCONGDOAN, DmcongdoanFields.Macd.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MACONGDOAN.Text = _RowViewSelect[DmcongdoanFields.Macd.Name].ToString();
                txt_TENCONGDOAN.Text = _RowViewSelect[DmcongdoanFields.Tencongdoan.Name].ToString();
            }
            else
                txt_TENCONGDOAN.Text = _RowViewSelect[DmcongdoanFields.Tencongdoan.Name].ToString();
        }
        private DataRow checkmaCongdoan(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmcongdoanFields.Macd.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion

        #region Shortcut Key
        private void txt_MACONGDOAN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMCONGDOAN frm_Dm = new FRM_DMCONGDOAN();
                frm_Dm.Text = "Danh mục công đoạn";
                frm_Dm.ShowDialog();
                DT_DMCONGDOAN = new DmcongdoanManager().SelectAllRDT();
            }
        }
        #endregion

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_DMDONGMAY.ColumnAutoResize = true;
            else
                GRID_DMDONGMAY.ColumnAutoResize = false;
        }

        private void FRM_DMDONGMAY_FormClosing(object sender, FormClosingEventArgs e)
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
