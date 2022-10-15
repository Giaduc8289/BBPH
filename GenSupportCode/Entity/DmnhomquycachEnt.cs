
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

		void BS_DMNHOMQUYCACH_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMNHOMQUYCACH.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMNHOMQUYCACH.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmnhomquycachFields.Manhom.Name].ToString();
					
					txt_MANHOM.Text = _Rowview.Row[DmnhomquycachFields.Manhom.Name].ToString();
					txt_TENNHOM.Text = _Rowview.Row[DmnhomquycachFields.Tennhom.Name].ToString();
					txt_TENRUTGON.Text = _Rowview.Row[DmnhomquycachFields.Tenrutgon.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmnhomquycachFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmnhomquycachFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmnhomquycachFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmnhomquycachFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMNHOMQUYCACH_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMNHOMQUYCACH_PK)
		{
			DmnhomquycachEntity _dmnhomquycachEntity = new DmnhomquycachEntity();
			
			_dmnhomquycachEntity.Manhom = txt_MANHOM.Text.Trim();
			_dmnhomquycachEntity.Tennhom = txt_TENNHOM.Text.Trim();
			_dmnhomquycachEntity.Tenrutgon = txt_TENRUTGON.Text.Trim();
			_dmnhomquycachEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dmnhomquycachEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dmnhomquycachEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dmnhomquycachEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMNHOMQUYCACH_PK))
			{
				_str_DMNHOMQUYCACH_PK = _DmnhomquycachManager.InsertV2(_dmnhomquycachEntity, r_Insert, DT_DMNHOMQUYCACH, BS_DMNHOMQUYCACH);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnhomquycachManager.Convert(_dmnhomquycachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMNHOMQUYCACH.ResetCurrentItem();
			}
			else
			{
				_DmnhomquycachManager.Update(_dmnhomquycachEntity);
				
				GRID_DMNHOMQUYCACH.CurrentRow.Cells[DmnhomquycachFields.Manhom.Name].Value = _dmnhomquycachEntity.Manhom;
				GRID_DMNHOMQUYCACH.CurrentRow.Cells[DmnhomquycachFields.Tennhom.Name].Value = _dmnhomquycachEntity.Tennhom;
				GRID_DMNHOMQUYCACH.CurrentRow.Cells[DmnhomquycachFields.Tenrutgon.Name].Value = _dmnhomquycachEntity.Tenrutgon;
				GRID_DMNHOMQUYCACH.CurrentRow.Cells[DmnhomquycachFields.Ngaytao.Name].Value = _dmnhomquycachEntity.Ngaytao;
				GRID_DMNHOMQUYCACH.CurrentRow.Cells[DmnhomquycachFields.Nguoitao.Name].Value = _dmnhomquycachEntity.Nguoitao;
				GRID_DMNHOMQUYCACH.CurrentRow.Cells[DmnhomquycachFields.Ngaysua.Name].Value = _dmnhomquycachEntity.Ngaysua;
				GRID_DMNHOMQUYCACH.CurrentRow.Cells[DmnhomquycachFields.Nguoisua.Name].Value = _dmnhomquycachEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnhomquycachManager.Convert(_dmnhomquycachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMNHOMQUYCACH_PK;
		}

	}
}
