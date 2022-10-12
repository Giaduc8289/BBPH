
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

		void BS_Xuatkhomang_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Xuatkhomang.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Xuatkhomang.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[XuatkhomangFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[XuatkhomangFields.Id.Name].ToString();
					txt_Ngayxuat.Text = _Rowview.Row[XuatkhomangFields.Ngayxuat.Name].ToString();
					txt_Makho.Text = _Rowview.Row[XuatkhomangFields.Makho.Name].ToString();
					txt_Tenkho.Text = _Rowview.Row[XuatkhomangFields.Tenkho.Name].ToString();
					txt_Mamang.Text = _Rowview.Row[XuatkhomangFields.Mamang.Name].ToString();
					txt_Tenmang.Text = _Rowview.Row[XuatkhomangFields.Tenmang.Name].ToString();
					txt_Somet.Text = _Rowview.Row[XuatkhomangFields.Somet.Name].ToString();
					txt_Sokg.Text = _Rowview.Row[XuatkhomangFields.Sokg.Name].ToString();
					txt_Malydo.Text = _Rowview.Row[XuatkhomangFields.Malydo.Name].ToString();
					txt_Tenlydo.Text = _Rowview.Row[XuatkhomangFields.Tenlydo.Name].ToString();
					txt_Lenhsx.Text = _Rowview.Row[XuatkhomangFields.Lenhsx.Name].ToString();
					txt_Sophieugiao.Text = _Rowview.Row[XuatkhomangFields.Sophieugiao.Name].ToString();
					txt_Madonhang.Text = _Rowview.Row[XuatkhomangFields.Madonhang.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[XuatkhomangFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[XuatkhomangFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[XuatkhomangFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[XuatkhomangFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Xuatkhomang_CurrentChanged"); }
		}

		private string Save_Data(string _str_Xuatkhomang_PK)
		{
			XuatkhomangEntity _xuatkhomangEntity = new XuatkhomangEntity();
			
			_xuatkhomangEntity.Id = txt_Id.Text.Trim();
			_xuatkhomangEntity.Ngayxuat = txt_Ngayxuat.Text.Trim();
			_xuatkhomangEntity.Makho = txt_Makho.Text.Trim();
			_xuatkhomangEntity.Tenkho = txt_Tenkho.Text.Trim();
			_xuatkhomangEntity.Mamang = txt_Mamang.Text.Trim();
			_xuatkhomangEntity.Tenmang = txt_Tenmang.Text.Trim();
			_xuatkhomangEntity.Somet = txt_Somet.Text.Trim();
			_xuatkhomangEntity.Sokg = txt_Sokg.Text.Trim();
			_xuatkhomangEntity.Malydo = txt_Malydo.Text.Trim();
			_xuatkhomangEntity.Tenlydo = txt_Tenlydo.Text.Trim();
			_xuatkhomangEntity.Lenhsx = txt_Lenhsx.Text.Trim();
			_xuatkhomangEntity.Sophieugiao = txt_Sophieugiao.Text.Trim();
			_xuatkhomangEntity.Madonhang = txt_Madonhang.Text.Trim();
			_xuatkhomangEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_xuatkhomangEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_xuatkhomangEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_xuatkhomangEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Xuatkhomang_PK = _XuatkhomangManager.InsertV2(_XuatkhomangEntity, r_Insert, DT_Xuatkhomang, BS_Xuatkhomang);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhomangManager.Convert(_xuatkhomangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Xuatkhomang.ResetCurrentItem();
			}
			else
			{
				_XuatkhomangManager.Update(_xuatkhomangEntity);
				
				GRID_Xuatkhomang.CurrentRow.Cells[XuatkhomangFields.Id.Name].Value = _xuatkhomangEntity.Id;
				GRID_Xuatkhomang.CurrentRow.Cells[XuatkhomangFields.Ngayxuat.Name].Value = _xuatkhomangEntity.Ngayxuat;
				GRID_Xuatkhomang.CurrentRow.Cells[XuatkhomangFields.Makho.Name].Value = _xuatkhomangEntity.Makho;
				GRID_Xuatkhomang.CurrentRow.Cells[XuatkhomangFields.Tenkho.Name].Value = _xuatkhomangEntity.Tenkho;
				GRID_Xuatkhomang.CurrentRow.Cells[XuatkhomangFields.Mamang.Name].Value = _xuatkhomangEntity.Mamang;
				GRID_Xuatkhomang.CurrentRow.Cells[XuatkhomangFields.Tenmang.Name].Value = _xuatkhomangEntity.Tenmang;
				GRID_Xuatkhomang.CurrentRow.Cells[XuatkhomangFields.Somet.Name].Value = _xuatkhomangEntity.Somet;
				GRID_Xuatkhomang.CurrentRow.Cells[XuatkhomangFields.Sokg.Name].Value = _xuatkhomangEntity.Sokg;
				GRID_Xuatkhomang.CurrentRow.Cells[XuatkhomangFields.Malydo.Name].Value = _xuatkhomangEntity.Malydo;
				GRID_Xuatkhomang.CurrentRow.Cells[XuatkhomangFields.Tenlydo.Name].Value = _xuatkhomangEntity.Tenlydo;
				GRID_Xuatkhomang.CurrentRow.Cells[XuatkhomangFields.Lenhsx.Name].Value = _xuatkhomangEntity.Lenhsx;
				GRID_Xuatkhomang.CurrentRow.Cells[XuatkhomangFields.Sophieugiao.Name].Value = _xuatkhomangEntity.Sophieugiao;
				GRID_Xuatkhomang.CurrentRow.Cells[XuatkhomangFields.Madonhang.Name].Value = _xuatkhomangEntity.Madonhang;
				GRID_Xuatkhomang.CurrentRow.Cells[XuatkhomangFields.Ngaytao.Name].Value = _xuatkhomangEntity.Ngaytao;
				GRID_Xuatkhomang.CurrentRow.Cells[XuatkhomangFields.Nguoitao.Name].Value = _xuatkhomangEntity.Nguoitao;
				GRID_Xuatkhomang.CurrentRow.Cells[XuatkhomangFields.Ngaysua.Name].Value = _xuatkhomangEntity.Ngaysua;
				GRID_Xuatkhomang.CurrentRow.Cells[XuatkhomangFields.Nguoisua.Name].Value = _xuatkhomangEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhomangManager.Convert(_xuatkhomangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Xuatkhomang_PK;
		}

	}
}
