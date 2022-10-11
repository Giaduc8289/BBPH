
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.TknguyenlieuthoiEnt
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
	public class TknguyenlieuthoiEnt : TknguyenlieuthoiEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TknguyenlieuthoiEnt()
		{
			// Nothing for now.
		}

		void BS_Tknguyenlieuthoi_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Tknguyenlieuthoi.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Tknguyenlieuthoi.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[TknguyenlieuthoiFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[TknguyenlieuthoiFields.Id.Name].ToString();
					txt_Ngay.Text = _Rowview.Row[TknguyenlieuthoiFields.Ngay.Name].ToString();
					txt_Ca.Text = _Rowview.Row[TknguyenlieuthoiFields.Ca.Name].ToString();
					txt_Manguyenlieu.Text = _Rowview.Row[TknguyenlieuthoiFields.Manguyenlieu.Name].ToString();
					txt_Tennguyenlieu.Text = _Rowview.Row[TknguyenlieuthoiFields.Tennguyenlieu.Name].ToString();
					txt_Klnhap.Text = _Rowview.Row[TknguyenlieuthoiFields.Klnhap.Name].ToString();
					txt_Klxuat.Text = _Rowview.Row[TknguyenlieuthoiFields.Klxuat.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Tknguyenlieuthoi_CurrentChanged"); }
		}

		private string Save_Data(string _str_Tknguyenlieuthoi_PK)
		{
			TknguyenlieuthoiEntity _tknguyenlieuthoiEntity = new TknguyenlieuthoiEntity();
			
			_tknguyenlieuthoiEntity.Id = txt_Id.Text.Trim();
			_tknguyenlieuthoiEntity.Ngay = txt_Ngay.Text.Trim();
			_tknguyenlieuthoiEntity.Ca = txt_Ca.Text.Trim();
			_tknguyenlieuthoiEntity.Manguyenlieu = txt_Manguyenlieu.Text.Trim();
			_tknguyenlieuthoiEntity.Tennguyenlieu = txt_Tennguyenlieu.Text.Trim();
			_tknguyenlieuthoiEntity.Klnhap = txt_Klnhap.Text.Trim();
			_tknguyenlieuthoiEntity.Klxuat = txt_Klxuat.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Tknguyenlieuthoi_PK = _TknguyenlieuthoiManager.InsertV2(_TknguyenlieuthoiEntity, r_Insert, DT_Tknguyenlieuthoi, BS_Tknguyenlieuthoi);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_TknguyenlieuthoiManager.Convert(_tknguyenlieuthoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Tknguyenlieuthoi.ResetCurrentItem();
			}
			else
			{
				_TknguyenlieuthoiManager.Update(_tknguyenlieuthoiEntity);
				
				GRID_Tknguyenlieuthoi.CurrentRow.Cells[TknguyenlieuthoiFields.Id.Name].Value = _tknguyenlieuthoiEntity.Id;
				GRID_Tknguyenlieuthoi.CurrentRow.Cells[TknguyenlieuthoiFields.Ngay.Name].Value = _tknguyenlieuthoiEntity.Ngay;
				GRID_Tknguyenlieuthoi.CurrentRow.Cells[TknguyenlieuthoiFields.Ca.Name].Value = _tknguyenlieuthoiEntity.Ca;
				GRID_Tknguyenlieuthoi.CurrentRow.Cells[TknguyenlieuthoiFields.Manguyenlieu.Name].Value = _tknguyenlieuthoiEntity.Manguyenlieu;
				GRID_Tknguyenlieuthoi.CurrentRow.Cells[TknguyenlieuthoiFields.Tennguyenlieu.Name].Value = _tknguyenlieuthoiEntity.Tennguyenlieu;
				GRID_Tknguyenlieuthoi.CurrentRow.Cells[TknguyenlieuthoiFields.Klnhap.Name].Value = _tknguyenlieuthoiEntity.Klnhap;
				GRID_Tknguyenlieuthoi.CurrentRow.Cells[TknguyenlieuthoiFields.Klxuat.Name].Value = _tknguyenlieuthoiEntity.Klxuat;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_TknguyenlieuthoiManager.Convert(_tknguyenlieuthoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Tknguyenlieuthoi_PK;
		}

	}
}
