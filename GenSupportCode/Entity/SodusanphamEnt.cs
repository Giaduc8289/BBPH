
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.SodusanphamEnt
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
	public class SodusanphamEnt : SodusanphamEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SodusanphamEnt()
		{
			// Nothing for now.
		}

		void BS_SODUSANPHAM_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_SODUSANPHAM.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_SODUSANPHAM.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[SodusanphamFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[SodusanphamFields.Id.Name].ToString();
					txt_NGAYKIEMKE.Text = _Rowview.Row[SodusanphamFields.Ngaykiemke.Name].ToString();
					txt_MAKHO.Text = _Rowview.Row[SodusanphamFields.Makho.Name].ToString();
					txt_TENKHO.Text = _Rowview.Row[SodusanphamFields.Tenkho.Name].ToString();
					txt_MASANPHAM.Text = _Rowview.Row[SodusanphamFields.Masanpham.Name].ToString();
					txt_TENSANPHAM.Text = _Rowview.Row[SodusanphamFields.Tensanpham.Name].ToString();
					txt_SOMET.Text = _Rowview.Row[SodusanphamFields.Somet.Name].ToString();
					txt_SOLUONG.Text = _Rowview.Row[SodusanphamFields.Soluong.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[SodusanphamFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[SodusanphamFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[SodusanphamFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[SodusanphamFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_SODUSANPHAM_CurrentChanged"); }
		}

		private string Save_Data(string _str_SODUSANPHAM_PK)
		{
			SodusanphamEntity _sodusanphamEntity = new SodusanphamEntity();
			
			_sodusanphamEntity.Id = txt_ID.Text.Trim();
			_sodusanphamEntity.Ngaykiemke = txt_NGAYKIEMKE.Text.Trim();
			_sodusanphamEntity.Makho = txt_MAKHO.Text.Trim();
			_sodusanphamEntity.Tenkho = txt_TENKHO.Text.Trim();
			_sodusanphamEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_sodusanphamEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
			_sodusanphamEntity.Somet = txt_SOMET.Text.Trim();
			_sodusanphamEntity.Soluong = txt_SOLUONG.Text.Trim();
			_sodusanphamEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_sodusanphamEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_sodusanphamEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_sodusanphamEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_SODUSANPHAM_PK))
			{
				_str_SODUSANPHAM_PK = _SodusanphamManager.InsertV2(_sodusanphamEntity, r_Insert, DT_SODUSANPHAM, BS_SODUSANPHAM);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodusanphamManager.Convert(_sodusanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_SODUSANPHAM.ResetCurrentItem();
			}
			else
			{
				_SodusanphamManager.Update(_sodusanphamEntity);
				
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Id.Name].Value = _sodusanphamEntity.Id;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Ngaykiemke.Name].Value = _sodusanphamEntity.Ngaykiemke;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Makho.Name].Value = _sodusanphamEntity.Makho;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Tenkho.Name].Value = _sodusanphamEntity.Tenkho;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Masanpham.Name].Value = _sodusanphamEntity.Masanpham;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Tensanpham.Name].Value = _sodusanphamEntity.Tensanpham;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Somet.Name].Value = _sodusanphamEntity.Somet;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Soluong.Name].Value = _sodusanphamEntity.Soluong;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Ngaytao.Name].Value = _sodusanphamEntity.Ngaytao;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Nguoitao.Name].Value = _sodusanphamEntity.Nguoitao;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Ngaysua.Name].Value = _sodusanphamEntity.Ngaysua;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Nguoisua.Name].Value = _sodusanphamEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodusanphamManager.Convert(_sodusanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_SODUSANPHAM_PK;
		}

	}
}
