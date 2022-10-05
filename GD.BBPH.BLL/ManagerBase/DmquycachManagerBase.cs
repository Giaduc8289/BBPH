


/*
'===============================================================================
'  GD.BBPH.BL.DmquycachManagerBase
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
	public class DmquycachManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Maqc="Maqc";				
		
		public const String Field_Tenquycach="Tenquycach";				
		
		public const String Field_Macd="Macd";				
		
		public const String Field_Maqccha="Maqccha";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmquycachManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Maqc,typeof(System.String));
			
			dt.Columns.Add(Field_Tenquycach,typeof(System.String));
			
			dt.Columns.Add(Field_Macd,typeof(System.String));
			
			dt.Columns.Add(Field_Maqccha,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmquycachEntity _DmquycachEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Maqc]=_DmquycachEntity.Maqc;
			}
			catch { }
			
			try
			{
				r[Field_Tenquycach]=_DmquycachEntity.Tenquycach;
			}
			catch { }
			
			try
			{
				r[Field_Macd]=_DmquycachEntity.Macd;
			}
			catch { }
			
			try
			{
				r[Field_Maqccha]=_DmquycachEntity.Maqccha;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DmquycachEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DmquycachEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DmquycachEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DmquycachEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmquycachEntity Convert(DataRow r)
		{	
			
			DmquycachEntity _DmquycachEntity=new DmquycachEntity(r[Field_Maqc].ToString());					
						
			
			
			try
			{
				_DmquycachEntity.Tenquycach= r[Field_Tenquycach].ToString();						
			}
			catch { }
			
			try
			{
				_DmquycachEntity.Macd= r[Field_Macd].ToString();						
			}
			catch { }
			
			try
			{
				_DmquycachEntity.Maqccha= r[Field_Maqccha].ToString();						
			}
			catch { }
			
			try
			{
				_DmquycachEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DmquycachEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DmquycachEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DmquycachEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DmquycachEntity;
		}			
		
		public DmquycachEntity Convert_Entity(DmquycachEntity _DmquycachEntity,DmquycachEntity _DmquycachEntity_XML)
		{	
			
			
			_DmquycachEntity.Maqc= _DmquycachEntity_XML.Maqc;
			
			_DmquycachEntity.Tenquycach= _DmquycachEntity_XML.Tenquycach;
			
			_DmquycachEntity.Macd= _DmquycachEntity_XML.Macd;
			
			_DmquycachEntity.Maqccha= _DmquycachEntity_XML.Maqccha;
			
			_DmquycachEntity.Ngaytao= _DmquycachEntity_XML.Ngaytao;
			
			_DmquycachEntity.Nguoitao= _DmquycachEntity_XML.Nguoitao;
			
			_DmquycachEntity.Ngaysua= _DmquycachEntity_XML.Ngaysua;
			
			_DmquycachEntity.Nguoisua= _DmquycachEntity_XML.Nguoisua;
									
				
			return _DmquycachEntity;
		}	
		
		public String InsertV2(DmquycachEntity _DmquycachEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmquycachManagerBase()).Insert(_DmquycachEntity).Maqc.ToString();
			
			
			try
			{
				r.SetField(Field_Maqc,_DmquycachEntity.Maqc);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenquycach,_DmquycachEntity.Tenquycach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macd,_DmquycachEntity.Macd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqccha,_DmquycachEntity.Maqccha);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmquycachEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmquycachEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmquycachEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmquycachEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmquycachEntity _DmquycachEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmquycachManagerBase()).Update(_DmquycachEntity);
			r.SetField(Field_Maqc,_DmquycachEntity.Maqc);
									
			
			
			
			try
			{
				r.SetField(Field_Tenquycach,_DmquycachEntity.Tenquycach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macd,_DmquycachEntity.Macd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqccha,_DmquycachEntity.Maqccha);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmquycachEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmquycachEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmquycachEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmquycachEntity.Nguoisua);
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

		public DmquycachEntity Insert(DmquycachEntity DmquycachEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmquycachEntity, true);
			}
			return DmquycachEntity;
		}

		public DmquycachEntity Insert(System.String  Maqc, System.String  Tenquycach, System.String  Macd, System.String  Maqccha, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DmquycachEntity _DmquycachEntity = new DmquycachEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmquycachEntity.Maqc = Maqc;
				
				_DmquycachEntity.Tenquycach = Tenquycach;
				
				_DmquycachEntity.Macd = Macd;
				
				_DmquycachEntity.Maqccha = Maqccha;
				
				_DmquycachEntity.Ngaytao = Ngaytao;
				
				_DmquycachEntity.Nguoitao = Nguoitao;
				
				_DmquycachEntity.Ngaysua = Ngaysua;
				
				_DmquycachEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DmquycachEntity, true);
			}
			return _DmquycachEntity;
		}

		public DmquycachEntity Insert(System.String Tenquycach, System.String Macd, System.String Maqccha, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DmquycachEntity _DmquycachEntity = new DmquycachEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmquycachEntity.Tenquycach = Tenquycach;
				
				_DmquycachEntity.Macd = Macd;
				
				_DmquycachEntity.Maqccha = Maqccha;
				
				_DmquycachEntity.Ngaytao = Ngaytao;
				
				_DmquycachEntity.Nguoitao = Nguoitao;
				
				_DmquycachEntity.Ngaysua = Ngaysua;
				
				_DmquycachEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DmquycachEntity, true);
			}
			return _DmquycachEntity;
		}

		public bool Update(DmquycachEntity _DmquycachEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmquycachFields.Maqc == _DmquycachEntity.Maqc);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmquycachEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmquycachEntity _DmquycachEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmquycachEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Maqc, System.String Tenquycach, System.String Macd, System.String Maqccha, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmquycachEntity _DmquycachEntity = new DmquycachEntity(Maqc);
				if (adapter.FetchEntity(_DmquycachEntity))
				{
				
					
					
					_DmquycachEntity.Tenquycach = Tenquycach;
					
					_DmquycachEntity.Macd = Macd;
					
					_DmquycachEntity.Maqccha = Maqccha;
					
					_DmquycachEntity.Ngaytao = Ngaytao;
					
					_DmquycachEntity.Nguoitao = Nguoitao;
					
					_DmquycachEntity.Ngaysua = Ngaysua;
					
					_DmquycachEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DmquycachEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Maqc)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmquycachEntity _DmquycachEntity = new DmquycachEntity(Maqc);
				if (adapter.FetchEntity(_DmquycachEntity))
				{
					adapter.DeleteEntity(_DmquycachEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmquycachEntity", null);
			}
		}
		
		
		
		public int DeleteByMaqc(System.String Maqc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Maqc == Maqc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenquycach(System.String Tenquycach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Tenquycach == Tenquycach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMacd(System.String Macd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Macd == Macd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaqccha(System.String Maqccha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Maqccha == Maqccha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmquycachEntity SelectOne(System.String Maqc)
		{
			DmquycachEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmquycachEntity _DmquycachEntity = new DmquycachEntity(Maqc);
				if (adapter.FetchEntity(_DmquycachEntity))
				{
					toReturn = _DmquycachEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmquycachCollection = new EntityCollection( new DmquycachEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, null, 0, null);
			}
			return _DmquycachCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMaqc(System.String Maqc)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Maqc == Maqc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByMaqcRDT(System.String Maqc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Maqc == Maqc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenquycach(System.String Tenquycach)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Tenquycach == Tenquycach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByTenquycachRDT(System.String Tenquycach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Tenquycach == Tenquycach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMacd(System.String Macd)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Macd == Macd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByMacdRDT(System.String Macd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Macd == Macd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaqccha(System.String Maqccha)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Maqccha == Maqccha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByMaqcchaRDT(System.String Maqccha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Maqccha == Maqccha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
