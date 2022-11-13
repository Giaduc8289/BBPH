
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.XuatkhomangEnt
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
	public class XuatkhomangEnt : XuatkhomangEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public XuatkhomangEnt()
		{
			// Nothing for now.
		}

		void BS_XUATKHOMANG_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_XUATKHOMANG.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_XUATKHOMANG.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[XuatkhomangFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[XuatkhomangFields.Id.Name].ToString();
					txt_NGAYXUAT.Text = _Rowview.Row[XuatkhomangFields.Ngayxuat.Name].ToString();
					txt_MAKHO.Text = _Rowview.Row[XuatkhomangFields.Makho.Name].ToString();
					txt_TENKHO.Text = _Rowview.Row[XuatkhomangFields.Tenkho.Name].ToString();
					txt_MAMANG.Text = _Rowview.Row[XuatkhomangFields.Mamang.Name].ToString();
					txt_TENMANG.Text = _Rowview.Row[XuatkhomangFields.Tenmang.Name].ToString();
					txt_SOMET.Text = _Rowview.Row[XuatkhomangFields.Somet.Name].ToString();
					txt_SOKG.Text = _Rowview.Row[XuatkhomangFields.Sokg.Name].ToString();
					txt_MALYDO.Text = _Rowview.Row[XuatkhomangFields.Malydo.Name].ToString();
					txt_TENLYDO.Text = _Rowview.Row[XuatkhomangFields.Tenlydo.Name].ToString();
					txt_LENHSX.Text = _Rowview.Row[XuatkhomangFields.Lenhsx.Name].ToString();
					txt_SOPHIEUGIAO.Text = _Rowview.Row[XuatkhomangFields.Sophieugiao.Name].ToString();
					txt_MADONHANG.Text = _Rowview.Row[XuatkhomangFields.Madonhang.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[XuatkhomangFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[XuatkhomangFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[XuatkhomangFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[XuatkhomangFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_XUATKHOMANG_CurrentChanged"); }
		}

		private string Save_Data(string _str_XUATKHOMANG_PK)
		{
			XuatkhomangEntity _XuatkhomangEntity = new XuatkhomangEntity();
			try { _XuatkhomangEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			try { _XuatkhomangEntity.Ngayxuat = System.DateTime.Parse(txt_NGAYXUAT.Text.Trim()); } 
			catch { }
			_XuatkhomangEntity.Makho = txt_MAKHO.Text.Trim();
			_XuatkhomangEntity.Tenkho = txt_TENKHO.Text.Trim();
			_XuatkhomangEntity.Mamang = txt_MAMANG.Text.Trim();
			_XuatkhomangEntity.Tenmang = txt_TENMANG.Text.Trim();
			try { _XuatkhomangEntity.Somet = System.Decimal.Parse(txt_SOMET.Text.Trim()); } 
			catch { }
			try { _XuatkhomangEntity.Sokg = System.Decimal.Parse(txt_SOKG.Text.Trim()); } 
			catch { }
			_XuatkhomangEntity.Malydo = txt_MALYDO.Text.Trim();
			_XuatkhomangEntity.Tenlydo = txt_TENLYDO.Text.Trim();
			_XuatkhomangEntity.Lenhsx = txt_LENHSX.Text.Trim();
			_XuatkhomangEntity.Sophieugiao = txt_SOPHIEUGIAO.Text.Trim();
			_XuatkhomangEntity.Madonhang = txt_MADONHANG.Text.Trim();
			try { _XuatkhomangEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_XuatkhomangEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _XuatkhomangEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_XuatkhomangEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_XUATKHOMANG_PK))
			{
				_str_XUATKHOMANG_PK = _XuatkhomangManager.InsertV2(_XuatkhomangEntity, r_Insert, DT_XUATKHOMANG, BS_XUATKHOMANG);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhomangManager.Convert(_XuatkhomangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_XUATKHOMANG.ResetCurrentItem();
			}
			else
			{
				_XuatkhomangManager.Update(_XuatkhomangEntity);
				
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Id.Name].Value = _XuatkhomangEntity.Id;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Ngayxuat.Name].Value = _XuatkhomangEntity.Ngayxuat;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Makho.Name].Value = _XuatkhomangEntity.Makho;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Tenkho.Name].Value = _XuatkhomangEntity.Tenkho;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Mamang.Name].Value = _XuatkhomangEntity.Mamang;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Tenmang.Name].Value = _XuatkhomangEntity.Tenmang;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Somet.Name].Value = _XuatkhomangEntity.Somet;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Sokg.Name].Value = _XuatkhomangEntity.Sokg;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Malydo.Name].Value = _XuatkhomangEntity.Malydo;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Tenlydo.Name].Value = _XuatkhomangEntity.Tenlydo;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Lenhsx.Name].Value = _XuatkhomangEntity.Lenhsx;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Sophieugiao.Name].Value = _XuatkhomangEntity.Sophieugiao;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Madonhang.Name].Value = _XuatkhomangEntity.Madonhang;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Ngaytao.Name].Value = _XuatkhomangEntity.Ngaytao;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Nguoitao.Name].Value = _XuatkhomangEntity.Nguoitao;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Ngaysua.Name].Value = _XuatkhomangEntity.Ngaysua;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Nguoisua.Name].Value = _XuatkhomangEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhomangManager.Convert(_XuatkhomangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_XUATKHOMANG_PK;
		}

	}
}
