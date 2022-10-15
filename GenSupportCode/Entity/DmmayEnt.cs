
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmmayEnt
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
	public class DmmayEnt : DmmayEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmmayEnt()
		{
			// Nothing for now.
		}

		void BS_DMMAY_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMMAY.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMMAY.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmmayFields.Mamay.Name].ToString();
					
					txt_MAMAY.Text = _Rowview.Row[DmmayFields.Mamay.Name].ToString();
					txt_TENMAY.Text = _Rowview.Row[DmmayFields.Tenmay.Name].ToString();
					txt_MADM.Text = _Rowview.Row[DmmayFields.Madm.Name].ToString();
					txt_VITRI.Text = _Rowview.Row[DmmayFields.Vitri.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmmayFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmmayFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmmayFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmmayFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMMAY_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMMAY_PK)
		{
			DmmayEntity _dmmayEntity = new DmmayEntity();
			
			_dmmayEntity.Mamay = txt_MAMAY.Text.Trim();
			_dmmayEntity.Tenmay = txt_TENMAY.Text.Trim();
			_dmmayEntity.Madm = txt_MADM.Text.Trim();
			_dmmayEntity.Vitri = txt_VITRI.Text.Trim();
			_dmmayEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dmmayEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dmmayEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dmmayEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMMAY_PK))
			{
				_str_DMMAY_PK = _DmmayManager.InsertV2(_dmmayEntity, r_Insert, DT_DMMAY, BS_DMMAY);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmayManager.Convert(_dmmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMMAY.ResetCurrentItem();
			}
			else
			{
				_DmmayManager.Update(_dmmayEntity);
				
				GRID_DMMAY.CurrentRow.Cells[DmmayFields.Mamay.Name].Value = _dmmayEntity.Mamay;
				GRID_DMMAY.CurrentRow.Cells[DmmayFields.Tenmay.Name].Value = _dmmayEntity.Tenmay;
				GRID_DMMAY.CurrentRow.Cells[DmmayFields.Madm.Name].Value = _dmmayEntity.Madm;
				GRID_DMMAY.CurrentRow.Cells[DmmayFields.Vitri.Name].Value = _dmmayEntity.Vitri;
				GRID_DMMAY.CurrentRow.Cells[DmmayFields.Ngaytao.Name].Value = _dmmayEntity.Ngaytao;
				GRID_DMMAY.CurrentRow.Cells[DmmayFields.Nguoitao.Name].Value = _dmmayEntity.Nguoitao;
				GRID_DMMAY.CurrentRow.Cells[DmmayFields.Ngaysua.Name].Value = _dmmayEntity.Ngaysua;
				GRID_DMMAY.CurrentRow.Cells[DmmayFields.Nguoisua.Name].Value = _dmmayEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmayManager.Convert(_dmmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMMAY_PK;
		}

	}
}
