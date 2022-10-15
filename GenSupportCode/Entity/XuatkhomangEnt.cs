
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
			XuatkhomangEntity _xuatkhomangEntity = new XuatkhomangEntity();
			
			_xuatkhomangEntity.Id = txt_ID.Text.Trim();
			_xuatkhomangEntity.Ngayxuat = txt_NGAYXUAT.Text.Trim();
			_xuatkhomangEntity.Makho = txt_MAKHO.Text.Trim();
			_xuatkhomangEntity.Tenkho = txt_TENKHO.Text.Trim();
			_xuatkhomangEntity.Mamang = txt_MAMANG.Text.Trim();
			_xuatkhomangEntity.Tenmang = txt_TENMANG.Text.Trim();
			_xuatkhomangEntity.Somet = txt_SOMET.Text.Trim();
			_xuatkhomangEntity.Sokg = txt_SOKG.Text.Trim();
			_xuatkhomangEntity.Malydo = txt_MALYDO.Text.Trim();
			_xuatkhomangEntity.Tenlydo = txt_TENLYDO.Text.Trim();
			_xuatkhomangEntity.Lenhsx = txt_LENHSX.Text.Trim();
			_xuatkhomangEntity.Sophieugiao = txt_SOPHIEUGIAO.Text.Trim();
			_xuatkhomangEntity.Madonhang = txt_MADONHANG.Text.Trim();
			_xuatkhomangEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_xuatkhomangEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_xuatkhomangEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_xuatkhomangEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_XUATKHOMANG_PK))
			{
				_str_XUATKHOMANG_PK = _XuatkhomangManager.InsertV2(_xuatkhomangEntity, r_Insert, DT_XUATKHOMANG, BS_XUATKHOMANG);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhomangManager.Convert(_xuatkhomangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_XUATKHOMANG.ResetCurrentItem();
			}
			else
			{
				_XuatkhomangManager.Update(_xuatkhomangEntity);
				
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Id.Name].Value = _xuatkhomangEntity.Id;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Ngayxuat.Name].Value = _xuatkhomangEntity.Ngayxuat;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Makho.Name].Value = _xuatkhomangEntity.Makho;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Tenkho.Name].Value = _xuatkhomangEntity.Tenkho;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Mamang.Name].Value = _xuatkhomangEntity.Mamang;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Tenmang.Name].Value = _xuatkhomangEntity.Tenmang;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Somet.Name].Value = _xuatkhomangEntity.Somet;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Sokg.Name].Value = _xuatkhomangEntity.Sokg;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Malydo.Name].Value = _xuatkhomangEntity.Malydo;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Tenlydo.Name].Value = _xuatkhomangEntity.Tenlydo;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Lenhsx.Name].Value = _xuatkhomangEntity.Lenhsx;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Sophieugiao.Name].Value = _xuatkhomangEntity.Sophieugiao;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Madonhang.Name].Value = _xuatkhomangEntity.Madonhang;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Ngaytao.Name].Value = _xuatkhomangEntity.Ngaytao;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Nguoitao.Name].Value = _xuatkhomangEntity.Nguoitao;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Ngaysua.Name].Value = _xuatkhomangEntity.Ngaysua;
				GRID_XUATKHOMANG.CurrentRow.Cells[XuatkhomangFields.Nguoisua.Name].Value = _xuatkhomangEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhomangManager.Convert(_xuatkhomangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_XUATKHOMANG_PK;
		}

	}
}
