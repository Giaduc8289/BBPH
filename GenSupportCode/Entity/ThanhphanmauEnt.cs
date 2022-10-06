
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.ThanhphanmauEnt
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
	public class ThanhphanmauEnt : ThanhphanmauEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ThanhphanmauEnt()
		{
			// Nothing for now.
		}

		void BS_Thanhphanmau_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Thanhphanmau.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Thanhphanmau.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[ThanhphanmauFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[ThanhphanmauFields.Id.Name].ToString();
					txt_Mamau.Text = _Rowview.Row[ThanhphanmauFields.Mamau.Name].ToString();
					txt_Tenmau.Text = _Rowview.Row[ThanhphanmauFields.Tenmau.Name].ToString();
					txt_Mausudung.Text = _Rowview.Row[ThanhphanmauFields.Mausudung.Name].ToString();
					txt_Tenmausudung.Text = _Rowview.Row[ThanhphanmauFields.Tenmausudung.Name].ToString();
					txt_Tyle.Text = _Rowview.Row[ThanhphanmauFields.Tyle.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[ThanhphanmauFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[ThanhphanmauFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[ThanhphanmauFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[ThanhphanmauFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Thanhphanmau_CurrentChanged"); }
		}

		private string Save_Data(string _str_Thanhphanmau_PK)
		{
			ThanhphanmauEntity _thanhphanmauEntity = new ThanhphanmauEntity();
			
			_thanhphanmau.Id = txt_Id.Text.Trim();
			_thanhphanmau.Mamau = txt_Mamau.Text.Trim();
			_thanhphanmau.Tenmau = txt_Tenmau.Text.Trim();
			_thanhphanmau.Mausudung = txt_Mausudung.Text.Trim();
			_thanhphanmau.Tenmausudung = txt_Tenmausudung.Text.Trim();
			_thanhphanmau.Tyle = txt_Tyle.Text.Trim();
			_thanhphanmau.Ngaytao = txt_Ngaytao.Text.Trim();
			_thanhphanmau.Nguoitao = txt_Nguoitao.Text.Trim();
			_thanhphanmau.Ngaysua = txt_Ngaysua.Text.Trim();
			_thanhphanmau.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Thanhphanmau_PK = _ThanhphanmauManager.InsertV2(_ThanhphanmauEntity, r_Insert, DT_Thanhphanmau, BS_Thanhphanmau);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_ThanhphanmauManager.Convert(_thanhphanmauEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Thanhphanmau.ResetCurrentItem();
			}
			else
			{
				_ThanhphanmauManager.Update(_thanhphanmauEntity);
				
				GRID_Thanhphanmau.CurrentRow.Cells[ThanhphanmauFields.Id.Name].Value = _thanhphanmauEntity.Id;
				GRID_Thanhphanmau.CurrentRow.Cells[ThanhphanmauFields.Mamau.Name].Value = _thanhphanmauEntity.Mamau;
				GRID_Thanhphanmau.CurrentRow.Cells[ThanhphanmauFields.Tenmau.Name].Value = _thanhphanmauEntity.Tenmau;
				GRID_Thanhphanmau.CurrentRow.Cells[ThanhphanmauFields.Mausudung.Name].Value = _thanhphanmauEntity.Mausudung;
				GRID_Thanhphanmau.CurrentRow.Cells[ThanhphanmauFields.Tenmausudung.Name].Value = _thanhphanmauEntity.Tenmausudung;
				GRID_Thanhphanmau.CurrentRow.Cells[ThanhphanmauFields.Tyle.Name].Value = _thanhphanmauEntity.Tyle;
				GRID_Thanhphanmau.CurrentRow.Cells[ThanhphanmauFields.Ngaytao.Name].Value = _thanhphanmauEntity.Ngaytao;
				GRID_Thanhphanmau.CurrentRow.Cells[ThanhphanmauFields.Nguoitao.Name].Value = _thanhphanmauEntity.Nguoitao;
				GRID_Thanhphanmau.CurrentRow.Cells[ThanhphanmauFields.Ngaysua.Name].Value = _thanhphanmauEntity.Ngaysua;
				GRID_Thanhphanmau.CurrentRow.Cells[ThanhphanmauFields.Nguoisua.Name].Value = _thanhphanmauEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_ThanhphanmauManager.Convert(_thanhphanmauEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Thanhphanmau_PK;
		}

	}
}
