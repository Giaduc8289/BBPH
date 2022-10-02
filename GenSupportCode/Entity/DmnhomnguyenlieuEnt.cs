
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

		void BS_Dmnhomnguyenlieu_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmnhomnguyenlieu.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmnhomnguyenlieu.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmnhomnguyenlieuFields.Manhom.Name].ToString();
					
					txt_Manhom.Text = _Rowview.Row[DmnhomnguyenlieuFields.Manhom.Name].ToString();
					txt_Tennhomnguyenlieu.Text = _Rowview.Row[DmnhomnguyenlieuFields.Tennhomnguyenlieu.Name].ToString();
					txt_Tenrutgon.Text = _Rowview.Row[DmnhomnguyenlieuFields.Tenrutgon.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmnhomnguyenlieu_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmnhomnguyenlieu_PK)
		{
			DmnhomnguyenlieuEntity _dmnhomnguyenlieuEntity = new DmnhomnguyenlieuEntity();
			
			_dmnhomnguyenlieu.Manhom = txt_Manhom.Text.Trim();
			_dmnhomnguyenlieu.Tennhomnguyenlieu = txt_Tennhomnguyenlieu.Text.Trim();
			_dmnhomnguyenlieu.Tenrutgon = txt_Tenrutgon.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmnhomnguyenlieu_PK = _DmnhomnguyenlieuManager.InsertV2(_DmnhomnguyenlieuEntity, r_Insert, DT_Dmnhomnguyenlieu, BS_Dmnhomnguyenlieu);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnhomnguyenlieuManager.Convert(_dmnhomnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmnhomnguyenlieu.ResetCurrentItem();
			}
			else
			{
				_DmnhomnguyenlieuManager.Update(_dmnhomnguyenlieuEntity);
				
				GRID_Dmnhomnguyenlieu.CurrentRow.Cells[DmnhomnguyenlieuFields.Manhom.Name].Value = _dmnhomnguyenlieuEntity.Manhom;
				GRID_Dmnhomnguyenlieu.CurrentRow.Cells[DmnhomnguyenlieuFields.Tennhomnguyenlieu.Name].Value = _dmnhomnguyenlieuEntity.Tennhomnguyenlieu;
				GRID_Dmnhomnguyenlieu.CurrentRow.Cells[DmnhomnguyenlieuFields.Tenrutgon.Name].Value = _dmnhomnguyenlieuEntity.Tenrutgon;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnhomnguyenlieuManager.Convert(_dmnhomnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmnhomnguyenlieu_PK;
		}

	}
}
