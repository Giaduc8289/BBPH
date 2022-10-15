﻿
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmdongmayEnt
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
	public class DmdongmayEnt : DmdongmayEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmdongmayEnt()
		{
			// Nothing for now.
		}

		void BS_DMDONGMAY_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMDONGMAY.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMDONGMAY.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmdongmayFields.Madm.Name].ToString();
					
					txt_MADM.Text = _Rowview.Row[DmdongmayFields.Madm.Name].ToString();
					txt_TENDONGMAY.Text = _Rowview.Row[DmdongmayFields.Tendongmay.Name].ToString();
					txt_MACD.Text = _Rowview.Row[DmdongmayFields.Macd.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmdongmayFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmdongmayFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmdongmayFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmdongmayFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMDONGMAY_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMDONGMAY_PK)
		{
			DmdongmayEntity _dmdongmayEntity = new DmdongmayEntity();
			
			_dmdongmayEntity.Madm = txt_MADM.Text.Trim();
			_dmdongmayEntity.Tendongmay = txt_TENDONGMAY.Text.Trim();
			_dmdongmayEntity.Macd = txt_MACD.Text.Trim();
			_dmdongmayEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dmdongmayEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dmdongmayEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dmdongmayEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMDONGMAY_PK))
			{
				_str_DMDONGMAY_PK = _DmdongmayManager.InsertV2(_dmdongmayEntity, r_Insert, DT_DMDONGMAY, BS_DMDONGMAY);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmdongmayManager.Convert(_dmdongmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMDONGMAY.ResetCurrentItem();
			}
			else
			{
				_DmdongmayManager.Update(_dmdongmayEntity);
				
				GRID_DMDONGMAY.CurrentRow.Cells[DmdongmayFields.Madm.Name].Value = _dmdongmayEntity.Madm;
				GRID_DMDONGMAY.CurrentRow.Cells[DmdongmayFields.Tendongmay.Name].Value = _dmdongmayEntity.Tendongmay;
				GRID_DMDONGMAY.CurrentRow.Cells[DmdongmayFields.Macd.Name].Value = _dmdongmayEntity.Macd;
				GRID_DMDONGMAY.CurrentRow.Cells[DmdongmayFields.Ngaytao.Name].Value = _dmdongmayEntity.Ngaytao;
				GRID_DMDONGMAY.CurrentRow.Cells[DmdongmayFields.Nguoitao.Name].Value = _dmdongmayEntity.Nguoitao;
				GRID_DMDONGMAY.CurrentRow.Cells[DmdongmayFields.Ngaysua.Name].Value = _dmdongmayEntity.Ngaysua;
				GRID_DMDONGMAY.CurrentRow.Cells[DmdongmayFields.Nguoisua.Name].Value = _dmdongmayEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmdongmayManager.Convert(_dmdongmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMDONGMAY_PK;
		}

	}
}
