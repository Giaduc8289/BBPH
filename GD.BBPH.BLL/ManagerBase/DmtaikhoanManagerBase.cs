


/*
'===============================================================================
'  GD.BBPH.BL.DmtaikhoanManagerBase
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
	public class DmtaikhoanManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Matk="Matk";				
		
		public const String Field_Tentk="Tentk";				
		
		public const String Field_Bactk="Bactk";				
		
		public const String Field_Tinhchattk="Tinhchattk";				
		
		public const String Field_Matkcha="Matkcha";				
		
		public const String Field_ChisoRgb="ChisoRgb";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmtaikhoanManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Matk,typeof(System.String));
			
			dt.Columns.Add(Field_Tentk,typeof(System.String));
			
			dt.Columns.Add(Field_Bactk,typeof(System.String));
			
			dt.Columns.Add(Field_Tinhchattk,typeof(System.String));
			
			dt.Columns.Add(Field_Matkcha,typeof(System.String));
			
			dt.Columns.Add(Field_ChisoRgb,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmtaikhoanEntity _DmtaikhoanEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Matk]=_DmtaikhoanEntity.Matk;
			}
			catch { }
			
			try
			{
				r[Field_Tentk]=_DmtaikhoanEntity.Tentk;
			}
			catch { }
			
			try
			{
				r[Field_Bactk]=_DmtaikhoanEntity.Bactk;
			}
			catch { }
			
			try
			{
				r[Field_Tinhchattk]=_DmtaikhoanEntity.Tinhchattk;
			}
			catch { }
			
			try
			{
				r[Field_Matkcha]=_DmtaikhoanEntity.Matkcha;
			}
			catch { }
			
			try
			{
				r[Field_ChisoRgb]=_DmtaikhoanEntity.ChisoRgb;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmtaikhoanEntity Convert(DataRow r)
		{	
			
			DmtaikhoanEntity _DmtaikhoanEntity=new DmtaikhoanEntity(r[Field_Matk].ToString());					
						
			
			
			try
			{
				_DmtaikhoanEntity.Tentk= r[Field_Tentk].ToString();						
			}
			catch { }
			
			try
			{
				_DmtaikhoanEntity.Bactk= r[Field_Bactk].ToString();						
			}
			catch { }
			
			try
			{
				_DmtaikhoanEntity.Tinhchattk= r[Field_Tinhchattk].ToString();						
			}
			catch { }
			
			try
			{
				_DmtaikhoanEntity.Matkcha= r[Field_Matkcha].ToString();						
			}
			catch { }
			
			try
			{
				_DmtaikhoanEntity.ChisoRgb= r[Field_ChisoRgb].ToString();						
			}
			catch { }
									
									
			return _DmtaikhoanEntity;
		}			
		
		public DmtaikhoanEntity Convert_Entity(DmtaikhoanEntity _DmtaikhoanEntity,DmtaikhoanEntity _DmtaikhoanEntity_XML)
		{	
			
			
			_DmtaikhoanEntity.Matk= _DmtaikhoanEntity_XML.Matk;
			
			_DmtaikhoanEntity.Tentk= _DmtaikhoanEntity_XML.Tentk;
			
			_DmtaikhoanEntity.Bactk= _DmtaikhoanEntity_XML.Bactk;
			
			_DmtaikhoanEntity.Tinhchattk= _DmtaikhoanEntity_XML.Tinhchattk;
			
			_DmtaikhoanEntity.Matkcha= _DmtaikhoanEntity_XML.Matkcha;
			
			_DmtaikhoanEntity.ChisoRgb= _DmtaikhoanEntity_XML.ChisoRgb;
									
				
			return _DmtaikhoanEntity;
		}	
		
		public String InsertV2(DmtaikhoanEntity _DmtaikhoanEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmtaikhoanManagerBase()).Insert(_DmtaikhoanEntity).Matk.ToString();
			
			
			try
			{
				r.SetField(Field_Matk,_DmtaikhoanEntity.Matk);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tentk,_DmtaikhoanEntity.Tentk);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Bactk,_DmtaikhoanEntity.Bactk);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tinhchattk,_DmtaikhoanEntity.Tinhchattk);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Matkcha,_DmtaikhoanEntity.Matkcha);
			}
			catch { }
			
			try
			{
				r.SetField(Field_ChisoRgb,_DmtaikhoanEntity.ChisoRgb);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmtaikhoanEntity _DmtaikhoanEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmtaikhoanManagerBase()).Update(_DmtaikhoanEntity);
			r.SetField(Field_Matk,_DmtaikhoanEntity.Matk);
									
			
			
			
			try
			{
				r.SetField(Field_Tentk,_DmtaikhoanEntity.Tentk);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Bactk,_DmtaikhoanEntity.Bactk);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tinhchattk,_DmtaikhoanEntity.Tinhchattk);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Matkcha,_DmtaikhoanEntity.Matkcha);
			}
			catch { }
			
			try
			{
				r.SetField(Field_ChisoRgb,_DmtaikhoanEntity.ChisoRgb);
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

		public DmtaikhoanEntity Insert(DmtaikhoanEntity DmtaikhoanEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmtaikhoanEntity, true);
			}
			return DmtaikhoanEntity;
		}

		public DmtaikhoanEntity Insert(System.String  Matk, System.String  Tentk, System.String  Bactk, System.String  Tinhchattk, System.String  Matkcha, System.String  ChisoRgb)
		{
			DmtaikhoanEntity _DmtaikhoanEntity = new DmtaikhoanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmtaikhoanEntity.Matk = Matk;
				
				_DmtaikhoanEntity.Tentk = Tentk;
				
				_DmtaikhoanEntity.Bactk = Bactk;
				
				_DmtaikhoanEntity.Tinhchattk = Tinhchattk;
				
				_DmtaikhoanEntity.Matkcha = Matkcha;
				
				_DmtaikhoanEntity.ChisoRgb = ChisoRgb;
					
					
				adapter.SaveEntity(_DmtaikhoanEntity, true);
			}
			return _DmtaikhoanEntity;
		}

		public DmtaikhoanEntity Insert(System.String Tentk, System.String Bactk, System.String Tinhchattk, System.String Matkcha, System.String ChisoRgb)//ko co mahieu
		{
			DmtaikhoanEntity _DmtaikhoanEntity = new DmtaikhoanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmtaikhoanEntity.Tentk = Tentk;
				
				_DmtaikhoanEntity.Bactk = Bactk;
				
				_DmtaikhoanEntity.Tinhchattk = Tinhchattk;
				
				_DmtaikhoanEntity.Matkcha = Matkcha;
				
				_DmtaikhoanEntity.ChisoRgb = ChisoRgb;
					

				adapter.SaveEntity(_DmtaikhoanEntity, true);
			}
			return _DmtaikhoanEntity;
		}

		public bool Update(DmtaikhoanEntity _DmtaikhoanEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmtaikhoanFields.Matk == _DmtaikhoanEntity.Matk);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmtaikhoanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmtaikhoanEntity _DmtaikhoanEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmtaikhoanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Matk, System.String Tentk, System.String Bactk, System.String Tinhchattk, System.String Matkcha, System.String ChisoRgb)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmtaikhoanEntity _DmtaikhoanEntity = new DmtaikhoanEntity(Matk);
				if (adapter.FetchEntity(_DmtaikhoanEntity))
				{
				
					
					
					_DmtaikhoanEntity.Tentk = Tentk;
					
					_DmtaikhoanEntity.Bactk = Bactk;
					
					_DmtaikhoanEntity.Tinhchattk = Tinhchattk;
					
					_DmtaikhoanEntity.Matkcha = Matkcha;
					
					_DmtaikhoanEntity.ChisoRgb = ChisoRgb;
						

					adapter.SaveEntity(_DmtaikhoanEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Matk)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmtaikhoanEntity _DmtaikhoanEntity = new DmtaikhoanEntity(Matk);
				if (adapter.FetchEntity(_DmtaikhoanEntity))
				{
					adapter.DeleteEntity(_DmtaikhoanEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", null);
			}
		}
		
		
		
		public int DeleteByMatk(System.String Matk)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Matk == Matk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTentk(System.String Tentk)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Tentk == Tentk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByBactk(System.String Bactk)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Bactk == Bactk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTinhchattk(System.String Tinhchattk)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Tinhchattk == Tinhchattk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMatkcha(System.String Matkcha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Matkcha == Matkcha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByChisoRgb(System.String ChisoRgb)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.ChisoRgb == ChisoRgb);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmtaikhoanEntity SelectOne(System.String Matk)
		{
			DmtaikhoanEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmtaikhoanEntity _DmtaikhoanEntity = new DmtaikhoanEntity(Matk);
				if (adapter.FetchEntity(_DmtaikhoanEntity))
				{
					toReturn = _DmtaikhoanEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection( new DmtaikhoanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, null, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMatk(System.String Matk)
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Matk == Matk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, filter, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		// Return DataTable
		public DataTable SelectByMatkRDT(System.String Matk)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Matk == Matk);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTentk(System.String Tentk)
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Tentk == Tentk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, filter, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		// Return DataTable
		public DataTable SelectByTentkRDT(System.String Tentk)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Tentk == Tentk);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByBactk(System.String Bactk)
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Bactk == Bactk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, filter, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		// Return DataTable
		public DataTable SelectByBactkRDT(System.String Bactk)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Bactk == Bactk);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTinhchattk(System.String Tinhchattk)
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Tinhchattk == Tinhchattk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, filter, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		// Return DataTable
		public DataTable SelectByTinhchattkRDT(System.String Tinhchattk)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Tinhchattk == Tinhchattk);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMatkcha(System.String Matkcha)
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Matkcha == Matkcha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, filter, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		// Return DataTable
		public DataTable SelectByMatkchaRDT(System.String Matkcha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Matkcha == Matkcha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByChisoRgb(System.String ChisoRgb)
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.ChisoRgb == ChisoRgb);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, filter, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		// Return DataTable
		public DataTable SelectByChisoRgbRDT(System.String ChisoRgb)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.ChisoRgb == ChisoRgb);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
