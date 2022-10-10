
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

		void BS_PhieugiaohangD_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_PhieugiaohangD.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_PhieugiaohangD.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[PhieugiaohangDFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[PhieugiaohangDFields.Id.Name].ToString();
					txt_Sophieu.Text = _Rowview.Row[PhieugiaohangDFields.Sophieu.Name].ToString();
					txt_Ngaygiao.Text = _Rowview.Row[PhieugiaohangDFields.Ngaygiao.Name].ToString();
					txt_Madon.Text = _Rowview.Row[PhieugiaohangDFields.Madon.Name].ToString();
					txt_DonchitietId.Text = _Rowview.Row[PhieugiaohangDFields.DonchitietId.Name].ToString();
					txt_Ngaydat.Text = _Rowview.Row[PhieugiaohangDFields.Ngaydat.Name].ToString();
					txt_Makhach.Text = _Rowview.Row[PhieugiaohangDFields.Makhach.Name].ToString();
					txt_Tenkhach.Text = _Rowview.Row[PhieugiaohangDFields.Tenkhach.Name].ToString();
					txt_Loaihang.Text = _Rowview.Row[PhieugiaohangDFields.Loaihang.Name].ToString();
					txt_Masp.Text = _Rowview.Row[PhieugiaohangDFields.Masp.Name].ToString();
					txt_Tenhang.Text = _Rowview.Row[PhieugiaohangDFields.Tenhang.Name].ToString();
					txt_Soluong.Text = _Rowview.Row[PhieugiaohangDFields.Soluong.Name].ToString();
					txt_Dongia.Text = _Rowview.Row[PhieugiaohangDFields.Dongia.Name].ToString();
					txt_Thanhtien.Text = _Rowview.Row[PhieugiaohangDFields.Thanhtien.Name].ToString();
					txt_Ghichu.Text = _Rowview.Row[PhieugiaohangDFields.Ghichu.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[PhieugiaohangDFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[PhieugiaohangDFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[PhieugiaohangDFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[PhieugiaohangDFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_PhieugiaohangD_CurrentChanged"); }
		}

		private string Save_Data(string _str_PhieugiaohangD_PK)
		{
			PhieugiaohangDEntity _phieugiaohangDEntity = new PhieugiaohangDEntity();
			
			_phieugiaohangDEntity.Id = txt_Id.Text.Trim();
			_phieugiaohangDEntity.Sophieu = txt_Sophieu.Text.Trim();
			_phieugiaohangDEntity.Ngaygiao = txt_Ngaygiao.Text.Trim();
			_phieugiaohangDEntity.Madon = txt_Madon.Text.Trim();
			_phieugiaohangDEntity.DonchitietId = txt_DonchitietId.Text.Trim();
			_phieugiaohangDEntity.Ngaydat = txt_Ngaydat.Text.Trim();
			_phieugiaohangDEntity.Makhach = txt_Makhach.Text.Trim();
			_phieugiaohangDEntity.Tenkhach = txt_Tenkhach.Text.Trim();
			_phieugiaohangDEntity.Loaihang = txt_Loaihang.Text.Trim();
			_phieugiaohangDEntity.Masp = txt_Masp.Text.Trim();
			_phieugiaohangDEntity.Tenhang = txt_Tenhang.Text.Trim();
			_phieugiaohangDEntity.Soluong = txt_Soluong.Text.Trim();
			_phieugiaohangDEntity.Dongia = txt_Dongia.Text.Trim();
			_phieugiaohangDEntity.Thanhtien = txt_Thanhtien.Text.Trim();
			_phieugiaohangDEntity.Ghichu = txt_Ghichu.Text.Trim();
			_phieugiaohangDEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_phieugiaohangDEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_phieugiaohangDEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_phieugiaohangDEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_PhieugiaohangD_PK = _PhieugiaohangDManager.InsertV2(_PhieugiaohangDEntity, r_Insert, DT_PhieugiaohangD, BS_PhieugiaohangD);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangDManager.Convert(_phieugiaohangDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_PhieugiaohangD.ResetCurrentItem();
			}
			else
			{
				_PhieugiaohangDManager.Update(_phieugiaohangDEntity);
				
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.Id.Name].Value = _phieugiaohangDEntity.Id;
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.Sophieu.Name].Value = _phieugiaohangDEntity.Sophieu;
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.Ngaygiao.Name].Value = _phieugiaohangDEntity.Ngaygiao;
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.Madon.Name].Value = _phieugiaohangDEntity.Madon;
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.DonchitietId.Name].Value = _phieugiaohangDEntity.DonchitietId;
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.Ngaydat.Name].Value = _phieugiaohangDEntity.Ngaydat;
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.Makhach.Name].Value = _phieugiaohangDEntity.Makhach;
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.Tenkhach.Name].Value = _phieugiaohangDEntity.Tenkhach;
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.Loaihang.Name].Value = _phieugiaohangDEntity.Loaihang;
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.Masp.Name].Value = _phieugiaohangDEntity.Masp;
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.Tenhang.Name].Value = _phieugiaohangDEntity.Tenhang;
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.Soluong.Name].Value = _phieugiaohangDEntity.Soluong;
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.Dongia.Name].Value = _phieugiaohangDEntity.Dongia;
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.Thanhtien.Name].Value = _phieugiaohangDEntity.Thanhtien;
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.Ghichu.Name].Value = _phieugiaohangDEntity.Ghichu;
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.Ngaytao.Name].Value = _phieugiaohangDEntity.Ngaytao;
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.Nguoitao.Name].Value = _phieugiaohangDEntity.Nguoitao;
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.Ngaysua.Name].Value = _phieugiaohangDEntity.Ngaysua;
				GRID_PhieugiaohangD.CurrentRow.Cells[PhieugiaohangDFields.Nguoisua.Name].Value = _phieugiaohangDEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangDManager.Convert(_phieugiaohangDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_PhieugiaohangD_PK;
		}

	}
}
