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
    public partial class FRM_DMCONGNHAN : FRM_DMPARENT
    {
        private DmcongnhanManager _DmcongnhanManager = new DmcongnhanManager();
        private DmcongnhanEntity _DmcongnhanEntity = new DmcongnhanEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMCONGNHAN = new DataTable();
        private BindingSource BS_DMCONGNHAN = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DMCONGNHAN = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";

        private DataTable DT_DMBOPHAN = new DataTable(), DT_DMCHUCVU = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMCONGNHAN");
                        DT_DMCONGNHAN = LIB.SESSION_START.DT_DMCONGNHAN;

                        DT_DMBOPHAN = LIB.SESSION_START.DT_DMBOPHAN;
                        DT_DMCHUCVU = LIB.SESSION_START.DT_DMCHUCVU;
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

        public FRM_DMCONGNHAN()
        {
            InitializeComponent();
            DmcongnhanManager _DmcongnhanManager = new DmcongnhanManager();
            DataTable dt111 = _DmcongnhanManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCONGNHAN.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCONGNHAN.xml", GRID_DMCONGNHAN, uiPanel0Container);
            //GRID_DMCONGNHAN.RootTable.Groups.Add(GRID_DMCONGNHAN.Tables[0].Columns[DmcongnhanFields.Phongban.Name]);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMCONGNHAN);
            BS_DMCONGNHAN = new BindingSource();
            BS_DMCONGNHAN.DataSource = Source_View;
            GRID_DMCONGNHAN.DataSource = BS_DMCONGNHAN;
            BS_DMCONGNHAN.CurrentChanged += new EventHandler(BS_DMCONGNHAN_CurrentChanged);
            BS_DMCONGNHAN_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMCONGNHAN_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_DMCONGNHAN.UpdateData();
                if (BS_DMCONGNHAN.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMCONGNHAN.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DmcongnhanFields.Macn.Name].ToString();
                    txt_MAHIEU.Text = _Rowview.Row[DmcongnhanFields.Macn.Name].ToString();
                    txt_TENHIEU.Text = _Rowview.Row[DmcongnhanFields.Hovatencongnhan.Name].ToString();
                    txt_TEN.Text = _Rowview.Row[DmcongnhanFields.Tencongnhan.Name].ToString();
                    txt_MAPHONGBAN.Text = _Rowview.Row[DmcongnhanFields.Mabp.Name].ToString();
                    txt_MACHUCVU.Text = _Rowview.Row[DmcongnhanFields.Macv.Name].ToString();
                    txt_SODIENTHOAI.Text = _Rowview.Row[DmcongnhanFields.Sodienthoai.Name].ToString();

                    try { chk_DANGHI.Checked = Convert.ToBoolean(_Rowview.Row[DmcongnhanFields.Danghi.Name].ToString()); }
                    catch { }

                    txt_MAPHONGBAN_Validating(new object(), new CancelEventArgs());
                    txt_MACHUCVU_Validating(new object(), new CancelEventArgs());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMCONGNHAN_CurrentChanged"); }
        }

        private string Save_Data(string _str_MAHIEU_PK)
        {
            DmcongnhanEntity _DmcongnhanEntity = new DmcongnhanEntity();
            _DmcongnhanEntity.Macn = txt_MAHIEU.Text.Trim();
            _DmcongnhanEntity.Hovatencongnhan = txt_TENHIEU.Text.Trim();
            _DmcongnhanEntity.Tencongnhan = txt_TEN.Text.Trim();
            _DmcongnhanEntity.Mabp = txt_MAPHONGBAN.Text.Trim();
            _DmcongnhanEntity.Phongban = txt_PHONGBAN.Text.Trim();
            _DmcongnhanEntity.Macv = txt_MACHUCVU.Text.Trim();
            _DmcongnhanEntity.Chucvu = txt_CHUCVU.Text.Trim();
            _DmcongnhanEntity.Sodienthoai = txt_SODIENTHOAI.Text.Trim();
            if (chk_DANGHI.Checked)
                _DmcongnhanEntity.Danghi = true;
            else
                _DmcongnhanEntity.Danghi = false;
            if (string.IsNullOrEmpty(_str_MAHIEU_PK))
            {
                _DmcongnhanEntity.Ngaytao = DateTime.Now;
                _DmcongnhanEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_MAHIEU_PK = _DmcongnhanManager.InsertV2(_DmcongnhanEntity, r_Insert, DT_DMCONGNHAN, BS_DMCONGNHAN);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcongnhanManager.Convert(_DmcongnhanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMCONGNHAN.ResetCurrentItem();
            }
            else
            {
                _DmcongnhanEntity.Ngaysua = DateTime.Now;
                _DmcongnhanEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DmcongnhanManager.Update(_DmcongnhanEntity);
                GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Macn.Name].Value = _DmcongnhanEntity.Macn;
                GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Hovatencongnhan.Name].Value = _DmcongnhanEntity.Hovatencongnhan;
                GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Tencongnhan.Name].Value = _DmcongnhanEntity.Tencongnhan;
                GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Mabp.Name].Value = _DmcongnhanEntity.Mabp;
                GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Phongban.Name].Value = _DmcongnhanEntity.Phongban;
                GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Macv.Name].Value = _DmcongnhanEntity.Macv;
                GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Chucvu.Name].Value = _DmcongnhanEntity.Chucvu;
                GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Sodienthoai.Name].Value = _DmcongnhanEntity.Sodienthoai;
                GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Danghi.Name].Value = _DmcongnhanEntity.Danghi;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcongnhanManager.Convert(_DmcongnhanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_PHONGBAN.Text = string.Empty;
            txt_CHUCVU.Text = string.Empty;
            r_Insert = DT_DMCONGNHAN.NewRow();
            DT_DMCONGNHAN.Rows.Add(r_Insert);
            BS_DMCONGNHAN.Position = DT_DMCONGNHAN.Rows.Count;
            MAHIEU_PK = "";
            txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_PHONGBAN, txt_CHUCVU }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMCONGNHAN.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MAHIEU, txt_PHONGBAN, txt_CHUCVU }));
                txt_TENHIEU.Focus();
            }
            GRID_DMCONGNHAN.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMCONGNHAN.Rows.Remove(r_Insert);
            }
            BS_DMCONGNHAN_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMCONGNHAN.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DmcongnhanManager _DmcongnhanManager = new DmcongnhanManager();
            DmcongnhanEntity _DmcongnhanEntity = new DmcongnhanEntity();
            _DmcongnhanEntity = _DmcongnhanManager.SelectOne(MAHIEU_PK);
            if (_DmcongnhanEntity != null && MessageBox.Show("Xóa công nhân: " + MAHIEU_PK + " - " + txt_TENHIEU.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DmcongnhanManager.Delete(MAHIEU_PK);
                    GRID_DMCONGNHAN.CurrentRow.Delete();
                    BS_DMCONGNHAN_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcongnhanManager.Convert(_DmcongnhanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công nhân " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMCONGNHAN.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DmcongnhanManager.SelectOne(txt_MAHIEU.Text.Trim()) != null)
            {
                MessageBox.Show("Mã công nhân bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_MAHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã công nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_TENHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên công nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENHIEU.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMCONGNHAN.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validate
        private void txt_MAPHONGBAN_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAPHONGBAN.Text.Trim()) || DT_DMBOPHAN == null || DT_DMBOPHAN.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MAPHONGBAN.Text.Trim().ToUpper();
            _RowViewSelect = checkmaPhongban(_str_MACANTIM, DT_DMBOPHAN);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMBOPHAN.xml",
                        DT_DMBOPHAN, DmbophanFields.Mabp.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAPHONGBAN.Text = _RowViewSelect[DmbophanFields.Mabp.Name].ToString();
                txt_PHONGBAN.Text = _RowViewSelect[DmbophanFields.Tenbophan.Name].ToString();
            }
            else
                txt_PHONGBAN.Text = _RowViewSelect[DmbophanFields.Tenbophan.Name].ToString();
        }
        private DataRow checkmaPhongban(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmbophanFields.Mabp.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MACHUCVU_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MACHUCVU.Text.Trim()) || DT_DMCHUCVU == null || DT_DMCHUCVU.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MACHUCVU.Text.Trim().ToUpper();
            _RowViewSelect = checkMACHUCVU(_str_MACANTIM, DT_DMCHUCVU);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCHUCVU.xml",
                        DT_DMCHUCVU, DmchucvuFields.Macv.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MACHUCVU.Text = _RowViewSelect[DmchucvuFields.Macv.Name].ToString();
                txt_CHUCVU.Text = _RowViewSelect[DmchucvuFields.Tenchucvu.Name].ToString();
            }
            else
                txt_CHUCVU.Text = _RowViewSelect[DmchucvuFields.Tenchucvu.Name].ToString();
        }

       

        private DataRow checkMACHUCVU(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmchucvuFields.Macv.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        
        #endregion

        #region Shortcut Key
        private void txt_MAPHONGBAN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMBOPHAN frm_Bp = new FRM_DMBOPHAN();
                frm_Bp.Text = "Danh mục bộ phận";
                frm_Bp.ShowDialog();
                DT_DMBOPHAN = new DmbophanManager().SelectAllRDT();
            }
        }

        private void txt_MACHUCVU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMCHUCVU frm_CV = new FRM_DMCHUCVU();
                frm_CV.Text = "Danh mục chức vụ";
                frm_CV.ShowDialog();
                DT_DMCHUCVU = new DmchucvuManager().SelectAllRDT();
            }
        }
        #endregion

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_DMCONGNHAN.ColumnAutoResize = true;
            else
                GRID_DMCONGNHAN.ColumnAutoResize = false;
        }

        private void FRM_DMCONGNHAN_FormClosing(object sender, FormClosingEventArgs e)
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
