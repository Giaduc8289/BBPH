
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmmangEnt
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
	public class DmmangEnt : DmmangEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmmangEnt()
		{
			// Nothing for now.
		}

		void BS_DMMANG_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMMANG.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMMANG.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmmangFields.Mamang.Name].ToString();
					
					txt_MAMANG.Text = _Rowview.Row[DmmangFields.Mamang.Name].ToString();
					txt_TENMANG.Text = _Rowview.Row[DmmangFields.Tenmang.Name].ToString();
					txt_MAKHACH.Text = _Rowview.Row[DmmangFields.Makhach.Name].ToString();
					txt_TENKHACH.Text = _Rowview.Row[DmmangFields.Tenkhach.Name].ToString();
					txt_KICHTHUOC.Text = _Rowview.Row[DmmangFields.Kichthuoc.Name].ToString();
					txt_MACTPT.Text = _Rowview.Row[DmmangFields.Mactpt.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmmangFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmmangFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmmangFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmmangFields.Nguoisua.Name].ToString();
					txt_DODAY.Text = _Rowview.Row[DmmangFields.Doday.Name].ToString();
					txt_RONG.Text = _Rowview.Row[DmmangFields.Rong.Name].ToString();
					txt_MALOAIMANG.Text = _Rowview.Row[DmmangFields.Maloaimang.Name].ToString();
					txt_TENLOAIMANG.Text = _Rowview.Row[DmmangFields.Tenloaimang.Name].ToString();
					txt_MAQCMANG.Text = _Rowview.Row[DmmangFields.Maqcmang.Name].ToString();
					txt_TENQCMANG.Text = _Rowview.Row[DmmangFields.Tenqcmang.Name].ToString();
					txt_TRONGLUONG.Text = _Rowview.Row[DmmangFields.Trongluong.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMMANG_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMMANG_PK)
		{
			DmmangEntity _DmmangEntity = new DmmangEntity();
			
			_DmmangEntity.Mamang = txt_MAMANG.Text.Trim();
			_DmmangEntity.Tenmang = txt_TENMANG.Text.Trim();
			_DmmangEntity.Makhach = txt_MAKHACH.Text.Trim();
			_DmmangEntity.Tenkhach = txt_TENKHACH.Text.Trim();
			_DmmangEntity.Kichthuoc = txt_KICHTHUOC.Text.Trim();
			_DmmangEntity.Mactpt = txt_MACTPT.Text.Trim();
			_DmmangEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_DmmangEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_DmmangEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_DmmangEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_DmmangEntity.Doday = txt_DODAY.Text.Trim();
			_DmmangEntity.Rong = txt_RONG.Text.Trim();
			_DmmangEntity.Maloaimang = txt_MALOAIMANG.Text.Trim();
			_DmmangEntity.Tenloaimang = txt_TENLOAIMANG.Text.Trim();
			_DmmangEntity.Maqcmang = txt_MAQCMANG.Text.Trim();
			_DmmangEntity.Tenqcmang = txt_TENQCMANG.Text.Trim();
			_DmmangEntity.Trongluong = txt_TRONGLUONG.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMMANG_PK))
			{
				_str_DMMANG_PK = _DmmangManager.InsertV2(_DmmangEntity, r_Insert, DT_DMMANG, BS_DMMANG);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmangManager.Convert(_DmmangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMMANG.ResetCurrentItem();
			}
			else
			{
				_DmmangManager.Update(_DmmangEntity);
				
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Mamang.Name].Value = _DmmangEntity.Mamang;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Tenmang.Name].Value = _DmmangEntity.Tenmang;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Makhach.Name].Value = _DmmangEntity.Makhach;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Tenkhach.Name].Value = _DmmangEntity.Tenkhach;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Kichthuoc.Name].Value = _DmmangEntity.Kichthuoc;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Mactpt.Name].Value = _DmmangEntity.Mactpt;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Ngaytao.Name].Value = _DmmangEntity.Ngaytao;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Nguoitao.Name].Value = _DmmangEntity.Nguoitao;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Ngaysua.Name].Value = _DmmangEntity.Ngaysua;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Nguoisua.Name].Value = _DmmangEntity.Nguoisua;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Doday.Name].Value = _DmmangEntity.Doday;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Rong.Name].Value = _DmmangEntity.Rong;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Maloaimang.Name].Value = _DmmangEntity.Maloaimang;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Tenloaimang.Name].Value = _DmmangEntity.Tenloaimang;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Maqcmang.Name].Value = _DmmangEntity.Maqcmang;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Tenqcmang.Name].Value = _DmmangEntity.Tenqcmang;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Trongluong.Name].Value = _DmmangEntity.Trongluong;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmangManager.Convert(_DmmangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMMANG_PK;
		}

	}
}
