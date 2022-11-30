
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.KehoachinEnt
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
	public class KehoachinEnt : KehoachinEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KehoachinEnt()
		{
			// Nothing for now.
		}

		void BS_KEHOACHIN_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_KEHOACHIN.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_KEHOACHIN.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KehoachinFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[KehoachinFields.Id.Name].ToString();
					txt_SOLENHSX.Text = _Rowview.Row[KehoachinFields.Solenhsx.Name].ToString();
					txt_NGAYDAT.Text = _Rowview.Row[KehoachinFields.Ngaydat.Name].ToString();
					txt_NGAYGIAO.Text = _Rowview.Row[KehoachinFields.Ngaygiao.Name].ToString();
					txt_MASANPHAM.Text = _Rowview.Row[KehoachinFields.Masanpham.Name].ToString();
					txt_MAMAY.Text = _Rowview.Row[KehoachinFields.Mamay.Name].ToString();
					txt_NGAYCHAY.Text = _Rowview.Row[KehoachinFields.Ngaychay.Name].ToString();
					txt_CA.Text = _Rowview.Row[KehoachinFields.Ca.Name].ToString();
					txt_SOMET.Text = _Rowview.Row[KehoachinFields.Somet.Name].ToString();
					txt_SOKG.Text = _Rowview.Row[KehoachinFields.Sokg.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KehoachinFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KehoachinFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KehoachinFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KehoachinFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KEHOACHIN_CurrentChanged"); }
		}

		private string Save_Data(string _str_KEHOACHIN_PK)
		{
			KehoachinEntity _KehoachinEntity = new KehoachinEntity();
			try { _KehoachinEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			_KehoachinEntity.Solenhsx = txt_SOLENHSX.Text.Trim();
			try { _KehoachinEntity.Ngaydat = System.DateTime.Parse(txt_NGAYDAT.Text.Trim()); } 
			catch { }
			try { _KehoachinEntity.Ngaygiao = System.DateTime.Parse(txt_NGAYGIAO.Text.Trim()); } 
			catch { }
			_KehoachinEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_KehoachinEntity.Mamay = txt_MAMAY.Text.Trim();
			try { _KehoachinEntity.Ngaychay = System.DateTime.Parse(txt_NGAYCHAY.Text.Trim()); } 
			catch { }
			try { _KehoachinEntity.Ca = System.Int32.Parse(txt_CA.Text.Trim()); } 
			catch { }
			try { _KehoachinEntity.Somet = System.Decimal.Parse(txt_SOMET.Text.Trim()); } 
			catch { }
			try { _KehoachinEntity.Sokg = System.Decimal.Parse(txt_SOKG.Text.Trim()); } 
			catch { }
			try { _KehoachinEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_KehoachinEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _KehoachinEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_KehoachinEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_KEHOACHIN_PK))
			{
				_str_KEHOACHIN_PK = _KehoachinManager.InsertV2(_KehoachinEntity, r_Insert, DT_KEHOACHIN, BS_KEHOACHIN);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KehoachinManager.Convert(_KehoachinEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KEHOACHIN.ResetCurrentItem();
			}
			else
			{
				_KehoachinManager.Update(_KehoachinEntity);
				
				GRID_KEHOACHIN.CurrentRow.Cells[KehoachinFields.Id.Name].Value = _KehoachinEntity.Id;
				GRID_KEHOACHIN.CurrentRow.Cells[KehoachinFields.Solenhsx.Name].Value = _KehoachinEntity.Solenhsx;
				GRID_KEHOACHIN.CurrentRow.Cells[KehoachinFields.Ngaydat.Name].Value = _KehoachinEntity.Ngaydat;
				GRID_KEHOACHIN.CurrentRow.Cells[KehoachinFields.Ngaygiao.Name].Value = _KehoachinEntity.Ngaygiao;
				GRID_KEHOACHIN.CurrentRow.Cells[KehoachinFields.Masanpham.Name].Value = _KehoachinEntity.Masanpham;
				GRID_KEHOACHIN.CurrentRow.Cells[KehoachinFields.Mamay.Name].Value = _KehoachinEntity.Mamay;
				GRID_KEHOACHIN.CurrentRow.Cells[KehoachinFields.Ngaychay.Name].Value = _KehoachinEntity.Ngaychay;
				GRID_KEHOACHIN.CurrentRow.Cells[KehoachinFields.Ca.Name].Value = _KehoachinEntity.Ca;
				GRID_KEHOACHIN.CurrentRow.Cells[KehoachinFields.Somet.Name].Value = _KehoachinEntity.Somet;
				GRID_KEHOACHIN.CurrentRow.Cells[KehoachinFields.Sokg.Name].Value = _KehoachinEntity.Sokg;
				GRID_KEHOACHIN.CurrentRow.Cells[KehoachinFields.Ngaytao.Name].Value = _KehoachinEntity.Ngaytao;
				GRID_KEHOACHIN.CurrentRow.Cells[KehoachinFields.Nguoitao.Name].Value = _KehoachinEntity.Nguoitao;
				GRID_KEHOACHIN.CurrentRow.Cells[KehoachinFields.Ngaysua.Name].Value = _KehoachinEntity.Ngaysua;
				GRID_KEHOACHIN.CurrentRow.Cells[KehoachinFields.Nguoisua.Name].Value = _KehoachinEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KehoachinManager.Convert(_KehoachinEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KEHOACHIN_PK;
		}

	}
}
