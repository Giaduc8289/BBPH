


/*
'===============================================================================
'  GD.BBPH.BL.KetquathoiManagerBase
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
	public class KetquathoiManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngay="Ngay";				
		
		public const String Field_Ca="Ca";				
		
		public const String Field_Mamay="Mamay";				
		
		public const String Field_Lenhthoi="Lenhthoi";				
		
		public const String Field_Mamang="Mamang";				
		
		public const String Field_Macongnhan="Macongnhan";				
		
		public const String Field_Somet="Somet";				
		
		public const String Field_Sokg="Sokg";				
		
		public const String Field_Sokgquydoi="Sokgquydoi";				
		
		public const String Field_Chenhlechkg="Chenhlechkg";				
		
		public const String Field_Chatluong="Chatluong";				
		
		public const String Field_Phelieuthucte="Phelieuthucte";				
		
		public const String Field_Tongsp="Tongsp";				
		
		public const String Field_Thoigianbatdau="Thoigianbatdau";				
		
		public const String Field_Thoigianketthuc="Thoigianketthuc";				
		
		public const String Field_Thoigianchuanbi="Thoigianchuanbi";				
		
		public const String Field_Thoigiansuco="Thoigiansuco";				
		
		public const String Field_Sokgdukiendat="Sokgdukiendat";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
		public const String Field_Tenmang="Tenmang";				
		
		public const String Field_Tenmay="Tenmay";				
		
		public const String Field_Tencongnhan="Tencongnhan";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquathoiManagerBase()
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
			
			dt.Columns.Add(Field_Lenhthoi,typeof(System.String));
			
			dt.Columns.Add(Field_Mamang,typeof(System.String));
			
			dt.Columns.Add(Field_Macongnhan,typeof(System.String));
			
			dt.Columns.Add(Field_Somet,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sokg,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sokgquydoi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Chenhlechkg,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Chatluong,typeof(System.String));
			
			dt.Columns.Add(Field_Phelieuthucte,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Tongsp,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigianbatdau,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigianketthuc,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigianchuanbi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigiansuco,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sokgdukiendat,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmang,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmay,typeof(System.String));
			
			dt.Columns.Add(Field_Tencongnhan,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(KetquathoiEntity _KetquathoiEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_KetquathoiEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngay]=_KetquathoiEntity.Ngay;
			}
			catch { }
			
			try
			{
				r[Field_Ca]=_KetquathoiEntity.Ca;
			}
			catch { }
			
			try
			{
				r[Field_Mamay]=_KetquathoiEntity.Mamay;
			}
			catch { }
			
			try
			{
				r[Field_Lenhthoi]=_KetquathoiEntity.Lenhthoi;
			}
			catch { }
			
			try
			{
				r[Field_Mamang]=_KetquathoiEntity.Mamang;
			}
			catch { }
			
			try
			{
				r[Field_Macongnhan]=_KetquathoiEntity.Macongnhan;
			}
			catch { }
			
			try
			{
				r[Field_Somet]=_KetquathoiEntity.Somet;
			}
			catch { }
			
			try
			{
				r[Field_Sokg]=_KetquathoiEntity.Sokg;
			}
			catch { }
			
			try
			{
				r[Field_Sokgquydoi]=_KetquathoiEntity.Sokgquydoi;
			}
			catch { }
			
			try
			{
				r[Field_Chenhlechkg]=_KetquathoiEntity.Chenhlechkg;
			}
			catch { }
			
			try
			{
				r[Field_Chatluong]=_KetquathoiEntity.Chatluong;
			}
			catch { }
			
			try
			{
				r[Field_Phelieuthucte]=_KetquathoiEntity.Phelieuthucte;
			}
			catch { }
			
			try
			{
				r[Field_Tongsp]=_KetquathoiEntity.Tongsp;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianbatdau]=_KetquathoiEntity.Thoigianbatdau;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianketthuc]=_KetquathoiEntity.Thoigianketthuc;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianchuanbi]=_KetquathoiEntity.Thoigianchuanbi;
			}
			catch { }
			
			try
			{
				r[Field_Thoigiansuco]=_KetquathoiEntity.Thoigiansuco;
			}
			catch { }
			
			try
			{
				r[Field_Sokgdukiendat]=_KetquathoiEntity.Sokgdukiendat;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_KetquathoiEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_KetquathoiEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_KetquathoiEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_KetquathoiEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Tenmang]=_KetquathoiEntity.Tenmang;
			}
			catch { }
			
			try
			{
				r[Field_Tenmay]=_KetquathoiEntity.Tenmay;
			}
			catch { }
			
			try
			{
				r[Field_Tencongnhan]=_KetquathoiEntity.Tencongnhan;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public KetquathoiEntity Convert(DataRow r)
		{	
			
			KetquathoiEntity _KetquathoiEntity=new KetquathoiEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_KetquathoiEntity.Ngay= System.DateTime.Parse(r[Field_Ngay].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Ca= System.Int32.Parse(r[Field_Ca].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Mamay= r[Field_Mamay].ToString();						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Lenhthoi= r[Field_Lenhthoi].ToString();						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Mamang= r[Field_Mamang].ToString();						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Macongnhan= r[Field_Macongnhan].ToString();						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Somet= System.Decimal.Parse(r[Field_Somet].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Sokg= System.Decimal.Parse(r[Field_Sokg].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Sokgquydoi= System.Decimal.Parse(r[Field_Sokgquydoi].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Chenhlechkg= System.Decimal.Parse(r[Field_Chenhlechkg].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Chatluong= r[Field_Chatluong].ToString();						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Phelieuthucte= System.Decimal.Parse(r[Field_Phelieuthucte].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Tongsp= System.Decimal.Parse(r[Field_Tongsp].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Thoigianbatdau= System.DateTime.Parse(r[Field_Thoigianbatdau].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Thoigianketthuc= System.DateTime.Parse(r[Field_Thoigianketthuc].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Thoigianchuanbi= System.Decimal.Parse(r[Field_Thoigianchuanbi].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Thoigiansuco= System.Decimal.Parse(r[Field_Thoigiansuco].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Sokgdukiendat= System.Decimal.Parse(r[Field_Sokgdukiendat].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Tenmang= r[Field_Tenmang].ToString();						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Tenmay= r[Field_Tenmay].ToString();						
			}
			catch { }
			
			try
			{
				_KetquathoiEntity.Tencongnhan= r[Field_Tencongnhan].ToString();						
			}
			catch { }
									
									
			return _KetquathoiEntity;
		}			
		
		public KetquathoiEntity Convert_Entity(KetquathoiEntity _KetquathoiEntity,KetquathoiEntity _KetquathoiEntity_XML)
		{	
			
			
			_KetquathoiEntity.Id= _KetquathoiEntity_XML.Id;
			
			_KetquathoiEntity.Ngay= _KetquathoiEntity_XML.Ngay;
			
			_KetquathoiEntity.Ca= _KetquathoiEntity_XML.Ca;
			
			_KetquathoiEntity.Mamay= _KetquathoiEntity_XML.Mamay;
			
			_KetquathoiEntity.Lenhthoi= _KetquathoiEntity_XML.Lenhthoi;
			
			_KetquathoiEntity.Mamang= _KetquathoiEntity_XML.Mamang;
			
			_KetquathoiEntity.Macongnhan= _KetquathoiEntity_XML.Macongnhan;
			
			_KetquathoiEntity.Somet= _KetquathoiEntity_XML.Somet;
			
			_KetquathoiEntity.Sokg= _KetquathoiEntity_XML.Sokg;
			
			_KetquathoiEntity.Sokgquydoi= _KetquathoiEntity_XML.Sokgquydoi;
			
			_KetquathoiEntity.Chenhlechkg= _KetquathoiEntity_XML.Chenhlechkg;
			
			_KetquathoiEntity.Chatluong= _KetquathoiEntity_XML.Chatluong;
			
			_KetquathoiEntity.Phelieuthucte= _KetquathoiEntity_XML.Phelieuthucte;
			
			_KetquathoiEntity.Tongsp= _KetquathoiEntity_XML.Tongsp;
			
			_KetquathoiEntity.Thoigianbatdau= _KetquathoiEntity_XML.Thoigianbatdau;
			
			_KetquathoiEntity.Thoigianketthuc= _KetquathoiEntity_XML.Thoigianketthuc;
			
			_KetquathoiEntity.Thoigianchuanbi= _KetquathoiEntity_XML.Thoigianchuanbi;
			
			_KetquathoiEntity.Thoigiansuco= _KetquathoiEntity_XML.Thoigiansuco;
			
			_KetquathoiEntity.Sokgdukiendat= _KetquathoiEntity_XML.Sokgdukiendat;
			
			_KetquathoiEntity.Ngaytao= _KetquathoiEntity_XML.Ngaytao;
			
			_KetquathoiEntity.Nguoitao= _KetquathoiEntity_XML.Nguoitao;
			
			_KetquathoiEntity.Ngaysua= _KetquathoiEntity_XML.Ngaysua;
			
			_KetquathoiEntity.Nguoisua= _KetquathoiEntity_XML.Nguoisua;
			
			_KetquathoiEntity.Tenmang= _KetquathoiEntity_XML.Tenmang;
			
			_KetquathoiEntity.Tenmay= _KetquathoiEntity_XML.Tenmay;
			
			_KetquathoiEntity.Tencongnhan= _KetquathoiEntity_XML.Tencongnhan;
									
				
			return _KetquathoiEntity;
		}	
		
		public String InsertV2(KetquathoiEntity _KetquathoiEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new KetquathoiManagerBase()).Insert(_KetquathoiEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_KetquathoiEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngay,_KetquathoiEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KetquathoiEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KetquathoiEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhthoi,_KetquathoiEntity.Lenhthoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamang,_KetquathoiEntity.Mamang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongnhan,_KetquathoiEntity.Macongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_KetquathoiEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_KetquathoiEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgquydoi,_KetquathoiEntity.Sokgquydoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chenhlechkg,_KetquathoiEntity.Chenhlechkg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chatluong,_KetquathoiEntity.Chatluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phelieuthucte,_KetquathoiEntity.Phelieuthucte);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tongsp,_KetquathoiEntity.Tongsp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianbatdau,_KetquathoiEntity.Thoigianbatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianketthuc,_KetquathoiEntity.Thoigianketthuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianchuanbi,_KetquathoiEntity.Thoigianchuanbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiansuco,_KetquathoiEntity.Thoigiansuco);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgdukiendat,_KetquathoiEntity.Sokgdukiendat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KetquathoiEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KetquathoiEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KetquathoiEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KetquathoiEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmang,_KetquathoiEntity.Tenmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmay,_KetquathoiEntity.Tenmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongnhan,_KetquathoiEntity.Tencongnhan);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(KetquathoiEntity _KetquathoiEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new KetquathoiManagerBase()).Update(_KetquathoiEntity);
			r.SetField(Field_Id,_KetquathoiEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngay,_KetquathoiEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KetquathoiEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KetquathoiEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhthoi,_KetquathoiEntity.Lenhthoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamang,_KetquathoiEntity.Mamang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongnhan,_KetquathoiEntity.Macongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_KetquathoiEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_KetquathoiEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgquydoi,_KetquathoiEntity.Sokgquydoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chenhlechkg,_KetquathoiEntity.Chenhlechkg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chatluong,_KetquathoiEntity.Chatluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phelieuthucte,_KetquathoiEntity.Phelieuthucte);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tongsp,_KetquathoiEntity.Tongsp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianbatdau,_KetquathoiEntity.Thoigianbatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianketthuc,_KetquathoiEntity.Thoigianketthuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianchuanbi,_KetquathoiEntity.Thoigianchuanbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiansuco,_KetquathoiEntity.Thoigiansuco);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgdukiendat,_KetquathoiEntity.Sokgdukiendat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KetquathoiEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KetquathoiEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KetquathoiEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KetquathoiEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmang,_KetquathoiEntity.Tenmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmay,_KetquathoiEntity.Tenmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongnhan,_KetquathoiEntity.Tencongnhan);
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

		public KetquathoiEntity Insert(KetquathoiEntity KetquathoiEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(KetquathoiEntity, true);
			}
			return KetquathoiEntity;
		}

		public KetquathoiEntity Insert(System.Int64  Id, System.DateTime  Ngay, System.Int32  Ca, System.String  Mamay, System.String  Lenhthoi, System.String  Mamang, System.String  Macongnhan, System.Decimal  Somet, System.Decimal  Sokg, System.Decimal  Sokgquydoi, System.Decimal  Chenhlechkg, System.String  Chatluong, System.Decimal  Phelieuthucte, System.Decimal  Tongsp, System.DateTime  Thoigianbatdau, System.DateTime  Thoigianketthuc, System.Decimal  Thoigianchuanbi, System.Decimal  Thoigiansuco, System.Decimal  Sokgdukiendat, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.String  Tenmang, System.String  Tenmay, System.String  Tencongnhan)
		{
			KetquathoiEntity _KetquathoiEntity = new KetquathoiEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KetquathoiEntity.Id = Id;
				
				_KetquathoiEntity.Ngay = Ngay;
				
				_KetquathoiEntity.Ca = Ca;
				
				_KetquathoiEntity.Mamay = Mamay;
				
				_KetquathoiEntity.Lenhthoi = Lenhthoi;
				
				_KetquathoiEntity.Mamang = Mamang;
				
				_KetquathoiEntity.Macongnhan = Macongnhan;
				
				_KetquathoiEntity.Somet = Somet;
				
				_KetquathoiEntity.Sokg = Sokg;
				
				_KetquathoiEntity.Sokgquydoi = Sokgquydoi;
				
				_KetquathoiEntity.Chenhlechkg = Chenhlechkg;
				
				_KetquathoiEntity.Chatluong = Chatluong;
				
				_KetquathoiEntity.Phelieuthucte = Phelieuthucte;
				
				_KetquathoiEntity.Tongsp = Tongsp;
				
				_KetquathoiEntity.Thoigianbatdau = Thoigianbatdau;
				
				_KetquathoiEntity.Thoigianketthuc = Thoigianketthuc;
				
				_KetquathoiEntity.Thoigianchuanbi = Thoigianchuanbi;
				
				_KetquathoiEntity.Thoigiansuco = Thoigiansuco;
				
				_KetquathoiEntity.Sokgdukiendat = Sokgdukiendat;
				
				_KetquathoiEntity.Ngaytao = Ngaytao;
				
				_KetquathoiEntity.Nguoitao = Nguoitao;
				
				_KetquathoiEntity.Ngaysua = Ngaysua;
				
				_KetquathoiEntity.Nguoisua = Nguoisua;
				
				_KetquathoiEntity.Tenmang = Tenmang;
				
				_KetquathoiEntity.Tenmay = Tenmay;
				
				_KetquathoiEntity.Tencongnhan = Tencongnhan;
					
					
				adapter.SaveEntity(_KetquathoiEntity, true);
			}
			return _KetquathoiEntity;
		}

		public KetquathoiEntity Insert(System.DateTime Ngay, System.Int32 Ca, System.String Mamay, System.String Lenhthoi, System.String Mamang, System.String Macongnhan, System.Decimal Somet, System.Decimal Sokg, System.Decimal Sokgquydoi, System.Decimal Chenhlechkg, System.String Chatluong, System.Decimal Phelieuthucte, System.Decimal Tongsp, System.DateTime Thoigianbatdau, System.DateTime Thoigianketthuc, System.Decimal Thoigianchuanbi, System.Decimal Thoigiansuco, System.Decimal Sokgdukiendat, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.String Tenmang, System.String Tenmay, System.String Tencongnhan)//ko co mahieu
		{
			KetquathoiEntity _KetquathoiEntity = new KetquathoiEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_KetquathoiEntity.Ngay = Ngay;
				
				_KetquathoiEntity.Ca = Ca;
				
				_KetquathoiEntity.Mamay = Mamay;
				
				_KetquathoiEntity.Lenhthoi = Lenhthoi;
				
				_KetquathoiEntity.Mamang = Mamang;
				
				_KetquathoiEntity.Macongnhan = Macongnhan;
				
				_KetquathoiEntity.Somet = Somet;
				
				_KetquathoiEntity.Sokg = Sokg;
				
				_KetquathoiEntity.Sokgquydoi = Sokgquydoi;
				
				_KetquathoiEntity.Chenhlechkg = Chenhlechkg;
				
				_KetquathoiEntity.Chatluong = Chatluong;
				
				_KetquathoiEntity.Phelieuthucte = Phelieuthucte;
				
				_KetquathoiEntity.Tongsp = Tongsp;
				
				_KetquathoiEntity.Thoigianbatdau = Thoigianbatdau;
				
				_KetquathoiEntity.Thoigianketthuc = Thoigianketthuc;
				
				_KetquathoiEntity.Thoigianchuanbi = Thoigianchuanbi;
				
				_KetquathoiEntity.Thoigiansuco = Thoigiansuco;
				
				_KetquathoiEntity.Sokgdukiendat = Sokgdukiendat;
				
				_KetquathoiEntity.Ngaytao = Ngaytao;
				
				_KetquathoiEntity.Nguoitao = Nguoitao;
				
				_KetquathoiEntity.Ngaysua = Ngaysua;
				
				_KetquathoiEntity.Nguoisua = Nguoisua;
				
				_KetquathoiEntity.Tenmang = Tenmang;
				
				_KetquathoiEntity.Tenmay = Tenmay;
				
				_KetquathoiEntity.Tencongnhan = Tencongnhan;
					

				adapter.SaveEntity(_KetquathoiEntity, true);
			}
			return _KetquathoiEntity;
		}

		public bool Update(KetquathoiEntity _KetquathoiEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(KetquathoiFields.Id == _KetquathoiEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_KetquathoiEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(KetquathoiEntity _KetquathoiEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_KetquathoiEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngay, System.Int32 Ca, System.String Mamay, System.String Lenhthoi, System.String Mamang, System.String Macongnhan, System.Decimal Somet, System.Decimal Sokg, System.Decimal Sokgquydoi, System.Decimal Chenhlechkg, System.String Chatluong, System.Decimal Phelieuthucte, System.Decimal Tongsp, System.DateTime Thoigianbatdau, System.DateTime Thoigianketthuc, System.Decimal Thoigianchuanbi, System.Decimal Thoigiansuco, System.Decimal Sokgdukiendat, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.String Tenmang, System.String Tenmay, System.String Tencongnhan)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquathoiEntity _KetquathoiEntity = new KetquathoiEntity(Id);
				if (adapter.FetchEntity(_KetquathoiEntity))
				{
				
					
					
					_KetquathoiEntity.Ngay = Ngay;
					
					_KetquathoiEntity.Ca = Ca;
					
					_KetquathoiEntity.Mamay = Mamay;
					
					_KetquathoiEntity.Lenhthoi = Lenhthoi;
					
					_KetquathoiEntity.Mamang = Mamang;
					
					_KetquathoiEntity.Macongnhan = Macongnhan;
					
					_KetquathoiEntity.Somet = Somet;
					
					_KetquathoiEntity.Sokg = Sokg;
					
					_KetquathoiEntity.Sokgquydoi = Sokgquydoi;
					
					_KetquathoiEntity.Chenhlechkg = Chenhlechkg;
					
					_KetquathoiEntity.Chatluong = Chatluong;
					
					_KetquathoiEntity.Phelieuthucte = Phelieuthucte;
					
					_KetquathoiEntity.Tongsp = Tongsp;
					
					_KetquathoiEntity.Thoigianbatdau = Thoigianbatdau;
					
					_KetquathoiEntity.Thoigianketthuc = Thoigianketthuc;
					
					_KetquathoiEntity.Thoigianchuanbi = Thoigianchuanbi;
					
					_KetquathoiEntity.Thoigiansuco = Thoigiansuco;
					
					_KetquathoiEntity.Sokgdukiendat = Sokgdukiendat;
					
					_KetquathoiEntity.Ngaytao = Ngaytao;
					
					_KetquathoiEntity.Nguoitao = Nguoitao;
					
					_KetquathoiEntity.Ngaysua = Ngaysua;
					
					_KetquathoiEntity.Nguoisua = Nguoisua;
					
					_KetquathoiEntity.Tenmang = Tenmang;
					
					_KetquathoiEntity.Tenmay = Tenmay;
					
					_KetquathoiEntity.Tencongnhan = Tencongnhan;
						

					adapter.SaveEntity(_KetquathoiEntity, true);
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
				KetquathoiEntity _KetquathoiEntity = new KetquathoiEntity(Id);
				if (adapter.FetchEntity(_KetquathoiEntity))
				{
					adapter.DeleteEntity(_KetquathoiEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("KetquathoiEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgay(System.DateTime Ngay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCa(System.Int32 Ca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamay(System.String Mamay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLenhthoi(System.String Lenhthoi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Lenhthoi == Lenhthoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamang(System.String Mamang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMacongnhan(System.String Macongnhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomet(System.Decimal Somet)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokg(System.Decimal Sokg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokgquydoi(System.Decimal Sokgquydoi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Sokgquydoi == Sokgquydoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByChenhlechkg(System.Decimal Chenhlechkg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Chenhlechkg == Chenhlechkg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByChatluong(System.String Chatluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Chatluong == Chatluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhelieuthucte(System.Decimal Phelieuthucte)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Phelieuthucte == Phelieuthucte);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTongsp(System.Decimal Tongsp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Tongsp == Tongsp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianbatdau(System.DateTime Thoigianbatdau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianketthuc(System.DateTime Thoigianketthuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianchuanbi(System.Decimal Thoigianchuanbi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Thoigianchuanbi == Thoigianchuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigiansuco(System.Decimal Thoigiansuco)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokgdukiendat(System.Decimal Sokgdukiendat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Sokgdukiendat == Sokgdukiendat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmang(System.String Tenmang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmay(System.String Tenmay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTencongnhan(System.String Tencongnhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathoiEntity", filter);
			}
			return toReturn;
		}		
			
		
		public KetquathoiEntity SelectOne(System.Int64 Id)
		{
			KetquathoiEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquathoiEntity _KetquathoiEntity = new KetquathoiEntity(Id);
				if (adapter.FetchEntity(_KetquathoiEntity))
				{
					toReturn = _KetquathoiEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _KetquathoiCollection = new EntityCollection( new KetquathoiEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, null, 0, null);
			}
			return _KetquathoiCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgay(System.DateTime Ngay)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayRDT(System.DateTime Ngay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCa(System.Int32 Ca)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByCaRDT(System.Int32 Ca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamay(System.String Mamay)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByMamayRDT(System.String Mamay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLenhthoi(System.String Lenhthoi)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Lenhthoi == Lenhthoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByLenhthoiRDT(System.String Lenhthoi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Lenhthoi == Lenhthoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamang(System.String Mamang)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByMamangRDT(System.String Mamang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMacongnhan(System.String Macongnhan)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByMacongnhanRDT(System.String Macongnhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomet(System.Decimal Somet)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectBySometRDT(System.Decimal Somet)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokg(System.Decimal Sokg)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgRDT(System.Decimal Sokg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokgquydoi(System.Decimal Sokgquydoi)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Sokgquydoi == Sokgquydoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgquydoiRDT(System.Decimal Sokgquydoi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Sokgquydoi == Sokgquydoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByChenhlechkg(System.Decimal Chenhlechkg)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Chenhlechkg == Chenhlechkg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByChenhlechkgRDT(System.Decimal Chenhlechkg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Chenhlechkg == Chenhlechkg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByChatluong(System.String Chatluong)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Chatluong == Chatluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByChatluongRDT(System.String Chatluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Chatluong == Chatluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhelieuthucte(System.Decimal Phelieuthucte)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Phelieuthucte == Phelieuthucte);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByPhelieuthucteRDT(System.Decimal Phelieuthucte)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Phelieuthucte == Phelieuthucte);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTongsp(System.Decimal Tongsp)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Tongsp == Tongsp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByTongspRDT(System.Decimal Tongsp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Tongsp == Tongsp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianbatdau(System.DateTime Thoigianbatdau)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianbatdauRDT(System.DateTime Thoigianbatdau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianketthuc(System.DateTime Thoigianketthuc)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianketthucRDT(System.DateTime Thoigianketthuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianchuanbi(System.Decimal Thoigianchuanbi)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Thoigianchuanbi == Thoigianchuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianchuanbiRDT(System.Decimal Thoigianchuanbi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Thoigianchuanbi == Thoigianchuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigiansuco(System.Decimal Thoigiansuco)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigiansucoRDT(System.Decimal Thoigiansuco)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokgdukiendat(System.Decimal Sokgdukiendat)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Sokgdukiendat == Sokgdukiendat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgdukiendatRDT(System.Decimal Sokgdukiendat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Sokgdukiendat == Sokgdukiendat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmang(System.String Tenmang)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmangRDT(System.String Tenmang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmay(System.String Tenmay)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmayRDT(System.String Tenmay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTencongnhan(System.String Tencongnhan)
		{
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathoiCollection, filter, 0, null);
			}
			return _KetquathoiCollection;
		}
		// Return DataTable
		public DataTable SelectByTencongnhanRDT(System.String Tencongnhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathoiFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
