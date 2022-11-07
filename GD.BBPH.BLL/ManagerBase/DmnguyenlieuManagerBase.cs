


/*
'===============================================================================
'  GD.BBPH.BL.DmnguyenlieuManagerBase
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
	public class DmnguyenlieuManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Manl="Manl";				
		
		public const String Field_Tennl="Tennl";				
		
		public const String Field_Tenrutgon="Tenrutgon";				
		
		public const String Field_Manhom="Manhom";				
		
		public const String Field_Tennhom="Tennhom";				
		
		public const String Field_Gia="Gia";				
		
		public const String Field_Ngay="Ngay";				
		
		public const String Field_Giahientai="Giahientai";				
		
		public const String Field_Tang="Tang";				
		
		public const String Field_Giam="Giam";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmnguyenlieuManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Manl,typeof(System.String));
			
			dt.Columns.Add(Field_Tennl,typeof(System.String));
			
			dt.Columns.Add(Field_Tenrutgon,typeof(System.String));
			
			dt.Columns.Add(Field_Manhom,typeof(System.String));
			
			dt.Columns.Add(Field_Tennhom,typeof(System.String));
			
			dt.Columns.Add(Field_Gia,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngay,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Giahientai,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Tang,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Giam,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmnguyenlieuEntity _DmnguyenlieuEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_DmnguyenlieuEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Manl]=_DmnguyenlieuEntity.Manl;
			}
			catch { }
			
			try
			{
				r[Field_Tennl]=_DmnguyenlieuEntity.Tennl;
			}
			catch { }
			
			try
			{
				r[Field_Tenrutgon]=_DmnguyenlieuEntity.Tenrutgon;
			}
			catch { }
			
			try
			{
				r[Field_Manhom]=_DmnguyenlieuEntity.Manhom;
			}
			catch { }
			
			try
			{
				r[Field_Tennhom]=_DmnguyenlieuEntity.Tennhom;
			}
			catch { }
			
			try
			{
				r[Field_Gia]=_DmnguyenlieuEntity.Gia;
			}
			catch { }
			
			try
			{
				r[Field_Ngay]=_DmnguyenlieuEntity.Ngay;
			}
			catch { }
			
			try
			{
				r[Field_Giahientai]=_DmnguyenlieuEntity.Giahientai;
			}
			catch { }
			
			try
			{
				r[Field_Tang]=_DmnguyenlieuEntity.Tang;
			}
			catch { }
			
			try
			{
				r[Field_Giam]=_DmnguyenlieuEntity.Giam;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DmnguyenlieuEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DmnguyenlieuEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DmnguyenlieuEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DmnguyenlieuEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmnguyenlieuEntity Convert(DataRow r)
		{	
			
			DmnguyenlieuEntity _DmnguyenlieuEntity=new DmnguyenlieuEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_DmnguyenlieuEntity.Manl= r[Field_Manl].ToString();						
			}
			catch { }
			
			try
			{
				_DmnguyenlieuEntity.Tennl= r[Field_Tennl].ToString();						
			}
			catch { }
			
			try
			{
				_DmnguyenlieuEntity.Tenrutgon= r[Field_Tenrutgon].ToString();						
			}
			catch { }
			
			try
			{
				_DmnguyenlieuEntity.Manhom= r[Field_Manhom].ToString();						
			}
			catch { }
			
			try
			{
				_DmnguyenlieuEntity.Tennhom= r[Field_Tennhom].ToString();						
			}
			catch { }
			
			try
			{
				_DmnguyenlieuEntity.Gia= System.Decimal.Parse(r[Field_Gia].ToString());						
			}
			catch { }
			
			try
			{
				_DmnguyenlieuEntity.Ngay= System.DateTime.Parse(r[Field_Ngay].ToString());						
			}
			catch { }
			
			try
			{
				_DmnguyenlieuEntity.Giahientai= System.Decimal.Parse(r[Field_Giahientai].ToString());						
			}
			catch { }
			
			try
			{
				_DmnguyenlieuEntity.Tang= System.Decimal.Parse(r[Field_Tang].ToString());						
			}
			catch { }
			
			try
			{
				_DmnguyenlieuEntity.Giam= System.Decimal.Parse(r[Field_Giam].ToString());						
			}
			catch { }
			
			try
			{
				_DmnguyenlieuEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DmnguyenlieuEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DmnguyenlieuEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DmnguyenlieuEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DmnguyenlieuEntity;
		}			
		
		public DmnguyenlieuEntity Convert_Entity(DmnguyenlieuEntity _DmnguyenlieuEntity,DmnguyenlieuEntity _DmnguyenlieuEntity_XML)
		{	
			
			
			_DmnguyenlieuEntity.Id= _DmnguyenlieuEntity_XML.Id;
			
			_DmnguyenlieuEntity.Manl= _DmnguyenlieuEntity_XML.Manl;
			
			_DmnguyenlieuEntity.Tennl= _DmnguyenlieuEntity_XML.Tennl;
			
			_DmnguyenlieuEntity.Tenrutgon= _DmnguyenlieuEntity_XML.Tenrutgon;
			
			_DmnguyenlieuEntity.Manhom= _DmnguyenlieuEntity_XML.Manhom;
			
			_DmnguyenlieuEntity.Tennhom= _DmnguyenlieuEntity_XML.Tennhom;
			
			_DmnguyenlieuEntity.Gia= _DmnguyenlieuEntity_XML.Gia;
			
			_DmnguyenlieuEntity.Ngay= _DmnguyenlieuEntity_XML.Ngay;
			
			_DmnguyenlieuEntity.Giahientai= _DmnguyenlieuEntity_XML.Giahientai;
			
			_DmnguyenlieuEntity.Tang= _DmnguyenlieuEntity_XML.Tang;
			
			_DmnguyenlieuEntity.Giam= _DmnguyenlieuEntity_XML.Giam;
			
			_DmnguyenlieuEntity.Ngaytao= _DmnguyenlieuEntity_XML.Ngaytao;
			
			_DmnguyenlieuEntity.Nguoitao= _DmnguyenlieuEntity_XML.Nguoitao;
			
			_DmnguyenlieuEntity.Ngaysua= _DmnguyenlieuEntity_XML.Ngaysua;
			
			_DmnguyenlieuEntity.Nguoisua= _DmnguyenlieuEntity_XML.Nguoisua;
									
				
			return _DmnguyenlieuEntity;
		}	
		
		public String InsertV2(DmnguyenlieuEntity _DmnguyenlieuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmnguyenlieuManagerBase()).Insert(_DmnguyenlieuEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_DmnguyenlieuEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Manl,_DmnguyenlieuEntity.Manl);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennl,_DmnguyenlieuEntity.Tennl);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DmnguyenlieuEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manhom,_DmnguyenlieuEntity.Manhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennhom,_DmnguyenlieuEntity.Tennhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Gia,_DmnguyenlieuEntity.Gia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngay,_DmnguyenlieuEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Giahientai,_DmnguyenlieuEntity.Giahientai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tang,_DmnguyenlieuEntity.Tang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Giam,_DmnguyenlieuEntity.Giam);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmnguyenlieuEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmnguyenlieuEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmnguyenlieuEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmnguyenlieuEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmnguyenlieuEntity _DmnguyenlieuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmnguyenlieuManagerBase()).Update(_DmnguyenlieuEntity);
			r.SetField(Field_Id,_DmnguyenlieuEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Manl,_DmnguyenlieuEntity.Manl);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennl,_DmnguyenlieuEntity.Tennl);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DmnguyenlieuEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manhom,_DmnguyenlieuEntity.Manhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennhom,_DmnguyenlieuEntity.Tennhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Gia,_DmnguyenlieuEntity.Gia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngay,_DmnguyenlieuEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Giahientai,_DmnguyenlieuEntity.Giahientai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tang,_DmnguyenlieuEntity.Tang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Giam,_DmnguyenlieuEntity.Giam);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmnguyenlieuEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmnguyenlieuEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmnguyenlieuEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmnguyenlieuEntity.Nguoisua);
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

		public DmnguyenlieuEntity Insert(DmnguyenlieuEntity DmnguyenlieuEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmnguyenlieuEntity, true);
			}
			return DmnguyenlieuEntity;
		}

		public DmnguyenlieuEntity Insert(System.Int64  Id, System.String  Manl, System.String  Tennl, System.String  Tenrutgon, System.String  Manhom, System.String  Tennhom, System.Decimal  Gia, System.DateTime  Ngay, System.Decimal  Giahientai, System.Decimal  Tang, System.Decimal  Giam, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmnguyenlieuEntity.Id = Id;
				
				_DmnguyenlieuEntity.Manl = Manl;
				
				_DmnguyenlieuEntity.Tennl = Tennl;
				
				_DmnguyenlieuEntity.Tenrutgon = Tenrutgon;
				
				_DmnguyenlieuEntity.Manhom = Manhom;
				
				_DmnguyenlieuEntity.Tennhom = Tennhom;
				
				_DmnguyenlieuEntity.Gia = Gia;
				
				_DmnguyenlieuEntity.Ngay = Ngay;
				
				_DmnguyenlieuEntity.Giahientai = Giahientai;
				
				_DmnguyenlieuEntity.Tang = Tang;
				
				_DmnguyenlieuEntity.Giam = Giam;
				
				_DmnguyenlieuEntity.Ngaytao = Ngaytao;
				
				_DmnguyenlieuEntity.Nguoitao = Nguoitao;
				
				_DmnguyenlieuEntity.Ngaysua = Ngaysua;
				
				_DmnguyenlieuEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DmnguyenlieuEntity, true);
			}
			return _DmnguyenlieuEntity;
		}

		public DmnguyenlieuEntity Insert(System.String Manl, System.String Tennl, System.String Tenrutgon, System.String Manhom, System.String Tennhom, System.Decimal Gia, System.DateTime Ngay, System.Decimal Giahientai, System.Decimal Tang, System.Decimal Giam, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmnguyenlieuEntity.Manl = Manl;
				
				_DmnguyenlieuEntity.Tennl = Tennl;
				
				_DmnguyenlieuEntity.Tenrutgon = Tenrutgon;
				
				_DmnguyenlieuEntity.Manhom = Manhom;
				
				_DmnguyenlieuEntity.Tennhom = Tennhom;
				
				_DmnguyenlieuEntity.Gia = Gia;
				
				_DmnguyenlieuEntity.Ngay = Ngay;
				
				_DmnguyenlieuEntity.Giahientai = Giahientai;
				
				_DmnguyenlieuEntity.Tang = Tang;
				
				_DmnguyenlieuEntity.Giam = Giam;
				
				_DmnguyenlieuEntity.Ngaytao = Ngaytao;
				
				_DmnguyenlieuEntity.Nguoitao = Nguoitao;
				
				_DmnguyenlieuEntity.Ngaysua = Ngaysua;
				
				_DmnguyenlieuEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DmnguyenlieuEntity, true);
			}
			return _DmnguyenlieuEntity;
		}

		public bool Update(DmnguyenlieuEntity _DmnguyenlieuEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmnguyenlieuFields.Id == _DmnguyenlieuEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmnguyenlieuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmnguyenlieuEntity _DmnguyenlieuEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmnguyenlieuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Manl, System.String Tennl, System.String Tenrutgon, System.String Manhom, System.String Tennhom, System.Decimal Gia, System.DateTime Ngay, System.Decimal Giahientai, System.Decimal Tang, System.Decimal Giam, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity(Id);
				if (adapter.FetchEntity(_DmnguyenlieuEntity))
				{
				
					
					
					_DmnguyenlieuEntity.Manl = Manl;
					
					_DmnguyenlieuEntity.Tennl = Tennl;
					
					_DmnguyenlieuEntity.Tenrutgon = Tenrutgon;
					
					_DmnguyenlieuEntity.Manhom = Manhom;
					
					_DmnguyenlieuEntity.Tennhom = Tennhom;
					
					_DmnguyenlieuEntity.Gia = Gia;
					
					_DmnguyenlieuEntity.Ngay = Ngay;
					
					_DmnguyenlieuEntity.Giahientai = Giahientai;
					
					_DmnguyenlieuEntity.Tang = Tang;
					
					_DmnguyenlieuEntity.Giam = Giam;
					
					_DmnguyenlieuEntity.Ngaytao = Ngaytao;
					
					_DmnguyenlieuEntity.Nguoitao = Nguoitao;
					
					_DmnguyenlieuEntity.Ngaysua = Ngaysua;
					
					_DmnguyenlieuEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DmnguyenlieuEntity, true);
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
				DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity(Id);
				if (adapter.FetchEntity(_DmnguyenlieuEntity))
				{
					adapter.DeleteEntity(_DmnguyenlieuEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByManl(System.String Manl)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Manl == Manl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennl(System.String Tennl)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Tennl == Tennl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenrutgon(System.String Tenrutgon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByManhom(System.String Manhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennhom(System.String Tennhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByGia(System.Decimal Gia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Gia == Gia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgay(System.DateTime Ngay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByGiahientai(System.Decimal Giahientai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Giahientai == Giahientai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTang(System.Decimal Tang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Tang == Tang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByGiam(System.Decimal Giam)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Giam == Giam);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmnguyenlieuEntity SelectOne(System.Int64 Id)
		{
			DmnguyenlieuEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity(Id);
				if (adapter.FetchEntity(_DmnguyenlieuEntity))
				{
					toReturn = _DmnguyenlieuEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection( new DmnguyenlieuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, null, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByManl(System.String Manl)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Manl == Manl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByManlRDT(System.String Manl)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Manl == Manl);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennl(System.String Tennl)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Tennl == Tennl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByTennlRDT(System.String Tennl)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Tennl == Tennl);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenrutgon(System.String Tenrutgon)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByTenrutgonRDT(System.String Tenrutgon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByManhom(System.String Manhom)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByManhomRDT(System.String Manhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennhom(System.String Tennhom)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByTennhomRDT(System.String Tennhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByGia(System.Decimal Gia)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Gia == Gia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByGiaRDT(System.Decimal Gia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Gia == Gia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgay(System.DateTime Ngay)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayRDT(System.DateTime Ngay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByGiahientai(System.Decimal Giahientai)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Giahientai == Giahientai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByGiahientaiRDT(System.Decimal Giahientai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Giahientai == Giahientai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTang(System.Decimal Tang)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Tang == Tang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByTangRDT(System.Decimal Tang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Tang == Tang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByGiam(System.Decimal Giam)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Giam == Giam);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByGiamRDT(System.Decimal Giam)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Giam == Giam);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
