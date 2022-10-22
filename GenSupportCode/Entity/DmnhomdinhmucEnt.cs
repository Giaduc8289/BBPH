﻿
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmnhomdinhmucEnt
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
	public class DmnhomdinhmucEnt : DmnhomdinhmucEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmnhomdinhmucEnt()
		{
			// Nothing for now.
		}

		void BS_DMNHOMDINHMUC_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMNHOMDINHMUC.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMNHOMDINHMUC.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmnhomdinhmucFields.Manhom.Name].ToString();
					
					txt_MANHOM.Text = _Rowview.Row[DmnhomdinhmucFields.Manhom.Name].ToString();
					txt_TENNHOM.Text = _Rowview.Row[DmnhomdinhmucFields.Tennhom.Name].ToString();
					txt_TENRUTGON.Text = _Rowview.Row[DmnhomdinhmucFields.Tenrutgon.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmnhomdinhmucFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmnhomdinhmucFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmnhomdinhmucFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmnhomdinhmucFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMNHOMDINHMUC_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMNHOMDINHMUC_PK)
		{
			DmnhomdinhmucEntity _dmnhomdinhmucEntity = new DmnhomdinhmucEntity();
			
			_dmnhomdinhmucEntity.Manhom = txt_MANHOM.Text.Trim();
			_dmnhomdinhmucEntity.Tennhom = txt_TENNHOM.Text.Trim();
			_dmnhomdinhmucEntity.Tenrutgon = txt_TENRUTGON.Text.Trim();
			_dmnhomdinhmucEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dmnhomdinhmucEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dmnhomdinhmucEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dmnhomdinhmucEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMNHOMDINHMUC_PK))
			{
				_str_DMNHOMDINHMUC_PK = _DmnhomdinhmucManager.InsertV2(_dmnhomdinhmucEntity, r_Insert, DT_DMNHOMDINHMUC, BS_DMNHOMDINHMUC);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnhomdinhmucManager.Convert(_dmnhomdinhmucEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMNHOMDINHMUC.ResetCurrentItem();
			}
			else
			{
				_DmnhomdinhmucManager.Update(_dmnhomdinhmucEntity);
				
				GRID_DMNHOMDINHMUC.CurrentRow.Cells[DmnhomdinhmucFields.Manhom.Name].Value = _dmnhomdinhmucEntity.Manhom;
				GRID_DMNHOMDINHMUC.CurrentRow.Cells[DmnhomdinhmucFields.Tennhom.Name].Value = _dmnhomdinhmucEntity.Tennhom;
				GRID_DMNHOMDINHMUC.CurrentRow.Cells[DmnhomdinhmucFields.Tenrutgon.Name].Value = _dmnhomdinhmucEntity.Tenrutgon;
				GRID_DMNHOMDINHMUC.CurrentRow.Cells[DmnhomdinhmucFields.Ngaytao.Name].Value = _dmnhomdinhmucEntity.Ngaytao;
				GRID_DMNHOMDINHMUC.CurrentRow.Cells[DmnhomdinhmucFields.Nguoitao.Name].Value = _dmnhomdinhmucEntity.Nguoitao;
				GRID_DMNHOMDINHMUC.CurrentRow.Cells[DmnhomdinhmucFields.Ngaysua.Name].Value = _dmnhomdinhmucEntity.Ngaysua;
				GRID_DMNHOMDINHMUC.CurrentRow.Cells[DmnhomdinhmucFields.Nguoisua.Name].Value = _dmnhomdinhmucEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnhomdinhmucManager.Convert(_dmnhomdinhmucEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMNHOMDINHMUC_PK;
		}

	}
}
