
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
			CtptmangDEntity _ctptmangDEntity = new CtptmangDEntity();
			
			_ctptmangDEntity.Id = txt_ID.Text.Trim();
			_ctptmangDEntity.IdH = txt_IDH.Text.Trim();
			_ctptmangDEntity.Mact = txt_MACT.Text.Trim();
			_ctptmangDEntity.Tenct = txt_TENCT.Text.Trim();
			_ctptmangDEntity.Manl = txt_MANL.Text.Trim();
			_ctptmangDEntity.Tennguyenlieu = txt_TENNGUYENLIEU.Text.Trim();
			_ctptmangDEntity.Trongluong = txt_TRONGLUONG.Text.Trim();
			_ctptmangDEntity.Tyle = txt_TYLE.Text.Trim();
			_ctptmangDEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_ctptmangDEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_ctptmangDEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_ctptmangDEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_CTPTMANGD_PK))
			{
				_str_CTPTMANGD_PK = _CtptmangDManager.InsertV2(_ctptmangDEntity, r_Insert, DT_CTPTMANGD, BS_CTPTMANGD);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CtptmangDManager.Convert(_ctptmangDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_CTPTMANGD.ResetCurrentItem();
			}
			else
			{
				_CtptmangDManager.Update(_ctptmangDEntity);
				
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Id.Name].Value = _ctptmangDEntity.Id;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.IdH.Name].Value = _ctptmangDEntity.IdH;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Mact.Name].Value = _ctptmangDEntity.Mact;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Tenct.Name].Value = _ctptmangDEntity.Tenct;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Manl.Name].Value = _ctptmangDEntity.Manl;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Tennguyenlieu.Name].Value = _ctptmangDEntity.Tennguyenlieu;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Trongluong.Name].Value = _ctptmangDEntity.Trongluong;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Tyle.Name].Value = _ctptmangDEntity.Tyle;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Ngaytao.Name].Value = _ctptmangDEntity.Ngaytao;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Nguoitao.Name].Value = _ctptmangDEntity.Nguoitao;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Ngaysua.Name].Value = _ctptmangDEntity.Ngaysua;
				GRID_CTPTMANGD.CurrentRow.Cells[CtptmangDFields.Nguoisua.Name].Value = _ctptmangDEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CtptmangDManager.Convert(_ctptmangDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_CTPTMANGD_PK;
		}

	}
}
