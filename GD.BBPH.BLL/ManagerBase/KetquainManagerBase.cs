


/*
'===============================================================================
'  GD.BBPH.BL.KetquainManagerBase
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
using System.Windows.Forms;
namespace GD.BBPH.BLL
{
	public class KetquainManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngay="Ngay";				
		
		public const String Field_Ca="Ca";				
		
		public const String Field_Mamay="Mamay";				
		
		public const String Field_Lenhin="Lenhin";				
		
		public const String Field_Masanpham="Masanpham";				
		
		public const String Field_Macongnhan="Macongnhan";				
		
		public const String Field_SometLsx="SometLsx";				
		
		public const String Field_Sometcap="Sometcap";				
		
		public const String Field_Sokgcap="Sokgcap";				
		
		public const String Field_Thuctein="Thuctein";				
		
		public const String Field_Sokgin="Sokgin";				
		
		public const String Field_Saihongthucte="Saihongthucte";				
		
		public const String Field_Thoigianbatdau="Thoigianbatdau";				
		
		public const String Field_Thoigianketthuc="Thoigianketthuc";				
		
		public const String Field_Thoigianchuanbi="Thoigianchuanbi";				
		
		public const String Field_Thoigiansuco="Thoigiansuco";				
		
		public const String Field_PheNcc="PheNcc";				
		
		public const String Field_PheSx="PheSx";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
		public const String Field_Tensanpham="Tensanpham";				
		
		public const String Field_Tenmay="Tenmay";				
		
		public const String Field_Tencongnhan="Tencongnhan";				
		
		public const String Field_Nangsuat="Nangsuat";				
		
		public const String Field_Tylesaihong="Tylesaihong";				
		
		public const String Field_Tongmdm="Tongmdm";				
		
		public const String Field_Matruongca="Matruongca";				
		
		public const String Field_Tentruongca="Tentruongca";				
		
		public const String Field_Tocdodinhmuc="Tocdodinhmuc";				
		
		public const String Field_Lydosuco="Lydosuco";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquainManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Ngay,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Ca,typeof(System.Int32));
			
			dt.Columns.Add(Field_Mamay,typeof(System.String));
			
			dt.Columns.Add(Field_Lenhin,typeof(System.String));
			
			dt.Columns.Add(Field_Masanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Macongnhan,typeof(System.String));
			
			dt.Columns.Add(Field_SometLsx,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sometcap,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sokgcap,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thuctein,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sokgin,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Saihongthucte,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigianbatdau,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigianketthuc,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigianchuanbi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigiansuco,typeof(System.Decimal));
			
			dt.Columns.Add(Field_PheNcc,typeof(System.Decimal));
			
			dt.Columns.Add(Field_PheSx,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
			
			dt.Columns.Add(Field_Tensanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmay,typeof(System.String));
			
			dt.Columns.Add(Field_Tencongnhan,typeof(System.String));
			
			dt.Columns.Add(Field_Nangsuat,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Tylesaihong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Tongmdm,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Matruongca,typeof(System.String));
			
			dt.Columns.Add(Field_Tentruongca,typeof(System.String));
			
			dt.Columns.Add(Field_Tocdodinhmuc,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Lydosuco,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(KetquainEntity _KetquainEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_KetquainEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngay]=_KetquainEntity.Ngay;
			}
			catch { }
			
			try
			{
				r[Field_Ca]=_KetquainEntity.Ca;
			}
			catch { }
			
			try
			{
				r[Field_Mamay]=_KetquainEntity.Mamay;
			}
			catch { }
			
			try
			{
				r[Field_Lenhin]=_KetquainEntity.Lenhin;
			}
			catch { }
			
			try
			{
				r[Field_Masanpham]=_KetquainEntity.Masanpham;
			}
			catch { }
			
			try
			{
				r[Field_Macongnhan]=_KetquainEntity.Macongnhan;
			}
			catch { }
			
			try
			{
				r[Field_SometLsx]=_KetquainEntity.SometLsx;
			}
			catch { }
			
			try
			{
				r[Field_Sometcap]=_KetquainEntity.Sometcap;
			}
			catch { }
			
			try
			{
				r[Field_Sokgcap]=_KetquainEntity.Sokgcap;
			}
			catch { }
			
			try
			{
				r[Field_Thuctein]=_KetquainEntity.Thuctein;
			}
			catch { }
			
			try
			{
				r[Field_Sokgin]=_KetquainEntity.Sokgin;
			}
			catch { }
			
			try
			{
				r[Field_Saihongthucte]=_KetquainEntity.Saihongthucte;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianbatdau]=_KetquainEntity.Thoigianbatdau;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianketthuc]=_KetquainEntity.Thoigianketthuc;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianchuanbi]=_KetquainEntity.Thoigianchuanbi;
			}
			catch { }
			
			try
			{
				r[Field_Thoigiansuco]=_KetquainEntity.Thoigiansuco;
			}
			catch { }
			
			try
			{
				r[Field_PheNcc]=_KetquainEntity.PheNcc;
			}
			catch { }
			
			try
			{
				r[Field_PheSx]=_KetquainEntity.PheSx;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_KetquainEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_KetquainEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_KetquainEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_KetquainEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Tensanpham]=_KetquainEntity.Tensanpham;
			}
			catch { }
			
			try
			{
				r[Field_Tenmay]=_KetquainEntity.Tenmay;
			}
			catch { }
			
			try
			{
				r[Field_Tencongnhan]=_KetquainEntity.Tencongnhan;
			}
			catch { }
			
			try
			{
				r[Field_Nangsuat]=_KetquainEntity.Nangsuat;
			}
			catch { }
			
			try
			{
				r[Field_Tylesaihong]=_KetquainEntity.Tylesaihong;
			}
			catch { }
			
			try
			{
				r[Field_Tongmdm]=_KetquainEntity.Tongmdm;
			}
			catch { }
			
			try
			{
				r[Field_Matruongca]=_KetquainEntity.Matruongca;
			}
			catch { }
			
			try
			{
				r[Field_Tentruongca]=_KetquainEntity.Tentruongca;
			}
			catch { }
			
			try
			{
				r[Field_Tocdodinhmuc]=_KetquainEntity.Tocdodinhmuc;
			}
			catch { }
			
			try
			{
				r[Field_Lydosuco]=_KetquainEntity.Lydosuco;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public KetquainEntity Convert(DataRow r)
		{	
			
			KetquainEntity _KetquainEntity=new KetquainEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_KetquainEntity.Ngay= System.DateTime.Parse(r[Field_Ngay].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Ca= System.Int32.Parse(r[Field_Ca].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Mamay= r[Field_Mamay].ToString();						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Lenhin= r[Field_Lenhin].ToString();						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Masanpham= r[Field_Masanpham].ToString();						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Macongnhan= r[Field_Macongnhan].ToString();						
			}
			catch { }
			
			try
			{
				_KetquainEntity.SometLsx= System.Decimal.Parse(r[Field_SometLsx].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Sometcap= System.Decimal.Parse(r[Field_Sometcap].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Sokgcap= System.Decimal.Parse(r[Field_Sokgcap].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Thuctein= System.Decimal.Parse(r[Field_Thuctein].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Sokgin= System.Decimal.Parse(r[Field_Sokgin].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Saihongthucte= System.Decimal.Parse(r[Field_Saihongthucte].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Thoigianbatdau= System.DateTime.Parse(r[Field_Thoigianbatdau].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Thoigianketthuc= System.DateTime.Parse(r[Field_Thoigianketthuc].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Thoigianchuanbi= System.Decimal.Parse(r[Field_Thoigianchuanbi].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Thoigiansuco= System.Decimal.Parse(r[Field_Thoigiansuco].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.PheNcc= System.Decimal.Parse(r[Field_PheNcc].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.PheSx= System.Decimal.Parse(r[Field_PheSx].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Tensanpham= r[Field_Tensanpham].ToString();						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Tenmay= r[Field_Tenmay].ToString();						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Tencongnhan= r[Field_Tencongnhan].ToString();						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Nangsuat= System.Decimal.Parse(r[Field_Nangsuat].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Tylesaihong= System.Decimal.Parse(r[Field_Tylesaihong].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Tongmdm= System.Decimal.Parse(r[Field_Tongmdm].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Matruongca= r[Field_Matruongca].ToString();						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Tentruongca= r[Field_Tentruongca].ToString();						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Tocdodinhmuc= System.Decimal.Parse(r[Field_Tocdodinhmuc].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainEntity.Lydosuco= r[Field_Lydosuco].ToString();						
			}
			catch { }
									
									
			return _KetquainEntity;
		}			
		
		public KetquainEntity Convert_Entity(KetquainEntity _KetquainEntity,KetquainEntity _KetquainEntity_XML)
		{	
			
			
			_KetquainEntity.Id= _KetquainEntity_XML.Id;
			
			_KetquainEntity.Ngay= _KetquainEntity_XML.Ngay;
			
			_KetquainEntity.Ca= _KetquainEntity_XML.Ca;
			
			_KetquainEntity.Mamay= _KetquainEntity_XML.Mamay;
			
			_KetquainEntity.Lenhin= _KetquainEntity_XML.Lenhin;
			
			_KetquainEntity.Masanpham= _KetquainEntity_XML.Masanpham;
			
			_KetquainEntity.Macongnhan= _KetquainEntity_XML.Macongnhan;
			
			_KetquainEntity.SometLsx= _KetquainEntity_XML.SometLsx;
			
			_KetquainEntity.Sometcap= _KetquainEntity_XML.Sometcap;
			
			_KetquainEntity.Sokgcap= _KetquainEntity_XML.Sokgcap;
			
			_KetquainEntity.Thuctein= _KetquainEntity_XML.Thuctein;
			
			_KetquainEntity.Sokgin= _KetquainEntity_XML.Sokgin;
			
			_KetquainEntity.Saihongthucte= _KetquainEntity_XML.Saihongthucte;
			
			_KetquainEntity.Thoigianbatdau= _KetquainEntity_XML.Thoigianbatdau;
			
			_KetquainEntity.Thoigianketthuc= _KetquainEntity_XML.Thoigianketthuc;
			
			_KetquainEntity.Thoigianchuanbi= _KetquainEntity_XML.Thoigianchuanbi;
			
			_KetquainEntity.Thoigiansuco= _KetquainEntity_XML.Thoigiansuco;
			
			_KetquainEntity.PheNcc= _KetquainEntity_XML.PheNcc;
			
			_KetquainEntity.PheSx= _KetquainEntity_XML.PheSx;
			
			_KetquainEntity.Ngaytao= _KetquainEntity_XML.Ngaytao;
			
			_KetquainEntity.Nguoitao= _KetquainEntity_XML.Nguoitao;
			
			_KetquainEntity.Ngaysua= _KetquainEntity_XML.Ngaysua;
			
			_KetquainEntity.Nguoisua= _KetquainEntity_XML.Nguoisua;
			
			_KetquainEntity.Tensanpham= _KetquainEntity_XML.Tensanpham;
			
			_KetquainEntity.Tenmay= _KetquainEntity_XML.Tenmay;
			
			_KetquainEntity.Tencongnhan= _KetquainEntity_XML.Tencongnhan;
			
			_KetquainEntity.Nangsuat= _KetquainEntity_XML.Nangsuat;
			
			_KetquainEntity.Tylesaihong= _KetquainEntity_XML.Tylesaihong;
			
			_KetquainEntity.Tongmdm= _KetquainEntity_XML.Tongmdm;
			
			_KetquainEntity.Matruongca= _KetquainEntity_XML.Matruongca;
			
			_KetquainEntity.Tentruongca= _KetquainEntity_XML.Tentruongca;
			
			_KetquainEntity.Tocdodinhmuc= _KetquainEntity_XML.Tocdodinhmuc;
			
			_KetquainEntity.Lydosuco= _KetquainEntity_XML.Lydosuco;
									
				
			return _KetquainEntity;
		}	
		
		public String InsertV2(KetquainEntity _KetquainEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new KetquainManagerBase()).Insert(_KetquainEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_KetquainEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngay,_KetquainEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KetquainEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KetquainEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhin,_KetquainEntity.Lenhin);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KetquainEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongnhan,_KetquainEntity.Macongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_SometLsx,_KetquainEntity.SometLsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometcap,_KetquainEntity.Sometcap);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgcap,_KetquainEntity.Sokgcap);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thuctein,_KetquainEntity.Thuctein);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgin,_KetquainEntity.Sokgin);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Saihongthucte,_KetquainEntity.Saihongthucte);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianbatdau,_KetquainEntity.Thoigianbatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianketthuc,_KetquainEntity.Thoigianketthuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianchuanbi,_KetquainEntity.Thoigianchuanbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiansuco,_KetquainEntity.Thoigiansuco);
			}
			catch { }
			
			try
			{
				r.SetField(Field_PheNcc,_KetquainEntity.PheNcc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_PheSx,_KetquainEntity.PheSx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KetquainEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KetquainEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KetquainEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KetquainEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_KetquainEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmay,_KetquainEntity.Tenmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongnhan,_KetquainEntity.Tencongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nangsuat,_KetquainEntity.Nangsuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tylesaihong,_KetquainEntity.Tylesaihong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tongmdm,_KetquainEntity.Tongmdm);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Matruongca,_KetquainEntity.Matruongca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tentruongca,_KetquainEntity.Tentruongca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tocdodinhmuc,_KetquainEntity.Tocdodinhmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lydosuco,_KetquainEntity.Lydosuco);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(KetquainEntity _KetquainEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new KetquainManagerBase()).Update(_KetquainEntity);
			r.SetField(Field_Id,_KetquainEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngay,_KetquainEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KetquainEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KetquainEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhin,_KetquainEntity.Lenhin);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KetquainEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongnhan,_KetquainEntity.Macongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_SometLsx,_KetquainEntity.SometLsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometcap,_KetquainEntity.Sometcap);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgcap,_KetquainEntity.Sokgcap);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thuctein,_KetquainEntity.Thuctein);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgin,_KetquainEntity.Sokgin);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Saihongthucte,_KetquainEntity.Saihongthucte);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianbatdau,_KetquainEntity.Thoigianbatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianketthuc,_KetquainEntity.Thoigianketthuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianchuanbi,_KetquainEntity.Thoigianchuanbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiansuco,_KetquainEntity.Thoigiansuco);
			}
			catch { }
			
			try
			{
				r.SetField(Field_PheNcc,_KetquainEntity.PheNcc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_PheSx,_KetquainEntity.PheSx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KetquainEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KetquainEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KetquainEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KetquainEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_KetquainEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmay,_KetquainEntity.Tenmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongnhan,_KetquainEntity.Tencongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nangsuat,_KetquainEntity.Nangsuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tylesaihong,_KetquainEntity.Tylesaihong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tongmdm,_KetquainEntity.Tongmdm);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Matruongca,_KetquainEntity.Matruongca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tentruongca,_KetquainEntity.Tentruongca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tocdodinhmuc,_KetquainEntity.Tocdodinhmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lydosuco,_KetquainEntity.Lydosuco);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
		}

		public void InsertCollection(EntityCollection _Collection)
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntityCollection(_Collection);
			}
		}

		public KetquainEntity Insert(KetquainEntity KetquainEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(KetquainEntity, true);
			}
			return KetquainEntity;
		}

		public KetquainEntity Insert(System.Int64  Id, System.DateTime  Ngay, System.Int32  Ca, System.String  Mamay, System.String  Lenhin, System.String  Masanpham, System.String  Macongnhan, System.Decimal  SometLsx, System.Decimal  Sometcap, System.Decimal  Sokgcap, System.Decimal  Thuctein, System.Decimal  Sokgin, System.Decimal  Saihongthucte, System.DateTime  Thoigianbatdau, System.DateTime  Thoigianketthuc, System.Decimal  Thoigianchuanbi, System.Decimal  Thoigiansuco, System.Decimal  PheNcc, System.Decimal  PheSx, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.String  Tensanpham, System.String  Tenmay, System.String  Tencongnhan, System.Decimal  Nangsuat, System.Decimal  Tylesaihong, System.Decimal  Tongmdm, System.String  Matruongca, System.String  Tentruongca, System.Decimal  Tocdodinhmuc, System.String  Lydosuco)
		{
			KetquainEntity _KetquainEntity = new KetquainEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KetquainEntity.Id = Id;
				
				_KetquainEntity.Ngay = Ngay;
				
				_KetquainEntity.Ca = Ca;
				
				_KetquainEntity.Mamay = Mamay;
				
				_KetquainEntity.Lenhin = Lenhin;
				
				_KetquainEntity.Masanpham = Masanpham;
				
				_KetquainEntity.Macongnhan = Macongnhan;
				
				_KetquainEntity.SometLsx = SometLsx;
				
				_KetquainEntity.Sometcap = Sometcap;
				
				_KetquainEntity.Sokgcap = Sokgcap;
				
				_KetquainEntity.Thuctein = Thuctein;
				
				_KetquainEntity.Sokgin = Sokgin;
				
				_KetquainEntity.Saihongthucte = Saihongthucte;
				
				_KetquainEntity.Thoigianbatdau = Thoigianbatdau;
				
				_KetquainEntity.Thoigianketthuc = Thoigianketthuc;
				
				_KetquainEntity.Thoigianchuanbi = Thoigianchuanbi;
				
				_KetquainEntity.Thoigiansuco = Thoigiansuco;
				
				_KetquainEntity.PheNcc = PheNcc;
				
				_KetquainEntity.PheSx = PheSx;
				
				_KetquainEntity.Ngaytao = Ngaytao;
				
				_KetquainEntity.Nguoitao = Nguoitao;
				
				_KetquainEntity.Ngaysua = Ngaysua;
				
				_KetquainEntity.Nguoisua = Nguoisua;
				
				_KetquainEntity.Tensanpham = Tensanpham;
				
				_KetquainEntity.Tenmay = Tenmay;
				
				_KetquainEntity.Tencongnhan = Tencongnhan;
				
				_KetquainEntity.Nangsuat = Nangsuat;
				
				_KetquainEntity.Tylesaihong = Tylesaihong;
				
				_KetquainEntity.Tongmdm = Tongmdm;
				
				_KetquainEntity.Matruongca = Matruongca;
				
				_KetquainEntity.Tentruongca = Tentruongca;
				
				_KetquainEntity.Tocdodinhmuc = Tocdodinhmuc;
				
				_KetquainEntity.Lydosuco = Lydosuco;
					
					
				adapter.SaveEntity(_KetquainEntity, true);
			}
			return _KetquainEntity;
		}

		public KetquainEntity Insert(System.DateTime Ngay, System.Int32 Ca, System.String Mamay, System.String Lenhin, System.String Masanpham, System.String Macongnhan, System.Decimal SometLsx, System.Decimal Sometcap, System.Decimal Sokgcap, System.Decimal Thuctein, System.Decimal Sokgin, System.Decimal Saihongthucte, System.DateTime Thoigianbatdau, System.DateTime Thoigianketthuc, System.Decimal Thoigianchuanbi, System.Decimal Thoigiansuco, System.Decimal PheNcc, System.Decimal PheSx, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.String Tensanpham, System.String Tenmay, System.String Tencongnhan, System.Decimal Nangsuat, System.Decimal Tylesaihong, System.Decimal Tongmdm, System.String Matruongca, System.String Tentruongca, System.Decimal Tocdodinhmuc, System.String Lydosuco)//ko co mahieu
		{
			KetquainEntity _KetquainEntity = new KetquainEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_KetquainEntity.Ngay = Ngay;
				
				_KetquainEntity.Ca = Ca;
				
				_KetquainEntity.Mamay = Mamay;
				
				_KetquainEntity.Lenhin = Lenhin;
				
				_KetquainEntity.Masanpham = Masanpham;
				
				_KetquainEntity.Macongnhan = Macongnhan;
				
				_KetquainEntity.SometLsx = SometLsx;
				
				_KetquainEntity.Sometcap = Sometcap;
				
				_KetquainEntity.Sokgcap = Sokgcap;
				
				_KetquainEntity.Thuctein = Thuctein;
				
				_KetquainEntity.Sokgin = Sokgin;
				
				_KetquainEntity.Saihongthucte = Saihongthucte;
				
				_KetquainEntity.Thoigianbatdau = Thoigianbatdau;
				
				_KetquainEntity.Thoigianketthuc = Thoigianketthuc;
				
				_KetquainEntity.Thoigianchuanbi = Thoigianchuanbi;
				
				_KetquainEntity.Thoigiansuco = Thoigiansuco;
				
				_KetquainEntity.PheNcc = PheNcc;
				
				_KetquainEntity.PheSx = PheSx;
				
				_KetquainEntity.Ngaytao = Ngaytao;
				
				_KetquainEntity.Nguoitao = Nguoitao;
				
				_KetquainEntity.Ngaysua = Ngaysua;
				
				_KetquainEntity.Nguoisua = Nguoisua;
				
				_KetquainEntity.Tensanpham = Tensanpham;
				
				_KetquainEntity.Tenmay = Tenmay;
				
				_KetquainEntity.Tencongnhan = Tencongnhan;
				
				_KetquainEntity.Nangsuat = Nangsuat;
				
				_KetquainEntity.Tylesaihong = Tylesaihong;
				
				_KetquainEntity.Tongmdm = Tongmdm;
				
				_KetquainEntity.Matruongca = Matruongca;
				
				_KetquainEntity.Tentruongca = Tentruongca;
				
				_KetquainEntity.Tocdodinhmuc = Tocdodinhmuc;
				
				_KetquainEntity.Lydosuco = Lydosuco;
					

				adapter.SaveEntity(_KetquainEntity, true);
			}
			return _KetquainEntity;
		}

		public bool Update(KetquainEntity _KetquainEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(KetquainFields.Id == _KetquainEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_KetquainEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(KetquainEntity _KetquainEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_KetquainEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngay, System.Int32 Ca, System.String Mamay, System.String Lenhin, System.String Masanpham, System.String Macongnhan, System.Decimal SometLsx, System.Decimal Sometcap, System.Decimal Sokgcap, System.Decimal Thuctein, System.Decimal Sokgin, System.Decimal Saihongthucte, System.DateTime Thoigianbatdau, System.DateTime Thoigianketthuc, System.Decimal Thoigianchuanbi, System.Decimal Thoigiansuco, System.Decimal PheNcc, System.Decimal PheSx, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.String Tensanpham, System.String Tenmay, System.String Tencongnhan, System.Decimal Nangsuat, System.Decimal Tylesaihong, System.Decimal Tongmdm, System.String Matruongca, System.String Tentruongca, System.Decimal Tocdodinhmuc, System.String Lydosuco)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquainEntity _KetquainEntity = new KetquainEntity(Id);
				if (adapter.FetchEntity(_KetquainEntity))
				{
				
					
					
					_KetquainEntity.Ngay = Ngay;
					
					_KetquainEntity.Ca = Ca;
					
					_KetquainEntity.Mamay = Mamay;
					
					_KetquainEntity.Lenhin = Lenhin;
					
					_KetquainEntity.Masanpham = Masanpham;
					
					_KetquainEntity.Macongnhan = Macongnhan;
					
					_KetquainEntity.SometLsx = SometLsx;
					
					_KetquainEntity.Sometcap = Sometcap;
					
					_KetquainEntity.Sokgcap = Sokgcap;
					
					_KetquainEntity.Thuctein = Thuctein;
					
					_KetquainEntity.Sokgin = Sokgin;
					
					_KetquainEntity.Saihongthucte = Saihongthucte;
					
					_KetquainEntity.Thoigianbatdau = Thoigianbatdau;
					
					_KetquainEntity.Thoigianketthuc = Thoigianketthuc;
					
					_KetquainEntity.Thoigianchuanbi = Thoigianchuanbi;
					
					_KetquainEntity.Thoigiansuco = Thoigiansuco;
					
					_KetquainEntity.PheNcc = PheNcc;
					
					_KetquainEntity.PheSx = PheSx;
					
					_KetquainEntity.Ngaytao = Ngaytao;
					
					_KetquainEntity.Nguoitao = Nguoitao;
					
					_KetquainEntity.Ngaysua = Ngaysua;
					
					_KetquainEntity.Nguoisua = Nguoisua;
					
					_KetquainEntity.Tensanpham = Tensanpham;
					
					_KetquainEntity.Tenmay = Tenmay;
					
					_KetquainEntity.Tencongnhan = Tencongnhan;
					
					_KetquainEntity.Nangsuat = Nangsuat;
					
					_KetquainEntity.Tylesaihong = Tylesaihong;
					
					_KetquainEntity.Tongmdm = Tongmdm;
					
					_KetquainEntity.Matruongca = Matruongca;
					
					_KetquainEntity.Tentruongca = Tentruongca;
					
					_KetquainEntity.Tocdodinhmuc = Tocdodinhmuc;
					
					_KetquainEntity.Lydosuco = Lydosuco;
						

					adapter.SaveEntity(_KetquainEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.Int64 Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquainEntity _KetquainEntity = new KetquainEntity(Id);
				if (adapter.FetchEntity(_KetquainEntity))
				{
					adapter.DeleteEntity(_KetquainEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("KetquainEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgay(System.DateTime Ngay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCa(System.Int32 Ca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamay(System.String Mamay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLenhin(System.String Lenhin)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Lenhin == Lenhin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasanpham(System.String Masanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMacongnhan(System.String Macongnhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySometLsx(System.Decimal SometLsx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.SometLsx == SometLsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySometcap(System.Decimal Sometcap)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Sometcap == Sometcap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokgcap(System.Decimal Sokgcap)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Sokgcap == Sokgcap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThuctein(System.Decimal Thuctein)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Thuctein == Thuctein);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokgin(System.Decimal Sokgin)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Sokgin == Sokgin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySaihongthucte(System.Decimal Saihongthucte)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Saihongthucte == Saihongthucte);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianbatdau(System.DateTime Thoigianbatdau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianketthuc(System.DateTime Thoigianketthuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianchuanbi(System.Decimal Thoigianchuanbi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Thoigianchuanbi == Thoigianchuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigiansuco(System.Decimal Thoigiansuco)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPheNcc(System.Decimal PheNcc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.PheNcc == PheNcc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPheSx(System.Decimal PheSx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.PheSx == PheSx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensanpham(System.String Tensanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmay(System.String Tenmay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTencongnhan(System.String Tencongnhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNangsuat(System.Decimal Nangsuat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Nangsuat == Nangsuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTylesaihong(System.Decimal Tylesaihong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tylesaihong == Tylesaihong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTongmdm(System.Decimal Tongmdm)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tongmdm == Tongmdm);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMatruongca(System.String Matruongca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Matruongca == Matruongca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTentruongca(System.String Tentruongca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tentruongca == Tentruongca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTocdodinhmuc(System.Decimal Tocdodinhmuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tocdodinhmuc == Tocdodinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLydosuco(System.String Lydosuco)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Lydosuco == Lydosuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainEntity", filter);
			}
			return toReturn;
		}		
			
		
		public KetquainEntity SelectOne(System.Int64 Id)
		{
			KetquainEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquainEntity _KetquainEntity = new KetquainEntity(Id);
				if (adapter.FetchEntity(_KetquainEntity))
				{
					toReturn = _KetquainEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _KetquainCollection = new EntityCollection( new KetquainEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, null, 0, null);
			}
			return _KetquainCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgay(System.DateTime Ngay)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayRDT(System.DateTime Ngay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCa(System.Int32 Ca)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByCaRDT(System.Int32 Ca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamay(System.String Mamay)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByMamayRDT(System.String Mamay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLenhin(System.String Lenhin)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Lenhin == Lenhin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByLenhinRDT(System.String Lenhin)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Lenhin == Lenhin);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasanpham(System.String Masanpham)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByMasanphamRDT(System.String Masanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMacongnhan(System.String Macongnhan)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByMacongnhanRDT(System.String Macongnhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySometLsx(System.Decimal SometLsx)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.SometLsx == SometLsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectBySometLsxRDT(System.Decimal SometLsx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.SometLsx == SometLsx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySometcap(System.Decimal Sometcap)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Sometcap == Sometcap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectBySometcapRDT(System.Decimal Sometcap)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Sometcap == Sometcap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokgcap(System.Decimal Sokgcap)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Sokgcap == Sokgcap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgcapRDT(System.Decimal Sokgcap)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Sokgcap == Sokgcap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThuctein(System.Decimal Thuctein)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Thuctein == Thuctein);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByThucteinRDT(System.Decimal Thuctein)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Thuctein == Thuctein);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokgin(System.Decimal Sokgin)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Sokgin == Sokgin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectBySokginRDT(System.Decimal Sokgin)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Sokgin == Sokgin);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySaihongthucte(System.Decimal Saihongthucte)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Saihongthucte == Saihongthucte);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectBySaihongthucteRDT(System.Decimal Saihongthucte)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Saihongthucte == Saihongthucte);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianbatdau(System.DateTime Thoigianbatdau)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianbatdauRDT(System.DateTime Thoigianbatdau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianketthuc(System.DateTime Thoigianketthuc)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianketthucRDT(System.DateTime Thoigianketthuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianchuanbi(System.Decimal Thoigianchuanbi)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Thoigianchuanbi == Thoigianchuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianchuanbiRDT(System.Decimal Thoigianchuanbi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Thoigianchuanbi == Thoigianchuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigiansuco(System.Decimal Thoigiansuco)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigiansucoRDT(System.Decimal Thoigiansuco)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPheNcc(System.Decimal PheNcc)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.PheNcc == PheNcc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByPheNccRDT(System.Decimal PheNcc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.PheNcc == PheNcc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPheSx(System.Decimal PheSx)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.PheSx == PheSx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByPheSxRDT(System.Decimal PheSx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.PheSx == PheSx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensanpham(System.String Tensanpham)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByTensanphamRDT(System.String Tensanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmay(System.String Tenmay)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmayRDT(System.String Tenmay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTencongnhan(System.String Tencongnhan)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByTencongnhanRDT(System.String Tencongnhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNangsuat(System.Decimal Nangsuat)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Nangsuat == Nangsuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByNangsuatRDT(System.Decimal Nangsuat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Nangsuat == Nangsuat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTylesaihong(System.Decimal Tylesaihong)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tylesaihong == Tylesaihong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByTylesaihongRDT(System.Decimal Tylesaihong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tylesaihong == Tylesaihong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTongmdm(System.Decimal Tongmdm)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tongmdm == Tongmdm);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByTongmdmRDT(System.Decimal Tongmdm)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tongmdm == Tongmdm);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMatruongca(System.String Matruongca)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Matruongca == Matruongca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByMatruongcaRDT(System.String Matruongca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Matruongca == Matruongca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTentruongca(System.String Tentruongca)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tentruongca == Tentruongca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByTentruongcaRDT(System.String Tentruongca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tentruongca == Tentruongca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTocdodinhmuc(System.Decimal Tocdodinhmuc)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tocdodinhmuc == Tocdodinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByTocdodinhmucRDT(System.Decimal Tocdodinhmuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Tocdodinhmuc == Tocdodinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLydosuco(System.String Lydosuco)
		{
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Lydosuco == Lydosuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainCollection, filter, 0, null);
			}
			return _KetquainCollection;
		}
		// Return DataTable
		public DataTable SelectByLydosucoRDT(System.String Lydosuco)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainFields.Lydosuco == Lydosuco);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(KetquainFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
