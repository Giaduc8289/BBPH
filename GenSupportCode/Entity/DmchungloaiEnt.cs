
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmchungloaiEnt
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
	public class DmchungloaiEnt : DmchungloaiEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmchungloaiEnt()
		{
			// Nothing for now.
		}

		void BS_Dmchungloai_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmchungloai.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmchungloai.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmchungloaiFields.Machungloai.Name].ToString();
					
					txt_Machungloai.Text = _Rowview.Row[DmchungloaiFields.Machungloai.Name].ToString();
					txt_Tenchungloai.Text = _Rowview.Row[DmchungloaiFields.Tenchungloai.Name].ToString();
					txt_Kichthuoc.Text = _Rowview.Row[DmchungloaiFields.Kichthuoc.Name].ToString();
					txt_Trongluong.Text = _Rowview.Row[DmchungloaiFields.Trongluong.Name].ToString();
					txt_Somau.Text = _Rowview.Row[DmchungloaiFields.Somau.Name].ToString();
					txt_Sohinh.Text = _Rowview.Row[DmchungloaiFields.Sohinh.Name].ToString();
					txt_Loaimuc.Text = _Rowview.Row[DmchungloaiFields.Loaimuc.Name].ToString();
					txt_Ghichu.Text = _Rowview.Row[DmchungloaiFields.Ghichu.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[DmchungloaiFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[DmchungloaiFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[DmchungloaiFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[DmchungloaiFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmchungloai_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmchungloai_PK)
		{
			DmchungloaiEntity _dmchungloaiEntity = new DmchungloaiEntity();
			
			_dmchungloaiEntity.Machungloai = txt_Machungloai.Text.Trim();
			_dmchungloaiEntity.Tenchungloai = txt_Tenchungloai.Text.Trim();
			_dmchungloaiEntity.Kichthuoc = txt_Kichthuoc.Text.Trim();
			_dmchungloaiEntity.Trongluong = txt_Trongluong.Text.Trim();
			_dmchungloaiEntity.Somau = txt_Somau.Text.Trim();
			_dmchungloaiEntity.Sohinh = txt_Sohinh.Text.Trim();
			_dmchungloaiEntity.Loaimuc = txt_Loaimuc.Text.Trim();
			_dmchungloaiEntity.Ghichu = txt_Ghichu.Text.Trim();
			_dmchungloaiEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_dmchungloaiEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_dmchungloaiEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_dmchungloaiEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmchungloai_PK = _DmchungloaiManager.InsertV2(_DmchungloaiEntity, r_Insert, DT_Dmchungloai, BS_Dmchungloai);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchungloaiManager.Convert(_dmchungloaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmchungloai.ResetCurrentItem();
			}
			else
			{
				_DmchungloaiManager.Update(_dmchungloaiEntity);
				
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Machungloai.Name].Value = _dmchungloaiEntity.Machungloai;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Tenchungloai.Name].Value = _dmchungloaiEntity.Tenchungloai;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Kichthuoc.Name].Value = _dmchungloaiEntity.Kichthuoc;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Trongluong.Name].Value = _dmchungloaiEntity.Trongluong;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Somau.Name].Value = _dmchungloaiEntity.Somau;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Sohinh.Name].Value = _dmchungloaiEntity.Sohinh;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Loaimuc.Name].Value = _dmchungloaiEntity.Loaimuc;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Ghichu.Name].Value = _dmchungloaiEntity.Ghichu;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Ngaytao.Name].Value = _dmchungloaiEntity.Ngaytao;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Nguoitao.Name].Value = _dmchungloaiEntity.Nguoitao;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Ngaysua.Name].Value = _dmchungloaiEntity.Ngaysua;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Nguoisua.Name].Value = _dmchungloaiEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchungloaiManager.Convert(_dmchungloaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmchungloai_PK;
		}

	}
}
