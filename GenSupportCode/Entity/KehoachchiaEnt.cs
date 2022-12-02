
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.KehoachchiaEnt
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
	public class KehoachchiaEnt : KehoachchiaEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KehoachchiaEnt()
		{
			// Nothing for now.
		}

		void BS_KEHOACHCHIA_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_KEHOACHCHIA.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_KEHOACHCHIA.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KehoachchiaFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[KehoachchiaFields.Id.Name].ToString();
					txt_SOLENHSX.Text = _Rowview.Row[KehoachchiaFields.Solenhsx.Name].ToString();
					txt_NGAYDAT.Text = _Rowview.Row[KehoachchiaFields.Ngaydat.Name].ToString();
					txt_NGAYGIAO.Text = _Rowview.Row[KehoachchiaFields.Ngaygiao.Name].ToString();
					txt_MASANPHAM.Text = _Rowview.Row[KehoachchiaFields.Masanpham.Name].ToString();
					txt_MAMAY.Text = _Rowview.Row[KehoachchiaFields.Mamay.Name].ToString();
					txt_NGAYCHAY.Text = _Rowview.Row[KehoachchiaFields.Ngaychay.Name].ToString();
					txt_CA.Text = _Rowview.Row[KehoachchiaFields.Ca.Name].ToString();
					txt_SOMET.Text = _Rowview.Row[KehoachchiaFields.Somet.Name].ToString();
					txt_SOKG.Text = _Rowview.Row[KehoachchiaFields.Sokg.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KehoachchiaFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KehoachchiaFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KehoachchiaFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KehoachchiaFields.Nguoisua.Name].ToString();
					txt_SOMETDUKIEN.Text = _Rowview.Row[KehoachchiaFields.Sometdukien.Name].ToString();
					txt_SOKGDUKIEN.Text = _Rowview.Row[KehoachchiaFields.Sokgdukien.Name].ToString();
					txt_SOLUONG.Text = _Rowview.Row[KehoachchiaFields.Soluong.Name].ToString();
					txt_SLDUKIEN.Text = _Rowview.Row[KehoachchiaFields.Sldukien.Name].ToString();
					txt_TGDUKIEN.Text = _Rowview.Row[KehoachchiaFields.Tgdukien.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KEHOACHCHIA_CurrentChanged"); }
		}

		private string Save_Data(string _str_KEHOACHCHIA_PK)
		{
			KehoachchiaEntity _KehoachchiaEntity = new KehoachchiaEntity();
			try { _KehoachchiaEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			_KehoachchiaEntity.Solenhsx = txt_SOLENHSX.Text.Trim();
			try { _KehoachchiaEntity.Ngaydat = System.DateTime.Parse(txt_NGAYDAT.Text.Trim()); } 
			catch { }
			try { _KehoachchiaEntity.Ngaygiao = System.DateTime.Parse(txt_NGAYGIAO.Text.Trim()); } 
			catch { }
			_KehoachchiaEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_KehoachchiaEntity.Mamay = txt_MAMAY.Text.Trim();
			try { _KehoachchiaEntity.Ngaychay = System.DateTime.Parse(txt_NGAYCHAY.Text.Trim()); } 
			catch { }
			try { _KehoachchiaEntity.Ca = System.Int32.Parse(txt_CA.Text.Trim()); } 
			catch { }
			try { _KehoachchiaEntity.Somet = System.Decimal.Parse(txt_SOMET.Text.Trim()); } 
			catch { }
			try { _KehoachchiaEntity.Sokg = System.Decimal.Parse(txt_SOKG.Text.Trim()); } 
			catch { }
			try { _KehoachchiaEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_KehoachchiaEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _KehoachchiaEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_KehoachchiaEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			try { _KehoachchiaEntity.Sometdukien = System.Decimal.Parse(txt_SOMETDUKIEN.Text.Trim()); } 
			catch { }
			try { _KehoachchiaEntity.Sokgdukien = System.Decimal.Parse(txt_SOKGDUKIEN.Text.Trim()); } 
			catch { }
			try { _KehoachchiaEntity.Soluong = System.Int32.Parse(txt_SOLUONG.Text.Trim()); } 
			catch { }
			try { _KehoachchiaEntity.Sldukien = System.Int32.Parse(txt_SLDUKIEN.Text.Trim()); } 
			catch { }
			try { _KehoachchiaEntity.Tgdukien = System.Int32.Parse(txt_TGDUKIEN.Text.Trim()); } 
			catch { }
			
			
			if (string.IsNullOrEmpty(_str_KEHOACHCHIA_PK))
			{
				_str_KEHOACHCHIA_PK = _KehoachchiaManager.InsertV2(_KehoachchiaEntity, r_Insert, DT_KEHOACHCHIA, BS_KEHOACHCHIA);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KehoachchiaManager.Convert(_KehoachchiaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KEHOACHCHIA.ResetCurrentItem();
			}
			else
			{
				_KehoachchiaManager.Update(_KehoachchiaEntity);
				
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Id.Name].Value = _KehoachchiaEntity.Id;
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Solenhsx.Name].Value = _KehoachchiaEntity.Solenhsx;
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Ngaydat.Name].Value = _KehoachchiaEntity.Ngaydat;
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Ngaygiao.Name].Value = _KehoachchiaEntity.Ngaygiao;
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Masanpham.Name].Value = _KehoachchiaEntity.Masanpham;
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Mamay.Name].Value = _KehoachchiaEntity.Mamay;
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Ngaychay.Name].Value = _KehoachchiaEntity.Ngaychay;
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Ca.Name].Value = _KehoachchiaEntity.Ca;
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Somet.Name].Value = _KehoachchiaEntity.Somet;
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Sokg.Name].Value = _KehoachchiaEntity.Sokg;
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Ngaytao.Name].Value = _KehoachchiaEntity.Ngaytao;
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Nguoitao.Name].Value = _KehoachchiaEntity.Nguoitao;
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Ngaysua.Name].Value = _KehoachchiaEntity.Ngaysua;
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Nguoisua.Name].Value = _KehoachchiaEntity.Nguoisua;
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Sometdukien.Name].Value = _KehoachchiaEntity.Sometdukien;
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Sokgdukien.Name].Value = _KehoachchiaEntity.Sokgdukien;
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Soluong.Name].Value = _KehoachchiaEntity.Soluong;
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Sldukien.Name].Value = _KehoachchiaEntity.Sldukien;
				GRID_KEHOACHCHIA.CurrentRow.Cells[KehoachchiaFields.Tgdukien.Name].Value = _KehoachchiaEntity.Tgdukien;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KehoachchiaManager.Convert(_KehoachchiaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KEHOACHCHIA_PK;
		}

	}
}
