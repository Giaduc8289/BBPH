


/*
'===============================================================================
'  GD.BBPH.BL.DmchucvuManagerBase
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
	public class DmchucvuManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Macv="Macv";				
		
		public const String Field_Tenchucvu="Tenchucvu";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
		public const String Field_Heso="Heso";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmchucvuManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Macv,typeof(System.String));
			
			dt.Columns.Add(Field_Tenchucvu,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
			
			dt.Columns.Add(Field_Heso,typeof(System.Decimal));
									
		            
			return dt;			
		}
		public DataRow Convert(DmchucvuEntity _DmchucvuEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Macv]=_DmchucvuEntity.Macv;
			}
			catch { }
			
			try
			{
				r[Field_Tenchucvu]=_DmchucvuEntity.Tenchucvu;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DmchucvuEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DmchucvuEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DmchucvuEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DmchucvuEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Heso]=_DmchucvuEntity.Heso;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmchucvuEntity Convert(DataRow r)
		{	
			
			DmchucvuEntity _DmchucvuEntity=new DmchucvuEntity(r[Field_Macv].ToString());					
						
			
			
			try
			{
				_DmchucvuEntity.Tenchucvu= r[Field_Tenchucvu].ToString();						
			}
			catch { }
			
			try
			{
				_DmchucvuEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DmchucvuEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DmchucvuEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DmchucvuEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_DmchucvuEntity.Heso= System.Decimal.Parse(r[Field_Heso].ToString());						
			}
			catch { }
									
									
			return _DmchucvuEntity;
		}			
		
		public DmchucvuEntity Convert_Entity(DmchucvuEntity _DmchucvuEntity,DmchucvuEntity _DmchucvuEntity_XML)
		{	
			
			
			_DmchucvuEntity.Macv= _DmchucvuEntity_XML.Macv;
			
			_DmchucvuEntity.Tenchucvu= _DmchucvuEntity_XML.Tenchucvu;
			
			_DmchucvuEntity.Ngaytao= _DmchucvuEntity_XML.Ngaytao;
			
			_DmchucvuEntity.Nguoitao= _DmchucvuEntity_XML.Nguoitao;
			
			_DmchucvuEntity.Ngaysua= _DmchucvuEntity_XML.Ngaysua;
			
			_DmchucvuEntity.Nguoisua= _DmchucvuEntity_XML.Nguoisua;
			
			_DmchucvuEntity.Heso= _DmchucvuEntity_XML.Heso;
									
				
			return _DmchucvuEntity;
		}	
		
		public String InsertV2(DmchucvuEntity _DmchucvuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmchucvuManagerBase()).Insert(_DmchucvuEntity).Macv.ToString();
			
			
			try
			{
				r.SetField(Field_Macv,_DmchucvuEntity.Macv);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenchucvu,_DmchucvuEntity.Tenchucvu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmchucvuEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmchucvuEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmchucvuEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmchucvuEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Heso,_DmchucvuEntity.Heso);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmchucvuEntity _DmchucvuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmchucvuManagerBase()).Update(_DmchucvuEntity);
			r.SetField(Field_Macv,_DmchucvuEntity.Macv);
									
			
			
			
			try
			{
				r.SetField(Field_Tenchucvu,_DmchucvuEntity.Tenchucvu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmchucvuEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmchucvuEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmchucvuEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmchucvuEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Heso,_DmchucvuEntity.Heso);
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

		public DmchucvuEntity Insert(DmchucvuEntity DmchucvuEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmchucvuEntity, true);
			}
			return DmchucvuEntity;
		}

		public DmchucvuEntity Insert(System.String  Macv, System.String  Tenchucvu, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.Decimal  Heso)
		{
			DmchucvuEntity _DmchucvuEntity = new DmchucvuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmchucvuEntity.Macv = Macv;
				
				_DmchucvuEntity.Tenchucvu = Tenchucvu;
				
				_DmchucvuEntity.Ngaytao = Ngaytao;
				
				_DmchucvuEntity.Nguoitao = Nguoitao;
				
				_DmchucvuEntity.Ngaysua = Ngaysua;
				
				_DmchucvuEntity.Nguoisua = Nguoisua;
				
				_DmchucvuEntity.Heso = Heso;
					
					
				adapter.SaveEntity(_DmchucvuEntity, true);
			}
			return _DmchucvuEntity;
		}

		public DmchucvuEntity Insert(System.String Tenchucvu, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Heso)//ko co mahieu
		{
			DmchucvuEntity _DmchucvuEntity = new DmchucvuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmchucvuEntity.Tenchucvu = Tenchucvu;
				
				_DmchucvuEntity.Ngaytao = Ngaytao;
				
				_DmchucvuEntity.Nguoitao = Nguoitao;
				
				_DmchucvuEntity.Ngaysua = Ngaysua;
				
				_DmchucvuEntity.Nguoisua = Nguoisua;
				
				_DmchucvuEntity.Heso = Heso;
					

				adapter.SaveEntity(_DmchucvuEntity, true);
			}
			return _DmchucvuEntity;
		}

		public bool Update(DmchucvuEntity _DmchucvuEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmchucvuFields.Macv == _DmchucvuEntity.Macv);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmchucvuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmchucvuEntity _DmchucvuEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmchucvuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Macv, System.String Tenchucvu, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Heso)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmchucvuEntity _DmchucvuEntity = new DmchucvuEntity(Macv);
				if (adapter.FetchEntity(_DmchucvuEntity))
				{
				
					
					
					_DmchucvuEntity.Tenchucvu = Tenchucvu;
					
					_DmchucvuEntity.Ngaytao = Ngaytao;
					
					_DmchucvuEntity.Nguoitao = Nguoitao;
					
					_DmchucvuEntity.Ngaysua = Ngaysua;
					
					_DmchucvuEntity.Nguoisua = Nguoisua;
					
					_DmchucvuEntity.Heso = Heso;
						

					adapter.SaveEntity(_DmchucvuEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Macv)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmchucvuEntity _DmchucvuEntity = new DmchucvuEntity(Macv);
				if (adapter.FetchEntity(_DmchucvuEntity))
				{
					adapter.DeleteEntity(_DmchucvuEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmchucvuEntity", null);
			}
		}
		
		
		
		public int DeleteByMacv(System.String Macv)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Macv == Macv);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmchucvuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenchucvu(System.String Tenchucvu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Tenchucvu == Tenchucvu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmchucvuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmchucvuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmchucvuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmchucvuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmchucvuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByHeso(System.Decimal Heso)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Heso == Heso);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmchucvuEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmchucvuEntity SelectOne(System.String Macv)
		{
			DmchucvuEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmchucvuEntity _DmchucvuEntity = new DmchucvuEntity(Macv);
				if (adapter.FetchEntity(_DmchucvuEntity))
				{
					toReturn = _DmchucvuEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmchucvuCollection = new EntityCollection( new DmchucvuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchucvuCollection, null, 0, null);
			}
			return _DmchucvuCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMacv(System.String Macv)
		{
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Macv == Macv);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchucvuCollection, filter, 0, null);
			}
			return _DmchucvuCollection;
		}
		// Return DataTable
		public DataTable SelectByMacvRDT(System.String Macv)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Macv == Macv);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenchucvu(System.String Tenchucvu)
		{
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Tenchucvu == Tenchucvu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchucvuCollection, filter, 0, null);
			}
			return _DmchucvuCollection;
		}
		// Return DataTable
		public DataTable SelectByTenchucvuRDT(System.String Tenchucvu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Tenchucvu == Tenchucvu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchucvuCollection, filter, 0, null);
			}
			return _DmchucvuCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchucvuCollection, filter, 0, null);
			}
			return _DmchucvuCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchucvuCollection, filter, 0, null);
			}
			return _DmchucvuCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchucvuCollection, filter, 0, null);
			}
			return _DmchucvuCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByHeso(System.Decimal Heso)
		{
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Heso == Heso);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchucvuCollection, filter, 0, null);
			}
			return _DmchucvuCollection;
		}
		// Return DataTable
		public DataTable SelectByHesoRDT(System.Decimal Heso)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Heso == Heso);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(DmchucvuFields.Macv.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
