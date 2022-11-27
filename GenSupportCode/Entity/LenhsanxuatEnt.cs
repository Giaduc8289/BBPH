
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.LenhsanxuatEnt
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
	public class LenhsanxuatEnt : LenhsanxuatEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LenhsanxuatEnt()
		{
			// Nothing for now.
		}

		void BS_LENHSANXUAT_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_LENHSANXUAT.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_LENHSANXUAT.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[LenhsanxuatFields.Solenhsx.Name].ToString();
					
					txt_SOLENHSX.Text = _Rowview.Row[LenhsanxuatFields.Solenhsx.Name].ToString();
					txt_NGAYPHATLENH.Text = _Rowview.Row[LenhsanxuatFields.Ngayphatlenh.Name].ToString();
					txt_NGAYBATDAUSX.Text = _Rowview.Row[LenhsanxuatFields.Ngaybatdausx.Name].ToString();
					txt_NGAYHOANTHANHSX.Text = _Rowview.Row[LenhsanxuatFields.Ngayhoanthanhsx.Name].ToString();
					txt_MADON.Text = _Rowview.Row[LenhsanxuatFields.Madon.Name].ToString();
					txt_NGAYDAT.Text = _Rowview.Row[LenhsanxuatFields.Ngaydat.Name].ToString();
					txt_MAKHACH.Text = _Rowview.Row[LenhsanxuatFields.Makhach.Name].ToString();
					txt_TENKHACH.Text = _Rowview.Row[LenhsanxuatFields.Tenkhach.Name].ToString();
					txt_MADONHANGCHITIET.Text = _Rowview.Row[LenhsanxuatFields.Madonhangchitiet.Name].ToString();
					txt_LOAIHANG.Text = _Rowview.Row[LenhsanxuatFields.Loaihang.Name].ToString();
					txt_MASP.Text = _Rowview.Row[LenhsanxuatFields.Masp.Name].ToString();
					txt_TENHANG.Text = _Rowview.Row[LenhsanxuatFields.Tenhang.Name].ToString();
					txt_SOLUONG.Text = _Rowview.Row[LenhsanxuatFields.Soluong.Name].ToString();
					txt_NGAYGIAO.Text = _Rowview.Row[LenhsanxuatFields.Ngaygiao.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[LenhsanxuatFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[LenhsanxuatFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[LenhsanxuatFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[LenhsanxuatFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_LENHSANXUAT_CurrentChanged"); }
		}

		private string Save_Data(string _str_LENHSANXUAT_PK)
		{
			LenhsanxuatEntity _LenhsanxuatEntity = new LenhsanxuatEntity();
			_LenhsanxuatEntity.Solenhsx = txt_SOLENHSX.Text.Trim();
			try { _LenhsanxuatEntity.Ngayphatlenh = System.DateTime.Parse(txt_NGAYPHATLENH.Text.Trim()); } 
			catch { }
			try { _LenhsanxuatEntity.Ngaybatdausx = System.DateTime.Parse(txt_NGAYBATDAUSX.Text.Trim()); } 
			catch { }
			try { _LenhsanxuatEntity.Ngayhoanthanhsx = System.DateTime.Parse(txt_NGAYHOANTHANHSX.Text.Trim()); } 
			catch { }
			_LenhsanxuatEntity.Madon = txt_MADON.Text.Trim();
			try { _LenhsanxuatEntity.Ngaydat = System.DateTime.Parse(txt_NGAYDAT.Text.Trim()); } 
			catch { }
			_LenhsanxuatEntity.Makhach = txt_MAKHACH.Text.Trim();
			_LenhsanxuatEntity.Tenkhach = txt_TENKHACH.Text.Trim();
			try { _LenhsanxuatEntity.Madonhangchitiet = System.Int64.Parse(txt_MADONHANGCHITIET.Text.Trim()); } 
			catch { }
			try { _LenhsanxuatEntity.Loaihang = System.Int32.Parse(txt_LOAIHANG.Text.Trim()); } 
			catch { }
			_LenhsanxuatEntity.Masp = txt_MASP.Text.Trim();
			_LenhsanxuatEntity.Tenhang = txt_TENHANG.Text.Trim();
			try { _LenhsanxuatEntity.Soluong = System.Decimal.Parse(txt_SOLUONG.Text.Trim()); } 
			catch { }
			try { _LenhsanxuatEntity.Ngaygiao = System.DateTime.Parse(txt_NGAYGIAO.Text.Trim()); } 
			catch { }
			try { _LenhsanxuatEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_LenhsanxuatEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _LenhsanxuatEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_LenhsanxuatEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_LENHSANXUAT_PK))
			{
				_str_LENHSANXUAT_PK = _LenhsanxuatManager.InsertV2(_LenhsanxuatEntity, r_Insert, DT_LENHSANXUAT, BS_LENHSANXUAT);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_LenhsanxuatManager.Convert(_LenhsanxuatEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_LENHSANXUAT.ResetCurrentItem();
			}
			else
			{
				_LenhsanxuatManager.Update(_LenhsanxuatEntity);
				
				GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Solenhsx.Name].Value = _LenhsanxuatEntity.Solenhsx;
				GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Ngayphatlenh.Name].Value = _LenhsanxuatEntity.Ngayphatlenh;
				GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Ngaybatdausx.Name].Value = _LenhsanxuatEntity.Ngaybatdausx;
				GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Ngayhoanthanhsx.Name].Value = _LenhsanxuatEntity.Ngayhoanthanhsx;
				GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Madon.Name].Value = _LenhsanxuatEntity.Madon;
				GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Ngaydat.Name].Value = _LenhsanxuatEntity.Ngaydat;
				GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Makhach.Name].Value = _LenhsanxuatEntity.Makhach;
				GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Tenkhach.Name].Value = _LenhsanxuatEntity.Tenkhach;
				GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Madonhangchitiet.Name].Value = _LenhsanxuatEntity.Madonhangchitiet;
				GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Loaihang.Name].Value = _LenhsanxuatEntity.Loaihang;
				GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Masp.Name].Value = _LenhsanxuatEntity.Masp;
				GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Tenhang.Name].Value = _LenhsanxuatEntity.Tenhang;
				GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Soluong.Name].Value = _LenhsanxuatEntity.Soluong;
				GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Ngaygiao.Name].Value = _LenhsanxuatEntity.Ngaygiao;
				GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Ngaytao.Name].Value = _LenhsanxuatEntity.Ngaytao;
				GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Nguoitao.Name].Value = _LenhsanxuatEntity.Nguoitao;
				GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Ngaysua.Name].Value = _LenhsanxuatEntity.Ngaysua;
				GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Nguoisua.Name].Value = _LenhsanxuatEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_LenhsanxuatManager.Convert(_LenhsanxuatEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_LENHSANXUAT_PK;
		}

	}
}
