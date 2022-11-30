


/*
'===============================================================================
'  GD.BBPH.BL.KehoachthoiManagerBase
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
	public class KehoachthoiManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Solenhsx="Solenhsx";				
		
		public const String Field_Ngaydat="Ngaydat";				
		
		public const String Field_Ngaygiao="Ngaygiao";				
		
		public const String Field_Mamang="Mamang";				
		
		public const String Field_Mamay="Mamay";				
		
		public const String Field_Ngaychay="Ngaychay";				
		
		public const String Field_Ca="Ca";				
		
		public const String Field_Somet="Somet";				
		
		public const String Field_Sokg="Sokg";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KehoachthoiManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Solenhsx,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaydat,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Ngaygiao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Mamang,typeof(System.String));
			
			dt.Columns.Add(Field_Mamay,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaychay,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Ca,typeof(System.Int32));
			
			dt.Columns.Add(Field_Somet,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sokg,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(KehoachthoiEntity _KehoachthoiEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_KehoachthoiEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Solenhsx]=_KehoachthoiEntity.Solenhsx;
			}
			catch { }
			
			try
			{
				r[Field_Ngaydat]=_KehoachthoiEntity.Ngaydat;
			}
			catch { }
			
			try
			{
				r[Field_Ngaygiao]=_KehoachthoiEntity.Ngaygiao;
			}
			catch { }
			
			try
			{
				r[Field_Mamang]=_KehoachthoiEntity.Mamang;
			}
			catch { }
			
			try
			{
				r[Field_Mamay]=_KehoachthoiEntity.Mamay;
			}
			catch { }
			
			try
			{
				r[Field_Ngaychay]=_KehoachthoiEntity.Ngaychay;
			}
			catch { }
			
			try
			{
				r[Field_Ca]=_KehoachthoiEntity.Ca;
			}
			catch { }
			
			try
			{
				r[Field_Somet]=_KehoachthoiEntity.Somet;
			}
			catch { }
			
			try
			{
				r[Field_Sokg]=_KehoachthoiEntity.Sokg;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_KehoachthoiEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_KehoachthoiEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_KehoachthoiEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_KehoachthoiEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public KehoachthoiEntity Convert(DataRow r)
		{	
			
			KehoachthoiEntity _KehoachthoiEntity=new KehoachthoiEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_KehoachthoiEntity.Solenhsx= r[Field_Solenhsx].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachthoiEntity.Ngaydat= System.DateTime.Parse(r[Field_Ngaydat].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachthoiEntity.Ngaygiao= System.DateTime.Parse(r[Field_Ngaygiao].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachthoiEntity.Mamang= r[Field_Mamang].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachthoiEntity.Mamay= r[Field_Mamay].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachthoiEntity.Ngaychay= System.DateTime.Parse(r[Field_Ngaychay].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachthoiEntity.Ca= System.Int32.Parse(r[Field_Ca].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachthoiEntity.Somet= System.Decimal.Parse(r[Field_Somet].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachthoiEntity.Sokg= System.Decimal.Parse(r[Field_Sokg].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachthoiEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachthoiEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachthoiEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachthoiEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _KehoachthoiEntity;
		}			
		
		public KehoachthoiEntity Convert_Entity(KehoachthoiEntity _KehoachthoiEntity,KehoachthoiEntity _KehoachthoiEntity_XML)
		{	
			
			
			_KehoachthoiEntity.Id= _KehoachthoiEntity_XML.Id;
			
			_KehoachthoiEntity.Solenhsx= _KehoachthoiEntity_XML.Solenhsx;
			
			_KehoachthoiEntity.Ngaydat= _KehoachthoiEntity_XML.Ngaydat;
			
			_KehoachthoiEntity.Ngaygiao= _KehoachthoiEntity_XML.Ngaygiao;
			
			_KehoachthoiEntity.Mamang= _KehoachthoiEntity_XML.Mamang;
			
			_KehoachthoiEntity.Mamay= _KehoachthoiEntity_XML.Mamay;
			
			_KehoachthoiEntity.Ngaychay= _KehoachthoiEntity_XML.Ngaychay;
			
			_KehoachthoiEntity.Ca= _KehoachthoiEntity_XML.Ca;
			
			_KehoachthoiEntity.Somet= _KehoachthoiEntity_XML.Somet;
			
			_KehoachthoiEntity.Sokg= _KehoachthoiEntity_XML.Sokg;
			
			_KehoachthoiEntity.Ngaytao= _KehoachthoiEntity_XML.Ngaytao;
			
			_KehoachthoiEntity.Nguoitao= _KehoachthoiEntity_XML.Nguoitao;
			
			_KehoachthoiEntity.Ngaysua= _KehoachthoiEntity_XML.Ngaysua;
			
			_KehoachthoiEntity.Nguoisua= _KehoachthoiEntity_XML.Nguoisua;
									
				
			return _KehoachthoiEntity;
		}	
		
		public String InsertV2(KehoachthoiEntity _KehoachthoiEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new KehoachthoiManagerBase()).Insert(_KehoachthoiEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_KehoachthoiEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Solenhsx,_KehoachthoiEntity.Solenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_KehoachthoiEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_KehoachthoiEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamang,_KehoachthoiEntity.Mamang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KehoachthoiEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaychay,_KehoachthoiEntity.Ngaychay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KehoachthoiEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_KehoachthoiEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_KehoachthoiEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KehoachthoiEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KehoachthoiEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KehoachthoiEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KehoachthoiEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(KehoachthoiEntity _KehoachthoiEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new KehoachthoiManagerBase()).Update(_KehoachthoiEntity);
			r.SetField(Field_Id,_KehoachthoiEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Solenhsx,_KehoachthoiEntity.Solenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_KehoachthoiEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_KehoachthoiEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamang,_KehoachthoiEntity.Mamang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KehoachthoiEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaychay,_KehoachthoiEntity.Ngaychay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KehoachthoiEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_KehoachthoiEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_KehoachthoiEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KehoachthoiEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KehoachthoiEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KehoachthoiEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KehoachthoiEntity.Nguoisua);
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

		public KehoachthoiEntity Insert(KehoachthoiEntity KehoachthoiEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(KehoachthoiEntity, true);
			}
			return KehoachthoiEntity;
		}

		public KehoachthoiEntity Insert(System.Int64  Id, System.String  Solenhsx, System.DateTime  Ngaydat, System.DateTime  Ngaygiao, System.String  Mamang, System.String  Mamay, System.DateTime  Ngaychay, System.Int32  Ca, System.Decimal  Somet, System.Decimal  Sokg, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			KehoachthoiEntity _KehoachthoiEntity = new KehoachthoiEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KehoachthoiEntity.Id = Id;
				
				_KehoachthoiEntity.Solenhsx = Solenhsx;
				
				_KehoachthoiEntity.Ngaydat = Ngaydat;
				
				_KehoachthoiEntity.Ngaygiao = Ngaygiao;
				
				_KehoachthoiEntity.Mamang = Mamang;
				
				_KehoachthoiEntity.Mamay = Mamay;
				
				_KehoachthoiEntity.Ngaychay = Ngaychay;
				
				_KehoachthoiEntity.Ca = Ca;
				
				_KehoachthoiEntity.Somet = Somet;
				
				_KehoachthoiEntity.Sokg = Sokg;
				
				_KehoachthoiEntity.Ngaytao = Ngaytao;
				
				_KehoachthoiEntity.Nguoitao = Nguoitao;
				
				_KehoachthoiEntity.Ngaysua = Ngaysua;
				
				_KehoachthoiEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_KehoachthoiEntity, true);
			}
			return _KehoachthoiEntity;
		}

		public KehoachthoiEntity Insert(System.String Solenhsx, System.DateTime Ngaydat, System.DateTime Ngaygiao, System.String Mamang, System.String Mamay, System.DateTime Ngaychay, System.Int32 Ca, System.Decimal Somet, System.Decimal Sokg, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			KehoachthoiEntity _KehoachthoiEntity = new KehoachthoiEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_KehoachthoiEntity.Solenhsx = Solenhsx;
				
				_KehoachthoiEntity.Ngaydat = Ngaydat;
				
				_KehoachthoiEntity.Ngaygiao = Ngaygiao;
				
				_KehoachthoiEntity.Mamang = Mamang;
				
				_KehoachthoiEntity.Mamay = Mamay;
				
				_KehoachthoiEntity.Ngaychay = Ngaychay;
				
				_KehoachthoiEntity.Ca = Ca;
				
				_KehoachthoiEntity.Somet = Somet;
				
				_KehoachthoiEntity.Sokg = Sokg;
				
				_KehoachthoiEntity.Ngaytao = Ngaytao;
				
				_KehoachthoiEntity.Nguoitao = Nguoitao;
				
				_KehoachthoiEntity.Ngaysua = Ngaysua;
				
				_KehoachthoiEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_KehoachthoiEntity, true);
			}
			return _KehoachthoiEntity;
		}

		public bool Update(KehoachthoiEntity _KehoachthoiEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(KehoachthoiFields.Id == _KehoachthoiEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_KehoachthoiEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(KehoachthoiEntity _KehoachthoiEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_KehoachthoiEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Solenhsx, System.DateTime Ngaydat, System.DateTime Ngaygiao, System.String Mamang, System.String Mamay, System.DateTime Ngaychay, System.Int32 Ca, System.Decimal Somet, System.Decimal Sokg, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KehoachthoiEntity _KehoachthoiEntity = new KehoachthoiEntity(Id);
				if (adapter.FetchEntity(_KehoachthoiEntity))
				{
				
					
					
					_KehoachthoiEntity.Solenhsx = Solenhsx;
					
					_KehoachthoiEntity.Ngaydat = Ngaydat;
					
					_KehoachthoiEntity.Ngaygiao = Ngaygiao;
					
					_KehoachthoiEntity.Mamang = Mamang;
					
					_KehoachthoiEntity.Mamay = Mamay;
					
					_KehoachthoiEntity.Ngaychay = Ngaychay;
					
					_KehoachthoiEntity.Ca = Ca;
					
					_KehoachthoiEntity.Somet = Somet;
					
					_KehoachthoiEntity.Sokg = Sokg;
					
					_KehoachthoiEntity.Ngaytao = Ngaytao;
					
					_KehoachthoiEntity.Nguoitao = Nguoitao;
					
					_KehoachthoiEntity.Ngaysua = Ngaysua;
					
					_KehoachthoiEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_KehoachthoiEntity, true);
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
				KehoachthoiEntity _KehoachthoiEntity = new KehoachthoiEntity(Id);
				if (adapter.FetchEntity(_KehoachthoiEntity))
				{
					adapter.DeleteEntity(_KehoachthoiEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("KehoachthoiEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySolenhsx(System.String Solenhsx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaydat(System.DateTime Ngaydat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaygiao(System.DateTime Ngaygiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamang(System.String Mamang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamay(System.String Mamay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaychay(System.DateTime Ngaychay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Ngaychay == Ngaychay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCa(System.Int32 Ca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomet(System.Decimal Somet)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokg(System.Decimal Sokg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachthoiEntity", filter);
			}
			return toReturn;
		}		
			
		
		public KehoachthoiEntity SelectOne(System.Int64 Id)
		{
			KehoachthoiEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KehoachthoiEntity _KehoachthoiEntity = new KehoachthoiEntity(Id);
				if (adapter.FetchEntity(_KehoachthoiEntity))
				{
					toReturn = _KehoachthoiEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _KehoachthoiCollection = new EntityCollection( new KehoachthoiEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachthoiCollection, null, 0, null);
			}
			return _KehoachthoiCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachthoiCollection, filter, 0, null);
			}
			return _KehoachthoiCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySolenhsx(System.String Solenhsx)
		{
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachthoiCollection, filter, 0, null);
			}
			return _KehoachthoiCollection;
		}
		// Return DataTable
		public DataTable SelectBySolenhsxRDT(System.String Solenhsx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaydat(System.DateTime Ngaydat)
		{
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachthoiCollection, filter, 0, null);
			}
			return _KehoachthoiCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaydatRDT(System.DateTime Ngaydat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaygiao(System.DateTime Ngaygiao)
		{
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachthoiCollection, filter, 0, null);
			}
			return _KehoachthoiCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaygiaoRDT(System.DateTime Ngaygiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamang(System.String Mamang)
		{
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachthoiCollection, filter, 0, null);
			}
			return _KehoachthoiCollection;
		}
		// Return DataTable
		public DataTable SelectByMamangRDT(System.String Mamang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamay(System.String Mamay)
		{
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachthoiCollection, filter, 0, null);
			}
			return _KehoachthoiCollection;
		}
		// Return DataTable
		public DataTable SelectByMamayRDT(System.String Mamay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaychay(System.DateTime Ngaychay)
		{
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Ngaychay == Ngaychay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachthoiCollection, filter, 0, null);
			}
			return _KehoachthoiCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaychayRDT(System.DateTime Ngaychay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Ngaychay == Ngaychay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCa(System.Int32 Ca)
		{
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachthoiCollection, filter, 0, null);
			}
			return _KehoachthoiCollection;
		}
		// Return DataTable
		public DataTable SelectByCaRDT(System.Int32 Ca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomet(System.Decimal Somet)
		{
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachthoiCollection, filter, 0, null);
			}
			return _KehoachthoiCollection;
		}
		// Return DataTable
		public DataTable SelectBySometRDT(System.Decimal Somet)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokg(System.Decimal Sokg)
		{
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachthoiCollection, filter, 0, null);
			}
			return _KehoachthoiCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgRDT(System.Decimal Sokg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachthoiCollection, filter, 0, null);
			}
			return _KehoachthoiCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachthoiCollection, filter, 0, null);
			}
			return _KehoachthoiCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachthoiCollection, filter, 0, null);
			}
			return _KehoachthoiCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachthoiCollection, filter, 0, null);
			}
			return _KehoachthoiCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachthoiFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(KehoachthoiFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
