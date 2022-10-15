
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

		void BS_NHAPKHOMANG_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_NHAPKHOMANG.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_NHAPKHOMANG.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[NhapkhomangFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[NhapkhomangFields.Id.Name].ToString();
					txt_NGAYNHAP.Text = _Rowview.Row[NhapkhomangFields.Ngaynhap.Name].ToString();
					txt_MAKHO.Text = _Rowview.Row[NhapkhomangFields.Makho.Name].ToString();
					txt_TENKHO.Text = _Rowview.Row[NhapkhomangFields.Tenkho.Name].ToString();
					txt_MAMANG.Text = _Rowview.Row[NhapkhomangFields.Mamang.Name].ToString();
					txt_TENMANG.Text = _Rowview.Row[NhapkhomangFields.Tenmang.Name].ToString();
					txt_SOMET.Text = _Rowview.Row[NhapkhomangFields.Somet.Name].ToString();
					txt_SOKG.Text = _Rowview.Row[NhapkhomangFields.Sokg.Name].ToString();
					txt_MALYDO.Text = _Rowview.Row[NhapkhomangFields.Malydo.Name].ToString();
					txt_TENLYDO.Text = _Rowview.Row[NhapkhomangFields.Tenlydo.Name].ToString();
					txt_LENHSX.Text = _Rowview.Row[NhapkhomangFields.Lenhsx.Name].ToString();
					txt_SOHOPDONGMUA.Text = _Rowview.Row[NhapkhomangFields.Sohopdongmua.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[NhapkhomangFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[NhapkhomangFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[NhapkhomangFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[NhapkhomangFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_NHAPKHOMANG_CurrentChanged"); }
		}

		private string Save_Data(string _str_NHAPKHOMANG_PK)
		{
			NhapkhomangEntity _nhapkhomangEntity = new NhapkhomangEntity();
			
			_nhapkhomangEntity.Id = txt_ID.Text.Trim();
			_nhapkhomangEntity.Ngaynhap = txt_NGAYNHAP.Text.Trim();
			_nhapkhomangEntity.Makho = txt_MAKHO.Text.Trim();
			_nhapkhomangEntity.Tenkho = txt_TENKHO.Text.Trim();
			_nhapkhomangEntity.Mamang = txt_MAMANG.Text.Trim();
			_nhapkhomangEntity.Tenmang = txt_TENMANG.Text.Trim();
			_nhapkhomangEntity.Somet = txt_SOMET.Text.Trim();
			_nhapkhomangEntity.Sokg = txt_SOKG.Text.Trim();
			_nhapkhomangEntity.Malydo = txt_MALYDO.Text.Trim();
			_nhapkhomangEntity.Tenlydo = txt_TENLYDO.Text.Trim();
			_nhapkhomangEntity.Lenhsx = txt_LENHSX.Text.Trim();
			_nhapkhomangEntity.Sohopdongmua = txt_SOHOPDONGMUA.Text.Trim();
			_nhapkhomangEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_nhapkhomangEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_nhapkhomangEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_nhapkhomangEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_NHAPKHOMANG_PK))
			{
				_str_NHAPKHOMANG_PK = _NhapkhomangManager.InsertV2(_nhapkhomangEntity, r_Insert, DT_NHAPKHOMANG, BS_NHAPKHOMANG);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhomangManager.Convert(_nhapkhomangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_NHAPKHOMANG.ResetCurrentItem();
			}
			else
			{
				_NhapkhomangManager.Update(_nhapkhomangEntity);
				
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Id.Name].Value = _nhapkhomangEntity.Id;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Ngaynhap.Name].Value = _nhapkhomangEntity.Ngaynhap;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Makho.Name].Value = _nhapkhomangEntity.Makho;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Tenkho.Name].Value = _nhapkhomangEntity.Tenkho;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Mamang.Name].Value = _nhapkhomangEntity.Mamang;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Tenmang.Name].Value = _nhapkhomangEntity.Tenmang;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Somet.Name].Value = _nhapkhomangEntity.Somet;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Sokg.Name].Value = _nhapkhomangEntity.Sokg;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Malydo.Name].Value = _nhapkhomangEntity.Malydo;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Tenlydo.Name].Value = _nhapkhomangEntity.Tenlydo;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Lenhsx.Name].Value = _nhapkhomangEntity.Lenhsx;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Sohopdongmua.Name].Value = _nhapkhomangEntity.Sohopdongmua;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Ngaytao.Name].Value = _nhapkhomangEntity.Ngaytao;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Nguoitao.Name].Value = _nhapkhomangEntity.Nguoitao;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Ngaysua.Name].Value = _nhapkhomangEntity.Ngaysua;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Nguoisua.Name].Value = _nhapkhomangEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhomangManager.Convert(_nhapkhomangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_NHAPKHOMANG_PK;
		}

	}
}
