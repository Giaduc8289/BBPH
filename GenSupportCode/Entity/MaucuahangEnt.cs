
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.MaucuahangEnt
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
	public class MaucuahangEnt : MaucuahangEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MaucuahangEnt()
		{
			// Nothing for now.
		}

		void BS_Maucuahang_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Maucuahang.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Maucuahang.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[MaucuahangFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[MaucuahangFields.Id.Name].ToString();
					txt_Masp.Text = _Rowview.Row[MaucuahangFields.Masp.Name].ToString();
					txt_Tensp.Text = _Rowview.Row[MaucuahangFields.Tensp.Name].ToString();
					txt_Mamau.Text = _Rowview.Row[MaucuahangFields.Mamau.Name].ToString();
					txt_Tenmau.Text = _Rowview.Row[MaucuahangFields.Tenmau.Name].ToString();
					txt_Klmau.Text = _Rowview.Row[MaucuahangFields.Klmau.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[MaucuahangFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[MaucuahangFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[MaucuahangFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[MaucuahangFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Maucuahang_CurrentChanged"); }
		}

		private string Save_Data(string _str_Maucuahang_PK)
		{
			MaucuahangEntity _maucuahangEntity = new MaucuahangEntity();
			
			_maucuahangEntity.Id = txt_Id.Text.Trim();
			_maucuahangEntity.Masp = txt_Masp.Text.Trim();
			_maucuahangEntity.Tensp = txt_Tensp.Text.Trim();
			_maucuahangEntity.Mamau = txt_Mamau.Text.Trim();
			_maucuahangEntity.Tenmau = txt_Tenmau.Text.Trim();
			_maucuahangEntity.Klmau = txt_Klmau.Text.Trim();
			_maucuahangEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_maucuahangEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_maucuahangEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_maucuahangEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Maucuahang_PK = _MaucuahangManager.InsertV2(_MaucuahangEntity, r_Insert, DT_Maucuahang, BS_Maucuahang);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_MaucuahangManager.Convert(_maucuahangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Maucuahang.ResetCurrentItem();
			}
			else
			{
				_MaucuahangManager.Update(_maucuahangEntity);
				
				GRID_Maucuahang.CurrentRow.Cells[MaucuahangFields.Id.Name].Value = _maucuahangEntity.Id;
				GRID_Maucuahang.CurrentRow.Cells[MaucuahangFields.Masp.Name].Value = _maucuahangEntity.Masp;
				GRID_Maucuahang.CurrentRow.Cells[MaucuahangFields.Tensp.Name].Value = _maucuahangEntity.Tensp;
				GRID_Maucuahang.CurrentRow.Cells[MaucuahangFields.Mamau.Name].Value = _maucuahangEntity.Mamau;
				GRID_Maucuahang.CurrentRow.Cells[MaucuahangFields.Tenmau.Name].Value = _maucuahangEntity.Tenmau;
				GRID_Maucuahang.CurrentRow.Cells[MaucuahangFields.Klmau.Name].Value = _maucuahangEntity.Klmau;
				GRID_Maucuahang.CurrentRow.Cells[MaucuahangFields.Ngaytao.Name].Value = _maucuahangEntity.Ngaytao;
				GRID_Maucuahang.CurrentRow.Cells[MaucuahangFields.Nguoitao.Name].Value = _maucuahangEntity.Nguoitao;
				GRID_Maucuahang.CurrentRow.Cells[MaucuahangFields.Ngaysua.Name].Value = _maucuahangEntity.Ngaysua;
				GRID_Maucuahang.CurrentRow.Cells[MaucuahangFields.Nguoisua.Name].Value = _maucuahangEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_MaucuahangManager.Convert(_maucuahangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Maucuahang_PK;
		}

	}
}
