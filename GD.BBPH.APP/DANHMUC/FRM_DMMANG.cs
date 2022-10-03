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
    public partial class FRM_DMMANG : FRM_DMPARENT
    {
        private DmmangManager _DmmangManager = new DmmangManager();
        private DmmangEntity _DmmangEntity = new DmmangEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMMANG = new DataTable();
        private BindingSource BS_DMMANG = new BindingSource();
        private DataRow r_Insert = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DMMANG = new GD.BBPH.CONTROL.JGridEX();
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMMANG");
                        DT_DMMANG = LIB.SESSION_START.DT_DMMANG;
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

        public FRM_DMMANG()
        {
            InitializeComponent();
            DmmangManager _DmmangManager = new DmmangManager();
            DataTable dt111 = _DmmangManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMANG.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMANG.xml", GRID_DMMANG, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMMANG);
            BS_DMMANG = new BindingSource();
            BS_DMMANG.DataSource = Source_View;
            GRID_DMMANG.DataSource = BS_DMMANG;
            BS_DMMANG.CurrentChanged += new EventHandler(BS_DMMANG_CurrentChanged);
            BS_DMMANG_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMMANG_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_DMMANG.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMMANG.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DmmangFields.Mamang.Name].ToString();
                    txt_MAHIEU.Text = _Rowview.Row[DmmangFields.Mamang.Name].ToString();
                    txt_TENHIEU.Text = _Rowview.Row[DmmangFields.Tenmang.Name].ToString();
                    txt_MAKHACH.Text = _Rowview.Row[DmmangFields.Makhach.Name].ToString();
                    txt_TENKHACH.Text = _Rowview.Row[DmmangFields.Tenkhach.Name].ToString();
                    txt_KICHTHUOC.Text = _Rowview.Row[DmmangFields.Kichthuoc.Name].ToString();
                    txt_TRONGLUONG.Text = _Rowview.Row[DmmangFields.Trongluong.Name].ToString();
                    txt_MACTPT.Text = _Rowview.Row[DmmangFields.Mactpt.Name].ToString();
                    //try
                    //{
                    //    chk_TRUYENTHONG.Checked = Convert.ToBoolean(_Rowview.Row[DmmangFields.Truyenthong.Name].ToString());
                    //}
                    //catch { }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMMANG_CurrentChanged"); }
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            DmmangEntity _DmmangEntity = new DmmangEntity();
            _DmmangEntity.Mamang = txt_MAHIEU.Text.Trim();
            _DmmangEntity.Tenmang = txt_TENHIEU.Text.Trim();
            _DmmangEntity.Makhach = txt_MAKHACH.Text.Trim();
            _DmmangEntity.Tenkhach = txt_TENKHACH.Text.Trim();
            _DmmangEntity.Kichthuoc = txt_KICHTHUOC.Text.Trim();
            _DmmangEntity.Trongluong = txt_TRONGLUONG.Text.Trim();
            _DmmangEntity.Mactpt = txt_MACTPT.Text.Trim();
            //if (chk_TRUYENTHONG.Checked)
            //    _DmmangEntity.Truyenthong = true;
            //else
            //    _DmmangEntity.Truyenthong = false;
            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _str_DMCHUONG_PK = _DmmangManager.InsertV2(_DmmangEntity, r_Insert, DT_DMMANG, BS_DMMANG);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmangManager.Convert(_DmmangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMMANG.ResetCurrentItem();
            }
            else
            {
                _DmmangManager.Update(_DmmangEntity);
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Mamang.Name].Value = _DmmangEntity.Mamang;
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Tenmang.Name].Value = _DmmangEntity.Tenmang;
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Makhach.Name].Value = _DmmangEntity.Makhach;
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Tenkhach.Name].Value = _DmmangEntity.Tenkhach;
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Kichthuoc.Name].Value = _DmmangEntity.Kichthuoc;
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Trongluong.Name].Value = _DmmangEntity.Trongluong;
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Mactpt.Name].Value = _DmmangEntity.Mactpt;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmangManager.Convert(_DmmangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            DmmangManager _DmmangManager = new DmmangManager();
            DmmangEntity _DmmangEntity = new DmmangEntity();
            r_Insert = DT_DMMANG.NewRow();
            DT_DMMANG.Rows.Add(r_Insert);
            BS_DMMANG.Position = DT_DMMANG.Rows.Count;
            MAHIEU_PK = "";
            txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMMANG.Enabled = false;
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
            GRID_DMMANG.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMMANG.Rows.Remove(r_Insert);
            }
            BS_DMMANG_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMMANG.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DmmangManager _DmmangManager = new DmmangManager();
            DmmangEntity _DmmangEntity = new DmmangEntity();
            _DmmangEntity = _DmmangManager.SelectOne(MAHIEU_PK);
            if (_DmmangEntity != null && MessageBox.Show("Xóa khách hàng: " + MAHIEU_PK + " - " + txt_TENHIEU.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DmmangManager.Delete(MAHIEU_PK);
                    GRID_DMMANG.CurrentRow.Delete();
                    BS_DMMANG_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmangManager.Convert(_DmmangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa khách hàng " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMMANG.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DmmangManager.SelectOne(txt_MAHIEU.Text.Trim()) != null)
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
                GRID_DMMANG.Enabled = true;
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
                GRID_DMMANG.ColumnAutoResize = true;
            else
                GRID_DMMANG.ColumnAutoResize = false;
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void FRM_DMMANG_FormClosing(object sender, FormClosingEventArgs e)
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
