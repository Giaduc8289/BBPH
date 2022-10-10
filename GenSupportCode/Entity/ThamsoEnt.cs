
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.ThamsoEnt
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
	public class ThamsoEnt : ThamsoEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ThamsoEnt()
		{
			// Nothing for now.
		}

		void BS_Thamso_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Thamso.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Thamso.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[ThamsoFields.Mahieu.Name].ToString();
					
					txt_Mahieu.Text = _Rowview.Row[ThamsoFields.Mahieu.Name].ToString();
					txt_Stt.Text = _Rowview.Row[ThamsoFields.Stt.Name].ToString();
					txt_Tenthamso.Text = _Rowview.Row[ThamsoFields.Tenthamso.Name].ToString();
					txt_Giatri.Text = _Rowview.Row[ThamsoFields.Giatri.Name].ToString();
					txt_Thaydoi.Text = _Rowview.Row[ThamsoFields.Thaydoi.Name].ToString();
					txt_Kieudulieu.Text = _Rowview.Row[ThamsoFields.Kieudulieu.Name].ToString();
					txt_Ghichu.Text = _Rowview.Row[ThamsoFields.Ghichu.Name].ToString();
					txt_Loaithamso.Text = _Rowview.Row[ThamsoFields.Loaithamso.Name].ToString();
					txt_An.Text = _Rowview.Row[ThamsoFields.An.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Thamso_CurrentChanged"); }
		}

		private string Save_Data(string _str_Thamso_PK)
		{
			ThamsoEntity _thamsoEntity = new ThamsoEntity();
			
			_thamsoEntity.Mahieu = txt_Mahieu.Text.Trim();
			_thamsoEntity.Stt = txt_Stt.Text.Trim();
			_thamsoEntity.Tenthamso = txt_Tenthamso.Text.Trim();
			_thamsoEntity.Giatri = txt_Giatri.Text.Trim();
			_thamsoEntity.Thaydoi = txt_Thaydoi.Text.Trim();
			_thamsoEntity.Kieudulieu = txt_Kieudulieu.Text.Trim();
			_thamsoEntity.Ghichu = txt_Ghichu.Text.Trim();
			_thamsoEntity.Loaithamso = txt_Loaithamso.Text.Trim();
			_thamsoEntity.An = txt_An.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Thamso_PK = _ThamsoManager.InsertV2(_ThamsoEntity, r_Insert, DT_Thamso, BS_Thamso);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_ThamsoManager.Convert(_thamsoEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Thamso.ResetCurrentItem();
			}
			else
			{
				_ThamsoManager.Update(_thamsoEntity);
				
				GRID_Thamso.CurrentRow.Cells[ThamsoFields.Mahieu.Name].Value = _thamsoEntity.Mahieu;
				GRID_Thamso.CurrentRow.Cells[ThamsoFields.Stt.Name].Value = _thamsoEntity.Stt;
				GRID_Thamso.CurrentRow.Cells[ThamsoFields.Tenthamso.Name].Value = _thamsoEntity.Tenthamso;
				GRID_Thamso.CurrentRow.Cells[ThamsoFields.Giatri.Name].Value = _thamsoEntity.Giatri;
				GRID_Thamso.CurrentRow.Cells[ThamsoFields.Thaydoi.Name].Value = _thamsoEntity.Thaydoi;
				GRID_Thamso.CurrentRow.Cells[ThamsoFields.Kieudulieu.Name].Value = _thamsoEntity.Kieudulieu;
				GRID_Thamso.CurrentRow.Cells[ThamsoFields.Ghichu.Name].Value = _thamsoEntity.Ghichu;
				GRID_Thamso.CurrentRow.Cells[ThamsoFields.Loaithamso.Name].Value = _thamsoEntity.Loaithamso;
				GRID_Thamso.CurrentRow.Cells[ThamsoFields.An.Name].Value = _thamsoEntity.An;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_ThamsoManager.Convert(_thamsoEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Thamso_PK;
		}

	}
}
