
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmmauEnt
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
	public class DmmauEnt : DmmauEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmmauEnt()
		{
			// Nothing for now.
		}

		void BS_Dmmau_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmmau.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmmau.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmmauFields.Mamau.Name].ToString();
					
					txt_Mamau.Text = _Rowview.Row[DmmauFields.Mamau.Name].ToString();
					txt_Tenmau.Text = _Rowview.Row[DmmauFields.Tenmau.Name].ToString();
					txt_Lamaugoc.Text = _Rowview.Row[DmmauFields.Lamaugoc.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[DmmauFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[DmmauFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[DmmauFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[DmmauFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmmau_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmmau_PK)
		{
			DmmauEntity _dmmauEntity = new DmmauEntity();
			
			_dmmauEntity.Mamau = txt_Mamau.Text.Trim();
			_dmmauEntity.Tenmau = txt_Tenmau.Text.Trim();
			_dmmauEntity.Lamaugoc = txt_Lamaugoc.Text.Trim();
			_dmmauEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_dmmauEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_dmmauEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_dmmauEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmmau_PK = _DmmauManager.InsertV2(_DmmauEntity, r_Insert, DT_Dmmau, BS_Dmmau);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmauManager.Convert(_dmmauEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmmau.ResetCurrentItem();
			}
			else
			{
				_DmmauManager.Update(_dmmauEntity);
				
				GRID_Dmmau.CurrentRow.Cells[DmmauFields.Mamau.Name].Value = _dmmauEntity.Mamau;
				GRID_Dmmau.CurrentRow.Cells[DmmauFields.Tenmau.Name].Value = _dmmauEntity.Tenmau;
				GRID_Dmmau.CurrentRow.Cells[DmmauFields.Lamaugoc.Name].Value = _dmmauEntity.Lamaugoc;
				GRID_Dmmau.CurrentRow.Cells[DmmauFields.Ngaytao.Name].Value = _dmmauEntity.Ngaytao;
				GRID_Dmmau.CurrentRow.Cells[DmmauFields.Nguoitao.Name].Value = _dmmauEntity.Nguoitao;
				GRID_Dmmau.CurrentRow.Cells[DmmauFields.Ngaysua.Name].Value = _dmmauEntity.Ngaysua;
				GRID_Dmmau.CurrentRow.Cells[DmmauFields.Nguoisua.Name].Value = _dmmauEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmauManager.Convert(_dmmauEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmmau_PK;
		}

	}
}
