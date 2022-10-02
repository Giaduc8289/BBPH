
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
					txt_Makhach.Text = _Rowview.Row[DmhangFields.Makhach.Name].ToString();
					txt_Tenkhach.Text = _Rowview.Row[DmhangFields.Tenkhach.Name].ToString();
					txt_Kichthuoc.Text = _Rowview.Row[DmhangFields.Kichthuoc.Name].ToString();
					txt_Khoiluongmuc.Text = _Rowview.Row[DmhangFields.Khoiluongmuc.Name].ToString();
					txt_Sohinh.Text = _Rowview.Row[DmhangFields.Sohinh.Name].ToString();
					txt_Cautrucin.Text = _Rowview.Row[DmhangFields.Cautrucin.Name].ToString();
					txt_Somau.Text = _Rowview.Row[DmhangFields.Somau.Name].ToString();
					txt_Loaimuc.Text = _Rowview.Row[DmhangFields.Loaimuc.Name].ToString();
					txt_Kichthuoctruc.Text = _Rowview.Row[DmhangFields.Kichthuoctruc.Name].ToString();
					txt_Vitri.Text = _Rowview.Row[DmhangFields.Vitri.Name].ToString();
					txt_Quycachdonggoi.Text = _Rowview.Row[DmhangFields.Quycachdonggoi.Name].ToString();
					txt_Loaithung.Text = _Rowview.Row[DmhangFields.Loaithung.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmhang_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmhang_PK)
		{
			DmhangEntity _dmhangEntity = new DmhangEntity();
			
			_dmhang.Masp = txt_Masp.Text.Trim();
			_dmhang.Tensp = txt_Tensp.Text.Trim();
			_dmhang.Makhach = txt_Makhach.Text.Trim();
			_dmhang.Tenkhach = txt_Tenkhach.Text.Trim();
			_dmhang.Kichthuoc = txt_Kichthuoc.Text.Trim();
			_dmhang.Khoiluongmuc = txt_Khoiluongmuc.Text.Trim();
			_dmhang.Sohinh = txt_Sohinh.Text.Trim();
			_dmhang.Cautrucin = txt_Cautrucin.Text.Trim();
			_dmhang.Somau = txt_Somau.Text.Trim();
			_dmhang.Loaimuc = txt_Loaimuc.Text.Trim();
			_dmhang.Kichthuoctruc = txt_Kichthuoctruc.Text.Trim();
			_dmhang.Vitri = txt_Vitri.Text.Trim();
			_dmhang.Quycachdonggoi = txt_Quycachdonggoi.Text.Trim();
			_dmhang.Loaithung = txt_Loaithung.Text.Trim();
			
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
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Makhach.Name].Value = _dmhangEntity.Makhach;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Tenkhach.Name].Value = _dmhangEntity.Tenkhach;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Kichthuoc.Name].Value = _dmhangEntity.Kichthuoc;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Khoiluongmuc.Name].Value = _dmhangEntity.Khoiluongmuc;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Sohinh.Name].Value = _dmhangEntity.Sohinh;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Cautrucin.Name].Value = _dmhangEntity.Cautrucin;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Somau.Name].Value = _dmhangEntity.Somau;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Loaimuc.Name].Value = _dmhangEntity.Loaimuc;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Kichthuoctruc.Name].Value = _dmhangEntity.Kichthuoctruc;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Vitri.Name].Value = _dmhangEntity.Vitri;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Quycachdonggoi.Name].Value = _dmhangEntity.Quycachdonggoi;
				GRID_Dmhang.CurrentRow.Cells[DmhangFields.Loaithung.Name].Value = _dmhangEntity.Loaithung;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmhangManager.Convert(_dmhangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmhang_PK;
		}

	}
}
