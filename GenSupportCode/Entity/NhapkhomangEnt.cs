
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
					txt_CUONDO.Text = _Rowview.Row[NhapkhomangFields.Cuondo.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_NHAPKHOMANG_CurrentChanged"); }
		}

		private string Save_Data(string _str_NHAPKHOMANG_PK)
		{
			NhapkhomangEntity _NhapkhomangEntity = new NhapkhomangEntity();
			try { _NhapkhomangEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			try { _NhapkhomangEntity.Ngaynhap = System.DateTime.Parse(txt_NGAYNHAP.Text.Trim()); } 
			catch { }
			_NhapkhomangEntity.Makho = txt_MAKHO.Text.Trim();
			_NhapkhomangEntity.Tenkho = txt_TENKHO.Text.Trim();
			_NhapkhomangEntity.Mamang = txt_MAMANG.Text.Trim();
			_NhapkhomangEntity.Tenmang = txt_TENMANG.Text.Trim();
			try { _NhapkhomangEntity.Somet = System.Decimal.Parse(txt_SOMET.Text.Trim()); } 
			catch { }
			try { _NhapkhomangEntity.Sokg = System.Decimal.Parse(txt_SOKG.Text.Trim()); } 
			catch { }
			_NhapkhomangEntity.Malydo = txt_MALYDO.Text.Trim();
			_NhapkhomangEntity.Tenlydo = txt_TENLYDO.Text.Trim();
			_NhapkhomangEntity.Lenhsx = txt_LENHSX.Text.Trim();
			_NhapkhomangEntity.Sohopdongmua = txt_SOHOPDONGMUA.Text.Trim();
			try { _NhapkhomangEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_NhapkhomangEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _NhapkhomangEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_NhapkhomangEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			try { _NhapkhomangEntity.Cuondo = System.Boolean.Parse(txt_CUONDO.Text.Trim()); } 
			catch { }
			
			
			if (string.IsNullOrEmpty(_str_NHAPKHOMANG_PK))
			{
				_str_NHAPKHOMANG_PK = _NhapkhomangManager.InsertV2(_NhapkhomangEntity, r_Insert, DT_NHAPKHOMANG, BS_NHAPKHOMANG);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhomangManager.Convert(_NhapkhomangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_NHAPKHOMANG.ResetCurrentItem();
			}
			else
			{
				_NhapkhomangManager.Update(_NhapkhomangEntity);
				
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Id.Name].Value = _NhapkhomangEntity.Id;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Ngaynhap.Name].Value = _NhapkhomangEntity.Ngaynhap;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Makho.Name].Value = _NhapkhomangEntity.Makho;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Tenkho.Name].Value = _NhapkhomangEntity.Tenkho;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Mamang.Name].Value = _NhapkhomangEntity.Mamang;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Tenmang.Name].Value = _NhapkhomangEntity.Tenmang;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Somet.Name].Value = _NhapkhomangEntity.Somet;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Sokg.Name].Value = _NhapkhomangEntity.Sokg;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Malydo.Name].Value = _NhapkhomangEntity.Malydo;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Tenlydo.Name].Value = _NhapkhomangEntity.Tenlydo;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Lenhsx.Name].Value = _NhapkhomangEntity.Lenhsx;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Sohopdongmua.Name].Value = _NhapkhomangEntity.Sohopdongmua;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Ngaytao.Name].Value = _NhapkhomangEntity.Ngaytao;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Nguoitao.Name].Value = _NhapkhomangEntity.Nguoitao;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Ngaysua.Name].Value = _NhapkhomangEntity.Ngaysua;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Nguoisua.Name].Value = _NhapkhomangEntity.Nguoisua;
				GRID_NHAPKHOMANG.CurrentRow.Cells[NhapkhomangFields.Cuondo.Name].Value = _NhapkhomangEntity.Cuondo;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhomangManager.Convert(_NhapkhomangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_NHAPKHOMANG_PK;
		}

	}
}
