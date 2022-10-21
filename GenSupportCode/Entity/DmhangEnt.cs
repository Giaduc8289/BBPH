
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
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMHANG_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMHANG_PK)
		{
			DmhangEntity _dmhangEntity = new DmhangEntity();
			
			_dmhangEntity.Masp = txt_MASP.Text.Trim();
			_dmhangEntity.Tensp = txt_TENSP.Text.Trim();
			_dmhangEntity.Maspcuakhach = txt_MASPCUAKHACH.Text.Trim();
			_dmhangEntity.Machungloai = txt_MACHUNGLOAI.Text.Trim();
			_dmhangEntity.Tenchungloai = txt_TENCHUNGLOAI.Text.Trim();
			_dmhangEntity.Makhach = txt_MAKHACH.Text.Trim();
			_dmhangEntity.Tenkhach = txt_TENKHACH.Text.Trim();
			_dmhangEntity.Kichthuoc = txt_KICHTHUOC.Text.Trim();
			_dmhangEntity.Trongluong = txt_TRONGLUONG.Text.Trim();
			_dmhangEntity.Sohinh = txt_SOHINH.Text.Trim();
			_dmhangEntity.Somau = txt_SOMAU.Text.Trim();
			_dmhangEntity.Loaimuc = txt_LOAIMUC.Text.Trim();
			_dmhangEntity.Khoiluongmuc = txt_KHOILUONGMUC.Text.Trim();
			_dmhangEntity.Cautrucin = txt_CAUTRUCIN.Text.Trim();
			_dmhangEntity.Mamang1 = txt_MAMANG1.Text.Trim();
			_dmhangEntity.Tenmang1 = txt_TENMANG1.Text.Trim();
			_dmhangEntity.Tlmanglop1 = txt_TLMANGLOP1.Text.Trim();
			_dmhangEntity.Tlkeolop1 = txt_TLKEOLOP1.Text.Trim();
			_dmhangEntity.Mamang2 = txt_MAMANG2.Text.Trim();
			_dmhangEntity.Tenmang2 = txt_TENMANG2.Text.Trim();
			_dmhangEntity.Tlmanglop2 = txt_TLMANGLOP2.Text.Trim();
			_dmhangEntity.Tlkeolop2 = txt_TLKEOLOP2.Text.Trim();
			_dmhangEntity.Dinhluongkeo = txt_DINHLUONGKEO.Text.Trim();
			_dmhangEntity.Kichthuoctruc = txt_KICHTHUOCTRUC.Text.Trim();
			_dmhangEntity.Vitri = txt_VITRI.Text.Trim();
			_dmhangEntity.Maqcdonggoi = txt_MAQCDONGGOI.Text.Trim();
			_dmhangEntity.Tenqcdonggoi = txt_TENQCDONGGOI.Text.Trim();
			_dmhangEntity.Maqcloaithung = txt_MAQCLOAITHUNG.Text.Trim();
			_dmhangEntity.Tenqcloaithung = txt_TENQCLOAITHUNG.Text.Trim();
			_dmhangEntity.Maqcthanhpham = txt_MAQCTHANHPHAM.Text.Trim();
			_dmhangEntity.Tenqcthanhpham = txt_TENQCTHANHPHAM.Text.Trim();
			_dmhangEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dmhangEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dmhangEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dmhangEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_dmhangEntity.Rong = txt_RONG.Text.Trim();
			_dmhangEntity.Dai = txt_DAI.Text.Trim();
			_dmhangEntity.Somauma = txt_SOMAUMA.Text.Trim();
			_dmhangEntity.Sohinhma = txt_SOHINHMA.Text.Trim();
			_dmhangEntity.Maloaimuc = txt_MALOAIMUC.Text.Trim();
			_dmhangEntity.Doday = txt_DODAY.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMHANG_PK))
			{
				_str_DMHANG_PK = _DmhangManager.InsertV2(_dmhangEntity, r_Insert, DT_DMHANG, BS_DMHANG);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmhangManager.Convert(_dmhangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMHANG.ResetCurrentItem();
			}
			else
			{
				_DmhangManager.Update(_dmhangEntity);
				
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Masp.Name].Value = _dmhangEntity.Masp;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tensp.Name].Value = _dmhangEntity.Tensp;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Maspcuakhach.Name].Value = _dmhangEntity.Maspcuakhach;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Machungloai.Name].Value = _dmhangEntity.Machungloai;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tenchungloai.Name].Value = _dmhangEntity.Tenchungloai;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Makhach.Name].Value = _dmhangEntity.Makhach;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tenkhach.Name].Value = _dmhangEntity.Tenkhach;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Kichthuoc.Name].Value = _dmhangEntity.Kichthuoc;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Trongluong.Name].Value = _dmhangEntity.Trongluong;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Sohinh.Name].Value = _dmhangEntity.Sohinh;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Somau.Name].Value = _dmhangEntity.Somau;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Loaimuc.Name].Value = _dmhangEntity.Loaimuc;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Khoiluongmuc.Name].Value = _dmhangEntity.Khoiluongmuc;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Cautrucin.Name].Value = _dmhangEntity.Cautrucin;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Mamang1.Name].Value = _dmhangEntity.Mamang1;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tenmang1.Name].Value = _dmhangEntity.Tenmang1;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tlmanglop1.Name].Value = _dmhangEntity.Tlmanglop1;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tlkeolop1.Name].Value = _dmhangEntity.Tlkeolop1;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Mamang2.Name].Value = _dmhangEntity.Mamang2;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tenmang2.Name].Value = _dmhangEntity.Tenmang2;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tlmanglop2.Name].Value = _dmhangEntity.Tlmanglop2;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tlkeolop2.Name].Value = _dmhangEntity.Tlkeolop2;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Dinhluongkeo.Name].Value = _dmhangEntity.Dinhluongkeo;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Kichthuoctruc.Name].Value = _dmhangEntity.Kichthuoctruc;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Vitri.Name].Value = _dmhangEntity.Vitri;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Maqcdonggoi.Name].Value = _dmhangEntity.Maqcdonggoi;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tenqcdonggoi.Name].Value = _dmhangEntity.Tenqcdonggoi;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Maqcloaithung.Name].Value = _dmhangEntity.Maqcloaithung;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tenqcloaithung.Name].Value = _dmhangEntity.Tenqcloaithung;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Maqcthanhpham.Name].Value = _dmhangEntity.Maqcthanhpham;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Tenqcthanhpham.Name].Value = _dmhangEntity.Tenqcthanhpham;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Ngaytao.Name].Value = _dmhangEntity.Ngaytao;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Nguoitao.Name].Value = _dmhangEntity.Nguoitao;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Ngaysua.Name].Value = _dmhangEntity.Ngaysua;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Nguoisua.Name].Value = _dmhangEntity.Nguoisua;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Rong.Name].Value = _dmhangEntity.Rong;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Dai.Name].Value = _dmhangEntity.Dai;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Somauma.Name].Value = _dmhangEntity.Somauma;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Sohinhma.Name].Value = _dmhangEntity.Sohinhma;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Maloaimuc.Name].Value = _dmhangEntity.Maloaimuc;
				GRID_DMHANG.CurrentRow.Cells[DmhangFields.Doday.Name].Value = _dmhangEntity.Doday;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmhangManager.Convert(_dmhangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMHANG_PK;
		}

	}
}
