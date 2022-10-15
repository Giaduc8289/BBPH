
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

		void BS_THAMSO_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_THAMSO.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_THAMSO.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[ThamsoFields.Mahieu.Name].ToString();
					
					txt_MAHIEU.Text = _Rowview.Row[ThamsoFields.Mahieu.Name].ToString();
					txt_STT.Text = _Rowview.Row[ThamsoFields.Stt.Name].ToString();
					txt_TENTHAMSO.Text = _Rowview.Row[ThamsoFields.Tenthamso.Name].ToString();
					txt_GIATRI.Text = _Rowview.Row[ThamsoFields.Giatri.Name].ToString();
					txt_THAYDOI.Text = _Rowview.Row[ThamsoFields.Thaydoi.Name].ToString();
					txt_KIEUDULIEU.Text = _Rowview.Row[ThamsoFields.Kieudulieu.Name].ToString();
					txt_GHICHU.Text = _Rowview.Row[ThamsoFields.Ghichu.Name].ToString();
					txt_LOAITHAMSO.Text = _Rowview.Row[ThamsoFields.Loaithamso.Name].ToString();
					txt_AN.Text = _Rowview.Row[ThamsoFields.An.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_THAMSO_CurrentChanged"); }
		}

		private string Save_Data(string _str_THAMSO_PK)
		{
			ThamsoEntity _thamsoEntity = new ThamsoEntity();
			
			_thamsoEntity.Mahieu = txt_MAHIEU.Text.Trim();
			_thamsoEntity.Stt = txt_STT.Text.Trim();
			_thamsoEntity.Tenthamso = txt_TENTHAMSO.Text.Trim();
			_thamsoEntity.Giatri = txt_GIATRI.Text.Trim();
			_thamsoEntity.Thaydoi = txt_THAYDOI.Text.Trim();
			_thamsoEntity.Kieudulieu = txt_KIEUDULIEU.Text.Trim();
			_thamsoEntity.Ghichu = txt_GHICHU.Text.Trim();
			_thamsoEntity.Loaithamso = txt_LOAITHAMSO.Text.Trim();
			_thamsoEntity.An = txt_AN.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_THAMSO_PK))
			{
				_str_THAMSO_PK = _ThamsoManager.InsertV2(_thamsoEntity, r_Insert, DT_THAMSO, BS_THAMSO);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_ThamsoManager.Convert(_thamsoEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_THAMSO.ResetCurrentItem();
			}
			else
			{
				_ThamsoManager.Update(_thamsoEntity);
				
				GRID_THAMSO.CurrentRow.Cells[ThamsoFields.Mahieu.Name].Value = _thamsoEntity.Mahieu;
				GRID_THAMSO.CurrentRow.Cells[ThamsoFields.Stt.Name].Value = _thamsoEntity.Stt;
				GRID_THAMSO.CurrentRow.Cells[ThamsoFields.Tenthamso.Name].Value = _thamsoEntity.Tenthamso;
				GRID_THAMSO.CurrentRow.Cells[ThamsoFields.Giatri.Name].Value = _thamsoEntity.Giatri;
				GRID_THAMSO.CurrentRow.Cells[ThamsoFields.Thaydoi.Name].Value = _thamsoEntity.Thaydoi;
				GRID_THAMSO.CurrentRow.Cells[ThamsoFields.Kieudulieu.Name].Value = _thamsoEntity.Kieudulieu;
				GRID_THAMSO.CurrentRow.Cells[ThamsoFields.Ghichu.Name].Value = _thamsoEntity.Ghichu;
				GRID_THAMSO.CurrentRow.Cells[ThamsoFields.Loaithamso.Name].Value = _thamsoEntity.Loaithamso;
				GRID_THAMSO.CurrentRow.Cells[ThamsoFields.An.Name].Value = _thamsoEntity.An;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_ThamsoManager.Convert(_thamsoEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_THAMSO_PK;
		}

	}
}
