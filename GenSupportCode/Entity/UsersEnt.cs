
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.UsersEnt
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
	public class UsersEnt : UsersEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public UsersEnt()
		{
			// Nothing for now.
		}

		void BS_Users_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Users.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Users.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[UsersFields.Userid.Name].ToString();
					
					txt_Userid.Text = _Rowview.Row[UsersFields.Userid.Name].ToString();
					txt_Rolesid.Text = _Rowview.Row[UsersFields.Rolesid.Name].ToString();
					txt_Username.Text = _Rowview.Row[UsersFields.Username.Name].ToString();
					txt_Fullname.Text = _Rowview.Row[UsersFields.Fullname.Name].ToString();
					txt_Phone.Text = _Rowview.Row[UsersFields.Phone.Name].ToString();
					txt_Address.Text = _Rowview.Row[UsersFields.Address.Name].ToString();
					txt_Password.Text = _Rowview.Row[UsersFields.Password.Name].ToString();
					txt_Active.Text = _Rowview.Row[UsersFields.Active.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Users_CurrentChanged"); }
		}

		private string Save_Data(string _str_Users_PK)
		{
			UsersEntity _usersEntity = new UsersEntity();
			
			_users.Userid = txt_Userid.Text.Trim();
			_users.Rolesid = txt_Rolesid.Text.Trim();
			_users.Username = txt_Username.Text.Trim();
			_users.Fullname = txt_Fullname.Text.Trim();
			_users.Phone = txt_Phone.Text.Trim();
			_users.Address = txt_Address.Text.Trim();
			_users.Password = txt_Password.Text.Trim();
			_users.Active = txt_Active.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Users_PK = _UsersManager.InsertV2(_UsersEntity, r_Insert, DT_Users, BS_Users);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_UsersManager.Convert(_usersEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Users.ResetCurrentItem();
			}
			else
			{
				_UsersManager.Update(_usersEntity);
				
				GRID_Users.CurrentRow.Cells[UsersFields.Userid.Name].Value = _usersEntity.Userid;
				GRID_Users.CurrentRow.Cells[UsersFields.Rolesid.Name].Value = _usersEntity.Rolesid;
				GRID_Users.CurrentRow.Cells[UsersFields.Username.Name].Value = _usersEntity.Username;
				GRID_Users.CurrentRow.Cells[UsersFields.Fullname.Name].Value = _usersEntity.Fullname;
				GRID_Users.CurrentRow.Cells[UsersFields.Phone.Name].Value = _usersEntity.Phone;
				GRID_Users.CurrentRow.Cells[UsersFields.Address.Name].Value = _usersEntity.Address;
				GRID_Users.CurrentRow.Cells[UsersFields.Password.Name].Value = _usersEntity.Password;
				GRID_Users.CurrentRow.Cells[UsersFields.Active.Name].Value = _usersEntity.Active;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_UsersManager.Convert(_usersEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Users_PK;
		}

	}
}
