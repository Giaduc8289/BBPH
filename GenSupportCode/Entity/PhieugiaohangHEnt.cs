
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.PhieugiaohangHEnt
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
	public class PhieugiaohangHEnt : PhieugiaohangHEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhieugiaohangHEnt()
		{
			// Nothing for now.
		}

		void BS_PHIEUGIAOHANGH_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_PHIEUGIAOHANGH.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_PHIEUGIAOHANGH.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[PhieugiaohangHFields.Sophieu.Name].ToString();
					
					txt_SOPHIEU.Text = _Rowview.Row[PhieugiaohangHFields.Sophieu.Name].ToString();
					txt_NGAYGIAO.Text = _Rowview.Row[PhieugiaohangHFields.Ngaygiao.Name].ToString();
					txt_MADON.Text = _Rowview.Row[PhieugiaohangHFields.Madon.Name].ToString();
					txt_NGAYDAT.Text = _Rowview.Row[PhieugiaohangHFields.Ngaydat.Name].ToString();
					txt_MAKHACH.Text = _Rowview.Row[PhieugiaohangHFields.Makhach.Name].ToString();
					txt_TENKHACH.Text = _Rowview.Row[PhieugiaohangHFields.Tenkhach.Name].ToString();
					txt_TONGTIEN.Text = _Rowview.Row[PhieugiaohangHFields.Tongtien.Name].ToString();
					txt_VAT.Text = _Rowview.Row[PhieugiaohangHFields.Vat.Name].ToString();
					txt_GHICHU.Text = _Rowview.Row[PhieugiaohangHFields.Ghichu.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[PhieugiaohangHFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[PhieugiaohangHFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[PhieugiaohangHFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[PhieugiaohangHFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_PHIEUGIAOHANGH_CurrentChanged"); }
		}

		private string Save_Data(string _str_PHIEUGIAOHANGH_PK)
		{
			PhieugiaohangHEntity _phieugiaohangHEntity = new PhieugiaohangHEntity();
			
			_phieugiaohangHEntity.Sophieu = txt_SOPHIEU.Text.Trim();
			_phieugiaohangHEntity.Ngaygiao = txt_NGAYGIAO.Text.Trim();
			_phieugiaohangHEntity.Madon = txt_MADON.Text.Trim();
			_phieugiaohangHEntity.Ngaydat = txt_NGAYDAT.Text.Trim();
			_phieugiaohangHEntity.Makhach = txt_MAKHACH.Text.Trim();
			_phieugiaohangHEntity.Tenkhach = txt_TENKHACH.Text.Trim();
			_phieugiaohangHEntity.Tongtien = txt_TONGTIEN.Text.Trim();
			_phieugiaohangHEntity.Vat = txt_VAT.Text.Trim();
			_phieugiaohangHEntity.Ghichu = txt_GHICHU.Text.Trim();
			_phieugiaohangHEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_phieugiaohangHEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_phieugiaohangHEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_phieugiaohangHEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_PHIEUGIAOHANGH_PK))
			{
				_str_PHIEUGIAOHANGH_PK = _PhieugiaohangHManager.InsertV2(_phieugiaohangHEntity, r_Insert, DT_PHIEUGIAOHANGH, BS_PHIEUGIAOHANGH);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangHManager.Convert(_phieugiaohangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_PHIEUGIAOHANGH.ResetCurrentItem();
			}
			else
			{
				_PhieugiaohangHManager.Update(_phieugiaohangHEntity);
				
				GRID_PHIEUGIAOHANGH.CurrentRow.Cells[PhieugiaohangHFields.Sophieu.Name].Value = _phieugiaohangHEntity.Sophieu;
				GRID_PHIEUGIAOHANGH.CurrentRow.Cells[PhieugiaohangHFields.Ngaygiao.Name].Value = _phieugiaohangHEntity.Ngaygiao;
				GRID_PHIEUGIAOHANGH.CurrentRow.Cells[PhieugiaohangHFields.Madon.Name].Value = _phieugiaohangHEntity.Madon;
				GRID_PHIEUGIAOHANGH.CurrentRow.Cells[PhieugiaohangHFields.Ngaydat.Name].Value = _phieugiaohangHEntity.Ngaydat;
				GRID_PHIEUGIAOHANGH.CurrentRow.Cells[PhieugiaohangHFields.Makhach.Name].Value = _phieugiaohangHEntity.Makhach;
				GRID_PHIEUGIAOHANGH.CurrentRow.Cells[PhieugiaohangHFields.Tenkhach.Name].Value = _phieugiaohangHEntity.Tenkhach;
				GRID_PHIEUGIAOHANGH.CurrentRow.Cells[PhieugiaohangHFields.Tongtien.Name].Value = _phieugiaohangHEntity.Tongtien;
				GRID_PHIEUGIAOHANGH.CurrentRow.Cells[PhieugiaohangHFields.Vat.Name].Value = _phieugiaohangHEntity.Vat;
				GRID_PHIEUGIAOHANGH.CurrentRow.Cells[PhieugiaohangHFields.Ghichu.Name].Value = _phieugiaohangHEntity.Ghichu;
				GRID_PHIEUGIAOHANGH.CurrentRow.Cells[PhieugiaohangHFields.Ngaytao.Name].Value = _phieugiaohangHEntity.Ngaytao;
				GRID_PHIEUGIAOHANGH.CurrentRow.Cells[PhieugiaohangHFields.Nguoitao.Name].Value = _phieugiaohangHEntity.Nguoitao;
				GRID_PHIEUGIAOHANGH.CurrentRow.Cells[PhieugiaohangHFields.Ngaysua.Name].Value = _phieugiaohangHEntity.Ngaysua;
				GRID_PHIEUGIAOHANGH.CurrentRow.Cells[PhieugiaohangHFields.Nguoisua.Name].Value = _phieugiaohangHEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangHManager.Convert(_phieugiaohangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_PHIEUGIAOHANGH_PK;
		}

	}
}
