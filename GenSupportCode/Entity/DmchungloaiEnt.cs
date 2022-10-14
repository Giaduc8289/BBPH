
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
					txt_Rong.Text = _Rowview.Row[DmchungloaiFields.Rong.Name].ToString();
					txt_Dai.Text = _Rowview.Row[DmchungloaiFields.Dai.Name].ToString();
					txt_Somauma.Text = _Rowview.Row[DmchungloaiFields.Somauma.Name].ToString();
					txt_Sohinhma.Text = _Rowview.Row[DmchungloaiFields.Sohinhma.Name].ToString();
					txt_Maqcdonggoi.Text = _Rowview.Row[DmchungloaiFields.Maqcdonggoi.Name].ToString();
					txt_Tenqcdonggoi.Text = _Rowview.Row[DmchungloaiFields.Tenqcdonggoi.Name].ToString();
					txt_Maqcloaithung.Text = _Rowview.Row[DmchungloaiFields.Maqcloaithung.Name].ToString();
					txt_Tenqcloaithung.Text = _Rowview.Row[DmchungloaiFields.Tenqcloaithung.Name].ToString();
					txt_Maqcthanhpham.Text = _Rowview.Row[DmchungloaiFields.Maqcthanhpham.Name].ToString();
					txt_Tenqcthanhpham.Text = _Rowview.Row[DmchungloaiFields.Tenqcthanhpham.Name].ToString();
					txt_Maloaimuc.Text = _Rowview.Row[DmchungloaiFields.Maloaimuc.Name].ToString();
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
			_dmchungloaiEntity.Rong = txt_Rong.Text.Trim();
			_dmchungloaiEntity.Dai = txt_Dai.Text.Trim();
			_dmchungloaiEntity.Somauma = txt_Somauma.Text.Trim();
			_dmchungloaiEntity.Sohinhma = txt_Sohinhma.Text.Trim();
			_dmchungloaiEntity.Maqcdonggoi = txt_Maqcdonggoi.Text.Trim();
			_dmchungloaiEntity.Tenqcdonggoi = txt_Tenqcdonggoi.Text.Trim();
			_dmchungloaiEntity.Maqcloaithung = txt_Maqcloaithung.Text.Trim();
			_dmchungloaiEntity.Tenqcloaithung = txt_Tenqcloaithung.Text.Trim();
			_dmchungloaiEntity.Maqcthanhpham = txt_Maqcthanhpham.Text.Trim();
			_dmchungloaiEntity.Tenqcthanhpham = txt_Tenqcthanhpham.Text.Trim();
			_dmchungloaiEntity.Maloaimuc = txt_Maloaimuc.Text.Trim();
			
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
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Rong.Name].Value = _dmchungloaiEntity.Rong;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Dai.Name].Value = _dmchungloaiEntity.Dai;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Somauma.Name].Value = _dmchungloaiEntity.Somauma;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Sohinhma.Name].Value = _dmchungloaiEntity.Sohinhma;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Maqcdonggoi.Name].Value = _dmchungloaiEntity.Maqcdonggoi;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Tenqcdonggoi.Name].Value = _dmchungloaiEntity.Tenqcdonggoi;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Maqcloaithung.Name].Value = _dmchungloaiEntity.Maqcloaithung;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Tenqcloaithung.Name].Value = _dmchungloaiEntity.Tenqcloaithung;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Maqcthanhpham.Name].Value = _dmchungloaiEntity.Maqcthanhpham;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Tenqcthanhpham.Name].Value = _dmchungloaiEntity.Tenqcthanhpham;
				GRID_Dmchungloai.CurrentRow.Cells[DmchungloaiFields.Maloaimuc.Name].Value = _dmchungloaiEntity.Maloaimuc;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchungloaiManager.Convert(_dmchungloaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmchungloai_PK;
		}

	}
}
