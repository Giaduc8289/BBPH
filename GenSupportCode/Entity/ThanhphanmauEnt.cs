
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
			ThanhphanmauEntity _ThanhphanmauEntity = new ThanhphanmauEntity();
			
			_ThanhphanmauEntity.Id = txt_ID.Text.Trim();
			_ThanhphanmauEntity.Mamau = txt_MAMAU.Text.Trim();
			_ThanhphanmauEntity.Tenmau = txt_TENMAU.Text.Trim();
			_ThanhphanmauEntity.Mausudung = txt_MAUSUDUNG.Text.Trim();
			_ThanhphanmauEntity.Tenmausudung = txt_TENMAUSUDUNG.Text.Trim();
			_ThanhphanmauEntity.Tyle = txt_TYLE.Text.Trim();
			_ThanhphanmauEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_ThanhphanmauEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_ThanhphanmauEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_ThanhphanmauEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_THANHPHANMAU_PK))
			{
				_str_THANHPHANMAU_PK = _ThanhphanmauManager.InsertV2(_ThanhphanmauEntity, r_Insert, DT_THANHPHANMAU, BS_THANHPHANMAU);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_ThanhphanmauManager.Convert(_ThanhphanmauEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_THANHPHANMAU.ResetCurrentItem();
			}
			else
			{
				_ThanhphanmauManager.Update(_ThanhphanmauEntity);
				
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Id.Name].Value = _ThanhphanmauEntity.Id;
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Mamau.Name].Value = _ThanhphanmauEntity.Mamau;
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Tenmau.Name].Value = _ThanhphanmauEntity.Tenmau;
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Mausudung.Name].Value = _ThanhphanmauEntity.Mausudung;
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Tenmausudung.Name].Value = _ThanhphanmauEntity.Tenmausudung;
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Tyle.Name].Value = _ThanhphanmauEntity.Tyle;
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Ngaytao.Name].Value = _ThanhphanmauEntity.Ngaytao;
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Nguoitao.Name].Value = _ThanhphanmauEntity.Nguoitao;
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Ngaysua.Name].Value = _ThanhphanmauEntity.Ngaysua;
				GRID_THANHPHANMAU.CurrentRow.Cells[ThanhphanmauFields.Nguoisua.Name].Value = _ThanhphanmauEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_ThanhphanmauManager.Convert(_ThanhphanmauEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_THANHPHANMAU_PK;
		}

	}
}
