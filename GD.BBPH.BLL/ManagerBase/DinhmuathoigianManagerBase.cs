


/*
'===============================================================================
'  GD.BBPH.BL.DinhmuathoigianManagerBase
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
	public class DinhmuathoigianManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Madmtg="Madmtg";				
		
		public const String Field_Tendinhmuc="Tendinhmuc";				
		
		public const String Field_Mamay="Mamay";				
		
		public const String Field_Madm="Madm";				
		
		public const String Field_Dauca="Dauca";				
		
		public const String Field_Doilenh="Doilenh";				
		
		public const String Field_Lencuon="Lencuon";				
		
		public const String Field_Xuongcuon="Xuongcuon";				
		
		public const String Field_Thaythietbi="Thaythietbi";				
		
		public const String Field_Dungmay="Dungmay";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DinhmuathoigianManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Madmtg,typeof(System.String));
			
			dt.Columns.Add(Field_Tendinhmuc,typeof(System.String));
			
			dt.Columns.Add(Field_Mamay,typeof(System.String));
			
			dt.Columns.Add(Field_Madm,typeof(System.String));
			
			dt.Columns.Add(Field_Dauca,typeof(System.String));
			
			dt.Columns.Add(Field_Doilenh,typeof(System.String));
			
			dt.Columns.Add(Field_Lencuon,typeof(System.String));
			
			dt.Columns.Add(Field_Xuongcuon,typeof(System.String));
			
			dt.Columns.Add(Field_Thaythietbi,typeof(System.String));
			
			dt.Columns.Add(Field_Dungmay,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DinhmuathoigianEntity _DinhmuathoigianEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Madmtg]=_DinhmuathoigianEntity.Madmtg;
			}
			catch { }
			
			try
			{
				r[Field_Tendinhmuc]=_DinhmuathoigianEntity.Tendinhmuc;
			}
			catch { }
			
			try
			{
				r[Field_Mamay]=_DinhmuathoigianEntity.Mamay;
			}
			catch { }
			
			try
			{
				r[Field_Madm]=_DinhmuathoigianEntity.Madm;
			}
			catch { }
			
			try
			{
				r[Field_Dauca]=_DinhmuathoigianEntity.Dauca;
			}
			catch { }
			
			try
			{
				r[Field_Doilenh]=_DinhmuathoigianEntity.Doilenh;
			}
			catch { }
			
			try
			{
				r[Field_Lencuon]=_DinhmuathoigianEntity.Lencuon;
			}
			catch { }
			
			try
			{
				r[Field_Xuongcuon]=_DinhmuathoigianEntity.Xuongcuon;
			}
			catch { }
			
			try
			{
				r[Field_Thaythietbi]=_DinhmuathoigianEntity.Thaythietbi;
			}
			catch { }
			
			try
			{
				r[Field_Dungmay]=_DinhmuathoigianEntity.Dungmay;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DinhmuathoigianEntity Convert(DataRow r)
		{	
			
			DinhmuathoigianEntity _DinhmuathoigianEntity=new DinhmuathoigianEntity(r[Field_Madmtg].ToString());					
						
			
			
			try
			{
				_DinhmuathoigianEntity.Tendinhmuc= r[Field_Tendinhmuc].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmuathoigianEntity.Mamay= r[Field_Mamay].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmuathoigianEntity.Madm= r[Field_Madm].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmuathoigianEntity.Dauca= r[Field_Dauca].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmuathoigianEntity.Doilenh= r[Field_Doilenh].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmuathoigianEntity.Lencuon= r[Field_Lencuon].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmuathoigianEntity.Xuongcuon= r[Field_Xuongcuon].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmuathoigianEntity.Thaythietbi= r[Field_Thaythietbi].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmuathoigianEntity.Dungmay= r[Field_Dungmay].ToString();						
			}
			catch { }
									
									
			return _DinhmuathoigianEntity;
		}			
		
		public DinhmuathoigianEntity Convert_Entity(DinhmuathoigianEntity _DinhmuathoigianEntity,DinhmuathoigianEntity _DinhmuathoigianEntity_XML)
		{	
			
			
			_DinhmuathoigianEntity.Madmtg= _DinhmuathoigianEntity_XML.Madmtg;
			
			_DinhmuathoigianEntity.Tendinhmuc= _DinhmuathoigianEntity_XML.Tendinhmuc;
			
			_DinhmuathoigianEntity.Mamay= _DinhmuathoigianEntity_XML.Mamay;
			
			_DinhmuathoigianEntity.Madm= _DinhmuathoigianEntity_XML.Madm;
			
			_DinhmuathoigianEntity.Dauca= _DinhmuathoigianEntity_XML.Dauca;
			
			_DinhmuathoigianEntity.Doilenh= _DinhmuathoigianEntity_XML.Doilenh;
			
			_DinhmuathoigianEntity.Lencuon= _DinhmuathoigianEntity_XML.Lencuon;
			
			_DinhmuathoigianEntity.Xuongcuon= _DinhmuathoigianEntity_XML.Xuongcuon;
			
			_DinhmuathoigianEntity.Thaythietbi= _DinhmuathoigianEntity_XML.Thaythietbi;
			
			_DinhmuathoigianEntity.Dungmay= _DinhmuathoigianEntity_XML.Dungmay;
									
				
			return _DinhmuathoigianEntity;
		}	
		
		public String InsertV2(DinhmuathoigianEntity _DinhmuathoigianEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DinhmuathoigianManagerBase()).Insert(_DinhmuathoigianEntity).Madmtg.ToString();
			
			
			try
			{
				r.SetField(Field_Madmtg,_DinhmuathoigianEntity.Madmtg);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tendinhmuc,_DinhmuathoigianEntity.Tendinhmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_DinhmuathoigianEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madm,_DinhmuathoigianEntity.Madm);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dauca,_DinhmuathoigianEntity.Dauca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Doilenh,_DinhmuathoigianEntity.Doilenh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lencuon,_DinhmuathoigianEntity.Lencuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Xuongcuon,_DinhmuathoigianEntity.Xuongcuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thaythietbi,_DinhmuathoigianEntity.Thaythietbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dungmay,_DinhmuathoigianEntity.Dungmay);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DinhmuathoigianEntity _DinhmuathoigianEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DinhmuathoigianManagerBase()).Update(_DinhmuathoigianEntity);
			r.SetField(Field_Madmtg,_DinhmuathoigianEntity.Madmtg);
									
			
			
			
			try
			{
				r.SetField(Field_Tendinhmuc,_DinhmuathoigianEntity.Tendinhmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_DinhmuathoigianEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madm,_DinhmuathoigianEntity.Madm);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dauca,_DinhmuathoigianEntity.Dauca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Doilenh,_DinhmuathoigianEntity.Doilenh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lencuon,_DinhmuathoigianEntity.Lencuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Xuongcuon,_DinhmuathoigianEntity.Xuongcuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thaythietbi,_DinhmuathoigianEntity.Thaythietbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dungmay,_DinhmuathoigianEntity.Dungmay);
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

		public DinhmuathoigianEntity Insert(DinhmuathoigianEntity DinhmuathoigianEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DinhmuathoigianEntity, true);
			}
			return DinhmuathoigianEntity;
		}

		public DinhmuathoigianEntity Insert(System.String  Madmtg, System.String  Tendinhmuc, System.String  Mamay, System.String  Madm, System.String  Dauca, System.String  Doilenh, System.String  Lencuon, System.String  Xuongcuon, System.String  Thaythietbi, System.String  Dungmay)
		{
			DinhmuathoigianEntity _DinhmuathoigianEntity = new DinhmuathoigianEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DinhmuathoigianEntity.Madmtg = Madmtg;
				
				_DinhmuathoigianEntity.Tendinhmuc = Tendinhmuc;
				
				_DinhmuathoigianEntity.Mamay = Mamay;
				
				_DinhmuathoigianEntity.Madm = Madm;
				
				_DinhmuathoigianEntity.Dauca = Dauca;
				
				_DinhmuathoigianEntity.Doilenh = Doilenh;
				
				_DinhmuathoigianEntity.Lencuon = Lencuon;
				
				_DinhmuathoigianEntity.Xuongcuon = Xuongcuon;
				
				_DinhmuathoigianEntity.Thaythietbi = Thaythietbi;
				
				_DinhmuathoigianEntity.Dungmay = Dungmay;
					
					
				adapter.SaveEntity(_DinhmuathoigianEntity, true);
			}
			return _DinhmuathoigianEntity;
		}

		public DinhmuathoigianEntity Insert(System.String Tendinhmuc, System.String Mamay, System.String Madm, System.String Dauca, System.String Doilenh, System.String Lencuon, System.String Xuongcuon, System.String Thaythietbi, System.String Dungmay, )//ko co mahieu
		{
			DinhmuathoigianEntity _DinhmuathoigianEntity = new DinhmuathoigianEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DinhmuathoigianEntity.Tendinhmuc = Tendinhmuc;
				
				_DinhmuathoigianEntity.Mamay = Mamay;
				
				_DinhmuathoigianEntity.Madm = Madm;
				
				_DinhmuathoigianEntity.Dauca = Dauca;
				
				_DinhmuathoigianEntity.Doilenh = Doilenh;
				
				_DinhmuathoigianEntity.Lencuon = Lencuon;
				
				_DinhmuathoigianEntity.Xuongcuon = Xuongcuon;
				
				_DinhmuathoigianEntity.Thaythietbi = Thaythietbi;
				
				_DinhmuathoigianEntity.Dungmay = Dungmay;
					

				adapter.SaveEntity(_DinhmuathoigianEntity, true);
			}
			return _DinhmuathoigianEntity;
		}

		public bool Update(DinhmuathoigianEntity _DinhmuathoigianEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DinhmuathoigianFields.Madmtg == _DinhmuathoigianEntity.Madmtg);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DinhmuathoigianEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DinhmuathoigianEntity _DinhmuathoigianEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DinhmuathoigianEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Madmtg, System.String Tendinhmuc, System.String Mamay, System.String Madm, System.String Dauca, System.String Doilenh, System.String Lencuon, System.String Xuongcuon, System.String Thaythietbi, System.String Dungmay)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DinhmuathoigianEntity _DinhmuathoigianEntity = new DinhmuathoigianEntity(Madmtg);
				if (adapter.FetchEntity(_DinhmuathoigianEntity))
				{
				
					
					
					_DinhmuathoigianEntity.Tendinhmuc = Tendinhmuc;
					
					_DinhmuathoigianEntity.Mamay = Mamay;
					
					_DinhmuathoigianEntity.Madm = Madm;
					
					_DinhmuathoigianEntity.Dauca = Dauca;
					
					_DinhmuathoigianEntity.Doilenh = Doilenh;
					
					_DinhmuathoigianEntity.Lencuon = Lencuon;
					
					_DinhmuathoigianEntity.Xuongcuon = Xuongcuon;
					
					_DinhmuathoigianEntity.Thaythietbi = Thaythietbi;
					
					_DinhmuathoigianEntity.Dungmay = Dungmay;
						

					adapter.SaveEntity(_DinhmuathoigianEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Madmtg)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DinhmuathoigianEntity _DinhmuathoigianEntity = new DinhmuathoigianEntity(Madmtg);
				if (adapter.FetchEntity(_DinhmuathoigianEntity))
				{
					adapter.DeleteEntity(_DinhmuathoigianEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DinhmuathoigianEntity", null);
			}
		}
		
		
		
		public int DeleteByMadmtg(System.String Madmtg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Madmtg == Madmtg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuathoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTendinhmuc(System.String Tendinhmuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Tendinhmuc == Tendinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuathoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamay(System.String Mamay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuathoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMadm(System.String Madm)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Madm == Madm);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuathoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDauca(System.String Dauca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Dauca == Dauca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuathoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDoilenh(System.String Doilenh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Doilenh == Doilenh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuathoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLencuon(System.String Lencuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Lencuon == Lencuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuathoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByXuongcuon(System.String Xuongcuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Xuongcuon == Xuongcuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuathoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThaythietbi(System.String Thaythietbi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Thaythietbi == Thaythietbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuathoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDungmay(System.String Dungmay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Dungmay == Dungmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuathoigianEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DinhmuathoigianEntity SelectOne(System.String Madmtg)
		{
			DinhmuathoigianEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DinhmuathoigianEntity _DinhmuathoigianEntity = new DinhmuathoigianEntity(Madmtg);
				if (adapter.FetchEntity(_DinhmuathoigianEntity))
				{
					toReturn = _DinhmuathoigianEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DinhmuathoigianCollection = new EntityCollection( new DinhmuathoigianEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuathoigianCollection, null, 0, null);
			}
			return _DinhmuathoigianCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuathoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMadmtg(System.String Madmtg)
		{
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Madmtg == Madmtg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuathoigianCollection, filter, 0, null);
			}
			return _DinhmuathoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByMadmtgRDT(System.String Madmtg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Madmtg == Madmtg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuathoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTendinhmuc(System.String Tendinhmuc)
		{
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Tendinhmuc == Tendinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuathoigianCollection, filter, 0, null);
			}
			return _DinhmuathoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByTendinhmucRDT(System.String Tendinhmuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Tendinhmuc == Tendinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuathoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamay(System.String Mamay)
		{
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuathoigianCollection, filter, 0, null);
			}
			return _DinhmuathoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByMamayRDT(System.String Mamay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuathoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMadm(System.String Madm)
		{
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Madm == Madm);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuathoigianCollection, filter, 0, null);
			}
			return _DinhmuathoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByMadmRDT(System.String Madm)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Madm == Madm);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuathoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDauca(System.String Dauca)
		{
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Dauca == Dauca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuathoigianCollection, filter, 0, null);
			}
			return _DinhmuathoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByDaucaRDT(System.String Dauca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Dauca == Dauca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuathoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDoilenh(System.String Doilenh)
		{
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Doilenh == Doilenh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuathoigianCollection, filter, 0, null);
			}
			return _DinhmuathoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByDoilenhRDT(System.String Doilenh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Doilenh == Doilenh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuathoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLencuon(System.String Lencuon)
		{
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Lencuon == Lencuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuathoigianCollection, filter, 0, null);
			}
			return _DinhmuathoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByLencuonRDT(System.String Lencuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Lencuon == Lencuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuathoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByXuongcuon(System.String Xuongcuon)
		{
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Xuongcuon == Xuongcuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuathoigianCollection, filter, 0, null);
			}
			return _DinhmuathoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByXuongcuonRDT(System.String Xuongcuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Xuongcuon == Xuongcuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuathoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThaythietbi(System.String Thaythietbi)
		{
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Thaythietbi == Thaythietbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuathoigianCollection, filter, 0, null);
			}
			return _DinhmuathoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByThaythietbiRDT(System.String Thaythietbi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Thaythietbi == Thaythietbi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuathoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDungmay(System.String Dungmay)
		{
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Dungmay == Dungmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuathoigianCollection, filter, 0, null);
			}
			return _DinhmuathoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByDungmayRDT(System.String Dungmay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuathoigianCollection = new EntityCollection(new DinhmuathoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuathoigianFields.Dungmay == Dungmay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuathoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
