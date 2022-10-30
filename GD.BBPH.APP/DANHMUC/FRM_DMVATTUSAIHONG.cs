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
using System.Text.RegularExpressions;

namespace GD.BBPH.APP.DANHMUC
{
    public partial class FRM_DMVATTUSAIHONG : FRM_DMPARENT
    {
        private DinhmucvattuManager _DinhmucvattuManager = new DinhmucvattuManager();
        private DinhmucvattuEntity _DinhmucvattuEntity = new DinhmucvattuEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMVATTUSAIHONG = new DataTable();
        private BindingSource BS_DMVATTUSAIHONG = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DMVATTUSAIHONG = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";

        private DataTable DT_DMMAY = new DataTable(), DT_DMDONGMAY = new DataTable(), DT_DMCONGDOAN = new DataTable()
            , DT_SOMAU = new DataTable(), DT_LOAIMUC = new DataTable(), DT_LOAIMANG = new DataTable(), DT_QCTHANHPHAM = new DataTable(), DT_DMNHOMDINHMUC = new DataTable(), DT_DMMAU = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMVATTUSAIHONG");
                        DT_DMVATTUSAIHONG = LIB.SESSION_START.DT_DMVATTUSAIHONG;
                        DT_DMNHOMDINHMUC = LIB.SESSION_START.DT_DMNHOMDINHMUC;
                        DT_DMMAU = LIB.SESSION_START.DT_DMMAU;
                        DT_DMMAY = LIB.SESSION_START.DT_DMMAY;
                        DT_DMDONGMAY = LIB.SESSION_START.DT_DMDONGMAY;
                        DT_DMCONGDOAN = LIB.SESSION_START.DT_DMCONGDOAN;
                        DT_SOMAU = new DmquycachManager().SelectByManhomRDT("N01");
                        DT_LOAIMUC = new DmquycachManager().SelectByManhomRDT("N04");
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

        public FRM_DMVATTUSAIHONG()
        {
            InitializeComponent();
            DinhmucvattuManager _DinhmucvattuManager = new DinhmucvattuManager();
            DataTable dt111 = _DinhmucvattuManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMVATTUSAIHONG.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SAOCHEP, btn_SAOCHEP.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMVATTUSAIHONG.xml", GRID_DMVATTUSAIHONG, uiPanel0Container);
            GRID_DMVATTUSAIHONG.RootTable.Groups.Add(GRID_DMVATTUSAIHONG.Tables[0].Columns[DinhmucvattuFields.Tennhom.Name]);
            //GRID_DMVATTUSAIHONG.RootTable.SortKeys.Add(DinhmucvattuFields.Sothutucongdoan.Name, Janus.Windows.GridEX.SortOrder.Ascending);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMVATTUSAIHONG);
            BS_DMVATTUSAIHONG = new BindingSource();
            BS_DMVATTUSAIHONG.DataSource = Source_View;
            GRID_DMVATTUSAIHONG.DataSource = BS_DMVATTUSAIHONG;
            BS_DMVATTUSAIHONG.CurrentChanged += new EventHandler(BS_DMVATTUSAIHONG_CurrentChanged);
            BS_DMVATTUSAIHONG_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_CHONSOMAU.Enabled = btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONLOAIMUC.Enabled = btn_CHONMAMAU.Enabled = false;
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMVATTUSAIHONG_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_DMVATTUSAIHONG.UpdateData();
                if (BS_DMVATTUSAIHONG.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMVATTUSAIHONG.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DinhmucvattuFields.Madinhmuc.Name].ToString();
                    txt_MADINHMUC.Text = _Rowview.Row[DinhmucvattuFields.Madinhmuc.Name].ToString();
                    txt_TENDINHMUC.Text = _Rowview.Row[DinhmucvattuFields.Tendinhmuc.Name].ToString();

                    txt_MANHOM.Text = _Rowview.Row[DinhmucvattuFields.Manhom.Name].ToString();
                    txt_MANHOM_Validating(new object(), new CancelEventArgs());
                    txt_MAMAY.Text = _Rowview.Row[DinhmucvattuFields.Mamay.Name].ToString();
                    txt_MAMAY_Validating(new object(), new CancelEventArgs());
                    txt_MADONGMAY.Text = _Rowview.Row[DinhmucvattuFields.Madongmay.Name].ToString();
                    txt_MADONGMAY_Validating(new object(), new CancelEventArgs());
                    txt_MACONGDOAN.Text = _Rowview.Row[DinhmucvattuFields.Macongdoan.Name].ToString();
                    txt_MACONGDOAN_Validating(new object(), new CancelEventArgs());

                    txt_MALOAIMUC.Text = _Rowview.Row[DinhmucvattuFields.Maloaimuc.Name].ToString();
                    txt_MAMAU.Text = _Rowview.Row[DinhmucvattuFields.Mamau.Name].ToString();
                    txt_SOMAUMA.Text = _Rowview.Row[DinhmucvattuFields.Somauma.Name].ToString();
                    txt_MALOAIMANG.Text = _Rowview.Row[DinhmucvattuFields.Maloaimang.Name].ToString();
                    txt_MAQCTHANHPHAM.Text = _Rowview.Row[DinhmucvattuFields.Maqcthanhpham.Name].ToString();
                    txt_DINHMUC.Text = _Rowview.Row[DinhmucvattuFields.Dinhmuc.Name].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMVATTUSAIHONG_CurrentChanged"); }
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_TENNHOM.Text = txt_TENMAY.Text = txt_TENDONGMAY.Text = txt_TENCONGDOAN.Text = string.Empty;
            r_Insert = DT_DMVATTUSAIHONG.NewRow();
            DT_DMVATTUSAIHONG.Rows.Add(r_Insert);
            BS_DMVATTUSAIHONG.Position = DT_DMVATTUSAIHONG.Rows.Count;
            MAHIEU_PK = "";
            txt_MADINHMUC.Text = GetMadinhmuc("DM");
            txt_MADINHMUC.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENNHOM, txt_TENMAY, txt_TENDONGMAY, txt_TENCONGDOAN }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMVATTUSAIHONG.Enabled = false;
            btn_CHONSOMAU.Enabled = btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONLOAIMUC.Enabled = btn_CHONMAMAU.Enabled = true;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MADINHMUC, txt_TENNHOM, txt_TENMAY, txt_TENDONGMAY, txt_TENCONGDOAN }));
                txt_TENDINHMUC.Focus();
            }
            GRID_DMVATTUSAIHONG.Enabled = false;
            btn_CHONSOMAU.Enabled = btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONLOAIMUC.Enabled = btn_CHONMAMAU.Enabled = true;
        }
        private void btn_SAOCHEP_Click(object sender, EventArgs e)
        {
            try
            {
                BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                DinhmucvattuManager _DinhmucvattuManager = new DinhmucvattuManager();
                DinhmucvattuEntity _DinhmucvattuEntity = new DinhmucvattuEntity();
                r_Insert = DT_DMVATTUSAIHONG.NewRow();
                DT_DMVATTUSAIHONG.Rows.Add(r_Insert);
                DataRow[] drCopy = DT_DMVATTUSAIHONG.Select(DinhmucvattuFields.Madinhmuc.Name + "= '" + MAHIEU_PK + "'");
                BS_DMVATTUSAIHONG.Position = DT_DMVATTUSAIHONG.Rows.Count;

                txt_MADINHMUC.Text = drCopy[0][DinhmucvattuFields.Madinhmuc.Name].ToString();
                txt_TENDINHMUC.Text = drCopy[0][DinhmucvattuFields.Tendinhmuc.Name].ToString();

                txt_MANHOM.Text = drCopy[0][DinhmucvattuFields.Manhom.Name].ToString();
                txt_MANHOM_Validating(new object(), new CancelEventArgs());
                txt_MAMAY.Text = drCopy[0][DinhmucvattuFields.Mamay.Name].ToString();
                txt_MAMAY_Validating(new object(), new CancelEventArgs());
                txt_MADONGMAY.Text = drCopy[0][DinhmucvattuFields.Madongmay.Name].ToString();
                txt_MADONGMAY_Validating(new object(), new CancelEventArgs());
                txt_MACONGDOAN.Text = drCopy[0][DinhmucvattuFields.Macongdoan.Name].ToString();
                txt_MACONGDOAN_Validating(new object(), new CancelEventArgs());

                txt_MALOAIMUC.Text = drCopy[0][DinhmucvattuFields.Maloaimuc.Name].ToString();
                txt_MAMAU.Text = drCopy[0][DinhmucvattuFields.Mamau.Name].ToString();
                txt_SOMAUMA.Text = drCopy[0][DinhmucvattuFields.Somauma.Name].ToString();
                txt_MALOAIMANG.Text = drCopy[0][DinhmucvattuFields.Maloaimang.Name].ToString();
                txt_MAQCTHANHPHAM.Text = drCopy[0][DinhmucvattuFields.Maqcthanhpham.Name].ToString();
                txt_DINHMUC.Text = drCopy[0][DinhmucvattuFields.Dinhmuc.Name].ToString();

                MAHIEU_PK = "";
                txt_MADINHMUC.Text = GetMadinhmuc("DM");
                txt_MADINHMUC.Focus();
                //TEXTBOX_Only_Control(false, null);
                // txt_MAHIEU.Text = DmcapmaManager.GET_MA_INT(DmcapmaManager.LOAI_MA_HIEU, false, KTXPT.DATA);
                BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENNHOM, txt_TENMAY, txt_TENDONGMAY, txt_TENCONGDOAN }));
                BBPH.BLL.MenuroleManager.set_Enable_controls(BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GRID_DMVATTUSAIHONG.Enabled = false;
                btn_CHONSOMAU.Enabled = btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONLOAIMUC.Enabled = btn_CHONMAMAU.Enabled = true;
            }
            catch { }
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMVATTUSAIHONG.Rows.Remove(r_Insert);
            }
            BS_DMVATTUSAIHONG_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMVATTUSAIHONG.Enabled = true;
            btn_CHONSOMAU.Enabled = btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONLOAIMUC.Enabled = btn_CHONMAMAU.Enabled = false;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DinhmucvattuManager _DinhmucvattuManager = new DinhmucvattuManager();
            DinhmucvattuEntity _DinhmucvattuEntity = new DinhmucvattuEntity();
            _DinhmucvattuEntity = _DinhmucvattuManager.SelectOne(MAHIEU_PK);
            if (_DinhmucvattuEntity != null && MessageBox.Show("Xóa công đoạn: " + MAHIEU_PK + " - " + txt_TENDINHMUC.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DinhmucvattuManager.Delete(MAHIEU_PK);
                    GRID_DMVATTUSAIHONG.CurrentRow.Delete();
                    BS_DMVATTUSAIHONG_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmucvattuManager.Convert(_DinhmucvattuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_CHONSOMAU.Enabled = btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONLOAIMUC.Enabled = btn_CHONMAMAU.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công đoạn " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMVATTUSAIHONG.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DinhmucvattuManager.SelectOne(txt_MADINHMUC.Text.Trim()) != null)
            {
                MessageBox.Show("Mã công đoạn bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MADINHMUC.Focus();
                return;
            }
            else if (txt_MADINHMUC.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã công đoạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MADINHMUC.Focus();
                return;
            }
            else if (txt_TENDINHMUC.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên công đoạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENDINHMUC.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMVATTUSAIHONG.Enabled = true;
                btn_THEMMOI.Focus();
                btn_CHONSOMAU.Enabled = btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONLOAIMUC.Enabled = btn_CHONMAMAU.Enabled = false;
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private string Save_Data(string _str_MAHIEU_PK)
        {
            DinhmucvattuEntity _DinhmucvattuEntity = new DinhmucvattuEntity();

            _DinhmucvattuEntity.Madinhmuc = txt_MADINHMUC.Text.Trim();
            _DinhmucvattuEntity.Tendinhmuc = txt_TENDINHMUC.Text.Trim();
            _DinhmucvattuEntity.Manhom = txt_MANHOM.Text.Trim();
            _DinhmucvattuEntity.Tennhom = txt_TENNHOM.Text.Trim();
            _DinhmucvattuEntity.Mamay = txt_MAMAY.Text.Trim();
            _DinhmucvattuEntity.Madongmay = txt_MADONGMAY.Text.Trim();
            _DinhmucvattuEntity.Macongdoan = txt_MACONGDOAN.Text.Trim();
            _DinhmucvattuEntity.Somauma = txt_SOMAUMA.Text.Trim();
            _DinhmucvattuEntity.Maloaimuc = txt_MALOAIMUC.Text.Trim();
            _DinhmucvattuEntity.Mamau = txt_MAMAU.Text.Trim();
            _DinhmucvattuEntity.Maloaimang = txt_MALOAIMANG.Text.Trim();
            _DinhmucvattuEntity.Maqcthanhpham = txt_MAQCTHANHPHAM.Text.Trim();
            _DinhmucvattuEntity.Dinhmuc = LIB.ConvertString.NumbertoDB(txt_DINHMUC.Text.Trim());

            if (string.IsNullOrEmpty(_str_MAHIEU_PK))
            {
                _DinhmucvattuEntity.Ngaytao = DateTime.Now;
                _DinhmucvattuEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_MAHIEU_PK = _DinhmucvattuManager.InsertV2(_DinhmucvattuEntity, r_Insert, DT_DMVATTUSAIHONG, BS_DMVATTUSAIHONG);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmucvattuManager.Convert(_DinhmucvattuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_CHONSOMAU.Enabled = btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONLOAIMUC.Enabled = btn_CHONMAMAU.Enabled = false;
                BS_DMVATTUSAIHONG.ResetCurrentItem();
            }
            else
            {
                _DinhmucvattuEntity.Ngaysua = DateTime.Now;
                _DinhmucvattuEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DinhmucvattuManager.Update(_DinhmucvattuEntity);
                GRID_DMVATTUSAIHONG.CurrentRow.Cells[DinhmucvattuFields.Madinhmuc.Name].Value = _DinhmucvattuEntity.Madinhmuc;
                GRID_DMVATTUSAIHONG.CurrentRow.Cells[DinhmucvattuFields.Tendinhmuc.Name].Value = _DinhmucvattuEntity.Tendinhmuc;
                GRID_DMVATTUSAIHONG.CurrentRow.Cells[DinhmucvattuFields.Mamay.Name].Value = _DinhmucvattuEntity.Mamay;
                GRID_DMVATTUSAIHONG.CurrentRow.Cells[DinhmucvattuFields.Madongmay.Name].Value = _DinhmucvattuEntity.Madongmay;
                GRID_DMVATTUSAIHONG.CurrentRow.Cells[DinhmucvattuFields.Macongdoan.Name].Value = _DinhmucvattuEntity.Macongdoan;
                GRID_DMVATTUSAIHONG.CurrentRow.Cells[DinhmucvattuFields.Manhom.Name].Value = _DinhmucvattuEntity.Manhom;
                GRID_DMVATTUSAIHONG.CurrentRow.Cells[DinhmucvattuFields.Tennhom.Name].Value = _DinhmucvattuEntity.Tennhom;
                GRID_DMVATTUSAIHONG.CurrentRow.Cells[DinhmucvattuFields.Maloaimuc.Name].Value = _DinhmucvattuEntity.Maloaimuc;
                GRID_DMVATTUSAIHONG.CurrentRow.Cells[DinhmucvattuFields.Mamau.Name].Value = _DinhmucvattuEntity.Mamau;
                GRID_DMVATTUSAIHONG.CurrentRow.Cells[DinhmucvattuFields.Somauma.Name].Value = _DinhmucvattuEntity.Somauma;
                GRID_DMVATTUSAIHONG.CurrentRow.Cells[DinhmucvattuFields.Maloaimang.Name].Value = _DinhmucvattuEntity.Maloaimang;
                GRID_DMVATTUSAIHONG.CurrentRow.Cells[DinhmucvattuFields.Maqcthanhpham.Name].Value = _DinhmucvattuEntity.Maqcthanhpham;
                GRID_DMVATTUSAIHONG.CurrentRow.Cells[DinhmucvattuFields.Dinhmuc.Name].Value = _DinhmucvattuEntity.Dinhmuc;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmucvattuManager.Convert(_DinhmucvattuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_CHONSOMAU.Enabled = btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONLOAIMUC.Enabled = btn_CHONMAMAU.Enabled = false;
            }
            return _str_MAHIEU_PK;
        }

        #region Validate
        private void txt_MANHOM_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            txt_TENNHOM.Text = string.Empty;
            if (string.IsNullOrEmpty(txt_MANHOM.Text.Trim()) || DT_DMNHOMDINHMUC == null || DT_DMNHOMDINHMUC.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MANHOM.Text.Trim().ToUpper();
            _RowViewSelect = checkmaNhomdinhmuc(Str_MASIEUTHI, DT_DMNHOMDINHMUC);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMNHOMDINHMUC.xml",
                        DT_DMNHOMDINHMUC, DmnhomdinhmucFields.Manhom.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MANHOM.Text = _RowViewSelect[DmnhomdinhmucFields.Manhom.Name].ToString();
                txt_TENNHOM.Text = _RowViewSelect[DmnhomdinhmucFields.Tennhom.Name].ToString();
            }
            else
                txt_TENNHOM.Text = _RowViewSelect[DmnhomdinhmucFields.Tennhom.Name].ToString();
        }

        private DataRow checkmaNhomdinhmuc(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmnhomdinhmucFields.Manhom.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MAMAY_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            txt_TENMAY.Text = string.Empty;
            if (string.IsNullOrEmpty(txt_MAMAY.Text.Trim()) || DT_DMMAY == null || DT_DMMAY.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAMAY.Text.Trim().ToUpper();
            _RowViewSelect = checkmaMay(Str_MASIEUTHI, DT_DMMAY);
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

                txt_MADONGMAY.Text = _RowViewSelect[DmmayFields.Madm.Name].ToString();
                txt_MADONGMAY_Validating(new object(), new CancelEventArgs());
            }
            else
            {
                txt_TENMAY.Text = _RowViewSelect[DmmayFields.Tenmay.Name].ToString();

                txt_MADONGMAY.Text = _RowViewSelect[DmmayFields.Madm.Name].ToString();
                txt_MADONGMAY_Validating(new object(), new CancelEventArgs());
            }
        }

        private DataRow checkmaMay(string masieuthi, DataTable dt)
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
            txt_TENDONGMAY.Text = string.Empty;
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

                txt_MACONGDOAN.Text = _RowViewSelect[DmdongmayFields.Macd.Name].ToString();
                txt_MACONGDOAN_Validating(new object(), new CancelEventArgs());
            }
            else
            {
                txt_TENDONGMAY.Text = _RowViewSelect[DmdongmayFields.Tendongmay.Name].ToString();

                txt_MACONGDOAN.Text = _RowViewSelect[DmdongmayFields.Macd.Name].ToString();
                txt_MACONGDOAN_Validating(new object(), new CancelEventArgs());
            }
        }
        private DataRow checkmaDongmay(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmdongmayFields.Madm.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MACONGDOAN_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            txt_TENCONGDOAN.Text = string.Empty;
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

        private void btn_CHONLOAIMUC_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH_CHON.xml", DT_LOAIMUC, DmquycachFields.Maquycach.Name, txt_MALOAIMUC.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmquycachFields.Maquycach.Name].ToString() + ",";

            txt_MALOAIMUC.Text = str;
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

        private void btn_CHONMAMAU_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMAU_CHON.xml", DT_DMMAU, DmmauFields.Mamau.Name, txt_MAMAU.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmmauFields.Mamau.Name].ToString() + ",";

            txt_MAMAU.Text = str;
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

        #region Shortcut Key
        private void txt_MANHOM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMNHOMDINHMUC frm_Dm = new FRM_DMNHOMDINHMUC();
                frm_Dm.Text = "Danh mục nhóm định mức";
                frm_Dm.ShowDialog();
                DT_DMNHOMDINHMUC = new DmnhomdinhmucManager().SelectAllRDT();
            }
        }
        private void txt_MAMAY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMMAY frm_Dm = new FRM_DMMAY();
                frm_Dm.Text = "Danh mục máy";
                frm_Dm.ShowDialog();
                DT_DMMAY = new DmmayManager().SelectAllRDT();
            }
        }
        private void txt_MADONGMAY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMDONGMAY frm_Dm = new FRM_DMDONGMAY();
                frm_Dm.Text = "Danh mục dòng máy";
                frm_Dm.ShowDialog();
                DT_DMDONGMAY = new DmdongmayManager().SelectAllRDT();
            }
        }
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
        private void txt_SOMAUMA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMQUYCACH frm_Dm = new FRM_DMQUYCACH();
                frm_Dm.Text = "Danh mục quy cách";
                frm_Dm.ShowDialog();
                DT_SOMAU = new DmquycachManager().SelectByManhomRDT("N01");
            }
        }
        private void txt_MALOAIMUC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMQUYCACH frm_Dm = new FRM_DMQUYCACH();
                frm_Dm.Text = "Danh mục quy cách";
                frm_Dm.ShowDialog();
                DT_LOAIMUC = new DmquycachManager().SelectByManhomRDT("N04");
            }
        }
        private void txt_MAQCTHANHPHAM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMQUYCACH frm_Dm = new FRM_DMQUYCACH();
                frm_Dm.Text = "Danh mục quy cách";
                frm_Dm.ShowDialog();
                DT_QCTHANHPHAM = new DmquycachManager().SelectByManhomRDT("N06");
            }
        }
        #endregion

        private string GetMadinhmuc(string m_Tiento)
        {
            long m_sohieu = 0, m_newsohieu = 0;

            DataTable _table = new DinhmucvattuManager().SelectAllRDT();
            if (_table.Rows.Count == 0) return m_Tiento + "001";
            DataRow[] _row = _table.Select();

            int max_sohieu = 0;
            string alphaPart = "";
            for (int i = 0; i < _row.Length; i++)
            {
                int _sohieu = 0;
                // alphaPart = "";
                // kiem tra chuoi co ca so va chu 
                string m_sohieu_chucai_so = _row[i][DinhmucvattuFields.Madinhmuc.Name].ToString();
                Regex re = new Regex(@"([a-zA-Z]+)(\d+)");
                Match result = re.Match(m_sohieu_chucai_so);
                if (result.Length == 0) int.TryParse(_row[i][DinhmucvattuFields.Madinhmuc.Name].ToString(), out _sohieu);
                else
                {
                    alphaPart = result.Groups[1].Value;
                    string numberPart = result.Groups[2].Value;
                    int.TryParse(numberPart, out _sohieu);
                }
                max_sohieu = (max_sohieu < _sohieu) ? _sohieu : max_sohieu;
            }
            max_sohieu++;
            if (max_sohieu == 1) alphaPart = m_Tiento;
            m_sohieu = (m_newsohieu > max_sohieu) ? m_newsohieu : max_sohieu;
            m_newsohieu = m_sohieu;

            return (alphaPart + m_newsohieu.ToString().PadLeft(3, '0'));
        }

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_DMVATTUSAIHONG.ColumnAutoResize = true;
            else
                GRID_DMVATTUSAIHONG.ColumnAutoResize = false;
        }

        private void FRM_DMVATTUSAIHONG_FormClosing(object sender, FormClosingEventArgs e)
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
