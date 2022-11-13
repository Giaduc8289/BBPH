﻿


/*
'===============================================================================
'  GD.BBPH.BL.CongsuatmayManagerBase
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
	public class CongsuatmayManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Macongsuat="Macongsuat";				
		
		public const String Field_Tencongsuat="Tencongsuat";				
		
		public const String Field_Dodaytu="Dodaytu";				
		
		public const String Field_Dodayden="Dodayden";				
		
		public const String Field_Khotu="Khotu";				
		
		public const String Field_Khoden="Khoden";				
		
		public const String Field_Chieudaitu="Chieudaitu";				
		
		public const String Field_Chieudaiden="Chieudaiden";				
		
		public const String Field_Mamays="Mamays";				
		
		public const String Field_Macongdoans="Macongdoans";				
		
		public const String Field_Somaumas="Somaumas";				
		
		public const String Field_Sohinhmas="Sohinhmas";				
		
		public const String Field_Maloaimangs="Maloaimangs";				
		
		public const String Field_Maqcthanhphams="Maqcthanhphams";				
		
		public const String Field_Makhachs="Makhachs";				
		
		public const String Field_Mahangs="Mahangs";				
		
		public const String Field_Tocdo="Tocdo";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CongsuatmayManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Macongsuat,typeof(System.String));
			
			dt.Columns.Add(Field_Tencongsuat,typeof(System.String));
			
			dt.Columns.Add(Field_Dodaytu,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dodayden,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Khotu,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Khoden,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Chieudaitu,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Chieudaiden,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Mamays,typeof(System.String));
			
			dt.Columns.Add(Field_Macongdoans,typeof(System.String));
			
			dt.Columns.Add(Field_Somaumas,typeof(System.String));
			
			dt.Columns.Add(Field_Sohinhmas,typeof(System.String));
			
			dt.Columns.Add(Field_Maloaimangs,typeof(System.String));
			
			dt.Columns.Add(Field_Maqcthanhphams,typeof(System.String));
			
			dt.Columns.Add(Field_Makhachs,typeof(System.String));
			
			dt.Columns.Add(Field_Mahangs,typeof(System.String));
			
			dt.Columns.Add(Field_Tocdo,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(CongsuatmayEntity _CongsuatmayEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Macongsuat]=_CongsuatmayEntity.Macongsuat;
			}
			catch { }
			
			try
			{
				r[Field_Tencongsuat]=_CongsuatmayEntity.Tencongsuat;
			}
			catch { }
			
			try
			{
				r[Field_Dodaytu]=_CongsuatmayEntity.Dodaytu;
			}
			catch { }
			
			try
			{
				r[Field_Dodayden]=_CongsuatmayEntity.Dodayden;
			}
			catch { }
			
			try
			{
				r[Field_Khotu]=_CongsuatmayEntity.Khotu;
			}
			catch { }
			
			try
			{
				r[Field_Khoden]=_CongsuatmayEntity.Khoden;
			}
			catch { }
			
			try
			{
				r[Field_Chieudaitu]=_CongsuatmayEntity.Chieudaitu;
			}
			catch { }
			
			try
			{
				r[Field_Chieudaiden]=_CongsuatmayEntity.Chieudaiden;
			}
			catch { }
			
			try
			{
				r[Field_Mamays]=_CongsuatmayEntity.Mamays;
			}
			catch { }
			
			try
			{
				r[Field_Macongdoans]=_CongsuatmayEntity.Macongdoans;
			}
			catch { }
			
			try
			{
				r[Field_Somaumas]=_CongsuatmayEntity.Somaumas;
			}
			catch { }
			
			try
			{
				r[Field_Sohinhmas]=_CongsuatmayEntity.Sohinhmas;
			}
			catch { }
			
			try
			{
				r[Field_Maloaimangs]=_CongsuatmayEntity.Maloaimangs;
			}
			catch { }
			
			try
			{
				r[Field_Maqcthanhphams]=_CongsuatmayEntity.Maqcthanhphams;
			}
			catch { }
			
			try
			{
				r[Field_Makhachs]=_CongsuatmayEntity.Makhachs;
			}
			catch { }
			
			try
			{
				r[Field_Mahangs]=_CongsuatmayEntity.Mahangs;
			}
			catch { }
			
			try
			{
				r[Field_Tocdo]=_CongsuatmayEntity.Tocdo;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_CongsuatmayEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_CongsuatmayEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_CongsuatmayEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_CongsuatmayEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public CongsuatmayEntity Convert(DataRow r)
		{	
			
			CongsuatmayEntity _CongsuatmayEntity=new CongsuatmayEntity(r[Field_Macongsuat].ToString());					
						
			
			
			try
			{
				_CongsuatmayEntity.Tencongsuat= r[Field_Tencongsuat].ToString();						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Dodaytu= System.Decimal.Parse(r[Field_Dodaytu].ToString());						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Dodayden= System.Decimal.Parse(r[Field_Dodayden].ToString());						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Khotu= System.Decimal.Parse(r[Field_Khotu].ToString());						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Khoden= System.Decimal.Parse(r[Field_Khoden].ToString());						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Chieudaitu= System.Decimal.Parse(r[Field_Chieudaitu].ToString());						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Chieudaiden= System.Decimal.Parse(r[Field_Chieudaiden].ToString());						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Mamays= r[Field_Mamays].ToString();						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Macongdoans= r[Field_Macongdoans].ToString();						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Somaumas= r[Field_Somaumas].ToString();						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Sohinhmas= r[Field_Sohinhmas].ToString();						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Maloaimangs= r[Field_Maloaimangs].ToString();						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Maqcthanhphams= r[Field_Maqcthanhphams].ToString();						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Makhachs= r[Field_Makhachs].ToString();						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Mahangs= r[Field_Mahangs].ToString();						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Tocdo= System.Decimal.Parse(r[Field_Tocdo].ToString());						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _CongsuatmayEntity;
		}			
		
		public CongsuatmayEntity Convert_Entity(CongsuatmayEntity _CongsuatmayEntity,CongsuatmayEntity _CongsuatmayEntity_XML)
		{	
			
			
			_CongsuatmayEntity.Macongsuat= _CongsuatmayEntity_XML.Macongsuat;
			
			_CongsuatmayEntity.Tencongsuat= _CongsuatmayEntity_XML.Tencongsuat;
			
			_CongsuatmayEntity.Dodaytu= _CongsuatmayEntity_XML.Dodaytu;
			
			_CongsuatmayEntity.Dodayden= _CongsuatmayEntity_XML.Dodayden;
			
			_CongsuatmayEntity.Khotu= _CongsuatmayEntity_XML.Khotu;
			
			_CongsuatmayEntity.Khoden= _CongsuatmayEntity_XML.Khoden;
			
			_CongsuatmayEntity.Chieudaitu= _CongsuatmayEntity_XML.Chieudaitu;
			
			_CongsuatmayEntity.Chieudaiden= _CongsuatmayEntity_XML.Chieudaiden;
			
			_CongsuatmayEntity.Mamays= _CongsuatmayEntity_XML.Mamays;
			
			_CongsuatmayEntity.Macongdoans= _CongsuatmayEntity_XML.Macongdoans;
			
			_CongsuatmayEntity.Somaumas= _CongsuatmayEntity_XML.Somaumas;
			
			_CongsuatmayEntity.Sohinhmas= _CongsuatmayEntity_XML.Sohinhmas;
			
			_CongsuatmayEntity.Maloaimangs= _CongsuatmayEntity_XML.Maloaimangs;
			
			_CongsuatmayEntity.Maqcthanhphams= _CongsuatmayEntity_XML.Maqcthanhphams;
			
			_CongsuatmayEntity.Makhachs= _CongsuatmayEntity_XML.Makhachs;
			
			_CongsuatmayEntity.Mahangs= _CongsuatmayEntity_XML.Mahangs;
			
			_CongsuatmayEntity.Tocdo= _CongsuatmayEntity_XML.Tocdo;
			
			_CongsuatmayEntity.Ngaytao= _CongsuatmayEntity_XML.Ngaytao;
			
			_CongsuatmayEntity.Nguoitao= _CongsuatmayEntity_XML.Nguoitao;
			
			_CongsuatmayEntity.Ngaysua= _CongsuatmayEntity_XML.Ngaysua;
			
			_CongsuatmayEntity.Nguoisua= _CongsuatmayEntity_XML.Nguoisua;
									
				
			return _CongsuatmayEntity;
		}	
		
		public String InsertV2(CongsuatmayEntity _CongsuatmayEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new CongsuatmayManagerBase()).Insert(_CongsuatmayEntity).Macongsuat.ToString();
			
			
			try
			{
				r.SetField(Field_Macongsuat,_CongsuatmayEntity.Macongsuat);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tencongsuat,_CongsuatmayEntity.Tencongsuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dodaytu,_CongsuatmayEntity.Dodaytu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dodayden,_CongsuatmayEntity.Dodayden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khotu,_CongsuatmayEntity.Khotu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khoden,_CongsuatmayEntity.Khoden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chieudaitu,_CongsuatmayEntity.Chieudaitu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chieudaiden,_CongsuatmayEntity.Chieudaiden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamays,_CongsuatmayEntity.Mamays);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongdoans,_CongsuatmayEntity.Macongdoans);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somaumas,_CongsuatmayEntity.Somaumas);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sohinhmas,_CongsuatmayEntity.Sohinhmas);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaimangs,_CongsuatmayEntity.Maloaimangs);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqcthanhphams,_CongsuatmayEntity.Maqcthanhphams);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhachs,_CongsuatmayEntity.Makhachs);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mahangs,_CongsuatmayEntity.Mahangs);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tocdo,_CongsuatmayEntity.Tocdo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_CongsuatmayEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_CongsuatmayEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_CongsuatmayEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_CongsuatmayEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(CongsuatmayEntity _CongsuatmayEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new CongsuatmayManagerBase()).Update(_CongsuatmayEntity);
			r.SetField(Field_Macongsuat,_CongsuatmayEntity.Macongsuat);
									
			
			
			
			try
			{
				r.SetField(Field_Tencongsuat,_CongsuatmayEntity.Tencongsuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dodaytu,_CongsuatmayEntity.Dodaytu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dodayden,_CongsuatmayEntity.Dodayden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khotu,_CongsuatmayEntity.Khotu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khoden,_CongsuatmayEntity.Khoden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chieudaitu,_CongsuatmayEntity.Chieudaitu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chieudaiden,_CongsuatmayEntity.Chieudaiden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamays,_CongsuatmayEntity.Mamays);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongdoans,_CongsuatmayEntity.Macongdoans);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somaumas,_CongsuatmayEntity.Somaumas);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sohinhmas,_CongsuatmayEntity.Sohinhmas);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaimangs,_CongsuatmayEntity.Maloaimangs);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqcthanhphams,_CongsuatmayEntity.Maqcthanhphams);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhachs,_CongsuatmayEntity.Makhachs);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mahangs,_CongsuatmayEntity.Mahangs);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tocdo,_CongsuatmayEntity.Tocdo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_CongsuatmayEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_CongsuatmayEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_CongsuatmayEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_CongsuatmayEntity.Nguoisua);
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

		public CongsuatmayEntity Insert(CongsuatmayEntity CongsuatmayEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(CongsuatmayEntity, true);
			}
			return CongsuatmayEntity;
		}

		public CongsuatmayEntity Insert(System.String  Macongsuat, System.String  Tencongsuat, System.Decimal  Dodaytu, System.Decimal  Dodayden, System.Decimal  Khotu, System.Decimal  Khoden, System.Decimal  Chieudaitu, System.Decimal  Chieudaiden, System.String  Mamays, System.String  Macongdoans, System.String  Somaumas, System.String  Sohinhmas, System.String  Maloaimangs, System.String  Maqcthanhphams, System.String  Makhachs, System.String  Mahangs, System.Decimal  Tocdo, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			CongsuatmayEntity _CongsuatmayEntity = new CongsuatmayEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CongsuatmayEntity.Macongsuat = Macongsuat;
				
				_CongsuatmayEntity.Tencongsuat = Tencongsuat;
				
				_CongsuatmayEntity.Dodaytu = Dodaytu;
				
				_CongsuatmayEntity.Dodayden = Dodayden;
				
				_CongsuatmayEntity.Khotu = Khotu;
				
				_CongsuatmayEntity.Khoden = Khoden;
				
				_CongsuatmayEntity.Chieudaitu = Chieudaitu;
				
				_CongsuatmayEntity.Chieudaiden = Chieudaiden;
				
				_CongsuatmayEntity.Mamays = Mamays;
				
				_CongsuatmayEntity.Macongdoans = Macongdoans;
				
				_CongsuatmayEntity.Somaumas = Somaumas;
				
				_CongsuatmayEntity.Sohinhmas = Sohinhmas;
				
				_CongsuatmayEntity.Maloaimangs = Maloaimangs;
				
				_CongsuatmayEntity.Maqcthanhphams = Maqcthanhphams;
				
				_CongsuatmayEntity.Makhachs = Makhachs;
				
				_CongsuatmayEntity.Mahangs = Mahangs;
				
				_CongsuatmayEntity.Tocdo = Tocdo;
				
				_CongsuatmayEntity.Ngaytao = Ngaytao;
				
				_CongsuatmayEntity.Nguoitao = Nguoitao;
				
				_CongsuatmayEntity.Ngaysua = Ngaysua;
				
				_CongsuatmayEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_CongsuatmayEntity, true);
			}
			return _CongsuatmayEntity;
		}

		public CongsuatmayEntity Insert(System.String Tencongsuat, System.Decimal Dodaytu, System.Decimal Dodayden, System.Decimal Khotu, System.Decimal Khoden, System.Decimal Chieudaitu, System.Decimal Chieudaiden, System.String Mamays, System.String Macongdoans, System.String Somaumas, System.String Sohinhmas, System.String Maloaimangs, System.String Maqcthanhphams, System.String Makhachs, System.String Mahangs, System.Decimal Tocdo, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			CongsuatmayEntity _CongsuatmayEntity = new CongsuatmayEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_CongsuatmayEntity.Tencongsuat = Tencongsuat;
				
				_CongsuatmayEntity.Dodaytu = Dodaytu;
				
				_CongsuatmayEntity.Dodayden = Dodayden;
				
				_CongsuatmayEntity.Khotu = Khotu;
				
				_CongsuatmayEntity.Khoden = Khoden;
				
				_CongsuatmayEntity.Chieudaitu = Chieudaitu;
				
				_CongsuatmayEntity.Chieudaiden = Chieudaiden;
				
				_CongsuatmayEntity.Mamays = Mamays;
				
				_CongsuatmayEntity.Macongdoans = Macongdoans;
				
				_CongsuatmayEntity.Somaumas = Somaumas;
				
				_CongsuatmayEntity.Sohinhmas = Sohinhmas;
				
				_CongsuatmayEntity.Maloaimangs = Maloaimangs;
				
				_CongsuatmayEntity.Maqcthanhphams = Maqcthanhphams;
				
				_CongsuatmayEntity.Makhachs = Makhachs;
				
				_CongsuatmayEntity.Mahangs = Mahangs;
				
				_CongsuatmayEntity.Tocdo = Tocdo;
				
				_CongsuatmayEntity.Ngaytao = Ngaytao;
				
				_CongsuatmayEntity.Nguoitao = Nguoitao;
				
				_CongsuatmayEntity.Ngaysua = Ngaysua;
				
				_CongsuatmayEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_CongsuatmayEntity, true);
			}
			return _CongsuatmayEntity;
		}

		public bool Update(CongsuatmayEntity _CongsuatmayEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(CongsuatmayFields.Macongsuat == _CongsuatmayEntity.Macongsuat);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_CongsuatmayEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(CongsuatmayEntity _CongsuatmayEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_CongsuatmayEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Macongsuat, System.String Tencongsuat, System.Decimal Dodaytu, System.Decimal Dodayden, System.Decimal Khotu, System.Decimal Khoden, System.Decimal Chieudaitu, System.Decimal Chieudaiden, System.String Mamays, System.String Macongdoans, System.String Somaumas, System.String Sohinhmas, System.String Maloaimangs, System.String Maqcthanhphams, System.String Makhachs, System.String Mahangs, System.Decimal Tocdo, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CongsuatmayEntity _CongsuatmayEntity = new CongsuatmayEntity(Macongsuat);
				if (adapter.FetchEntity(_CongsuatmayEntity))
				{
				
					
					
					_CongsuatmayEntity.Tencongsuat = Tencongsuat;
					
					_CongsuatmayEntity.Dodaytu = Dodaytu;
					
					_CongsuatmayEntity.Dodayden = Dodayden;
					
					_CongsuatmayEntity.Khotu = Khotu;
					
					_CongsuatmayEntity.Khoden = Khoden;
					
					_CongsuatmayEntity.Chieudaitu = Chieudaitu;
					
					_CongsuatmayEntity.Chieudaiden = Chieudaiden;
					
					_CongsuatmayEntity.Mamays = Mamays;
					
					_CongsuatmayEntity.Macongdoans = Macongdoans;
					
					_CongsuatmayEntity.Somaumas = Somaumas;
					
					_CongsuatmayEntity.Sohinhmas = Sohinhmas;
					
					_CongsuatmayEntity.Maloaimangs = Maloaimangs;
					
					_CongsuatmayEntity.Maqcthanhphams = Maqcthanhphams;
					
					_CongsuatmayEntity.Makhachs = Makhachs;
					
					_CongsuatmayEntity.Mahangs = Mahangs;
					
					_CongsuatmayEntity.Tocdo = Tocdo;
					
					_CongsuatmayEntity.Ngaytao = Ngaytao;
					
					_CongsuatmayEntity.Nguoitao = Nguoitao;
					
					_CongsuatmayEntity.Ngaysua = Ngaysua;
					
					_CongsuatmayEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_CongsuatmayEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Macongsuat)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CongsuatmayEntity _CongsuatmayEntity = new CongsuatmayEntity(Macongsuat);
				if (adapter.FetchEntity(_CongsuatmayEntity))
				{
					adapter.DeleteEntity(_CongsuatmayEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("CongsuatmayEntity", null);
			}
		}
		
		
		
		public int DeleteByMacongsuat(System.String Macongsuat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Macongsuat == Macongsuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTencongsuat(System.String Tencongsuat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Tencongsuat == Tencongsuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDodaytu(System.Decimal Dodaytu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Dodaytu == Dodaytu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDodayden(System.Decimal Dodayden)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Dodayden == Dodayden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKhotu(System.Decimal Khotu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Khotu == Khotu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKhoden(System.Decimal Khoden)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Khoden == Khoden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByChieudaitu(System.Decimal Chieudaitu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Chieudaitu == Chieudaitu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByChieudaiden(System.Decimal Chieudaiden)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Chieudaiden == Chieudaiden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamays(System.String Mamays)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Mamays == Mamays);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMacongdoans(System.String Macongdoans)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Macongdoans == Macongdoans);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomaumas(System.String Somaumas)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Somaumas == Somaumas);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySohinhmas(System.String Sohinhmas)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Sohinhmas == Sohinhmas);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaloaimangs(System.String Maloaimangs)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Maloaimangs == Maloaimangs);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaqcthanhphams(System.String Maqcthanhphams)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Maqcthanhphams == Maqcthanhphams);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhachs(System.String Makhachs)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Makhachs == Makhachs);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMahangs(System.String Mahangs)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Mahangs == Mahangs);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTocdo(System.Decimal Tocdo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Tocdo == Tocdo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
			
		
		public CongsuatmayEntity SelectOne(System.String Macongsuat)
		{
			CongsuatmayEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CongsuatmayEntity _CongsuatmayEntity = new CongsuatmayEntity(Macongsuat);
				if (adapter.FetchEntity(_CongsuatmayEntity))
				{
					toReturn = _CongsuatmayEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection( new CongsuatmayEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, null, 0, null);
			}
			return _CongsuatmayCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMacongsuat(System.String Macongsuat)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Macongsuat == Macongsuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByMacongsuatRDT(System.String Macongsuat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Macongsuat == Macongsuat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTencongsuat(System.String Tencongsuat)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Tencongsuat == Tencongsuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByTencongsuatRDT(System.String Tencongsuat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Tencongsuat == Tencongsuat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDodaytu(System.Decimal Dodaytu)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Dodaytu == Dodaytu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByDodaytuRDT(System.Decimal Dodaytu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Dodaytu == Dodaytu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDodayden(System.Decimal Dodayden)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Dodayden == Dodayden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByDodaydenRDT(System.Decimal Dodayden)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Dodayden == Dodayden);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKhotu(System.Decimal Khotu)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Khotu == Khotu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByKhotuRDT(System.Decimal Khotu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Khotu == Khotu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKhoden(System.Decimal Khoden)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Khoden == Khoden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByKhodenRDT(System.Decimal Khoden)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Khoden == Khoden);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByChieudaitu(System.Decimal Chieudaitu)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Chieudaitu == Chieudaitu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByChieudaituRDT(System.Decimal Chieudaitu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Chieudaitu == Chieudaitu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByChieudaiden(System.Decimal Chieudaiden)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Chieudaiden == Chieudaiden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByChieudaidenRDT(System.Decimal Chieudaiden)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Chieudaiden == Chieudaiden);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamays(System.String Mamays)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Mamays == Mamays);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByMamaysRDT(System.String Mamays)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Mamays == Mamays);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMacongdoans(System.String Macongdoans)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Macongdoans == Macongdoans);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByMacongdoansRDT(System.String Macongdoans)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Macongdoans == Macongdoans);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomaumas(System.String Somaumas)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Somaumas == Somaumas);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectBySomaumasRDT(System.String Somaumas)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Somaumas == Somaumas);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySohinhmas(System.String Sohinhmas)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Sohinhmas == Sohinhmas);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectBySohinhmasRDT(System.String Sohinhmas)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Sohinhmas == Sohinhmas);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaloaimangs(System.String Maloaimangs)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Maloaimangs == Maloaimangs);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByMaloaimangsRDT(System.String Maloaimangs)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Maloaimangs == Maloaimangs);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaqcthanhphams(System.String Maqcthanhphams)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Maqcthanhphams == Maqcthanhphams);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByMaqcthanhphamsRDT(System.String Maqcthanhphams)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Maqcthanhphams == Maqcthanhphams);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhachs(System.String Makhachs)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Makhachs == Makhachs);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachsRDT(System.String Makhachs)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Makhachs == Makhachs);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMahangs(System.String Mahangs)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Mahangs == Mahangs);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByMahangsRDT(System.String Mahangs)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Mahangs == Mahangs);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTocdo(System.Decimal Tocdo)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Tocdo == Tocdo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByTocdoRDT(System.Decimal Tocdo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Tocdo == Tocdo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(CongsuatmayFields.Macongsuat.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
