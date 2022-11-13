﻿
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmnhomnguyenlieuEnt
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
	public class DmnhomnguyenlieuEnt : DmnhomnguyenlieuEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmnhomnguyenlieuEnt()
		{
			// Nothing for now.
		}

		void BS_DMNHOMNGUYENLIEU_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMNHOMNGUYENLIEU.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMNHOMNGUYENLIEU.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmnhomnguyenlieuFields.Manhom.Name].ToString();
					
					txt_MANHOM.Text = _Rowview.Row[DmnhomnguyenlieuFields.Manhom.Name].ToString();
					txt_TENNHOMNGUYENLIEU.Text = _Rowview.Row[DmnhomnguyenlieuFields.Tennhomnguyenlieu.Name].ToString();
					txt_TENRUTGON.Text = _Rowview.Row[DmnhomnguyenlieuFields.Tenrutgon.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmnhomnguyenlieuFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmnhomnguyenlieuFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmnhomnguyenlieuFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmnhomnguyenlieuFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMNHOMNGUYENLIEU_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMNHOMNGUYENLIEU_PK)
		{
			DmnhomnguyenlieuEntity _DmnhomnguyenlieuEntity = new DmnhomnguyenlieuEntity();
			_DmnhomnguyenlieuEntity.Manhom = txt_MANHOM.Text.Trim();
			_DmnhomnguyenlieuEntity.Tennhomnguyenlieu = txt_TENNHOMNGUYENLIEU.Text.Trim();
			_DmnhomnguyenlieuEntity.Tenrutgon = txt_TENRUTGON.Text.Trim();
			try { _DmnhomnguyenlieuEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_DmnhomnguyenlieuEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _DmnhomnguyenlieuEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_DmnhomnguyenlieuEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_DMNHOMNGUYENLIEU_PK))
			{
				_str_DMNHOMNGUYENLIEU_PK = _DmnhomnguyenlieuManager.InsertV2(_DmnhomnguyenlieuEntity, r_Insert, DT_DMNHOMNGUYENLIEU, BS_DMNHOMNGUYENLIEU);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnhomnguyenlieuManager.Convert(_DmnhomnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMNHOMNGUYENLIEU.ResetCurrentItem();
			}
			else
			{
				_DmnhomnguyenlieuManager.Update(_DmnhomnguyenlieuEntity);
				
				GRID_DMNHOMNGUYENLIEU.CurrentRow.Cells[DmnhomnguyenlieuFields.Manhom.Name].Value = _DmnhomnguyenlieuEntity.Manhom;
				GRID_DMNHOMNGUYENLIEU.CurrentRow.Cells[DmnhomnguyenlieuFields.Tennhomnguyenlieu.Name].Value = _DmnhomnguyenlieuEntity.Tennhomnguyenlieu;
				GRID_DMNHOMNGUYENLIEU.CurrentRow.Cells[DmnhomnguyenlieuFields.Tenrutgon.Name].Value = _DmnhomnguyenlieuEntity.Tenrutgon;
				GRID_DMNHOMNGUYENLIEU.CurrentRow.Cells[DmnhomnguyenlieuFields.Ngaytao.Name].Value = _DmnhomnguyenlieuEntity.Ngaytao;
				GRID_DMNHOMNGUYENLIEU.CurrentRow.Cells[DmnhomnguyenlieuFields.Nguoitao.Name].Value = _DmnhomnguyenlieuEntity.Nguoitao;
				GRID_DMNHOMNGUYENLIEU.CurrentRow.Cells[DmnhomnguyenlieuFields.Ngaysua.Name].Value = _DmnhomnguyenlieuEntity.Ngaysua;
				GRID_DMNHOMNGUYENLIEU.CurrentRow.Cells[DmnhomnguyenlieuFields.Nguoisua.Name].Value = _DmnhomnguyenlieuEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnhomnguyenlieuManager.Convert(_DmnhomnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMNHOMNGUYENLIEU_PK;
		}

	}
}
