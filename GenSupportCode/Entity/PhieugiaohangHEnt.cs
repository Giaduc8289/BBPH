
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

		void BS_PhieugiaohangH_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_PhieugiaohangH.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_PhieugiaohangH.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[PhieugiaohangHFields.Sophieu.Name].ToString();
					
					txt_Sophieu.Text = _Rowview.Row[PhieugiaohangHFields.Sophieu.Name].ToString();
					txt_Ngaygiao.Text = _Rowview.Row[PhieugiaohangHFields.Ngaygiao.Name].ToString();
					txt_Madon.Text = _Rowview.Row[PhieugiaohangHFields.Madon.Name].ToString();
					txt_Ngaydat.Text = _Rowview.Row[PhieugiaohangHFields.Ngaydat.Name].ToString();
					txt_Makhach.Text = _Rowview.Row[PhieugiaohangHFields.Makhach.Name].ToString();
					txt_Tenkhach.Text = _Rowview.Row[PhieugiaohangHFields.Tenkhach.Name].ToString();
					txt_Tongtien.Text = _Rowview.Row[PhieugiaohangHFields.Tongtien.Name].ToString();
					txt_Vat.Text = _Rowview.Row[PhieugiaohangHFields.Vat.Name].ToString();
					txt_Ghichu.Text = _Rowview.Row[PhieugiaohangHFields.Ghichu.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[PhieugiaohangHFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[PhieugiaohangHFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[PhieugiaohangHFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[PhieugiaohangHFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_PhieugiaohangH_CurrentChanged"); }
		}

		private string Save_Data(string _str_PhieugiaohangH_PK)
		{
			PhieugiaohangHEntity _phieugiaohangHEntity = new PhieugiaohangHEntity();
			
			_phieugiaohangHEntity.Sophieu = txt_Sophieu.Text.Trim();
			_phieugiaohangHEntity.Ngaygiao = txt_Ngaygiao.Text.Trim();
			_phieugiaohangHEntity.Madon = txt_Madon.Text.Trim();
			_phieugiaohangHEntity.Ngaydat = txt_Ngaydat.Text.Trim();
			_phieugiaohangHEntity.Makhach = txt_Makhach.Text.Trim();
			_phieugiaohangHEntity.Tenkhach = txt_Tenkhach.Text.Trim();
			_phieugiaohangHEntity.Tongtien = txt_Tongtien.Text.Trim();
			_phieugiaohangHEntity.Vat = txt_Vat.Text.Trim();
			_phieugiaohangHEntity.Ghichu = txt_Ghichu.Text.Trim();
			_phieugiaohangHEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_phieugiaohangHEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_phieugiaohangHEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_phieugiaohangHEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_PhieugiaohangH_PK = _PhieugiaohangHManager.InsertV2(_PhieugiaohangHEntity, r_Insert, DT_PhieugiaohangH, BS_PhieugiaohangH);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangHManager.Convert(_phieugiaohangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_PhieugiaohangH.ResetCurrentItem();
			}
			else
			{
				_PhieugiaohangHManager.Update(_phieugiaohangHEntity);
				
				GRID_PhieugiaohangH.CurrentRow.Cells[PhieugiaohangHFields.Sophieu.Name].Value = _phieugiaohangHEntity.Sophieu;
				GRID_PhieugiaohangH.CurrentRow.Cells[PhieugiaohangHFields.Ngaygiao.Name].Value = _phieugiaohangHEntity.Ngaygiao;
				GRID_PhieugiaohangH.CurrentRow.Cells[PhieugiaohangHFields.Madon.Name].Value = _phieugiaohangHEntity.Madon;
				GRID_PhieugiaohangH.CurrentRow.Cells[PhieugiaohangHFields.Ngaydat.Name].Value = _phieugiaohangHEntity.Ngaydat;
				GRID_PhieugiaohangH.CurrentRow.Cells[PhieugiaohangHFields.Makhach.Name].Value = _phieugiaohangHEntity.Makhach;
				GRID_PhieugiaohangH.CurrentRow.Cells[PhieugiaohangHFields.Tenkhach.Name].Value = _phieugiaohangHEntity.Tenkhach;
				GRID_PhieugiaohangH.CurrentRow.Cells[PhieugiaohangHFields.Tongtien.Name].Value = _phieugiaohangHEntity.Tongtien;
				GRID_PhieugiaohangH.CurrentRow.Cells[PhieugiaohangHFields.Vat.Name].Value = _phieugiaohangHEntity.Vat;
				GRID_PhieugiaohangH.CurrentRow.Cells[PhieugiaohangHFields.Ghichu.Name].Value = _phieugiaohangHEntity.Ghichu;
				GRID_PhieugiaohangH.CurrentRow.Cells[PhieugiaohangHFields.Ngaytao.Name].Value = _phieugiaohangHEntity.Ngaytao;
				GRID_PhieugiaohangH.CurrentRow.Cells[PhieugiaohangHFields.Nguoitao.Name].Value = _phieugiaohangHEntity.Nguoitao;
				GRID_PhieugiaohangH.CurrentRow.Cells[PhieugiaohangHFields.Ngaysua.Name].Value = _phieugiaohangHEntity.Ngaysua;
				GRID_PhieugiaohangH.CurrentRow.Cells[PhieugiaohangHFields.Nguoisua.Name].Value = _phieugiaohangHEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangHManager.Convert(_phieugiaohangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_PhieugiaohangH_PK;
		}

	}
}
