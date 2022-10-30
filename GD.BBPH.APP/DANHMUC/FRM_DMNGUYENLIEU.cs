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
    public partial class FRM_DMNGUYENLIEU : FRM_DMPARENT
    {
        private DmnguyenlieuManager _DmnguyenlieuManager = new DmnguyenlieuManager();
        private DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMNGUYENLIEU = new DataTable();
        private BindingSource BS_DMNGUYENLIEU = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DMNGUYENLIEU = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";

        private DataTable DT_DMNHOMNGUYENLIEU = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMNGUYENLIEU");
                        DT_DMNGUYENLIEU = LIB.SESSION_START.DT_DMNGUYENLIEU;

                        DT_DMNHOMNGUYENLIEU = LIB.SESSION_START.DT_DMNHOMNGUYENLIEU;
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

        public FRM_DMNGUYENLIEU()
        {
            InitializeComponent();
            DmnguyenlieuManager _DmnguyenlieuManager = new DmnguyenlieuManager();
            DataTable dt111 = _DmnguyenlieuManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMNGUYENLIEU.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMNGUYENLIEU.xml", GRID_DMNGUYENLIEU, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMNGUYENLIEU);
            BS_DMNGUYENLIEU = new BindingSource();
            BS_DMNGUYENLIEU.DataSource = Source_View;
            GRID_DMNGUYENLIEU.DataSource = BS_DMNGUYENLIEU;
            BS_DMNGUYENLIEU.CurrentChanged += new EventHandler(BS_DMNGUYENLIEU_CurrentChanged);
            BS_DMNGUYENLIEU_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMNGUYENLIEU_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_DMNGUYENLIEU.UpdateData();
                if (BS_DMNGUYENLIEU.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMNGUYENLIEU.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DmnguyenlieuFields.Manl.Name].ToString();
                    txt_MAHIEU.Text = _Rowview.Row[DmnguyenlieuFields.Manl.Name].ToString();
                    txt_TENHIEU.Text = _Rowview.Row[DmnguyenlieuFields.Tenrutgon.Name].ToString();
                    txt_MANHOM.Text = _Rowview.Row[DmnguyenlieuFields.Manhom.Name].ToString();
                    txt_TENHIEU.Text = _Rowview.Row[DmnguyenlieuFields.Tennl.Name].ToString();
                    txt_GIA.Text = _Rowview.Row[DmnguyenlieuFields.Gia.Name].ToString();
                    txt_NGAY.Text = _Rowview.Row[DmnguyenlieuFields.Ngay.Name].ToString();
                    txt_GIAHIENTAI.Text = _Rowview.Row[DmnguyenlieuFields.Giahientai.Name].ToString();
                    txt_TANG.Text = _Rowview.Row[DmnguyenlieuFields.Tang.Name].ToString();
                    txt_GIAM.Text = _Rowview.Row[DmnguyenlieuFields.Giam.Name].ToString();


                    txt_MANHOMNGUYENLIEU_Validating(new object(), new CancelEventArgs());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMNGUYENLIEU_CurrentChanged"); }
        }

        private string Save_Data(string _str_MAHIEU_PK)
        {
            DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity();
            _DmnguyenlieuEntity.Manl = txt_MAHIEU.Text.Trim();
            _DmnguyenlieuEntity.Tenrutgon = txt_TENHIEU.Text.Trim();
            _DmnguyenlieuEntity.Manhom = txt_MANHOM.Text.Trim();
            _DmnguyenlieuEntity.Tennhom = txt_TENNHOM.Text.Trim();
            _DmnguyenlieuEntity.Tennl = txt_TENNGUYENLIEU.Text.Trim();
            _DmnguyenlieuEntity.Gia = Convert.ToDecimal(txt_GIA.Text.Trim());
            _DmnguyenlieuEntity.Ngay = Convert.ToDateTime(txt_NGAY.Text.Trim());
            _DmnguyenlieuEntity.Giahientai = Convert.ToDecimal(txt_GIAHIENTAI.Text.Trim());
            _DmnguyenlieuEntity.Tang = Convert.ToDecimal(txt_TANG.Text.Trim());
            _DmnguyenlieuEntity.Giam = Convert.ToDecimal(txt_GIAM.Text.Trim());

            if (string.IsNullOrEmpty(_str_MAHIEU_PK))
            {
                _DmnguyenlieuEntity.Ngaytao = DateTime.Now;
                _DmnguyenlieuEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_MAHIEU_PK = _DmnguyenlieuManager.InsertV2(_DmnguyenlieuEntity, r_Insert, DT_DMNGUYENLIEU, BS_DMNGUYENLIEU);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnguyenlieuManager.Convert(_DmnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMNGUYENLIEU.ResetCurrentItem();
            }
            else
            {
                _DmnguyenlieuEntity.Ngaysua = DateTime.Now;
                _DmnguyenlieuEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DmnguyenlieuManager.Update(_DmnguyenlieuEntity);
                GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Manl.Name].Value = _DmnguyenlieuEntity.Manl;
                GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Tenrutgon.Name].Value = _DmnguyenlieuEntity.Tenrutgon;
                GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Manhom.Name].Value = _DmnguyenlieuEntity.Manhom;
                GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Tennhom.Name].Value = _DmnguyenlieuEntity.Tennhom;
                GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Tennl.Name].Value = _DmnguyenlieuEntity.Tennl;
                GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Gia.Name].Value = _DmnguyenlieuEntity.Gia;
                GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Ngay.Name].Value = _DmnguyenlieuEntity.Ngay;
                GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Giahientai.Name].Value = _DmnguyenlieuEntity.Giahientai;
                GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Tang.Name].Value = _DmnguyenlieuEntity.Tang;
                GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Giam.Name].Value = _DmnguyenlieuEntity.Giam;

                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnguyenlieuManager.Convert(_DmnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            r_Insert = DT_DMNGUYENLIEU.NewRow();
            DT_DMNGUYENLIEU.Rows.Add(r_Insert);
            BS_DMNGUYENLIEU.Position = DT_DMNGUYENLIEU.Rows.Count;
            MAHIEU_PK = "";
            txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMNGUYENLIEU.Enabled = false;
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
            GRID_DMNGUYENLIEU.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMNGUYENLIEU.Rows.Remove(r_Insert);
            }
            BS_DMNGUYENLIEU_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMNGUYENLIEU.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DmnguyenlieuManager _DmnguyenlieuManager = new DmnguyenlieuManager();
            DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity();
            _DmnguyenlieuEntity = _DmnguyenlieuManager.SelectOne(MAHIEU_PK);
            if (_DmnguyenlieuEntity != null && MessageBox.Show("Xóa khách hàng: " + MAHIEU_PK + " - " + txt_TENHIEU.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DmnguyenlieuManager.Delete(MAHIEU_PK);
                    GRID_DMNGUYENLIEU.CurrentRow.Delete();
                    BS_DMNGUYENLIEU_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnguyenlieuManager.Convert(_DmnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa khách hàng " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMNGUYENLIEU.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DmnguyenlieuManager.SelectOne(txt_MAHIEU.Text.Trim()) != null)
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
                MessageBox.Show("Yêu cầu nhập tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENHIEU.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMNGUYENLIEU.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validate
        private void txt_MANHOMNGUYENLIEU_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MANHOM.Text.Trim()) || DT_DMNHOMNGUYENLIEU == null || DT_DMNHOMNGUYENLIEU.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MANHOM.Text.Trim().ToUpper();
            _RowViewSelect = checkmaNhomnguyenlieu(Str_MASIEUTHI, DT_DMNHOMNGUYENLIEU);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMNHOMNGUYENLIEU.xml",
                        DT_DMNHOMNGUYENLIEU, DmnhomnguyenlieuFields.Manhom.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MANHOM.Text = _RowViewSelect[DmnhomnguyenlieuFields.Manhom.Name].ToString();
                txt_TENNHOM.Text = _RowViewSelect[DmnhomnguyenlieuFields.Tennhomnguyenlieu.Name].ToString();
            }
            else
                txt_TENNHOM.Text = _RowViewSelect[DmnhomnguyenlieuFields.Tennhomnguyenlieu.Name].ToString();
        }
        private DataRow checkmaNhomnguyenlieu(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmnhomnguyenlieuFields.Manhom.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion

        #region Shortcut Key
        private void txt_MANHOMNGUYENLIEU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMNHOMNGUYENLIEU frm_Dm = new FRM_DMNHOMNGUYENLIEU();
                frm_Dm.Text = "Danh mục nhóm nguyên liệu";
                frm_Dm.ShowDialog();
                DT_DMNHOMNGUYENLIEU = new DmnhomnguyenlieuManager().SelectAllRDT();
            }
        }
        #endregion
        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_DMNGUYENLIEU.ColumnAutoResize = true;
            else
                GRID_DMNGUYENLIEU.ColumnAutoResize = false;
        }

        private void FRM_DMNGUYENLIEU_FormClosing(object sender, FormClosingEventArgs e)
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
