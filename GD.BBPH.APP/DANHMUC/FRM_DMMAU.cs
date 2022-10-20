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
using Microsoft.Office.Core;

namespace GD.BBPH.APP.DANHMUC
{
    public partial class FRM_DMMAU : FRM_DMPARENT
    {
        private DmmauManager _DmmauManager = new DmmauManager();
        private DmmauEntity _DmmauEntity = new DmmauEntity();
        private ThanhphanmauManager _ThanhphanmauManager = new ThanhphanmauManager();
        private ThanhphanmauEntity _ThanhphanmauEntity = new ThanhphanmauEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMMAU = new DataTable(), DT_TPMAU = new DataTable(), DT_TPMAU_FILL = new DataTable();
        private BindingSource BS_DMMAU = new BindingSource(), BS_TPMAU = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null, _RowDanhmuchanghoa = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DMMAU = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_TPMAU = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";

        private DataTable DT_DMSOI = new DataTable(), DT_DMNGUYENLIEU = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMMAU");
                        DT_DMMAU = LIB.SESSION_START.DT_DMMAU;
                        DT_TPMAU = LIB.SESSION_START.DT_TPMAU;
                        DT_TPMAU_FILL = DT_TPMAU.Clone();
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

        public FRM_DMMAU()
        {
            InitializeComponent();
            DmmauManager _DmmauManager = new DmmauManager();
            DataTable dt111 = _DmmauManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMAU.xml");
            ThanhphanmauManager _ThanhphanmauManager = new ThanhphanmauManager();
            dt111 = _ThanhphanmauManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_TPMAU.xml");

            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMAU.xml", GRID_DMMAU, uiPanel0Container);
            //GRID_DMMAU.RootTable.Groups.Add(GRID_DMMAU.Tables[0].Columns[DmmauFields.Mactpt.Name]);
            //GRID_DMMAU.RootTable.SortKeys.Add(DmmauFields.Ngayapdung.Name, Janus.Windows.GridEX.SortOrder.Descending);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_TPMAU.xml", GRID_TPMAU, pne_CHITIET);
            GRID_TPMAU.FilterMode = FilterMode.None;
            GRID_TPMAU.GroupByBoxVisible = false;
            FORM_PROCESS();
            //GRID_TPMAU.COMBO_MULTICOLUMN(GRID_TPMAU,ThanhphanmauFields.Tennguyenlieu.Name, DmnguyenlieuFields.Manl.Name, DmnguyenlieuFields.Tenrutgon.Name, DmnguyenlieuFields.Tenrutgon.Name, DT_DMNGUYENLIEU);
            GRID_TPMAU.CellEdited += GRID_TPMAU_CellEdited;
            GRID_TPMAU.DeletingRecord += GRID_TPMAU_DeletingRecord;
            //GRID_TPMAU.RootTable.Columns[ThanhphanmauFields.Tyle.Name].EditType = EditType.NoEdit;
            DataView Source_View = new DataView(DT_DMMAU);
            BS_DMMAU = new BindingSource();
            BS_DMMAU.DataSource = Source_View;
            GRID_DMMAU.DataSource = BS_DMMAU;
            BS_DMMAU.CurrentChanged += new EventHandler(BS_DMMAU_CurrentChanged);
            BS_DMMAU_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        #region Xử lý Grid Detail
        private void GRID_TPMAU_CellEdited(object sender, ColumnActionEventArgs e)
        {
            if (e.Column.DataMember == ThanhphanmauFields.Mausudung.Name)
            {
                string tenmau = GRID_TPMAU.CurrentRow.Cells[ThanhphanmauFields.Tenmausudung.Name].Value.ToString();
                DataTable dt = new DmmauManager().SelectByTenmauRDT(tenmau);
                GRID_TPMAU.CurrentRow.Cells[ThanhphanmauFields.Mausudung.Name].Value = dt.Rows[0][DmmauFields.Mamau.Name].ToString();
            }
        }
        private void GRID_TPMAU_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {           
            btn_XOADONG_Click(new object(), new EventArgs());
        }

        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            DataTable DT_DMMAU_GOC = new DataTable();
            DT_DMMAU_GOC = new DmmauManager().SelectByLamaugocRDT(true);
            ListviewJanusC _frm_MultiRows_Select =
                new ListviewJanusC(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMAU_CHON.xml", DT_DMMAU_GOC, DmmauFields.Mamau.Name, string.Empty);
            _frm_MultiRows_Select.ShowDialog();
            if (_frm_MultiRows_Select._RowsViewSelect == null) return;

            foreach (DataRowView drv in _frm_MultiRows_Select._RowsViewSelect)
            {
                DataRow r_Detail = DT_TPMAU_FILL.NewRow();
                r_Detail[ThanhphanmauFields.Mausudung.Name] = drv.Row[DmmauFields.Mamau.Name].ToString();
                r_Detail[ThanhphanmauFields.Tenmausudung.Name] = drv.Row[DmmauFields.Tenmau.Name].ToString();

                DT_TPMAU_FILL.Rows.Add(r_Detail);
            }

            DataView Source_View = new DataView(DT_TPMAU_FILL);
            BS_TPMAU = new BindingSource();
            BS_TPMAU.DataSource = Source_View;
            GRID_TPMAU.DataSource = BS_TPMAU;
            BS_TPMAU.Position = DT_TPMAU_FILL.Rows.Count;
        }

        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_TPMAU.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[ThanhphanmauFields.Id.Name].ToString();
            string _MAUSUDUNG = _view[ThanhphanmauFields.Mausudung.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK)) return;
            ThanhphanmauManager _ThanhphanmauManager = new ThanhphanmauManager();
            ThanhphanmauEntity _ThanhphanmauEntity = new ThanhphanmauEntity();
            try { _ThanhphanmauEntity = _ThanhphanmauManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
            catch { }
            if (_ThanhphanmauEntity != null && MessageBox.Show("Xóa dòng: " + _MAUSUDUNG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _ThanhphanmauManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                    DataRow[] drArr = DT_TPMAU.Select(ThanhphanmauFields.Id.Name + "='" + _MAHIEU_PK + "'");
                    DT_TPMAU.Rows.Remove(drArr[0]);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa dòng " + _MAUSUDUNG + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                BS_TPMAU.ResetCurrentItem();
                GRID_TPMAU.DataSource = BS_TPMAU;
            }
            GRID_TPMAU.Enabled = true;
        }
        #endregion

        void BS_DMMAU_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GRID_DMMAU.UpdateData();
                if (BS_DMMAU.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMMAU.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DmmauFields.Mamau.Name].ToString();

                    txt_MAMAU.Text = _Rowview.Row[DmmauFields.Mamau.Name].ToString();
                    txt_TENMAU.Text = _Rowview.Row[DmmauFields.Tenmau.Name].ToString();
                    txt_MAARGB.BackColor = Color.FromArgb(Convert.ToInt32(_Rowview.Row[DmmauFields.MaArgb.Name].ToString()));
                    try { chk_LAMAUGOC.Checked = Convert.ToBoolean(_Rowview.Row[DmmauFields.Lamaugoc.Name].ToString()); }
                    catch { }


                    SHOWGRID(MAHIEU_PK);
                }
                else 
                {
                    SHOWGRID("");
                    GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container)); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu nhập vào chưa đúng, xin mời nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void BS_TPMAU_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_TPMAU.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_TPMAU.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[ThanhphanmauFields.Id.Name].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập vào chưa đúng, xin mời nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SHOWGRID(string MAHIEU_PK)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK))
            {
                DT_TPMAU = new ThanhphanmauManager().Clone();
                BS_TPMAU = new BindingSource(DT_TPMAU, null);
                GRID_TPMAU.DataSource = BS_TPMAU;
            }
            else
            {
                DT_TPMAU = new ThanhphanmauManager().SelectByMamauRDT(MAHIEU_PK);
                DataView Source_View = new DataView(DT_TPMAU);
                BS_TPMAU = new BindingSource();
                BS_TPMAU.DataSource = Source_View;
                GRID_TPMAU.DataSource = BS_TPMAU;
            }
            BS_TPMAU.CurrentChanged += new EventHandler(BS_TPMAU_CurrentChanged);
            BS_TPMAU_CurrentChanged((new object()), (new EventArgs()));
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            DmmauEntity _dmmauEntity = new DmmauEntity();

            _dmmauEntity.Mamau = txt_MAMAU.Text.Trim();
            _dmmauEntity.Tenmau = txt_TENMAU.Text.Trim();
            _dmmauEntity.MaArgb = txt_MAARGB.BackColor.ToArgb();
            if (chk_LAMAUGOC.Checked)
                _dmmauEntity.Lamaugoc = true;
            else
                _dmmauEntity.Lamaugoc = false;

            EntityCollection _ThanhphanmauEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_TPMAU.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                ThanhphanmauEntity _thanhphanmauEntity = new ThanhphanmauEntity();

                _thanhphanmauEntity.Mamau = txt_MAMAU.Text.Trim();
                _thanhphanmauEntity.Tenmau = txt_TENMAU.Text.Trim();
                _thanhphanmauEntity.Mausudung = _view[ThanhphanmauFields.Mausudung.Name].ToString();
                _thanhphanmauEntity.Tenmausudung = _view[ThanhphanmauFields.Tenmausudung.Name].ToString();
                try { _thanhphanmauEntity.Tyle = Convert.ToDecimal(_view[ThanhphanmauFields.Tyle.Name].ToString()); }
                catch { }
                try { _thanhphanmauEntity.Id = Convert.ToInt64(_view[ThanhphanmauFields.Id.Name].ToString()); }
                catch { }

                _thanhphanmauEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_thanhphanmauEntity.IsNew)
                {
                    EntityCollection drDHCT = (new ThanhphanmauManager()).SelectById(_thanhphanmauEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _thanhphanmauEntity.Ngaysua = DateTime.Now;
                        _thanhphanmauEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _thanhphanmauEntity.IsNew = false;
                    }
                    else
                    {
                        _thanhphanmauEntity.Ngaytao = DateTime.Now;
                        _thanhphanmauEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }

                _ThanhphanmauEntityCol.Add(_thanhphanmauEntity);
            }

            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _dmmauEntity.Ngaytao = DateTime.Now;
                _dmmauEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_DMCHUONG_PK = _DmmauManager.InsertV2(_dmmauEntity, r_Insert, DT_DMMAU, BS_DMMAU);

                //---Xử lý trường hợp khi thêm mới màu gốc, thì thành phần màu tự bổ sung với tỷ lệ 100%
                if(_dmmauEntity.Lamaugoc==true)
                {
                    ThanhphanmauEntity _thanhphanmauEntity = new ThanhphanmauEntity();
                    _thanhphanmauEntity.Mamau = txt_MAMAU.Text.Trim();
                    _thanhphanmauEntity.Tenmau = txt_TENMAU.Text.Trim();
                    _thanhphanmauEntity.Mausudung = txt_MAMAU.Text.Trim();
                    _thanhphanmauEntity.Tenmausudung = txt_TENMAU.Text.Trim();
                    _thanhphanmauEntity.Tyle = 100;
                    _ThanhphanmauEntityCol.Add(_thanhphanmauEntity);
                }
                _ThanhphanmauManager.InsertCollection(_ThanhphanmauEntityCol);

                GRID_TPMAU.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TPMAU.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TPMAU.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmauManager.Convert(_DmmauEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                BS_DMMAU.ResetCurrentItem();
                BS_DMMAU_CurrentChanged(new object(), new EventArgs());
                BS_DMMAU.Position = DT_DMMAU.Rows.Count - 1;
            }
            else
            {
                _dmmauEntity.Ngaysua = DateTime.Now;
                _dmmauEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DmmauManager.Update(_dmmauEntity);

                //foreach (ThanhphanmauEntity _thanhphanmauEntity in _ThanhphanmauEntityCol)
                //    _thanhphanmauEntity.Mamau = _dmmauEntity.Mamau;
                foreach (ThanhphanmauEntity _thanhphanmauEntity in _ThanhphanmauEntityCol)
                {
                    if (_thanhphanmauEntity.IsNew)
                    {
                        DataRow _r_Insert = DT_TPMAU.NewRow();
                        DT_TPMAU.Rows.Add(_r_Insert);
                        _ThanhphanmauManager.InsertV2(_thanhphanmauEntity, _r_Insert, DT_TPMAU, BS_TPMAU);
                    }
                    else _ThanhphanmauManager.Update(_thanhphanmauEntity);
                }

                GRID_DMMAU.CurrentRow.Cells[DmmauFields.Mamau.Name].Value = _dmmauEntity.Mamau;
                GRID_DMMAU.CurrentRow.Cells[DmmauFields.Tenmau.Name].Value = _dmmauEntity.Tenmau;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmauManager.Convert(_DmmauEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GRID_TPMAU.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TPMAU.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TPMAU.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                BS_DMMAU.ResetCurrentItem();
                BS_DMMAU_CurrentChanged(new object(), new EventArgs());
            }

            return _str_DMCHUONG_PK;      
        }

        private void btn_CHONMAU_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                txt_MAARGB.BackColor = colorDlg.Color; // lấy color ở dòng này   
            }
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            string _Maydet = txt_MAMAU.Text.Trim();
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_TENMAU.Text = string.Empty;
            ThanhphanmauManager _ThanhphanmauManager = new ThanhphanmauManager();
            ThanhphanmauEntity _ThanhphanmauEntity = new ThanhphanmauEntity();
            r_Insert = DT_DMMAU.NewRow();
            DT_DMMAU.Rows.Add(r_Insert);
            BS_DMMAU.Position = DT_DMMAU.Rows.Count;
            GRID_TPMAU.Enabled = true;
            GRID_TPMAU.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TPMAU.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TPMAU.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TPMAU.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            MAHIEU_PK = "";
            txt_MAMAU.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMMAU.Enabled = false;
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            btn_SAOCHEP.Enabled = false;
        }

        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] {  }));
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            }
            GRID_TPMAU.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_TPMAU.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TPMAU.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TPMAU.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TPMAU.Enabled = true;
            GRID_DMMAU.Enabled = false;
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            btn_SAOCHEP.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMMAU.Rows.Remove(r_Insert);
            }
            BS_DMMAU_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_TPMAU.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_TPMAU.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_TPMAU.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_DMMAU.Enabled = true;
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            btn_SAOCHEP.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            ThanhphanmauManager _ThanhphanmauManager = new ThanhphanmauManager();
            ThanhphanmauEntity _ThanhphanmauEntity = new ThanhphanmauEntity();
            _DmmauEntity = _DmmauManager.SelectOne(MAHIEU_PK);
            if (_DmmauEntity != null && MessageBox.Show("Xóa màu: " + txt_TENMAU.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    GridEXRow[] listGrid = GRID_TPMAU.GetDataRows();
                    foreach (GridEXRow _grid in listGrid)
                    {
                        DataRowView _view = (DataRowView)_grid.DataRow;
                        if (_view == null) continue;
                        if (!string.IsNullOrEmpty(_view[ThanhphanmauFields.Id.Name].ToString()))
                        {
                            try { _ThanhphanmauManager.Delete(Convert.ToInt64(_view[ThanhphanmauFields.Id.Name].ToString())); }
                            catch { }
                        }
                    }
                    _DmmauManager.Delete(MAHIEU_PK);
                    try { GRID_DMMAU.CurrentRow.Delete(); }
                    catch { }
                    BS_DMMAU_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_ThanhphanmauManager.Convert(_ThanhphanmauEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa màu: " + txt_TENMAU.Text + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_TPMAU.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_TPMAU.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_TPMAU.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_DMMAU.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (txt_MAMAU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã màu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAMAU.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(MAHIEU_PK) && _DmmauManager.SelectByMamauRDT(txt_MAMAU.Text).Rows.Count > 0)
            {
                MessageBox.Show("Mã màu bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAMAU.Focus();
                return;
            }
            else if (txt_TENMAU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên màu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENMAU.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMMAU.Enabled = true;
                //BS_DMMAU.MoveLast();
                btn_THEMMOI.Focus();
                GRID_TPMAU.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TPMAU.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TPMAU.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                btn_SAOCHEP.Enabled = true;
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_SAOCHEP_Click(object sender, EventArgs e)
        {
            try
            {
                BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                ThanhphanmauManager _ThanhphanmauManager = new ThanhphanmauManager();
                ThanhphanmauEntity _ThanhphanmauEntity = new ThanhphanmauEntity();
                r_Insert = DT_DMMAU.NewRow();
                DT_DMMAU.Rows.Add(r_Insert);
                DataTable dt = new ThanhphanmauManager().SelectByMamauRDT(MAHIEU_PK);
                DataRow[] drCopy = DT_DMMAU.Select(DmmauFields.Mamau.Name + "= '" + MAHIEU_PK + "'");
                BS_DMMAU.Position = DT_DMMAU.Rows.Count;
                GRID_TPMAU.Enabled = true;
                GRID_TPMAU.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_TPMAU.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_TPMAU.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_TPMAU.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;

                txt_MAMAU.Text = drCopy[0][DmmauFields.Mamau.Name].ToString();
                txt_TENMAU.Text = drCopy[0][DmmauFields.Tenmau.Name].ToString();

                foreach (DataRow dr in dt.Rows)
                {
                    DataRow r_Detail = DT_TPMAU.NewRow();
                    r_Detail[ThanhphanmauFields.Mamau.Name] = dr[ThanhphanmauFields.Mamau.Name];
                    r_Detail[ThanhphanmauFields.Tenmau.Name] = dr[ThanhphanmauFields.Tenmau.Name];
                    r_Detail[ThanhphanmauFields.Mausudung.Name] = dr[ThanhphanmauFields.Mausudung.Name];
                    r_Detail[ThanhphanmauFields.Tyle.Name] = dr[ThanhphanmauFields.Tyle.Name];
                    DT_TPMAU.Rows.Add(r_Detail);
                }

                MAHIEU_PK = "";
                txt_MAMAU.Focus();
                BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                BBPH.BLL.MenuroleManager.set_Enable_controls(BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GRID_DMMAU.Enabled = false;
            }
            catch { }
            btn_SAOCHEP.Enabled = false;
        }
        #endregion

        private void FRM_DMMAU_FormClosing(object sender, FormClosingEventArgs e)
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
