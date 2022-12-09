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
using GD.BBPH.APP.DANHMUC;
using System.Data.SqlClient;

namespace GD.BBPH.APP.BANHANG
{
    public partial class FRM_PHIEUGIAOHANG : FRM_DMPARENT
    {
        private PhieugiaohangHManager _PhieugiaohangHManager = new PhieugiaohangHManager();
        private PhieugiaohangHEntity _PhieugiaohangHEntity = new PhieugiaohangHEntity();
        private PhieugiaohangDManager _PhieugiaohangDManager = new PhieugiaohangDManager();
        private PhieugiaohangDEntity _PhieugiaohangDEntity = new PhieugiaohangDEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_PHIEUGIAOHANG_H = new DataTable(), DT_PHIEUGIAOHANG_D = new DataTable(), DT_PHIEUGIAOHANG_D_FILL = new DataTable();
        private BindingSource BS_PHIEUGIAOHANG_H = new BindingSource(), BS_PHIEUGIAOHANG_D = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null, _RowDanhmuchanghoa = null;
        private GD.BBPH.CONTROL.JGridEX GRID_PHIEUGIAOHANG_H = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_PHIEUGIAOHANG_D = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";
        private string MADONHANG = "", SoPO = "", MAKHACHHANG = "", MAHANG = "";
        private decimal _Vat = 10;

        public DataTable DT_HANGCHON = new DataTable(), DT_DONHANG_H = new DataTable(), DT_DMXE = new DataTable(),
                        DT_DONHANG_D = new DataTable(), DT_BAOGIA_H = new DataTable(), DT_DMKHACH = new DataTable(), DT_DMHANGHOA = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_PHIEUGIAOHANG");
                        DT_PHIEUGIAOHANG_H = LIB.Procedures.Danhsachphieugiaohang(LIB.SESSION_START.TS_NGAYDAUQUY, LIB.SESSION_START.TS_NGAYCUOIQUY, MAHIEU_PK, MADONHANG, MAKHACHHANG, MAHANG);
                        DT_PHIEUGIAOHANG_D = LIB.Procedures.Danhsachphieugiaohangchitiet(LIB.SESSION_START.TS_NGAYDAUQUY, LIB.SESSION_START.TS_NGAYCUOIQUY, MAHIEU_PK, MADONHANG, MAKHACHHANG, MAHANG);
                        DT_PHIEUGIAOHANG_D_FILL = DT_PHIEUGIAOHANG_D.Clone();

                        //DT_BAOGIA_H = LIB.SESSION_START.DT_BAOGIA_H;
                        DT_DONHANG_D = new DonhangDManager().SelectAllRDT();
                        //DT_DONHANG_D = LIB.SESSION_START.DT_DONHANG_D_DCC;
                        DT_DMKHACH = new DmkhachManager().SelectAllRDT();
                        DT_DMHANGHOA = new DmhangManager().SelectAllRDT();
                        //DT_DMHANGHOA = LIB.SESSION_START.DT_DMHANGHOA;
                        //DT_DMXE = LIB.SESSION_START.DT_DMXE;
                        _Vat = LIB.ConvertString.NumbertoDB(LIB.Procedures.Laygiatrithamso("Vat"));
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

        public FRM_PHIEUGIAOHANG()
        {
            InitializeComponent();
            PhieugiaohangHManager _PhieugiaohangHManager = new PhieugiaohangHManager();
            DataTable dt111 = _PhieugiaohangHManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_PHIEUGIAOHANG_H.xml");
            dt111 = _PhieugiaohangDManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_PHIEUGIAOHANG_D.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMDONG, btn_THEMDONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOADONG, btn_XOADONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LAMMOI, btn_LAMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_TIMKIEM, btn_TIMKIEM.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_IN, btn_IN.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_PHIEUGIAOHANG_H.xml", GRID_PHIEUGIAOHANG_H, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_PHIEUGIAOHANG_D.xml", GRID_PHIEUGIAOHANG_D, pne_CHITIET);
            GRID_PHIEUGIAOHANG_H.RootTable.SortKeys.Add(PhieugiaohangHFields.Ngaygiao.Name, Janus.Windows.GridEX.SortOrder.Descending);
            GRID_PHIEUGIAOHANG_D.FilterMode = FilterMode.None;
            GRID_PHIEUGIAOHANG_D.GroupByBoxVisible = false;
            FORM_PROCESS();
            //GRID_PHIEUGIAOHANG_D.COMBO_MULTICOLUMN(GRID_PHIEUGIAOHANG_D, PhieugiaohangDFields.Masp.Name, DanhmuchanghoaFields.Tenhieu.Name, DanhmuchanghoaFields.Mahieu.Name, DanhmuchanghoaFields.Mahieu.Name, DT_DMHANG);
            GRID_PHIEUGIAOHANG_D.CellEdited += GRID_PHIEUGIAOHANG_D_CellEdited;
            GRID_PHIEUGIAOHANG_D.RecordsDeleted += GRID_PHIEUGIAOHANG_D_RecordsDeleted;
            GRID_PHIEUGIAOHANG_D.RecordUpdated += GRID_PHIEUGIAOHANG_D_RecordUpdated;
            GRID_PHIEUGIAOHANG_D.DeletingRecord += GRID_PHIEUGIAOHANG_D_DeletingRecord;
            //GRID_PHIEUGIAOHANG_D.Click += GRID_PHIEUGIAOHANG_D_Click;
            GRID_PHIEUGIAOHANG_D.RootTable.Columns["Thanhtien"].EditType = EditType.NoEdit;
            DataView Source_View = new DataView(DT_PHIEUGIAOHANG_H);
            BS_PHIEUGIAOHANG_H = new BindingSource();
            BS_PHIEUGIAOHANG_H.DataSource = Source_View;
            GRID_PHIEUGIAOHANG_H.DataSource = BS_PHIEUGIAOHANG_H;
            BS_PHIEUGIAOHANG_H.CurrentChanged += new EventHandler(BS_PHIEUGIAOHANG_H_CurrentChanged);
            BS_PHIEUGIAOHANG_H_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        #region Xử lý Grid Detail

        private void GRID_PHIEUGIAOHANG_D_RecordUpdated(object sender, EventArgs e)
        {
            Tinhtong();
        }
        private void GRID_PHIEUGIAOHANG_D_RecordsDeleted(object sender, EventArgs e)
        {
            Tinhtong();
        }
        private void GRID_PHIEUGIAOHANG_D_CellEdited(object sender, ColumnActionEventArgs e)
        {
            //GRID_PHIEUGIAOHANG_D.UpdateData();
            //decimal VATpe = 0, VATbao = 0, VATtong = 0;
            //GridEXRow[] listGrid = GRID_PHIEUGIAOHANG_D.GetDataRows();
            //// tính giá có VAT
            //foreach (GridEXRow _grid in listGrid)
            //{
            //    DataRowView _view = (DataRowView)_grid.DataRow;
            //    if (_view == null) continue;
            //    VATpe = LIB.ConvertString.NumbertoDB(_view[PhieugiaohangDFields.Dongiapechuavat.Name].ToString()) * 10 / 100;
            //    _view[PhieugiaohangDFields.Dongiapecovat.Name] = LIB.ConvertString.NumbertoDB(_view[PhieugiaohangDFields.Dongiapechuavat.Name].ToString()) + VATpe;
            //    VATbao = LIB.ConvertString.NumbertoDB(_view[PhieugiaohangDFields.Dongiabaochuavat.Name].ToString()) * 10 / 100;
            //    _view[PhieugiaohangDFields.Dongiabaocovat.Name] = LIB.ConvertString.NumbertoDB(_view[PhieugiaohangDFields.Dongiabaochuavat.Name].ToString()) + VATbao;
            //    VATtong = LIB.ConvertString.NumbertoDB(_view[PhieugiaohangDFields.Dongiatongchuavat.Name].ToString()) * 10 / 100;
            //    _view[PhieugiaohangDFields.Dongiatongcovat.Name] = LIB.ConvertString.NumbertoDB(_view[PhieugiaohangDFields.Dongiatongchuavat.Name].ToString()) + VATtong;
            //}
            Tinhtong();
        }
        private void GRID_PHIEUGIAOHANG_D_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {
            //throw new NotImplementedException();
            btn_XOADONG_Click(new object(), new EventArgs());
            Tinhtong();
        }

        //private void GRID_PHIEUGIAOHANG_D_Click(object sender, EventArgs e)
        //{
        //    Tinhtong();
        //}
        private void Tinhtong()
        {
            decimal tong = 0, dongia = 0;
            int soluong = 0;
            try
            {
                GRID_PHIEUGIAOHANG_D.UpdateData();
                GridEXRow[] listGrid = GRID_PHIEUGIAOHANG_D.GetDataRows();
                //-------Tính tổng
                foreach (GridEXRow _grid in listGrid)
                {
                    DataRowView _view = (DataRowView)_grid.DataRow;
                    if (_view == null) continue;
                    soluong = Convert.ToInt32(_view["Soluong"]);
                    dongia = Convert.ToDecimal(_view["Dongia"]);
                    _view["Thanhtien"] = soluong * dongia;

                    tong += soluong * dongia;
                }
                txt_TONGTIEN.Text = tong.ToString("#,0.00", new System.Globalization.CultureInfo("vi-VN"));

            }
            catch { }
        }
        #endregion

        void BS_PHIEUGIAOHANG_H_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                // GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_PHIEUGIAOHANG_H.UpdateData();
                if (BS_PHIEUGIAOHANG_H.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_PHIEUGIAOHANG_H.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[PhieugiaohangHFields.Sophieu.Name].ToString();

                    txt_SOPHIEUGIAO.Text = _Rowview.Row[PhieugiaohangHFields.Sophieu.Name].ToString();
                    txt_NGAYGIAO.Text = _Rowview.Row[PhieugiaohangHFields.Ngaygiao.Name].ToString();
                    txt_MAKHACH.Text = _Rowview.Row[PhieugiaohangHFields.Makhach.Name].ToString();
                    txt_TONGTIEN.Text = _Rowview.Row[PhieugiaohangHFields.Tongtien.Name].ToString();

                    txt_MAKHACH_Validating(new object(), new CancelEventArgs());
                    txt_MADONHANG_Validating(new object(), new CancelEventArgs());


                    txt_VAT.Text = _Rowview.Row[PhieugiaohangHFields.Vat.Name].ToString();
                    if(string.IsNullOrEmpty(txt_VAT.Text))
                        txt_VAT.Text = _Vat.ToString();

                    SHOWGRID(MAHIEU_PK);
                    #region Load grid
                    //try
                    //{
                    //    DataRow[] drArr = DT_PHIEUGIAOHANG_D.Select(PhieugiaohangHFields.Sophieuxuat.Name + "='" + MAHIEU_PK + "'");
                    //    if (drArr.Length != 0)
                    //    {
                    //        DT_PHIEUGIAOHANG_D_FILL = drArr.CopyToDataTable();
                    //    }
                    //    else DT_PHIEUGIAOHANG_D_FILL.Clear();
                    //    GRID_PHIEUGIAOHANG_D.DataSource = DT_PHIEUGIAOHANG_D_FILL;
                    //}
                    //catch (Exception ex) { }
                    #endregion
                }
                else
                {
                    SHOWGRID("");
                }
            }
            catch { }
        }
        void BS_PHIEUGIAOHANG_D_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GRID_PHIEUGIAOHANG_D.UpdateData();
                if (BS_PHIEUGIAOHANG_D.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_PHIEUGIAOHANG_D.Current;
                    MACHITIET = "";
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[PhieugiaohangDFields.Id.Name].ToString();
                    txt_MAHANG.Text = _Rowview.Row[PhieugiaohangDFields.Masp.Name].ToString();
                    txt_MADONHANG.Text = _Rowview.Row[PhieugiaohangDFields.Madon.Name].ToString();

                    txt_MAHANG_Validating(new object(), new CancelEventArgs());
                    txt_MADONHANG_Validating(new object(), new CancelEventArgs());

                    try { txt_SOLUONG.Text = int.Parse(_Rowview.Row[PhieugiaohangDFields.Soluong.Name].ToString()).ToString("#.00", new System.Globalization.CultureInfo("vi-VN")); }
                    catch { }
                    try { txt_DONGIA.Text = decimal.Parse(_Rowview.Row[PhieugiaohangDFields.Dongia.Name].ToString()).ToString("#.00", new System.Globalization.CultureInfo("vi-VN")); }
                    catch { }
                }
                //else
                //{
                //    GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                //}
            }
            catch { }
        }
        private void SHOWGRID(string MAHIEU_PK)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK))
            {
                DT_PHIEUGIAOHANG_D_FILL = new PhieugiaohangDManager().Clone();
                //DT_PHIEUGIAOHANG_D_FILL.Columns.Add("Thanhtien", Type.GetType("System.Decimal"));
                BS_PHIEUGIAOHANG_D = new BindingSource(DT_PHIEUGIAOHANG_D_FILL, null);
                GRID_PHIEUGIAOHANG_D.DataSource = BS_PHIEUGIAOHANG_D;
            }
            else
            {
                DT_PHIEUGIAOHANG_D_FILL = LIB.Procedures.Danhsachphieugiaohangchitiet(LIB.SESSION_START.TS_NGAYDAUQUY, LIB.SESSION_START.TS_NGAYCUOIQUY, MAHIEU_PK, MADONHANG, MAKHACHHANG, MAHANG);
               // DT_PHIEUGIAOHANG_D_FILL.Columns.Add("Thanhtien", Type.GetType("System.Decimal"));

                DataView Source_View = new DataView(DT_PHIEUGIAOHANG_D_FILL);
                BS_PHIEUGIAOHANG_D = new BindingSource();
                BS_PHIEUGIAOHANG_D.DataSource = Source_View;
                GRID_PHIEUGIAOHANG_D.DataSource = BS_PHIEUGIAOHANG_D;
            }
            BS_PHIEUGIAOHANG_D.CurrentChanged += new EventHandler(BS_PHIEUGIAOHANG_D_CurrentChanged);
            BS_PHIEUGIAOHANG_D_CurrentChanged((new object()), (new EventArgs()));
        }

        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            DataRow r_Detail = DT_PHIEUGIAOHANG_D_FILL.NewRow();
            r_Detail[PhieugiaohangDFields.Sophieu.Name] = txt_SOPHIEUGIAO.Text;
            r_Detail[PhieugiaohangDFields.Madon.Name] = txt_MADONHANG.Text;
            r_Detail[PhieugiaohangDFields.Makhach.Name] = txt_MAKHACH.Text;
            try { r_Detail[PhieugiaohangDFields.DonchitietId.Name] = Convert.ToInt64(txt_MADONHANG_D.Text.Trim()); }
            catch { }
            //r_Detail[PhieugiaohangDFields.Loaihang.Name] = txt_LOAIHANG.Text;
            r_Detail[PhieugiaohangDFields.Masp.Name] = txt_MAHANG.Text;
            //r_Detail[PhieugiaohangDFields.Mauin.Name] = txt_MAUIN.Text;
            //r_Detail[PhieugiaohangDFields.Loai.Name] = txt_LOAI.Text;
            try { r_Detail[PhieugiaohangDFields.Soluong.Name] = LIB.ConvertString.NumbertoDB(txt_SOLUONG.Text.Trim()); }
            catch { }
            try { r_Detail[PhieugiaohangDFields.Dongia.Name] = LIB.ConvertString.NumbertoDB(txt_DONGIA.Text.Trim()); }
            catch { }

            DT_PHIEUGIAOHANG_D_FILL.Rows.Add(r_Detail);

            DataView Source_View = new DataView(DT_PHIEUGIAOHANG_D_FILL);
            BS_PHIEUGIAOHANG_D = new BindingSource();
            BS_PHIEUGIAOHANG_D.DataSource = Source_View;
            GRID_PHIEUGIAOHANG_D.DataSource = BS_PHIEUGIAOHANG_D;
            BS_PHIEUGIAOHANG_D.Position = DT_PHIEUGIAOHANG_D_FILL.Rows.Count;
            Tinhtong();
            txt_MAHANG.Focus();
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_PHIEUGIAOHANG_D.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[PhieugiaohangDFields.Id.Name].ToString();
            string _MAHANG = _view[PhieugiaohangDFields.Masp.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MAHANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_PHIEUGIAOHANG_D.CurrentRow.Delete();
            }
            else
            {
                PhieugiaohangDManager _PhieugiaohangDManager = new PhieugiaohangDManager();
                PhieugiaohangDEntity _PhieugiaohangDEntity = new PhieugiaohangDEntity();
                try { _PhieugiaohangDEntity = _PhieugiaohangDManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_PhieugiaohangDEntity != null && MessageBox.Show("Xóa dòng: " + _MAHANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _PhieugiaohangDManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_PHIEUGIAOHANG_D_FILL.Select(PhieugiaohangDFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_PHIEUGIAOHANG_D_FILL.Rows.Remove(drArr[0]);
                        //GRID_PHIEUGIAOHANG_D.CurrentRow.Delete();
                        //GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangHManager.Convert(_PhieugiaohangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa dòng " + _MAHANG + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    BS_PHIEUGIAOHANG_D.ResetCurrentItem();
                    GRID_PHIEUGIAOHANG_D.DataSource = BS_PHIEUGIAOHANG_D;
                }
                GRID_PHIEUGIAOHANG_D.Enabled = true;
            }
            Tinhtong();
        }

        private void btn_SUADONG_Click(object sender, EventArgs e)
        {
            GRID_PHIEUGIAOHANG_D.CurrentRow.Cells[PhieugiaohangDFields.Masp.Name].Value = txt_MAHANG.Text;
            GRID_PHIEUGIAOHANG_D.CurrentRow.Cells[PhieugiaohangDFields.Tenhang.Name].Value = txt_TENHANG.Text;
            GRID_PHIEUGIAOHANG_D.CurrentRow.Cells[PhieugiaohangDFields.Madon.Name].Value = txt_MADONHANG.Text;

            GRID_PHIEUGIAOHANG_D.CurrentRow.Cells[PhieugiaohangDFields.Makhach.Name].Value = txt_MAKHACH.Text;
            GRID_PHIEUGIAOHANG_D.CurrentRow.Cells[PhieugiaohangDFields.Tenkhach.Name].Value = txt_TENKHACH.Text;
            GRID_PHIEUGIAOHANG_D.CurrentRow.Cells[PhieugiaohangDFields.Soluong.Name].Value = LIB.ConvertString.NumbertoDB(txt_SOLUONG.Text.Trim());
            GRID_PHIEUGIAOHANG_D.CurrentRow.Cells[PhieugiaohangDFields.Dongia.Name].Value = LIB.ConvertString.NumbertoDB(txt_DONGIA.Text.Trim());
            GRID_PHIEUGIAOHANG_D.CurrentRow.Cells[PhieugiaohangDFields.Thanhtien.Name].Value = LIB.ConvertString.NumbertoDB(txt_TONGTIEN.Text.Trim());
        }
        #endregion

        private string Save_Data(string _str_MAHIEU_PK)
        {
            PhieugiaohangHEntity _PhieugiaohangHEntity = new PhieugiaohangHEntity();
            _PhieugiaohangHEntity.Sophieu = txt_SOPHIEUGIAO.Text.Trim();
            try { _PhieugiaohangHEntity.Ngaygiao = Convert.ToDateTime(txt_NGAYGIAO.Text.Trim()); }
            catch { }
            _PhieugiaohangHEntity.Madon = txt_MADONHANG.Text.Trim();
            try { _PhieugiaohangHEntity.Ngaydat = Convert.ToDateTime(txt_NGAYDAT.Text.Trim()); }
            catch { }
            //_PhieugiaohangHEntity.Sopo = txt_SOPO.Text.Trim();
            _PhieugiaohangHEntity.Makhach = txt_MAKHACH.Text.Trim();
            _PhieugiaohangHEntity.Tenkhach = txt_TENKHACH.Text.Trim();
            //_PhieugiaohangHEntity.Bienkiemsoat = txt_BIENKIEMSOAT.Text.Trim();
            //_PhieugiaohangHEntity.Laixehoten = txt_LAIXEHOTEN.Text.Trim();
            //_PhieugiaohangHEntity.Laixeghichu = txt_LAIXEGHICHU.Text.Trim();
            try { _PhieugiaohangHEntity.Tongtien = Convert.ToInt32(txt_TONGTIEN.Text.Trim()); }
            catch { }
            try { _PhieugiaohangHEntity.Vat = Convert.ToInt32(txt_VAT.Text.Trim()); }
            catch { }
            GRID_PHIEUGIAOHANG_D.UpdateData();


            EntityCollection _PhieugiaohangDEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_PHIEUGIAOHANG_D.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                PhieugiaohangDEntity _PhieugiaohangDEntity = new PhieugiaohangDEntity();
                _PhieugiaohangDEntity.Sophieu = _PhieugiaohangHEntity.Sophieu;
                _PhieugiaohangDEntity.Ngaygiao = _PhieugiaohangHEntity.Ngaygiao;
                _PhieugiaohangDEntity.Madon = _view[PhieugiaohangDFields.Madon.Name].ToString();
                _PhieugiaohangDEntity.Makhach = _view[PhieugiaohangDFields.Makhach.Name].ToString();
                try { _PhieugiaohangDEntity.DonchitietId = Convert.ToInt64(_view[PhieugiaohangDFields.DonchitietId.Name].ToString()); }
                catch { }
                //try { _PhieugiaohangDEntity.Loaihang = Convert.ToInt32(_view[PhieugiaohangDFields.Loaihang.Name].ToString()); }
                //catch { }
                _PhieugiaohangDEntity.Masp = _view[PhieugiaohangDFields.Masp.Name].ToString();
                _PhieugiaohangDEntity.Tenhang = _view[PhieugiaohangDFields.Tenhang.Name].ToString();
                //_PhieugiaohangDEntity.Mauin = _view[PhieugiaohangDFields.Mauin.Name].ToString();
                //_PhieugiaohangDEntity.Loai = _view[PhieugiaohangDFields.Loai.Name].ToString();
                try { _PhieugiaohangDEntity.Soluong = Convert.ToInt32(_view[PhieugiaohangDFields.Soluong.Name].ToString()); }
                catch { }
                try { _PhieugiaohangDEntity.Dongia = Convert.ToDecimal(_view[PhieugiaohangDFields.Dongia.Name].ToString()); }
                catch { }
                try { _PhieugiaohangDEntity.Thanhtien = Convert.ToDecimal(_view[PhieugiaohangDFields.Thanhtien.Name].ToString()); }
                catch { }
                _PhieugiaohangDEntity.Ghichu = _view[PhieugiaohangDFields.Ghichu.Name].ToString();

                try { _PhieugiaohangDEntity.Id = Convert.ToInt64(_view[PhieugiaohangDFields.Id.Name].ToString()); }
                catch { }

                _PhieugiaohangDEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_PhieugiaohangDEntity.IsNew)
                {
                    EntityCollection drDHCT = (new PhieugiaohangDManager()).SelectById(_PhieugiaohangDEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _PhieugiaohangDEntity.Ngaysua = DateTime.Now;
                        _PhieugiaohangDEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _PhieugiaohangDEntity.IsNew = false;
                    }
                    else
                    {
                        _PhieugiaohangDEntity.Ngaytao = DateTime.Now;
                        _PhieugiaohangDEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }

                if(!string.IsNullOrEmpty(_PhieugiaohangDEntity.Masp))
                    _PhieugiaohangDEntityCol.Add(_PhieugiaohangDEntity);
            }

            if (string.IsNullOrEmpty(_str_MAHIEU_PK))
            {
                _PhieugiaohangHEntity.Ngaytao = DateTime.Now;
                _PhieugiaohangHEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_MAHIEU_PK = _PhieugiaohangHManager.InsertV2(_PhieugiaohangHEntity, r_Insert, DT_PHIEUGIAOHANG_H, BS_PHIEUGIAOHANG_H);
                _PhieugiaohangDManager.InsertCollection(_PhieugiaohangDEntityCol);
                GRID_PHIEUGIAOHANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_PHIEUGIAOHANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_PHIEUGIAOHANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangHManager.Convert(_PhieugiaohangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                BS_PHIEUGIAOHANG_H.ResetCurrentItem();
                BS_PHIEUGIAOHANG_H_CurrentChanged(new object(), new EventArgs());
                BS_PHIEUGIAOHANG_H.Position = DT_PHIEUGIAOHANG_H.Rows.Count - 1;
            }
            else
            {
                _PhieugiaohangHEntity.Ngaysua = DateTime.Now;
                _PhieugiaohangHEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _PhieugiaohangHManager.Update(_PhieugiaohangHEntity);
                foreach (PhieugiaohangDEntity _PhieugiaohangDEntity in _PhieugiaohangDEntityCol)
                {
                    if (_PhieugiaohangDEntity.IsNew)
                    {
                        DataRow _r_Insert = DT_PHIEUGIAOHANG_D.NewRow();
                        DT_PHIEUGIAOHANG_D.Rows.Add(_r_Insert);
                        _PhieugiaohangDManager.InsertV2(_PhieugiaohangDEntity, _r_Insert, DT_PHIEUGIAOHANG_D, BS_PHIEUGIAOHANG_D);
                    }
                    else _PhieugiaohangDManager.Update(_PhieugiaohangDEntity);
                }
                GRID_PHIEUGIAOHANG_H.CurrentRow.Cells[PhieugiaohangHFields.Ngaygiao.Name].Value = _PhieugiaohangHEntity.Ngaygiao;
                GRID_PHIEUGIAOHANG_H.CurrentRow.Cells[PhieugiaohangHFields.Madon.Name].Value = _PhieugiaohangHEntity.Madon;
                //GRID_PHIEUGIAOHANG_H.CurrentRow.Cells[PhieugiaohangHFields.Ngaydat.Name].Value = _PhieugiaohangHEntity.Ngaydat;
                //GRID_PHIEUGIAOHANG_H.CurrentRow.Cells[PhieugiaohangHFields.Sopo.Name].Value = _PhieugiaohangHEntity.Sopo;
                GRID_PHIEUGIAOHANG_H.CurrentRow.Cells[PhieugiaohangHFields.Tenkhach.Name].Value = _PhieugiaohangHEntity.Tenkhach;
                //GRID_PHIEUGIAOHANG_H.CurrentRow.Cells[PhieugiaohangHFields.Bienkiemsoat.Name].Value = _PhieugiaohangHEntity.Bienkiemsoat;
                //GRID_PHIEUGIAOHANG_H.CurrentRow.Cells[PhieugiaohangHFields.Laixehoten.Name].Value = _PhieugiaohangHEntity.Laixehoten;
                //GRID_PHIEUGIAOHANG_H.CurrentRow.Cells[PhieugiaohangHFields.Laixeghichu.Name].Value = _PhieugiaohangHEntity.Laixeghichu;
                GRID_PHIEUGIAOHANG_H.CurrentRow.Cells[PhieugiaohangHFields.Vat.Name].Value = _PhieugiaohangHEntity.Vat;

                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangHManager.Convert(_PhieugiaohangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GRID_PHIEUGIAOHANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_PHIEUGIAOHANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_PHIEUGIAOHANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_SUADONG.Enabled =  false;
                BS_PHIEUGIAOHANG_H.ResetCurrentItem();
                BS_PHIEUGIAOHANG_H_CurrentChanged(new object(), new EventArgs());
            }
            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_SOPHIEUGIAO.Text = txt_NGAYDAT.Text = txt_MAKHACH.Text = txt_TENKHACH.Text 
                = txt_MAHANG.Text = txt_TENHANG.Text = txt_LOAI.Text = txt_MADONHANG.Text = txt_NGAYGIAO.Text 
               /* = txt_SOPO.Text*/ = txt_SOLUONG.Text = txt_DONGIA.Text =/* txt_SOLUONGCONLAI.Text =*/ txt_TONGTIEN.Text 
                /*= txt_BIENKIEMSOAT.Text = txt_LAIXEHOTEN.Text = txt_LAIXEGHICHU.Text */= string.Empty;
            r_Insert = DT_PHIEUGIAOHANG_H.NewRow();
            DT_PHIEUGIAOHANG_H.Rows.Add(r_Insert);
            BS_PHIEUGIAOHANG_H.Position = DT_PHIEUGIAOHANG_H.Rows.Count;
            GRID_PHIEUGIAOHANG_D.Enabled = true;
            GRID_PHIEUGIAOHANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_PHIEUGIAOHANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_PHIEUGIAOHANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_PHIEUGIAOHANG_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            MAHIEU_PK = "";
            txt_SOPHIEUGIAO.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_NGAYDAT,/* txt_SOPO,*/ txt_TENKHACH,  txt_TONGTIEN, txt_TENHANG, txt_LOAI,/* txt_SOLUONGCONLAI,*//* txt_LAIXEHOTEN, txt_LAIXEGHICHU */}));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_SUADONG.Enabled = true;
            GRID_PHIEUGIAOHANG_H.Enabled = false;
            btn_TIMKIEM.Enabled = btn_IN.Enabled = false;
            txt_NGAYGIAO.Text = LIB.SESSION_START.TS_NGAYLAMVIEC.ToString("dd/MM/yyyy");
        }

        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_SUADONG.Enabled = true;
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_NGAYDAT, /*txt_SOPO,*/ txt_TENKHACH,  txt_TONGTIEN, txt_TENHANG, txt_LOAI,/* txt_SOLUONGCONLAI,*/ /*txt_LAIXEHOTEN, txt_LAIXEGHICHU*/ }));
                //txt_TENHIEU.Focus();
            }
            GRID_PHIEUGIAOHANG_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_PHIEUGIAOHANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_PHIEUGIAOHANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_PHIEUGIAOHANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_PHIEUGIAOHANG_D.Enabled = true;
            GRID_PHIEUGIAOHANG_H.Enabled = false;
            btn_XOADONG.Enabled = true;
            btn_TIMKIEM.Enabled = btn_IN.Enabled = false;
        }

        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_PHIEUGIAOHANG_H.Rows.Remove(r_Insert);
            }
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_SUADONG.Enabled = false;
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            btn_TIMKIEM.Enabled = btn_IN.Enabled =btn_LAMMOI.Enabled = true;
            GRID_PHIEUGIAOHANG_H.Enabled = true;
            GRID_PHIEUGIAOHANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_PHIEUGIAOHANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_PHIEUGIAOHANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;

            BS_PHIEUGIAOHANG_H_CurrentChanged(new object(), new EventArgs());
        }

        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            PhieugiaohangHManager _PhieugiaohangHManager = new PhieugiaohangHManager();
            PhieugiaohangHEntity _PhieugiaohangHEntity = new PhieugiaohangHEntity();
            _PhieugiaohangHEntity = _PhieugiaohangHManager.SelectOne(MAHIEU_PK);
            if (_PhieugiaohangHEntity != null && MessageBox.Show("Xóa phiếu giao: " + MAHIEU_PK, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _PhieugiaohangDManager.DeleteBySophieugiao(MAHIEU_PK);
                    _PhieugiaohangHManager.Delete(MAHIEU_PK);
                    GRID_PHIEUGIAOHANG_H.CurrentRow.Delete();
                    BS_PHIEUGIAOHANG_H_CurrentChanged(new object(), new EventArgs());
                    //GD.BBPH.LIB.TrayPopup.PoupStringMessage(GD.BBPH.APP.Properties.Resources.MessageTitle, GD.BBPH.APP.Properties.Resources.MessageContent_T);
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangHManager.Convert(_PhieugiaohangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_SUADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa phiếu giao " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            btn_TIMKIEM.Enabled = btn_IN.Enabled = btn_LAMMOI.Enabled = true;
            GRID_PHIEUGIAOHANG_H.Enabled = true;
            GRID_PHIEUGIAOHANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_PHIEUGIAOHANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_PHIEUGIAOHANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }

        private void btn_LAMMOI_Click(object sender, EventArgs e)
        {
            if(btn_LUULAI.Enabled)
            {
                //DT_BAOGIA_H = LIB.SESSION_START.DT_BAOGIA_H;
                DT_DONHANG_H = new DonhangHManager().SelectAllRDT();
                //DT_DONHANG_D = LIB.SESSION_START.DT_DONHANG_D_DCC;
                DT_DMKHACH = new DmkhachManager().SelectAllRDT();
                //DT_DMHANGHOA = LIB.SESSION_START.DT_DMHANGHOA;
                //DT_DMXE = LIB.SESSION_START.DT_DMXE;
            }
            else
            {
                MAKHACHHANG = "";
                MAHANG = "";
                SoPO = "";
                MADONHANG = "";
                MAHIEU_PK = "";
                DT_PHIEUGIAOHANG_H = LIB.Procedures.Danhsachphieugiaohang(LIB.SESSION_START.TS_NGAYDAUQUY, LIB.SESSION_START.TS_NGAYCUOIQUY, MAHIEU_PK, MADONHANG, MAKHACHHANG, MAHANG);
                DataView Source_View = new DataView(DT_PHIEUGIAOHANG_H);
                BS_PHIEUGIAOHANG_H = new BindingSource();
                BS_PHIEUGIAOHANG_H.DataSource = Source_View;
                GRID_PHIEUGIAOHANG_H.DataSource = BS_PHIEUGIAOHANG_H;
                BS_PHIEUGIAOHANG_H.CurrentChanged += new EventHandler(BS_PHIEUGIAOHANG_H_CurrentChanged);
                BS_PHIEUGIAOHANG_H_CurrentChanged((new object()), (new EventArgs()));
            }

            if (btn_SUA.Enabled == true || btn_THEMMOI.Enabled == true)
            {
            }
        }

        private void btn_IN_Click(object sender, EventArgs e)
        {
            DataSet dsKetqua = new DataSet();
            DateTime _Ngaygiao = new DateTime(), _Ngayhieuluc = new DateTime();
            string _Sophieugiao = txt_SOPHIEUGIAO.Text; //, _Khachhang = "", _Phuongthuctt = "", _Laixehoten = "", _Noidung = "";

            try
            {
                #region Lay thong tin cac tham so
                
                #endregion

                #region Chay procedure
                DAL.DatabaseSpecific.DataAccessAdapter _DataAccessAdapter = new DAL.DatabaseSpecific.DataAccessAdapter(LIB.SESSION_START.ConnectionStringKeyName);
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@Sophieugiao", _Sophieugiao);

                _DataAccessAdapter.CallRetrievalStoredProcedure("Inphieugiaohang", parameters, dsKetqua);
                _DataAccessAdapter.CloseConnection();
                dsKetqua.Tables[0].TableName = "Inphieugiaohang";
                #endregion

                #region Tham so
                DataTable dtThamso = new DataTable("Thamso");
                dtThamso.Columns.Add("Ngaygiao");
                dtThamso.Columns.Add("Thoigianbaocao");
                dtThamso.Columns.Add("Sophieugiao");
                dtThamso.Columns.Add("Khachhang");
                dtThamso.Columns.Add("Madondathang");
                dtThamso.Columns.Add("Sopo");
                dtThamso.Columns.Add("Tongtien");
                dtThamso.Columns.Add("VAT");

                DataRow dr = dtThamso.NewRow();
                dr["Ngaygiao"] = txt_NGAYGIAO.Text;
                dr["Thoigianbaocao"] = "Hà Nội, ngày " + txt_NGAYGIAO.Text;
                dr["Sophieugiao"] = txt_SOPHIEUGIAO.Text;
                dr["Khachhang"] = txt_TENKHACH.Text;
                dr["Madondathang"] = txt_MADONHANG.Text;
                //dr["Sopo"] = txt_SOPO.Text;
                dr["Tongtien"] = txt_TONGTIEN.Text;
                dr["VAT"] = txt_VAT.Text;

                dtThamso.Rows.Add(dr);
                dsKetqua.Tables.Add(dtThamso);
                #endregion

                #region Mẫu giao thời
                string _Maubaocao = "PHIEUGIAOHANG_DC.rdlc";
                //try
                //{
                //    PhieugiaohangHEntity _PhieugiaohangHEntity = new PhieugiaohangHManager().SelectOne(_Sophieugiao);
                //    DondathangHEntity _DondathangHEntity = new DondathangHManager().SelectOne(_PhieugiaohangHEntity.Madon);
                //    if (_DondathangHEntity.Ngaybaogia < Convert.ToDateTime("01/02/2022") && _PhieugiaohangHEntity.Ngaygiao >= Convert.ToDateTime("01/02/2022"))
                //    {
                //        _Maubaocao = "PHIEUGIAOHANG_DC.rdlc";
                //    }
                //}
                //catch { }
                #endregion

                #region Hien bao cao
                new BAOCAO.FRM_REPORTVIEWER(dsKetqua, LIB.PATH.BBPH_PATH + @"\RDLC\" + _Maubaocao, "Inphieugiaohang", this.Text, true).Show();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_TIMKIEM_Click(object sender, EventArgs e)
        {
            //FRM_TIMKIEM frm = new FRM_TIMKIEM();
            //frm.ShowDialog();
            //if (frm._DialogResult == DialogResult.No) return;
            ////DT_PHIEUXUATHANG = LIB.SESSION_START.DT_PHIEUXUATHANG;
            //MAKHACHHANG = frm._Makhachhang;
            //MAHANG = frm._Mahang;
            //MADONHANG = frm._Madondathang;
            //MAHIEU_PK = "";
            //DT_PHIEUGIAOHANG_H = LIB.Procedures.Danhsachphieugiaohang(LIB.SESSION_START.TS_NGAYDAUQUY, LIB.SESSION_START.TS_NGAYCUOIQUY, MAHIEU_PK, MADONHANG, MAKHACHHANG, MAHANG);
            //DataView Source_View = new DataView(DT_PHIEUGIAOHANG_H);
            //BS_PHIEUGIAOHANG_H = new BindingSource();
            //BS_PHIEUGIAOHANG_H.DataSource = Source_View;
            //GRID_PHIEUGIAOHANG_H.DataSource = BS_PHIEUGIAOHANG_H;
            //BS_PHIEUGIAOHANG_H.CurrentChanged += new EventHandler(BS_PHIEUGIAOHANG_H_CurrentChanged);
            //BS_PHIEUGIAOHANG_H_CurrentChanged((new object()), (new EventArgs()));
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _PhieugiaohangHManager.SelectOne(txt_SOPHIEUGIAO.Text.Trim()) != null)
            {
                MessageBox.Show("Số phiếu giao bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SOPHIEUGIAO.Focus();
                return;
            }
            else if (txt_SOPHIEUGIAO.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SOPHIEUGIAO.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_PHIEUGIAOHANG_H.Enabled = true;
                btn_TIMKIEM.Enabled = btn_IN.Enabled = btn_LAMMOI.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_PHIEUGIAOHANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_PHIEUGIAOHANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_PHIEUGIAOHANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validate
        private void txt_MAKHACH_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            txt_TENKHACH.Text = string.Empty;
            if (string.IsNullOrEmpty(txt_MAKHACH.Text.Trim()) || DT_DMKHACH == null || DT_DMKHACH.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MAKHACH.Text.Trim().ToUpper();
            _RowViewSelect = checkMakhach(_str_MACANTIM, DT_DMKHACH);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMKHACH.xml",
                        DT_DMKHACH, DmkhachFields.Makhach.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAKHACH.Text = _RowViewSelect[DmkhachFields.Makhach.Name].ToString();
                txt_TENKHACH.Text = _RowViewSelect[DmkhachFields.Tenkhach.Name].ToString();

                DateTime _Ngay = LIB.SESSION_START.TS_NGAYLAMVIEC;
                try { _Ngay = Convert.ToDateTime(txt_NGAYGIAO.Text.Trim()); }
                catch { }
                DT_DMHANGHOA = LIB.Procedures.Danhsachhangchontronghoadon(txt_MAKHACH.Text, _Ngay); //new DmhangManager().SelectByMakhachRDT(txt_MAKHACH.Text);
                DT_DONHANG_D = new DonhangDManager().SelectByMakhachRDT(txt_MAKHACH.Text);
            }
            else
            {
                txt_TENKHACH.Text = _RowViewSelect[DmkhachFields.Tenkhach.Name].ToString();

                DateTime _Ngay = LIB.SESSION_START.TS_NGAYLAMVIEC;
                try { _Ngay = Convert.ToDateTime(txt_NGAYGIAO.Text.Trim()); }
                catch { }
                DT_DMHANGHOA = LIB.Procedures.Danhsachhangchontronghoadon(txt_MAKHACH.Text, _Ngay); //new DmhangManager().SelectByMakhachRDT(txt_MAKHACH.Text);
                DT_DONHANG_D = new DonhangDManager().SelectByMakhachRDT(txt_MAKHACH.Text);
            }
        }
        private DataRow checkMakhach(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmkhachFields.Makhach.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MAHANG_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            txt_TENHANG.Text = txt_LOAI.Text = string.Empty;
            if (string.IsNullOrEmpty(txt_MAHANG.Text.Trim()) || DT_DMHANGHOA == null || DT_DMHANGHOA.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MAHANG.Text.Trim().ToUpper();
            _RowViewSelect = checkmaHang(_str_MACANTIM, DT_DMHANGHOA);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMHANG.xml",
                        DT_DMHANGHOA, DmhangFields.Masp.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAHANG.Text = _RowViewSelect[DmhangFields.Masp.Name].ToString();
                txt_TENHANG.Text = _RowViewSelect[DmhangFields.Tensp.Name].ToString();
            }
            else
            {
                txt_TENHANG.Text = _RowViewSelect[DmhangFields.Tensp.Name].ToString();
            }
        }
        private DataRow checkmaHang(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DonhangDFields.Masp.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MADONHANG_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            txt_NGAYDAT.Text =/* txt_SOPO.Text = txt_SOLUONGCONLAI.Text =*/ txt_MADONHANG_D.Text = txt_SOLUONG.Text = txt_DONGIA.Text = string.Empty;
            if (!btn_THEMMOI.Enabled && !btn_SUA.Enabled && string.IsNullOrEmpty(MACHITIET))
                DT_DONHANG_D = LIB.Procedures.Danhsachdondathangchitietkhongton(txt_MAKHACH.Text, txt_MAHANG.Text);
            //else
            //    DT_DONHANG_D = new DonhangDManager().SelectAllRDT();

            if (string.IsNullOrEmpty(txt_MADONHANG.Text.Trim()) || DT_DONHANG_D == null || DT_DONHANG_D.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MADONHANG.Text.Trim().ToUpper();
            _RowViewSelect = checkMadonhang(_str_MACANTIM, DT_DONHANG_D);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DONHANG_D.xml",
                        DT_DONHANG_D, DonhangDFields.Madon.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MADONHANG.Text = _RowViewSelect[DonhangDFields.Madon.Name].ToString();
                txt_NGAYDAT.Text = _RowViewSelect[DonhangDFields.Ngaydat.Name].ToString();
                //txt_SOPO.Text = _RowViewSelect[DonhangDFields.Sopo.Name].ToString();
                txt_MADONHANG_D.Text = _RowViewSelect[DonhangDFields.Id.Name].ToString();
                //try { txt_SOLUONGCONLAI.Text = int.Parse(_RowViewSelect[DonhangDFields.Soluongconlai.Name].ToString()).ToString("#.00", new System.Globalization.CultureInfo("vi-VN")); }
                //catch { }

                //try { txt_SOLUONG.Text = int.Parse(_RowViewSelect[DonhangDFields.Soluongconlai.Name].ToString()).ToString("#.00", new System.Globalization.CultureInfo("vi-VN")); }
                //catch { }
                try { txt_DONGIA.Text = double.Parse(_RowViewSelect[DonhangDFields.Dongia.Name].ToString()).ToString("#.00", new System.Globalization.CultureInfo("vi-VN")); }
                catch { }
            }
            else
            {
                txt_NGAYDAT.Text = _RowViewSelect[DonhangDFields.Ngaydat.Name].ToString();
                //txt_SOPO.Text = _RowViewSelect[DonhangDFields.Sopo.Name].ToString();
                txt_MADONHANG_D.Text = _RowViewSelect[DonhangDFields.Id.Name].ToString();
                //try { txt_SOLUONGCONLAI.Text = int.Parse(_RowViewSelect[DonhangDFields.Soluongconlai.Name].ToString()).ToString("#.00", new System.Globalization.CultureInfo("vi-VN")); }
                //catch { }

                //try { txt_SOLUONG.Text = int.Parse(_RowViewSelect[DonhangDFields.Soluongconlai.Name].ToString()).ToString("#.00", new System.Globalization.CultureInfo("vi-VN")); }
                //catch { }
                try { txt_DONGIA.Text = double.Parse(_RowViewSelect[DonhangDFields.Dongia.Name].ToString()).ToString("#.00", new System.Globalization.CultureInfo("vi-VN")); }
                catch { }
            }
        }
        private DataRow checkMadonhang(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DonhangDFields.Madon.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_BIENKIEMSOAT_Validating(object sender, CancelEventArgs e)
        {
            //_RowViewSelect = null;
            //txt_LAIXEHOTEN.Text = txt_LAIXEGHICHU.Text = string.Empty;
            //if (string.IsNullOrEmpty(txt_BIENKIEMSOAT.Text.Trim()) || DT_DMXE == null || DT_DMXE.Rows.Count == 0) return;
            //string _str_MACANTIM = txt_BIENKIEMSOAT.Text.Trim().ToUpper();
            //_RowViewSelect = checkmaBienkiemsoat(_str_MACANTIM, DT_DMXE);
            //if (_RowViewSelect == null)
            //{
            //    ListviewJanus _frm_SingerRows_Select =
            //        new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMXE.xml",
            //            DT_DMXE, DanhmucxeFields.Bienkiemsoat.Name, _str_MACANTIM);
            //    _frm_SingerRows_Select.ShowDialog();
            //    if (_frm_SingerRows_Select._RowViewSelect == null) return;
            //    _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
            //    txt_BIENKIEMSOAT.Text = _RowViewSelect[DanhmucxeFields.Bienkiemsoat.Name].ToString();
            //    txt_LAIXEHOTEN.Text = _RowViewSelect[DanhmucxeFields.Laixehoten.Name].ToString();
            //    txt_LAIXEGHICHU.Text = _RowViewSelect[DanhmucxeFields.Laixeghichu.Name].ToString();
            //}
            //else
            //{
            //    txt_LAIXEHOTEN.Text = _RowViewSelect[DanhmucxeFields.Laixehoten.Name].ToString();
            //    txt_LAIXEGHICHU.Text = _RowViewSelect[DanhmucxeFields.Laixeghichu.Name].ToString();
            //}
        }
        //private DataRow checkmaBienkiemsoat(string macantim, DataTable dt)
        //{
        //    try
        //    {
        //        return dt.Select(DanhmucxeFields.Bienkiemsoat.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
        //    }
        //    catch { return null; }
        //}
        #endregion

        #region Shortcut Key

        private void txt_MAKHACH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMKHACH frm_Dm = new FRM_DMKHACH();
                frm_Dm.Text = "Danh mục khách hàng";
                frm_Dm.ShowDialog();
                DT_DMKHACH = new DmkhachManager().SelectAllRDT();
            }
        }

        private void txt_MAHANG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMHANG frm_Dm = new FRM_DMHANG();
                frm_Dm.Text = "Danh mục hàng hoá";
                frm_Dm.ShowDialog();
                DT_DMHANGHOA = new DmhangManager().SelectAllRDT();
            }
        }
       
        private void txt_MADONHANG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DONHANG frm_Dm = new FRM_DONHANG();
                frm_Dm.Text = "Danh mục đơn hàng";
                frm_Dm.ShowDialog();
                DT_DONHANG_H = new DonhangHManager().SelectAllRDT();
            }
        }
        private void txt_BIENKIEMSOAT_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.F4)
            //{
            //    FRM_DMXE frm_Dm = new FRM_DMXE();
            //    frm_Dm.Text = "Danh mục xe";
            //    frm_Dm.ShowDialog();
            //    DT_DMXE = new DanhmucxeManager().SelectAllRDT();
            //}
        }
        #endregion
        private void FRM_PHIEUGIAOHANG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void FRM_PHIEUGIAOHANG_FormClosing(object sender, FormClosingEventArgs e)
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
