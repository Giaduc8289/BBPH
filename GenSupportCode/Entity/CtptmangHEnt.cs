
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.CtptmangHEnt
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
	public class CtptmangHEnt : CtptmangHEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CtptmangHEnt()
		{
			// Nothing for now.
		}

		void BS_CTPTMANGH_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_CTPTMANGH.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_CTPTMANGH.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[CtptmangHFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[CtptmangHFields.Id.Name].ToString();
					txt_MACTPT.Text = _Rowview.Row[CtptmangHFields.Mactpt.Name].ToString();
					txt_TENCTPT.Text = _Rowview.Row[CtptmangHFields.Tenctpt.Name].ToString();
					txt_NGAYAPDUNG.Text = _Rowview.Row[CtptmangHFields.Ngayapdung.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[CtptmangHFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[CtptmangHFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[CtptmangHFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[CtptmangHFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_CTPTMANGH_CurrentChanged"); }
		}

		private string Save_Data(string _str_CTPTMANGH_PK)
		{
			CtptmangHEntity _CtptmangHEntity = new CtptmangHEntity();
			try { _CtptmangHEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			_CtptmangHEntity.Mactpt = txt_MACTPT.Text.Trim();
			_CtptmangHEntity.Tenctpt = txt_TENCTPT.Text.Trim();
			try { _CtptmangHEntity.Ngayapdung = System.DateTime.Parse(txt_NGAYAPDUNG.Text.Trim()); } 
			catch { }
			try { _CtptmangHEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_CtptmangHEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _CtptmangHEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_CtptmangHEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_CTPTMANGH_PK))
			{
				_str_CTPTMANGH_PK = _CtptmangHManager.InsertV2(_CtptmangHEntity, r_Insert, DT_CTPTMANGH, BS_CTPTMANGH);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CtptmangHManager.Convert(_CtptmangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_CTPTMANGH.ResetCurrentItem();
			}
			else
			{
				_CtptmangHManager.Update(_CtptmangHEntity);
				
				GRID_CTPTMANGH.CurrentRow.Cells[CtptmangHFields.Id.Name].Value = _CtptmangHEntity.Id;
				GRID_CTPTMANGH.CurrentRow.Cells[CtptmangHFields.Mactpt.Name].Value = _CtptmangHEntity.Mactpt;
				GRID_CTPTMANGH.CurrentRow.Cells[CtptmangHFields.Tenctpt.Name].Value = _CtptmangHEntity.Tenctpt;
				GRID_CTPTMANGH.CurrentRow.Cells[CtptmangHFields.Ngayapdung.Name].Value = _CtptmangHEntity.Ngayapdung;
				GRID_CTPTMANGH.CurrentRow.Cells[CtptmangHFields.Ngaytao.Name].Value = _CtptmangHEntity.Ngaytao;
				GRID_CTPTMANGH.CurrentRow.Cells[CtptmangHFields.Nguoitao.Name].Value = _CtptmangHEntity.Nguoitao;
				GRID_CTPTMANGH.CurrentRow.Cells[CtptmangHFields.Ngaysua.Name].Value = _CtptmangHEntity.Ngaysua;
				GRID_CTPTMANGH.CurrentRow.Cells[CtptmangHFields.Nguoisua.Name].Value = _CtptmangHEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CtptmangHManager.Convert(_CtptmangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_CTPTMANGH_PK;
		}

	}
}
