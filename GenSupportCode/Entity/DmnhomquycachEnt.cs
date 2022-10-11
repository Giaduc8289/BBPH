
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmnhomquycachEnt
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
	public class DmnhomquycachEnt : DmnhomquycachEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmnhomquycachEnt()
		{
			// Nothing for now.
		}

		void BS_Dmnhomquycach_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmnhomquycach.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmnhomquycach.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmnhomquycachFields.Manhom.Name].ToString();
					
					txt_Manhom.Text = _Rowview.Row[DmnhomquycachFields.Manhom.Name].ToString();
					txt_Tennhom.Text = _Rowview.Row[DmnhomquycachFields.Tennhom.Name].ToString();
					txt_Tenrutgon.Text = _Rowview.Row[DmnhomquycachFields.Tenrutgon.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[DmnhomquycachFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[DmnhomquycachFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[DmnhomquycachFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[DmnhomquycachFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmnhomquycach_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmnhomquycach_PK)
		{
			DmnhomquycachEntity _dmnhomquycachEntity = new DmnhomquycachEntity();
			
			_dmnhomquycachEntity.Manhom = txt_Manhom.Text.Trim();
			_dmnhomquycachEntity.Tennhom = txt_Tennhom.Text.Trim();
			_dmnhomquycachEntity.Tenrutgon = txt_Tenrutgon.Text.Trim();
			_dmnhomquycachEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_dmnhomquycachEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_dmnhomquycachEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_dmnhomquycachEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmnhomquycach_PK = _DmnhomquycachManager.InsertV2(_DmnhomquycachEntity, r_Insert, DT_Dmnhomquycach, BS_Dmnhomquycach);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnhomquycachManager.Convert(_dmnhomquycachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmnhomquycach.ResetCurrentItem();
			}
			else
			{
				_DmnhomquycachManager.Update(_dmnhomquycachEntity);
				
				GRID_Dmnhomquycach.CurrentRow.Cells[DmnhomquycachFields.Manhom.Name].Value = _dmnhomquycachEntity.Manhom;
				GRID_Dmnhomquycach.CurrentRow.Cells[DmnhomquycachFields.Tennhom.Name].Value = _dmnhomquycachEntity.Tennhom;
				GRID_Dmnhomquycach.CurrentRow.Cells[DmnhomquycachFields.Tenrutgon.Name].Value = _dmnhomquycachEntity.Tenrutgon;
				GRID_Dmnhomquycach.CurrentRow.Cells[DmnhomquycachFields.Ngaytao.Name].Value = _dmnhomquycachEntity.Ngaytao;
				GRID_Dmnhomquycach.CurrentRow.Cells[DmnhomquycachFields.Nguoitao.Name].Value = _dmnhomquycachEntity.Nguoitao;
				GRID_Dmnhomquycach.CurrentRow.Cells[DmnhomquycachFields.Ngaysua.Name].Value = _dmnhomquycachEntity.Ngaysua;
				GRID_Dmnhomquycach.CurrentRow.Cells[DmnhomquycachFields.Nguoisua.Name].Value = _dmnhomquycachEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnhomquycachManager.Convert(_dmnhomquycachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmnhomquycach_PK;
		}

	}
}
