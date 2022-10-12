
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

		void BS_Nhapkhosanpham_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Nhapkhosanpham.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Nhapkhosanpham.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[NhapkhosanphamFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[NhapkhosanphamFields.Id.Name].ToString();
					txt_Ngaynhap.Text = _Rowview.Row[NhapkhosanphamFields.Ngaynhap.Name].ToString();
					txt_Makho.Text = _Rowview.Row[NhapkhosanphamFields.Makho.Name].ToString();
					txt_Tenkho.Text = _Rowview.Row[NhapkhosanphamFields.Tenkho.Name].ToString();
					txt_Masanpham.Text = _Rowview.Row[NhapkhosanphamFields.Masanpham.Name].ToString();
					txt_Tensanpham.Text = _Rowview.Row[NhapkhosanphamFields.Tensanpham.Name].ToString();
					txt_Soluong.Text = _Rowview.Row[NhapkhosanphamFields.Soluong.Name].ToString();
					txt_Somet.Text = _Rowview.Row[NhapkhosanphamFields.Somet.Name].ToString();
					txt_Sokg.Text = _Rowview.Row[NhapkhosanphamFields.Sokg.Name].ToString();
					txt_Malydo.Text = _Rowview.Row[NhapkhosanphamFields.Malydo.Name].ToString();
					txt_Tenlydo.Text = _Rowview.Row[NhapkhosanphamFields.Tenlydo.Name].ToString();
					txt_Lenhsx.Text = _Rowview.Row[NhapkhosanphamFields.Lenhsx.Name].ToString();
					txt_Sohopdongmua.Text = _Rowview.Row[NhapkhosanphamFields.Sohopdongmua.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[NhapkhosanphamFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[NhapkhosanphamFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[NhapkhosanphamFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[NhapkhosanphamFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Nhapkhosanpham_CurrentChanged"); }
		}

		private string Save_Data(string _str_Nhapkhosanpham_PK)
		{
			NhapkhosanphamEntity _nhapkhosanphamEntity = new NhapkhosanphamEntity();
			
			_nhapkhosanphamEntity.Id = txt_Id.Text.Trim();
			_nhapkhosanphamEntity.Ngaynhap = txt_Ngaynhap.Text.Trim();
			_nhapkhosanphamEntity.Makho = txt_Makho.Text.Trim();
			_nhapkhosanphamEntity.Tenkho = txt_Tenkho.Text.Trim();
			_nhapkhosanphamEntity.Masanpham = txt_Masanpham.Text.Trim();
			_nhapkhosanphamEntity.Tensanpham = txt_Tensanpham.Text.Trim();
			_nhapkhosanphamEntity.Soluong = txt_Soluong.Text.Trim();
			_nhapkhosanphamEntity.Somet = txt_Somet.Text.Trim();
			_nhapkhosanphamEntity.Sokg = txt_Sokg.Text.Trim();
			_nhapkhosanphamEntity.Malydo = txt_Malydo.Text.Trim();
			_nhapkhosanphamEntity.Tenlydo = txt_Tenlydo.Text.Trim();
			_nhapkhosanphamEntity.Lenhsx = txt_Lenhsx.Text.Trim();
			_nhapkhosanphamEntity.Sohopdongmua = txt_Sohopdongmua.Text.Trim();
			_nhapkhosanphamEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_nhapkhosanphamEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_nhapkhosanphamEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_nhapkhosanphamEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Nhapkhosanpham_PK = _NhapkhosanphamManager.InsertV2(_NhapkhosanphamEntity, r_Insert, DT_Nhapkhosanpham, BS_Nhapkhosanpham);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhosanphamManager.Convert(_nhapkhosanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Nhapkhosanpham.ResetCurrentItem();
			}
			else
			{
				_NhapkhosanphamManager.Update(_nhapkhosanphamEntity);
				
				GRID_Nhapkhosanpham.CurrentRow.Cells[NhapkhosanphamFields.Id.Name].Value = _nhapkhosanphamEntity.Id;
				GRID_Nhapkhosanpham.CurrentRow.Cells[NhapkhosanphamFields.Ngaynhap.Name].Value = _nhapkhosanphamEntity.Ngaynhap;
				GRID_Nhapkhosanpham.CurrentRow.Cells[NhapkhosanphamFields.Makho.Name].Value = _nhapkhosanphamEntity.Makho;
				GRID_Nhapkhosanpham.CurrentRow.Cells[NhapkhosanphamFields.Tenkho.Name].Value = _nhapkhosanphamEntity.Tenkho;
				GRID_Nhapkhosanpham.CurrentRow.Cells[NhapkhosanphamFields.Masanpham.Name].Value = _nhapkhosanphamEntity.Masanpham;
				GRID_Nhapkhosanpham.CurrentRow.Cells[NhapkhosanphamFields.Tensanpham.Name].Value = _nhapkhosanphamEntity.Tensanpham;
				GRID_Nhapkhosanpham.CurrentRow.Cells[NhapkhosanphamFields.Soluong.Name].Value = _nhapkhosanphamEntity.Soluong;
				GRID_Nhapkhosanpham.CurrentRow.Cells[NhapkhosanphamFields.Somet.Name].Value = _nhapkhosanphamEntity.Somet;
				GRID_Nhapkhosanpham.CurrentRow.Cells[NhapkhosanphamFields.Sokg.Name].Value = _nhapkhosanphamEntity.Sokg;
				GRID_Nhapkhosanpham.CurrentRow.Cells[NhapkhosanphamFields.Malydo.Name].Value = _nhapkhosanphamEntity.Malydo;
				GRID_Nhapkhosanpham.CurrentRow.Cells[NhapkhosanphamFields.Tenlydo.Name].Value = _nhapkhosanphamEntity.Tenlydo;
				GRID_Nhapkhosanpham.CurrentRow.Cells[NhapkhosanphamFields.Lenhsx.Name].Value = _nhapkhosanphamEntity.Lenhsx;
				GRID_Nhapkhosanpham.CurrentRow.Cells[NhapkhosanphamFields.Sohopdongmua.Name].Value = _nhapkhosanphamEntity.Sohopdongmua;
				GRID_Nhapkhosanpham.CurrentRow.Cells[NhapkhosanphamFields.Ngaytao.Name].Value = _nhapkhosanphamEntity.Ngaytao;
				GRID_Nhapkhosanpham.CurrentRow.Cells[NhapkhosanphamFields.Nguoitao.Name].Value = _nhapkhosanphamEntity.Nguoitao;
				GRID_Nhapkhosanpham.CurrentRow.Cells[NhapkhosanphamFields.Ngaysua.Name].Value = _nhapkhosanphamEntity.Ngaysua;
				GRID_Nhapkhosanpham.CurrentRow.Cells[NhapkhosanphamFields.Nguoisua.Name].Value = _nhapkhosanphamEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhosanphamManager.Convert(_nhapkhosanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Nhapkhosanpham_PK;
		}

	}
}
