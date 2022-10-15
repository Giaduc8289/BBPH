
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

		void BS_THANHPHANMAU_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_THANHPHANMAU.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_THANHPHANMAU.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[ThanhphanmauFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[ThanhphanmauFields.Id.Name].ToString();
					txt_MAMAU.Text = _Rowview.Row[ThanhphanmauFields.Mamau.Name].ToString();
					txt_TENMAU.Text = _Rowview.Row[ThanhphanmauFields.Tenmau.Name].ToString();
					txt_MAUSUDUNG.Text = _Rowview.Row[ThanhphanmauFields.Mausudung.Name].ToString();
					txt_TENMAUSUDUNG.Text = _Rowview.Row[ThanhphanmauFields.Tenmausudung.Name].ToString();
					txt_TYLE.Text = _Rowview.Row[ThanhphanmauFields.Tyle.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[ThanhphanmauFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[ThanhphanmauFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[ThanhphanmauFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[ThanhphanmauFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_THANHPHANMAU_CurrentChanged"); }
		}

		private string Save_Data(string _str_THANHPHANMAU_PK)
		{
			ThanhphanmauEntity _thanhphanmauEntity = new ThanhphanmauEntity();
			
			_thanhphanmauEntity.Id = txt_ID.Text.Trim();
			_thanhphanmauEntity.Mamau = txt_MAMAU.Text.Trim();
			_thanhphanmauEntity.Tenmau = txt_TENMAU.Text.Trim();
			_thanhphanmauEntity.Mausudung = txt_MAUSUDUNG.Text.Trim();
			_thanhphanmauEntity.Tenmausudung = txt_TENMAUSUDUNG.Text.Trim();
			_thanhphanmauEntity.Tyle = txt_TYLE.Text.Trim();
			_thanhphanmauEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_thanhphanmauEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_thanhphanmauEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_thanhphanmauEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_THANHPHANMAU_PK))
			{
				_str_THANHPHANMAU_PK = _ThanhphanmauManager.InsertV2(_thanhphanmauEntity, r_Insert, DT_THANHPHANMAU, BS_THANHPHANMAU);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_ThanhphanmauManager.Convert(_thanhphanmauEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_THANHPHANMAU.ResetCurrentItem();
			}
			else
			{
				_ThanhphanmauManager.Update(_thanhphanmauEntity);
				
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Id.Name].Value = _thanhphanmauEntity.Id;
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Mamau.Name].Value = _thanhphanmauEntity.Mamau;
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Tenmau.Name].Value = _thanhphanmauEntity.Tenmau;
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Mausudung.Name].Value = _thanhphanmauEntity.Mausudung;
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Tenmausudung.Name].Value = _thanhphanmauEntity.Tenmausudung;
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Tyle.Name].Value = _thanhphanmauEntity.Tyle;
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Ngaytao.Name].Value = _thanhphanmauEntity.Ngaytao;
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Nguoitao.Name].Value = _thanhphanmauEntity.Nguoitao;
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Ngaysua.Name].Value = _thanhphanmauEntity.Ngaysua;
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Nguoisua.Name].Value = _thanhphanmauEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_ThanhphanmauManager.Convert(_thanhphanmauEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_THANHPHANMAU_PK;
		}

	}
}
