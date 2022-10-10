
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmmangEnt
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
	public class DmmangEnt : DmmangEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmmangEnt()
		{
			// Nothing for now.
		}

		void BS_Dmmang_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmmang.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmmang.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmmangFields.Mamang.Name].ToString();
					
					txt_Mamang.Text = _Rowview.Row[DmmangFields.Mamang.Name].ToString();
					txt_Tenmang.Text = _Rowview.Row[DmmangFields.Tenmang.Name].ToString();
					txt_Makhach.Text = _Rowview.Row[DmmangFields.Makhach.Name].ToString();
					txt_Tenkhach.Text = _Rowview.Row[DmmangFields.Tenkhach.Name].ToString();
					txt_Kichthuoc.Text = _Rowview.Row[DmmangFields.Kichthuoc.Name].ToString();
					txt_Trongluong.Text = _Rowview.Row[DmmangFields.Trongluong.Name].ToString();
					txt_Mactpt.Text = _Rowview.Row[DmmangFields.Mactpt.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[DmmangFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[DmmangFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[DmmangFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[DmmangFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmmang_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmmang_PK)
		{
			DmmangEntity _dmmangEntity = new DmmangEntity();
			
			_dmmangEntity.Mamang = txt_Mamang.Text.Trim();
			_dmmangEntity.Tenmang = txt_Tenmang.Text.Trim();
			_dmmangEntity.Makhach = txt_Makhach.Text.Trim();
			_dmmangEntity.Tenkhach = txt_Tenkhach.Text.Trim();
			_dmmangEntity.Kichthuoc = txt_Kichthuoc.Text.Trim();
			_dmmangEntity.Trongluong = txt_Trongluong.Text.Trim();
			_dmmangEntity.Mactpt = txt_Mactpt.Text.Trim();
			_dmmangEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_dmmangEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_dmmangEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_dmmangEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmmang_PK = _DmmangManager.InsertV2(_DmmangEntity, r_Insert, DT_Dmmang, BS_Dmmang);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmangManager.Convert(_dmmangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmmang.ResetCurrentItem();
			}
			else
			{
				_DmmangManager.Update(_dmmangEntity);
				
				GRID_Dmmang.CurrentRow.Cells[DmmangFields.Mamang.Name].Value = _dmmangEntity.Mamang;
				GRID_Dmmang.CurrentRow.Cells[DmmangFields.Tenmang.Name].Value = _dmmangEntity.Tenmang;
				GRID_Dmmang.CurrentRow.Cells[DmmangFields.Makhach.Name].Value = _dmmangEntity.Makhach;
				GRID_Dmmang.CurrentRow.Cells[DmmangFields.Tenkhach.Name].Value = _dmmangEntity.Tenkhach;
				GRID_Dmmang.CurrentRow.Cells[DmmangFields.Kichthuoc.Name].Value = _dmmangEntity.Kichthuoc;
				GRID_Dmmang.CurrentRow.Cells[DmmangFields.Trongluong.Name].Value = _dmmangEntity.Trongluong;
				GRID_Dmmang.CurrentRow.Cells[DmmangFields.Mactpt.Name].Value = _dmmangEntity.Mactpt;
				GRID_Dmmang.CurrentRow.Cells[DmmangFields.Ngaytao.Name].Value = _dmmangEntity.Ngaytao;
				GRID_Dmmang.CurrentRow.Cells[DmmangFields.Nguoitao.Name].Value = _dmmangEntity.Nguoitao;
				GRID_Dmmang.CurrentRow.Cells[DmmangFields.Ngaysua.Name].Value = _dmmangEntity.Ngaysua;
				GRID_Dmmang.CurrentRow.Cells[DmmangFields.Nguoisua.Name].Value = _dmmangEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmangManager.Convert(_dmmangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmmang_PK;
		}

	}
}
