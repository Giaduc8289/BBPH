
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.MangcuahangEnt
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
	public class MangcuahangEnt : MangcuahangEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MangcuahangEnt()
		{
			// Nothing for now.
		}

		void BS_MANGCUAHANG_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_MANGCUAHANG.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_MANGCUAHANG.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[MangcuahangFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[MangcuahangFields.Id.Name].ToString();
					txt_MASP.Text = _Rowview.Row[MangcuahangFields.Masp.Name].ToString();
					txt_TENSP.Text = _Rowview.Row[MangcuahangFields.Tensp.Name].ToString();
					txt_MANGIN.Text = _Rowview.Row[MangcuahangFields.Mangin.Name].ToString();
					txt_MAMANG.Text = _Rowview.Row[MangcuahangFields.Mamang.Name].ToString();
					txt_TENMANG.Text = _Rowview.Row[MangcuahangFields.Tenmang.Name].ToString();
					txt_MALOAIKEO.Text = _Rowview.Row[MangcuahangFields.Maloaikeo.Name].ToString();
					txt_TENLOAIKEO.Text = _Rowview.Row[MangcuahangFields.Tenloaikeo.Name].ToString();
					txt_MALOAIDONGRAN.Text = _Rowview.Row[MangcuahangFields.Maloaidongran.Name].ToString();
					txt_TENLOAIDONGRAN.Text = _Rowview.Row[MangcuahangFields.Tenloaidongran.Name].ToString();
					txt_DINHMUCKEOKHO.Text = _Rowview.Row[MangcuahangFields.Dinhmuckeokho.Name].ToString();
					txt_DINHMUCDONGRANKHO.Text = _Rowview.Row[MangcuahangFields.Dinhmucdongrankho.Name].ToString();
					txt_TYLEKEOKHO.Text = _Rowview.Row[MangcuahangFields.Tylekeokho.Name].ToString();
					txt_TYLEDONGRANKHO.Text = _Rowview.Row[MangcuahangFields.Tyledongrankho.Name].ToString();
					txt_TYLEKEO.Text = _Rowview.Row[MangcuahangFields.Tylekeo.Name].ToString();
					txt_TYLEDONGRAN.Text = _Rowview.Row[MangcuahangFields.Tyledongran.Name].ToString();
					txt_DINHMUCKEOUOT.Text = _Rowview.Row[MangcuahangFields.Dinhmuckeouot.Name].ToString();
					txt_DINHMUCDONGRANUOT.Text = _Rowview.Row[MangcuahangFields.Dinhmucdongranuot.Name].ToString();
					txt_DINHMUCDUNGMOI.Text = _Rowview.Row[MangcuahangFields.Dinhmucdungmoi.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[MangcuahangFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[MangcuahangFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[MangcuahangFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[MangcuahangFields.Nguoisua.Name].ToString();
					txt_DODAY.Text = _Rowview.Row[MangcuahangFields.Doday.Name].ToString();
					txt_MALOAIMANG.Text = _Rowview.Row[MangcuahangFields.Maloaimang.Name].ToString();
					txt_TENLOAIMANG.Text = _Rowview.Row[MangcuahangFields.Tenloaimang.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_MANGCUAHANG_CurrentChanged"); }
		}

		private string Save_Data(string _str_MANGCUAHANG_PK)
		{
			MangcuahangEntity _MangcuahangEntity = new MangcuahangEntity();
			
			_MangcuahangEntity.Id = txt_ID.Text.Trim();
			_MangcuahangEntity.Masp = txt_MASP.Text.Trim();
			_MangcuahangEntity.Tensp = txt_TENSP.Text.Trim();
			_MangcuahangEntity.Mangin = txt_MANGIN.Text.Trim();
			_MangcuahangEntity.Mamang = txt_MAMANG.Text.Trim();
			_MangcuahangEntity.Tenmang = txt_TENMANG.Text.Trim();
			_MangcuahangEntity.Maloaikeo = txt_MALOAIKEO.Text.Trim();
			_MangcuahangEntity.Tenloaikeo = txt_TENLOAIKEO.Text.Trim();
			_MangcuahangEntity.Maloaidongran = txt_MALOAIDONGRAN.Text.Trim();
			_MangcuahangEntity.Tenloaidongran = txt_TENLOAIDONGRAN.Text.Trim();
			_MangcuahangEntity.Dinhmuckeokho = txt_DINHMUCKEOKHO.Text.Trim();
			_MangcuahangEntity.Dinhmucdongrankho = txt_DINHMUCDONGRANKHO.Text.Trim();
			_MangcuahangEntity.Tylekeokho = txt_TYLEKEOKHO.Text.Trim();
			_MangcuahangEntity.Tyledongrankho = txt_TYLEDONGRANKHO.Text.Trim();
			_MangcuahangEntity.Tylekeo = txt_TYLEKEO.Text.Trim();
			_MangcuahangEntity.Tyledongran = txt_TYLEDONGRAN.Text.Trim();
			_MangcuahangEntity.Dinhmuckeouot = txt_DINHMUCKEOUOT.Text.Trim();
			_MangcuahangEntity.Dinhmucdongranuot = txt_DINHMUCDONGRANUOT.Text.Trim();
			_MangcuahangEntity.Dinhmucdungmoi = txt_DINHMUCDUNGMOI.Text.Trim();
			_MangcuahangEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_MangcuahangEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_MangcuahangEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_MangcuahangEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_MangcuahangEntity.Doday = txt_DODAY.Text.Trim();
			_MangcuahangEntity.Maloaimang = txt_MALOAIMANG.Text.Trim();
			_MangcuahangEntity.Tenloaimang = txt_TENLOAIMANG.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_MANGCUAHANG_PK))
			{
				_str_MANGCUAHANG_PK = _MangcuahangManager.InsertV2(_MangcuahangEntity, r_Insert, DT_MANGCUAHANG, BS_MANGCUAHANG);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_MangcuahangManager.Convert(_MangcuahangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_MANGCUAHANG.ResetCurrentItem();
			}
			else
			{
				_MangcuahangManager.Update(_MangcuahangEntity);
				
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Id.Name].Value = _MangcuahangEntity.Id;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Masp.Name].Value = _MangcuahangEntity.Masp;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Tensp.Name].Value = _MangcuahangEntity.Tensp;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Mangin.Name].Value = _MangcuahangEntity.Mangin;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Mamang.Name].Value = _MangcuahangEntity.Mamang;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Tenmang.Name].Value = _MangcuahangEntity.Tenmang;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Maloaikeo.Name].Value = _MangcuahangEntity.Maloaikeo;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Tenloaikeo.Name].Value = _MangcuahangEntity.Tenloaikeo;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Maloaidongran.Name].Value = _MangcuahangEntity.Maloaidongran;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Tenloaidongran.Name].Value = _MangcuahangEntity.Tenloaidongran;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Dinhmuckeokho.Name].Value = _MangcuahangEntity.Dinhmuckeokho;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Dinhmucdongrankho.Name].Value = _MangcuahangEntity.Dinhmucdongrankho;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Tylekeokho.Name].Value = _MangcuahangEntity.Tylekeokho;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Tyledongrankho.Name].Value = _MangcuahangEntity.Tyledongrankho;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Tylekeo.Name].Value = _MangcuahangEntity.Tylekeo;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Tyledongran.Name].Value = _MangcuahangEntity.Tyledongran;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Dinhmuckeouot.Name].Value = _MangcuahangEntity.Dinhmuckeouot;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Dinhmucdongranuot.Name].Value = _MangcuahangEntity.Dinhmucdongranuot;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Dinhmucdungmoi.Name].Value = _MangcuahangEntity.Dinhmucdungmoi;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Ngaytao.Name].Value = _MangcuahangEntity.Ngaytao;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Nguoitao.Name].Value = _MangcuahangEntity.Nguoitao;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Ngaysua.Name].Value = _MangcuahangEntity.Ngaysua;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Nguoisua.Name].Value = _MangcuahangEntity.Nguoisua;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Doday.Name].Value = _MangcuahangEntity.Doday;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Maloaimang.Name].Value = _MangcuahangEntity.Maloaimang;
				GRID_MANGCUAHANG.CurrentRow.Cells[MangcuahangFields.Tenloaimang.Name].Value = _MangcuahangEntity.Tenloaimang;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_MangcuahangManager.Convert(_MangcuahangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_MANGCUAHANG_PK;
		}

	}
}
