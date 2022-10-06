


/*
'===============================================================================
'  GD.BBPH.BL.DmdongmayManagerBase
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
	public class DmdongmayManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Madm="Madm";				
		
		public const String Field_Tendongmay="Tendongmay";				
		
		public const String Field_Macd="Macd";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmdongmayManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Madm,typeof(System.String));
			
			dt.Columns.Add(Field_Tendongmay,typeof(System.String));
			
			dt.Columns.Add(Field_Macd,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmdongmayEntity _DmdongmayEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Madm]=_DmdongmayEntity.Madm;
			}
			catch { }
			
			try
			{
				r[Field_Tendongmay]=_DmdongmayEntity.Tendongmay;
			}
			catch { }
			
			try
			{
				r[Field_Macd]=_DmdongmayEntity.Macd;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DmdongmayEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DmdongmayEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DmdongmayEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DmdongmayEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmdongmayEntity Convert(DataRow r)
		{	
			
			DmdongmayEntity _DmdongmayEntity=new DmdongmayEntity(r[Field_Madm].ToString());					
						
			
			
			try
			{
				_DmdongmayEntity.Tendongmay= r[Field_Tendongmay].ToString();						
			}
			catch { }
			
			try
			{
				_DmdongmayEntity.Macd= r[Field_Macd].ToString();						
			}
			catch { }
			
			try
			{
				_DmdongmayEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DmdongmayEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DmdongmayEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DmdongmayEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DmdongmayEntity;
		}			
		
		public DmdongmayEntity Convert_Entity(DmdongmayEntity _DmdongmayEntity,DmdongmayEntity _DmdongmayEntity_XML)
		{	
			
			
			_DmdongmayEntity.Madm= _DmdongmayEntity_XML.Madm;
			
			_DmdongmayEntity.Tendongmay= _DmdongmayEntity_XML.Tendongmay;
			
			_DmdongmayEntity.Macd= _DmdongmayEntity_XML.Macd;
			
			_DmdongmayEntity.Ngaytao= _DmdongmayEntity_XML.Ngaytao;
			
			_DmdongmayEntity.Nguoitao= _DmdongmayEntity_XML.Nguoitao;
			
			_DmdongmayEntity.Ngaysua= _DmdongmayEntity_XML.Ngaysua;
			
			_DmdongmayEntity.Nguoisua= _DmdongmayEntity_XML.Nguoisua;
									
				
			return _DmdongmayEntity;
		}	
		
		public String InsertV2(DmdongmayEntity _DmdongmayEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmdongmayManagerBase()).Insert(_DmdongmayEntity).Madm.ToString();
			
			
			try
			{
				r.SetField(Field_Madm,_DmdongmayEntity.Madm);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tendongmay,_DmdongmayEntity.Tendongmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macd,_DmdongmayEntity.Macd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmdongmayEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmdongmayEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmdongmayEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmdongmayEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmdongmayEntity _DmdongmayEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmdongmayManagerBase()).Update(_DmdongmayEntity);
			r.SetField(Field_Madm,_DmdongmayEntity.Madm);
									
			
			
			
			try
			{
				r.SetField(Field_Tendongmay,_DmdongmayEntity.Tendongmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macd,_DmdongmayEntity.Macd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmdongmayEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmdongmayEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmdongmayEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmdongmayEntity.Nguoisua);
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

		public DmdongmayEntity Insert(DmdongmayEntity DmdongmayEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmdongmayEntity, true);
			}
			return DmdongmayEntity;
		}

		public DmdongmayEntity Insert(System.String  Madm, System.String  Tendongmay, System.String  Macd, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DmdongmayEntity _DmdongmayEntity = new DmdongmayEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmdongmayEntity.Madm = Madm;
				
				_DmdongmayEntity.Tendongmay = Tendongmay;
				
				_DmdongmayEntity.Macd = Macd;
				
				_DmdongmayEntity.Ngaytao = Ngaytao;
				
				_DmdongmayEntity.Nguoitao = Nguoitao;
				
				_DmdongmayEntity.Ngaysua = Ngaysua;
				
				_DmdongmayEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DmdongmayEntity, true);
			}
			return _DmdongmayEntity;
		}

		public DmdongmayEntity Insert(System.String Tendongmay, System.String Macd, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DmdongmayEntity _DmdongmayEntity = new DmdongmayEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmdongmayEntity.Tendongmay = Tendongmay;
				
				_DmdongmayEntity.Macd = Macd;
				
				_DmdongmayEntity.Ngaytao = Ngaytao;
				
				_DmdongmayEntity.Nguoitao = Nguoitao;
				
				_DmdongmayEntity.Ngaysua = Ngaysua;
				
				_DmdongmayEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DmdongmayEntity, true);
			}
			return _DmdongmayEntity;
		}

		public bool Update(DmdongmayEntity _DmdongmayEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmdongmayFields.Madm == _DmdongmayEntity.Madm);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmdongmayEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmdongmayEntity _DmdongmayEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmdongmayEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Madm, System.String Tendongmay, System.String Macd, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmdongmayEntity _DmdongmayEntity = new DmdongmayEntity(Madm);
				if (adapter.FetchEntity(_DmdongmayEntity))
				{
				
					
					
					_DmdongmayEntity.Tendongmay = Tendongmay;
					
					_DmdongmayEntity.Macd = Macd;
					
					_DmdongmayEntity.Ngaytao = Ngaytao;
					
					_DmdongmayEntity.Nguoitao = Nguoitao;
					
					_DmdongmayEntity.Ngaysua = Ngaysua;
					
					_DmdongmayEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DmdongmayEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Madm)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmdongmayEntity _DmdongmayEntity = new DmdongmayEntity(Madm);
				if (adapter.FetchEntity(_DmdongmayEntity))
				{
					adapter.DeleteEntity(_DmdongmayEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmdongmayEntity", null);
			}
		}
		
		
		
		public int DeleteByMadm(System.String Madm)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Madm == Madm);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmdongmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTendongmay(System.String Tendongmay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Tendongmay == Tendongmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmdongmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMacd(System.String Macd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Macd == Macd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmdongmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmdongmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmdongmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmdongmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmdongmayEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmdongmayEntity SelectOne(System.String Madm)
		{
			DmdongmayEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmdongmayEntity _DmdongmayEntity = new DmdongmayEntity(Madm);
				if (adapter.FetchEntity(_DmdongmayEntity))
				{
					toReturn = _DmdongmayEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmdongmayCollection = new EntityCollection( new DmdongmayEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmdongmayCollection, null, 0, null);
			}
			return _DmdongmayCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmdongmayCollection = new EntityCollection(new DmdongmayEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmdongmayCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMadm(System.String Madm)
		{
			EntityCollection _DmdongmayCollection = new EntityCollection(new DmdongmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Madm == Madm);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmdongmayCollection, filter, 0, null);
			}
			return _DmdongmayCollection;
		}
		// Return DataTable
		public DataTable SelectByMadmRDT(System.String Madm)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmdongmayCollection = new EntityCollection(new DmdongmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Madm == Madm);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmdongmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTendongmay(System.String Tendongmay)
		{
			EntityCollection _DmdongmayCollection = new EntityCollection(new DmdongmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Tendongmay == Tendongmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmdongmayCollection, filter, 0, null);
			}
			return _DmdongmayCollection;
		}
		// Return DataTable
		public DataTable SelectByTendongmayRDT(System.String Tendongmay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmdongmayCollection = new EntityCollection(new DmdongmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Tendongmay == Tendongmay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmdongmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMacd(System.String Macd)
		{
			EntityCollection _DmdongmayCollection = new EntityCollection(new DmdongmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Macd == Macd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmdongmayCollection, filter, 0, null);
			}
			return _DmdongmayCollection;
		}
		// Return DataTable
		public DataTable SelectByMacdRDT(System.String Macd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmdongmayCollection = new EntityCollection(new DmdongmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Macd == Macd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmdongmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DmdongmayCollection = new EntityCollection(new DmdongmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmdongmayCollection, filter, 0, null);
			}
			return _DmdongmayCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmdongmayCollection = new EntityCollection(new DmdongmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmdongmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DmdongmayCollection = new EntityCollection(new DmdongmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmdongmayCollection, filter, 0, null);
			}
			return _DmdongmayCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmdongmayCollection = new EntityCollection(new DmdongmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmdongmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DmdongmayCollection = new EntityCollection(new DmdongmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmdongmayCollection, filter, 0, null);
			}
			return _DmdongmayCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmdongmayCollection = new EntityCollection(new DmdongmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmdongmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DmdongmayCollection = new EntityCollection(new DmdongmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmdongmayCollection, filter, 0, null);
			}
			return _DmdongmayCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmdongmayCollection = new EntityCollection(new DmdongmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmdongmayFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmdongmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
