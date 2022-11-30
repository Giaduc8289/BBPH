
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.KehoachlocEnt
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
	public class KehoachlocEnt : KehoachlocEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KehoachlocEnt()
		{
			// Nothing for now.
		}

		void BS_KEHOACHLOC_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_KEHOACHLOC.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_KEHOACHLOC.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KehoachlocFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[KehoachlocFields.Id.Name].ToString();
					txt_SOLENHSX.Text = _Rowview.Row[KehoachlocFields.Solenhsx.Name].ToString();
					txt_NGAYDAT.Text = _Rowview.Row[KehoachlocFields.Ngaydat.Name].ToString();
					txt_NGAYGIAO.Text = _Rowview.Row[KehoachlocFields.Ngaygiao.Name].ToString();
					txt_MASANPHAM.Text = _Rowview.Row[KehoachlocFields.Masanpham.Name].ToString();
					txt_MAMAY.Text = _Rowview.Row[KehoachlocFields.Mamay.Name].ToString();
					txt_NGAYCHAY.Text = _Rowview.Row[KehoachlocFields.Ngaychay.Name].ToString();
					txt_CA.Text = _Rowview.Row[KehoachlocFields.Ca.Name].ToString();
					txt_SOMET.Text = _Rowview.Row[KehoachlocFields.Somet.Name].ToString();
					txt_SOKG.Text = _Rowview.Row[KehoachlocFields.Sokg.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KehoachlocFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KehoachlocFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KehoachlocFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KehoachlocFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KEHOACHLOC_CurrentChanged"); }
		}

		private string Save_Data(string _str_KEHOACHLOC_PK)
		{
			KehoachlocEntity _KehoachlocEntity = new KehoachlocEntity();
			try { _KehoachlocEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			_KehoachlocEntity.Solenhsx = txt_SOLENHSX.Text.Trim();
			try { _KehoachlocEntity.Ngaydat = System.DateTime.Parse(txt_NGAYDAT.Text.Trim()); } 
			catch { }
			try { _KehoachlocEntity.Ngaygiao = System.DateTime.Parse(txt_NGAYGIAO.Text.Trim()); } 
			catch { }
			_KehoachlocEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_KehoachlocEntity.Mamay = txt_MAMAY.Text.Trim();
			try { _KehoachlocEntity.Ngaychay = System.DateTime.Parse(txt_NGAYCHAY.Text.Trim()); } 
			catch { }
			try { _KehoachlocEntity.Ca = System.Int32.Parse(txt_CA.Text.Trim()); } 
			catch { }
			try { _KehoachlocEntity.Somet = System.Decimal.Parse(txt_SOMET.Text.Trim()); } 
			catch { }
			try { _KehoachlocEntity.Sokg = System.Decimal.Parse(txt_SOKG.Text.Trim()); } 
			catch { }
			try { _KehoachlocEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_KehoachlocEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _KehoachlocEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_KehoachlocEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_KEHOACHLOC_PK))
			{
				_str_KEHOACHLOC_PK = _KehoachlocManager.InsertV2(_KehoachlocEntity, r_Insert, DT_KEHOACHLOC, BS_KEHOACHLOC);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KehoachlocManager.Convert(_KehoachlocEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KEHOACHLOC.ResetCurrentItem();
			}
			else
			{
				_KehoachlocManager.Update(_KehoachlocEntity);
				
				GRID_KEHOACHLOC.CurrentRow.Cells[KehoachlocFields.Id.Name].Value = _KehoachlocEntity.Id;
				GRID_KEHOACHLOC.CurrentRow.Cells[KehoachlocFields.Solenhsx.Name].Value = _KehoachlocEntity.Solenhsx;
				GRID_KEHOACHLOC.CurrentRow.Cells[KehoachlocFields.Ngaydat.Name].Value = _KehoachlocEntity.Ngaydat;
				GRID_KEHOACHLOC.CurrentRow.Cells[KehoachlocFields.Ngaygiao.Name].Value = _KehoachlocEntity.Ngaygiao;
				GRID_KEHOACHLOC.CurrentRow.Cells[KehoachlocFields.Masanpham.Name].Value = _KehoachlocEntity.Masanpham;
				GRID_KEHOACHLOC.CurrentRow.Cells[KehoachlocFields.Mamay.Name].Value = _KehoachlocEntity.Mamay;
				GRID_KEHOACHLOC.CurrentRow.Cells[KehoachlocFields.Ngaychay.Name].Value = _KehoachlocEntity.Ngaychay;
				GRID_KEHOACHLOC.CurrentRow.Cells[KehoachlocFields.Ca.Name].Value = _KehoachlocEntity.Ca;
				GRID_KEHOACHLOC.CurrentRow.Cells[KehoachlocFields.Somet.Name].Value = _KehoachlocEntity.Somet;
				GRID_KEHOACHLOC.CurrentRow.Cells[KehoachlocFields.Sokg.Name].Value = _KehoachlocEntity.Sokg;
				GRID_KEHOACHLOC.CurrentRow.Cells[KehoachlocFields.Ngaytao.Name].Value = _KehoachlocEntity.Ngaytao;
				GRID_KEHOACHLOC.CurrentRow.Cells[KehoachlocFields.Nguoitao.Name].Value = _KehoachlocEntity.Nguoitao;
				GRID_KEHOACHLOC.CurrentRow.Cells[KehoachlocFields.Ngaysua.Name].Value = _KehoachlocEntity.Ngaysua;
				GRID_KEHOACHLOC.CurrentRow.Cells[KehoachlocFields.Nguoisua.Name].Value = _KehoachlocEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KehoachlocManager.Convert(_KehoachlocEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KEHOACHLOC_PK;
		}

	}
}
