
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
					txt_SOKG.Text = _Rowview.Row[SodusanphamFields.Sokg.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_SODUSANPHAM_CurrentChanged"); }
		}

		private string Save_Data(string _str_SODUSANPHAM_PK)
		{
			SodusanphamEntity _SodusanphamEntity = new SodusanphamEntity();
			
			_SodusanphamEntity.Id = txt_ID.Text.Trim();
			_SodusanphamEntity.Ngaykiemke = txt_NGAYKIEMKE.Text.Trim();
			_SodusanphamEntity.Makho = txt_MAKHO.Text.Trim();
			_SodusanphamEntity.Tenkho = txt_TENKHO.Text.Trim();
			_SodusanphamEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_SodusanphamEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
			_SodusanphamEntity.Somet = txt_SOMET.Text.Trim();
			_SodusanphamEntity.Soluong = txt_SOLUONG.Text.Trim();
			_SodusanphamEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_SodusanphamEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_SodusanphamEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_SodusanphamEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_SodusanphamEntity.Sokg = txt_SOKG.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_SODUSANPHAM_PK))
			{
				_str_SODUSANPHAM_PK = _SodusanphamManager.InsertV2(_SodusanphamEntity, r_Insert, DT_SODUSANPHAM, BS_SODUSANPHAM);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodusanphamManager.Convert(_SodusanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_SODUSANPHAM.ResetCurrentItem();
			}
			else
			{
				_SodusanphamManager.Update(_SodusanphamEntity);
				
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Id.Name].Value = _SodusanphamEntity.Id;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Ngaykiemke.Name].Value = _SodusanphamEntity.Ngaykiemke;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Makho.Name].Value = _SodusanphamEntity.Makho;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Tenkho.Name].Value = _SodusanphamEntity.Tenkho;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Masanpham.Name].Value = _SodusanphamEntity.Masanpham;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Tensanpham.Name].Value = _SodusanphamEntity.Tensanpham;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Somet.Name].Value = _SodusanphamEntity.Somet;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Soluong.Name].Value = _SodusanphamEntity.Soluong;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Ngaytao.Name].Value = _SodusanphamEntity.Ngaytao;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Nguoitao.Name].Value = _SodusanphamEntity.Nguoitao;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Ngaysua.Name].Value = _SodusanphamEntity.Ngaysua;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Nguoisua.Name].Value = _SodusanphamEntity.Nguoisua;
				GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Sokg.Name].Value = _SodusanphamEntity.Sokg;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodusanphamManager.Convert(_SodusanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_SODUSANPHAM_PK;
		}

	}
}
