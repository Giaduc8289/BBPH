
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

		void BS_DMHANG_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMHANG.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMHANG.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmhangFields.Masp.Name].ToString();
					
					txt_MASP.Text = _Rowview.Row[DmhangFields.Masp.Name].ToString();
					txt_TENSP.Text = _Rowview.Row[DmhangFields.Tensp.Name].ToString();
					txt_MASPCUAKHACH.Text = _Rowview.Row[DmhangFields.Maspcuakhach.Name].ToString();
					txt_MACHUNGLOAI.Text = _Rowview.Row[DmhangFields.Machungloai.Name].ToString();
					txt_TENCHUNGLOAI.Text = _Rowview.Row[DmhangFields.Tenchungloai.Name].ToString();
					txt_MAKHACH.Text = _Rowview.Row[DmhangFields.Makhach.Name].ToString();
					txt_TENKHACH.Text = _Rowview.Row[DmhangFields.Tenkhach.Name].ToString();
					txt_KICHTHUOC.Text = _Rowview.Row[DmhangFields.Kichthuoc.Name].ToString();
					txt_TRONGLUONG.Text = _Rowview.Row[DmhangFields.Trongluong.Name].ToString();
					txt_SOHINH.Text = _Rowview.Row[DmhangFields.Sohinh.Name].ToString();
					txt_SOMAU.Text = _Rowview.Row[DmhangFields.Somau.Name].ToString();
					txt_LOAIMUC.Text = _Rowview.Row[DmhangFields.Loaimuc.Name].ToString();
					txt_KHOILUONGMUC.Text = _Rowview.Row[DmhangFields.Khoiluongmuc.Name].ToString();
					txt_CAUTRUCIN.Text = _Rowview.Row[DmhangFields.Cautrucin.Name].ToString();
					txt_MAMANG1.Text = _Rowview.Row[DmhangFields.Mamang1.Name].ToString();
					txt_TENMANG1.Text = _Rowview.Row[DmhangFields.Tenmang1.Name].ToString();
					txt_TLMANGLOP1.Text = _Rowview.Row[DmhangFields.Tlmanglop1.Name].ToString();
					txt_TLKEOLOP1.Text = _Rowview.Row[DmhangFields.Tlkeolop1.Name].ToString();
					txt_MAMANG2.Text = _Rowview.Row[DmhangFields.Mamang2.Name].ToString();
					txt_TENMANG2.Text = _Rowview.Row[DmhangFields.Tenmang2.Name].ToString();
					txt_TLMANGLOP2.Text = _Rowview.Row[DmhangFields.Tlmanglop2.Name].ToString();
					txt_TLKEOLOP2.Text = _Rowview.Row[DmhangFields.Tlkeolop2.Name].ToString();
					txt_DINHLUONGKEO.Text = _Rowview.Row[DmhangFields.Dinhluongkeo.Name].ToString();
					txt_KICHTHUOCTRUC.Text = _Rowview.Row[DmhangFields.Kichthuoctruc.Name].ToString();
					txt_VITRI.Text = _Rowview.Row[DmhangFields.Vitri.Name].ToString();
					txt_MAQCDONGGOI.Text = _Rowview.Row[DmhangFields.Maqcdonggoi.Name].ToString();
					txt_TENQCDONGGOI.Text = _Rowview.Row[DmhangFields.Tenqcdonggoi.Name].ToString();
					txt_MAQCLOAITHUNG.Text = _Rowview.Row[DmhangFields.Maqcloaithung.Name].ToString();
					txt_TENQCLOAITHUNG.Text = _Rowview.Row[DmhangFields.Tenqcloaithung.Name].ToString();
					txt_MAQCTHANHPHAM.Text = _Rowview.Row[DmhangFields.Maqcthanhpham.Name].ToString();
					txt_TENQCTHANHPHAM.Text = _Rowview.Row[DmhangFields.Tenqcthanhpham.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmhangFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmhangFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmhangFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmhangFields.Nguoisua.Name].ToString();
					txt_RONG.Text = _Rowview.Row[DmhangFields.Rong.Name].ToString();
					txt_DAI.Text = _Rowview.Row[DmhangFields.Dai.Name].ToString();
					txt_SOMAUMA.Text = _Rowview.Row[DmhangFields.Somauma.Name].ToString();
					txt_SOHINHMA.Text = _Rowview.Row[DmhangFields.Sohinhma.Name].ToString();
					txt_MALOAIMUC.Text = _Rowview.Row[DmhangFields.Maloaimuc.Name].ToString();
					txt_DODAY.Text = _Rowview.Row[DmhangFields.Doday.Name].ToString();
					txt_MACAUTRUCIN.Text = _Rowview.Row[DmhangFields.Macautrucin.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMHANG_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMHANG_PK)
		{
			DmhangEntity _DmhangEntity = new DmhangEntity();
			
			_DmhangEntity.Masp = txt_MASP.Text.Trim();
			_DmhangEntity.Tensp = txt_TENSP.Text.Trim();
			_DmhangEntity.Maspcuakhach = txt_MASPCUAKHACH.Text.Trim();
			_DmhangEntity.Machungloai = txt_MACHUNGLOAI.Text.Trim();
			_DmhangEntity.Tenchungloai = txt_TENCHUNGLOAI.Text.Trim();
			_DmhangEntity.Makhach = txt_MAKHACH.Text.Trim();
			_DmhangEntity.Tenkhach = txt_TENKHACH.Text.Trim();
			_DmhangEntity.Kichthuoc = txt_KICHTHUOC.Text.Trim();
			_DmhangEntity.Trongluong = txt_TRONGLUONG.Text.Trim();
			_DmhangEntity.Sohinh = txt_SOHINH.Text.Trim();
			_DmhangEntity.Somau = txt_SOMAU.Text.Trim();
			_DmhangEntity.Loaimuc = txt_LOAIMUC.Text.Trim();
			_DmhangEntity.Khoiluongmuc = txt_KHOILUONGMUC.Text.Trim();
			_DmhangEntity.Cautrucin = txt_CAUTRUCIN.Text.Trim();
			_DmhangEntity.Mamang1 = txt_MAMANG1.Text.Trim();
			_DmhangEntity.Tenmang1 = txt_TENMANG1.Text.Trim();
			_DmhangEntity.Tlmanglop1 = txt_TLMANGLOP1.Text.Trim();
			_DmhangEntity.Tlkeolop1 = txt_TLKEOLOP1.Text.Trim();
			_DmhangEntity.Mamang2 = txt_MAMANG2.Text.Trim();
			_DmhangEntity.Tenmang2 = txt_TENMANG2.Text.Trim();
			_DmhangEntity.Tlmanglop2 = txt_TLMANGLOP2.Text.Trim();
			_DmhangEntity.Tlkeolop2 = txt_TLKEOLOP2.Text.Trim();
			_DmhangEntity.Dinhluongkeo = txt_DINHLUONGKEO.Text.Trim();
			_DmhangEntity.Kichthuoctruc = txt_KICHTHUOCTRUC.Text.Trim();
			_DmhangEntity.Vitri = txt_VITRI.Text.Trim();
			_DmhangEntity.Maqcdonggoi = txt_MAQCDONGGOI.Text.Trim();
			_DmhangEntity.Tenqcdonggoi = txt_TENQCDONGGOI.Text.Trim();
			_DmhangEntity.Maqcloaithung = txt_MAQCLOAITHUNG.Text.Trim();
			_DmhangEntity.Tenqcloaithung = txt_TENQCLOAITHUNG.Text.Trim();
			_DmhangEntity.Maqcthanhpham = txt_MAQCTHANHPHAM.Text.Trim();
			_DmhangEntity.Tenqcthanhpham = txt_TENQCTHANHPHAM.Text.Trim();
			_DmhangEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_DmhangEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_DmhangEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_DmhangEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_DmhangEntity.Rong = txt_RONG.Text.Trim();
			_DmhangEntity.Dai = txt_DAI.Text.Trim();
			_DmhangEntity.Somauma = txt_SOMAUMA.Text.Trim();
			_DmhangEntity.Sohinhma = txt_SOHINHMA.Text.Trim();
			_DmhangEntity.Maloaimuc = txt_MALOAIMUC.Text.Trim();
			_DmhangEntity.Doday = txt_DODAY.Text.Trim();
			_DmhangEntity.Macautrucin = txt_MACAUTRUCIN.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMHANG_PK))
			{
				_str_DMHANG_PK = _DmhangManager.InsertV2(_DmhangEntity, r_Insert, DT_DMHANG, BS_DMHANG);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmhangManager.Convert(_DmhangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMHANG.ResetCurrentItem();
			}
			else
			{
				_DmhangManager.Update(_DmhangEntity);
				
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Masp.Name].Value = _DmhangEntity.Masp;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tensp.Name].Value = _DmhangEntity.Tensp;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Maspcuakhach.Name].Value = _DmhangEntity.Maspcuakhach;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Machungloai.Name].Value = _DmhangEntity.Machungloai;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tenchungloai.Name].Value = _DmhangEntity.Tenchungloai;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Makhach.Name].Value = _DmhangEntity.Makhach;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tenkhach.Name].Value = _DmhangEntity.Tenkhach;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Kichthuoc.Name].Value = _DmhangEntity.Kichthuoc;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Trongluong.Name].Value = _DmhangEntity.Trongluong;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Sohinh.Name].Value = _DmhangEntity.Sohinh;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Somau.Name].Value = _DmhangEntity.Somau;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Loaimuc.Name].Value = _DmhangEntity.Loaimuc;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Khoiluongmuc.Name].Value = _DmhangEntity.Khoiluongmuc;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Cautrucin.Name].Value = _DmhangEntity.Cautrucin;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Mamang1.Name].Value = _DmhangEntity.Mamang1;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tenmang1.Name].Value = _DmhangEntity.Tenmang1;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tlmanglop1.Name].Value = _DmhangEntity.Tlmanglop1;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tlkeolop1.Name].Value = _DmhangEntity.Tlkeolop1;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Mamang2.Name].Value = _DmhangEntity.Mamang2;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tenmang2.Name].Value = _DmhangEntity.Tenmang2;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tlmanglop2.Name].Value = _DmhangEntity.Tlmanglop2;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tlkeolop2.Name].Value = _DmhangEntity.Tlkeolop2;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Dinhluongkeo.Name].Value = _DmhangEntity.Dinhluongkeo;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Kichthuoctruc.Name].Value = _DmhangEntity.Kichthuoctruc;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Vitri.Name].Value = _DmhangEntity.Vitri;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Maqcdonggoi.Name].Value = _DmhangEntity.Maqcdonggoi;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tenqcdonggoi.Name].Value = _DmhangEntity.Tenqcdonggoi;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Maqcloaithung.Name].Value = _DmhangEntity.Maqcloaithung;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tenqcloaithung.Name].Value = _DmhangEntity.Tenqcloaithung;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Maqcthanhpham.Name].Value = _DmhangEntity.Maqcthanhpham;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tenqcthanhpham.Name].Value = _DmhangEntity.Tenqcthanhpham;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Ngaytao.Name].Value = _DmhangEntity.Ngaytao;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Nguoitao.Name].Value = _DmhangEntity.Nguoitao;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Ngaysua.Name].Value = _DmhangEntity.Ngaysua;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Nguoisua.Name].Value = _DmhangEntity.Nguoisua;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Rong.Name].Value = _DmhangEntity.Rong;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Dai.Name].Value = _DmhangEntity.Dai;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Somauma.Name].Value = _DmhangEntity.Somauma;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Sohinhma.Name].Value = _DmhangEntity.Sohinhma;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Maloaimuc.Name].Value = _DmhangEntity.Maloaimuc;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Doday.Name].Value = _DmhangEntity.Doday;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Macautrucin.Name].Value = _DmhangEntity.Macautrucin;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmhangManager.Convert(_DmhangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMHANG_PK;
		}

	}
}
