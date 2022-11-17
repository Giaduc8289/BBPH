


/*
'===============================================================================
'  GD.BBPH.BL.HangtralaiManagerBase
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
	public class HangtralaiManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngaytra="Ngaytra";				
		
		public const String Field_Makhach="Makhach";				
		
		public const String Field_Tenkhach="Tenkhach";				
		
		public const String Field_Masanpham="Masanpham";				
		
		public const String Field_Tensanpham="Tensanpham";				
		
		public const String Field_Soluongtra="Soluongtra";				
		
		public const String Field_Nguyennhan="Nguyennhan";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HangtralaiManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Ngaytra,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Makhach,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkhach,typeof(System.String));
			
			dt.Columns.Add(Field_Masanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Tensanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Soluongtra,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Nguyennhan,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(HangtralaiEntity _HangtralaiEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_HangtralaiEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytra]=_HangtralaiEntity.Ngaytra;
			}
			catch { }
			
			try
			{
				r[Field_Makhach]=_HangtralaiEntity.Makhach;
			}
			catch { }
			
			try
			{
				r[Field_Tenkhach]=_HangtralaiEntity.Tenkhach;
			}
			catch { }
			
			try
			{
				r[Field_Masanpham]=_HangtralaiEntity.Masanpham;
			}
			catch { }
			
			try
			{
				r[Field_Tensanpham]=_HangtralaiEntity.Tensanpham;
			}
			catch { }
			
			try
			{
				r[Field_Soluongtra]=_HangtralaiEntity.Soluongtra;
			}
			catch { }
			
			try
			{
				r[Field_Nguyennhan]=_HangtralaiEntity.Nguyennhan;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_HangtralaiEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_HangtralaiEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_HangtralaiEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_HangtralaiEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public HangtralaiEntity Convert(DataRow r)
		{	
			
			HangtralaiEntity _HangtralaiEntity=new HangtralaiEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_HangtralaiEntity.Ngaytra= System.DateTime.Parse(r[Field_Ngaytra].ToString());						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Makhach= r[Field_Makhach].ToString();						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Tenkhach= r[Field_Tenkhach].ToString();						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Masanpham= r[Field_Masanpham].ToString();						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Tensanpham= r[Field_Tensanpham].ToString();						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Soluongtra= System.Decimal.Parse(r[Field_Soluongtra].ToString());						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Nguyennhan= r[Field_Nguyennhan].ToString();						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _HangtralaiEntity;
		}			
		
		public HangtralaiEntity Convert_Entity(HangtralaiEntity _HangtralaiEntity,HangtralaiEntity _HangtralaiEntity_XML)
		{	
			
			
			_HangtralaiEntity.Id= _HangtralaiEntity_XML.Id;
			
			_HangtralaiEntity.Ngaytra= _HangtralaiEntity_XML.Ngaytra;
			
			_HangtralaiEntity.Makhach= _HangtralaiEntity_XML.Makhach;
			
			_HangtralaiEntity.Tenkhach= _HangtralaiEntity_XML.Tenkhach;
			
			_HangtralaiEntity.Masanpham= _HangtralaiEntity_XML.Masanpham;
			
			_HangtralaiEntity.Tensanpham= _HangtralaiEntity_XML.Tensanpham;
			
			_HangtralaiEntity.Soluongtra= _HangtralaiEntity_XML.Soluongtra;
			
			_HangtralaiEntity.Nguyennhan= _HangtralaiEntity_XML.Nguyennhan;
			
			_HangtralaiEntity.Ngaytao= _HangtralaiEntity_XML.Ngaytao;
			
			_HangtralaiEntity.Nguoitao= _HangtralaiEntity_XML.Nguoitao;
			
			_HangtralaiEntity.Ngaysua= _HangtralaiEntity_XML.Ngaysua;
			
			_HangtralaiEntity.Nguoisua= _HangtralaiEntity_XML.Nguoisua;
									
				
			return _HangtralaiEntity;
		}	
		
		public String InsertV2(HangtralaiEntity _HangtralaiEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new HangtralaiManagerBase()).Insert(_HangtralaiEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_HangtralaiEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngaytra,_HangtralaiEntity.Ngaytra);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_HangtralaiEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_HangtralaiEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_HangtralaiEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_HangtralaiEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluongtra,_HangtralaiEntity.Soluongtra);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguyennhan,_HangtralaiEntity.Nguyennhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_HangtralaiEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_HangtralaiEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_HangtralaiEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_HangtralaiEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(HangtralaiEntity _HangtralaiEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new HangtralaiManagerBase()).Update(_HangtralaiEntity);
			r.SetField(Field_Id,_HangtralaiEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngaytra,_HangtralaiEntity.Ngaytra);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_HangtralaiEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_HangtralaiEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_HangtralaiEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_HangtralaiEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluongtra,_HangtralaiEntity.Soluongtra);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguyennhan,_HangtralaiEntity.Nguyennhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_HangtralaiEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_HangtralaiEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_HangtralaiEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_HangtralaiEntity.Nguoisua);
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

		public HangtralaiEntity Insert(HangtralaiEntity HangtralaiEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(HangtralaiEntity, true);
			}
			return HangtralaiEntity;
		}

		public HangtralaiEntity Insert(System.Int64  Id, System.DateTime  Ngaytra, System.String  Makhach, System.String  Tenkhach, System.String  Masanpham, System.String  Tensanpham, System.Decimal  Soluongtra, System.String  Nguyennhan, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			HangtralaiEntity _HangtralaiEntity = new HangtralaiEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_HangtralaiEntity.Id = Id;
				
				_HangtralaiEntity.Ngaytra = Ngaytra;
				
				_HangtralaiEntity.Makhach = Makhach;
				
				_HangtralaiEntity.Tenkhach = Tenkhach;
				
				_HangtralaiEntity.Masanpham = Masanpham;
				
				_HangtralaiEntity.Tensanpham = Tensanpham;
				
				_HangtralaiEntity.Soluongtra = Soluongtra;
				
				_HangtralaiEntity.Nguyennhan = Nguyennhan;
				
				_HangtralaiEntity.Ngaytao = Ngaytao;
				
				_HangtralaiEntity.Nguoitao = Nguoitao;
				
				_HangtralaiEntity.Ngaysua = Ngaysua;
				
				_HangtralaiEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_HangtralaiEntity, true);
			}
			return _HangtralaiEntity;
		}

		public HangtralaiEntity Insert(System.DateTime Ngaytra, System.String Makhach, System.String Tenkhach, System.String Masanpham, System.String Tensanpham, System.Decimal Soluongtra, System.String Nguyennhan, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			HangtralaiEntity _HangtralaiEntity = new HangtralaiEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_HangtralaiEntity.Ngaytra = Ngaytra;
				
				_HangtralaiEntity.Makhach = Makhach;
				
				_HangtralaiEntity.Tenkhach = Tenkhach;
				
				_HangtralaiEntity.Masanpham = Masanpham;
				
				_HangtralaiEntity.Tensanpham = Tensanpham;
				
				_HangtralaiEntity.Soluongtra = Soluongtra;
				
				_HangtralaiEntity.Nguyennhan = Nguyennhan;
				
				_HangtralaiEntity.Ngaytao = Ngaytao;
				
				_HangtralaiEntity.Nguoitao = Nguoitao;
				
				_HangtralaiEntity.Ngaysua = Ngaysua;
				
				_HangtralaiEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_HangtralaiEntity, true);
			}
			return _HangtralaiEntity;
		}

		public bool Update(HangtralaiEntity _HangtralaiEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(HangtralaiFields.Id == _HangtralaiEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_HangtralaiEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(HangtralaiEntity _HangtralaiEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_HangtralaiEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngaytra, System.String Makhach, System.String Tenkhach, System.String Masanpham, System.String Tensanpham, System.Decimal Soluongtra, System.String Nguyennhan, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HangtralaiEntity _HangtralaiEntity = new HangtralaiEntity(Id);
				if (adapter.FetchEntity(_HangtralaiEntity))
				{
				
					
					
					_HangtralaiEntity.Ngaytra = Ngaytra;
					
					_HangtralaiEntity.Makhach = Makhach;
					
					_HangtralaiEntity.Tenkhach = Tenkhach;
					
					_HangtralaiEntity.Masanpham = Masanpham;
					
					_HangtralaiEntity.Tensanpham = Tensanpham;
					
					_HangtralaiEntity.Soluongtra = Soluongtra;
					
					_HangtralaiEntity.Nguyennhan = Nguyennhan;
					
					_HangtralaiEntity.Ngaytao = Ngaytao;
					
					_HangtralaiEntity.Nguoitao = Nguoitao;
					
					_HangtralaiEntity.Ngaysua = Ngaysua;
					
					_HangtralaiEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_HangtralaiEntity, true);
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
				HangtralaiEntity _HangtralaiEntity = new HangtralaiEntity(Id);
				if (adapter.FetchEntity(_HangtralaiEntity))
				{
					adapter.DeleteEntity(_HangtralaiEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("HangtralaiEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytra(System.DateTime Ngaytra)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaytra == Ngaytra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhach(System.String Makhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkhach(System.String Tenkhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasanpham(System.String Masanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensanpham(System.String Tensanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluongtra(System.Decimal Soluongtra)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Soluongtra == Soluongtra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguyennhan(System.String Nguyennhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Nguyennhan == Nguyennhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
			
		
		public HangtralaiEntity SelectOne(System.Int64 Id)
		{
			HangtralaiEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HangtralaiEntity _HangtralaiEntity = new HangtralaiEntity(Id);
				if (adapter.FetchEntity(_HangtralaiEntity))
				{
					toReturn = _HangtralaiEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _HangtralaiCollection = new EntityCollection( new HangtralaiEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, null, 0, null);
			}
			return _HangtralaiCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytra(System.DateTime Ngaytra)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaytra == Ngaytra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytraRDT(System.DateTime Ngaytra)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaytra == Ngaytra);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhach(System.String Makhach)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachRDT(System.String Makhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkhach(System.String Tenkhach)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhachRDT(System.String Tenkhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasanpham(System.String Masanpham)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByMasanphamRDT(System.String Masanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensanpham(System.String Tensanpham)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByTensanphamRDT(System.String Tensanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluongtra(System.Decimal Soluongtra)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Soluongtra == Soluongtra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluongtraRDT(System.Decimal Soluongtra)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Soluongtra == Soluongtra);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguyennhan(System.String Nguyennhan)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Nguyennhan == Nguyennhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByNguyennhanRDT(System.String Nguyennhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Nguyennhan == Nguyennhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(HangtralaiFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
