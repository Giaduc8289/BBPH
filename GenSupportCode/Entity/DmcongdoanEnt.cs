
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

		void BS_Dmcongdoan_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmcongdoan.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmcongdoan.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmcongdoanFields.Macd.Name].ToString();
					
					txt_Macd.Text = _Rowview.Row[DmcongdoanFields.Macd.Name].ToString();
					txt_Tencongdoan.Text = _Rowview.Row[DmcongdoanFields.Tencongdoan.Name].ToString();
					txt_Sothutucongdoan.Text = _Rowview.Row[DmcongdoanFields.Sothutucongdoan.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[DmcongdoanFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[DmcongdoanFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[DmcongdoanFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[DmcongdoanFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmcongdoan_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmcongdoan_PK)
		{
			DmcongdoanEntity _dmcongdoanEntity = new DmcongdoanEntity();
			
			_dmcongdoanEntity.Macd = txt_Macd.Text.Trim();
			_dmcongdoanEntity.Tencongdoan = txt_Tencongdoan.Text.Trim();
			_dmcongdoanEntity.Sothutucongdoan = txt_Sothutucongdoan.Text.Trim();
			_dmcongdoanEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_dmcongdoanEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_dmcongdoanEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_dmcongdoanEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmcongdoan_PK = _DmcongdoanManager.InsertV2(_DmcongdoanEntity, r_Insert, DT_Dmcongdoan, BS_Dmcongdoan);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcongdoanManager.Convert(_dmcongdoanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmcongdoan.ResetCurrentItem();
			}
			else
			{
				_DmcongdoanManager.Update(_dmcongdoanEntity);
				
				GRID_Dmcongdoan.CurrentRow.Cells[DmcongdoanFields.Macd.Name].Value = _dmcongdoanEntity.Macd;
				GRID_Dmcongdoan.CurrentRow.Cells[DmcongdoanFields.Tencongdoan.Name].Value = _dmcongdoanEntity.Tencongdoan;
				GRID_Dmcongdoan.CurrentRow.Cells[DmcongdoanFields.Sothutucongdoan.Name].Value = _dmcongdoanEntity.Sothutucongdoan;
				GRID_Dmcongdoan.CurrentRow.Cells[DmcongdoanFields.Ngaytao.Name].Value = _dmcongdoanEntity.Ngaytao;
				GRID_Dmcongdoan.CurrentRow.Cells[DmcongdoanFields.Nguoitao.Name].Value = _dmcongdoanEntity.Nguoitao;
				GRID_Dmcongdoan.CurrentRow.Cells[DmcongdoanFields.Ngaysua.Name].Value = _dmcongdoanEntity.Ngaysua;
				GRID_Dmcongdoan.CurrentRow.Cells[DmcongdoanFields.Nguoisua.Name].Value = _dmcongdoanEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcongdoanManager.Convert(_dmcongdoanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmcongdoan_PK;
		}

	}
}
