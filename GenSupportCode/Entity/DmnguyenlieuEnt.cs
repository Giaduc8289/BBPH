
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
						MAHIEU_PK = _Rowview.Row[DmnguyenlieuFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[DmnguyenlieuFields.Id.Name].ToString();
					txt_MANL.Text = _Rowview.Row[DmnguyenlieuFields.Manl.Name].ToString();
					txt_TENNL.Text = _Rowview.Row[DmnguyenlieuFields.Tennl.Name].ToString();
					txt_TENRUTGON.Text = _Rowview.Row[DmnguyenlieuFields.Tenrutgon.Name].ToString();
					txt_MANHOM.Text = _Rowview.Row[DmnguyenlieuFields.Manhom.Name].ToString();
					txt_TENNHOM.Text = _Rowview.Row[DmnguyenlieuFields.Tennhom.Name].ToString();
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
			DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity();
			try { _DmnguyenlieuEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			_DmnguyenlieuEntity.Manl = txt_MANL.Text.Trim();
			_DmnguyenlieuEntity.Tennl = txt_TENNL.Text.Trim();
			_DmnguyenlieuEntity.Tenrutgon = txt_TENRUTGON.Text.Trim();
			_DmnguyenlieuEntity.Manhom = txt_MANHOM.Text.Trim();
			_DmnguyenlieuEntity.Tennhom = txt_TENNHOM.Text.Trim();
			try { _DmnguyenlieuEntity.Gia = System.Decimal.Parse(txt_GIA.Text.Trim()); } 
			catch { }
			try { _DmnguyenlieuEntity.Ngay = System.DateTime.Parse(txt_NGAY.Text.Trim()); } 
			catch { }
			try { _DmnguyenlieuEntity.Giahientai = System.Decimal.Parse(txt_GIAHIENTAI.Text.Trim()); } 
			catch { }
			try { _DmnguyenlieuEntity.Tang = System.Decimal.Parse(txt_TANG.Text.Trim()); } 
			catch { }
			try { _DmnguyenlieuEntity.Giam = System.Decimal.Parse(txt_GIAM.Text.Trim()); } 
			catch { }
			try { _DmnguyenlieuEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_DmnguyenlieuEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _DmnguyenlieuEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_DmnguyenlieuEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_DMNGUYENLIEU_PK))
			{
				_str_DMNGUYENLIEU_PK = _DmnguyenlieuManager.InsertV2(_DmnguyenlieuEntity, r_Insert, DT_DMNGUYENLIEU, BS_DMNGUYENLIEU);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnguyenlieuManager.Convert(_DmnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMNGUYENLIEU.ResetCurrentItem();
			}
			else
			{
				_DmnguyenlieuManager.Update(_DmnguyenlieuEntity);
				
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Id.Name].Value = _DmnguyenlieuEntity.Id;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Manl.Name].Value = _DmnguyenlieuEntity.Manl;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Tennl.Name].Value = _DmnguyenlieuEntity.Tennl;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Tenrutgon.Name].Value = _DmnguyenlieuEntity.Tenrutgon;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Manhom.Name].Value = _DmnguyenlieuEntity.Manhom;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Tennhom.Name].Value = _DmnguyenlieuEntity.Tennhom;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Gia.Name].Value = _DmnguyenlieuEntity.Gia;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Ngay.Name].Value = _DmnguyenlieuEntity.Ngay;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Giahientai.Name].Value = _DmnguyenlieuEntity.Giahientai;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Tang.Name].Value = _DmnguyenlieuEntity.Tang;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Giam.Name].Value = _DmnguyenlieuEntity.Giam;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Ngaytao.Name].Value = _DmnguyenlieuEntity.Ngaytao;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Nguoitao.Name].Value = _DmnguyenlieuEntity.Nguoitao;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Ngaysua.Name].Value = _DmnguyenlieuEntity.Ngaysua;
				GRID_DMNGUYENLIEU.CurrentRow.Cells[DmnguyenlieuFields.Nguoisua.Name].Value = _DmnguyenlieuEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnguyenlieuManager.Convert(_DmnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMNGUYENLIEU_PK;
		}

	}
}
