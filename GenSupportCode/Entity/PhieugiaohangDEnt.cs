
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.PhieugiaohangDEnt
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using GD.BBPH.BLL;
using GD.BBPH.DAL;
using GD.BBPH.DAL.EntityClasses;
using GD.BBPH.DAL.FactoryClasses;
using GD.BBPH.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.BBPH.DAL.EntityClasses
{
	public class PhieugiaohangDEnt : PhieugiaohangDEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhieugiaohangDEnt()
		{
			// Nothing for now.
		}

		void BS_PHIEUGIAOHANGD_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_PHIEUGIAOHANGD.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_PHIEUGIAOHANGD.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[PhieugiaohangDFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[PhieugiaohangDFields.Id.Name].ToString();
					txt_SOPHIEU.Text = _Rowview.Row[PhieugiaohangDFields.Sophieu.Name].ToString();
					txt_NGAYGIAO.Text = _Rowview.Row[PhieugiaohangDFields.Ngaygiao.Name].ToString();
					txt_MADON.Text = _Rowview.Row[PhieugiaohangDFields.Madon.Name].ToString();
					txt_DONCHITIETID.Text = _Rowview.Row[PhieugiaohangDFields.DonchitietId.Name].ToString();
					txt_NGAYDAT.Text = _Rowview.Row[PhieugiaohangDFields.Ngaydat.Name].ToString();
					txt_MAKHACH.Text = _Rowview.Row[PhieugiaohangDFields.Makhach.Name].ToString();
					txt_TENKHACH.Text = _Rowview.Row[PhieugiaohangDFields.Tenkhach.Name].ToString();
					txt_LOAIHANG.Text = _Rowview.Row[PhieugiaohangDFields.Loaihang.Name].ToString();
					txt_MASP.Text = _Rowview.Row[PhieugiaohangDFields.Masp.Name].ToString();
					txt_TENHANG.Text = _Rowview.Row[PhieugiaohangDFields.Tenhang.Name].ToString();
					txt_SOLUONG.Text = _Rowview.Row[PhieugiaohangDFields.Soluong.Name].ToString();
					txt_DONGIA.Text = _Rowview.Row[PhieugiaohangDFields.Dongia.Name].ToString();
					txt_THANHTIEN.Text = _Rowview.Row[PhieugiaohangDFields.Thanhtien.Name].ToString();
					txt_GHICHU.Text = _Rowview.Row[PhieugiaohangDFields.Ghichu.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[PhieugiaohangDFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[PhieugiaohangDFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[PhieugiaohangDFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[PhieugiaohangDFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_PHIEUGIAOHANGD_CurrentChanged"); }
		}

		private string Save_Data(string _str_PHIEUGIAOHANGD_PK)
		{
			PhieugiaohangDEntity _phieugiaohangDEntity = new PhieugiaohangDEntity();
			
			_phieugiaohangDEntity.Id = txt_ID.Text.Trim();
			_phieugiaohangDEntity.Sophieu = txt_SOPHIEU.Text.Trim();
			_phieugiaohangDEntity.Ngaygiao = txt_NGAYGIAO.Text.Trim();
			_phieugiaohangDEntity.Madon = txt_MADON.Text.Trim();
			_phieugiaohangDEntity.DonchitietId = txt_DONCHITIETID.Text.Trim();
			_phieugiaohangDEntity.Ngaydat = txt_NGAYDAT.Text.Trim();
			_phieugiaohangDEntity.Makhach = txt_MAKHACH.Text.Trim();
			_phieugiaohangDEntity.Tenkhach = txt_TENKHACH.Text.Trim();
			_phieugiaohangDEntity.Loaihang = txt_LOAIHANG.Text.Trim();
			_phieugiaohangDEntity.Masp = txt_MASP.Text.Trim();
			_phieugiaohangDEntity.Tenhang = txt_TENHANG.Text.Trim();
			_phieugiaohangDEntity.Soluong = txt_SOLUONG.Text.Trim();
			_phieugiaohangDEntity.Dongia = txt_DONGIA.Text.Trim();
			_phieugiaohangDEntity.Thanhtien = txt_THANHTIEN.Text.Trim();
			_phieugiaohangDEntity.Ghichu = txt_GHICHU.Text.Trim();
			_phieugiaohangDEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_phieugiaohangDEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_phieugiaohangDEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_phieugiaohangDEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_PHIEUGIAOHANGD_PK))
			{
				_str_PHIEUGIAOHANGD_PK = _PhieugiaohangDManager.InsertV2(_phieugiaohangDEntity, r_Insert, DT_PHIEUGIAOHANGD, BS_PHIEUGIAOHANGD);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangDManager.Convert(_phieugiaohangDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_PHIEUGIAOHANGD.ResetCurrentItem();
			}
			else
			{
				_PhieugiaohangDManager.Update(_phieugiaohangDEntity);
				
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.Id.Name].Value = _phieugiaohangDEntity.Id;
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.Sophieu.Name].Value = _phieugiaohangDEntity.Sophieu;
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.Ngaygiao.Name].Value = _phieugiaohangDEntity.Ngaygiao;
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.Madon.Name].Value = _phieugiaohangDEntity.Madon;
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.DonchitietId.Name].Value = _phieugiaohangDEntity.DonchitietId;
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.Ngaydat.Name].Value = _phieugiaohangDEntity.Ngaydat;
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.Makhach.Name].Value = _phieugiaohangDEntity.Makhach;
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.Tenkhach.Name].Value = _phieugiaohangDEntity.Tenkhach;
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.Loaihang.Name].Value = _phieugiaohangDEntity.Loaihang;
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.Masp.Name].Value = _phieugiaohangDEntity.Masp;
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.Tenhang.Name].Value = _phieugiaohangDEntity.Tenhang;
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.Soluong.Name].Value = _phieugiaohangDEntity.Soluong;
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.Dongia.Name].Value = _phieugiaohangDEntity.Dongia;
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.Thanhtien.Name].Value = _phieugiaohangDEntity.Thanhtien;
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.Ghichu.Name].Value = _phieugiaohangDEntity.Ghichu;
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.Ngaytao.Name].Value = _phieugiaohangDEntity.Ngaytao;
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.Nguoitao.Name].Value = _phieugiaohangDEntity.Nguoitao;
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.Ngaysua.Name].Value = _phieugiaohangDEntity.Ngaysua;
				GRID_PHIEUGIAOHANGD.CurrentRow.Cells[PhieugiaohangDFields.Nguoisua.Name].Value = _phieugiaohangDEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangDManager.Convert(_phieugiaohangDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_PHIEUGIAOHANGD_PK;
		}

	}
}
