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
    public partial class FRM_DMCHUCVU : FRM_DMPARENT
    {
        private DmchucvuManager _DmchucvuManager = new DmchucvuManager();
        private DmchucvuEntity _DmchucvuEntity = new DmchucvuEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMCHUCVU = new DataTable();
        private BindingSource BS_DMCHUCVU = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DMCHUCVU = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";

        //private DataTable DT_DMPHONGBAN = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMCHUCVU");
                        DT_DMCHUCVU = LIB.SESSION_START.DT_DMCHUCVU;

                        //DT_DMPHONGBAN = LIB.SESSION_START.DT_DMPHONGBAN;
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

        public FRM_DMCHUCVU()
        {
            InitializeComponent();
            DmchucvuManager _DmchucvuManager = new DmchucvuManager();
            DataTable dt111 = _DmchucvuManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCHUCVU.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCHUCVU.xml", GRID_DMCHUCVU, uiPanel0Container);
            //GRID_DMCHUCVU.RootTable.Groups.Add(GRID_DMCHUCVU.Tables[0].Columns[DmchucvuFields.Phongban.Name]);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMCHUCVU);
            BS_DMCHUCVU = new BindingSource();
            BS_DMCHUCVU.DataSource = Source_View;
            GRID_DMCHUCVU.DataSource = BS_DMCHUCVU;
            BS_DMCHUCVU.CurrentChanged += new EventHandler(BS_DMCHUCVU_CurrentChanged);
            BS_DMCHUCVU_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMCHUCVU_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_DMCHUCVU.UpdateData();
                if (BS_DMCHUCVU.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMCHUCVU.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DmchucvuFields.Macv.Name].ToString();
                    txt_MAHIEU.Text = _Rowview.Row[DmchucvuFields.Macv.Name].ToString();
                    txt_TENHIEU.Text = _Rowview.Row[DmchucvuFields.Tenchucvu.Name].ToString();
                    txt_HESO.Text = _Rowview.Row[DmchucvuFields.Heso.Name].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMCHUCVU_CurrentChanged"); }
        }

        private string Save_Data(string _str_MAHIEU_PK)
        {
            DmchucvuEntity _DmchucvuEntity = new DmchucvuEntity();
            _DmchucvuEntity.Macv = txt_MAHIEU.Text.Trim();
            _DmchucvuEntity.Tenchucvu = txt_TENHIEU.Text.Trim();
            try { _DmchucvuEntity.Heso = System.Decimal.Parse(txt_HESO.Text.Trim()); }
            catch { }
            if (string.IsNullOrEmpty(_str_MAHIEU_PK))
            {
                _DmchucvuEntity.Ngaytao = DateTime.Now;
                _DmchucvuEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_MAHIEU_PK = _DmchucvuManager.InsertV2(_DmchucvuEntity, r_Insert, DT_DMCHUCVU, BS_DMCHUCVU);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchucvuManager.Convert(_DmchucvuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMCHUCVU.ResetCurrentItem();
            }
            else
            {
                _DmchucvuEntity.Ngaysua = DateTime.Now;
                _DmchucvuEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DmchucvuManager.Update(_DmchucvuEntity);
                GRID_DMCHUCVU.CurrentRow.Cells[DmchucvuFields.Macv.Name].Value = _DmchucvuEntity.Macv;
                GRID_DMCHUCVU.CurrentRow.Cells[DmchucvuFields.Tenchucvu.Name].Value = _DmchucvuEntity.Tenchucvu;
                GRID_DMCHUCVU.CurrentRow.Cells[DmchucvuFields.Heso.Name].Value = _DmchucvuEntity.Heso;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchucvuManager.Convert(_DmchucvuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            r_Insert = DT_DMCHUCVU.NewRow();
            DT_DMCHUCVU.Rows.Add(r_Insert);
            BS_DMCHUCVU.Position = DT_DMCHUCVU.Rows.Count;
            MAHIEU_PK = "";
            txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            //GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_PHONGBAN, txt_CHUCVU }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMCHUCVU.Enabled = false;
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
            GRID_DMCHUCVU.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMCHUCVU.Rows.Remove(r_Insert);
            }
            BS_DMCHUCVU_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMCHUCVU.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DmchucvuManager _DmchucvuManager = new DmchucvuManager();
            DmchucvuEntity _DmchucvuEntity = new DmchucvuEntity();
            _DmchucvuEntity = _DmchucvuManager.SelectOne(MAHIEU_PK);
            if (_DmchucvuEntity != null && MessageBox.Show("Xóa công nhân: " + MAHIEU_PK + " - " + txt_TENHIEU.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DmchucvuManager.Delete(MAHIEU_PK);
                    GRID_DMCHUCVU.CurrentRow.Delete();
                    BS_DMCHUCVU_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchucvuManager.Convert(_DmchucvuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công nhân " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMCHUCVU.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DmchucvuManager.SelectOne(txt_MAHIEU.Text.Trim()) != null)
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
                GRID_DMCHUCVU.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Shortcut Key
        //private void txt_MAPHONGBAN_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.F4)
        //    {
        //        FRM_DMPHONGBAN frm_Dm = new FRM_DMPHONGBAN();
        //        frm_Dm.Text = "Danh mục phòng ban";
        //        frm_Dm.ShowDialog();
        //        DT_DMPHONGBAN = new DanhmucphongbanManager().SelectAllRDT();
        //    }
        //}
        #endregion

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_DMCHUCVU.ColumnAutoResize = true;
            else
                GRID_DMCHUCVU.ColumnAutoResize = false;
        }

        private void FRM_DMCHUCVU_FormClosing(object sender, FormClosingEventArgs e)
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
