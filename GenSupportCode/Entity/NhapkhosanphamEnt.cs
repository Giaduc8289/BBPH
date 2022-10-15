
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.NhapkhosanphamEnt
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
	public class NhapkhosanphamEnt : NhapkhosanphamEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NhapkhosanphamEnt()
		{
			// Nothing for now.
		}

		void BS_NHAPKHOSANPHAM_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_NHAPKHOSANPHAM.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_NHAPKHOSANPHAM.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[NhapkhosanphamFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[NhapkhosanphamFields.Id.Name].ToString();
					txt_NGAYNHAP.Text = _Rowview.Row[NhapkhosanphamFields.Ngaynhap.Name].ToString();
					txt_MAKHO.Text = _Rowview.Row[NhapkhosanphamFields.Makho.Name].ToString();
					txt_TENKHO.Text = _Rowview.Row[NhapkhosanphamFields.Tenkho.Name].ToString();
					txt_MASANPHAM.Text = _Rowview.Row[NhapkhosanphamFields.Masanpham.Name].ToString();
					txt_TENSANPHAM.Text = _Rowview.Row[NhapkhosanphamFields.Tensanpham.Name].ToString();
					txt_SOLUONG.Text = _Rowview.Row[NhapkhosanphamFields.Soluong.Name].ToString();
					txt_SOMET.Text = _Rowview.Row[NhapkhosanphamFields.Somet.Name].ToString();
					txt_SOKG.Text = _Rowview.Row[NhapkhosanphamFields.Sokg.Name].ToString();
					txt_MALYDO.Text = _Rowview.Row[NhapkhosanphamFields.Malydo.Name].ToString();
					txt_TENLYDO.Text = _Rowview.Row[NhapkhosanphamFields.Tenlydo.Name].ToString();
					txt_LENHSX.Text = _Rowview.Row[NhapkhosanphamFields.Lenhsx.Name].ToString();
					txt_SOHOPDONGMUA.Text = _Rowview.Row[NhapkhosanphamFields.Sohopdongmua.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[NhapkhosanphamFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[NhapkhosanphamFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[NhapkhosanphamFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[NhapkhosanphamFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_NHAPKHOSANPHAM_CurrentChanged"); }
		}

		private string Save_Data(string _str_NHAPKHOSANPHAM_PK)
		{
			NhapkhosanphamEntity _nhapkhosanphamEntity = new NhapkhosanphamEntity();
			
			_nhapkhosanphamEntity.Id = txt_ID.Text.Trim();
			_nhapkhosanphamEntity.Ngaynhap = txt_NGAYNHAP.Text.Trim();
			_nhapkhosanphamEntity.Makho = txt_MAKHO.Text.Trim();
			_nhapkhosanphamEntity.Tenkho = txt_TENKHO.Text.Trim();
			_nhapkhosanphamEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_nhapkhosanphamEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
			_nhapkhosanphamEntity.Soluong = txt_SOLUONG.Text.Trim();
			_nhapkhosanphamEntity.Somet = txt_SOMET.Text.Trim();
			_nhapkhosanphamEntity.Sokg = txt_SOKG.Text.Trim();
			_nhapkhosanphamEntity.Malydo = txt_MALYDO.Text.Trim();
			_nhapkhosanphamEntity.Tenlydo = txt_TENLYDO.Text.Trim();
			_nhapkhosanphamEntity.Lenhsx = txt_LENHSX.Text.Trim();
			_nhapkhosanphamEntity.Sohopdongmua = txt_SOHOPDONGMUA.Text.Trim();
			_nhapkhosanphamEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_nhapkhosanphamEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_nhapkhosanphamEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_nhapkhosanphamEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_NHAPKHOSANPHAM_PK))
			{
				_str_NHAPKHOSANPHAM_PK = _NhapkhosanphamManager.InsertV2(_nhapkhosanphamEntity, r_Insert, DT_NHAPKHOSANPHAM, BS_NHAPKHOSANPHAM);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhosanphamManager.Convert(_nhapkhosanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_NHAPKHOSANPHAM.ResetCurrentItem();
			}
			else
			{
				_NhapkhosanphamManager.Update(_nhapkhosanphamEntity);
				
				GRID_NHAPKHOSANPHAM.CurrentRow.Cells[NhapkhosanphamFields.Id.Name].Value = _nhapkhosanphamEntity.Id;
				GRID_NHAPKHOSANPHAM.CurrentRow.Cells[NhapkhosanphamFields.Ngaynhap.Name].Value = _nhapkhosanphamEntity.Ngaynhap;
				GRID_NHAPKHOSANPHAM.CurrentRow.Cells[NhapkhosanphamFields.Makho.Name].Value = _nhapkhosanphamEntity.Makho;
				GRID_NHAPKHOSANPHAM.CurrentRow.Cells[NhapkhosanphamFields.Tenkho.Name].Value = _nhapkhosanphamEntity.Tenkho;
				GRID_NHAPKHOSANPHAM.CurrentRow.Cells[NhapkhosanphamFields.Masanpham.Name].Value = _nhapkhosanphamEntity.Masanpham;
				GRID_NHAPKHOSANPHAM.CurrentRow.Cells[NhapkhosanphamFields.Tensanpham.Name].Value = _nhapkhosanphamEntity.Tensanpham;
				GRID_NHAPKHOSANPHAM.CurrentRow.Cells[NhapkhosanphamFields.Soluong.Name].Value = _nhapkhosanphamEntity.Soluong;
				GRID_NHAPKHOSANPHAM.CurrentRow.Cells[NhapkhosanphamFields.Somet.Name].Value = _nhapkhosanphamEntity.Somet;
				GRID_NHAPKHOSANPHAM.CurrentRow.Cells[NhapkhosanphamFields.Sokg.Name].Value = _nhapkhosanphamEntity.Sokg;
				GRID_NHAPKHOSANPHAM.CurrentRow.Cells[NhapkhosanphamFields.Malydo.Name].Value = _nhapkhosanphamEntity.Malydo;
				GRID_NHAPKHOSANPHAM.CurrentRow.Cells[NhapkhosanphamFields.Tenlydo.Name].Value = _nhapkhosanphamEntity.Tenlydo;
				GRID_NHAPKHOSANPHAM.CurrentRow.Cells[NhapkhosanphamFields.Lenhsx.Name].Value = _nhapkhosanphamEntity.Lenhsx;
				GRID_NHAPKHOSANPHAM.CurrentRow.Cells[NhapkhosanphamFields.Sohopdongmua.Name].Value = _nhapkhosanphamEntity.Sohopdongmua;
				GRID_NHAPKHOSANPHAM.CurrentRow.Cells[NhapkhosanphamFields.Ngaytao.Name].Value = _nhapkhosanphamEntity.Ngaytao;
				GRID_NHAPKHOSANPHAM.CurrentRow.Cells[NhapkhosanphamFields.Nguoitao.Name].Value = _nhapkhosanphamEntity.Nguoitao;
				GRID_NHAPKHOSANPHAM.CurrentRow.Cells[NhapkhosanphamFields.Ngaysua.Name].Value = _nhapkhosanphamEntity.Ngaysua;
				GRID_NHAPKHOSANPHAM.CurrentRow.Cells[NhapkhosanphamFields.Nguoisua.Name].Value = _nhapkhosanphamEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhosanphamManager.Convert(_nhapkhosanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_NHAPKHOSANPHAM_PK;
		}

	}
}
