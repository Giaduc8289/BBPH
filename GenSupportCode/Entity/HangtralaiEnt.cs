
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.HangtralaiEnt
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
	public class HangtralaiEnt : HangtralaiEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HangtralaiEnt()
		{
			// Nothing for now.
		}

		void BS_HANGTRALAI_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_HANGTRALAI.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_HANGTRALAI.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[HangtralaiFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[HangtralaiFields.Id.Name].ToString();
					txt_NGAYTRA.Text = _Rowview.Row[HangtralaiFields.Ngaytra.Name].ToString();
					txt_MAKHACH.Text = _Rowview.Row[HangtralaiFields.Makhach.Name].ToString();
					txt_TENKHACH.Text = _Rowview.Row[HangtralaiFields.Tenkhach.Name].ToString();
					txt_MASANPHAM.Text = _Rowview.Row[HangtralaiFields.Masanpham.Name].ToString();
					txt_TENSANPHAM.Text = _Rowview.Row[HangtralaiFields.Tensanpham.Name].ToString();
					txt_SOLUONGTRA.Text = _Rowview.Row[HangtralaiFields.Soluongtra.Name].ToString();
					txt_NGUYENNHAN.Text = _Rowview.Row[HangtralaiFields.Nguyennhan.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[HangtralaiFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[HangtralaiFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[HangtralaiFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[HangtralaiFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_HANGTRALAI_CurrentChanged"); }
		}

		private string Save_Data(string _str_HANGTRALAI_PK)
		{
			HangtralaiEntity _HangtralaiEntity = new HangtralaiEntity();
			try { _HangtralaiEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			try { _HangtralaiEntity.Ngaytra = System.DateTime.Parse(txt_NGAYTRA.Text.Trim()); } 
			catch { }
			_HangtralaiEntity.Makhach = txt_MAKHACH.Text.Trim();
			_HangtralaiEntity.Tenkhach = txt_TENKHACH.Text.Trim();
			_HangtralaiEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_HangtralaiEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
			try { _HangtralaiEntity.Soluongtra = System.Decimal.Parse(txt_SOLUONGTRA.Text.Trim()); } 
			catch { }
			_HangtralaiEntity.Nguyennhan = txt_NGUYENNHAN.Text.Trim();
			try { _HangtralaiEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_HangtralaiEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _HangtralaiEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_HangtralaiEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_HANGTRALAI_PK))
			{
				_str_HANGTRALAI_PK = _HangtralaiManager.InsertV2(_HangtralaiEntity, r_Insert, DT_HANGTRALAI, BS_HANGTRALAI);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_HangtralaiManager.Convert(_HangtralaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_HANGTRALAI.ResetCurrentItem();
			}
			else
			{
				_HangtralaiManager.Update(_HangtralaiEntity);
				
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Id.Name].Value = _HangtralaiEntity.Id;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Ngaytra.Name].Value = _HangtralaiEntity.Ngaytra;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Makhach.Name].Value = _HangtralaiEntity.Makhach;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Tenkhach.Name].Value = _HangtralaiEntity.Tenkhach;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Masanpham.Name].Value = _HangtralaiEntity.Masanpham;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Tensanpham.Name].Value = _HangtralaiEntity.Tensanpham;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Soluongtra.Name].Value = _HangtralaiEntity.Soluongtra;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Nguyennhan.Name].Value = _HangtralaiEntity.Nguyennhan;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Ngaytao.Name].Value = _HangtralaiEntity.Ngaytao;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Nguoitao.Name].Value = _HangtralaiEntity.Nguoitao;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Ngaysua.Name].Value = _HangtralaiEntity.Ngaysua;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Nguoisua.Name].Value = _HangtralaiEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_HangtralaiManager.Convert(_HangtralaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_HANGTRALAI_PK;
		}

	}
}
