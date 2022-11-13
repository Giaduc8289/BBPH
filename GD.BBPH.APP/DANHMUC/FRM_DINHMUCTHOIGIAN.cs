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
    public partial class FRM_DINHMUCTHOIGIAN : FRM_DMPARENT
    {
        private DinhmucthoigianManager _DinhmucthoigianManager = new DinhmucthoigianManager();
        private DinhmucthoigianEntity _DinhmucthoigianEntity = new DinhmucthoigianEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DINHMUCTHOIGIAN = new DataTable();
        private BindingSource BS_DINHMUCTHOIGIAN = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DINHMUCTHOIGIAN = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";

        private DataTable DT_DMMAY = new DataTable(), DT_DMDONGMAY = new DataTable(), DT_DMCONGDOAN = new DataTable()
            , DT_SOMAU = new DataTable(), DT_SOHINH = new DataTable(), DT_LOAIMANG = new DataTable(), DT_QCTHANHPHAM = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DINHMUCTHOIGIAN");
                        DT_DINHMUCTHOIGIAN = LIB.SESSION_START.DT_DINHMUCTHOIGIAN;
                        DT_DMMAY = LIB.SESSION_START.DT_DMMAY;
                        DT_DMDONGMAY = LIB.SESSION_START.DT_DMDONGMAY;
                        DT_DMCONGDOAN = LIB.SESSION_START.DT_DMCONGDOAN;


                        DT_SOMAU = new DmquycachManager().SelectByManhomRDT("N01");
                        DT_SOHINH = new DmquycachManager().SelectByManhomRDT("N03");
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

        public FRM_DINHMUCTHOIGIAN()
        {
            InitializeComponent();
            DinhmucthoigianManager _DinhmucthoigianManager = new DinhmucthoigianManager();
            DataTable dt111 = _DinhmucthoigianManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DINHMUCTHOIGIAN.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DINHMUCTHOIGIAN.xml", GRID_DINHMUCTHOIGIAN, uiPanel0Container);
            //GRID_DINHMUCTHOIGIAN.RootTable.SortKeys.Add(DinhmucthoigianFields.Sothutucongdoan.Name, Janus.Windows.GridEX.SortOrder.Ascending);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DINHMUCTHOIGIAN);
            BS_DINHMUCTHOIGIAN = new BindingSource();
            BS_DINHMUCTHOIGIAN.DataSource = Source_View;
            GRID_DINHMUCTHOIGIAN.DataSource = BS_DINHMUCTHOIGIAN;
            BS_DINHMUCTHOIGIAN.CurrentChanged += new EventHandler(BS_DINHMUCTHOIGIAN_CurrentChanged);
            BS_DINHMUCTHOIGIAN_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = false;
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DINHMUCTHOIGIAN_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_DINHMUCTHOIGIAN.UpdateData();
                if (BS_DINHMUCTHOIGIAN.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DINHMUCTHOIGIAN.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DinhmucthoigianFields.Madmtg.Name].ToString();
                    txt_MADINHMUC.Text = _Rowview.Row[DinhmucthoigianFields.Madmtg.Name].ToString();
                    txt_TENDINHMUC.Text = _Rowview.Row[DinhmucthoigianFields.Tendinhmuc.Name].ToString();
                    txt_MAMAY.Text = _Rowview.Row[DinhmucthoigianFields.Mamay.Name].ToString();
                    txt_MADONGMAY.Text = _Rowview.Row[DinhmucthoigianFields.Madongmay.Name].ToString();
                    txt_MACONGDOAN.Text = _Rowview.Row[DinhmucthoigianFields.Macongdoan.Name].ToString();
                    txt_DODAYTU.Text = _Rowview.Row[DinhmucthoigianFields.Dodaytu.Name].ToString();
                    txt_DODAYDEN.Text = _Rowview.Row[DinhmucthoigianFields.Dodayden.Name].ToString();
                    txt_KHOTU.Text = _Rowview.Row[DinhmucthoigianFields.Khotu.Name].ToString();
                    txt_KHODEN.Text = _Rowview.Row[DinhmucthoigianFields.Khoden.Name].ToString();
                    txt_CHIEUDAITU.Text = _Rowview.Row[DinhmucthoigianFields.Chieudaitu.Name].ToString();
                    txt_CHIEUDAIDEN.Text = _Rowview.Row[DinhmucthoigianFields.Chieudaiden.Name].ToString();
                    txt_SOMAUMA.Text = _Rowview.Row[DinhmucthoigianFields.Somauma.Name].ToString();
                    txt_SOHINHMA.Text = _Rowview.Row[DinhmucthoigianFields.Sohinhma.Name].ToString();
                    txt_MALOAIMANG.Text = _Rowview.Row[DinhmucthoigianFields.Maloaimang.Name].ToString();
                    txt_MAQCTHANHPHAM.Text = _Rowview.Row[DinhmucthoigianFields.Maqcthanhpham.Name].ToString();
                    txt_DAUCA.Text = _Rowview.Row[DinhmucthoigianFields.Dauca.Name].ToString();
                    txt_DAUCUON.Text = _Rowview.Row[DinhmucthoigianFields.Daucuon.Name].ToString();
                    txt_DOILENH.Text = _Rowview.Row[DinhmucthoigianFields.Doilenh.Name].ToString();
                    txt_LENCUON.Text = _Rowview.Row[DinhmucthoigianFields.Lencuon.Name].ToString();
                    txt_XUONGCUON.Text = _Rowview.Row[DinhmucthoigianFields.Xuongcuon.Name].ToString();
                    txt_THAYTHIETBI.Text = _Rowview.Row[DinhmucthoigianFields.Thaythietbi.Name].ToString();
                    txt_DUNGMAY.Text = _Rowview.Row[DinhmucthoigianFields.Dungmay.Name].ToString();

                    txt_MAMAY_Validating(new object(), new CancelEventArgs());
                    txt_MADONGMAY_Validating(new object(), new CancelEventArgs());
                    txt_CONGDOAN_Validating(new object(), new CancelEventArgs());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DINHMUCTHOIGIAN_CurrentChanged"); }
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            r_Insert = DT_DINHMUCTHOIGIAN.NewRow();
            DT_DINHMUCTHOIGIAN.Rows.Add(r_Insert);
            BS_DINHMUCTHOIGIAN.Position = DT_DINHMUCTHOIGIAN.Rows.Count;
            MAHIEU_PK = "";
            txt_MAMAY.Text = txt_TENMAY.Text = txt_MADONGMAY.Text = txt_TENDONGMAY.Text = txt_MACONGDOAN.Text = txt_TENCONGDOAN.Text = string.Empty;
            txt_MADINHMUC.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DINHMUCTHOIGIAN.Enabled = false;
            btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = true;
           
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MADINHMUC }));
                txt_TENDINHMUC.Focus();
            }
            GRID_DINHMUCTHOIGIAN.Enabled = false;
            btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DINHMUCTHOIGIAN.Rows.Remove(r_Insert);
            }
            BS_DINHMUCTHOIGIAN_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DINHMUCTHOIGIAN.Enabled = true;
            btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = false;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DinhmucthoigianManager _DinhmucthoigianManager = new DinhmucthoigianManager();
            DinhmucthoigianEntity _DinhmucthoigianEntity = new DinhmucthoigianEntity();
            _DinhmucthoigianEntity = _DinhmucthoigianManager.SelectOne(MAHIEU_PK);
            if (_DinhmucthoigianEntity != null && MessageBox.Show("Xóa công đoạn: " + MAHIEU_PK + " - " + txt_TENDINHMUC.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DinhmucthoigianManager.Delete(MAHIEU_PK);
                    GRID_DINHMUCTHOIGIAN.CurrentRow.Delete();
                    BS_DINHMUCTHOIGIAN_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmucthoigianManager.Convert(_DinhmucthoigianEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công đoạn " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DINHMUCTHOIGIAN.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DinhmucthoigianManager.SelectOne(txt_MADINHMUC.Text.Trim()) != null)
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
                GRID_DINHMUCTHOIGIAN.Enabled = true;
                btn_THEMMOI.Focus();
                btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = false;
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private string Save_Data(string _str_MAHIEU_PK)
        {
            DinhmucthoigianEntity _DinhmucthoigianEntity = new DinhmucthoigianEntity();

            _DinhmucthoigianEntity.Madmtg = txt_MADINHMUC.Text.Trim();
            _DinhmucthoigianEntity.Tendinhmuc = txt_TENDINHMUC.Text.Trim();
            _DinhmucthoigianEntity.Mamay = txt_MAMAY.Text.Trim();
            _DinhmucthoigianEntity.Madongmay = txt_MADONGMAY.Text.Trim();
            _DinhmucthoigianEntity.Macongdoan = txt_MACONGDOAN.Text.Trim();
            _DinhmucthoigianEntity.Khotu = LIB.ConvertString.NumbertoDB(txt_KHOTU.Text.Trim());
            _DinhmucthoigianEntity.Khoden = LIB.ConvertString.NumbertoDB(txt_KHODEN.Text.Trim());
            _DinhmucthoigianEntity.Chieudaitu = LIB.ConvertString.NumbertoDB(txt_CHIEUDAITU.Text.Trim());
            _DinhmucthoigianEntity.Chieudaiden = LIB.ConvertString.NumbertoDB(txt_CHIEUDAIDEN.Text.Trim());
            _DinhmucthoigianEntity.Dodaytu = LIB.ConvertString.NumbertoDB(txt_DODAYTU.Text.Trim());
            _DinhmucthoigianEntity.Dodayden = LIB.ConvertString.NumbertoDB(txt_DODAYDEN.Text.Trim());
            _DinhmucthoigianEntity.Somauma = txt_SOMAUMA.Text.Trim();
            _DinhmucthoigianEntity.Sohinhma = txt_SOHINHMA.Text.Trim();
            _DinhmucthoigianEntity.Maloaimang = txt_MALOAIMANG.Text.Trim();
            _DinhmucthoigianEntity.Maqcthanhpham = txt_MAQCTHANHPHAM.Text.Trim();
            _DinhmucthoigianEntity.Dauca = LIB.ConvertString.NumbertoDB(txt_DAUCA.Text.Trim());
            _DinhmucthoigianEntity.Daucuon = LIB.ConvertString.NumbertoDB(txt_DAUCUON.Text.Trim());
            _DinhmucthoigianEntity.Doilenh = LIB.ConvertString.NumbertoDB(txt_DOILENH.Text.Trim());
            _DinhmucthoigianEntity.Lencuon = LIB.ConvertString.NumbertoDB(txt_LENCUON.Text.Trim());
            _DinhmucthoigianEntity.Xuongcuon = LIB.ConvertString.NumbertoDB(txt_XUONGCUON.Text.Trim());
            _DinhmucthoigianEntity.Thaythietbi = LIB.ConvertString.NumbertoDB(txt_THAYTHIETBI.Text.Trim());
            _DinhmucthoigianEntity.Dungmay = LIB.ConvertString.NumbertoDB(txt_DUNGMAY.Text.Trim());

            if (string.IsNullOrEmpty(_str_MAHIEU_PK))
            {
                _DinhmucthoigianEntity.Ngaytao = DateTime.Now;
                _DinhmucthoigianEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_MAHIEU_PK = _DinhmucthoigianManager.InsertV2(_DinhmucthoigianEntity, r_Insert, DT_DINHMUCTHOIGIAN, BS_DINHMUCTHOIGIAN);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmucthoigianManager.Convert(_DinhmucthoigianEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = false;
                BS_DINHMUCTHOIGIAN.ResetCurrentItem();
            }
            else
            {
                _DinhmucthoigianEntity.Ngaysua = DateTime.Now;
                _DinhmucthoigianEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DinhmucthoigianManager.Update(_DinhmucthoigianEntity);
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Madmtg.Name].Value = _DinhmucthoigianEntity.Madmtg;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Tendinhmuc.Name].Value = _DinhmucthoigianEntity.Tendinhmuc;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Mamay.Name].Value = _DinhmucthoigianEntity.Mamay;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Madongmay.Name].Value = _DinhmucthoigianEntity.Madongmay;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Macongdoan.Name].Value = _DinhmucthoigianEntity.Macongdoan;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Khotu.Name].Value = _DinhmucthoigianEntity.Khotu;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Khoden.Name].Value = _DinhmucthoigianEntity.Khoden;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Chieudaitu.Name].Value = _DinhmucthoigianEntity.Chieudaitu;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Chieudaiden.Name].Value = _DinhmucthoigianEntity.Chieudaiden;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dodaytu.Name].Value = _DinhmucthoigianEntity.Dodaytu;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dodayden.Name].Value = _DinhmucthoigianEntity.Dodayden;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Somauma.Name].Value = _DinhmucthoigianEntity.Somauma;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Sohinhma.Name].Value = _DinhmucthoigianEntity.Sohinhma;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Maloaimang.Name].Value = _DinhmucthoigianEntity.Maloaimang;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Maqcthanhpham.Name].Value = _DinhmucthoigianEntity.Maqcthanhpham;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dauca.Name].Value = _DinhmucthoigianEntity.Dauca;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Daucuon.Name].Value = _DinhmucthoigianEntity.Daucuon;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Doilenh.Name].Value = _DinhmucthoigianEntity.Doilenh;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Lencuon.Name].Value = _DinhmucthoigianEntity.Lencuon;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Xuongcuon.Name].Value = _DinhmucthoigianEntity.Xuongcuon;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Thaythietbi.Name].Value = _DinhmucthoigianEntity.Thaythietbi;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dungmay.Name].Value = _DinhmucthoigianEntity.Dungmay;

                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmucthoigianManager.Convert(_DinhmucthoigianEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = false;
            }
            return _str_MAHIEU_PK;
        }

        #region Validate
        private void txt_MAMAY_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAMAY.Text.Trim()) || DT_DMMAY == null || DT_DMMAY.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MAMAY.Text.Trim().ToUpper();
            _RowViewSelect = checkmamay(_str_MACANTIM, DT_DMMAY);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMAY.xml",
                        DT_DMMAY, DmmayFields.Mamay.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAMAY.Text = _RowViewSelect[DmmayFields.Mamay.Name].ToString();
                txt_TENMAY.Text = _RowViewSelect[DmmayFields.Tenmay.Name].ToString();
            }
            else
            {
                txt_TENMAY.Text = _RowViewSelect[DmmayFields.Tenmay.Name].ToString();
            }
        }

        private DataRow checkmamay(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmmayFields.Mamay.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MADONGMAY_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MADONGMAY.Text.Trim()) || DT_DMDONGMAY == null || DT_DMDONGMAY.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MADONGMAY.Text.Trim().ToUpper();
            _RowViewSelect = checkmaDongmay(_str_MACANTIM, DT_DMDONGMAY);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMDONGMAY.xml",
                        DT_DMDONGMAY, DmdongmayFields.Madm.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MADONGMAY.Text = _RowViewSelect[DmdongmayFields.Madm.Name].ToString();
                txt_TENDONGMAY.Text = _RowViewSelect[DmdongmayFields.Tendongmay.Name].ToString();
            }
            else
                txt_TENDONGMAY.Text = _RowViewSelect[DmdongmayFields.Tendongmay.Name].ToString();
        }
        private DataRow checkmaDongmay(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmdongmayFields.Madm.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

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

        private void btn_CHONSOMAU_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC("Danh sách số màu", LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH_CHON.xml", DT_SOMAU, DmquycachFields.Maquycach.Name, txt_SOMAUMA.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmquycachFields.Maquycach.Name].ToString() + ",";

            txt_SOMAUMA.Text = str;
        }

        private void btn_CHONSOHINH_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC("Danh sách số hình", LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH_CHON.xml", DT_SOHINH, DmquycachFields.Maquycach.Name, txt_SOHINHMA.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmquycachFields.Maquycach.Name].ToString() + ",";

            txt_SOHINHMA.Text = str;
        }

        private void btn_CHONLOAIMANG_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC("Danh sách loại màng", LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH_CHON.xml", DT_LOAIMANG, DmquycachFields.Maquycach.Name, txt_MALOAIMANG.Text);
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
                new ListviewJanusC("Danh sách quy cách thành phẩm", LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH_CHON.xml", DT_QCTHANHPHAM, DmquycachFields.Maquycach.Name, txt_MAQCTHANHPHAM.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmquycachFields.Maquycach.Name].ToString() + ",";

            txt_MAQCTHANHPHAM.Text = str;
        }

        #endregion

        #region Shortcut Key
        private void txt_MAMAY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMMAY frm_Dm = new FRM_DMMAY();
                frm_Dm.Text = "Danh sách máy";
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
        #endregion

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_DINHMUCTHOIGIAN.ColumnAutoResize = true;
            else
                GRID_DINHMUCTHOIGIAN.ColumnAutoResize = false;
        }

        private void FRM_DINHMUCTHOIGIAN_FormClosing(object sender, FormClosingEventArgs e)
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
