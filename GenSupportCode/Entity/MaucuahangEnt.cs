
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.MaucuahangEnt
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
	public class MaucuahangEnt : MaucuahangEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MaucuahangEnt()
		{
			// Nothing for now.
		}

		void BS_MAUCUAHANG_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_MAUCUAHANG.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_MAUCUAHANG.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[MaucuahangFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[MaucuahangFields.Id.Name].ToString();
					txt_MASP.Text = _Rowview.Row[MaucuahangFields.Masp.Name].ToString();
					txt_TENSP.Text = _Rowview.Row[MaucuahangFields.Tensp.Name].ToString();
					txt_MAMAU.Text = _Rowview.Row[MaucuahangFields.Mamau.Name].ToString();
					txt_TENMAU.Text = _Rowview.Row[MaucuahangFields.Tenmau.Name].ToString();
					txt_KLMAU.Text = _Rowview.Row[MaucuahangFields.Klmau.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[MaucuahangFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[MaucuahangFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[MaucuahangFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[MaucuahangFields.Nguoisua.Name].ToString();
					txt_TYLEBAOPHU.Text = _Rowview.Row[MaucuahangFields.Tylebaophu.Name].ToString();
					txt_MAARGB.Text = _Rowview.Row[MaucuahangFields.MaArgb.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_MAUCUAHANG_CurrentChanged"); }
		}

		private string Save_Data(string _str_MAUCUAHANG_PK)
		{
			MaucuahangEntity _MaucuahangEntity = new MaucuahangEntity();
			try { _MaucuahangEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			_MaucuahangEntity.Masp = txt_MASP.Text.Trim();
			_MaucuahangEntity.Tensp = txt_TENSP.Text.Trim();
			_MaucuahangEntity.Mamau = txt_MAMAU.Text.Trim();
			_MaucuahangEntity.Tenmau = txt_TENMAU.Text.Trim();
			try { _MaucuahangEntity.Klmau = System.Decimal.Parse(txt_KLMAU.Text.Trim()); } 
			catch { }
			try { _MaucuahangEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_MaucuahangEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _MaucuahangEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_MaucuahangEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			try { _MaucuahangEntity.Tylebaophu = System.Decimal.Parse(txt_TYLEBAOPHU.Text.Trim()); } 
			catch { }
			try { _MaucuahangEntity.MaArgb = System.Int64.Parse(txt_MAARGB.Text.Trim()); } 
			catch { }
			
			
			if (string.IsNullOrEmpty(_str_MAUCUAHANG_PK))
			{
				_str_MAUCUAHANG_PK = _MaucuahangManager.InsertV2(_MaucuahangEntity, r_Insert, DT_MAUCUAHANG, BS_MAUCUAHANG);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_MaucuahangManager.Convert(_MaucuahangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_MAUCUAHANG.ResetCurrentItem();
			}
			else
			{
				_MaucuahangManager.Update(_MaucuahangEntity);
				
				GRID_MAUCUAHANG.CurrentRow.Cells[MaucuahangFields.Id.Name].Value = _MaucuahangEntity.Id;
				GRID_MAUCUAHANG.CurrentRow.Cells[MaucuahangFields.Masp.Name].Value = _MaucuahangEntity.Masp;
				GRID_MAUCUAHANG.CurrentRow.Cells[MaucuahangFields.Tensp.Name].Value = _MaucuahangEntity.Tensp;
				GRID_MAUCUAHANG.CurrentRow.Cells[MaucuahangFields.Mamau.Name].Value = _MaucuahangEntity.Mamau;
				GRID_MAUCUAHANG.CurrentRow.Cells[MaucuahangFields.Tenmau.Name].Value = _MaucuahangEntity.Tenmau;
				GRID_MAUCUAHANG.CurrentRow.Cells[MaucuahangFields.Klmau.Name].Value = _MaucuahangEntity.Klmau;
				GRID_MAUCUAHANG.CurrentRow.Cells[MaucuahangFields.Ngaytao.Name].Value = _MaucuahangEntity.Ngaytao;
				GRID_MAUCUAHANG.CurrentRow.Cells[MaucuahangFields.Nguoitao.Name].Value = _MaucuahangEntity.Nguoitao;
				GRID_MAUCUAHANG.CurrentRow.Cells[MaucuahangFields.Ngaysua.Name].Value = _MaucuahangEntity.Ngaysua;
				GRID_MAUCUAHANG.CurrentRow.Cells[MaucuahangFields.Nguoisua.Name].Value = _MaucuahangEntity.Nguoisua;
				GRID_MAUCUAHANG.CurrentRow.Cells[MaucuahangFields.Tylebaophu.Name].Value = _MaucuahangEntity.Tylebaophu;
				GRID_MAUCUAHANG.CurrentRow.Cells[MaucuahangFields.MaArgb.Name].Value = _MaucuahangEntity.MaArgb;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_MaucuahangManager.Convert(_MaucuahangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_MAUCUAHANG_PK;
		}

	}
}
