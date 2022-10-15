﻿
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmcongdoanEnt
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
	public class DmcongdoanEnt : DmcongdoanEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmcongdoanEnt()
		{
			// Nothing for now.
		}

		void BS_DMCONGDOAN_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMCONGDOAN.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMCONGDOAN.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmcongdoanFields.Macd.Name].ToString();
					
					txt_MACD.Text = _Rowview.Row[DmcongdoanFields.Macd.Name].ToString();
					txt_TENCONGDOAN.Text = _Rowview.Row[DmcongdoanFields.Tencongdoan.Name].ToString();
					txt_SOTHUTUCONGDOAN.Text = _Rowview.Row[DmcongdoanFields.Sothutucongdoan.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmcongdoanFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmcongdoanFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmcongdoanFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmcongdoanFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMCONGDOAN_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMCONGDOAN_PK)
		{
			DmcongdoanEntity _dmcongdoanEntity = new DmcongdoanEntity();
			
			_dmcongdoanEntity.Macd = txt_MACD.Text.Trim();
			_dmcongdoanEntity.Tencongdoan = txt_TENCONGDOAN.Text.Trim();
			_dmcongdoanEntity.Sothutucongdoan = txt_SOTHUTUCONGDOAN.Text.Trim();
			_dmcongdoanEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dmcongdoanEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dmcongdoanEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dmcongdoanEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMCONGDOAN_PK))
			{
				_str_DMCONGDOAN_PK = _DmcongdoanManager.InsertV2(_dmcongdoanEntity, r_Insert, DT_DMCONGDOAN, BS_DMCONGDOAN);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcongdoanManager.Convert(_dmcongdoanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMCONGDOAN.ResetCurrentItem();
			}
			else
			{
				_DmcongdoanManager.Update(_dmcongdoanEntity);
				
				GRID_DMCONGDOAN.CurrentRow.Cells[DmcongdoanFields.Macd.Name].Value = _dmcongdoanEntity.Macd;
				GRID_DMCONGDOAN.CurrentRow.Cells[DmcongdoanFields.Tencongdoan.Name].Value = _dmcongdoanEntity.Tencongdoan;
				GRID_DMCONGDOAN.CurrentRow.Cells[DmcongdoanFields.Sothutucongdoan.Name].Value = _dmcongdoanEntity.Sothutucongdoan;
				GRID_DMCONGDOAN.CurrentRow.Cells[DmcongdoanFields.Ngaytao.Name].Value = _dmcongdoanEntity.Ngaytao;
				GRID_DMCONGDOAN.CurrentRow.Cells[DmcongdoanFields.Nguoitao.Name].Value = _dmcongdoanEntity.Nguoitao;
				GRID_DMCONGDOAN.CurrentRow.Cells[DmcongdoanFields.Ngaysua.Name].Value = _dmcongdoanEntity.Ngaysua;
				GRID_DMCONGDOAN.CurrentRow.Cells[DmcongdoanFields.Nguoisua.Name].Value = _dmcongdoanEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcongdoanManager.Convert(_dmcongdoanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMCONGDOAN_PK;
		}

	}
}
