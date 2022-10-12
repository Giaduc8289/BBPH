
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmhangEnt
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
	public class DmhangEnt : DmhangEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmhangEnt()
		{
			// Nothing for now.
		}

		void BS_Dmhang_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmhang.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmhang.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmhangFields.Masp.Name].ToString();
					
					txt_Masp.Text = _Rowview.Row[DmhangFields.Masp.Name].ToString();
					txt_Tensp.Text = _Rowview.Row[DmhangFields.Tensp.Name].ToString();
					txt_Maspcuakhach.Text = _Rowview.Row[DmhangFields.Maspcuakhach.Name].ToString();
					txt_Machungloai.Text = _Rowview.Row[DmhangFields.Machungloai.Name].ToString();
					txt_Tenchungloai.Text = _Rowview.Row[DmhangFields.Tenchungloai.Name].ToString();
					txt_Makhach.Text = _Rowview.Row[DmhangFields.Makhach.Name].ToString();
					txt_Tenkhach.Text = _Rowview.Row[DmhangFields.Tenkhach.Name].ToString();
					txt_Kichthuoc.Text = _Rowview.Row[DmhangFields.Kichthuoc.Name].ToString();
					txt_Trongluong.Text = _Rowview.Row[DmhangFields.Trongluong.Name].ToString();
					txt_Sohinh.Text = _Rowview.Row[DmhangFields.Sohinh.Name].ToString();
					txt_Somau.Text = _Rowview.Row[DmhangFields.Somau.Name].ToString();
					txt_Loaimuc.Text = _Rowview.Row[DmhangFields.Loaimuc.Name].ToString();
					txt_Khoiluongmuc.Text = _Rowview.Row[DmhangFields.Khoiluongmuc.Name].ToString();
					txt_Cautrucin.Text = _Rowview.Row[DmhangFields.Cautrucin.Name].ToString();
					txt_Mamang1.Text = _Rowview.Row[DmhangFields.Mamang1.Name].ToString();
					txt_Tenmang1.Text = _Rowview.Row[DmhangFields.Tenmang1.Name].ToString();
					txt_Tlmanglop1.Text = _Rowview.Row[DmhangFields.Tlmanglop1.Name].ToString();
					txt_Tlkeolop1.Text = _Rowview.Row[DmhangFields.Tlkeolop1.Name].ToString();
					txt_Mamang2.Text = _Rowview.Row[DmhangFields.Mamang2.Name].ToString();
					txt_Tenmang2.Text = _Rowview.Row[DmhangFields.Tenmang2.Name].ToString();
					txt_Tlmanglop2.Text = _Rowview.Row[DmhangFields.Tlmanglop2.Name].ToString();
					txt_Tlkeolop2.Text = _Rowview.Row[DmhangFields.Tlkeolop2.Name].ToString();
					txt_Dinhluongkeo.Text = _Rowview.Row[DmhangFields.Dinhluongkeo.Name].ToString();
					txt_Kichthuoctruc.Text = _Rowview.Row[DmhangFields.Kichthuoctruc.Name].ToString();
					txt_Vitri.Text = _Rowview.Row[DmhangFields.Vitri.Name].ToString();
					txt_Maqcdonggoi.Text = _Rowview.Row[DmhangFields.Maqcdonggoi.Name].ToString();
					txt_Tenqcdonggoi.Text = _Rowview.Row[DmhangFields.Tenqcdonggoi.Name].ToString();
					txt_Maqcloaithung.Text = _Rowview.Row[DmhangFields.Maqcloaithung.Name].ToString();
					txt_Tenqcloaithung.Text = _Rowview.Row[DmhangFields.Tenqcloaithung.Name].ToString();
					txt_Maqcthanhpham.Text = _Rowview.Row[DmhangFields.Maqcthanhpham.Name].ToString();
					txt_Tenqcthanhpham.Text = _Rowview.Row[DmhangFields.Tenqcthanhpham.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[DmhangFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[DmhangFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[DmhangFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[DmhangFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmhang_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmhang_PK)
		{
			DmhangEntity _dmhangEntity = new DmhangEntity();
			
			_dmhangEntity.Masp = txt_Masp.Text.Trim();
			_dmhangEntity.Tensp = txt_Tensp.Text.Trim();
			_dmhangEntity.Maspcuakhach = txt_Maspcuakhach.Text.Trim();
			_dmhangEntity.Machungloai = txt_Machungloai.Text.Trim();
			_dmhangEntity.Tenchungloai = txt_Tenchungloai.Text.Trim();
			_dmhangEntity.Makhach = txt_Makhach.Text.Trim();
			_dmhangEntity.Tenkhach = txt_Tenkhach.Text.Trim();
			_dmhangEntity.Kichthuoc = txt_Kichthuoc.Text.Trim();
			_dmhangEntity.Trongluong = txt_Trongluong.Text.Trim();
			_dmhangEntity.Sohinh = txt_Sohinh.Text.Trim();
			_dmhangEntity.Somau = txt_Somau.Text.Trim();
			_dmhangEntity.Loaimuc = txt_Loaimuc.Text.Trim();
			_dmhangEntity.Khoiluongmuc = txt_Khoiluongmuc.Text.Trim();
			_dmhangEntity.Cautrucin = txt_Cautrucin.Text.Trim();
			_dmhangEntity.Mamang1 = txt_Mamang1.Text.Trim();
			_dmhangEntity.Tenmang1 = txt_Tenmang1.Text.Trim();
			_dmhangEntity.Tlmanglop1 = txt_Tlmanglop1.Text.Trim();
			_dmhangEntity.Tlkeolop1 = txt_Tlkeolop1.Text.Trim();
			_dmhangEntity.Mamang2 = txt_Mamang2.Text.Trim();
			_dmhangEntity.Tenmang2 = txt_Tenmang2.Text.Trim();
			_dmhangEntity.Tlmanglop2 = txt_Tlmanglop2.Text.Trim();
			_dmhangEntity.Tlkeolop2 = txt_Tlkeolop2.Text.Trim();
			_dmhangEntity.Dinhluongkeo = txt_Dinhluongkeo.Text.Trim();
			_dmhangEntity.Kichthuoctruc = txt_Kichthuoctruc.Text.Trim();
			_dmhangEntity.Vitri = txt_Vitri.Text.Trim();
			_dmhangEntity.Maqcdonggoi = txt_Maqcdonggoi.Text.Trim();
			_dmhangEntity.Tenqcdonggoi = txt_Tenqcdonggoi.Text.Trim();
			_dmhangEntity.Maqcloaithung = txt_Maqcloaithung.Text.Trim();
			_dmhangEntity.Tenqcloaithung = txt_Tenqcloaithung.Text.Trim();
			_dmhangEntity.Maqcthanhpham = txt_Maqcthanhpham.Text.Trim();
			_dmhangEntity.Tenqcthanhpham = txt_Tenqcthanhpham.Text.Trim();
			_dmhangEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_dmhangEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_dmhangEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_dmhangEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmhang_PK = _DmhangManager.InsertV2(_DmhangEntity, r_Insert, DT_Dmhang, BS_Dmhang);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmhangManager.Convert(_dmhangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmhang.ResetCurrentItem();
			}
			else
			{
				_DmhangManager.Update(_dmhangEntity);
				
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Masp.Name].Value = _dmhangEntity.Masp;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Tensp.Name].Value = _dmhangEntity.Tensp;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Maspcuakhach.Name].Value = _dmhangEntity.Maspcuakhach;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Machungloai.Name].Value = _dmhangEntity.Machungloai;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Tenchungloai.Name].Value = _dmhangEntity.Tenchungloai;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Makhach.Name].Value = _dmhangEntity.Makhach;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Tenkhach.Name].Value = _dmhangEntity.Tenkhach;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Kichthuoc.Name].Value = _dmhangEntity.Kichthuoc;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Trongluong.Name].Value = _dmhangEntity.Trongluong;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Sohinh.Name].Value = _dmhangEntity.Sohinh;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Somau.Name].Value = _dmhangEntity.Somau;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Loaimuc.Name].Value = _dmhangEntity.Loaimuc;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Khoiluongmuc.Name].Value = _dmhangEntity.Khoiluongmuc;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Cautrucin.Name].Value = _dmhangEntity.Cautrucin;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Mamang1.Name].Value = _dmhangEntity.Mamang1;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Tenmang1.Name].Value = _dmhangEntity.Tenmang1;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Tlmanglop1.Name].Value = _dmhangEntity.Tlmanglop1;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Tlkeolop1.Name].Value = _dmhangEntity.Tlkeolop1;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Mamang2.Name].Value = _dmhangEntity.Mamang2;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Tenmang2.Name].Value = _dmhangEntity.Tenmang2;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Tlmanglop2.Name].Value = _dmhangEntity.Tlmanglop2;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Tlkeolop2.Name].Value = _dmhangEntity.Tlkeolop2;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Dinhluongkeo.Name].Value = _dmhangEntity.Dinhluongkeo;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Kichthuoctruc.Name].Value = _dmhangEntity.Kichthuoctruc;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Vitri.Name].Value = _dmhangEntity.Vitri;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Maqcdonggoi.Name].Value = _dmhangEntity.Maqcdonggoi;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Tenqcdonggoi.Name].Value = _dmhangEntity.Tenqcdonggoi;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Maqcloaithung.Name].Value = _dmhangEntity.Maqcloaithung;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Tenqcloaithung.Name].Value = _dmhangEntity.Tenqcloaithung;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Maqcthanhpham.Name].Value = _dmhangEntity.Maqcthanhpham;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Tenqcthanhpham.Name].Value = _dmhangEntity.Tenqcthanhpham;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Ngaytao.Name].Value = _dmhangEntity.Ngaytao;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Nguoitao.Name].Value = _dmhangEntity.Nguoitao;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Ngaysua.Name].Value = _dmhangEntity.Ngaysua;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Nguoisua.Name].Value = _dmhangEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmhangManager.Convert(_dmhangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmhang_PK;
		}

	}
}
