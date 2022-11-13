
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

		void BS_SODUMANG_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_SODUMANG.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_SODUMANG.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[SodumangFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[SodumangFields.Id.Name].ToString();
					txt_NGAYKIEMKE.Text = _Rowview.Row[SodumangFields.Ngaykiemke.Name].ToString();
					txt_MAKHO.Text = _Rowview.Row[SodumangFields.Makho.Name].ToString();
					txt_TENKHO.Text = _Rowview.Row[SodumangFields.Tenkho.Name].ToString();
					txt_MAMANG.Text = _Rowview.Row[SodumangFields.Mamang.Name].ToString();
					txt_TENMANG.Text = _Rowview.Row[SodumangFields.Tenmang.Name].ToString();
					txt_SOMET.Text = _Rowview.Row[SodumangFields.Somet.Name].ToString();
					txt_SOKG.Text = _Rowview.Row[SodumangFields.Sokg.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[SodumangFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[SodumangFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[SodumangFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[SodumangFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_SODUMANG_CurrentChanged"); }
		}

		private string Save_Data(string _str_SODUMANG_PK)
		{
			SodumangEntity _SodumangEntity = new SodumangEntity();
			try { _SodumangEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			try { _SodumangEntity.Ngaykiemke = System.DateTime.Parse(txt_NGAYKIEMKE.Text.Trim()); } 
			catch { }
			_SodumangEntity.Makho = txt_MAKHO.Text.Trim();
			_SodumangEntity.Tenkho = txt_TENKHO.Text.Trim();
			_SodumangEntity.Mamang = txt_MAMANG.Text.Trim();
			_SodumangEntity.Tenmang = txt_TENMANG.Text.Trim();
			try { _SodumangEntity.Somet = System.Decimal.Parse(txt_SOMET.Text.Trim()); } 
			catch { }
			try { _SodumangEntity.Sokg = System.Decimal.Parse(txt_SOKG.Text.Trim()); } 
			catch { }
			try { _SodumangEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_SodumangEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _SodumangEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_SodumangEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_SODUMANG_PK))
			{
				_str_SODUMANG_PK = _SodumangManager.InsertV2(_SodumangEntity, r_Insert, DT_SODUMANG, BS_SODUMANG);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodumangManager.Convert(_SodumangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_SODUMANG.ResetCurrentItem();
			}
			else
			{
				_SodumangManager.Update(_SodumangEntity);
				
				GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Id.Name].Value = _SodumangEntity.Id;
				GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Ngaykiemke.Name].Value = _SodumangEntity.Ngaykiemke;
				GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Makho.Name].Value = _SodumangEntity.Makho;
				GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Tenkho.Name].Value = _SodumangEntity.Tenkho;
				GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Mamang.Name].Value = _SodumangEntity.Mamang;
				GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Tenmang.Name].Value = _SodumangEntity.Tenmang;
				GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Somet.Name].Value = _SodumangEntity.Somet;
				GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Sokg.Name].Value = _SodumangEntity.Sokg;
				GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Ngaytao.Name].Value = _SodumangEntity.Ngaytao;
				GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Nguoitao.Name].Value = _SodumangEntity.Nguoitao;
				GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Ngaysua.Name].Value = _SodumangEntity.Ngaysua;
				GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Nguoisua.Name].Value = _SodumangEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodumangManager.Convert(_SodumangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_SODUMANG_PK;
		}

	}
}
