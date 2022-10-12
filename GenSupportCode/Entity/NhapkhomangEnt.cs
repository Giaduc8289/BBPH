
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.NhapkhomangEnt
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
	public class NhapkhomangEnt : NhapkhomangEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NhapkhomangEnt()
		{
			// Nothing for now.
		}

		void BS_Nhapkhomang_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Nhapkhomang.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Nhapkhomang.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[NhapkhomangFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[NhapkhomangFields.Id.Name].ToString();
					txt_Ngaynhap.Text = _Rowview.Row[NhapkhomangFields.Ngaynhap.Name].ToString();
					txt_Makho.Text = _Rowview.Row[NhapkhomangFields.Makho.Name].ToString();
					txt_Tenkho.Text = _Rowview.Row[NhapkhomangFields.Tenkho.Name].ToString();
					txt_Mamang.Text = _Rowview.Row[NhapkhomangFields.Mamang.Name].ToString();
					txt_Tenmang.Text = _Rowview.Row[NhapkhomangFields.Tenmang.Name].ToString();
					txt_Somet.Text = _Rowview.Row[NhapkhomangFields.Somet.Name].ToString();
					txt_Sokg.Text = _Rowview.Row[NhapkhomangFields.Sokg.Name].ToString();
					txt_Malydo.Text = _Rowview.Row[NhapkhomangFields.Malydo.Name].ToString();
					txt_Tenlydo.Text = _Rowview.Row[NhapkhomangFields.Tenlydo.Name].ToString();
					txt_Lenhsx.Text = _Rowview.Row[NhapkhomangFields.Lenhsx.Name].ToString();
					txt_Sohopdongmua.Text = _Rowview.Row[NhapkhomangFields.Sohopdongmua.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[NhapkhomangFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[NhapkhomangFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[NhapkhomangFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[NhapkhomangFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Nhapkhomang_CurrentChanged"); }
		}

		private string Save_Data(string _str_Nhapkhomang_PK)
		{
			NhapkhomangEntity _nhapkhomangEntity = new NhapkhomangEntity();
			
			_nhapkhomangEntity.Id = txt_Id.Text.Trim();
			_nhapkhomangEntity.Ngaynhap = txt_Ngaynhap.Text.Trim();
			_nhapkhomangEntity.Makho = txt_Makho.Text.Trim();
			_nhapkhomangEntity.Tenkho = txt_Tenkho.Text.Trim();
			_nhapkhomangEntity.Mamang = txt_Mamang.Text.Trim();
			_nhapkhomangEntity.Tenmang = txt_Tenmang.Text.Trim();
			_nhapkhomangEntity.Somet = txt_Somet.Text.Trim();
			_nhapkhomangEntity.Sokg = txt_Sokg.Text.Trim();
			_nhapkhomangEntity.Malydo = txt_Malydo.Text.Trim();
			_nhapkhomangEntity.Tenlydo = txt_Tenlydo.Text.Trim();
			_nhapkhomangEntity.Lenhsx = txt_Lenhsx.Text.Trim();
			_nhapkhomangEntity.Sohopdongmua = txt_Sohopdongmua.Text.Trim();
			_nhapkhomangEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_nhapkhomangEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_nhapkhomangEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_nhapkhomangEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Nhapkhomang_PK = _NhapkhomangManager.InsertV2(_NhapkhomangEntity, r_Insert, DT_Nhapkhomang, BS_Nhapkhomang);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhomangManager.Convert(_nhapkhomangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Nhapkhomang.ResetCurrentItem();
			}
			else
			{
				_NhapkhomangManager.Update(_nhapkhomangEntity);
				
				GRID_Nhapkhomang.CurrentRow.Cells[NhapkhomangFields.Id.Name].Value = _nhapkhomangEntity.Id;
				GRID_Nhapkhomang.CurrentRow.Cells[NhapkhomangFields.Ngaynhap.Name].Value = _nhapkhomangEntity.Ngaynhap;
				GRID_Nhapkhomang.CurrentRow.Cells[NhapkhomangFields.Makho.Name].Value = _nhapkhomangEntity.Makho;
				GRID_Nhapkhomang.CurrentRow.Cells[NhapkhomangFields.Tenkho.Name].Value = _nhapkhomangEntity.Tenkho;
				GRID_Nhapkhomang.CurrentRow.Cells[NhapkhomangFields.Mamang.Name].Value = _nhapkhomangEntity.Mamang;
				GRID_Nhapkhomang.CurrentRow.Cells[NhapkhomangFields.Tenmang.Name].Value = _nhapkhomangEntity.Tenmang;
				GRID_Nhapkhomang.CurrentRow.Cells[NhapkhomangFields.Somet.Name].Value = _nhapkhomangEntity.Somet;
				GRID_Nhapkhomang.CurrentRow.Cells[NhapkhomangFields.Sokg.Name].Value = _nhapkhomangEntity.Sokg;
				GRID_Nhapkhomang.CurrentRow.Cells[NhapkhomangFields.Malydo.Name].Value = _nhapkhomangEntity.Malydo;
				GRID_Nhapkhomang.CurrentRow.Cells[NhapkhomangFields.Tenlydo.Name].Value = _nhapkhomangEntity.Tenlydo;
				GRID_Nhapkhomang.CurrentRow.Cells[NhapkhomangFields.Lenhsx.Name].Value = _nhapkhomangEntity.Lenhsx;
				GRID_Nhapkhomang.CurrentRow.Cells[NhapkhomangFields.Sohopdongmua.Name].Value = _nhapkhomangEntity.Sohopdongmua;
				GRID_Nhapkhomang.CurrentRow.Cells[NhapkhomangFields.Ngaytao.Name].Value = _nhapkhomangEntity.Ngaytao;
				GRID_Nhapkhomang.CurrentRow.Cells[NhapkhomangFields.Nguoitao.Name].Value = _nhapkhomangEntity.Nguoitao;
				GRID_Nhapkhomang.CurrentRow.Cells[NhapkhomangFields.Ngaysua.Name].Value = _nhapkhomangEntity.Ngaysua;
				GRID_Nhapkhomang.CurrentRow.Cells[NhapkhomangFields.Nguoisua.Name].Value = _nhapkhomangEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhomangManager.Convert(_nhapkhomangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Nhapkhomang_PK;
		}

	}
}
