
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.SodumangEnt
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
	public class SodumangEnt : SodumangEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SodumangEnt()
		{
			// Nothing for now.
		}

		void BS_Sodumang_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Sodumang.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Sodumang.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[SodumangFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[SodumangFields.Id.Name].ToString();
					txt_Ngaykiemke.Text = _Rowview.Row[SodumangFields.Ngaykiemke.Name].ToString();
					txt_Makho.Text = _Rowview.Row[SodumangFields.Makho.Name].ToString();
					txt_Tenkho.Text = _Rowview.Row[SodumangFields.Tenkho.Name].ToString();
					txt_Mamang.Text = _Rowview.Row[SodumangFields.Mamang.Name].ToString();
					txt_Tenmang.Text = _Rowview.Row[SodumangFields.Tenmang.Name].ToString();
					txt_Somet.Text = _Rowview.Row[SodumangFields.Somet.Name].ToString();
					txt_Sokg.Text = _Rowview.Row[SodumangFields.Sokg.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[SodumangFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[SodumangFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[SodumangFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[SodumangFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Sodumang_CurrentChanged"); }
		}

		private string Save_Data(string _str_Sodumang_PK)
		{
			SodumangEntity _sodumangEntity = new SodumangEntity();
			
			_sodumangEntity.Id = txt_Id.Text.Trim();
			_sodumangEntity.Ngaykiemke = txt_Ngaykiemke.Text.Trim();
			_sodumangEntity.Makho = txt_Makho.Text.Trim();
			_sodumangEntity.Tenkho = txt_Tenkho.Text.Trim();
			_sodumangEntity.Mamang = txt_Mamang.Text.Trim();
			_sodumangEntity.Tenmang = txt_Tenmang.Text.Trim();
			_sodumangEntity.Somet = txt_Somet.Text.Trim();
			_sodumangEntity.Sokg = txt_Sokg.Text.Trim();
			_sodumangEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_sodumangEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_sodumangEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_sodumangEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Sodumang_PK = _SodumangManager.InsertV2(_SodumangEntity, r_Insert, DT_Sodumang, BS_Sodumang);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodumangManager.Convert(_sodumangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Sodumang.ResetCurrentItem();
			}
			else
			{
				_SodumangManager.Update(_sodumangEntity);
				
				GRID_Sodumang.CurrentRow.Cells[SodumangFields.Id.Name].Value = _sodumangEntity.Id;
				GRID_Sodumang.CurrentRow.Cells[SodumangFields.Ngaykiemke.Name].Value = _sodumangEntity.Ngaykiemke;
				GRID_Sodumang.CurrentRow.Cells[SodumangFields.Makho.Name].Value = _sodumangEntity.Makho;
				GRID_Sodumang.CurrentRow.Cells[SodumangFields.Tenkho.Name].Value = _sodumangEntity.Tenkho;
				GRID_Sodumang.CurrentRow.Cells[SodumangFields.Mamang.Name].Value = _sodumangEntity.Mamang;
				GRID_Sodumang.CurrentRow.Cells[SodumangFields.Tenmang.Name].Value = _sodumangEntity.Tenmang;
				GRID_Sodumang.CurrentRow.Cells[SodumangFields.Somet.Name].Value = _sodumangEntity.Somet;
				GRID_Sodumang.CurrentRow.Cells[SodumangFields.Sokg.Name].Value = _sodumangEntity.Sokg;
				GRID_Sodumang.CurrentRow.Cells[SodumangFields.Ngaytao.Name].Value = _sodumangEntity.Ngaytao;
				GRID_Sodumang.CurrentRow.Cells[SodumangFields.Nguoitao.Name].Value = _sodumangEntity.Nguoitao;
				GRID_Sodumang.CurrentRow.Cells[SodumangFields.Ngaysua.Name].Value = _sodumangEntity.Ngaysua;
				GRID_Sodumang.CurrentRow.Cells[SodumangFields.Nguoisua.Name].Value = _sodumangEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodumangManager.Convert(_sodumangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Sodumang_PK;
		}

	}
}
