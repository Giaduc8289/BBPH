
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.KehoachghepEnt
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
	public class KehoachghepEnt : KehoachghepEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KehoachghepEnt()
		{
			// Nothing for now.
		}

		void BS_KEHOACHGHEP_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_KEHOACHGHEP.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_KEHOACHGHEP.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KehoachghepFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[KehoachghepFields.Id.Name].ToString();
					txt_SOLENHSX.Text = _Rowview.Row[KehoachghepFields.Solenhsx.Name].ToString();
					txt_NGAYDAT.Text = _Rowview.Row[KehoachghepFields.Ngaydat.Name].ToString();
					txt_NGAYGIAO.Text = _Rowview.Row[KehoachghepFields.Ngaygiao.Name].ToString();
					txt_MASANPHAM.Text = _Rowview.Row[KehoachghepFields.Masanpham.Name].ToString();
					txt_MAMAY.Text = _Rowview.Row[KehoachghepFields.Mamay.Name].ToString();
					txt_NGAYCHAY.Text = _Rowview.Row[KehoachghepFields.Ngaychay.Name].ToString();
					txt_CA.Text = _Rowview.Row[KehoachghepFields.Ca.Name].ToString();
					txt_SOMET.Text = _Rowview.Row[KehoachghepFields.Somet.Name].ToString();
					txt_SOKG.Text = _Rowview.Row[KehoachghepFields.Sokg.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KehoachghepFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KehoachghepFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KehoachghepFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KehoachghepFields.Nguoisua.Name].ToString();
					txt_SOMETDUKIEN.Text = _Rowview.Row[KehoachghepFields.Sometdukien.Name].ToString();
					txt_SOKGDUKIEN.Text = _Rowview.Row[KehoachghepFields.Sokgdukien.Name].ToString();
					txt_SOLUONG.Text = _Rowview.Row[KehoachghepFields.Soluong.Name].ToString();
					txt_SLDUKIEN.Text = _Rowview.Row[KehoachghepFields.Sldukien.Name].ToString();
					txt_TGDUKIEN.Text = _Rowview.Row[KehoachghepFields.Tgdukien.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KEHOACHGHEP_CurrentChanged"); }
		}

		private string Save_Data(string _str_KEHOACHGHEP_PK)
		{
			KehoachghepEntity _KehoachghepEntity = new KehoachghepEntity();
			try { _KehoachghepEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			_KehoachghepEntity.Solenhsx = txt_SOLENHSX.Text.Trim();
			try { _KehoachghepEntity.Ngaydat = System.DateTime.Parse(txt_NGAYDAT.Text.Trim()); } 
			catch { }
			try { _KehoachghepEntity.Ngaygiao = System.DateTime.Parse(txt_NGAYGIAO.Text.Trim()); } 
			catch { }
			_KehoachghepEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_KehoachghepEntity.Mamay = txt_MAMAY.Text.Trim();
			try { _KehoachghepEntity.Ngaychay = System.DateTime.Parse(txt_NGAYCHAY.Text.Trim()); } 
			catch { }
			try { _KehoachghepEntity.Ca = System.Int32.Parse(txt_CA.Text.Trim()); } 
			catch { }
			try { _KehoachghepEntity.Somet = System.Decimal.Parse(txt_SOMET.Text.Trim()); } 
			catch { }
			try { _KehoachghepEntity.Sokg = System.Decimal.Parse(txt_SOKG.Text.Trim()); } 
			catch { }
			try { _KehoachghepEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_KehoachghepEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _KehoachghepEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_KehoachghepEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			try { _KehoachghepEntity.Sometdukien = System.Decimal.Parse(txt_SOMETDUKIEN.Text.Trim()); } 
			catch { }
			try { _KehoachghepEntity.Sokgdukien = System.Decimal.Parse(txt_SOKGDUKIEN.Text.Trim()); } 
			catch { }
			try { _KehoachghepEntity.Soluong = System.Int32.Parse(txt_SOLUONG.Text.Trim()); } 
			catch { }
			try { _KehoachghepEntity.Sldukien = System.Int32.Parse(txt_SLDUKIEN.Text.Trim()); } 
			catch { }
			try { _KehoachghepEntity.Tgdukien = System.Int32.Parse(txt_TGDUKIEN.Text.Trim()); } 
			catch { }
			
			
			if (string.IsNullOrEmpty(_str_KEHOACHGHEP_PK))
			{
				_str_KEHOACHGHEP_PK = _KehoachghepManager.InsertV2(_KehoachghepEntity, r_Insert, DT_KEHOACHGHEP, BS_KEHOACHGHEP);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KehoachghepManager.Convert(_KehoachghepEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KEHOACHGHEP.ResetCurrentItem();
			}
			else
			{
				_KehoachghepManager.Update(_KehoachghepEntity);
				
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Id.Name].Value = _KehoachghepEntity.Id;
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Solenhsx.Name].Value = _KehoachghepEntity.Solenhsx;
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Ngaydat.Name].Value = _KehoachghepEntity.Ngaydat;
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Ngaygiao.Name].Value = _KehoachghepEntity.Ngaygiao;
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Masanpham.Name].Value = _KehoachghepEntity.Masanpham;
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Mamay.Name].Value = _KehoachghepEntity.Mamay;
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Ngaychay.Name].Value = _KehoachghepEntity.Ngaychay;
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Ca.Name].Value = _KehoachghepEntity.Ca;
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Somet.Name].Value = _KehoachghepEntity.Somet;
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Sokg.Name].Value = _KehoachghepEntity.Sokg;
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Ngaytao.Name].Value = _KehoachghepEntity.Ngaytao;
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Nguoitao.Name].Value = _KehoachghepEntity.Nguoitao;
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Ngaysua.Name].Value = _KehoachghepEntity.Ngaysua;
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Nguoisua.Name].Value = _KehoachghepEntity.Nguoisua;
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Sometdukien.Name].Value = _KehoachghepEntity.Sometdukien;
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Sokgdukien.Name].Value = _KehoachghepEntity.Sokgdukien;
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Soluong.Name].Value = _KehoachghepEntity.Soluong;
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Sldukien.Name].Value = _KehoachghepEntity.Sldukien;
				GRID_KEHOACHGHEP.CurrentRow.Cells[KehoachghepFields.Tgdukien.Name].Value = _KehoachghepEntity.Tgdukien;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KehoachghepManager.Convert(_KehoachghepEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KEHOACHGHEP_PK;
		}

	}
}
