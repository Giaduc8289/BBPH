
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.KehoachtuaEnt
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
	public class KehoachtuaEnt : KehoachtuaEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KehoachtuaEnt()
		{
			// Nothing for now.
		}

		void BS_KEHOACHTUA_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_KEHOACHTUA.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_KEHOACHTUA.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KehoachtuaFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[KehoachtuaFields.Id.Name].ToString();
					txt_SOLENHSX.Text = _Rowview.Row[KehoachtuaFields.Solenhsx.Name].ToString();
					txt_NGAYDAT.Text = _Rowview.Row[KehoachtuaFields.Ngaydat.Name].ToString();
					txt_NGAYGIAO.Text = _Rowview.Row[KehoachtuaFields.Ngaygiao.Name].ToString();
					txt_MASANPHAM.Text = _Rowview.Row[KehoachtuaFields.Masanpham.Name].ToString();
					txt_MAMAY.Text = _Rowview.Row[KehoachtuaFields.Mamay.Name].ToString();
					txt_NGAYCHAY.Text = _Rowview.Row[KehoachtuaFields.Ngaychay.Name].ToString();
					txt_CA.Text = _Rowview.Row[KehoachtuaFields.Ca.Name].ToString();
					txt_SOMET.Text = _Rowview.Row[KehoachtuaFields.Somet.Name].ToString();
					txt_SOKG.Text = _Rowview.Row[KehoachtuaFields.Sokg.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KehoachtuaFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KehoachtuaFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KehoachtuaFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KehoachtuaFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KEHOACHTUA_CurrentChanged"); }
		}

		private string Save_Data(string _str_KEHOACHTUA_PK)
		{
			KehoachtuaEntity _KehoachtuaEntity = new KehoachtuaEntity();
			try { _KehoachtuaEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			_KehoachtuaEntity.Solenhsx = txt_SOLENHSX.Text.Trim();
			try { _KehoachtuaEntity.Ngaydat = System.DateTime.Parse(txt_NGAYDAT.Text.Trim()); } 
			catch { }
			try { _KehoachtuaEntity.Ngaygiao = System.DateTime.Parse(txt_NGAYGIAO.Text.Trim()); } 
			catch { }
			_KehoachtuaEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_KehoachtuaEntity.Mamay = txt_MAMAY.Text.Trim();
			try { _KehoachtuaEntity.Ngaychay = System.DateTime.Parse(txt_NGAYCHAY.Text.Trim()); } 
			catch { }
			try { _KehoachtuaEntity.Ca = System.Int32.Parse(txt_CA.Text.Trim()); } 
			catch { }
			try { _KehoachtuaEntity.Somet = System.Decimal.Parse(txt_SOMET.Text.Trim()); } 
			catch { }
			try { _KehoachtuaEntity.Sokg = System.Decimal.Parse(txt_SOKG.Text.Trim()); } 
			catch { }
			try { _KehoachtuaEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_KehoachtuaEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _KehoachtuaEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_KehoachtuaEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_KEHOACHTUA_PK))
			{
				_str_KEHOACHTUA_PK = _KehoachtuaManager.InsertV2(_KehoachtuaEntity, r_Insert, DT_KEHOACHTUA, BS_KEHOACHTUA);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KehoachtuaManager.Convert(_KehoachtuaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KEHOACHTUA.ResetCurrentItem();
			}
			else
			{
				_KehoachtuaManager.Update(_KehoachtuaEntity);
				
				GRID_KEHOACHTUA.CurrentRow.Cells[KehoachtuaFields.Id.Name].Value = _KehoachtuaEntity.Id;
				GRID_KEHOACHTUA.CurrentRow.Cells[KehoachtuaFields.Solenhsx.Name].Value = _KehoachtuaEntity.Solenhsx;
				GRID_KEHOACHTUA.CurrentRow.Cells[KehoachtuaFields.Ngaydat.Name].Value = _KehoachtuaEntity.Ngaydat;
				GRID_KEHOACHTUA.CurrentRow.Cells[KehoachtuaFields.Ngaygiao.Name].Value = _KehoachtuaEntity.Ngaygiao;
				GRID_KEHOACHTUA.CurrentRow.Cells[KehoachtuaFields.Masanpham.Name].Value = _KehoachtuaEntity.Masanpham;
				GRID_KEHOACHTUA.CurrentRow.Cells[KehoachtuaFields.Mamay.Name].Value = _KehoachtuaEntity.Mamay;
				GRID_KEHOACHTUA.CurrentRow.Cells[KehoachtuaFields.Ngaychay.Name].Value = _KehoachtuaEntity.Ngaychay;
				GRID_KEHOACHTUA.CurrentRow.Cells[KehoachtuaFields.Ca.Name].Value = _KehoachtuaEntity.Ca;
				GRID_KEHOACHTUA.CurrentRow.Cells[KehoachtuaFields.Somet.Name].Value = _KehoachtuaEntity.Somet;
				GRID_KEHOACHTUA.CurrentRow.Cells[KehoachtuaFields.Sokg.Name].Value = _KehoachtuaEntity.Sokg;
				GRID_KEHOACHTUA.CurrentRow.Cells[KehoachtuaFields.Ngaytao.Name].Value = _KehoachtuaEntity.Ngaytao;
				GRID_KEHOACHTUA.CurrentRow.Cells[KehoachtuaFields.Nguoitao.Name].Value = _KehoachtuaEntity.Nguoitao;
				GRID_KEHOACHTUA.CurrentRow.Cells[KehoachtuaFields.Ngaysua.Name].Value = _KehoachtuaEntity.Ngaysua;
				GRID_KEHOACHTUA.CurrentRow.Cells[KehoachtuaFields.Nguoisua.Name].Value = _KehoachtuaEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KehoachtuaManager.Convert(_KehoachtuaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KEHOACHTUA_PK;
		}

	}
}
