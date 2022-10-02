﻿
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.CtptmangDEnt
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
	public class CtptmangDEnt : CtptmangDEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CtptmangDEnt()
		{
			// Nothing for now.
		}

		void BS_CtptmangD_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_CtptmangD.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_CtptmangD.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[CtptmangDFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[CtptmangDFields.Id.Name].ToString();
					txt_IdH.Text = _Rowview.Row[CtptmangDFields.IdH.Name].ToString();
					txt_Mact.Text = _Rowview.Row[CtptmangDFields.Mact.Name].ToString();
					txt_Tenct.Text = _Rowview.Row[CtptmangDFields.Tenct.Name].ToString();
					txt_Manl.Text = _Rowview.Row[CtptmangDFields.Manl.Name].ToString();
					txt_Tennguyenlieu.Text = _Rowview.Row[CtptmangDFields.Tennguyenlieu.Name].ToString();
					txt_Trongluong.Text = _Rowview.Row[CtptmangDFields.Trongluong.Name].ToString();
					txt_Tile.Text = _Rowview.Row[CtptmangDFields.Tile.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_CtptmangD_CurrentChanged"); }
		}

		private string Save_Data(string _str_CtptmangD_PK)
		{
			CtptmangDEntity _ctptmangDEntity = new CtptmangDEntity();
			
			_ctptmangD.Id = txt_Id.Text.Trim();
			_ctptmangD.IdH = txt_IdH.Text.Trim();
			_ctptmangD.Mact = txt_Mact.Text.Trim();
			_ctptmangD.Tenct = txt_Tenct.Text.Trim();
			_ctptmangD.Manl = txt_Manl.Text.Trim();
			_ctptmangD.Tennguyenlieu = txt_Tennguyenlieu.Text.Trim();
			_ctptmangD.Trongluong = txt_Trongluong.Text.Trim();
			_ctptmangD.Tile = txt_Tile.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_CtptmangD_PK = _CtptmangDManager.InsertV2(_CtptmangDEntity, r_Insert, DT_CtptmangD, BS_CtptmangD);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CtptmangDManager.Convert(_ctptmangDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_CtptmangD.ResetCurrentItem();
			}
			else
			{
				_CtptmangDManager.Update(_ctptmangDEntity);
				
				GRID_CtptmangD.CurrentRow.Cells[CtptmangDFields.Id.Name].Value = _ctptmangDEntity.Id;
				GRID_CtptmangD.CurrentRow.Cells[CtptmangDFields.IdH.Name].Value = _ctptmangDEntity.IdH;
				GRID_CtptmangD.CurrentRow.Cells[CtptmangDFields.Mact.Name].Value = _ctptmangDEntity.Mact;
				GRID_CtptmangD.CurrentRow.Cells[CtptmangDFields.Tenct.Name].Value = _ctptmangDEntity.Tenct;
				GRID_CtptmangD.CurrentRow.Cells[CtptmangDFields.Manl.Name].Value = _ctptmangDEntity.Manl;
				GRID_CtptmangD.CurrentRow.Cells[CtptmangDFields.Tennguyenlieu.Name].Value = _ctptmangDEntity.Tennguyenlieu;
				GRID_CtptmangD.CurrentRow.Cells[CtptmangDFields.Trongluong.Name].Value = _ctptmangDEntity.Trongluong;
				GRID_CtptmangD.CurrentRow.Cells[CtptmangDFields.Tile.Name].Value = _ctptmangDEntity.Tile;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CtptmangDManager.Convert(_ctptmangDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_CtptmangD_PK;
		}

	}
}
