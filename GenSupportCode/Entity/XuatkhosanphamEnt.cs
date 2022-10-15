
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

		void BS_XUATKHOSANPHAM_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_XUATKHOSANPHAM.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_XUATKHOSANPHAM.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[XuatkhosanphamFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[XuatkhosanphamFields.Id.Name].ToString();
					txt_NGAYXUAT.Text = _Rowview.Row[XuatkhosanphamFields.Ngayxuat.Name].ToString();
					txt_MAKHO.Text = _Rowview.Row[XuatkhosanphamFields.Makho.Name].ToString();
					txt_TENKHO.Text = _Rowview.Row[XuatkhosanphamFields.Tenkho.Name].ToString();
					txt_MASANPHAM.Text = _Rowview.Row[XuatkhosanphamFields.Masanpham.Name].ToString();
					txt_TENSANPHAM.Text = _Rowview.Row[XuatkhosanphamFields.Tensanpham.Name].ToString();
					txt_SOLUONG.Text = _Rowview.Row[XuatkhosanphamFields.Soluong.Name].ToString();
					txt_SOMET.Text = _Rowview.Row[XuatkhosanphamFields.Somet.Name].ToString();
					txt_SOKG.Text = _Rowview.Row[XuatkhosanphamFields.Sokg.Name].ToString();
					txt_MALYDO.Text = _Rowview.Row[XuatkhosanphamFields.Malydo.Name].ToString();
					txt_TENLYDO.Text = _Rowview.Row[XuatkhosanphamFields.Tenlydo.Name].ToString();
					txt_LENHSX.Text = _Rowview.Row[XuatkhosanphamFields.Lenhsx.Name].ToString();
					txt_SOPHIEUGIAO.Text = _Rowview.Row[XuatkhosanphamFields.Sophieugiao.Name].ToString();
					txt_MADONHANG.Text = _Rowview.Row[XuatkhosanphamFields.Madonhang.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[XuatkhosanphamFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[XuatkhosanphamFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[XuatkhosanphamFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[XuatkhosanphamFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_XUATKHOSANPHAM_CurrentChanged"); }
		}

		private string Save_Data(string _str_XUATKHOSANPHAM_PK)
		{
			XuatkhosanphamEntity _xuatkhosanphamEntity = new XuatkhosanphamEntity();
			
			_xuatkhosanphamEntity.Id = txt_ID.Text.Trim();
			_xuatkhosanphamEntity.Ngayxuat = txt_NGAYXUAT.Text.Trim();
			_xuatkhosanphamEntity.Makho = txt_MAKHO.Text.Trim();
			_xuatkhosanphamEntity.Tenkho = txt_TENKHO.Text.Trim();
			_xuatkhosanphamEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_xuatkhosanphamEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
			_xuatkhosanphamEntity.Soluong = txt_SOLUONG.Text.Trim();
			_xuatkhosanphamEntity.Somet = txt_SOMET.Text.Trim();
			_xuatkhosanphamEntity.Sokg = txt_SOKG.Text.Trim();
			_xuatkhosanphamEntity.Malydo = txt_MALYDO.Text.Trim();
			_xuatkhosanphamEntity.Tenlydo = txt_TENLYDO.Text.Trim();
			_xuatkhosanphamEntity.Lenhsx = txt_LENHSX.Text.Trim();
			_xuatkhosanphamEntity.Sophieugiao = txt_SOPHIEUGIAO.Text.Trim();
			_xuatkhosanphamEntity.Madonhang = txt_MADONHANG.Text.Trim();
			_xuatkhosanphamEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_xuatkhosanphamEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_xuatkhosanphamEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_xuatkhosanphamEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_XUATKHOSANPHAM_PK))
			{
				_str_XUATKHOSANPHAM_PK = _XuatkhosanphamManager.InsertV2(_xuatkhosanphamEntity, r_Insert, DT_XUATKHOSANPHAM, BS_XUATKHOSANPHAM);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhosanphamManager.Convert(_xuatkhosanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_XUATKHOSANPHAM.ResetCurrentItem();
			}
			else
			{
				_XuatkhosanphamManager.Update(_xuatkhosanphamEntity);
				
				GRID_XUATKHOSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Id.Name].Value = _xuatkhosanphamEntity.Id;
				GRID_XUATKHOSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Ngayxuat.Name].Value = _xuatkhosanphamEntity.Ngayxuat;
				GRID_XUATKHOSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Makho.Name].Value = _xuatkhosanphamEntity.Makho;
				GRID_XUATKHOSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Tenkho.Name].Value = _xuatkhosanphamEntity.Tenkho;
				GRID_XUATKHOSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Masanpham.Name].Value = _xuatkhosanphamEntity.Masanpham;
				GRID_XUATKHOSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Tensanpham.Name].Value = _xuatkhosanphamEntity.Tensanpham;
				GRID_XUATKHOSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Soluong.Name].Value = _xuatkhosanphamEntity.Soluong;
				GRID_XUATKHOSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Somet.Name].Value = _xuatkhosanphamEntity.Somet;
				GRID_XUATKHOSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Sokg.Name].Value = _xuatkhosanphamEntity.Sokg;
				GRID_XUATKHOSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Malydo.Name].Value = _xuatkhosanphamEntity.Malydo;
				GRID_XUATKHOSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Tenlydo.Name].Value = _xuatkhosanphamEntity.Tenlydo;
				GRID_XUATKHOSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Lenhsx.Name].Value = _xuatkhosanphamEntity.Lenhsx;
				GRID_XUATKHOSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Sophieugiao.Name].Value = _xuatkhosanphamEntity.Sophieugiao;
				GRID_XUATKHOSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Madonhang.Name].Value = _xuatkhosanphamEntity.Madonhang;
				GRID_XUATKHOSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Ngaytao.Name].Value = _xuatkhosanphamEntity.Ngaytao;
				GRID_XUATKHOSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Nguoitao.Name].Value = _xuatkhosanphamEntity.Nguoitao;
				GRID_XUATKHOSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Ngaysua.Name].Value = _xuatkhosanphamEntity.Ngaysua;
				GRID_XUATKHOSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Nguoisua.Name].Value = _xuatkhosanphamEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhosanphamManager.Convert(_xuatkhosanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_XUATKHOSANPHAM_PK;
		}

	}
}
