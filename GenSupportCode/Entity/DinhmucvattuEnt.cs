
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DinhmucvattuEnt
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
	public class DinhmucvattuEnt : DinhmucvattuEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DinhmucvattuEnt()
		{
			// Nothing for now.
		}

		void BS_DINHMUCVATTU_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DINHMUCVATTU.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DINHMUCVATTU.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DinhmucvattuFields.Madinhmuc.Name].ToString();
					
					txt_MADINHMUC.Text = _Rowview.Row[DinhmucvattuFields.Madinhmuc.Name].ToString();
					txt_TENDINHMUC.Text = _Rowview.Row[DinhmucvattuFields.Tendinhmuc.Name].ToString();
					txt_MANHOM.Text = _Rowview.Row[DinhmucvattuFields.Manhom.Name].ToString();
					txt_TENNHOM.Text = _Rowview.Row[DinhmucvattuFields.Tennhom.Name].ToString();
					txt_MAMAY.Text = _Rowview.Row[DinhmucvattuFields.Mamay.Name].ToString();
					txt_MADONGMAY.Text = _Rowview.Row[DinhmucvattuFields.Madongmay.Name].ToString();
					txt_MACONGDOAN.Text = _Rowview.Row[DinhmucvattuFields.Macongdoan.Name].ToString();
					txt_SOMAUMA.Text = _Rowview.Row[DinhmucvattuFields.Somauma.Name].ToString();
					txt_MALOAIMUC.Text = _Rowview.Row[DinhmucvattuFields.Maloaimuc.Name].ToString();
					txt_MAMAU.Text = _Rowview.Row[DinhmucvattuFields.Mamau.Name].ToString();
					txt_MALOAIMANG.Text = _Rowview.Row[DinhmucvattuFields.Maloaimang.Name].ToString();
					txt_MAQCTHANHPHAM.Text = _Rowview.Row[DinhmucvattuFields.Maqcthanhpham.Name].ToString();
					txt_DINHMUC.Text = _Rowview.Row[DinhmucvattuFields.Dinhmuc.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DinhmucvattuFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DinhmucvattuFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DinhmucvattuFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DinhmucvattuFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DINHMUCVATTU_CurrentChanged"); }
		}

		private string Save_Data(string _str_DINHMUCVATTU_PK)
		{
			DinhmucvattuEntity _dinhmucvattuEntity = new DinhmucvattuEntity();
			
			_dinhmucvattuEntity.Madinhmuc = txt_MADINHMUC.Text.Trim();
			_dinhmucvattuEntity.Tendinhmuc = txt_TENDINHMUC.Text.Trim();
			_dinhmucvattuEntity.Manhom = txt_MANHOM.Text.Trim();
			_dinhmucvattuEntity.Tennhom = txt_TENNHOM.Text.Trim();
			_dinhmucvattuEntity.Mamay = txt_MAMAY.Text.Trim();
			_dinhmucvattuEntity.Madongmay = txt_MADONGMAY.Text.Trim();
			_dinhmucvattuEntity.Macongdoan = txt_MACONGDOAN.Text.Trim();
			_dinhmucvattuEntity.Somauma = txt_SOMAUMA.Text.Trim();
			_dinhmucvattuEntity.Maloaimuc = txt_MALOAIMUC.Text.Trim();
			_dinhmucvattuEntity.Mamau = txt_MAMAU.Text.Trim();
			_dinhmucvattuEntity.Maloaimang = txt_MALOAIMANG.Text.Trim();
			_dinhmucvattuEntity.Maqcthanhpham = txt_MAQCTHANHPHAM.Text.Trim();
			_dinhmucvattuEntity.Dinhmuc = txt_DINHMUC.Text.Trim();
			_dinhmucvattuEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dinhmucvattuEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dinhmucvattuEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dinhmucvattuEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DINHMUCVATTU_PK))
			{
				_str_DINHMUCVATTU_PK = _DinhmucvattuManager.InsertV2(_dinhmucvattuEntity, r_Insert, DT_DINHMUCVATTU, BS_DINHMUCVATTU);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmucvattuManager.Convert(_dinhmucvattuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DINHMUCVATTU.ResetCurrentItem();
			}
			else
			{
				_DinhmucvattuManager.Update(_dinhmucvattuEntity);
				
				GRID_DINHMUCVATTU.CurrentRow.Cells[DinhmucvattuFields.Madinhmuc.Name].Value = _dinhmucvattuEntity.Madinhmuc;
				GRID_DINHMUCVATTU.CurrentRow.Cells[DinhmucvattuFields.Tendinhmuc.Name].Value = _dinhmucvattuEntity.Tendinhmuc;
				GRID_DINHMUCVATTU.CurrentRow.Cells[DinhmucvattuFields.Manhom.Name].Value = _dinhmucvattuEntity.Manhom;
				GRID_DINHMUCVATTU.CurrentRow.Cells[DinhmucvattuFields.Tennhom.Name].Value = _dinhmucvattuEntity.Tennhom;
				GRID_DINHMUCVATTU.CurrentRow.Cells[DinhmucvattuFields.Mamay.Name].Value = _dinhmucvattuEntity.Mamay;
				GRID_DINHMUCVATTU.CurrentRow.Cells[DinhmucvattuFields.Madongmay.Name].Value = _dinhmucvattuEntity.Madongmay;
				GRID_DINHMUCVATTU.CurrentRow.Cells[DinhmucvattuFields.Macongdoan.Name].Value = _dinhmucvattuEntity.Macongdoan;
				GRID_DINHMUCVATTU.CurrentRow.Cells[DinhmucvattuFields.Somauma.Name].Value = _dinhmucvattuEntity.Somauma;
				GRID_DINHMUCVATTU.CurrentRow.Cells[DinhmucvattuFields.Maloaimuc.Name].Value = _dinhmucvattuEntity.Maloaimuc;
				GRID_DINHMUCVATTU.CurrentRow.Cells[DinhmucvattuFields.Mamau.Name].Value = _dinhmucvattuEntity.Mamau;
				GRID_DINHMUCVATTU.CurrentRow.Cells[DinhmucvattuFields.Maloaimang.Name].Value = _dinhmucvattuEntity.Maloaimang;
				GRID_DINHMUCVATTU.CurrentRow.Cells[DinhmucvattuFields.Maqcthanhpham.Name].Value = _dinhmucvattuEntity.Maqcthanhpham;
				GRID_DINHMUCVATTU.CurrentRow.Cells[DinhmucvattuFields.Dinhmuc.Name].Value = _dinhmucvattuEntity.Dinhmuc;
				GRID_DINHMUCVATTU.CurrentRow.Cells[DinhmucvattuFields.Ngaytao.Name].Value = _dinhmucvattuEntity.Ngaytao;
				GRID_DINHMUCVATTU.CurrentRow.Cells[DinhmucvattuFields.Nguoitao.Name].Value = _dinhmucvattuEntity.Nguoitao;
				GRID_DINHMUCVATTU.CurrentRow.Cells[DinhmucvattuFields.Ngaysua.Name].Value = _dinhmucvattuEntity.Ngaysua;
				GRID_DINHMUCVATTU.CurrentRow.Cells[DinhmucvattuFields.Nguoisua.Name].Value = _dinhmucvattuEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmucvattuManager.Convert(_dinhmucvattuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DINHMUCVATTU_PK;
		}

	}
}
