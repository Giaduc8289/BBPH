
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.KehoachhoanthienEnt
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
	public class KehoachhoanthienEnt : KehoachhoanthienEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KehoachhoanthienEnt()
		{
			// Nothing for now.
		}

		void BS_KEHOACHHOANTHIEN_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_KEHOACHHOANTHIEN.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_KEHOACHHOANTHIEN.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KehoachhoanthienFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[KehoachhoanthienFields.Id.Name].ToString();
					txt_SOLENHSX.Text = _Rowview.Row[KehoachhoanthienFields.Solenhsx.Name].ToString();
					txt_NGAYDAT.Text = _Rowview.Row[KehoachhoanthienFields.Ngaydat.Name].ToString();
					txt_NGAYGIAO.Text = _Rowview.Row[KehoachhoanthienFields.Ngaygiao.Name].ToString();
					txt_MASANPHAM.Text = _Rowview.Row[KehoachhoanthienFields.Masanpham.Name].ToString();
					txt_MAMAY.Text = _Rowview.Row[KehoachhoanthienFields.Mamay.Name].ToString();
					txt_NGAYCHAY.Text = _Rowview.Row[KehoachhoanthienFields.Ngaychay.Name].ToString();
					txt_CA.Text = _Rowview.Row[KehoachhoanthienFields.Ca.Name].ToString();
					txt_SOLUONG.Text = _Rowview.Row[KehoachhoanthienFields.Soluong.Name].ToString();
					txt_SOMET.Text = _Rowview.Row[KehoachhoanthienFields.Somet.Name].ToString();
					txt_SOKG.Text = _Rowview.Row[KehoachhoanthienFields.Sokg.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KehoachhoanthienFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KehoachhoanthienFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KehoachhoanthienFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KehoachhoanthienFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KEHOACHHOANTHIEN_CurrentChanged"); }
		}

		private string Save_Data(string _str_KEHOACHHOANTHIEN_PK)
		{
			KehoachhoanthienEntity _KehoachhoanthienEntity = new KehoachhoanthienEntity();
			try { _KehoachhoanthienEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			_KehoachhoanthienEntity.Solenhsx = txt_SOLENHSX.Text.Trim();
			try { _KehoachhoanthienEntity.Ngaydat = System.DateTime.Parse(txt_NGAYDAT.Text.Trim()); } 
			catch { }
			try { _KehoachhoanthienEntity.Ngaygiao = System.DateTime.Parse(txt_NGAYGIAO.Text.Trim()); } 
			catch { }
			_KehoachhoanthienEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_KehoachhoanthienEntity.Mamay = txt_MAMAY.Text.Trim();
			try { _KehoachhoanthienEntity.Ngaychay = System.DateTime.Parse(txt_NGAYCHAY.Text.Trim()); } 
			catch { }
			try { _KehoachhoanthienEntity.Ca = System.Int32.Parse(txt_CA.Text.Trim()); } 
			catch { }
			try { _KehoachhoanthienEntity.Soluong = System.Int32.Parse(txt_SOLUONG.Text.Trim()); } 
			catch { }
			try { _KehoachhoanthienEntity.Somet = System.Decimal.Parse(txt_SOMET.Text.Trim()); } 
			catch { }
			try { _KehoachhoanthienEntity.Sokg = System.Decimal.Parse(txt_SOKG.Text.Trim()); } 
			catch { }
			try { _KehoachhoanthienEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_KehoachhoanthienEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _KehoachhoanthienEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_KehoachhoanthienEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_KEHOACHHOANTHIEN_PK))
			{
				_str_KEHOACHHOANTHIEN_PK = _KehoachhoanthienManager.InsertV2(_KehoachhoanthienEntity, r_Insert, DT_KEHOACHHOANTHIEN, BS_KEHOACHHOANTHIEN);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KehoachhoanthienManager.Convert(_KehoachhoanthienEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KEHOACHHOANTHIEN.ResetCurrentItem();
			}
			else
			{
				_KehoachhoanthienManager.Update(_KehoachhoanthienEntity);
				
				GRID_KEHOACHHOANTHIEN.CurrentRow.Cells[KehoachhoanthienFields.Id.Name].Value = _KehoachhoanthienEntity.Id;
				GRID_KEHOACHHOANTHIEN.CurrentRow.Cells[KehoachhoanthienFields.Solenhsx.Name].Value = _KehoachhoanthienEntity.Solenhsx;
				GRID_KEHOACHHOANTHIEN.CurrentRow.Cells[KehoachhoanthienFields.Ngaydat.Name].Value = _KehoachhoanthienEntity.Ngaydat;
				GRID_KEHOACHHOANTHIEN.CurrentRow.Cells[KehoachhoanthienFields.Ngaygiao.Name].Value = _KehoachhoanthienEntity.Ngaygiao;
				GRID_KEHOACHHOANTHIEN.CurrentRow.Cells[KehoachhoanthienFields.Masanpham.Name].Value = _KehoachhoanthienEntity.Masanpham;
				GRID_KEHOACHHOANTHIEN.CurrentRow.Cells[KehoachhoanthienFields.Mamay.Name].Value = _KehoachhoanthienEntity.Mamay;
				GRID_KEHOACHHOANTHIEN.CurrentRow.Cells[KehoachhoanthienFields.Ngaychay.Name].Value = _KehoachhoanthienEntity.Ngaychay;
				GRID_KEHOACHHOANTHIEN.CurrentRow.Cells[KehoachhoanthienFields.Ca.Name].Value = _KehoachhoanthienEntity.Ca;
				GRID_KEHOACHHOANTHIEN.CurrentRow.Cells[KehoachhoanthienFields.Soluong.Name].Value = _KehoachhoanthienEntity.Soluong;
				GRID_KEHOACHHOANTHIEN.CurrentRow.Cells[KehoachhoanthienFields.Somet.Name].Value = _KehoachhoanthienEntity.Somet;
				GRID_KEHOACHHOANTHIEN.CurrentRow.Cells[KehoachhoanthienFields.Sokg.Name].Value = _KehoachhoanthienEntity.Sokg;
				GRID_KEHOACHHOANTHIEN.CurrentRow.Cells[KehoachhoanthienFields.Ngaytao.Name].Value = _KehoachhoanthienEntity.Ngaytao;
				GRID_KEHOACHHOANTHIEN.CurrentRow.Cells[KehoachhoanthienFields.Nguoitao.Name].Value = _KehoachhoanthienEntity.Nguoitao;
				GRID_KEHOACHHOANTHIEN.CurrentRow.Cells[KehoachhoanthienFields.Ngaysua.Name].Value = _KehoachhoanthienEntity.Ngaysua;
				GRID_KEHOACHHOANTHIEN.CurrentRow.Cells[KehoachhoanthienFields.Nguoisua.Name].Value = _KehoachhoanthienEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KehoachhoanthienManager.Convert(_KehoachhoanthienEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KEHOACHHOANTHIEN_PK;
		}

	}
}
