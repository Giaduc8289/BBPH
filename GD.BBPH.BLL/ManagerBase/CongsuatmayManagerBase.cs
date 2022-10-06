


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
		
		
		public const String Field_Macs="Macs";				
		
		public const String Field_Tencongsuat="Tencongsuat";				
		
		public const String Field_Macd="Macd";				
		
		public const String Field_Maqc="Maqc";				
		
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
			
			
			dt.Columns.Add(Field_Macs,typeof(System.String));
			
			dt.Columns.Add(Field_Tencongsuat,typeof(System.String));
			
			dt.Columns.Add(Field_Macd,typeof(System.String));
			
			dt.Columns.Add(Field_Maqc,typeof(System.String));
			
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
				r[Field_Macs]=_CongsuatmayEntity.Macs;
			}
			catch { }
			
			try
			{
				r[Field_Tencongsuat]=_CongsuatmayEntity.Tencongsuat;
			}
			catch { }
			
			try
			{
				r[Field_Macd]=_CongsuatmayEntity.Macd;
			}
			catch { }
			
			try
			{
				r[Field_Maqc]=_CongsuatmayEntity.Maqc;
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
			
			CongsuatmayEntity _CongsuatmayEntity=new CongsuatmayEntity(r[Field_Macs].ToString());					
						
			
			
			try
			{
				_CongsuatmayEntity.Tencongsuat= r[Field_Tencongsuat].ToString();						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Macd= r[Field_Macd].ToString();						
			}
			catch { }
			
			try
			{
				_CongsuatmayEntity.Maqc= r[Field_Maqc].ToString();						
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
			
			
			_CongsuatmayEntity.Macs= _CongsuatmayEntity_XML.Macs;
			
			_CongsuatmayEntity.Tencongsuat= _CongsuatmayEntity_XML.Tencongsuat;
			
			_CongsuatmayEntity.Macd= _CongsuatmayEntity_XML.Macd;
			
			_CongsuatmayEntity.Maqc= _CongsuatmayEntity_XML.Maqc;
			
			_CongsuatmayEntity.Ngaytao= _CongsuatmayEntity_XML.Ngaytao;
			
			_CongsuatmayEntity.Nguoitao= _CongsuatmayEntity_XML.Nguoitao;
			
			_CongsuatmayEntity.Ngaysua= _CongsuatmayEntity_XML.Ngaysua;
			
			_CongsuatmayEntity.Nguoisua= _CongsuatmayEntity_XML.Nguoisua;
									
				
			return _CongsuatmayEntity;
		}	
		
		public String InsertV2(CongsuatmayEntity _CongsuatmayEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new CongsuatmayManagerBase()).Insert(_CongsuatmayEntity).Macs.ToString();
			
			
			try
			{
				r.SetField(Field_Macs,_CongsuatmayEntity.Macs);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tencongsuat,_CongsuatmayEntity.Tencongsuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macd,_CongsuatmayEntity.Macd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqc,_CongsuatmayEntity.Maqc);
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
			r.SetField(Field_Macs,_CongsuatmayEntity.Macs);
									
			
			
			
			try
			{
				r.SetField(Field_Tencongsuat,_CongsuatmayEntity.Tencongsuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macd,_CongsuatmayEntity.Macd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqc,_CongsuatmayEntity.Maqc);
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

		public CongsuatmayEntity Insert(System.String  Macs, System.String  Tencongsuat, System.String  Macd, System.String  Maqc, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			CongsuatmayEntity _CongsuatmayEntity = new CongsuatmayEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CongsuatmayEntity.Macs = Macs;
				
				_CongsuatmayEntity.Tencongsuat = Tencongsuat;
				
				_CongsuatmayEntity.Macd = Macd;
				
				_CongsuatmayEntity.Maqc = Maqc;
				
				_CongsuatmayEntity.Ngaytao = Ngaytao;
				
				_CongsuatmayEntity.Nguoitao = Nguoitao;
				
				_CongsuatmayEntity.Ngaysua = Ngaysua;
				
				_CongsuatmayEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_CongsuatmayEntity, true);
			}
			return _CongsuatmayEntity;
		}

		public CongsuatmayEntity Insert(System.String Tencongsuat, System.String Macd, System.String Maqc, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			CongsuatmayEntity _CongsuatmayEntity = new CongsuatmayEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_CongsuatmayEntity.Tencongsuat = Tencongsuat;
				
				_CongsuatmayEntity.Macd = Macd;
				
				_CongsuatmayEntity.Maqc = Maqc;
				
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
				
				_PredicateExpression.Add(CongsuatmayFields.Macs == _CongsuatmayEntity.Macs);
				
					
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

		public bool Update(System.String Macs, System.String Tencongsuat, System.String Macd, System.String Maqc, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CongsuatmayEntity _CongsuatmayEntity = new CongsuatmayEntity(Macs);
				if (adapter.FetchEntity(_CongsuatmayEntity))
				{
				
					
					
					_CongsuatmayEntity.Tencongsuat = Tencongsuat;
					
					_CongsuatmayEntity.Macd = Macd;
					
					_CongsuatmayEntity.Maqc = Maqc;
					
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

		public bool Delete(System.String Macs)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CongsuatmayEntity _CongsuatmayEntity = new CongsuatmayEntity(Macs);
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
		
		
		
		public int DeleteByMacs(System.String Macs)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Macs == Macs);
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
		
		public int DeleteByMacd(System.String Macd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Macd == Macd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CongsuatmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaqc(System.String Maqc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Maqc == Maqc);
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
			
		
		public CongsuatmayEntity SelectOne(System.String Macs)
		{
			CongsuatmayEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CongsuatmayEntity _CongsuatmayEntity = new CongsuatmayEntity(Macs);
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
		public EntityCollection SelectByMacs(System.String Macs)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Macs == Macs);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByMacsRDT(System.String Macs)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Macs == Macs);
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
		public EntityCollection SelectByMacd(System.String Macd)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Macd == Macd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByMacdRDT(System.String Macd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Macd == Macd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CongsuatmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaqc(System.String Maqc)
		{
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Maqc == Maqc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CongsuatmayCollection, filter, 0, null);
			}
			return _CongsuatmayCollection;
		}
		// Return DataTable
		public DataTable SelectByMaqcRDT(System.String Maqc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CongsuatmayCollection = new EntityCollection(new CongsuatmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CongsuatmayFields.Maqc == Maqc);
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
			

	}
}
