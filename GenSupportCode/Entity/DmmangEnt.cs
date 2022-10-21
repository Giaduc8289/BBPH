
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
					txt_TRONGLUONG.Text = _Rowview.Row[DmmangFields.Trongluong.Name].ToString();
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
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMMANG_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMMANG_PK)
		{
			DmmangEntity _dmmangEntity = new DmmangEntity();
			
			_dmmangEntity.Mamang = txt_MAMANG.Text.Trim();
			_dmmangEntity.Tenmang = txt_TENMANG.Text.Trim();
			_dmmangEntity.Makhach = txt_MAKHACH.Text.Trim();
			_dmmangEntity.Tenkhach = txt_TENKHACH.Text.Trim();
			_dmmangEntity.Kichthuoc = txt_KICHTHUOC.Text.Trim();
			_dmmangEntity.Trongluong = txt_TRONGLUONG.Text.Trim();
			_dmmangEntity.Mactpt = txt_MACTPT.Text.Trim();
			_dmmangEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dmmangEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dmmangEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dmmangEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_dmmangEntity.Doday = txt_DODAY.Text.Trim();
			_dmmangEntity.Rong = txt_RONG.Text.Trim();
			_dmmangEntity.Maloaimang = txt_MALOAIMANG.Text.Trim();
			_dmmangEntity.Tenloaimang = txt_TENLOAIMANG.Text.Trim();
			_dmmangEntity.Maqcmang = txt_MAQCMANG.Text.Trim();
			_dmmangEntity.Tenqcmang = txt_TENQCMANG.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMMANG_PK))
			{
				_str_DMMANG_PK = _DmmangManager.InsertV2(_dmmangEntity, r_Insert, DT_DMMANG, BS_DMMANG);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmangManager.Convert(_dmmangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMMANG.ResetCurrentItem();
			}
			else
			{
				_DmmangManager.Update(_dmmangEntity);
				
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Mamang.Name].Value = _dmmangEntity.Mamang;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Tenmang.Name].Value = _dmmangEntity.Tenmang;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Makhach.Name].Value = _dmmangEntity.Makhach;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Tenkhach.Name].Value = _dmmangEntity.Tenkhach;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Kichthuoc.Name].Value = _dmmangEntity.Kichthuoc;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Trongluong.Name].Value = _dmmangEntity.Trongluong;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Mactpt.Name].Value = _dmmangEntity.Mactpt;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Ngaytao.Name].Value = _dmmangEntity.Ngaytao;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Nguoitao.Name].Value = _dmmangEntity.Nguoitao;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Ngaysua.Name].Value = _dmmangEntity.Ngaysua;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Nguoisua.Name].Value = _dmmangEntity.Nguoisua;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Doday.Name].Value = _dmmangEntity.Doday;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Rong.Name].Value = _dmmangEntity.Rong;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Maloaimang.Name].Value = _dmmangEntity.Maloaimang;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Tenloaimang.Name].Value = _dmmangEntity.Tenloaimang;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Maqcmang.Name].Value = _dmmangEntity.Maqcmang;
				GRID_DMMANG.CurrentRow.Cells[DmmangFields.Tenqcmang.Name].Value = _dmmangEntity.Tenqcmang;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmangManager.Convert(_dmmangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMMANG_PK;
		}

	}
}
