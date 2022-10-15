﻿
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmbophanEnt
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
	public class DmbophanEnt : DmbophanEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmbophanEnt()
		{
			// Nothing for now.
		}

		void BS_DMBOPHAN_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMBOPHAN.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMBOPHAN.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmbophanFields.Mabp.Name].ToString();
					
					txt_MABP.Text = _Rowview.Row[DmbophanFields.Mabp.Name].ToString();
					txt_TENBOPHAN.Text = _Rowview.Row[DmbophanFields.Tenbophan.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmbophanFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmbophanFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmbophanFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmbophanFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMBOPHAN_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMBOPHAN_PK)
		{
			DmbophanEntity _dmbophanEntity = new DmbophanEntity();
			
			_dmbophanEntity.Mabp = txt_MABP.Text.Trim();
			_dmbophanEntity.Tenbophan = txt_TENBOPHAN.Text.Trim();
			_dmbophanEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dmbophanEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dmbophanEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dmbophanEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBOPHAN_PK))
			{
				_str_DMBOPHAN_PK = _DmbophanManager.InsertV2(_dmbophanEntity, r_Insert, DT_DMBOPHAN, BS_DMBOPHAN);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmbophanManager.Convert(_dmbophanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMBOPHAN.ResetCurrentItem();
			}
			else
			{
				_DmbophanManager.Update(_dmbophanEntity);
				
				GRID_DMBOPHAN.CurrentRow.Cells[DmbophanFields.Mabp.Name].Value = _dmbophanEntity.Mabp;
				GRID_DMBOPHAN.CurrentRow.Cells[DmbophanFields.Tenbophan.Name].Value = _dmbophanEntity.Tenbophan;
				GRID_DMBOPHAN.CurrentRow.Cells[DmbophanFields.Ngaytao.Name].Value = _dmbophanEntity.Ngaytao;
				GRID_DMBOPHAN.CurrentRow.Cells[DmbophanFields.Nguoitao.Name].Value = _dmbophanEntity.Nguoitao;
				GRID_DMBOPHAN.CurrentRow.Cells[DmbophanFields.Ngaysua.Name].Value = _dmbophanEntity.Ngaysua;
				GRID_DMBOPHAN.CurrentRow.Cells[DmbophanFields.Nguoisua.Name].Value = _dmbophanEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmbophanManager.Convert(_dmbophanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMBOPHAN_PK;
		}

	}
}
