
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

		void BS_Truccuahang_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Truccuahang.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Truccuahang.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[TruccuahangFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[TruccuahangFields.Id.Name].ToString();
					txt_Masp.Text = _Rowview.Row[TruccuahangFields.Masp.Name].ToString();
					txt_Tensp.Text = _Rowview.Row[TruccuahangFields.Tensp.Name].ToString();
					txt_Stttruc.Text = _Rowview.Row[TruccuahangFields.Stttruc.Name].ToString();
					txt_Matruc.Text = _Rowview.Row[TruccuahangFields.Matruc.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[TruccuahangFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[TruccuahangFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[TruccuahangFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[TruccuahangFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Truccuahang_CurrentChanged"); }
		}

		private string Save_Data(string _str_Truccuahang_PK)
		{
			TruccuahangEntity _truccuahangEntity = new TruccuahangEntity();
			
			_truccuahangEntity.Id = txt_Id.Text.Trim();
			_truccuahangEntity.Masp = txt_Masp.Text.Trim();
			_truccuahangEntity.Tensp = txt_Tensp.Text.Trim();
			_truccuahangEntity.Stttruc = txt_Stttruc.Text.Trim();
			_truccuahangEntity.Matruc = txt_Matruc.Text.Trim();
			_truccuahangEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_truccuahangEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_truccuahangEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_truccuahangEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Truccuahang_PK = _TruccuahangManager.InsertV2(_TruccuahangEntity, r_Insert, DT_Truccuahang, BS_Truccuahang);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_TruccuahangManager.Convert(_truccuahangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Truccuahang.ResetCurrentItem();
			}
			else
			{
				_TruccuahangManager.Update(_truccuahangEntity);
				
				GRID_Truccuahang.CurrentRow.Cells[TruccuahangFields.Id.Name].Value = _truccuahangEntity.Id;
				GRID_Truccuahang.CurrentRow.Cells[TruccuahangFields.Masp.Name].Value = _truccuahangEntity.Masp;
				GRID_Truccuahang.CurrentRow.Cells[TruccuahangFields.Tensp.Name].Value = _truccuahangEntity.Tensp;
				GRID_Truccuahang.CurrentRow.Cells[TruccuahangFields.Stttruc.Name].Value = _truccuahangEntity.Stttruc;
				GRID_Truccuahang.CurrentRow.Cells[TruccuahangFields.Matruc.Name].Value = _truccuahangEntity.Matruc;
				GRID_Truccuahang.CurrentRow.Cells[TruccuahangFields.Ngaytao.Name].Value = _truccuahangEntity.Ngaytao;
				GRID_Truccuahang.CurrentRow.Cells[TruccuahangFields.Nguoitao.Name].Value = _truccuahangEntity.Nguoitao;
				GRID_Truccuahang.CurrentRow.Cells[TruccuahangFields.Ngaysua.Name].Value = _truccuahangEntity.Ngaysua;
				GRID_Truccuahang.CurrentRow.Cells[TruccuahangFields.Nguoisua.Name].Value = _truccuahangEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_TruccuahangManager.Convert(_truccuahangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Truccuahang_PK;
		}

	}
}
