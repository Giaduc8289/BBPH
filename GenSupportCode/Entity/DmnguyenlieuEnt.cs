
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

		void BS_DMNGUYENLIEU_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMNGUYENLIEU.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMNGUYENLIEU.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmnguyenlieuFields.Manl.Name].ToString();
					
					txt_MANL.Text = _Rowview.Row[DmnguyenlieuFields.Manl.Name].ToString();
					txt_TENRUTGON.Text = _Rowview.Row[DmnguyenlieuFields.Tenrutgon.Name].ToString();
					txt_MANHOM.Text = _Rowview.Row[DmnguyenlieuFields.Manhom.Name].ToString();
					txt_TENNHOM.Text = _Rowview.Row[DmnguyenlieuFields.Tennhom.Name].ToString();
					txt_TENNL.Text = _Rowview.Row[DmnguyenlieuFields.Tennl.Name].ToString();
					txt_GIA.Text = _Rowview.Row[DmnguyenlieuFields.Gia.Name].ToString();
					txt_NGAY.Text = _Rowview.Row[DmnguyenlieuFields.Ngay.Name].ToString();
					txt_GIAHIENTAI.Text = _Rowview.Row[DmnguyenlieuFields.Giahientai.Name].ToString();
					txt_TANG.Text = _Rowview.Row[DmnguyenlieuFields.Tang.Name].ToString();
					txt_GIAM.Text = _Rowview.Row[DmnguyenlieuFields.Giam.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmnguyenlieuFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmnguyenlieuFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmnguyenlieuFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmnguyenlieuFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMNGUYENLIEU_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMNGUYENLIEU_PK)
		{
			DmnguyenlieuEntity _dmnguyenlieuEntity = new DmnguyenlieuEntity();
			
			_dmnguyenlieuEntity.Manl = txt_MANL.Text.Trim();
			_dmnguyenlieuEntity.Tenrutgon = txt_TENRUTGON.Text.Trim();
			_dmnguyenlieuEntity.Manhom = txt_MANHOM.Text.Trim();
			_dmnguyenlieuEntity.Tennhom = txt_TENNHOM.Text.Trim();
			_dmnguyenlieuEntity.Tennl = txt_TENNL.Text.Trim();
			_dmnguyenlieuEntity.Gia = txt_GIA.Text.Trim();
			_dmnguyenlieuEntity.Ngay = txt_NGAY.Text.Trim();
			_dmnguyenlieuEntity.Giahientai = txt_GIAHIENTAI.Text.Trim();
			_dmnguyenlieuEntity.Tang = txt_TANG.Text.Trim();
			_dmnguyenlieuEntity.Giam = txt_GIAM.Text.Trim();
			_dmnguyenlieuEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dmnguyenlieuEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dmnguyenlieuEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dmnguyenlieuEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMNGUYENLIEU_PK))
			{
				_str_DMNGUYENLIEU_PK = _DmnguyenlieuManager.InsertV2(_dmnguyenlieuEntity, r_Insert, DT_DMNGUYENLIEU, BS_DMNGUYENLIEU);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnguyenlieuManager.Convert(_dmnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMNGUYENLIEU.ResetCurrentItem();
			}
			else
			{
				_DmnguyenlieuManager.Update(_dmnguyenlieuEntity);
				
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Manl.Name].Value = _dmnguyenlieuEntity.Manl;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Tenrutgon.Name].Value = _dmnguyenlieuEntity.Tenrutgon;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Manhom.Name].Value = _dmnguyenlieuEntity.Manhom;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Tennhom.Name].Value = _dmnguyenlieuEntity.Tennhom;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Tennl.Name].Value = _dmnguyenlieuEntity.Tennl;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Gia.Name].Value = _dmnguyenlieuEntity.Gia;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Ngay.Name].Value = _dmnguyenlieuEntity.Ngay;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Giahientai.Name].Value = _dmnguyenlieuEntity.Giahientai;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Tang.Name].Value = _dmnguyenlieuEntity.Tang;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Giam.Name].Value = _dmnguyenlieuEntity.Giam;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Ngaytao.Name].Value = _dmnguyenlieuEntity.Ngaytao;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Nguoitao.Name].Value = _dmnguyenlieuEntity.Nguoitao;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Ngaysua.Name].Value = _dmnguyenlieuEntity.Ngaysua;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Nguoisua.Name].Value = _dmnguyenlieuEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnguyenlieuManager.Convert(_dmnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMNGUYENLIEU_PK;
		}

	}
}
