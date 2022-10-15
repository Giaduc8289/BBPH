
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

		void BS_DMCHUNGLOAI_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMCHUNGLOAI.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMCHUNGLOAI.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmchungloaiFields.Machungloai.Name].ToString();
					
					txt_MACHUNGLOAI.Text = _Rowview.Row[DmchungloaiFields.Machungloai.Name].ToString();
					txt_TENCHUNGLOAI.Text = _Rowview.Row[DmchungloaiFields.Tenchungloai.Name].ToString();
					txt_KICHTHUOC.Text = _Rowview.Row[DmchungloaiFields.Kichthuoc.Name].ToString();
					txt_TRONGLUONG.Text = _Rowview.Row[DmchungloaiFields.Trongluong.Name].ToString();
					txt_SOMAU.Text = _Rowview.Row[DmchungloaiFields.Somau.Name].ToString();
					txt_SOHINH.Text = _Rowview.Row[DmchungloaiFields.Sohinh.Name].ToString();
					txt_LOAIMUC.Text = _Rowview.Row[DmchungloaiFields.Loaimuc.Name].ToString();
					txt_GHICHU.Text = _Rowview.Row[DmchungloaiFields.Ghichu.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmchungloaiFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmchungloaiFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmchungloaiFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmchungloaiFields.Nguoisua.Name].ToString();
					txt_RONG.Text = _Rowview.Row[DmchungloaiFields.Rong.Name].ToString();
					txt_DAI.Text = _Rowview.Row[DmchungloaiFields.Dai.Name].ToString();
					txt_SOMAUMA.Text = _Rowview.Row[DmchungloaiFields.Somauma.Name].ToString();
					txt_SOHINHMA.Text = _Rowview.Row[DmchungloaiFields.Sohinhma.Name].ToString();
					txt_MAQCDONGGOI.Text = _Rowview.Row[DmchungloaiFields.Maqcdonggoi.Name].ToString();
					txt_TENQCDONGGOI.Text = _Rowview.Row[DmchungloaiFields.Tenqcdonggoi.Name].ToString();
					txt_MAQCLOAITHUNG.Text = _Rowview.Row[DmchungloaiFields.Maqcloaithung.Name].ToString();
					txt_TENQCLOAITHUNG.Text = _Rowview.Row[DmchungloaiFields.Tenqcloaithung.Name].ToString();
					txt_MAQCTHANHPHAM.Text = _Rowview.Row[DmchungloaiFields.Maqcthanhpham.Name].ToString();
					txt_TENQCTHANHPHAM.Text = _Rowview.Row[DmchungloaiFields.Tenqcthanhpham.Name].ToString();
					txt_MALOAIMUC.Text = _Rowview.Row[DmchungloaiFields.Maloaimuc.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMCHUNGLOAI_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMCHUNGLOAI_PK)
		{
			DmchungloaiEntity _dmchungloaiEntity = new DmchungloaiEntity();
			
			_dmchungloaiEntity.Machungloai = txt_MACHUNGLOAI.Text.Trim();
			_dmchungloaiEntity.Tenchungloai = txt_TENCHUNGLOAI.Text.Trim();
			_dmchungloaiEntity.Kichthuoc = txt_KICHTHUOC.Text.Trim();
			_dmchungloaiEntity.Trongluong = txt_TRONGLUONG.Text.Trim();
			_dmchungloaiEntity.Somau = txt_SOMAU.Text.Trim();
			_dmchungloaiEntity.Sohinh = txt_SOHINH.Text.Trim();
			_dmchungloaiEntity.Loaimuc = txt_LOAIMUC.Text.Trim();
			_dmchungloaiEntity.Ghichu = txt_GHICHU.Text.Trim();
			_dmchungloaiEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dmchungloaiEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dmchungloaiEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dmchungloaiEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_dmchungloaiEntity.Rong = txt_RONG.Text.Trim();
			_dmchungloaiEntity.Dai = txt_DAI.Text.Trim();
			_dmchungloaiEntity.Somauma = txt_SOMAUMA.Text.Trim();
			_dmchungloaiEntity.Sohinhma = txt_SOHINHMA.Text.Trim();
			_dmchungloaiEntity.Maqcdonggoi = txt_MAQCDONGGOI.Text.Trim();
			_dmchungloaiEntity.Tenqcdonggoi = txt_TENQCDONGGOI.Text.Trim();
			_dmchungloaiEntity.Maqcloaithung = txt_MAQCLOAITHUNG.Text.Trim();
			_dmchungloaiEntity.Tenqcloaithung = txt_TENQCLOAITHUNG.Text.Trim();
			_dmchungloaiEntity.Maqcthanhpham = txt_MAQCTHANHPHAM.Text.Trim();
			_dmchungloaiEntity.Tenqcthanhpham = txt_TENQCTHANHPHAM.Text.Trim();
			_dmchungloaiEntity.Maloaimuc = txt_MALOAIMUC.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMCHUNGLOAI_PK))
			{
				_str_DMCHUNGLOAI_PK = _DmchungloaiManager.InsertV2(_dmchungloaiEntity, r_Insert, DT_DMCHUNGLOAI, BS_DMCHUNGLOAI);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchungloaiManager.Convert(_dmchungloaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMCHUNGLOAI.ResetCurrentItem();
			}
			else
			{
				_DmchungloaiManager.Update(_dmchungloaiEntity);
				
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Machungloai.Name].Value = _dmchungloaiEntity.Machungloai;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Tenchungloai.Name].Value = _dmchungloaiEntity.Tenchungloai;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Kichthuoc.Name].Value = _dmchungloaiEntity.Kichthuoc;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Trongluong.Name].Value = _dmchungloaiEntity.Trongluong;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Somau.Name].Value = _dmchungloaiEntity.Somau;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Sohinh.Name].Value = _dmchungloaiEntity.Sohinh;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Loaimuc.Name].Value = _dmchungloaiEntity.Loaimuc;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Ghichu.Name].Value = _dmchungloaiEntity.Ghichu;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Ngaytao.Name].Value = _dmchungloaiEntity.Ngaytao;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Nguoitao.Name].Value = _dmchungloaiEntity.Nguoitao;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Ngaysua.Name].Value = _dmchungloaiEntity.Ngaysua;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Nguoisua.Name].Value = _dmchungloaiEntity.Nguoisua;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Rong.Name].Value = _dmchungloaiEntity.Rong;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Dai.Name].Value = _dmchungloaiEntity.Dai;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Somauma.Name].Value = _dmchungloaiEntity.Somauma;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Sohinhma.Name].Value = _dmchungloaiEntity.Sohinhma;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Maqcdonggoi.Name].Value = _dmchungloaiEntity.Maqcdonggoi;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Tenqcdonggoi.Name].Value = _dmchungloaiEntity.Tenqcdonggoi;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Maqcloaithung.Name].Value = _dmchungloaiEntity.Maqcloaithung;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Tenqcloaithung.Name].Value = _dmchungloaiEntity.Tenqcloaithung;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Maqcthanhpham.Name].Value = _dmchungloaiEntity.Maqcthanhpham;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Tenqcthanhpham.Name].Value = _dmchungloaiEntity.Tenqcthanhpham;
				GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Maloaimuc.Name].Value = _dmchungloaiEntity.Maloaimuc;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchungloaiManager.Convert(_dmchungloaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMCHUNGLOAI_PK;
		}

	}
}
