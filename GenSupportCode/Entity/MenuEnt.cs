
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

		void BS_MENU_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_MENU.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_MENU.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[MenuFields.MenuId.Name].ToString();
					
					txt_MENUID.Text = _Rowview.Row[MenuFields.MenuId.Name].ToString();
					txt_MENUNAME.Text = _Rowview.Row[MenuFields.MenuName.Name].ToString();
					txt_ICON.Text = _Rowview.Row[MenuFields.Icon.Name].ToString();
					txt_ISSUDUNG.Text = _Rowview.Row[MenuFields.Issudung.Name].ToString();
					txt_ISTRANGTHAI.Text = _Rowview.Row[MenuFields.Istrangthai.Name].ToString();
					txt_MENUPARENT.Text = _Rowview.Row[MenuFields.Menuparent.Name].ToString();
					txt_THUTU.Text = _Rowview.Row[MenuFields.Thutu.Name].ToString();
					txt_FORMNAME.Text = _Rowview.Row[MenuFields.FormName.Name].ToString();
					txt_LOAIMENU.Text = _Rowview.Row[MenuFields.LoaiMenu.Name].ToString();
					txt_PARAM.Text = _Rowview.Row[MenuFields.Param.Name].ToString();
					txt_MAPHANHE.Text = _Rowview.Row[MenuFields.Maphanhe.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_MENU_CurrentChanged"); }
		}

		private string Save_Data(string _str_MENU_PK)
		{
			MenuEntity _menuEntity = new MenuEntity();
			
			_menuEntity.MenuId = txt_MENUID.Text.Trim();
			_menuEntity.MenuName = txt_MENUNAME.Text.Trim();
			_menuEntity.Icon = txt_ICON.Text.Trim();
			_menuEntity.Issudung = txt_ISSUDUNG.Text.Trim();
			_menuEntity.Istrangthai = txt_ISTRANGTHAI.Text.Trim();
			_menuEntity.Menuparent = txt_MENUPARENT.Text.Trim();
			_menuEntity.Thutu = txt_THUTU.Text.Trim();
			_menuEntity.FormName = txt_FORMNAME.Text.Trim();
			_menuEntity.LoaiMenu = txt_LOAIMENU.Text.Trim();
			_menuEntity.Param = txt_PARAM.Text.Trim();
			_menuEntity.Maphanhe = txt_MAPHANHE.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_MENU_PK))
			{
				_str_MENU_PK = _MenuManager.InsertV2(_menuEntity, r_Insert, DT_MENU, BS_MENU);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_MenuManager.Convert(_menuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_MENU.ResetCurrentItem();
			}
			else
			{
				_MenuManager.Update(_menuEntity);
				
				GRID_MENU.CurrentRow.Cells[MenuFields.MenuId.Name].Value = _menuEntity.MenuId;
				GRID_MENU.CurrentRow.Cells[MenuFields.MenuName.Name].Value = _menuEntity.MenuName;
				GRID_MENU.CurrentRow.Cells[MenuFields.Icon.Name].Value = _menuEntity.Icon;
				GRID_MENU.CurrentRow.Cells[MenuFields.Issudung.Name].Value = _menuEntity.Issudung;
				GRID_MENU.CurrentRow.Cells[MenuFields.Istrangthai.Name].Value = _menuEntity.Istrangthai;
				GRID_MENU.CurrentRow.Cells[MenuFields.Menuparent.Name].Value = _menuEntity.Menuparent;
				GRID_MENU.CurrentRow.Cells[MenuFields.Thutu.Name].Value = _menuEntity.Thutu;
				GRID_MENU.CurrentRow.Cells[MenuFields.FormName.Name].Value = _menuEntity.FormName;
				GRID_MENU.CurrentRow.Cells[MenuFields.LoaiMenu.Name].Value = _menuEntity.LoaiMenu;
				GRID_MENU.CurrentRow.Cells[MenuFields.Param.Name].Value = _menuEntity.Param;
				GRID_MENU.CurrentRow.Cells[MenuFields.Maphanhe.Name].Value = _menuEntity.Maphanhe;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_MenuManager.Convert(_menuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_MENU_PK;
		}

	}
}
