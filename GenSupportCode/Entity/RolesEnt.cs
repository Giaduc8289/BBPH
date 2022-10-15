
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

		void BS_ROLES_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_ROLES.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_ROLES.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[RolesFields.Rolesid.Name].ToString();
					
					txt_ROLESID.Text = _Rowview.Row[RolesFields.Rolesid.Name].ToString();
					txt_ROLESNAME.Text = _Rowview.Row[RolesFields.Rolesname.Name].ToString();
					txt_DESCRIPTION.Text = _Rowview.Row[RolesFields.Description.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_ROLES_CurrentChanged"); }
		}

		private string Save_Data(string _str_ROLES_PK)
		{
			RolesEntity _rolesEntity = new RolesEntity();
			
			_rolesEntity.Rolesid = txt_ROLESID.Text.Trim();
			_rolesEntity.Rolesname = txt_ROLESNAME.Text.Trim();
			_rolesEntity.Description = txt_DESCRIPTION.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_ROLES_PK))
			{
				_str_ROLES_PK = _RolesManager.InsertV2(_rolesEntity, r_Insert, DT_ROLES, BS_ROLES);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_RolesManager.Convert(_rolesEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_ROLES.ResetCurrentItem();
			}
			else
			{
				_RolesManager.Update(_rolesEntity);
				
				GRID_ROLES.CurrentRow.Cells[RolesFields.Rolesid.Name].Value = _rolesEntity.Rolesid;
				GRID_ROLES.CurrentRow.Cells[RolesFields.Rolesname.Name].Value = _rolesEntity.Rolesname;
				GRID_ROLES.CurrentRow.Cells[RolesFields.Description.Name].Value = _rolesEntity.Description;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_RolesManager.Convert(_rolesEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_ROLES_PK;
		}

	}
}
