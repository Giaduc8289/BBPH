
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

		void BS_Sodusanpham_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Sodusanpham.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Sodusanpham.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[SodusanphamFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[SodusanphamFields.Id.Name].ToString();
					txt_Ngaykiemke.Text = _Rowview.Row[SodusanphamFields.Ngaykiemke.Name].ToString();
					txt_Makho.Text = _Rowview.Row[SodusanphamFields.Makho.Name].ToString();
					txt_Tenkho.Text = _Rowview.Row[SodusanphamFields.Tenkho.Name].ToString();
					txt_Masanpham.Text = _Rowview.Row[SodusanphamFields.Masanpham.Name].ToString();
					txt_Tensanpham.Text = _Rowview.Row[SodusanphamFields.Tensanpham.Name].ToString();
					txt_Somet.Text = _Rowview.Row[SodusanphamFields.Somet.Name].ToString();
					txt_Soluong.Text = _Rowview.Row[SodusanphamFields.Soluong.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[SodusanphamFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[SodusanphamFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[SodusanphamFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[SodusanphamFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Sodusanpham_CurrentChanged"); }
		}

		private string Save_Data(string _str_Sodusanpham_PK)
		{
			SodusanphamEntity _sodusanphamEntity = new SodusanphamEntity();
			
			_sodusanphamEntity.Id = txt_Id.Text.Trim();
			_sodusanphamEntity.Ngaykiemke = txt_Ngaykiemke.Text.Trim();
			_sodusanphamEntity.Makho = txt_Makho.Text.Trim();
			_sodusanphamEntity.Tenkho = txt_Tenkho.Text.Trim();
			_sodusanphamEntity.Masanpham = txt_Masanpham.Text.Trim();
			_sodusanphamEntity.Tensanpham = txt_Tensanpham.Text.Trim();
			_sodusanphamEntity.Somet = txt_Somet.Text.Trim();
			_sodusanphamEntity.Soluong = txt_Soluong.Text.Trim();
			_sodusanphamEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_sodusanphamEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_sodusanphamEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_sodusanphamEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Sodusanpham_PK = _SodusanphamManager.InsertV2(_SodusanphamEntity, r_Insert, DT_Sodusanpham, BS_Sodusanpham);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodusanphamManager.Convert(_sodusanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Sodusanpham.ResetCurrentItem();
			}
			else
			{
				_SodusanphamManager.Update(_sodusanphamEntity);
				
				GRID_Sodusanpham.CurrentRow.Cells[SodusanphamFields.Id.Name].Value = _sodusanphamEntity.Id;
				GRID_Sodusanpham.CurrentRow.Cells[SodusanphamFields.Ngaykiemke.Name].Value = _sodusanphamEntity.Ngaykiemke;
				GRID_Sodusanpham.CurrentRow.Cells[SodusanphamFields.Makho.Name].Value = _sodusanphamEntity.Makho;
				GRID_Sodusanpham.CurrentRow.Cells[SodusanphamFields.Tenkho.Name].Value = _sodusanphamEntity.Tenkho;
				GRID_Sodusanpham.CurrentRow.Cells[SodusanphamFields.Masanpham.Name].Value = _sodusanphamEntity.Masanpham;
				GRID_Sodusanpham.CurrentRow.Cells[SodusanphamFields.Tensanpham.Name].Value = _sodusanphamEntity.Tensanpham;
				GRID_Sodusanpham.CurrentRow.Cells[SodusanphamFields.Somet.Name].Value = _sodusanphamEntity.Somet;
				GRID_Sodusanpham.CurrentRow.Cells[SodusanphamFields.Soluong.Name].Value = _sodusanphamEntity.Soluong;
				GRID_Sodusanpham.CurrentRow.Cells[SodusanphamFields.Ngaytao.Name].Value = _sodusanphamEntity.Ngaytao;
				GRID_Sodusanpham.CurrentRow.Cells[SodusanphamFields.Nguoitao.Name].Value = _sodusanphamEntity.Nguoitao;
				GRID_Sodusanpham.CurrentRow.Cells[SodusanphamFields.Ngaysua.Name].Value = _sodusanphamEntity.Ngaysua;
				GRID_Sodusanpham.CurrentRow.Cells[SodusanphamFields.Nguoisua.Name].Value = _sodusanphamEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodusanphamManager.Convert(_sodusanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Sodusanpham_PK;
		}

	}
}
