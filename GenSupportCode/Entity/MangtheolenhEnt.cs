
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.MangtheolenhEnt
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
	public class MangtheolenhEnt : MangtheolenhEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MangtheolenhEnt()
		{
			// Nothing for now.
		}

		void BS_MANGTHEOLENH_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_MANGTHEOLENH.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_MANGTHEOLENH.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[MangtheolenhFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[MangtheolenhFields.Id.Name].ToString();
					txt_SOLENHSX.Text = _Rowview.Row[MangtheolenhFields.Solenhsx.Name].ToString();
					txt_NGAYPHATLENH.Text = _Rowview.Row[MangtheolenhFields.Ngayphatlenh.Name].ToString();
					txt_MAMANGQUYDINH.Text = _Rowview.Row[MangtheolenhFields.Mamangquydinh.Name].ToString();
					txt_TENMANGQUYDINH.Text = _Rowview.Row[MangtheolenhFields.Tenmangquydinh.Name].ToString();
					txt_SOMETQUYDINH.Text = _Rowview.Row[MangtheolenhFields.Sometquydinh.Name].ToString();
					txt_SOKGQUYDINH.Text = _Rowview.Row[MangtheolenhFields.Sokgquydinh.Name].ToString();
					txt_SOMETTHOI.Text = _Rowview.Row[MangtheolenhFields.Sometthoi.Name].ToString();
					txt_SOKGTHOI.Text = _Rowview.Row[MangtheolenhFields.Sokgthoi.Name].ToString();
					txt_MAMANGSUDUNG.Text = _Rowview.Row[MangtheolenhFields.Mamangsudung.Name].ToString();
					txt_TENMANGSUDUNG.Text = _Rowview.Row[MangtheolenhFields.Tenmangsudung.Name].ToString();
					txt_SOMETSUDUNG.Text = _Rowview.Row[MangtheolenhFields.Sometsudung.Name].ToString();
					txt_SOKGSUDUNG.Text = _Rowview.Row[MangtheolenhFields.Sokgsudung.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[MangtheolenhFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[MangtheolenhFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[MangtheolenhFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[MangtheolenhFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_MANGTHEOLENH_CurrentChanged"); }
		}

		private string Save_Data(string _str_MANGTHEOLENH_PK)
		{
			MangtheolenhEntity _MangtheolenhEntity = new MangtheolenhEntity();
			try { _MangtheolenhEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			_MangtheolenhEntity.Solenhsx = txt_SOLENHSX.Text.Trim();
			try { _MangtheolenhEntity.Ngayphatlenh = System.DateTime.Parse(txt_NGAYPHATLENH.Text.Trim()); } 
			catch { }
			_MangtheolenhEntity.Mamangquydinh = txt_MAMANGQUYDINH.Text.Trim();
			_MangtheolenhEntity.Tenmangquydinh = txt_TENMANGQUYDINH.Text.Trim();
			try { _MangtheolenhEntity.Sometquydinh = System.Decimal.Parse(txt_SOMETQUYDINH.Text.Trim()); } 
			catch { }
			try { _MangtheolenhEntity.Sokgquydinh = System.Decimal.Parse(txt_SOKGQUYDINH.Text.Trim()); } 
			catch { }
			try { _MangtheolenhEntity.Sometthoi = System.Decimal.Parse(txt_SOMETTHOI.Text.Trim()); } 
			catch { }
			try { _MangtheolenhEntity.Sokgthoi = System.Decimal.Parse(txt_SOKGTHOI.Text.Trim()); } 
			catch { }
			_MangtheolenhEntity.Mamangsudung = txt_MAMANGSUDUNG.Text.Trim();
			_MangtheolenhEntity.Tenmangsudung = txt_TENMANGSUDUNG.Text.Trim();
			try { _MangtheolenhEntity.Sometsudung = System.Decimal.Parse(txt_SOMETSUDUNG.Text.Trim()); } 
			catch { }
			try { _MangtheolenhEntity.Sokgsudung = System.Decimal.Parse(txt_SOKGSUDUNG.Text.Trim()); } 
			catch { }
			try { _MangtheolenhEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_MangtheolenhEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _MangtheolenhEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_MangtheolenhEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_MANGTHEOLENH_PK))
			{
				_str_MANGTHEOLENH_PK = _MangtheolenhManager.InsertV2(_MangtheolenhEntity, r_Insert, DT_MANGTHEOLENH, BS_MANGTHEOLENH);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_MangtheolenhManager.Convert(_MangtheolenhEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_MANGTHEOLENH.ResetCurrentItem();
			}
			else
			{
				_MangtheolenhManager.Update(_MangtheolenhEntity);
				
				GRID_MANGTHEOLENH.CurrentRow.Cells[MangtheolenhFields.Id.Name].Value = _MangtheolenhEntity.Id;
				GRID_MANGTHEOLENH.CurrentRow.Cells[MangtheolenhFields.Solenhsx.Name].Value = _MangtheolenhEntity.Solenhsx;
				GRID_MANGTHEOLENH.CurrentRow.Cells[MangtheolenhFields.Ngayphatlenh.Name].Value = _MangtheolenhEntity.Ngayphatlenh;
				GRID_MANGTHEOLENH.CurrentRow.Cells[MangtheolenhFields.Mamangquydinh.Name].Value = _MangtheolenhEntity.Mamangquydinh;
				GRID_MANGTHEOLENH.CurrentRow.Cells[MangtheolenhFields.Tenmangquydinh.Name].Value = _MangtheolenhEntity.Tenmangquydinh;
				GRID_MANGTHEOLENH.CurrentRow.Cells[MangtheolenhFields.Sometquydinh.Name].Value = _MangtheolenhEntity.Sometquydinh;
				GRID_MANGTHEOLENH.CurrentRow.Cells[MangtheolenhFields.Sokgquydinh.Name].Value = _MangtheolenhEntity.Sokgquydinh;
				GRID_MANGTHEOLENH.CurrentRow.Cells[MangtheolenhFields.Sometthoi.Name].Value = _MangtheolenhEntity.Sometthoi;
				GRID_MANGTHEOLENH.CurrentRow.Cells[MangtheolenhFields.Sokgthoi.Name].Value = _MangtheolenhEntity.Sokgthoi;
				GRID_MANGTHEOLENH.CurrentRow.Cells[MangtheolenhFields.Mamangsudung.Name].Value = _MangtheolenhEntity.Mamangsudung;
				GRID_MANGTHEOLENH.CurrentRow.Cells[MangtheolenhFields.Tenmangsudung.Name].Value = _MangtheolenhEntity.Tenmangsudung;
				GRID_MANGTHEOLENH.CurrentRow.Cells[MangtheolenhFields.Sometsudung.Name].Value = _MangtheolenhEntity.Sometsudung;
				GRID_MANGTHEOLENH.CurrentRow.Cells[MangtheolenhFields.Sokgsudung.Name].Value = _MangtheolenhEntity.Sokgsudung;
				GRID_MANGTHEOLENH.CurrentRow.Cells[MangtheolenhFields.Ngaytao.Name].Value = _MangtheolenhEntity.Ngaytao;
				GRID_MANGTHEOLENH.CurrentRow.Cells[MangtheolenhFields.Nguoitao.Name].Value = _MangtheolenhEntity.Nguoitao;
				GRID_MANGTHEOLENH.CurrentRow.Cells[MangtheolenhFields.Ngaysua.Name].Value = _MangtheolenhEntity.Ngaysua;
				GRID_MANGTHEOLENH.CurrentRow.Cells[MangtheolenhFields.Nguoisua.Name].Value = _MangtheolenhEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_MangtheolenhManager.Convert(_MangtheolenhEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_MANGTHEOLENH_PK;
		}

	}
}
