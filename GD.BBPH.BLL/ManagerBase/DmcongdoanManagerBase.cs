


/*
'===============================================================================
'  GD.BBPH.BL.DmcongdoanManagerBase
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
	public class DmcongdoanManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Macd="Macd";				
		
		public const String Field_Tencongdoan="Tencongdoan";				
		
		public const String Field_Sothutucongdoan="Sothutucongdoan";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmcongdoanManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Macd,typeof(System.String));
			
			dt.Columns.Add(Field_Tencongdoan,typeof(System.String));
			
			dt.Columns.Add(Field_Sothutucongdoan,typeof(System.Int32));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmcongdoanEntity _DmcongdoanEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Macd]=_DmcongdoanEntity.Macd;
			}
			catch { }
			
			try
			{
				r[Field_Tencongdoan]=_DmcongdoanEntity.Tencongdoan;
			}
			catch { }
			
			try
			{
				r[Field_Sothutucongdoan]=_DmcongdoanEntity.Sothutucongdoan;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DmcongdoanEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DmcongdoanEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DmcongdoanEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DmcongdoanEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmcongdoanEntity Convert(DataRow r)
		{	
			
			DmcongdoanEntity _DmcongdoanEntity=new DmcongdoanEntity(r[Field_Macd].ToString());					
						
			
			
			try
			{
				_DmcongdoanEntity.Tencongdoan= r[Field_Tencongdoan].ToString();						
			}
			catch { }
			
			try
			{
				_DmcongdoanEntity.Sothutucongdoan= System.Int32.Parse(r[Field_Sothutucongdoan].ToString());						
			}
			catch { }
			
			try
			{
				_DmcongdoanEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DmcongdoanEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DmcongdoanEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DmcongdoanEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DmcongdoanEntity;
		}			
		
		public DmcongdoanEntity Convert_Entity(DmcongdoanEntity _DmcongdoanEntity,DmcongdoanEntity _DmcongdoanEntity_XML)
		{	
			
			
			_DmcongdoanEntity.Macd= _DmcongdoanEntity_XML.Macd;
			
			_DmcongdoanEntity.Tencongdoan= _DmcongdoanEntity_XML.Tencongdoan;
			
			_DmcongdoanEntity.Sothutucongdoan= _DmcongdoanEntity_XML.Sothutucongdoan;
			
			_DmcongdoanEntity.Ngaytao= _DmcongdoanEntity_XML.Ngaytao;
			
			_DmcongdoanEntity.Nguoitao= _DmcongdoanEntity_XML.Nguoitao;
			
			_DmcongdoanEntity.Ngaysua= _DmcongdoanEntity_XML.Ngaysua;
			
			_DmcongdoanEntity.Nguoisua= _DmcongdoanEntity_XML.Nguoisua;
									
				
			return _DmcongdoanEntity;
		}	
		
		public String InsertV2(DmcongdoanEntity _DmcongdoanEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmcongdoanManagerBase()).Insert(_DmcongdoanEntity).Macd.ToString();
			
			
			try
			{
				r.SetField(Field_Macd,_DmcongdoanEntity.Macd);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tencongdoan,_DmcongdoanEntity.Tencongdoan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sothutucongdoan,_DmcongdoanEntity.Sothutucongdoan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmcongdoanEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmcongdoanEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmcongdoanEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmcongdoanEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmcongdoanEntity _DmcongdoanEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmcongdoanManagerBase()).Update(_DmcongdoanEntity);
			r.SetField(Field_Macd,_DmcongdoanEntity.Macd);
									
			
			
			
			try
			{
				r.SetField(Field_Tencongdoan,_DmcongdoanEntity.Tencongdoan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sothutucongdoan,_DmcongdoanEntity.Sothutucongdoan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmcongdoanEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmcongdoanEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmcongdoanEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmcongdoanEntity.Nguoisua);
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

		public DmcongdoanEntity Insert(DmcongdoanEntity DmcongdoanEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmcongdoanEntity, true);
			}
			return DmcongdoanEntity;
		}

		public DmcongdoanEntity Insert(System.String  Macd, System.String  Tencongdoan, System.Int32  Sothutucongdoan, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DmcongdoanEntity _DmcongdoanEntity = new DmcongdoanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmcongdoanEntity.Macd = Macd;
				
				_DmcongdoanEntity.Tencongdoan = Tencongdoan;
				
				_DmcongdoanEntity.Sothutucongdoan = Sothutucongdoan;
				
				_DmcongdoanEntity.Ngaytao = Ngaytao;
				
				_DmcongdoanEntity.Nguoitao = Nguoitao;
				
				_DmcongdoanEntity.Ngaysua = Ngaysua;
				
				_DmcongdoanEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DmcongdoanEntity, true);
			}
			return _DmcongdoanEntity;
		}

		public DmcongdoanEntity Insert(System.String Tencongdoan, System.Int32 Sothutucongdoan, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DmcongdoanEntity _DmcongdoanEntity = new DmcongdoanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmcongdoanEntity.Tencongdoan = Tencongdoan;
				
				_DmcongdoanEntity.Sothutucongdoan = Sothutucongdoan;
				
				_DmcongdoanEntity.Ngaytao = Ngaytao;
				
				_DmcongdoanEntity.Nguoitao = Nguoitao;
				
				_DmcongdoanEntity.Ngaysua = Ngaysua;
				
				_DmcongdoanEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DmcongdoanEntity, true);
			}
			return _DmcongdoanEntity;
		}

		public bool Update(DmcongdoanEntity _DmcongdoanEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmcongdoanFields.Macd == _DmcongdoanEntity.Macd);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmcongdoanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmcongdoanEntity _DmcongdoanEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmcongdoanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Macd, System.String Tencongdoan, System.Int32 Sothutucongdoan, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmcongdoanEntity _DmcongdoanEntity = new DmcongdoanEntity(Macd);
				if (adapter.FetchEntity(_DmcongdoanEntity))
				{
				
					
					
					_DmcongdoanEntity.Tencongdoan = Tencongdoan;
					
					_DmcongdoanEntity.Sothutucongdoan = Sothutucongdoan;
					
					_DmcongdoanEntity.Ngaytao = Ngaytao;
					
					_DmcongdoanEntity.Nguoitao = Nguoitao;
					
					_DmcongdoanEntity.Ngaysua = Ngaysua;
					
					_DmcongdoanEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DmcongdoanEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Macd)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmcongdoanEntity _DmcongdoanEntity = new DmcongdoanEntity(Macd);
				if (adapter.FetchEntity(_DmcongdoanEntity))
				{
					adapter.DeleteEntity(_DmcongdoanEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmcongdoanEntity", null);
			}
		}
		
		
		
		public int DeleteByMacd(System.String Macd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Macd == Macd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongdoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTencongdoan(System.String Tencongdoan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Tencongdoan == Tencongdoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongdoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySothutucongdoan(System.Int32 Sothutucongdoan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Sothutucongdoan == Sothutucongdoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongdoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongdoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongdoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongdoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongdoanEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmcongdoanEntity SelectOne(System.String Macd)
		{
			DmcongdoanEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmcongdoanEntity _DmcongdoanEntity = new DmcongdoanEntity(Macd);
				if (adapter.FetchEntity(_DmcongdoanEntity))
				{
					toReturn = _DmcongdoanEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmcongdoanCollection = new EntityCollection( new DmcongdoanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongdoanCollection, null, 0, null);
			}
			return _DmcongdoanCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongdoanCollection = new EntityCollection(new DmcongdoanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongdoanCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMacd(System.String Macd)
		{
			EntityCollection _DmcongdoanCollection = new EntityCollection(new DmcongdoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Macd == Macd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongdoanCollection, filter, 0, null);
			}
			return _DmcongdoanCollection;
		}
		// Return DataTable
		public DataTable SelectByMacdRDT(System.String Macd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongdoanCollection = new EntityCollection(new DmcongdoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Macd == Macd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongdoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTencongdoan(System.String Tencongdoan)
		{
			EntityCollection _DmcongdoanCollection = new EntityCollection(new DmcongdoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Tencongdoan == Tencongdoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongdoanCollection, filter, 0, null);
			}
			return _DmcongdoanCollection;
		}
		// Return DataTable
		public DataTable SelectByTencongdoanRDT(System.String Tencongdoan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongdoanCollection = new EntityCollection(new DmcongdoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Tencongdoan == Tencongdoan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongdoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySothutucongdoan(System.Int32 Sothutucongdoan)
		{
			EntityCollection _DmcongdoanCollection = new EntityCollection(new DmcongdoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Sothutucongdoan == Sothutucongdoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongdoanCollection, filter, 0, null);
			}
			return _DmcongdoanCollection;
		}
		// Return DataTable
		public DataTable SelectBySothutucongdoanRDT(System.Int32 Sothutucongdoan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongdoanCollection = new EntityCollection(new DmcongdoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Sothutucongdoan == Sothutucongdoan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongdoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DmcongdoanCollection = new EntityCollection(new DmcongdoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongdoanCollection, filter, 0, null);
			}
			return _DmcongdoanCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongdoanCollection = new EntityCollection(new DmcongdoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongdoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DmcongdoanCollection = new EntityCollection(new DmcongdoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongdoanCollection, filter, 0, null);
			}
			return _DmcongdoanCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongdoanCollection = new EntityCollection(new DmcongdoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongdoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DmcongdoanCollection = new EntityCollection(new DmcongdoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongdoanCollection, filter, 0, null);
			}
			return _DmcongdoanCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongdoanCollection = new EntityCollection(new DmcongdoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongdoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DmcongdoanCollection = new EntityCollection(new DmcongdoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongdoanCollection, filter, 0, null);
			}
			return _DmcongdoanCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongdoanCollection = new EntityCollection(new DmcongdoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongdoanFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongdoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
