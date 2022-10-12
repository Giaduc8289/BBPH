
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.RolesEnt
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
	public class RolesEnt : RolesEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public RolesEnt()
		{
			// Nothing for now.
		}

		void BS_Roles_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Roles.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Roles.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[RolesFields.Rolesid.Name].ToString();
					
					txt_Rolesid.Text = _Rowview.Row[RolesFields.Rolesid.Name].ToString();
					txt_Rolesname.Text = _Rowview.Row[RolesFields.Rolesname.Name].ToString();
					txt_Description.Text = _Rowview.Row[RolesFields.Description.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Roles_CurrentChanged"); }
		}

		private string Save_Data(string _str_Roles_PK)
		{
			RolesEntity _rolesEntity = new RolesEntity();
			
			_rolesEntity.Rolesid = txt_Rolesid.Text.Trim();
			_rolesEntity.Rolesname = txt_Rolesname.Text.Trim();
			_rolesEntity.Description = txt_Description.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Roles_PK = _RolesManager.InsertV2(_RolesEntity, r_Insert, DT_Roles, BS_Roles);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_RolesManager.Convert(_rolesEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Roles.ResetCurrentItem();
			}
			else
			{
				_RolesManager.Update(_rolesEntity);
				
				GRID_Roles.CurrentRow.Cells[RolesFields.Rolesid.Name].Value = _rolesEntity.Rolesid;
				GRID_Roles.CurrentRow.Cells[RolesFields.Rolesname.Name].Value = _rolesEntity.Rolesname;
				GRID_Roles.CurrentRow.Cells[RolesFields.Description.Name].Value = _rolesEntity.Description;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_RolesManager.Convert(_rolesEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Roles_PK;
		}

	}
}
