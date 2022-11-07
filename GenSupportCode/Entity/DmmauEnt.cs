
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmmauEnt
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
	public class DmmauEnt : DmmauEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmmauEnt()
		{
			// Nothing for now.
		}

		void BS_DMMAU_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMMAU.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMMAU.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmmauFields.Mamau.Name].ToString();
					
					txt_MAMAU.Text = _Rowview.Row[DmmauFields.Mamau.Name].ToString();
					txt_TENMAU.Text = _Rowview.Row[DmmauFields.Tenmau.Name].ToString();
					txt_LAMAUGOC.Text = _Rowview.Row[DmmauFields.Lamaugoc.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmmauFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmmauFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmmauFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmmauFields.Nguoisua.Name].ToString();
					txt_MAARGB.Text = _Rowview.Row[DmmauFields.MaArgb.Name].ToString();
					txt_GHICHU.Text = _Rowview.Row[DmmauFields.Ghichu.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMMAU_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMMAU_PK)
		{
			DmmauEntity _DmmauEntity = new DmmauEntity();
			
			_DmmauEntity.Mamau = txt_MAMAU.Text.Trim();
			_DmmauEntity.Tenmau = txt_TENMAU.Text.Trim();
			_DmmauEntity.Lamaugoc = txt_LAMAUGOC.Text.Trim();
			_DmmauEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_DmmauEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_DmmauEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_DmmauEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_DmmauEntity.MaArgb = txt_MAARGB.Text.Trim();
			_DmmauEntity.Ghichu = txt_GHICHU.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMMAU_PK))
			{
				_str_DMMAU_PK = _DmmauManager.InsertV2(_DmmauEntity, r_Insert, DT_DMMAU, BS_DMMAU);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmauManager.Convert(_DmmauEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMMAU.ResetCurrentItem();
			}
			else
			{
				_DmmauManager.Update(_DmmauEntity);
				
				GRID_DMMAU.CurrentRow.Cells[DmmauFields.Mamau.Name].Value = _DmmauEntity.Mamau;
				GRID_DMMAU.CurrentRow.Cells[DmmauFields.Tenmau.Name].Value = _DmmauEntity.Tenmau;
				GRID_DMMAU.CurrentRow.Cells[DmmauFields.Lamaugoc.Name].Value = _DmmauEntity.Lamaugoc;
				GRID_DMMAU.CurrentRow.Cells[DmmauFields.Ngaytao.Name].Value = _DmmauEntity.Ngaytao;
				GRID_DMMAU.CurrentRow.Cells[DmmauFields.Nguoitao.Name].Value = _DmmauEntity.Nguoitao;
				GRID_DMMAU.CurrentRow.Cells[DmmauFields.Ngaysua.Name].Value = _DmmauEntity.Ngaysua;
				GRID_DMMAU.CurrentRow.Cells[DmmauFields.Nguoisua.Name].Value = _DmmauEntity.Nguoisua;
				GRID_DMMAU.CurrentRow.Cells[DmmauFields.MaArgb.Name].Value = _DmmauEntity.MaArgb;
				GRID_DMMAU.CurrentRow.Cells[DmmauFields.Ghichu.Name].Value = _DmmauEntity.Ghichu;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmauManager.Convert(_DmmauEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMMAU_PK;
		}

	}
}
