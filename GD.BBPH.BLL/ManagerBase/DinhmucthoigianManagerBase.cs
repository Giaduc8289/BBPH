


/*
'===============================================================================
'  GD.BBPH.BL.DinhmucthoigianManagerBase
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
	public class DinhmucthoigianManagerBase
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
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DinhmucthoigianManagerBase()
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
			
			dt.Columns.Add(Field_Dauca,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Doilenh,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Lencuon,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Xuongcuon,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thaythietbi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dungmay,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DinhmucthoigianEntity _DinhmucthoigianEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Madmtg]=_DinhmucthoigianEntity.Madmtg;
			}
			catch { }
			
			try
			{
				r[Field_Tendinhmuc]=_DinhmucthoigianEntity.Tendinhmuc;
			}
			catch { }
			
			try
			{
				r[Field_Mamay]=_DinhmucthoigianEntity.Mamay;
			}
			catch { }
			
			try
			{
				r[Field_Madm]=_DinhmucthoigianEntity.Madm;
			}
			catch { }
			
			try
			{
				r[Field_Dauca]=_DinhmucthoigianEntity.Dauca;
			}
			catch { }
			
			try
			{
				r[Field_Doilenh]=_DinhmucthoigianEntity.Doilenh;
			}
			catch { }
			
			try
			{
				r[Field_Lencuon]=_DinhmucthoigianEntity.Lencuon;
			}
			catch { }
			
			try
			{
				r[Field_Xuongcuon]=_DinhmucthoigianEntity.Xuongcuon;
			}
			catch { }
			
			try
			{
				r[Field_Thaythietbi]=_DinhmucthoigianEntity.Thaythietbi;
			}
			catch { }
			
			try
			{
				r[Field_Dungmay]=_DinhmucthoigianEntity.Dungmay;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DinhmucthoigianEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DinhmucthoigianEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DinhmucthoigianEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DinhmucthoigianEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DinhmucthoigianEntity Convert(DataRow r)
		{	
			
			DinhmucthoigianEntity _DinhmucthoigianEntity=new DinhmucthoigianEntity(r[Field_Madmtg].ToString());					
						
			
			
			try
			{
				_DinhmucthoigianEntity.Tendinhmuc= r[Field_Tendinhmuc].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Mamay= r[Field_Mamay].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Madm= r[Field_Madm].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Dauca= System.Decimal.Parse(r[Field_Dauca].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Doilenh= System.Decimal.Parse(r[Field_Doilenh].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Lencuon= System.Decimal.Parse(r[Field_Lencuon].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Xuongcuon= System.Decimal.Parse(r[Field_Xuongcuon].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Thaythietbi= System.Decimal.Parse(r[Field_Thaythietbi].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Dungmay= System.Decimal.Parse(r[Field_Dungmay].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DinhmucthoigianEntity;
		}			
		
		public DinhmucthoigianEntity Convert_Entity(DinhmucthoigianEntity _DinhmucthoigianEntity,DinhmucthoigianEntity _DinhmucthoigianEntity_XML)
		{	
			
			
			_DinhmucthoigianEntity.Madmtg= _DinhmucthoigianEntity_XML.Madmtg;
			
			_DinhmucthoigianEntity.Tendinhmuc= _DinhmucthoigianEntity_XML.Tendinhmuc;
			
			_DinhmucthoigianEntity.Mamay= _DinhmucthoigianEntity_XML.Mamay;
			
			_DinhmucthoigianEntity.Madm= _DinhmucthoigianEntity_XML.Madm;
			
			_DinhmucthoigianEntity.Dauca= _DinhmucthoigianEntity_XML.Dauca;
			
			_DinhmucthoigianEntity.Doilenh= _DinhmucthoigianEntity_XML.Doilenh;
			
			_DinhmucthoigianEntity.Lencuon= _DinhmucthoigianEntity_XML.Lencuon;
			
			_DinhmucthoigianEntity.Xuongcuon= _DinhmucthoigianEntity_XML.Xuongcuon;
			
			_DinhmucthoigianEntity.Thaythietbi= _DinhmucthoigianEntity_XML.Thaythietbi;
			
			_DinhmucthoigianEntity.Dungmay= _DinhmucthoigianEntity_XML.Dungmay;
			
			_DinhmucthoigianEntity.Ngaytao= _DinhmucthoigianEntity_XML.Ngaytao;
			
			_DinhmucthoigianEntity.Nguoitao= _DinhmucthoigianEntity_XML.Nguoitao;
			
			_DinhmucthoigianEntity.Ngaysua= _DinhmucthoigianEntity_XML.Ngaysua;
			
			_DinhmucthoigianEntity.Nguoisua= _DinhmucthoigianEntity_XML.Nguoisua;
									
				
			return _DinhmucthoigianEntity;
		}	
		
		public String InsertV2(DinhmucthoigianEntity _DinhmucthoigianEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DinhmucthoigianManagerBase()).Insert(_DinhmucthoigianEntity).Madmtg.ToString();
			
			
			try
			{
				r.SetField(Field_Madmtg,_DinhmucthoigianEntity.Madmtg);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tendinhmuc,_DinhmucthoigianEntity.Tendinhmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_DinhmucthoigianEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madm,_DinhmucthoigianEntity.Madm);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dauca,_DinhmucthoigianEntity.Dauca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Doilenh,_DinhmucthoigianEntity.Doilenh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lencuon,_DinhmucthoigianEntity.Lencuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Xuongcuon,_DinhmucthoigianEntity.Xuongcuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thaythietbi,_DinhmucthoigianEntity.Thaythietbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dungmay,_DinhmucthoigianEntity.Dungmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DinhmucthoigianEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DinhmucthoigianEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DinhmucthoigianEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DinhmucthoigianEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DinhmucthoigianEntity _DinhmucthoigianEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DinhmucthoigianManagerBase()).Update(_DinhmucthoigianEntity);
			r.SetField(Field_Madmtg,_DinhmucthoigianEntity.Madmtg);
									
			
			
			
			try
			{
				r.SetField(Field_Tendinhmuc,_DinhmucthoigianEntity.Tendinhmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_DinhmucthoigianEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madm,_DinhmucthoigianEntity.Madm);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dauca,_DinhmucthoigianEntity.Dauca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Doilenh,_DinhmucthoigianEntity.Doilenh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lencuon,_DinhmucthoigianEntity.Lencuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Xuongcuon,_DinhmucthoigianEntity.Xuongcuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thaythietbi,_DinhmucthoigianEntity.Thaythietbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dungmay,_DinhmucthoigianEntity.Dungmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DinhmucthoigianEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DinhmucthoigianEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DinhmucthoigianEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DinhmucthoigianEntity.Nguoisua);
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

		public DinhmucthoigianEntity Insert(DinhmucthoigianEntity DinhmucthoigianEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DinhmucthoigianEntity, true);
			}
			return DinhmucthoigianEntity;
		}

		public DinhmucthoigianEntity Insert(System.String  Madmtg, System.String  Tendinhmuc, System.String  Mamay, System.String  Madm, System.Decimal  Dauca, System.Decimal  Doilenh, System.Decimal  Lencuon, System.Decimal  Xuongcuon, System.Decimal  Thaythietbi, System.Decimal  Dungmay, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DinhmucthoigianEntity _DinhmucthoigianEntity = new DinhmucthoigianEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DinhmucthoigianEntity.Madmtg = Madmtg;
				
				_DinhmucthoigianEntity.Tendinhmuc = Tendinhmuc;
				
				_DinhmucthoigianEntity.Mamay = Mamay;
				
				_DinhmucthoigianEntity.Madm = Madm;
				
				_DinhmucthoigianEntity.Dauca = Dauca;
				
				_DinhmucthoigianEntity.Doilenh = Doilenh;
				
				_DinhmucthoigianEntity.Lencuon = Lencuon;
				
				_DinhmucthoigianEntity.Xuongcuon = Xuongcuon;
				
				_DinhmucthoigianEntity.Thaythietbi = Thaythietbi;
				
				_DinhmucthoigianEntity.Dungmay = Dungmay;
				
				_DinhmucthoigianEntity.Ngaytao = Ngaytao;
				
				_DinhmucthoigianEntity.Nguoitao = Nguoitao;
				
				_DinhmucthoigianEntity.Ngaysua = Ngaysua;
				
				_DinhmucthoigianEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DinhmucthoigianEntity, true);
			}
			return _DinhmucthoigianEntity;
		}

		public DinhmucthoigianEntity Insert(System.String Tendinhmuc, System.String Mamay, System.String Madm, System.Decimal Dauca, System.Decimal Doilenh, System.Decimal Lencuon, System.Decimal Xuongcuon, System.Decimal Thaythietbi, System.Decimal Dungmay, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DinhmucthoigianEntity _DinhmucthoigianEntity = new DinhmucthoigianEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DinhmucthoigianEntity.Tendinhmuc = Tendinhmuc;
				
				_DinhmucthoigianEntity.Mamay = Mamay;
				
				_DinhmucthoigianEntity.Madm = Madm;
				
				_DinhmucthoigianEntity.Dauca = Dauca;
				
				_DinhmucthoigianEntity.Doilenh = Doilenh;
				
				_DinhmucthoigianEntity.Lencuon = Lencuon;
				
				_DinhmucthoigianEntity.Xuongcuon = Xuongcuon;
				
				_DinhmucthoigianEntity.Thaythietbi = Thaythietbi;
				
				_DinhmucthoigianEntity.Dungmay = Dungmay;
				
				_DinhmucthoigianEntity.Ngaytao = Ngaytao;
				
				_DinhmucthoigianEntity.Nguoitao = Nguoitao;
				
				_DinhmucthoigianEntity.Ngaysua = Ngaysua;
				
				_DinhmucthoigianEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DinhmucthoigianEntity, true);
			}
			return _DinhmucthoigianEntity;
		}

		public bool Update(DinhmucthoigianEntity _DinhmucthoigianEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DinhmucthoigianFields.Madmtg == _DinhmucthoigianEntity.Madmtg);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DinhmucthoigianEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DinhmucthoigianEntity _DinhmucthoigianEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DinhmucthoigianEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Madmtg, System.String Tendinhmuc, System.String Mamay, System.String Madm, System.Decimal Dauca, System.Decimal Doilenh, System.Decimal Lencuon, System.Decimal Xuongcuon, System.Decimal Thaythietbi, System.Decimal Dungmay, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DinhmucthoigianEntity _DinhmucthoigianEntity = new DinhmucthoigianEntity(Madmtg);
				if (adapter.FetchEntity(_DinhmucthoigianEntity))
				{
				
					
					
					_DinhmucthoigianEntity.Tendinhmuc = Tendinhmuc;
					
					_DinhmucthoigianEntity.Mamay = Mamay;
					
					_DinhmucthoigianEntity.Madm = Madm;
					
					_DinhmucthoigianEntity.Dauca = Dauca;
					
					_DinhmucthoigianEntity.Doilenh = Doilenh;
					
					_DinhmucthoigianEntity.Lencuon = Lencuon;
					
					_DinhmucthoigianEntity.Xuongcuon = Xuongcuon;
					
					_DinhmucthoigianEntity.Thaythietbi = Thaythietbi;
					
					_DinhmucthoigianEntity.Dungmay = Dungmay;
					
					_DinhmucthoigianEntity.Ngaytao = Ngaytao;
					
					_DinhmucthoigianEntity.Nguoitao = Nguoitao;
					
					_DinhmucthoigianEntity.Ngaysua = Ngaysua;
					
					_DinhmucthoigianEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DinhmucthoigianEntity, true);
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
				DinhmucthoigianEntity _DinhmucthoigianEntity = new DinhmucthoigianEntity(Madmtg);
				if (adapter.FetchEntity(_DinhmucthoigianEntity))
				{
					adapter.DeleteEntity(_DinhmucthoigianEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", null);
			}
		}
		
		
		
		public int DeleteByMadmtg(System.String Madmtg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Madmtg == Madmtg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTendinhmuc(System.String Tendinhmuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Tendinhmuc == Tendinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamay(System.String Mamay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMadm(System.String Madm)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Madm == Madm);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDauca(System.Decimal Dauca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Dauca == Dauca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDoilenh(System.Decimal Doilenh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Doilenh == Doilenh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLencuon(System.Decimal Lencuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Lencuon == Lencuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByXuongcuon(System.Decimal Xuongcuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Xuongcuon == Xuongcuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThaythietbi(System.Decimal Thaythietbi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Thaythietbi == Thaythietbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDungmay(System.Decimal Dungmay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Dungmay == Dungmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DinhmucthoigianEntity SelectOne(System.String Madmtg)
		{
			DinhmucthoigianEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DinhmucthoigianEntity _DinhmucthoigianEntity = new DinhmucthoigianEntity(Madmtg);
				if (adapter.FetchEntity(_DinhmucthoigianEntity))
				{
					toReturn = _DinhmucthoigianEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection( new DinhmucthoigianEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, null, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMadmtg(System.String Madmtg)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Madmtg == Madmtg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByMadmtgRDT(System.String Madmtg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Madmtg == Madmtg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTendinhmuc(System.String Tendinhmuc)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Tendinhmuc == Tendinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByTendinhmucRDT(System.String Tendinhmuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Tendinhmuc == Tendinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamay(System.String Mamay)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByMamayRDT(System.String Mamay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMadm(System.String Madm)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Madm == Madm);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByMadmRDT(System.String Madm)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Madm == Madm);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDauca(System.Decimal Dauca)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Dauca == Dauca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByDaucaRDT(System.Decimal Dauca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Dauca == Dauca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDoilenh(System.Decimal Doilenh)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Doilenh == Doilenh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByDoilenhRDT(System.Decimal Doilenh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Doilenh == Doilenh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLencuon(System.Decimal Lencuon)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Lencuon == Lencuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByLencuonRDT(System.Decimal Lencuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Lencuon == Lencuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByXuongcuon(System.Decimal Xuongcuon)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Xuongcuon == Xuongcuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByXuongcuonRDT(System.Decimal Xuongcuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Xuongcuon == Xuongcuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThaythietbi(System.Decimal Thaythietbi)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Thaythietbi == Thaythietbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByThaythietbiRDT(System.Decimal Thaythietbi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Thaythietbi == Thaythietbi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDungmay(System.Decimal Dungmay)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Dungmay == Dungmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByDungmayRDT(System.Decimal Dungmay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Dungmay == Dungmay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
