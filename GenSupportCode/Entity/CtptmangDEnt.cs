
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.CtptmangDEnt
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
	public class CtptmangDEnt : CtptmangDEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CtptmangDEnt()
		{
			// Nothing for now.
		}

		void BS_CTPTMANGD_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_CTPTMANGD.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_CTPTMANGD.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[CtptmangDFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[CtptmangDFields.Id.Name].ToString();
					txt_IDH.Text = _Rowview.Row[CtptmangDFields.IdH.Name].ToString();
					txt_MACT.Text = _Rowview.Row[CtptmangDFields.Mact.Name].ToString();
					txt_TENCT.Text = _Rowview.Row[CtptmangDFields.Tenct.Name].ToString();
					txt_MANL.Text = _Rowview.Row[CtptmangDFields.Manl.Name].ToString();
					txt_TENNGUYENLIEU.Text = _Rowview.Row[CtptmangDFields.Tennguyenlieu.Name].ToString();
					txt_TRONGLUONG.Text = _Rowview.Row[CtptmangDFields.Trongluong.Name].ToString();
					txt_TYLE.Text = _Rowview.Row[CtptmangDFields.Tyle.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[CtptmangDFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[CtptmangDFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[CtptmangDFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[CtptmangDFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_CTPTMANGD_CurrentChanged"); }
		}

		private string Save_Data(string _str_CTPTMANGD_PK)
		{
			CtptmangDEntity _CtptmangDEntity = new CtptmangDEntity();
			
			_CtptmangDEntity.Id = txt_ID.Text.Trim();
			_CtptmangDEntity.IdH = txt_IDH.Text.Trim();
			_CtptmangDEntity.Mact = txt_MACT.Text.Trim();
			_CtptmangDEntity.Tenct = txt_TENCT.Text.Trim();
			_CtptmangDEntity.Manl = txt_MANL.Text.Trim();
			_CtptmangDEntity.Tennguyenlieu = txt_TENNGUYENLIEU.Text.Trim();
			_CtptmangDEntity.Trongluong = txt_TRONGLUONG.Text.Trim();
			_CtptmangDEntity.Tyle = txt_TYLE.Text.Trim();
			_CtptmangDEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_CtptmangDEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_CtptmangDEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_CtptmangDEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_CTPTMANGD_PK))
			{
				_str_CTPTMANGD_PK = _CtptmangDManager.InsertV2(_CtptmangDEntity, r_Insert, DT_CTPTMANGD, BS_CTPTMANGD);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CtptmangDManager.Convert(_CtptmangDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_CTPTMANGD.ResetCurrentItem();
			}
			else
			{
				_CtptmangDManager.Update(_CtptmangDEntity);
				
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Id.Name].Value = _CtptmangDEntity.Id;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.IdH.Name].Value = _CtptmangDEntity.IdH;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Mact.Name].Value = _CtptmangDEntity.Mact;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Tenct.Name].Value = _CtptmangDEntity.Tenct;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Manl.Name].Value = _CtptmangDEntity.Manl;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Tennguyenlieu.Name].Value = _CtptmangDEntity.Tennguyenlieu;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Trongluong.Name].Value = _CtptmangDEntity.Trongluong;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Tyle.Name].Value = _CtptmangDEntity.Tyle;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Ngaytao.Name].Value = _CtptmangDEntity.Ngaytao;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Nguoitao.Name].Value = _CtptmangDEntity.Nguoitao;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Ngaysua.Name].Value = _CtptmangDEntity.Ngaysua;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Nguoisua.Name].Value = _CtptmangDEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CtptmangDManager.Convert(_CtptmangDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_CTPTMANGD_PK;
		}

	}
}
