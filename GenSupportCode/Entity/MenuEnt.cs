
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.MenuEnt
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
	public class MenuEnt : MenuEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MenuEnt()
		{
			// Nothing for now.
		}

		void BS_Menu_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Menu.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Menu.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[MenuFields.MenuId.Name].ToString();
					
					txt_MenuId.Text = _Rowview.Row[MenuFields.MenuId.Name].ToString();
					txt_MenuName.Text = _Rowview.Row[MenuFields.MenuName.Name].ToString();
					txt_Icon.Text = _Rowview.Row[MenuFields.Icon.Name].ToString();
					txt_Issudung.Text = _Rowview.Row[MenuFields.Issudung.Name].ToString();
					txt_Istrangthai.Text = _Rowview.Row[MenuFields.Istrangthai.Name].ToString();
					txt_Menuparent.Text = _Rowview.Row[MenuFields.Menuparent.Name].ToString();
					txt_Thutu.Text = _Rowview.Row[MenuFields.Thutu.Name].ToString();
					txt_FormName.Text = _Rowview.Row[MenuFields.FormName.Name].ToString();
					txt_LoaiMenu.Text = _Rowview.Row[MenuFields.LoaiMenu.Name].ToString();
					txt_Param.Text = _Rowview.Row[MenuFields.Param.Name].ToString();
					txt_Maphanhe.Text = _Rowview.Row[MenuFields.Maphanhe.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Menu_CurrentChanged"); }
		}

		private string Save_Data(string _str_Menu_PK)
		{
			MenuEntity _menuEntity = new MenuEntity();
			
			_menuEntity.MenuId = txt_MenuId.Text.Trim();
			_menuEntity.MenuName = txt_MenuName.Text.Trim();
			_menuEntity.Icon = txt_Icon.Text.Trim();
			_menuEntity.Issudung = txt_Issudung.Text.Trim();
			_menuEntity.Istrangthai = txt_Istrangthai.Text.Trim();
			_menuEntity.Menuparent = txt_Menuparent.Text.Trim();
			_menuEntity.Thutu = txt_Thutu.Text.Trim();
			_menuEntity.FormName = txt_FormName.Text.Trim();
			_menuEntity.LoaiMenu = txt_LoaiMenu.Text.Trim();
			_menuEntity.Param = txt_Param.Text.Trim();
			_menuEntity.Maphanhe = txt_Maphanhe.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Menu_PK = _MenuManager.InsertV2(_MenuEntity, r_Insert, DT_Menu, BS_Menu);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_MenuManager.Convert(_menuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Menu.ResetCurrentItem();
			}
			else
			{
				_MenuManager.Update(_menuEntity);
				
				GRID_Menu.CurrentRow.Cells[MenuFields.MenuId.Name].Value = _menuEntity.MenuId;
				GRID_Menu.CurrentRow.Cells[MenuFields.MenuName.Name].Value = _menuEntity.MenuName;
				GRID_Menu.CurrentRow.Cells[MenuFields.Icon.Name].Value = _menuEntity.Icon;
				GRID_Menu.CurrentRow.Cells[MenuFields.Issudung.Name].Value = _menuEntity.Issudung;
				GRID_Menu.CurrentRow.Cells[MenuFields.Istrangthai.Name].Value = _menuEntity.Istrangthai;
				GRID_Menu.CurrentRow.Cells[MenuFields.Menuparent.Name].Value = _menuEntity.Menuparent;
				GRID_Menu.CurrentRow.Cells[MenuFields.Thutu.Name].Value = _menuEntity.Thutu;
				GRID_Menu.CurrentRow.Cells[MenuFields.FormName.Name].Value = _menuEntity.FormName;
				GRID_Menu.CurrentRow.Cells[MenuFields.LoaiMenu.Name].Value = _menuEntity.LoaiMenu;
				GRID_Menu.CurrentRow.Cells[MenuFields.Param.Name].Value = _menuEntity.Param;
				GRID_Menu.CurrentRow.Cells[MenuFields.Maphanhe.Name].Value = _menuEntity.Maphanhe;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_MenuManager.Convert(_menuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Menu_PK;
		}

	}
}
