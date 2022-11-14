﻿


/*
'===============================================================================
'  GD.BBPH.BL.DmmauManagerBase
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
	public class DmmauManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Mamau="Mamau";				
		
		public const String Field_Tenmau="Tenmau";				
		
		public const String Field_Lamaugoc="Lamaugoc";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
		public const String Field_MaArgb="MaArgb";				
		
		public const String Field_Ghichu="Ghichu";				
		
		public const String Field_Kyhieu="Kyhieu";				
		
		public const String Field_Masanphams="Masanphams";				
		
		public const String Field_Tensanphams="Tensanphams";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmmauManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Mamau,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmau,typeof(System.String));
			
			dt.Columns.Add(Field_Lamaugoc,typeof(System.Boolean));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
			
			dt.Columns.Add(Field_MaArgb,typeof(System.Int64));
			
			dt.Columns.Add(Field_Ghichu,typeof(System.String));
			
			dt.Columns.Add(Field_Kyhieu,typeof(System.String));
			
			dt.Columns.Add(Field_Masanphams,typeof(System.String));
			
			dt.Columns.Add(Field_Tensanphams,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmmauEntity _DmmauEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Mamau]=_DmmauEntity.Mamau;
			}
			catch { }
			
			try
			{
				r[Field_Tenmau]=_DmmauEntity.Tenmau;
			}
			catch { }
			
			try
			{
				r[Field_Lamaugoc]=_DmmauEntity.Lamaugoc;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DmmauEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DmmauEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DmmauEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DmmauEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_MaArgb]=_DmmauEntity.MaArgb;
			}
			catch { }
			
			try
			{
				r[Field_Ghichu]=_DmmauEntity.Ghichu;
			}
			catch { }
			
			try
			{
				r[Field_Kyhieu]=_DmmauEntity.Kyhieu;
			}
			catch { }
			
			try
			{
				r[Field_Masanphams]=_DmmauEntity.Masanphams;
			}
			catch { }
			
			try
			{
				r[Field_Tensanphams]=_DmmauEntity.Tensanphams;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmmauEntity Convert(DataRow r)
		{	
			
			DmmauEntity _DmmauEntity=new DmmauEntity(r[Field_Mamau].ToString());					
						
			
			
			try
			{
				_DmmauEntity.Tenmau= r[Field_Tenmau].ToString();						
			}
			catch { }
			
			try
			{
				_DmmauEntity.Lamaugoc= System.Boolean.Parse(r[Field_Lamaugoc].ToString());						
			}
			catch { }
			
			try
			{
				_DmmauEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DmmauEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DmmauEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DmmauEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_DmmauEntity.MaArgb= System.Int64.Parse(r[Field_MaArgb].ToString());						
			}
			catch { }
			
			try
			{
				_DmmauEntity.Ghichu= r[Field_Ghichu].ToString();						
			}
			catch { }
			
			try
			{
				_DmmauEntity.Kyhieu= r[Field_Kyhieu].ToString();						
			}
			catch { }
			
			try
			{
				_DmmauEntity.Masanphams= r[Field_Masanphams].ToString();						
			}
			catch { }
			
			try
			{
				_DmmauEntity.Tensanphams= r[Field_Tensanphams].ToString();						
			}
			catch { }
									
									
			return _DmmauEntity;
		}			
		
		public DmmauEntity Convert_Entity(DmmauEntity _DmmauEntity,DmmauEntity _DmmauEntity_XML)
		{	
			
			
			_DmmauEntity.Mamau= _DmmauEntity_XML.Mamau;
			
			_DmmauEntity.Tenmau= _DmmauEntity_XML.Tenmau;
			
			_DmmauEntity.Lamaugoc= _DmmauEntity_XML.Lamaugoc;
			
			_DmmauEntity.Ngaytao= _DmmauEntity_XML.Ngaytao;
			
			_DmmauEntity.Nguoitao= _DmmauEntity_XML.Nguoitao;
			
			_DmmauEntity.Ngaysua= _DmmauEntity_XML.Ngaysua;
			
			_DmmauEntity.Nguoisua= _DmmauEntity_XML.Nguoisua;
			
			_DmmauEntity.MaArgb= _DmmauEntity_XML.MaArgb;
			
			_DmmauEntity.Ghichu= _DmmauEntity_XML.Ghichu;
			
			_DmmauEntity.Kyhieu= _DmmauEntity_XML.Kyhieu;
			
			_DmmauEntity.Masanphams= _DmmauEntity_XML.Masanphams;
			
			_DmmauEntity.Tensanphams= _DmmauEntity_XML.Tensanphams;
									
				
			return _DmmauEntity;
		}	
		
		public String InsertV2(DmmauEntity _DmmauEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmmauManagerBase()).Insert(_DmmauEntity).Mamau.ToString();
			
			
			try
			{
				r.SetField(Field_Mamau,_DmmauEntity.Mamau);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenmau,_DmmauEntity.Tenmau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lamaugoc,_DmmauEntity.Lamaugoc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmmauEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmmauEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmmauEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmmauEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_MaArgb,_DmmauEntity.MaArgb);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ghichu,_DmmauEntity.Ghichu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kyhieu,_DmmauEntity.Kyhieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanphams,_DmmauEntity.Masanphams);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanphams,_DmmauEntity.Tensanphams);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmmauEntity _DmmauEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmmauManagerBase()).Update(_DmmauEntity);
			r.SetField(Field_Mamau,_DmmauEntity.Mamau);
									
			
			
			
			try
			{
				r.SetField(Field_Tenmau,_DmmauEntity.Tenmau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lamaugoc,_DmmauEntity.Lamaugoc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmmauEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmmauEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmmauEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmmauEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_MaArgb,_DmmauEntity.MaArgb);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ghichu,_DmmauEntity.Ghichu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kyhieu,_DmmauEntity.Kyhieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanphams,_DmmauEntity.Masanphams);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanphams,_DmmauEntity.Tensanphams);
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

		public DmmauEntity Insert(DmmauEntity DmmauEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmmauEntity, true);
			}
			return DmmauEntity;
		}

		public DmmauEntity Insert(System.String  Mamau, System.String  Tenmau, System.Boolean  Lamaugoc, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.Int64  MaArgb, System.String  Ghichu, System.String  Kyhieu, System.String  Masanphams, System.String  Tensanphams)
		{
			DmmauEntity _DmmauEntity = new DmmauEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmmauEntity.Mamau = Mamau;
				
				_DmmauEntity.Tenmau = Tenmau;
				
				_DmmauEntity.Lamaugoc = Lamaugoc;
				
				_DmmauEntity.Ngaytao = Ngaytao;
				
				_DmmauEntity.Nguoitao = Nguoitao;
				
				_DmmauEntity.Ngaysua = Ngaysua;
				
				_DmmauEntity.Nguoisua = Nguoisua;
				
				_DmmauEntity.MaArgb = MaArgb;
				
				_DmmauEntity.Ghichu = Ghichu;
				
				_DmmauEntity.Kyhieu = Kyhieu;
				
				_DmmauEntity.Masanphams = Masanphams;
				
				_DmmauEntity.Tensanphams = Tensanphams;
					
					
				adapter.SaveEntity(_DmmauEntity, true);
			}
			return _DmmauEntity;
		}

		public DmmauEntity Insert(System.String Tenmau, System.Boolean Lamaugoc, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Int64 MaArgb, System.String Ghichu, System.String Kyhieu, System.String Masanphams, System.String Tensanphams)//ko co mahieu
		{
			DmmauEntity _DmmauEntity = new DmmauEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmmauEntity.Tenmau = Tenmau;
				
				_DmmauEntity.Lamaugoc = Lamaugoc;
				
				_DmmauEntity.Ngaytao = Ngaytao;
				
				_DmmauEntity.Nguoitao = Nguoitao;
				
				_DmmauEntity.Ngaysua = Ngaysua;
				
				_DmmauEntity.Nguoisua = Nguoisua;
				
				_DmmauEntity.MaArgb = MaArgb;
				
				_DmmauEntity.Ghichu = Ghichu;
				
				_DmmauEntity.Kyhieu = Kyhieu;
				
				_DmmauEntity.Masanphams = Masanphams;
				
				_DmmauEntity.Tensanphams = Tensanphams;
					

				adapter.SaveEntity(_DmmauEntity, true);
			}
			return _DmmauEntity;
		}

		public bool Update(DmmauEntity _DmmauEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmmauFields.Mamau == _DmmauEntity.Mamau);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmmauEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmmauEntity _DmmauEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmmauEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Mamau, System.String Tenmau, System.Boolean Lamaugoc, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Int64 MaArgb, System.String Ghichu, System.String Kyhieu, System.String Masanphams, System.String Tensanphams)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmmauEntity _DmmauEntity = new DmmauEntity(Mamau);
				if (adapter.FetchEntity(_DmmauEntity))
				{
				
					
					
					_DmmauEntity.Tenmau = Tenmau;
					
					_DmmauEntity.Lamaugoc = Lamaugoc;
					
					_DmmauEntity.Ngaytao = Ngaytao;
					
					_DmmauEntity.Nguoitao = Nguoitao;
					
					_DmmauEntity.Ngaysua = Ngaysua;
					
					_DmmauEntity.Nguoisua = Nguoisua;
					
					_DmmauEntity.MaArgb = MaArgb;
					
					_DmmauEntity.Ghichu = Ghichu;
					
					_DmmauEntity.Kyhieu = Kyhieu;
					
					_DmmauEntity.Masanphams = Masanphams;
					
					_DmmauEntity.Tensanphams = Tensanphams;
						

					adapter.SaveEntity(_DmmauEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Mamau)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmmauEntity _DmmauEntity = new DmmauEntity(Mamau);
				if (adapter.FetchEntity(_DmmauEntity))
				{
					adapter.DeleteEntity(_DmmauEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmmauEntity", null);
			}
		}
		
		
		
		public int DeleteByMamau(System.String Mamau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Mamau == Mamau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmau(System.String Tenmau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Tenmau == Tenmau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLamaugoc(System.Boolean Lamaugoc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Lamaugoc == Lamaugoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaArgb(System.Int64 MaArgb)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.MaArgb == MaArgb);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByGhichu(System.String Ghichu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKyhieu(System.String Kyhieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Kyhieu == Kyhieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasanphams(System.String Masanphams)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Masanphams == Masanphams);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensanphams(System.String Tensanphams)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Tensanphams == Tensanphams);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmauEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmmauEntity SelectOne(System.String Mamau)
		{
			DmmauEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmmauEntity _DmmauEntity = new DmmauEntity(Mamau);
				if (adapter.FetchEntity(_DmmauEntity))
				{
					toReturn = _DmmauEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmmauCollection = new EntityCollection( new DmmauEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmauCollection, null, 0, null);
			}
			return _DmmauCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmauCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMamau(System.String Mamau)
		{
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Mamau == Mamau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmauCollection, filter, 0, null);
			}
			return _DmmauCollection;
		}
		// Return DataTable
		public DataTable SelectByMamauRDT(System.String Mamau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Mamau == Mamau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmau(System.String Tenmau)
		{
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Tenmau == Tenmau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmauCollection, filter, 0, null);
			}
			return _DmmauCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmauRDT(System.String Tenmau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Tenmau == Tenmau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLamaugoc(System.Boolean Lamaugoc)
		{
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Lamaugoc == Lamaugoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmauCollection, filter, 0, null);
			}
			return _DmmauCollection;
		}
		// Return DataTable
		public DataTable SelectByLamaugocRDT(System.Boolean Lamaugoc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Lamaugoc == Lamaugoc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmauCollection, filter, 0, null);
			}
			return _DmmauCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmauCollection, filter, 0, null);
			}
			return _DmmauCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmauCollection, filter, 0, null);
			}
			return _DmmauCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmauCollection, filter, 0, null);
			}
			return _DmmauCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaArgb(System.Int64 MaArgb)
		{
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.MaArgb == MaArgb);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmauCollection, filter, 0, null);
			}
			return _DmmauCollection;
		}
		// Return DataTable
		public DataTable SelectByMaArgbRDT(System.Int64 MaArgb)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.MaArgb == MaArgb);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByGhichu(System.String Ghichu)
		{
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmauCollection, filter, 0, null);
			}
			return _DmmauCollection;
		}
		// Return DataTable
		public DataTable SelectByGhichuRDT(System.String Ghichu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKyhieu(System.String Kyhieu)
		{
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Kyhieu == Kyhieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmauCollection, filter, 0, null);
			}
			return _DmmauCollection;
		}
		// Return DataTable
		public DataTable SelectByKyhieuRDT(System.String Kyhieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Kyhieu == Kyhieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasanphams(System.String Masanphams)
		{
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Masanphams == Masanphams);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmauCollection, filter, 0, null);
			}
			return _DmmauCollection;
		}
		// Return DataTable
		public DataTable SelectByMasanphamsRDT(System.String Masanphams)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Masanphams == Masanphams);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensanphams(System.String Tensanphams)
		{
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Tensanphams == Tensanphams);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmauCollection, filter, 0, null);
			}
			return _DmmauCollection;
		}
		// Return DataTable
		public DataTable SelectByTensanphamsRDT(System.String Tensanphams)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmauCollection = new EntityCollection(new DmmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmauFields.Tensanphams == Tensanphams);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(DmmauFields.Mamau.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
