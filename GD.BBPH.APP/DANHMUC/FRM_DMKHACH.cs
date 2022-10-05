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
    public partial class FRM_DMKHACH : FRM_DMPARENT
    {
        private DmkhachManager _DmkhachManager = new DmkhachManager();
        private DmkhachEntity _DmkhachEntity = new DmkhachEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMKHACH = new DataTable();
        private BindingSource BS_DMKHACH = new BindingSource();
        private DataRow r_Insert = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DMKHACH = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMKHACH");
                        DT_DMKHACH = LIB.SESSION_START.DT_DMKHACH;
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

        public FRM_DMKHACH()
        {
            InitializeComponent();
            DmkhachManager _DmkhachManager = new DmkhachManager();
            DataTable dt111 = _DmkhachManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMKHACH.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMKHACH.xml", GRID_DMKHACH, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMKHACH);
            BS_DMKHACH = new BindingSource();
            BS_DMKHACH.DataSource = Source_View;
            GRID_DMKHACH.DataSource = BS_DMKHACH;
            BS_DMKHACH.CurrentChanged += new EventHandler(BS_DMKHACH_CurrentChanged);
            BS_DMKHACH_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMKHACH_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_DMKHACH.UpdateData();
                if (BS_DMKHACH.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMKHACH.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DmkhachFields.Makhach.Name].ToString();
                    txt_MAHIEU.Text = _Rowview.Row[DmkhachFields.Makhach.Name].ToString();
                    txt_TENHIEU.Text = _Rowview.Row[DmkhachFields.Tenkhach.Name].ToString();
                    txt_DIACHI.Text = _Rowview.Row[DmkhachFields.Diachi.Name].ToString();
                    txt_SODIENTHOAI.Text = _Rowview.Row[DmkhachFields.Sodienthoai.Name].ToString();
                    txt_EMAIL.Text = _Rowview.Row[DmkhachFields.Email.Name].ToString();
                    txt_NGUOILIENHE.Text = _Rowview.Row[DmkhachFields.Tennguoilh.Name].ToString();
                    try
                    {
                        chk_TRUYENTHONG.Checked = Convert.ToBoolean(_Rowview.Row[DmkhachFields.Truyenthong.Name].ToString());
                    }
                    catch { }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMKHACH_CurrentChanged"); }
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            DmkhachEntity _DmkhachEntity = new DmkhachEntity();
            _DmkhachEntity.Makhach = txt_MAHIEU.Text.Trim();
            _DmkhachEntity.Tenkhach = txt_TENHIEU.Text.Trim();
            _DmkhachEntity.Diachi = txt_DIACHI.Text.Trim();
            _DmkhachEntity.Sodienthoai = txt_SODIENTHOAI.Text.Trim();
            _DmkhachEntity.Email = txt_EMAIL.Text.Trim();
            _DmkhachEntity.Tennguoilh = txt_NGUOILIENHE.Text.Trim();
            if (chk_TRUYENTHONG.Checked)
                _DmkhachEntity.Truyenthong = true;
            else
                _DmkhachEntity.Truyenthong = false;
            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _str_DMCHUONG_PK = _DmkhachManager.InsertV2(_DmkhachEntity, r_Insert, DT_DMKHACH, BS_DMKHACH);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmkhachManager.Convert(_DmkhachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMKHACH.ResetCurrentItem();
            }
            else
            {
                _DmkhachManager.Update(_DmkhachEntity);
                GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Makhach.Name].Value = _DmkhachEntity.Makhach;
                GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Tenkhach.Name].Value = _DmkhachEntity.Tenkhach;
                GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Diachi.Name].Value = _DmkhachEntity.Diachi;
                GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Sodienthoai.Name].Value = _DmkhachEntity.Sodienthoai;
                GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Email.Name].Value = _DmkhachEntity.Email;
                GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Truyenthong.Name].Value = _DmkhachEntity.Truyenthong;
                GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Tennguoilh.Name].Value = _DmkhachEntity.Tennguoilh;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmkhachManager.Convert(_DmkhachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            DmkhachManager _DmkhachManager = new DmkhachManager();
            DmkhachEntity _DmkhachEntity = new DmkhachEntity();
            r_Insert = DT_DMKHACH.NewRow();
            DT_DMKHACH.Rows.Add(r_Insert);
            BS_DMKHACH.Position = DT_DMKHACH.Rows.Count;
            MAHIEU_PK = "";
            txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMKHACH.Enabled = false;
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
            GRID_DMKHACH.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMKHACH.Rows.Remove(r_Insert);
            }
            BS_DMKHACH_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMKHACH.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DmkhachManager _DmkhachManager = new DmkhachManager();
            DmkhachEntity _DmkhachEntity = new DmkhachEntity();
            _DmkhachEntity = _DmkhachManager.SelectOne(MAHIEU_PK);
            if (_DmkhachEntity != null && MessageBox.Show("Xóa khách hàng: " + MAHIEU_PK + " - " + txt_TENHIEU.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DmkhachManager.Delete(MAHIEU_PK);
                    GRID_DMKHACH.CurrentRow.Delete();
                    BS_DMKHACH_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmkhachManager.Convert(_DmkhachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa khách hàng " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMKHACH.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DmkhachManager.SelectOne(txt_MAHIEU.Text.Trim()) != null)
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
                GRID_DMKHACH.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_DMKHACH.ColumnAutoResize = true;
            else
                GRID_DMKHACH.ColumnAutoResize = false;
        }

        private void FRM_DMKHACH_FormClosing(object sender, FormClosingEventArgs e)
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
