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
    public partial class FRM_DMNHOMQUYCACH : FRM_DMPARENT
    {
        private DmnhomquycachManager _DmnhomquycachManager = new DmnhomquycachManager();
        private DmnhomquycachEntity _DmnhomquycachEntity = new DmnhomquycachEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMNHOMQUYCACH = new DataTable();
        private BindingSource BS_DMNHOMQUYCACH = new BindingSource();
        private DataRow r_Insert = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DMNHOMQUYCACH = new GD.BBPH.CONTROL.JGridEX();
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMNHOMQUYCACH");
                        DT_DMNHOMQUYCACH = LIB.SESSION_START.DT_DMNHOMQUYCACH;
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

        public FRM_DMNHOMQUYCACH()
        {
            InitializeComponent();
            DmnhomquycachManager _DmnhomquycachManager = new DmnhomquycachManager();
            DataTable dt111 = _DmnhomquycachManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMNHOMQUYCACH.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMNHOMQUYCACH.xml", GRID_DMNHOMQUYCACH, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMNHOMQUYCACH);
            BS_DMNHOMQUYCACH = new BindingSource();
            BS_DMNHOMQUYCACH.DataSource = Source_View;
            GRID_DMNHOMQUYCACH.DataSource = BS_DMNHOMQUYCACH;
            BS_DMNHOMQUYCACH.CurrentChanged += new EventHandler(BS_DMNHOMQUYCACH_CurrentChanged);
            BS_DMNHOMQUYCACH_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMNHOMQUYCACH_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_DMNHOMQUYCACH.UpdateData();
                if (BS_DMNHOMQUYCACH.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMNHOMQUYCACH.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DmnhomquycachFields.Manhom.Name].ToString();
                    txt_MANHOM.Text = _Rowview.Row[DmnhomquycachFields.Manhom.Name].ToString();
                    txt_TENNHOM.Text = _Rowview.Row[DmnhomquycachFields.Tennhom.Name].ToString();
                    txt_TENRUTGON.Text = _Rowview.Row[DmnhomquycachFields.Tenrutgon.Name].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMNHOMQUYCACH_CurrentChanged"); }
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            DmnhomquycachEntity _dmnhomquycachEntity = new DmnhomquycachEntity();
            _dmnhomquycachEntity.Manhom = txt_MANHOM.Text.Trim();
            _dmnhomquycachEntity.Tennhom = txt_TENNHOM.Text.Trim();
            _dmnhomquycachEntity.Tenrutgon = txt_TENRUTGON.Text.Trim();

            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _dmnhomquycachEntity.Ngaytao = DateTime.Now;
                _dmnhomquycachEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_DMCHUONG_PK = _DmnhomquycachManager.InsertV2(_dmnhomquycachEntity, r_Insert, DT_DMNHOMQUYCACH, BS_DMNHOMQUYCACH);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnhomquycachManager.Convert(_dmnhomquycachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMNHOMQUYCACH.ResetCurrentItem();
            }
            else
            {
                _dmnhomquycachEntity.Ngaysua = DateTime.Now;
                _dmnhomquycachEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DmnhomquycachManager.Update(_dmnhomquycachEntity);
                GRID_DMNHOMQUYCACH.CurrentRow.Cells[DmnhomquycachFields.Manhom.Name].Value = _dmnhomquycachEntity.Manhom;
                GRID_DMNHOMQUYCACH.CurrentRow.Cells[DmnhomquycachFields.Tennhom.Name].Value = _dmnhomquycachEntity.Tennhom;
                GRID_DMNHOMQUYCACH.CurrentRow.Cells[DmnhomquycachFields.Tenrutgon.Name].Value = _dmnhomquycachEntity.Tenrutgon;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnhomquycachManager.Convert(_dmnhomquycachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            DmnhomquycachManager _DmnhomquycachManager = new DmnhomquycachManager();
            DmnhomquycachEntity _DmnhomquycachEntity = new DmnhomquycachEntity();
            r_Insert = DT_DMNHOMQUYCACH.NewRow();
            DT_DMNHOMQUYCACH.Rows.Add(r_Insert);
            BS_DMNHOMQUYCACH.Position = DT_DMNHOMQUYCACH.Rows.Count;
            MAHIEU_PK = "";
            txt_MANHOM.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMNHOMQUYCACH.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MANHOM }));
                txt_TENNHOM.Focus();
            }
            GRID_DMNHOMQUYCACH.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMNHOMQUYCACH.Rows.Remove(r_Insert);
            }
            BS_DMNHOMQUYCACH_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMNHOMQUYCACH.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DmnhomquycachManager _DmnhomquycachManager = new DmnhomquycachManager();
            DmnhomquycachEntity _DmnhomquycachEntity = new DmnhomquycachEntity();
            _DmnhomquycachEntity = _DmnhomquycachManager.SelectOne(MAHIEU_PK);
            if (_DmnhomquycachEntity != null && MessageBox.Show("Xóa khách hàng: " + MAHIEU_PK + " - " + txt_TENNHOM.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DmnhomquycachManager.Delete(MAHIEU_PK);
                    GRID_DMNHOMQUYCACH.CurrentRow.Delete();
                    BS_DMNHOMQUYCACH_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnhomquycachManager.Convert(_DmnhomquycachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa khách hàng " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMNHOMQUYCACH.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DmnhomquycachManager.SelectOne(txt_MANHOM.Text.Trim()) != null)
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
            else if (txt_TENNHOM.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENNHOM.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMNHOMQUYCACH.Enabled = true;
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
                GRID_DMNHOMQUYCACH.ColumnAutoResize = true;
            else
                GRID_DMNHOMQUYCACH.ColumnAutoResize = false;
        }

        private void FRM_DMNHOMQUYCACH_FormClosing(object sender, FormClosingEventArgs e)
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
