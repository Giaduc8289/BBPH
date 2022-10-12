
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.XuatkhosanphamEnt
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
	public class XuatkhosanphamEnt : XuatkhosanphamEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public XuatkhosanphamEnt()
		{
			// Nothing for now.
		}

		void BS_Xuatkhosanpham_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Xuatkhosanpham.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Xuatkhosanpham.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[XuatkhosanphamFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[XuatkhosanphamFields.Id.Name].ToString();
					txt_Ngayxuat.Text = _Rowview.Row[XuatkhosanphamFields.Ngayxuat.Name].ToString();
					txt_Makho.Text = _Rowview.Row[XuatkhosanphamFields.Makho.Name].ToString();
					txt_Tenkho.Text = _Rowview.Row[XuatkhosanphamFields.Tenkho.Name].ToString();
					txt_Masanpham.Text = _Rowview.Row[XuatkhosanphamFields.Masanpham.Name].ToString();
					txt_Tensanpham.Text = _Rowview.Row[XuatkhosanphamFields.Tensanpham.Name].ToString();
					txt_Soluong.Text = _Rowview.Row[XuatkhosanphamFields.Soluong.Name].ToString();
					txt_Somet.Text = _Rowview.Row[XuatkhosanphamFields.Somet.Name].ToString();
					txt_Sokg.Text = _Rowview.Row[XuatkhosanphamFields.Sokg.Name].ToString();
					txt_Malydo.Text = _Rowview.Row[XuatkhosanphamFields.Malydo.Name].ToString();
					txt_Tenlydo.Text = _Rowview.Row[XuatkhosanphamFields.Tenlydo.Name].ToString();
					txt_Lenhsx.Text = _Rowview.Row[XuatkhosanphamFields.Lenhsx.Name].ToString();
					txt_Sophieugiao.Text = _Rowview.Row[XuatkhosanphamFields.Sophieugiao.Name].ToString();
					txt_Madonhang.Text = _Rowview.Row[XuatkhosanphamFields.Madonhang.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[XuatkhosanphamFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[XuatkhosanphamFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[XuatkhosanphamFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[XuatkhosanphamFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Xuatkhosanpham_CurrentChanged"); }
		}

		private string Save_Data(string _str_Xuatkhosanpham_PK)
		{
			XuatkhosanphamEntity _xuatkhosanphamEntity = new XuatkhosanphamEntity();
			
			_xuatkhosanphamEntity.Id = txt_Id.Text.Trim();
			_xuatkhosanphamEntity.Ngayxuat = txt_Ngayxuat.Text.Trim();
			_xuatkhosanphamEntity.Makho = txt_Makho.Text.Trim();
			_xuatkhosanphamEntity.Tenkho = txt_Tenkho.Text.Trim();
			_xuatkhosanphamEntity.Masanpham = txt_Masanpham.Text.Trim();
			_xuatkhosanphamEntity.Tensanpham = txt_Tensanpham.Text.Trim();
			_xuatkhosanphamEntity.Soluong = txt_Soluong.Text.Trim();
			_xuatkhosanphamEntity.Somet = txt_Somet.Text.Trim();
			_xuatkhosanphamEntity.Sokg = txt_Sokg.Text.Trim();
			_xuatkhosanphamEntity.Malydo = txt_Malydo.Text.Trim();
			_xuatkhosanphamEntity.Tenlydo = txt_Tenlydo.Text.Trim();
			_xuatkhosanphamEntity.Lenhsx = txt_Lenhsx.Text.Trim();
			_xuatkhosanphamEntity.Sophieugiao = txt_Sophieugiao.Text.Trim();
			_xuatkhosanphamEntity.Madonhang = txt_Madonhang.Text.Trim();
			_xuatkhosanphamEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_xuatkhosanphamEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_xuatkhosanphamEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_xuatkhosanphamEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Xuatkhosanpham_PK = _XuatkhosanphamManager.InsertV2(_XuatkhosanphamEntity, r_Insert, DT_Xuatkhosanpham, BS_Xuatkhosanpham);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhosanphamManager.Convert(_xuatkhosanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Xuatkhosanpham.ResetCurrentItem();
			}
			else
			{
				_XuatkhosanphamManager.Update(_xuatkhosanphamEntity);
				
				GRID_Xuatkhosanpham.CurrentRow.Cells[XuatkhosanphamFields.Id.Name].Value = _xuatkhosanphamEntity.Id;
				GRID_Xuatkhosanpham.CurrentRow.Cells[XuatkhosanphamFields.Ngayxuat.Name].Value = _xuatkhosanphamEntity.Ngayxuat;
				GRID_Xuatkhosanpham.CurrentRow.Cells[XuatkhosanphamFields.Makho.Name].Value = _xuatkhosanphamEntity.Makho;
				GRID_Xuatkhosanpham.CurrentRow.Cells[XuatkhosanphamFields.Tenkho.Name].Value = _xuatkhosanphamEntity.Tenkho;
				GRID_Xuatkhosanpham.CurrentRow.Cells[XuatkhosanphamFields.Masanpham.Name].Value = _xuatkhosanphamEntity.Masanpham;
				GRID_Xuatkhosanpham.CurrentRow.Cells[XuatkhosanphamFields.Tensanpham.Name].Value = _xuatkhosanphamEntity.Tensanpham;
				GRID_Xuatkhosanpham.CurrentRow.Cells[XuatkhosanphamFields.Soluong.Name].Value = _xuatkhosanphamEntity.Soluong;
				GRID_Xuatkhosanpham.CurrentRow.Cells[XuatkhosanphamFields.Somet.Name].Value = _xuatkhosanphamEntity.Somet;
				GRID_Xuatkhosanpham.CurrentRow.Cells[XuatkhosanphamFields.Sokg.Name].Value = _xuatkhosanphamEntity.Sokg;
				GRID_Xuatkhosanpham.CurrentRow.Cells[XuatkhosanphamFields.Malydo.Name].Value = _xuatkhosanphamEntity.Malydo;
				GRID_Xuatkhosanpham.CurrentRow.Cells[XuatkhosanphamFields.Tenlydo.Name].Value = _xuatkhosanphamEntity.Tenlydo;
				GRID_Xuatkhosanpham.CurrentRow.Cells[XuatkhosanphamFields.Lenhsx.Name].Value = _xuatkhosanphamEntity.Lenhsx;
				GRID_Xuatkhosanpham.CurrentRow.Cells[XuatkhosanphamFields.Sophieugiao.Name].Value = _xuatkhosanphamEntity.Sophieugiao;
				GRID_Xuatkhosanpham.CurrentRow.Cells[XuatkhosanphamFields.Madonhang.Name].Value = _xuatkhosanphamEntity.Madonhang;
				GRID_Xuatkhosanpham.CurrentRow.Cells[XuatkhosanphamFields.Ngaytao.Name].Value = _xuatkhosanphamEntity.Ngaytao;
				GRID_Xuatkhosanpham.CurrentRow.Cells[XuatkhosanphamFields.Nguoitao.Name].Value = _xuatkhosanphamEntity.Nguoitao;
				GRID_Xuatkhosanpham.CurrentRow.Cells[XuatkhosanphamFields.Ngaysua.Name].Value = _xuatkhosanphamEntity.Ngaysua;
				GRID_Xuatkhosanpham.CurrentRow.Cells[XuatkhosanphamFields.Nguoisua.Name].Value = _xuatkhosanphamEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhosanphamManager.Convert(_xuatkhosanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Xuatkhosanpham_PK;
		}

	}
}
