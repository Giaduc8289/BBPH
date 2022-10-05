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
    public partial class FRM_DMNHOMNGUYENLIEU : FRM_DMPARENT
    {
        private DmnhomnguyenlieuManager _DmnhomnguyenlieuManager = new DmnhomnguyenlieuManager();
        private DmnhomnguyenlieuEntity _DmnhomnguyenlieuEntity = new DmnhomnguyenlieuEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMNHOMNGUYENLIEU = new DataTable();
        private BindingSource BS_DMNHOMNGUYENLIEU = new BindingSource();
        private DataRow r_Insert = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DMNHOMNGUYENLIEU = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";

        //private DataTable DT_DMCONGDOAN = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMNHOMNGUYENLIEU");
                        DT_DMNHOMNGUYENLIEU = LIB.SESSION_START.DT_DMNHOMNGUYENLIEU;

                        //DT_DMCONGDOAN = LIB.SESSION_START.DT_DMCONGDOAN;
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

        public FRM_DMNHOMNGUYENLIEU()
        {
            InitializeComponent();
            DmnhomnguyenlieuManager _DmnhomnguyenlieuManager = new DmnhomnguyenlieuManager();
            DataTable dt111 = _DmnhomnguyenlieuManager.Clone();
            GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMNHOMNGUYENLIEU.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMNHOMNGUYENLIEU.xml", GRID_DMNHOMNGUYENLIEU, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMNHOMNGUYENLIEU);
            BS_DMNHOMNGUYENLIEU = new BindingSource();
            BS_DMNHOMNGUYENLIEU.DataSource = Source_View;
            GRID_DMNHOMNGUYENLIEU.DataSource = BS_DMNHOMNGUYENLIEU;
            BS_DMNHOMNGUYENLIEU.CurrentChanged += new EventHandler(BS_DMNHOMNGUYENLIEU_CurrentChanged);
            BS_DMNHOMNGUYENLIEU_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMNHOMNGUYENLIEU_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_DMNHOMNGUYENLIEU.UpdateData();
                if (BS_DMNHOMNGUYENLIEU.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMNHOMNGUYENLIEU.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DmnhomnguyenlieuFields.Manhom.Name].ToString();
                    txt_MANHOM.Text = _Rowview.Row[DmnhomnguyenlieuFields.Manhom.Name].ToString();
                    txt_TENNL.Text = _Rowview.Row[DmnhomnguyenlieuFields.Tennhomnguyenlieu.Name].ToString();
                    txt_TENRUTGON.Text = _Rowview.Row[DmnhomnguyenlieuFields.Tenrutgon.Name].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMNHOMNGUYENLIEU_CurrentChanged"); }
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            DmnhomnguyenlieuEntity _DmnhomnguyenlieuEntity = new DmnhomnguyenlieuEntity();
            _DmnhomnguyenlieuEntity.Manhom = txt_MANHOM.Text.Trim();
            _DmnhomnguyenlieuEntity.Tennhomnguyenlieu = txt_TENNL.Text.Trim();
            _DmnhomnguyenlieuEntity.Tenrutgon = txt_TENRUTGON.Text.Trim();
            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _DmnhomnguyenlieuEntity.Ngaytao = DateTime.Now;
                _DmnhomnguyenlieuEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_DMCHUONG_PK = _DmnhomnguyenlieuManager.InsertV2(_DmnhomnguyenlieuEntity, r_Insert, DT_DMNHOMNGUYENLIEU, BS_DMNHOMNGUYENLIEU);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnhomnguyenlieuManager.Convert(_DmnhomnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMNHOMNGUYENLIEU.ResetCurrentItem();
            }
            else
            {
                _DmnhomnguyenlieuEntity.Ngaysua = DateTime.Now;
                _DmnhomnguyenlieuEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DmnhomnguyenlieuManager.Update(_DmnhomnguyenlieuEntity);
                GRID_DMNHOMNGUYENLIEU.CurrentRow.Cells[DmnhomnguyenlieuFields.Manhom.Name].Value = _DmnhomnguyenlieuEntity.Manhom;
                GRID_DMNHOMNGUYENLIEU.CurrentRow.Cells[DmnhomnguyenlieuFields.Tennhomnguyenlieu.Name].Value = _DmnhomnguyenlieuEntity.Tennhomnguyenlieu;
                GRID_DMNHOMNGUYENLIEU.CurrentRow.Cells[DmnhomnguyenlieuFields.Tenrutgon.Name].Value = _DmnhomnguyenlieuEntity.Tenrutgon;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnhomnguyenlieuManager.Convert(_DmnhomnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            DmnhomnguyenlieuManager _DmnhomnguyenlieuManager = new DmnhomnguyenlieuManager();
            DmnhomnguyenlieuEntity _DmnhomnguyenlieuEntity = new DmnhomnguyenlieuEntity();
            r_Insert = DT_DMNHOMNGUYENLIEU.NewRow();
            DT_DMNHOMNGUYENLIEU.Rows.Add(r_Insert);
            BS_DMNHOMNGUYENLIEU.Position = DT_DMNHOMNGUYENLIEU.Rows.Count;
            MAHIEU_PK = "";
            txt_MANHOM.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMNHOMNGUYENLIEU.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MANHOM }));
                txt_TENNL.Focus();
            }
            GRID_DMNHOMNGUYENLIEU.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMNHOMNGUYENLIEU.Rows.Remove(r_Insert);
            }
            BS_DMNHOMNGUYENLIEU_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMNHOMNGUYENLIEU.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DmnhomnguyenlieuManager _DmnhomnguyenlieuManager = new DmnhomnguyenlieuManager();
            DmnhomnguyenlieuEntity _DmnhomnguyenlieuEntity = new DmnhomnguyenlieuEntity();
            _DmnhomnguyenlieuEntity = _DmnhomnguyenlieuManager.SelectOne(MAHIEU_PK);
            if (_DmnhomnguyenlieuEntity != null && MessageBox.Show("Xóa khách hàng: " + MAHIEU_PK + " - " + txt_TENNL.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DmnhomnguyenlieuManager.Delete(MAHIEU_PK);
                    GRID_DMNHOMNGUYENLIEU.CurrentRow.Delete();
                    BS_DMNHOMNGUYENLIEU_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnhomnguyenlieuManager.Convert(_DmnhomnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa khách hàng " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMNHOMNGUYENLIEU.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DmnhomnguyenlieuManager.SelectOne(txt_MANHOM.Text.Trim()) != null)
            {
                MessageBox.Show("Mã khách hàng bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MANHOM.Focus();
                return;
            }
            else if (txt_MANHOM.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MANHOM.Focus();
                return;
            }
            else if (txt_TENNL.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENNL.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMNHOMNGUYENLIEU.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        //#region Validate
        //private void txt_CONGDOAN_Validating(object sender, CancelEventArgs e)
        //{
        //    _RowViewSelect = null;
        //    if (string.IsNullOrEmpty(txt_CONGDOAN.Text.Trim()) || DT_DMCONGDOAN == null || DT_DMCONGDOAN.Rows.Count == 0) return;
        //    string Str_MASIEUTHI = txt_CONGDOAN.Text.Trim().ToUpper();
        //    _RowViewSelect = checkmaCongdoan(Str_MASIEUTHI, DT_DMCONGDOAN);
        //    if (_RowViewSelect == null)
        //    {
        //        ListviewJanus _frm_SingerRows_Select =
        //            new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCONGDOAN.xml",
        //                DT_DMCONGDOAN, DmcongdoanFields.Macd.Name, Str_MASIEUTHI);
        //        _frm_SingerRows_Select.ShowDialog();
        //        if (_frm_SingerRows_Select._RowViewSelect == null) return;
        //        _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
        //        txt_CONGDOAN.Text = _RowViewSelect[DmcongdoanFields.Macd.Name].ToString();
        //        txt_TENCONGDOAN.Text = _RowViewSelect[DmcongdoanFields.Tencongdoan.Name].ToString();
        //    }
        //    else
        //        txt_TENCONGDOAN.Text = _RowViewSelect[DmcongdoanFields.Tencongdoan.Name].ToString();
        //}
        //private DataRow checkmaCongdoan(string masieuthi, DataTable dt)
        //{
        //    try
        //    {
        //        return dt.Select(DmcongdoanFields.Macd.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
        //    }
        //    catch { return null; }
        //}
        //#endregion

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_DMNHOMNGUYENLIEU.ColumnAutoResize = true;
            else
                GRID_DMNHOMNGUYENLIEU.ColumnAutoResize = false;
        }

        private void txt_MAHIEU_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRM_DMNHOMNGUYENLIEU_FormClosing(object sender, FormClosingEventArgs e)
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
