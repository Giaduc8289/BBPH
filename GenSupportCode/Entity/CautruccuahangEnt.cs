
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.CautruccuahangEnt
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
	public class CautruccuahangEnt : CautruccuahangEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CautruccuahangEnt()
		{
			// Nothing for now.
		}

		void BS_CAUTRUCCUAHANG_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_CAUTRUCCUAHANG.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_CAUTRUCCUAHANG.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[CautruccuahangFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[CautruccuahangFields.Id.Name].ToString();
					txt_MASP.Text = _Rowview.Row[CautruccuahangFields.Masp.Name].ToString();
					txt_TENSP.Text = _Rowview.Row[CautruccuahangFields.Tensp.Name].ToString();
					txt_MANGIN.Text = _Rowview.Row[CautruccuahangFields.Mangin.Name].ToString();
					txt_MAMANG.Text = _Rowview.Row[CautruccuahangFields.Mamang.Name].ToString();
					txt_TENMANG.Text = _Rowview.Row[CautruccuahangFields.Tenmang.Name].ToString();
					txt_MALOAIKEO.Text = _Rowview.Row[CautruccuahangFields.Maloaikeo.Name].ToString();
					txt_TENLOAIKEO.Text = _Rowview.Row[CautruccuahangFields.Tenloaikeo.Name].ToString();
					txt_MALOAIDONGRAN.Text = _Rowview.Row[CautruccuahangFields.Maloaidongran.Name].ToString();
					txt_TENLOAIDONGRAN.Text = _Rowview.Row[CautruccuahangFields.Tenloaidongran.Name].ToString();
					txt_DINHMUCKEOKHO.Text = _Rowview.Row[CautruccuahangFields.Dinhmuckeokho.Name].ToString();
					txt_DINHMUCDONGRANKHO.Text = _Rowview.Row[CautruccuahangFields.Dinhmucdongrankho.Name].ToString();
					txt_TYLEKEOKHO.Text = _Rowview.Row[CautruccuahangFields.Tylekeokho.Name].ToString();
					txt_TYLEDONGRANKHO.Text = _Rowview.Row[CautruccuahangFields.Tyledongrankho.Name].ToString();
					txt_TYLEKEO.Text = _Rowview.Row[CautruccuahangFields.Tylekeo.Name].ToString();
					txt_TYLEDONGRAN.Text = _Rowview.Row[CautruccuahangFields.Tyledongran.Name].ToString();
					txt_DINHMUCKEOUOT.Text = _Rowview.Row[CautruccuahangFields.Dinhmuckeouot.Name].ToString();
					txt_DINHMUCDONGRANUOT.Text = _Rowview.Row[CautruccuahangFields.Dinhmucdongranuot.Name].ToString();
					txt_DINHMUCDUNGMOI.Text = _Rowview.Row[CautruccuahangFields.Dinhmucdungmoi.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[CautruccuahangFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[CautruccuahangFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[CautruccuahangFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[CautruccuahangFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_CAUTRUCCUAHANG_CurrentChanged"); }
		}

		private string Save_Data(string _str_CAUTRUCCUAHANG_PK)
		{
			CautruccuahangEntity _CautruccuahangEntity = new CautruccuahangEntity();
			
			_CautruccuahangEntity.Id = txt_ID.Text.Trim();
			_CautruccuahangEntity.Masp = txt_MASP.Text.Trim();
			_CautruccuahangEntity.Tensp = txt_TENSP.Text.Trim();
			_CautruccuahangEntity.Mangin = txt_MANGIN.Text.Trim();
			_CautruccuahangEntity.Mamang = txt_MAMANG.Text.Trim();
			_CautruccuahangEntity.Tenmang = txt_TENMANG.Text.Trim();
			_CautruccuahangEntity.Maloaikeo = txt_MALOAIKEO.Text.Trim();
			_CautruccuahangEntity.Tenloaikeo = txt_TENLOAIKEO.Text.Trim();
			_CautruccuahangEntity.Maloaidongran = txt_MALOAIDONGRAN.Text.Trim();
			_CautruccuahangEntity.Tenloaidongran = txt_TENLOAIDONGRAN.Text.Trim();
			_CautruccuahangEntity.Dinhmuckeokho = txt_DINHMUCKEOKHO.Text.Trim();
			_CautruccuahangEntity.Dinhmucdongrankho = txt_DINHMUCDONGRANKHO.Text.Trim();
			_CautruccuahangEntity.Tylekeokho = txt_TYLEKEOKHO.Text.Trim();
			_CautruccuahangEntity.Tyledongrankho = txt_TYLEDONGRANKHO.Text.Trim();
			_CautruccuahangEntity.Tylekeo = txt_TYLEKEO.Text.Trim();
			_CautruccuahangEntity.Tyledongran = txt_TYLEDONGRAN.Text.Trim();
			_CautruccuahangEntity.Dinhmuckeouot = txt_DINHMUCKEOUOT.Text.Trim();
			_CautruccuahangEntity.Dinhmucdongranuot = txt_DINHMUCDONGRANUOT.Text.Trim();
			_CautruccuahangEntity.Dinhmucdungmoi = txt_DINHMUCDUNGMOI.Text.Trim();
			_CautruccuahangEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_CautruccuahangEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_CautruccuahangEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_CautruccuahangEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_CAUTRUCCUAHANG_PK))
			{
				_str_CAUTRUCCUAHANG_PK = _CautruccuahangManager.InsertV2(_CautruccuahangEntity, r_Insert, DT_CAUTRUCCUAHANG, BS_CAUTRUCCUAHANG);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CautruccuahangManager.Convert(_CautruccuahangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_CAUTRUCCUAHANG.ResetCurrentItem();
			}
			else
			{
				_CautruccuahangManager.Update(_CautruccuahangEntity);
				
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Id.Name].Value = _CautruccuahangEntity.Id;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Masp.Name].Value = _CautruccuahangEntity.Masp;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Tensp.Name].Value = _CautruccuahangEntity.Tensp;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Mangin.Name].Value = _CautruccuahangEntity.Mangin;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Mamang.Name].Value = _CautruccuahangEntity.Mamang;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Tenmang.Name].Value = _CautruccuahangEntity.Tenmang;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Maloaikeo.Name].Value = _CautruccuahangEntity.Maloaikeo;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Tenloaikeo.Name].Value = _CautruccuahangEntity.Tenloaikeo;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Maloaidongran.Name].Value = _CautruccuahangEntity.Maloaidongran;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Tenloaidongran.Name].Value = _CautruccuahangEntity.Tenloaidongran;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Dinhmuckeokho.Name].Value = _CautruccuahangEntity.Dinhmuckeokho;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Dinhmucdongrankho.Name].Value = _CautruccuahangEntity.Dinhmucdongrankho;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Tylekeokho.Name].Value = _CautruccuahangEntity.Tylekeokho;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Tyledongrankho.Name].Value = _CautruccuahangEntity.Tyledongrankho;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Tylekeo.Name].Value = _CautruccuahangEntity.Tylekeo;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Tyledongran.Name].Value = _CautruccuahangEntity.Tyledongran;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Dinhmuckeouot.Name].Value = _CautruccuahangEntity.Dinhmuckeouot;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Dinhmucdongranuot.Name].Value = _CautruccuahangEntity.Dinhmucdongranuot;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Dinhmucdungmoi.Name].Value = _CautruccuahangEntity.Dinhmucdungmoi;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Ngaytao.Name].Value = _CautruccuahangEntity.Ngaytao;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Nguoitao.Name].Value = _CautruccuahangEntity.Nguoitao;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Ngaysua.Name].Value = _CautruccuahangEntity.Ngaysua;
				GRID_CAUTRUCCUAHANG.CurrentRow.Cells[CautruccuahangFields.Nguoisua.Name].Value = _CautruccuahangEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CautruccuahangManager.Convert(_CautruccuahangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_CAUTRUCCUAHANG_PK;
		}

	}
}
