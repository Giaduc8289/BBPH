
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.KehoachthoiEnt
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
	public class KehoachthoiEnt : KehoachthoiEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KehoachthoiEnt()
		{
			// Nothing for now.
		}

		void BS_KEHOACHTHOI_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_KEHOACHTHOI.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_KEHOACHTHOI.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KehoachthoiFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[KehoachthoiFields.Id.Name].ToString();
					txt_SOLENHSX.Text = _Rowview.Row[KehoachthoiFields.Solenhsx.Name].ToString();
					txt_NGAYDAT.Text = _Rowview.Row[KehoachthoiFields.Ngaydat.Name].ToString();
					txt_NGAYGIAO.Text = _Rowview.Row[KehoachthoiFields.Ngaygiao.Name].ToString();
					txt_MAMANG.Text = _Rowview.Row[KehoachthoiFields.Mamang.Name].ToString();
					txt_MAMAY.Text = _Rowview.Row[KehoachthoiFields.Mamay.Name].ToString();
					txt_NGAYCHAY.Text = _Rowview.Row[KehoachthoiFields.Ngaychay.Name].ToString();
					txt_CA.Text = _Rowview.Row[KehoachthoiFields.Ca.Name].ToString();
					txt_SOMET.Text = _Rowview.Row[KehoachthoiFields.Somet.Name].ToString();
					txt_SOKG.Text = _Rowview.Row[KehoachthoiFields.Sokg.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KehoachthoiFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KehoachthoiFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KehoachthoiFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KehoachthoiFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KEHOACHTHOI_CurrentChanged"); }
		}

		private string Save_Data(string _str_KEHOACHTHOI_PK)
		{
			KehoachthoiEntity _KehoachthoiEntity = new KehoachthoiEntity();
			try { _KehoachthoiEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			_KehoachthoiEntity.Solenhsx = txt_SOLENHSX.Text.Trim();
			try { _KehoachthoiEntity.Ngaydat = System.DateTime.Parse(txt_NGAYDAT.Text.Trim()); } 
			catch { }
			try { _KehoachthoiEntity.Ngaygiao = System.DateTime.Parse(txt_NGAYGIAO.Text.Trim()); } 
			catch { }
			_KehoachthoiEntity.Mamang = txt_MAMANG.Text.Trim();
			_KehoachthoiEntity.Mamay = txt_MAMAY.Text.Trim();
			try { _KehoachthoiEntity.Ngaychay = System.DateTime.Parse(txt_NGAYCHAY.Text.Trim()); } 
			catch { }
			try { _KehoachthoiEntity.Ca = System.Int32.Parse(txt_CA.Text.Trim()); } 
			catch { }
			try { _KehoachthoiEntity.Somet = System.Decimal.Parse(txt_SOMET.Text.Trim()); } 
			catch { }
			try { _KehoachthoiEntity.Sokg = System.Decimal.Parse(txt_SOKG.Text.Trim()); } 
			catch { }
			try { _KehoachthoiEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_KehoachthoiEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _KehoachthoiEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_KehoachthoiEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_KEHOACHTHOI_PK))
			{
				_str_KEHOACHTHOI_PK = _KehoachthoiManager.InsertV2(_KehoachthoiEntity, r_Insert, DT_KEHOACHTHOI, BS_KEHOACHTHOI);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KehoachthoiManager.Convert(_KehoachthoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KEHOACHTHOI.ResetCurrentItem();
			}
			else
			{
				_KehoachthoiManager.Update(_KehoachthoiEntity);
				
				GRID_KEHOACHTHOI.CurrentRow.Cells[KehoachthoiFields.Id.Name].Value = _KehoachthoiEntity.Id;
				GRID_KEHOACHTHOI.CurrentRow.Cells[KehoachthoiFields.Solenhsx.Name].Value = _KehoachthoiEntity.Solenhsx;
				GRID_KEHOACHTHOI.CurrentRow.Cells[KehoachthoiFields.Ngaydat.Name].Value = _KehoachthoiEntity.Ngaydat;
				GRID_KEHOACHTHOI.CurrentRow.Cells[KehoachthoiFields.Ngaygiao.Name].Value = _KehoachthoiEntity.Ngaygiao;
				GRID_KEHOACHTHOI.CurrentRow.Cells[KehoachthoiFields.Mamang.Name].Value = _KehoachthoiEntity.Mamang;
				GRID_KEHOACHTHOI.CurrentRow.Cells[KehoachthoiFields.Mamay.Name].Value = _KehoachthoiEntity.Mamay;
				GRID_KEHOACHTHOI.CurrentRow.Cells[KehoachthoiFields.Ngaychay.Name].Value = _KehoachthoiEntity.Ngaychay;
				GRID_KEHOACHTHOI.CurrentRow.Cells[KehoachthoiFields.Ca.Name].Value = _KehoachthoiEntity.Ca;
				GRID_KEHOACHTHOI.CurrentRow.Cells[KehoachthoiFields.Somet.Name].Value = _KehoachthoiEntity.Somet;
				GRID_KEHOACHTHOI.CurrentRow.Cells[KehoachthoiFields.Sokg.Name].Value = _KehoachthoiEntity.Sokg;
				GRID_KEHOACHTHOI.CurrentRow.Cells[KehoachthoiFields.Ngaytao.Name].Value = _KehoachthoiEntity.Ngaytao;
				GRID_KEHOACHTHOI.CurrentRow.Cells[KehoachthoiFields.Nguoitao.Name].Value = _KehoachthoiEntity.Nguoitao;
				GRID_KEHOACHTHOI.CurrentRow.Cells[KehoachthoiFields.Ngaysua.Name].Value = _KehoachthoiEntity.Ngaysua;
				GRID_KEHOACHTHOI.CurrentRow.Cells[KehoachthoiFields.Nguoisua.Name].Value = _KehoachthoiEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KehoachthoiManager.Convert(_KehoachthoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KEHOACHTHOI_PK;
		}

	}
}
