
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.TruccuahangEnt
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
	public class TruccuahangEnt : TruccuahangEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TruccuahangEnt()
		{
			// Nothing for now.
		}

		void BS_TRUCCUAHANG_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_TRUCCUAHANG.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_TRUCCUAHANG.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[TruccuahangFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[TruccuahangFields.Id.Name].ToString();
					txt_MASP.Text = _Rowview.Row[TruccuahangFields.Masp.Name].ToString();
					txt_TENSP.Text = _Rowview.Row[TruccuahangFields.Tensp.Name].ToString();
					txt_STTTRUC.Text = _Rowview.Row[TruccuahangFields.Stttruc.Name].ToString();
					txt_MATRUC.Text = _Rowview.Row[TruccuahangFields.Matruc.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[TruccuahangFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[TruccuahangFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[TruccuahangFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[TruccuahangFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_TRUCCUAHANG_CurrentChanged"); }
		}

		private string Save_Data(string _str_TRUCCUAHANG_PK)
		{
			TruccuahangEntity _TruccuahangEntity = new TruccuahangEntity();
			try { _TruccuahangEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			_TruccuahangEntity.Masp = txt_MASP.Text.Trim();
			_TruccuahangEntity.Tensp = txt_TENSP.Text.Trim();
			try { _TruccuahangEntity.Stttruc = System.Int32.Parse(txt_STTTRUC.Text.Trim()); } 
			catch { }
			_TruccuahangEntity.Matruc = txt_MATRUC.Text.Trim();
			try { _TruccuahangEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_TruccuahangEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _TruccuahangEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_TruccuahangEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_TRUCCUAHANG_PK))
			{
				_str_TRUCCUAHANG_PK = _TruccuahangManager.InsertV2(_TruccuahangEntity, r_Insert, DT_TRUCCUAHANG, BS_TRUCCUAHANG);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_TruccuahangManager.Convert(_TruccuahangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_TRUCCUAHANG.ResetCurrentItem();
			}
			else
			{
				_TruccuahangManager.Update(_TruccuahangEntity);
				
				GRID_TRUCCUAHANG.CurrentRow.Cells[TruccuahangFields.Id.Name].Value = _TruccuahangEntity.Id;
				GRID_TRUCCUAHANG.CurrentRow.Cells[TruccuahangFields.Masp.Name].Value = _TruccuahangEntity.Masp;
				GRID_TRUCCUAHANG.CurrentRow.Cells[TruccuahangFields.Tensp.Name].Value = _TruccuahangEntity.Tensp;
				GRID_TRUCCUAHANG.CurrentRow.Cells[TruccuahangFields.Stttruc.Name].Value = _TruccuahangEntity.Stttruc;
				GRID_TRUCCUAHANG.CurrentRow.Cells[TruccuahangFields.Matruc.Name].Value = _TruccuahangEntity.Matruc;
				GRID_TRUCCUAHANG.CurrentRow.Cells[TruccuahangFields.Ngaytao.Name].Value = _TruccuahangEntity.Ngaytao;
				GRID_TRUCCUAHANG.CurrentRow.Cells[TruccuahangFields.Nguoitao.Name].Value = _TruccuahangEntity.Nguoitao;
				GRID_TRUCCUAHANG.CurrentRow.Cells[TruccuahangFields.Ngaysua.Name].Value = _TruccuahangEntity.Ngaysua;
				GRID_TRUCCUAHANG.CurrentRow.Cells[TruccuahangFields.Nguoisua.Name].Value = _TruccuahangEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_TruccuahangManager.Convert(_TruccuahangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_TRUCCUAHANG_PK;
		}

	}
}
