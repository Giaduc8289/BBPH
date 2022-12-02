


/*
'===============================================================================
'  GD.BBPH.BL.MangtheolenhManagerBase
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
	public class MangtheolenhManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Solenhsx="Solenhsx";				
		
		public const String Field_Ngayphatlenh="Ngayphatlenh";				
		
		public const String Field_Mamangquydinh="Mamangquydinh";				
		
		public const String Field_Tenmangquydinh="Tenmangquydinh";				
		
		public const String Field_Sometquydinh="Sometquydinh";				
		
		public const String Field_Sokgquydinh="Sokgquydinh";				
		
		public const String Field_Sometthoi="Sometthoi";				
		
		public const String Field_Sokgthoi="Sokgthoi";				
		
		public const String Field_Mamangsudung="Mamangsudung";				
		
		public const String Field_Tenmangsudung="Tenmangsudung";				
		
		public const String Field_Sometsudung="Sometsudung";				
		
		public const String Field_Sokgsudung="Sokgsudung";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MangtheolenhManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Solenhsx,typeof(System.String));
			
			dt.Columns.Add(Field_Ngayphatlenh,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Mamangquydinh,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmangquydinh,typeof(System.String));
			
			dt.Columns.Add(Field_Sometquydinh,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sokgquydinh,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sometthoi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sokgthoi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Mamangsudung,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmangsudung,typeof(System.String));
			
			dt.Columns.Add(Field_Sometsudung,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sokgsudung,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(MangtheolenhEntity _MangtheolenhEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_MangtheolenhEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Solenhsx]=_MangtheolenhEntity.Solenhsx;
			}
			catch { }
			
			try
			{
				r[Field_Ngayphatlenh]=_MangtheolenhEntity.Ngayphatlenh;
			}
			catch { }
			
			try
			{
				r[Field_Mamangquydinh]=_MangtheolenhEntity.Mamangquydinh;
			}
			catch { }
			
			try
			{
				r[Field_Tenmangquydinh]=_MangtheolenhEntity.Tenmangquydinh;
			}
			catch { }
			
			try
			{
				r[Field_Sometquydinh]=_MangtheolenhEntity.Sometquydinh;
			}
			catch { }
			
			try
			{
				r[Field_Sokgquydinh]=_MangtheolenhEntity.Sokgquydinh;
			}
			catch { }
			
			try
			{
				r[Field_Sometthoi]=_MangtheolenhEntity.Sometthoi;
			}
			catch { }
			
			try
			{
				r[Field_Sokgthoi]=_MangtheolenhEntity.Sokgthoi;
			}
			catch { }
			
			try
			{
				r[Field_Mamangsudung]=_MangtheolenhEntity.Mamangsudung;
			}
			catch { }
			
			try
			{
				r[Field_Tenmangsudung]=_MangtheolenhEntity.Tenmangsudung;
			}
			catch { }
			
			try
			{
				r[Field_Sometsudung]=_MangtheolenhEntity.Sometsudung;
			}
			catch { }
			
			try
			{
				r[Field_Sokgsudung]=_MangtheolenhEntity.Sokgsudung;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_MangtheolenhEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_MangtheolenhEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_MangtheolenhEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_MangtheolenhEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public MangtheolenhEntity Convert(DataRow r)
		{	
			
			MangtheolenhEntity _MangtheolenhEntity=new MangtheolenhEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_MangtheolenhEntity.Solenhsx= r[Field_Solenhsx].ToString();						
			}
			catch { }
			
			try
			{
				_MangtheolenhEntity.Ngayphatlenh= System.DateTime.Parse(r[Field_Ngayphatlenh].ToString());						
			}
			catch { }
			
			try
			{
				_MangtheolenhEntity.Mamangquydinh= r[Field_Mamangquydinh].ToString();						
			}
			catch { }
			
			try
			{
				_MangtheolenhEntity.Tenmangquydinh= r[Field_Tenmangquydinh].ToString();						
			}
			catch { }
			
			try
			{
				_MangtheolenhEntity.Sometquydinh= System.Decimal.Parse(r[Field_Sometquydinh].ToString());						
			}
			catch { }
			
			try
			{
				_MangtheolenhEntity.Sokgquydinh= System.Decimal.Parse(r[Field_Sokgquydinh].ToString());						
			}
			catch { }
			
			try
			{
				_MangtheolenhEntity.Sometthoi= System.Decimal.Parse(r[Field_Sometthoi].ToString());						
			}
			catch { }
			
			try
			{
				_MangtheolenhEntity.Sokgthoi= System.Decimal.Parse(r[Field_Sokgthoi].ToString());						
			}
			catch { }
			
			try
			{
				_MangtheolenhEntity.Mamangsudung= r[Field_Mamangsudung].ToString();						
			}
			catch { }
			
			try
			{
				_MangtheolenhEntity.Tenmangsudung= r[Field_Tenmangsudung].ToString();						
			}
			catch { }
			
			try
			{
				_MangtheolenhEntity.Sometsudung= System.Decimal.Parse(r[Field_Sometsudung].ToString());						
			}
			catch { }
			
			try
			{
				_MangtheolenhEntity.Sokgsudung= System.Decimal.Parse(r[Field_Sokgsudung].ToString());						
			}
			catch { }
			
			try
			{
				_MangtheolenhEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_MangtheolenhEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_MangtheolenhEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_MangtheolenhEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _MangtheolenhEntity;
		}			
		
		public MangtheolenhEntity Convert_Entity(MangtheolenhEntity _MangtheolenhEntity,MangtheolenhEntity _MangtheolenhEntity_XML)
		{	
			
			
			_MangtheolenhEntity.Id= _MangtheolenhEntity_XML.Id;
			
			_MangtheolenhEntity.Solenhsx= _MangtheolenhEntity_XML.Solenhsx;
			
			_MangtheolenhEntity.Ngayphatlenh= _MangtheolenhEntity_XML.Ngayphatlenh;
			
			_MangtheolenhEntity.Mamangquydinh= _MangtheolenhEntity_XML.Mamangquydinh;
			
			_MangtheolenhEntity.Tenmangquydinh= _MangtheolenhEntity_XML.Tenmangquydinh;
			
			_MangtheolenhEntity.Sometquydinh= _MangtheolenhEntity_XML.Sometquydinh;
			
			_MangtheolenhEntity.Sokgquydinh= _MangtheolenhEntity_XML.Sokgquydinh;
			
			_MangtheolenhEntity.Sometthoi= _MangtheolenhEntity_XML.Sometthoi;
			
			_MangtheolenhEntity.Sokgthoi= _MangtheolenhEntity_XML.Sokgthoi;
			
			_MangtheolenhEntity.Mamangsudung= _MangtheolenhEntity_XML.Mamangsudung;
			
			_MangtheolenhEntity.Tenmangsudung= _MangtheolenhEntity_XML.Tenmangsudung;
			
			_MangtheolenhEntity.Sometsudung= _MangtheolenhEntity_XML.Sometsudung;
			
			_MangtheolenhEntity.Sokgsudung= _MangtheolenhEntity_XML.Sokgsudung;
			
			_MangtheolenhEntity.Ngaytao= _MangtheolenhEntity_XML.Ngaytao;
			
			_MangtheolenhEntity.Nguoitao= _MangtheolenhEntity_XML.Nguoitao;
			
			_MangtheolenhEntity.Ngaysua= _MangtheolenhEntity_XML.Ngaysua;
			
			_MangtheolenhEntity.Nguoisua= _MangtheolenhEntity_XML.Nguoisua;
									
				
			return _MangtheolenhEntity;
		}	
		
		public String InsertV2(MangtheolenhEntity _MangtheolenhEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new MangtheolenhManagerBase()).Insert(_MangtheolenhEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_MangtheolenhEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Solenhsx,_MangtheolenhEntity.Solenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngayphatlenh,_MangtheolenhEntity.Ngayphatlenh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamangquydinh,_MangtheolenhEntity.Mamangquydinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmangquydinh,_MangtheolenhEntity.Tenmangquydinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometquydinh,_MangtheolenhEntity.Sometquydinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgquydinh,_MangtheolenhEntity.Sokgquydinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometthoi,_MangtheolenhEntity.Sometthoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgthoi,_MangtheolenhEntity.Sokgthoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamangsudung,_MangtheolenhEntity.Mamangsudung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmangsudung,_MangtheolenhEntity.Tenmangsudung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometsudung,_MangtheolenhEntity.Sometsudung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgsudung,_MangtheolenhEntity.Sokgsudung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_MangtheolenhEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_MangtheolenhEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_MangtheolenhEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_MangtheolenhEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(MangtheolenhEntity _MangtheolenhEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new MangtheolenhManagerBase()).Update(_MangtheolenhEntity);
			r.SetField(Field_Id,_MangtheolenhEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Solenhsx,_MangtheolenhEntity.Solenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngayphatlenh,_MangtheolenhEntity.Ngayphatlenh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamangquydinh,_MangtheolenhEntity.Mamangquydinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmangquydinh,_MangtheolenhEntity.Tenmangquydinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometquydinh,_MangtheolenhEntity.Sometquydinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgquydinh,_MangtheolenhEntity.Sokgquydinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometthoi,_MangtheolenhEntity.Sometthoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgthoi,_MangtheolenhEntity.Sokgthoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamangsudung,_MangtheolenhEntity.Mamangsudung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmangsudung,_MangtheolenhEntity.Tenmangsudung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometsudung,_MangtheolenhEntity.Sometsudung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgsudung,_MangtheolenhEntity.Sokgsudung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_MangtheolenhEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_MangtheolenhEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_MangtheolenhEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_MangtheolenhEntity.Nguoisua);
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

		public MangtheolenhEntity Insert(MangtheolenhEntity MangtheolenhEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(MangtheolenhEntity, true);
			}
			return MangtheolenhEntity;
		}

		public MangtheolenhEntity Insert(System.Int64  Id, System.String  Solenhsx, System.DateTime  Ngayphatlenh, System.String  Mamangquydinh, System.String  Tenmangquydinh, System.Decimal  Sometquydinh, System.Decimal  Sokgquydinh, System.Decimal  Sometthoi, System.Decimal  Sokgthoi, System.String  Mamangsudung, System.String  Tenmangsudung, System.Decimal  Sometsudung, System.Decimal  Sokgsudung, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			MangtheolenhEntity _MangtheolenhEntity = new MangtheolenhEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_MangtheolenhEntity.Id = Id;
				
				_MangtheolenhEntity.Solenhsx = Solenhsx;
				
				_MangtheolenhEntity.Ngayphatlenh = Ngayphatlenh;
				
				_MangtheolenhEntity.Mamangquydinh = Mamangquydinh;
				
				_MangtheolenhEntity.Tenmangquydinh = Tenmangquydinh;
				
				_MangtheolenhEntity.Sometquydinh = Sometquydinh;
				
				_MangtheolenhEntity.Sokgquydinh = Sokgquydinh;
				
				_MangtheolenhEntity.Sometthoi = Sometthoi;
				
				_MangtheolenhEntity.Sokgthoi = Sokgthoi;
				
				_MangtheolenhEntity.Mamangsudung = Mamangsudung;
				
				_MangtheolenhEntity.Tenmangsudung = Tenmangsudung;
				
				_MangtheolenhEntity.Sometsudung = Sometsudung;
				
				_MangtheolenhEntity.Sokgsudung = Sokgsudung;
				
				_MangtheolenhEntity.Ngaytao = Ngaytao;
				
				_MangtheolenhEntity.Nguoitao = Nguoitao;
				
				_MangtheolenhEntity.Ngaysua = Ngaysua;
				
				_MangtheolenhEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_MangtheolenhEntity, true);
			}
			return _MangtheolenhEntity;
		}

		public MangtheolenhEntity Insert(System.String Solenhsx, System.DateTime Ngayphatlenh, System.String Mamangquydinh, System.String Tenmangquydinh, System.Decimal Sometquydinh, System.Decimal Sokgquydinh, System.Decimal Sometthoi, System.Decimal Sokgthoi, System.String Mamangsudung, System.String Tenmangsudung, System.Decimal Sometsudung, System.Decimal Sokgsudung, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			MangtheolenhEntity _MangtheolenhEntity = new MangtheolenhEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_MangtheolenhEntity.Solenhsx = Solenhsx;
				
				_MangtheolenhEntity.Ngayphatlenh = Ngayphatlenh;
				
				_MangtheolenhEntity.Mamangquydinh = Mamangquydinh;
				
				_MangtheolenhEntity.Tenmangquydinh = Tenmangquydinh;
				
				_MangtheolenhEntity.Sometquydinh = Sometquydinh;
				
				_MangtheolenhEntity.Sokgquydinh = Sokgquydinh;
				
				_MangtheolenhEntity.Sometthoi = Sometthoi;
				
				_MangtheolenhEntity.Sokgthoi = Sokgthoi;
				
				_MangtheolenhEntity.Mamangsudung = Mamangsudung;
				
				_MangtheolenhEntity.Tenmangsudung = Tenmangsudung;
				
				_MangtheolenhEntity.Sometsudung = Sometsudung;
				
				_MangtheolenhEntity.Sokgsudung = Sokgsudung;
				
				_MangtheolenhEntity.Ngaytao = Ngaytao;
				
				_MangtheolenhEntity.Nguoitao = Nguoitao;
				
				_MangtheolenhEntity.Ngaysua = Ngaysua;
				
				_MangtheolenhEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_MangtheolenhEntity, true);
			}
			return _MangtheolenhEntity;
		}

		public bool Update(MangtheolenhEntity _MangtheolenhEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(MangtheolenhFields.Id == _MangtheolenhEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_MangtheolenhEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(MangtheolenhEntity _MangtheolenhEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_MangtheolenhEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Solenhsx, System.DateTime Ngayphatlenh, System.String Mamangquydinh, System.String Tenmangquydinh, System.Decimal Sometquydinh, System.Decimal Sokgquydinh, System.Decimal Sometthoi, System.Decimal Sokgthoi, System.String Mamangsudung, System.String Tenmangsudung, System.Decimal Sometsudung, System.Decimal Sokgsudung, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MangtheolenhEntity _MangtheolenhEntity = new MangtheolenhEntity(Id);
				if (adapter.FetchEntity(_MangtheolenhEntity))
				{
				
					
					
					_MangtheolenhEntity.Solenhsx = Solenhsx;
					
					_MangtheolenhEntity.Ngayphatlenh = Ngayphatlenh;
					
					_MangtheolenhEntity.Mamangquydinh = Mamangquydinh;
					
					_MangtheolenhEntity.Tenmangquydinh = Tenmangquydinh;
					
					_MangtheolenhEntity.Sometquydinh = Sometquydinh;
					
					_MangtheolenhEntity.Sokgquydinh = Sokgquydinh;
					
					_MangtheolenhEntity.Sometthoi = Sometthoi;
					
					_MangtheolenhEntity.Sokgthoi = Sokgthoi;
					
					_MangtheolenhEntity.Mamangsudung = Mamangsudung;
					
					_MangtheolenhEntity.Tenmangsudung = Tenmangsudung;
					
					_MangtheolenhEntity.Sometsudung = Sometsudung;
					
					_MangtheolenhEntity.Sokgsudung = Sokgsudung;
					
					_MangtheolenhEntity.Ngaytao = Ngaytao;
					
					_MangtheolenhEntity.Nguoitao = Nguoitao;
					
					_MangtheolenhEntity.Ngaysua = Ngaysua;
					
					_MangtheolenhEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_MangtheolenhEntity, true);
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
				MangtheolenhEntity _MangtheolenhEntity = new MangtheolenhEntity(Id);
				if (adapter.FetchEntity(_MangtheolenhEntity))
				{
					adapter.DeleteEntity(_MangtheolenhEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("MangtheolenhEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangtheolenhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySolenhsx(System.String Solenhsx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangtheolenhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgayphatlenh(System.DateTime Ngayphatlenh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Ngayphatlenh == Ngayphatlenh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangtheolenhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamangquydinh(System.String Mamangquydinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Mamangquydinh == Mamangquydinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangtheolenhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmangquydinh(System.String Tenmangquydinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Tenmangquydinh == Tenmangquydinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangtheolenhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySometquydinh(System.Decimal Sometquydinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Sometquydinh == Sometquydinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangtheolenhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokgquydinh(System.Decimal Sokgquydinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Sokgquydinh == Sokgquydinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangtheolenhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySometthoi(System.Decimal Sometthoi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Sometthoi == Sometthoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangtheolenhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokgthoi(System.Decimal Sokgthoi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Sokgthoi == Sokgthoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangtheolenhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamangsudung(System.String Mamangsudung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Mamangsudung == Mamangsudung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangtheolenhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmangsudung(System.String Tenmangsudung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Tenmangsudung == Tenmangsudung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangtheolenhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySometsudung(System.Decimal Sometsudung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Sometsudung == Sometsudung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangtheolenhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokgsudung(System.Decimal Sokgsudung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Sokgsudung == Sokgsudung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangtheolenhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangtheolenhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangtheolenhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangtheolenhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangtheolenhEntity", filter);
			}
			return toReturn;
		}		
			
		
		public MangtheolenhEntity SelectOne(System.Int64 Id)
		{
			MangtheolenhEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MangtheolenhEntity _MangtheolenhEntity = new MangtheolenhEntity(Id);
				if (adapter.FetchEntity(_MangtheolenhEntity))
				{
					toReturn = _MangtheolenhEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _MangtheolenhCollection = new EntityCollection( new MangtheolenhEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangtheolenhCollection, null, 0, null);
			}
			return _MangtheolenhCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangtheolenhCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangtheolenhCollection, filter, 0, null);
			}
			return _MangtheolenhCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangtheolenhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySolenhsx(System.String Solenhsx)
		{
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangtheolenhCollection, filter, 0, null);
			}
			return _MangtheolenhCollection;
		}
		// Return DataTable
		public DataTable SelectBySolenhsxRDT(System.String Solenhsx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangtheolenhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgayphatlenh(System.DateTime Ngayphatlenh)
		{
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Ngayphatlenh == Ngayphatlenh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangtheolenhCollection, filter, 0, null);
			}
			return _MangtheolenhCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayphatlenhRDT(System.DateTime Ngayphatlenh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Ngayphatlenh == Ngayphatlenh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangtheolenhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamangquydinh(System.String Mamangquydinh)
		{
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Mamangquydinh == Mamangquydinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangtheolenhCollection, filter, 0, null);
			}
			return _MangtheolenhCollection;
		}
		// Return DataTable
		public DataTable SelectByMamangquydinhRDT(System.String Mamangquydinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Mamangquydinh == Mamangquydinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangtheolenhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmangquydinh(System.String Tenmangquydinh)
		{
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Tenmangquydinh == Tenmangquydinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangtheolenhCollection, filter, 0, null);
			}
			return _MangtheolenhCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmangquydinhRDT(System.String Tenmangquydinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Tenmangquydinh == Tenmangquydinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangtheolenhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySometquydinh(System.Decimal Sometquydinh)
		{
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Sometquydinh == Sometquydinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangtheolenhCollection, filter, 0, null);
			}
			return _MangtheolenhCollection;
		}
		// Return DataTable
		public DataTable SelectBySometquydinhRDT(System.Decimal Sometquydinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Sometquydinh == Sometquydinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangtheolenhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokgquydinh(System.Decimal Sokgquydinh)
		{
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Sokgquydinh == Sokgquydinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangtheolenhCollection, filter, 0, null);
			}
			return _MangtheolenhCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgquydinhRDT(System.Decimal Sokgquydinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Sokgquydinh == Sokgquydinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangtheolenhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySometthoi(System.Decimal Sometthoi)
		{
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Sometthoi == Sometthoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangtheolenhCollection, filter, 0, null);
			}
			return _MangtheolenhCollection;
		}
		// Return DataTable
		public DataTable SelectBySometthoiRDT(System.Decimal Sometthoi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Sometthoi == Sometthoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangtheolenhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokgthoi(System.Decimal Sokgthoi)
		{
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Sokgthoi == Sokgthoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangtheolenhCollection, filter, 0, null);
			}
			return _MangtheolenhCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgthoiRDT(System.Decimal Sokgthoi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Sokgthoi == Sokgthoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangtheolenhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamangsudung(System.String Mamangsudung)
		{
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Mamangsudung == Mamangsudung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangtheolenhCollection, filter, 0, null);
			}
			return _MangtheolenhCollection;
		}
		// Return DataTable
		public DataTable SelectByMamangsudungRDT(System.String Mamangsudung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Mamangsudung == Mamangsudung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangtheolenhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmangsudung(System.String Tenmangsudung)
		{
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Tenmangsudung == Tenmangsudung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangtheolenhCollection, filter, 0, null);
			}
			return _MangtheolenhCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmangsudungRDT(System.String Tenmangsudung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Tenmangsudung == Tenmangsudung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangtheolenhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySometsudung(System.Decimal Sometsudung)
		{
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Sometsudung == Sometsudung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangtheolenhCollection, filter, 0, null);
			}
			return _MangtheolenhCollection;
		}
		// Return DataTable
		public DataTable SelectBySometsudungRDT(System.Decimal Sometsudung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Sometsudung == Sometsudung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangtheolenhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokgsudung(System.Decimal Sokgsudung)
		{
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Sokgsudung == Sokgsudung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangtheolenhCollection, filter, 0, null);
			}
			return _MangtheolenhCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgsudungRDT(System.Decimal Sokgsudung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Sokgsudung == Sokgsudung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangtheolenhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangtheolenhCollection, filter, 0, null);
			}
			return _MangtheolenhCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangtheolenhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangtheolenhCollection, filter, 0, null);
			}
			return _MangtheolenhCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangtheolenhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangtheolenhCollection, filter, 0, null);
			}
			return _MangtheolenhCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangtheolenhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangtheolenhCollection, filter, 0, null);
			}
			return _MangtheolenhCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangtheolenhCollection = new EntityCollection(new MangtheolenhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangtheolenhFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangtheolenhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(MangtheolenhFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
