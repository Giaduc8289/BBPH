
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.MenuroleEnt
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
	public class MenuroleEnt : MenuroleEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MenuroleEnt()
		{
			// Nothing for now.
		}

		void BS_Menurole_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Menurole.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Menurole.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[MenuroleFields.Menuid, Rolesid.Name].ToString();
					
					txt_Menuid.Text = _Rowview.Row[MenuroleFields.Menuid.Name].ToString();
					txt_Rolesid.Text = _Rowview.Row[MenuroleFields.Rolesid.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Menurole_CurrentChanged"); }
		}

		private string Save_Data(string _str_Menurole_PK)
		{
			MenuroleEntity _menuroleEntity = new MenuroleEntity();
			
			_menurole.Menuid = txt_Menuid.Text.Trim();
			_menurole.Rolesid = txt_Rolesid.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Menurole_PK = _MenuroleManager.InsertV2(_MenuroleEntity, r_Insert, DT_Menurole, BS_Menurole);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_MenuroleManager.Convert(_menuroleEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Menurole.ResetCurrentItem();
			}
			else
			{
				_MenuroleManager.Update(_menuroleEntity);
				
				GRID_Menurole.CurrentRow.Cells[MenuroleFields.Menuid.Name].Value = _menuroleEntity.Menuid;
				GRID_Menurole.CurrentRow.Cells[MenuroleFields.Rolesid.Name].Value = _menuroleEntity.Rolesid;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_MenuroleManager.Convert(_menuroleEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Menurole_PK;
		}

	}
}
