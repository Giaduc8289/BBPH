﻿
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

		void BS_USERS_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_USERS.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_USERS.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[UsersFields.Userid.Name].ToString();
					
					txt_USERID.Text = _Rowview.Row[UsersFields.Userid.Name].ToString();
					txt_ROLESID.Text = _Rowview.Row[UsersFields.Rolesid.Name].ToString();
					txt_USERNAME.Text = _Rowview.Row[UsersFields.Username.Name].ToString();
					txt_FULLNAME.Text = _Rowview.Row[UsersFields.Fullname.Name].ToString();
					txt_PHONE.Text = _Rowview.Row[UsersFields.Phone.Name].ToString();
					txt_ADDRESS.Text = _Rowview.Row[UsersFields.Address.Name].ToString();
					txt_PASSWORD.Text = _Rowview.Row[UsersFields.Password.Name].ToString();
					txt_ACTIVE.Text = _Rowview.Row[UsersFields.Active.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_USERS_CurrentChanged"); }
		}

		private string Save_Data(string _str_USERS_PK)
		{
			UsersEntity _UsersEntity = new UsersEntity();
			
			_UsersEntity.Userid = txt_USERID.Text.Trim();
			_UsersEntity.Rolesid = txt_ROLESID.Text.Trim();
			_UsersEntity.Username = txt_USERNAME.Text.Trim();
			_UsersEntity.Fullname = txt_FULLNAME.Text.Trim();
			_UsersEntity.Phone = txt_PHONE.Text.Trim();
			_UsersEntity.Address = txt_ADDRESS.Text.Trim();
			_UsersEntity.Password = txt_PASSWORD.Text.Trim();
			_UsersEntity.Active = txt_ACTIVE.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_USERS_PK))
			{
				_str_USERS_PK = _UsersManager.InsertV2(_UsersEntity, r_Insert, DT_USERS, BS_USERS);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_UsersManager.Convert(_UsersEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_USERS.ResetCurrentItem();
			}
			else
			{
				_UsersManager.Update(_UsersEntity);
				
				GRID_USERS.CurrentRow.Cells[UsersFields.Userid.Name].Value = _UsersEntity.Userid;
				GRID_USERS.CurrentRow.Cells[UsersFields.Rolesid.Name].Value = _UsersEntity.Rolesid;
				GRID_USERS.CurrentRow.Cells[UsersFields.Username.Name].Value = _UsersEntity.Username;
				GRID_USERS.CurrentRow.Cells[UsersFields.Fullname.Name].Value = _UsersEntity.Fullname;
				GRID_USERS.CurrentRow.Cells[UsersFields.Phone.Name].Value = _UsersEntity.Phone;
				GRID_USERS.CurrentRow.Cells[UsersFields.Address.Name].Value = _UsersEntity.Address;
				GRID_USERS.CurrentRow.Cells[UsersFields.Password.Name].Value = _UsersEntity.Password;
				GRID_USERS.CurrentRow.Cells[UsersFields.Active.Name].Value = _UsersEntity.Active;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_UsersManager.Convert(_UsersEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_USERS_PK;
		}

	}
}
