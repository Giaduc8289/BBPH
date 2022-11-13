
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DonhangHEnt
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
	public class DonhangHEnt : DonhangHEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DonhangHEnt()
		{
			// Nothing for now.
		}

		void BS_DONHANGH_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DONHANGH.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DONHANGH.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DonhangHFields.Madon.Name].ToString();
					
					txt_MADON.Text = _Rowview.Row[DonhangHFields.Madon.Name].ToString();
					txt_NGAYDAT.Text = _Rowview.Row[DonhangHFields.Ngaydat.Name].ToString();
					txt_MAKHACH.Text = _Rowview.Row[DonhangHFields.Makhach.Name].ToString();
					txt_TENKHACH.Text = _Rowview.Row[DonhangHFields.Tenkhach.Name].ToString();
					txt_SOBAOGIA.Text = _Rowview.Row[DonhangHFields.Sobaogia.Name].ToString();
					txt_NGAYBAOGIA.Text = _Rowview.Row[DonhangHFields.Ngaybaogia.Name].ToString();
					txt_USERID.Text = _Rowview.Row[DonhangHFields.Userid.Name].ToString();
					txt_TENNV.Text = _Rowview.Row[DonhangHFields.Tennv.Name].ToString();
					txt_GHICHU.Text = _Rowview.Row[DonhangHFields.Ghichu.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DonhangHFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DonhangHFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DonhangHFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DonhangHFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DONHANGH_CurrentChanged"); }
		}

		private string Save_Data(string _str_DONHANGH_PK)
		{
			DonhangHEntity _DonhangHEntity = new DonhangHEntity();
			_DonhangHEntity.Madon = txt_MADON.Text.Trim();
			try { _DonhangHEntity.Ngaydat = System.DateTime.Parse(txt_NGAYDAT.Text.Trim()); } 
			catch { }
			_DonhangHEntity.Makhach = txt_MAKHACH.Text.Trim();
			_DonhangHEntity.Tenkhach = txt_TENKHACH.Text.Trim();
			_DonhangHEntity.Sobaogia = txt_SOBAOGIA.Text.Trim();
			try { _DonhangHEntity.Ngaybaogia = System.DateTime.Parse(txt_NGAYBAOGIA.Text.Trim()); } 
			catch { }
			_DonhangHEntity.Userid = txt_USERID.Text.Trim();
			_DonhangHEntity.Tennv = txt_TENNV.Text.Trim();
			_DonhangHEntity.Ghichu = txt_GHICHU.Text.Trim();
			try { _DonhangHEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_DonhangHEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _DonhangHEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_DonhangHEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_DONHANGH_PK))
			{
				_str_DONHANGH_PK = _DonhangHManager.InsertV2(_DonhangHEntity, r_Insert, DT_DONHANGH, BS_DONHANGH);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DonhangHManager.Convert(_DonhangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DONHANGH.ResetCurrentItem();
			}
			else
			{
				_DonhangHManager.Update(_DonhangHEntity);
				
				GRID_DONHANGH.CurrentRow.Cells[DonhangHFields.Madon.Name].Value = _DonhangHEntity.Madon;
				GRID_DONHANGH.CurrentRow.Cells[DonhangHFields.Ngaydat.Name].Value = _DonhangHEntity.Ngaydat;
				GRID_DONHANGH.CurrentRow.Cells[DonhangHFields.Makhach.Name].Value = _DonhangHEntity.Makhach;
				GRID_DONHANGH.CurrentRow.Cells[DonhangHFields.Tenkhach.Name].Value = _DonhangHEntity.Tenkhach;
				GRID_DONHANGH.CurrentRow.Cells[DonhangHFields.Sobaogia.Name].Value = _DonhangHEntity.Sobaogia;
				GRID_DONHANGH.CurrentRow.Cells[DonhangHFields.Ngaybaogia.Name].Value = _DonhangHEntity.Ngaybaogia;
				GRID_DONHANGH.CurrentRow.Cells[DonhangHFields.Userid.Name].Value = _DonhangHEntity.Userid;
				GRID_DONHANGH.CurrentRow.Cells[DonhangHFields.Tennv.Name].Value = _DonhangHEntity.Tennv;
				GRID_DONHANGH.CurrentRow.Cells[DonhangHFields.Ghichu.Name].Value = _DonhangHEntity.Ghichu;
				GRID_DONHANGH.CurrentRow.Cells[DonhangHFields.Ngaytao.Name].Value = _DonhangHEntity.Ngaytao;
				GRID_DONHANGH.CurrentRow.Cells[DonhangHFields.Nguoitao.Name].Value = _DonhangHEntity.Nguoitao;
				GRID_DONHANGH.CurrentRow.Cells[DonhangHFields.Ngaysua.Name].Value = _DonhangHEntity.Ngaysua;
				GRID_DONHANGH.CurrentRow.Cells[DonhangHFields.Nguoisua.Name].Value = _DonhangHEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DonhangHManager.Convert(_DonhangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DONHANGH_PK;
		}

	}
}
