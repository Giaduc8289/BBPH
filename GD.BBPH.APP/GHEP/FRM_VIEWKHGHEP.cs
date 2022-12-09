using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace GD.BBPH.APP.GHEP
{
    public partial class FRM_VIEWKHGHEP : FRM_DMPARENT
    {
        private KehoachghepManager _KehoachghepManager = new KehoachghepManager();
        private KehoachghepEntity _KehoachghepEntity = new KehoachghepEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_KEHOACH = new DataTable();
        private BindingSource BS_KEHOACH = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_KEHOACH = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";

        DataTable DT_LENHSANXUAT = new DataTable();

        private DateTime NGAY = new DateTime();
        private int CA = 0;
        private string MAY = "";

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
                        DT_KEHOACH = LIB.Procedures.Kehoachgheptheocamay(NGAY, CA, MAY);// _KehoachghepManager.SelectByCaMay(NGAY, CA, MAY);

                        DT_LENHSANXUAT = new LenhsanxuatManager().SelectAllRDT();// LIB.SESSION_START.DT_LENHSANXUAT;
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
        public FRM_VIEWKHGHEP(DateTime _Ngay, int _Ca, string _May)
        {
            NGAY = _Ngay; CA = _Ca; MAY = _May;
            InitializeComponent();
            this.Text = ("Kế hoạch ghép ca " + CA + " ngày " + NGAY.ToString("dd/MM") + " máy " + MAY).ToUpper();
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KHGHEP_EDIT.xml", GRID_KEHOACH, panel1);
            GRID_KEHOACH.FilterMode = FilterMode.None;
            GRID_KEHOACH.GroupByBoxVisible = false;
            GRID_KEHOACH.RootTable.Columns[LenhsanxuatFields.Tenkhach.Name].EditType = EditType.NoEdit;
            GRID_KEHOACH.RootTable.Columns[KehoachghepFields.Masanpham.Name].EditType = EditType.NoEdit;
            GRID_KEHOACH.RootTable.Columns[KehoachghepFields.Ngaydat.Name].EditType = EditType.NoEdit;
            GRID_KEHOACH.RootTable.Columns[KehoachghepFields.Ngaygiao.Name].EditType = EditType.NoEdit;
            GRID_KEHOACH.RootTable.Columns[LenhsanxuatFields.Madon.Name].EditType = EditType.NoEdit; 
            GRID_KEHOACH.KeyDown += GRID_KEHOACH_KeyDown;
            FORM_PROCESS();
            RELOAD();
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        private void RELOAD()
        {
            DataView Source_View = new DataView(DT_KEHOACH);
            BS_KEHOACH = new BindingSource();
            BS_KEHOACH.DataSource = Source_View;
            GRID_KEHOACH.DataSource = BS_KEHOACH;
            BS_KEHOACH.CurrentChanged += new EventHandler(BS_KEHOACH_CurrentChanged);
            BS_KEHOACH_CurrentChanged((new object()), (new EventArgs()));
        }

        void BS_KEHOACH_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(panel1, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(panel1));
                if (BS_KEHOACH.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_KEHOACH.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[KehoachghepFields.Id.Name].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KEHOACH_CurrentChanged"); }
        }

        #region Button Click
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            KehoachghepManager _KehoachghepManager = new KehoachghepManager();
            KehoachghepEntity _KehoachghepEntity = new KehoachghepEntity();
            r_Insert = DT_KEHOACH.NewRow();
            DT_KEHOACH.Rows.Add(r_Insert);
            BS_KEHOACH.Position = DT_KEHOACH.Rows.Count;
            MAHIEU_PK = "";
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_KEHOACH.Enabled = true;
            GRID_KEHOACH.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
        }
        private string Save_Data(string _str_KEHOACH_PK)
        {
            EntityCollection _KehoachghepEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_KEHOACH.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                KehoachghepEntity _KehoachghepEntity = new KehoachghepEntity();
                try { _KehoachghepEntity.Id = Convert.ToInt64(_view[KehoachghepFields.Id.Name].ToString()); }
                catch { }
                _KehoachghepEntity.Solenhsx = _view[KehoachghepFields.Solenhsx.Name].ToString(); 
                //_KehoachghepEntity.Madondathang= _view[KehoachghepFields.Madondathang.Name].ToString();
                _KehoachghepEntity.Masanpham = _view[KehoachghepFields.Masanpham.Name].ToString();
                //_KehoachghepEntity.Makhachhang = _view[KehoachghepFields.Makhachhang.Name].ToString();
                //_KehoachghepEntity.Tenkhachhang = _view[KehoachghepFields.Tenkhachhang.Name].ToString();
                try { _KehoachghepEntity.Ngaydat = Convert.ToDateTime(_view[KehoachghepFields.Ngaydat.Name].ToString()); }
                catch { }
                try { _KehoachghepEntity.Ngaygiao = Convert.ToDateTime(_view[KehoachghepFields.Ngaygiao.Name].ToString()); }
                catch { }
                try { _KehoachghepEntity.Sldukien = Convert.ToInt32(_view[KehoachghepFields.Sldukien.Name].ToString()); }
                catch { }
                _KehoachghepEntity.Mamay = MAY;
                _KehoachghepEntity.Ngaychay = NGAY;
                _KehoachghepEntity.Ca = CA;

                _KehoachghepEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_KehoachghepEntity.IsNew)
                {
                    EntityCollection drKH = (new KehoachghepManager()).SelectById(_KehoachghepEntity.Id);
                    if (drKH.Count > 0) _KehoachghepEntity.IsNew = false;
                }

                _KehoachghepEntityCol.Add(_KehoachghepEntity);
            }
            if (string.IsNullOrEmpty(_str_KEHOACH_PK))
            {
                _str_KEHOACH_PK = _KehoachghepManager.InsertV2(_KehoachghepEntity, r_Insert, DT_KEHOACH, BS_KEHOACH);
                _KehoachghepManager.InsertCollection(_KehoachghepEntityCol);

                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KehoachghepManager.Convert(_KehoachghepEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_KEHOACH.ResetCurrentItem();
                BS_KEHOACH_CurrentChanged(new object(), new EventArgs());
            }
            else
            {
                foreach (KehoachghepEntity _KehoachghepEntity in _KehoachghepEntityCol)
                {
                    if (_KehoachghepEntity.IsNew)
                    {
                        DataRow _r_Insert = DT_KEHOACH.NewRow();
                        DT_KEHOACH.Rows.Add(_r_Insert);
                        _KehoachghepManager.InsertV2(_KehoachghepEntity, _r_Insert, DT_KEHOACH, BS_KEHOACH);
                    }
                    else _KehoachghepManager.Update(_KehoachghepEntity);
                }

                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KehoachghepManager.Convert(_KehoachghepEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_KEHOACH.ResetCurrentItem();
                BS_KEHOACH_CurrentChanged(new object(), new EventArgs());
            }
            return _str_KEHOACH_PK;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            GRID_KEHOACH.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            DT_KEHOACH = LIB.Procedures.Kehoachgheptheocamay(NGAY, CA, MAY);
            RELOAD();
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_KEHOACH.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, panel1, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            KehoachghepManager _KehoachghepManager = new KehoachghepManager();
            KehoachghepEntity _KehoachghepEntity = new KehoachghepEntity();
            _KehoachghepEntity = _KehoachghepManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_KehoachghepEntity != null && MessageBox.Show("Xóa kế hoạch hoàn thiện mẫu: " + _KehoachghepEntity.Masanpham, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _KehoachghepManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    GRID_KEHOACH.CurrentRow.Delete();
                    BS_KEHOACH_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KehoachghepManager.Convert(_KehoachghepEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa kế hoạch hoàn thiện mẫu " + _KehoachghepEntity.Masanpham + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_KEHOACH.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, panel1, null);
            MAHIEU_PK = Save_Data(MAHIEU_PK);
            DT_KEHOACH = LIB.Procedures.Kehoachgheptheocamay(NGAY, CA, MAY);
            RELOAD();
            GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
            GRID_KEHOACH.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            btn_THEMMOI.Focus();
        }
        #endregion
        
        #region Validate
        private void GRID_KEHOACH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                if (GRID_KEHOACH.AllowEdit == Janus.Windows.GridEX.InheritableBoolean.False) return;

                //DataRowView _Rowview = (DataRowView)this.BS_KEHOACH.Current;
                //string strFind = _Rowview.Row[DonhangDFields.Masp.Name].ToString();
                //_RowViewSelect = null;
                //if (DT_LENHSANXUAT == null || DT_LENHSANXUAT.Rows.Count == 0) return;
                //_RowViewSelect = checkDondathang(strFind, DT_LENHSANXUAT);
                //if (_RowViewSelect == null)
                //{
                //    ListviewJanus _frm_SingerRows_Select =
                //        new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DONDATHANGCHITIET.xml",
                //            DT_LENHSANXUAT, DondathangchitietFields.Madonhang.Name, strFind);
                //    _frm_SingerRows_Select.ShowDialog();
                //    if (_frm_SingerRows_Select._RowViewSelect == null) return;
                //    _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                //    GRID_KEHOACH.CurrentRow.Cells[KehoachghepFields.Madonhangct.Name].Value = _RowViewSelect[DondathangchitietFields.Id.Name].ToString();
                //    GRID_KEHOACH.CurrentRow.Cells[DondathangchitietFields.Madonhang.Name].Value = _RowViewSelect[DondathangchitietFields.Madonhang.Name].ToString();
                //    GRID_KEHOACH.CurrentRow.Cells[DondathangchitietFields.Mahang.Name].Value = _RowViewSelect[DondathangchitietFields.Mahang.Name].ToString();
                //    //GRID_KEHOACH.CurrentRow.Cells[KehoachghepFields.Makhachhang.Name].Value = _RowViewSelect[DondathangchitietFields.Makhachhang.Name].ToString();
                //    GRID_KEHOACH.CurrentRow.Cells[DondathangchitietFields.Tenkhachhang.Name].Value = _RowViewSelect[DondathangchitietFields.Tenkhachhang.Name].ToString();
                //    GRID_KEHOACH.CurrentRow.Cells[KehoachghepFields.Mauin.Name].Value = _RowViewSelect[DondathangchitietFields.Mauin.Name].ToString();
                //    GRID_KEHOACH.CurrentRow.Cells[KehoachghepFields.Ngaydat.Name].Value = _RowViewSelect[DondathangchitietFields.Ngaydat.Name].ToString();
                //    GRID_KEHOACH.CurrentRow.Cells[KehoachghepFields.Ngaygiao.Name].Value = _RowViewSelect[DondathangchitietFields.Ngaygiao.Name].ToString();
                //}
                //else
                //{
                //    GRID_KEHOACH.CurrentRow.Cells[KehoachghepFields.Madonhangct.Name].Value = _RowViewSelect[DondathangchitietFields.Id.Name].ToString();
                //    GRID_KEHOACH.CurrentRow.Cells[DondathangchitietFields.Madonhang.Name].Value = _RowViewSelect[DondathangchitietFields.Madonhang.Name].ToString();
                //    GRID_KEHOACH.CurrentRow.Cells[DondathangchitietFields.Mahang.Name].Value = _RowViewSelect[DondathangchitietFields.Mahang.Name].ToString();
                //    //GRID_KEHOACH.CurrentRow.Cells[KehoachghepFields.Makhachhang.Name].Value = _RowViewSelect[DondathangchitietFields.Makhachhang.Name].ToString();
                //    GRID_KEHOACH.CurrentRow.Cells[DondathangchitietFields.Tenkhachhang.Name].Value = _RowViewSelect[DondathangchitietFields.Tenkhachhang.Name].ToString();
                //    GRID_KEHOACH.CurrentRow.Cells[KehoachghepFields.Mauin.Name].Value = _RowViewSelect[DondathangchitietFields.Mauin.Name].ToString();
                //    GRID_KEHOACH.CurrentRow.Cells[KehoachghepFields.Ngaydat.Name].Value = _RowViewSelect[DondathangchitietFields.Ngaydat.Name].ToString();
                //    GRID_KEHOACH.CurrentRow.Cells[KehoachghepFields.Ngaygiao.Name].Value = _RowViewSelect[DondathangchitietFields.Ngaygiao.Name].ToString();
                //}
            }
        }
        private DataRow checkDondathang(string strFind, DataTable dt)
        {
            try
            {
                return dt.Select(DonhangDFields.Madon.Name + "=" + "'" + strFind + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FRM_KEHOACH_FormClosing(object sender, FormClosingEventArgs e)
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
