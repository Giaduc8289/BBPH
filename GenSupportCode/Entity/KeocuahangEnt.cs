
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.KeocuahangEnt
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
	public class KeocuahangEnt : KeocuahangEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KeocuahangEnt()
		{
			// Nothing for now.
		}

		void BS_KEOCUAHANG_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_KEOCUAHANG.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_KEOCUAHANG.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KeocuahangFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[KeocuahangFields.Id.Name].ToString();
					txt_MASP.Text = _Rowview.Row[KeocuahangFields.Masp.Name].ToString();
					txt_TENSP.Text = _Rowview.Row[KeocuahangFields.Tensp.Name].ToString();
					txt_MAKEODONGRAN.Text = _Rowview.Row[KeocuahangFields.MakeoDongran.Name].ToString();
					txt_TENKEODONGRAN.Text = _Rowview.Row[KeocuahangFields.TenkeoDongran.Name].ToString();
					txt_DINHMUCKEODONGRAN.Text = _Rowview.Row[KeocuahangFields.DinhmuckeoDongran.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KeocuahangFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KeocuahangFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KeocuahangFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KeocuahangFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KEOCUAHANG_CurrentChanged"); }
		}

		private string Save_Data(string _str_KEOCUAHANG_PK)
		{
			KeocuahangEntity _KeocuahangEntity = new KeocuahangEntity();
			try { _KeocuahangEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			_KeocuahangEntity.Masp = txt_MASP.Text.Trim();
			_KeocuahangEntity.Tensp = txt_TENSP.Text.Trim();
			_KeocuahangEntity.MakeoDongran = txt_MAKEODONGRAN.Text.Trim();
			_KeocuahangEntity.TenkeoDongran = txt_TENKEODONGRAN.Text.Trim();
			try { _KeocuahangEntity.DinhmuckeoDongran = System.Decimal.Parse(txt_DINHMUCKEODONGRAN.Text.Trim()); } 
			catch { }
			try { _KeocuahangEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_KeocuahangEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _KeocuahangEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_KeocuahangEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_KEOCUAHANG_PK))
			{
				_str_KEOCUAHANG_PK = _KeocuahangManager.InsertV2(_KeocuahangEntity, r_Insert, DT_KEOCUAHANG, BS_KEOCUAHANG);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KeocuahangManager.Convert(_KeocuahangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KEOCUAHANG.ResetCurrentItem();
			}
			else
			{
				_KeocuahangManager.Update(_KeocuahangEntity);
				
				GRID_KEOCUAHANG.CurrentRow.Cells[KeocuahangFields.Id.Name].Value = _KeocuahangEntity.Id;
				GRID_KEOCUAHANG.CurrentRow.Cells[KeocuahangFields.Masp.Name].Value = _KeocuahangEntity.Masp;
				GRID_KEOCUAHANG.CurrentRow.Cells[KeocuahangFields.Tensp.Name].Value = _KeocuahangEntity.Tensp;
				GRID_KEOCUAHANG.CurrentRow.Cells[KeocuahangFields.MakeoDongran.Name].Value = _KeocuahangEntity.MakeoDongran;
				GRID_KEOCUAHANG.CurrentRow.Cells[KeocuahangFields.TenkeoDongran.Name].Value = _KeocuahangEntity.TenkeoDongran;
				GRID_KEOCUAHANG.CurrentRow.Cells[KeocuahangFields.DinhmuckeoDongran.Name].Value = _KeocuahangEntity.DinhmuckeoDongran;
				GRID_KEOCUAHANG.CurrentRow.Cells[KeocuahangFields.Ngaytao.Name].Value = _KeocuahangEntity.Ngaytao;
				GRID_KEOCUAHANG.CurrentRow.Cells[KeocuahangFields.Nguoitao.Name].Value = _KeocuahangEntity.Nguoitao;
				GRID_KEOCUAHANG.CurrentRow.Cells[KeocuahangFields.Ngaysua.Name].Value = _KeocuahangEntity.Ngaysua;
				GRID_KEOCUAHANG.CurrentRow.Cells[KeocuahangFields.Nguoisua.Name].Value = _KeocuahangEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KeocuahangManager.Convert(_KeocuahangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KEOCUAHANG_PK;
		}

	}
}
