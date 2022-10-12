
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmnguyenlieuEnt
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
	public class DmnguyenlieuEnt : DmnguyenlieuEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmnguyenlieuEnt()
		{
			// Nothing for now.
		}

		void BS_Dmnguyenlieu_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmnguyenlieu.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmnguyenlieu.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmnguyenlieuFields.Manl.Name].ToString();
					
					txt_Manl.Text = _Rowview.Row[DmnguyenlieuFields.Manl.Name].ToString();
					txt_Tenrutgon.Text = _Rowview.Row[DmnguyenlieuFields.Tenrutgon.Name].ToString();
					txt_Manhom.Text = _Rowview.Row[DmnguyenlieuFields.Manhom.Name].ToString();
					txt_Tennhom.Text = _Rowview.Row[DmnguyenlieuFields.Tennhom.Name].ToString();
					txt_Tennl.Text = _Rowview.Row[DmnguyenlieuFields.Tennl.Name].ToString();
					txt_Gia.Text = _Rowview.Row[DmnguyenlieuFields.Gia.Name].ToString();
					txt_Ngay.Text = _Rowview.Row[DmnguyenlieuFields.Ngay.Name].ToString();
					txt_Giahientai.Text = _Rowview.Row[DmnguyenlieuFields.Giahientai.Name].ToString();
					txt_Tang.Text = _Rowview.Row[DmnguyenlieuFields.Tang.Name].ToString();
					txt_Giam.Text = _Rowview.Row[DmnguyenlieuFields.Giam.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[DmnguyenlieuFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[DmnguyenlieuFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[DmnguyenlieuFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[DmnguyenlieuFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmnguyenlieu_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmnguyenlieu_PK)
		{
			DmnguyenlieuEntity _dmnguyenlieuEntity = new DmnguyenlieuEntity();
			
			_dmnguyenlieuEntity.Manl = txt_Manl.Text.Trim();
			_dmnguyenlieuEntity.Tenrutgon = txt_Tenrutgon.Text.Trim();
			_dmnguyenlieuEntity.Manhom = txt_Manhom.Text.Trim();
			_dmnguyenlieuEntity.Tennhom = txt_Tennhom.Text.Trim();
			_dmnguyenlieuEntity.Tennl = txt_Tennl.Text.Trim();
			_dmnguyenlieuEntity.Gia = txt_Gia.Text.Trim();
			_dmnguyenlieuEntity.Ngay = txt_Ngay.Text.Trim();
			_dmnguyenlieuEntity.Giahientai = txt_Giahientai.Text.Trim();
			_dmnguyenlieuEntity.Tang = txt_Tang.Text.Trim();
			_dmnguyenlieuEntity.Giam = txt_Giam.Text.Trim();
			_dmnguyenlieuEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_dmnguyenlieuEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_dmnguyenlieuEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_dmnguyenlieuEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmnguyenlieu_PK = _DmnguyenlieuManager.InsertV2(_DmnguyenlieuEntity, r_Insert, DT_Dmnguyenlieu, BS_Dmnguyenlieu);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnguyenlieuManager.Convert(_dmnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmnguyenlieu.ResetCurrentItem();
			}
			else
			{
				_DmnguyenlieuManager.Update(_dmnguyenlieuEntity);
				
				GRID_Dmnguyenlieu.CurrentRow.Cells[DmnguyenlieuFields.Manl.Name].Value = _dmnguyenlieuEntity.Manl;
				GRID_Dmnguyenlieu.CurrentRow.Cells[DmnguyenlieuFields.Tenrutgon.Name].Value = _dmnguyenlieuEntity.Tenrutgon;
				GRID_Dmnguyenlieu.CurrentRow.Cells[DmnguyenlieuFields.Manhom.Name].Value = _dmnguyenlieuEntity.Manhom;
				GRID_Dmnguyenlieu.CurrentRow.Cells[DmnguyenlieuFields.Tennhom.Name].Value = _dmnguyenlieuEntity.Tennhom;
				GRID_Dmnguyenlieu.CurrentRow.Cells[DmnguyenlieuFields.Tennl.Name].Value = _dmnguyenlieuEntity.Tennl;
				GRID_Dmnguyenlieu.CurrentRow.Cells[DmnguyenlieuFields.Gia.Name].Value = _dmnguyenlieuEntity.Gia;
				GRID_Dmnguyenlieu.CurrentRow.Cells[DmnguyenlieuFields.Ngay.Name].Value = _dmnguyenlieuEntity.Ngay;
				GRID_Dmnguyenlieu.CurrentRow.Cells[DmnguyenlieuFields.Giahientai.Name].Value = _dmnguyenlieuEntity.Giahientai;
				GRID_Dmnguyenlieu.CurrentRow.Cells[DmnguyenlieuFields.Tang.Name].Value = _dmnguyenlieuEntity.Tang;
				GRID_Dmnguyenlieu.CurrentRow.Cells[DmnguyenlieuFields.Giam.Name].Value = _dmnguyenlieuEntity.Giam;
				GRID_Dmnguyenlieu.CurrentRow.Cells[DmnguyenlieuFields.Ngaytao.Name].Value = _dmnguyenlieuEntity.Ngaytao;
				GRID_Dmnguyenlieu.CurrentRow.Cells[DmnguyenlieuFields.Nguoitao.Name].Value = _dmnguyenlieuEntity.Nguoitao;
				GRID_Dmnguyenlieu.CurrentRow.Cells[DmnguyenlieuFields.Ngaysua.Name].Value = _dmnguyenlieuEntity.Ngaysua;
				GRID_Dmnguyenlieu.CurrentRow.Cells[DmnguyenlieuFields.Nguoisua.Name].Value = _dmnguyenlieuEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnguyenlieuManager.Convert(_dmnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmnguyenlieu_PK;
		}

	}
}
