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
    public partial class FRM_DMCONGDOAN : FRM_DMPARENT
    {
        private DmcongdoanManager _DmcongdoanManager = new DmcongdoanManager();
        private DmcongdoanEntity _DmcongdoanEntity = new DmcongdoanEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMCONGDOAN = new DataTable();
        private BindingSource BS_DMCONGDOAN = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DMCONGDOAN = new GD.BBPH.CONTROL.JGridEX();
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMCONGDOAN");
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

        public FRM_DMCONGDOAN()
        {
            InitializeComponent();
            DmcongdoanManager _DmcongdoanManager = new DmcongdoanManager();
            DataTable dt111 = _DmcongdoanManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCONGDOAN.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCONGDOAN.xml", GRID_DMCONGDOAN, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMCONGDOAN);
            BS_DMCONGDOAN = new BindingSource();
            BS_DMCONGDOAN.DataSource = Source_View;
            GRID_DMCONGDOAN.DataSource = BS_DMCONGDOAN;
            BS_DMCONGDOAN.CurrentChanged += new EventHandler(BS_DMCONGDOAN_CurrentChanged);
            BS_DMCONGDOAN_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMCONGDOAN_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_DMCONGDOAN.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMCONGDOAN.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DmcongdoanFields.Macd.Name].ToString();
                    txt_MAHIEU.Text = _Rowview.Row[DmcongdoanFields.Macd.Name].ToString();
                    txt_TENHIEU.Text = _Rowview.Row[DmcongdoanFields.Tencongdoan.Name].ToString();
                    txt_sothutucongdoan.Text = _Rowview.Row[DmcongdoanFields.Sothutucongdoan.Name].ToString();
                    //try { chk_COSUDUNGMAY.Checked = Convert.ToBoolean(_Rowview.Row[DmcongdoanFields.Cosudungmay.Name].ToString()); }
                    //catch { }
                    //try { chk_TRUOCCAT.Checked = Convert.ToBoolean(_Rowview.Row[DmcongdoanFields.Truoccat.Name].ToString()); }
                    //catch { }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMCONGDOAN_CurrentChanged"); }
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            DmcongdoanManager _DmcongdoanManager = new DmcongdoanManager();
            DmcongdoanEntity _DmcongdoanEntity = new DmcongdoanEntity();
            r_Insert = DT_DMCONGDOAN.NewRow();
            DT_DMCONGDOAN.Rows.Add(r_Insert);
            BS_DMCONGDOAN.Position = DT_DMCONGDOAN.Rows.Count;
            MAHIEU_PK = "";
            txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMCONGDOAN.Enabled = false;
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
            GRID_DMCONGDOAN.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMCONGDOAN.Rows.Remove(r_Insert);
            }
            BS_DMCONGDOAN_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMCONGDOAN.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DmcongdoanManager _DmcongdoanManager = new DmcongdoanManager();
            DmcongdoanEntity _DmcongdoanEntity = new DmcongdoanEntity();
            _DmcongdoanEntity = _DmcongdoanManager.SelectOne(MAHIEU_PK);
            if (_DmcongdoanEntity != null && MessageBox.Show("Xóa công đoạn: " + MAHIEU_PK + " - " + txt_TENHIEU.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DmcongdoanManager.Delete(MAHIEU_PK);
                    GRID_DMCONGDOAN.CurrentRow.Delete();
                    BS_DMCONGDOAN_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcongdoanManager.Convert(_DmcongdoanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công đoạn " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMCONGDOAN.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DmcongdoanManager.SelectOne(txt_MAHIEU.Text.Trim()) != null)
            {
                MessageBox.Show("Mã công đoạn bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_MAHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã công đoạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_TENHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên công đoạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENHIEU.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMCONGDOAN.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            DmcongdoanEntity _DmcongdoanEntity = new DmcongdoanEntity();
            _DmcongdoanEntity.Macd = txt_MAHIEU.Text.Trim();
            _DmcongdoanEntity.Tencongdoan = txt_TENHIEU.Text.Trim();
            try { _DmcongdoanEntity.Sothutucongdoan = Int32.Parse(txt_sothutucongdoan.Text.Trim()); }
            catch { }
            //if (chk_COSUDUNGMAY.Checked)
            //    _DmcongdoanEntity.Cosudungmay = true;
            //else
            //    _DmcongdoanEntity.Cosudungmay = false;
            //if (chk_TRUOCCAT.Checked)
            //    _DmcongdoanEntity.Truoccat = true;
            //else
            //    _DmcongdoanEntity.Truoccat = false;

            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _str_DMCHUONG_PK = _DmcongdoanManager.InsertV2(_DmcongdoanEntity, r_Insert, DT_DMCONGDOAN, BS_DMCONGDOAN);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcongdoanManager.Convert(_DmcongdoanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMCONGDOAN.ResetCurrentItem();
            }
            else
            {
                _DmcongdoanManager.Update(_DmcongdoanEntity);
                GRID_DMCONGDOAN.CurrentRow.Cells[DmcongdoanFields.Macd.Name].Value = _DmcongdoanEntity.Macd;
                GRID_DMCONGDOAN.CurrentRow.Cells[DmcongdoanFields.Tencongdoan.Name].Value = _DmcongdoanEntity.Tencongdoan;
                GRID_DMCONGDOAN.CurrentRow.Cells[DmcongdoanFields.Sothutucongdoan.Name].Value = _DmcongdoanEntity.Sothutucongdoan;

                //GRID_DMCONGDOAN.CurrentRow.Cells[DmcongdoanFields.Cosudungmay.Name].Value = _DmcongdoanEntity.Cosudungmay;
                //GRID_DMCONGDOAN.CurrentRow.Cells[DmcongdoanFields.Truoccat.Name].Value = _DmcongdoanEntity.Truoccat;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcongdoanManager.Convert(_DmcongdoanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_DMCONGDOAN.ColumnAutoResize = true;
            else
                GRID_DMCONGDOAN.ColumnAutoResize = false;
        }

        private void FRM_DMCONGDOAN_FormClosing(object sender, FormClosingEventArgs e)
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
