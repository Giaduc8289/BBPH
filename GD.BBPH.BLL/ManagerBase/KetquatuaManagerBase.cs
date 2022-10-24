


/*
'===============================================================================
'  GD.BBPH.BL.KetquatuaManagerBase
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
	public class KetquatuaManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngay="Ngay";				
		
		public const String Field_Ca="Ca";				
		
		public const String Field_Mamay="Mamay";				
		
		public const String Field_Lenhtua="Lenhtua";				
		
		public const String Field_Masanpham="Masanpham";				
		
		public const String Field_Macongnhan="Macongnhan";				
		
		public const String Field_Daurain="Daurain";				
		
		public const String Field_SoMetvao="SoMetvao";				
		
		public const String Field_SoKgvao="SoKgvao";				
		
		public const String Field_SoMetra="SoMetra";				
		
		public const String Field_SoKgra="SoKgra";				
		
		public const String Field_Saihongthucte="Saihongthucte";				
		
		public const String Field_Thoigianbatdau="Thoigianbatdau";				
		
		public const String Field_Thoigianketthuc="Thoigianketthuc";				
		
		public const String Field_Thoigianchuanbi="Thoigianchuanbi";				
		
		public const String Field_Thoigianhacuon="Thoigianhacuon";				
		
		public const String Field_Thoigiancatdau="Thoigiancatdau";				
		
		public const String Field_Thoigiandoilenh="Thoigiandoilenh";				
		
		public const String Field_Thoigiansuco="Thoigiansuco";				
		
		public const String Field_Phein="Phein";				
		
		public const String Field_Pheghep="Pheghep";				
		
		public const String Field_Phethoi="Phethoi";				
		
		public const String Field_Phesx="Phesx";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
		public const String Field_Tensanpham="Tensanpham";				
		
		public const String Field_Tenmay="Tenmay";				
		
		public const String Field_Tencongnhan="Tencongnhan";				
		
		public const String Field_Nangsuat="Nangsuat";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquatuaManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Ngay,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Ca,typeof(System.Int32));
			
			dt.Columns.Add(Field_Mamay,typeof(System.String));
			
			dt.Columns.Add(Field_Lenhtua,typeof(System.String));
			
			dt.Columns.Add(Field_Masanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Macongnhan,typeof(System.String));
			
			dt.Columns.Add(Field_Daurain,typeof(System.Decimal));
			
			dt.Columns.Add(Field_SoMetvao,typeof(System.Decimal));
			
			dt.Columns.Add(Field_SoKgvao,typeof(System.Decimal));
			
			dt.Columns.Add(Field_SoMetra,typeof(System.Decimal));
			
			dt.Columns.Add(Field_SoKgra,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Saihongthucte,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigianbatdau,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigianketthuc,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigianchuanbi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigianhacuon,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigiancatdau,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigiandoilenh,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigiansuco,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phein,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Pheghep,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phethoi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phesx,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
			
			dt.Columns.Add(Field_Tensanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmay,typeof(System.String));
			
			dt.Columns.Add(Field_Tencongnhan,typeof(System.String));
			
			dt.Columns.Add(Field_Nangsuat,typeof(System.Decimal));
									
		            
			return dt;			
		}
		public DataRow Convert(KetquatuaEntity _KetquatuaEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_KetquatuaEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngay]=_KetquatuaEntity.Ngay;
			}
			catch { }
			
			try
			{
				r[Field_Ca]=_KetquatuaEntity.Ca;
			}
			catch { }
			
			try
			{
				r[Field_Mamay]=_KetquatuaEntity.Mamay;
			}
			catch { }
			
			try
			{
				r[Field_Lenhtua]=_KetquatuaEntity.Lenhtua;
			}
			catch { }
			
			try
			{
				r[Field_Masanpham]=_KetquatuaEntity.Masanpham;
			}
			catch { }
			
			try
			{
				r[Field_Macongnhan]=_KetquatuaEntity.Macongnhan;
			}
			catch { }
			
			try
			{
				r[Field_Daurain]=_KetquatuaEntity.Daurain;
			}
			catch { }
			
			try
			{
				r[Field_SoMetvao]=_KetquatuaEntity.SoMetvao;
			}
			catch { }
			
			try
			{
				r[Field_SoKgvao]=_KetquatuaEntity.SoKgvao;
			}
			catch { }
			
			try
			{
				r[Field_SoMetra]=_KetquatuaEntity.SoMetra;
			}
			catch { }
			
			try
			{
				r[Field_SoKgra]=_KetquatuaEntity.SoKgra;
			}
			catch { }
			
			try
			{
				r[Field_Saihongthucte]=_KetquatuaEntity.Saihongthucte;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianbatdau]=_KetquatuaEntity.Thoigianbatdau;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianketthuc]=_KetquatuaEntity.Thoigianketthuc;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianchuanbi]=_KetquatuaEntity.Thoigianchuanbi;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianhacuon]=_KetquatuaEntity.Thoigianhacuon;
			}
			catch { }
			
			try
			{
				r[Field_Thoigiancatdau]=_KetquatuaEntity.Thoigiancatdau;
			}
			catch { }
			
			try
			{
				r[Field_Thoigiandoilenh]=_KetquatuaEntity.Thoigiandoilenh;
			}
			catch { }
			
			try
			{
				r[Field_Thoigiansuco]=_KetquatuaEntity.Thoigiansuco;
			}
			catch { }
			
			try
			{
				r[Field_Phein]=_KetquatuaEntity.Phein;
			}
			catch { }
			
			try
			{
				r[Field_Pheghep]=_KetquatuaEntity.Pheghep;
			}
			catch { }
			
			try
			{
				r[Field_Phethoi]=_KetquatuaEntity.Phethoi;
			}
			catch { }
			
			try
			{
				r[Field_Phesx]=_KetquatuaEntity.Phesx;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_KetquatuaEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_KetquatuaEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_KetquatuaEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_KetquatuaEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Tensanpham]=_KetquatuaEntity.Tensanpham;
			}
			catch { }
			
			try
			{
				r[Field_Tenmay]=_KetquatuaEntity.Tenmay;
			}
			catch { }
			
			try
			{
				r[Field_Tencongnhan]=_KetquatuaEntity.Tencongnhan;
			}
			catch { }
			
			try
			{
				r[Field_Nangsuat]=_KetquatuaEntity.Nangsuat;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public KetquatuaEntity Convert(DataRow r)
		{	
			
			KetquatuaEntity _KetquatuaEntity=new KetquatuaEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_KetquatuaEntity.Ngay= System.DateTime.Parse(r[Field_Ngay].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Ca= System.Int32.Parse(r[Field_Ca].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Mamay= r[Field_Mamay].ToString();						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Lenhtua= r[Field_Lenhtua].ToString();						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Masanpham= r[Field_Masanpham].ToString();						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Macongnhan= r[Field_Macongnhan].ToString();						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Daurain= System.Decimal.Parse(r[Field_Daurain].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.SoMetvao= System.Decimal.Parse(r[Field_SoMetvao].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.SoKgvao= System.Decimal.Parse(r[Field_SoKgvao].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.SoMetra= System.Decimal.Parse(r[Field_SoMetra].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.SoKgra= System.Decimal.Parse(r[Field_SoKgra].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Saihongthucte= System.Decimal.Parse(r[Field_Saihongthucte].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Thoigianbatdau= System.DateTime.Parse(r[Field_Thoigianbatdau].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Thoigianketthuc= System.DateTime.Parse(r[Field_Thoigianketthuc].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Thoigianchuanbi= System.Decimal.Parse(r[Field_Thoigianchuanbi].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Thoigianhacuon= System.Decimal.Parse(r[Field_Thoigianhacuon].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Thoigiancatdau= System.Decimal.Parse(r[Field_Thoigiancatdau].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Thoigiandoilenh= System.Decimal.Parse(r[Field_Thoigiandoilenh].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Thoigiansuco= System.Decimal.Parse(r[Field_Thoigiansuco].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Phein= System.Decimal.Parse(r[Field_Phein].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Pheghep= System.Decimal.Parse(r[Field_Pheghep].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Phethoi= System.Decimal.Parse(r[Field_Phethoi].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Phesx= System.Decimal.Parse(r[Field_Phesx].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Tensanpham= r[Field_Tensanpham].ToString();						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Tenmay= r[Field_Tenmay].ToString();						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Tencongnhan= r[Field_Tencongnhan].ToString();						
			}
			catch { }
			
			try
			{
				_KetquatuaEntity.Nangsuat= System.Decimal.Parse(r[Field_Nangsuat].ToString());						
			}
			catch { }
									
									
			return _KetquatuaEntity;
		}			
		
		public KetquatuaEntity Convert_Entity(KetquatuaEntity _KetquatuaEntity,KetquatuaEntity _KetquatuaEntity_XML)
		{	
			
			
			_KetquatuaEntity.Id= _KetquatuaEntity_XML.Id;
			
			_KetquatuaEntity.Ngay= _KetquatuaEntity_XML.Ngay;
			
			_KetquatuaEntity.Ca= _KetquatuaEntity_XML.Ca;
			
			_KetquatuaEntity.Mamay= _KetquatuaEntity_XML.Mamay;
			
			_KetquatuaEntity.Lenhtua= _KetquatuaEntity_XML.Lenhtua;
			
			_KetquatuaEntity.Masanpham= _KetquatuaEntity_XML.Masanpham;
			
			_KetquatuaEntity.Macongnhan= _KetquatuaEntity_XML.Macongnhan;
			
			_KetquatuaEntity.Daurain= _KetquatuaEntity_XML.Daurain;
			
			_KetquatuaEntity.SoMetvao= _KetquatuaEntity_XML.SoMetvao;
			
			_KetquatuaEntity.SoKgvao= _KetquatuaEntity_XML.SoKgvao;
			
			_KetquatuaEntity.SoMetra= _KetquatuaEntity_XML.SoMetra;
			
			_KetquatuaEntity.SoKgra= _KetquatuaEntity_XML.SoKgra;
			
			_KetquatuaEntity.Saihongthucte= _KetquatuaEntity_XML.Saihongthucte;
			
			_KetquatuaEntity.Thoigianbatdau= _KetquatuaEntity_XML.Thoigianbatdau;
			
			_KetquatuaEntity.Thoigianketthuc= _KetquatuaEntity_XML.Thoigianketthuc;
			
			_KetquatuaEntity.Thoigianchuanbi= _KetquatuaEntity_XML.Thoigianchuanbi;
			
			_KetquatuaEntity.Thoigianhacuon= _KetquatuaEntity_XML.Thoigianhacuon;
			
			_KetquatuaEntity.Thoigiancatdau= _KetquatuaEntity_XML.Thoigiancatdau;
			
			_KetquatuaEntity.Thoigiandoilenh= _KetquatuaEntity_XML.Thoigiandoilenh;
			
			_KetquatuaEntity.Thoigiansuco= _KetquatuaEntity_XML.Thoigiansuco;
			
			_KetquatuaEntity.Phein= _KetquatuaEntity_XML.Phein;
			
			_KetquatuaEntity.Pheghep= _KetquatuaEntity_XML.Pheghep;
			
			_KetquatuaEntity.Phethoi= _KetquatuaEntity_XML.Phethoi;
			
			_KetquatuaEntity.Phesx= _KetquatuaEntity_XML.Phesx;
			
			_KetquatuaEntity.Ngaytao= _KetquatuaEntity_XML.Ngaytao;
			
			_KetquatuaEntity.Nguoitao= _KetquatuaEntity_XML.Nguoitao;
			
			_KetquatuaEntity.Ngaysua= _KetquatuaEntity_XML.Ngaysua;
			
			_KetquatuaEntity.Nguoisua= _KetquatuaEntity_XML.Nguoisua;
			
			_KetquatuaEntity.Tensanpham= _KetquatuaEntity_XML.Tensanpham;
			
			_KetquatuaEntity.Tenmay= _KetquatuaEntity_XML.Tenmay;
			
			_KetquatuaEntity.Tencongnhan= _KetquatuaEntity_XML.Tencongnhan;
			
			_KetquatuaEntity.Nangsuat= _KetquatuaEntity_XML.Nangsuat;
									
				
			return _KetquatuaEntity;
		}	
		
		public String InsertV2(KetquatuaEntity _KetquatuaEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new KetquatuaManagerBase()).Insert(_KetquatuaEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_KetquatuaEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngay,_KetquatuaEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KetquatuaEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KetquatuaEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhtua,_KetquatuaEntity.Lenhtua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KetquatuaEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongnhan,_KetquatuaEntity.Macongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Daurain,_KetquatuaEntity.Daurain);
			}
			catch { }
			
			try
			{
				r.SetField(Field_SoMetvao,_KetquatuaEntity.SoMetvao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_SoKgvao,_KetquatuaEntity.SoKgvao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_SoMetra,_KetquatuaEntity.SoMetra);
			}
			catch { }
			
			try
			{
				r.SetField(Field_SoKgra,_KetquatuaEntity.SoKgra);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Saihongthucte,_KetquatuaEntity.Saihongthucte);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianbatdau,_KetquatuaEntity.Thoigianbatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianketthuc,_KetquatuaEntity.Thoigianketthuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianchuanbi,_KetquatuaEntity.Thoigianchuanbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianhacuon,_KetquatuaEntity.Thoigianhacuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiancatdau,_KetquatuaEntity.Thoigiancatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiandoilenh,_KetquatuaEntity.Thoigiandoilenh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiansuco,_KetquatuaEntity.Thoigiansuco);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phein,_KetquatuaEntity.Phein);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Pheghep,_KetquatuaEntity.Pheghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phethoi,_KetquatuaEntity.Phethoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phesx,_KetquatuaEntity.Phesx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KetquatuaEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KetquatuaEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KetquatuaEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KetquatuaEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_KetquatuaEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmay,_KetquatuaEntity.Tenmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongnhan,_KetquatuaEntity.Tencongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nangsuat,_KetquatuaEntity.Nangsuat);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(KetquatuaEntity _KetquatuaEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new KetquatuaManagerBase()).Update(_KetquatuaEntity);
			r.SetField(Field_Id,_KetquatuaEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngay,_KetquatuaEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KetquatuaEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KetquatuaEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhtua,_KetquatuaEntity.Lenhtua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KetquatuaEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongnhan,_KetquatuaEntity.Macongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Daurain,_KetquatuaEntity.Daurain);
			}
			catch { }
			
			try
			{
				r.SetField(Field_SoMetvao,_KetquatuaEntity.SoMetvao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_SoKgvao,_KetquatuaEntity.SoKgvao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_SoMetra,_KetquatuaEntity.SoMetra);
			}
			catch { }
			
			try
			{
				r.SetField(Field_SoKgra,_KetquatuaEntity.SoKgra);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Saihongthucte,_KetquatuaEntity.Saihongthucte);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianbatdau,_KetquatuaEntity.Thoigianbatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianketthuc,_KetquatuaEntity.Thoigianketthuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianchuanbi,_KetquatuaEntity.Thoigianchuanbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianhacuon,_KetquatuaEntity.Thoigianhacuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiancatdau,_KetquatuaEntity.Thoigiancatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiandoilenh,_KetquatuaEntity.Thoigiandoilenh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiansuco,_KetquatuaEntity.Thoigiansuco);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phein,_KetquatuaEntity.Phein);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Pheghep,_KetquatuaEntity.Pheghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phethoi,_KetquatuaEntity.Phethoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phesx,_KetquatuaEntity.Phesx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KetquatuaEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KetquatuaEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KetquatuaEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KetquatuaEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_KetquatuaEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmay,_KetquatuaEntity.Tenmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongnhan,_KetquatuaEntity.Tencongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nangsuat,_KetquatuaEntity.Nangsuat);
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

		public KetquatuaEntity Insert(KetquatuaEntity KetquatuaEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(KetquatuaEntity, true);
			}
			return KetquatuaEntity;
		}

		public KetquatuaEntity Insert(System.Int64  Id, System.DateTime  Ngay, System.Int32  Ca, System.String  Mamay, System.String  Lenhtua, System.String  Masanpham, System.String  Macongnhan, System.Decimal  Daurain, System.Decimal  SoMetvao, System.Decimal  SoKgvao, System.Decimal  SoMetra, System.Decimal  SoKgra, System.Decimal  Saihongthucte, System.DateTime  Thoigianbatdau, System.DateTime  Thoigianketthuc, System.Decimal  Thoigianchuanbi, System.Decimal  Thoigianhacuon, System.Decimal  Thoigiancatdau, System.Decimal  Thoigiandoilenh, System.Decimal  Thoigiansuco, System.Decimal  Phein, System.Decimal  Pheghep, System.Decimal  Phethoi, System.Decimal  Phesx, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.String  Tensanpham, System.String  Tenmay, System.String  Tencongnhan, System.Decimal  Nangsuat)
		{
			KetquatuaEntity _KetquatuaEntity = new KetquatuaEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KetquatuaEntity.Id = Id;
				
				_KetquatuaEntity.Ngay = Ngay;
				
				_KetquatuaEntity.Ca = Ca;
				
				_KetquatuaEntity.Mamay = Mamay;
				
				_KetquatuaEntity.Lenhtua = Lenhtua;
				
				_KetquatuaEntity.Masanpham = Masanpham;
				
				_KetquatuaEntity.Macongnhan = Macongnhan;
				
				_KetquatuaEntity.Daurain = Daurain;
				
				_KetquatuaEntity.SoMetvao = SoMetvao;
				
				_KetquatuaEntity.SoKgvao = SoKgvao;
				
				_KetquatuaEntity.SoMetra = SoMetra;
				
				_KetquatuaEntity.SoKgra = SoKgra;
				
				_KetquatuaEntity.Saihongthucte = Saihongthucte;
				
				_KetquatuaEntity.Thoigianbatdau = Thoigianbatdau;
				
				_KetquatuaEntity.Thoigianketthuc = Thoigianketthuc;
				
				_KetquatuaEntity.Thoigianchuanbi = Thoigianchuanbi;
				
				_KetquatuaEntity.Thoigianhacuon = Thoigianhacuon;
				
				_KetquatuaEntity.Thoigiancatdau = Thoigiancatdau;
				
				_KetquatuaEntity.Thoigiandoilenh = Thoigiandoilenh;
				
				_KetquatuaEntity.Thoigiansuco = Thoigiansuco;
				
				_KetquatuaEntity.Phein = Phein;
				
				_KetquatuaEntity.Pheghep = Pheghep;
				
				_KetquatuaEntity.Phethoi = Phethoi;
				
				_KetquatuaEntity.Phesx = Phesx;
				
				_KetquatuaEntity.Ngaytao = Ngaytao;
				
				_KetquatuaEntity.Nguoitao = Nguoitao;
				
				_KetquatuaEntity.Ngaysua = Ngaysua;
				
				_KetquatuaEntity.Nguoisua = Nguoisua;
				
				_KetquatuaEntity.Tensanpham = Tensanpham;
				
				_KetquatuaEntity.Tenmay = Tenmay;
				
				_KetquatuaEntity.Tencongnhan = Tencongnhan;
				
				_KetquatuaEntity.Nangsuat = Nangsuat;
					
					
				adapter.SaveEntity(_KetquatuaEntity, true);
			}
			return _KetquatuaEntity;
		}

		public KetquatuaEntity Insert(System.DateTime Ngay, System.Int32 Ca, System.String Mamay, System.String Lenhtua, System.String Masanpham, System.String Macongnhan, System.Decimal Daurain, System.Decimal SoMetvao, System.Decimal SoKgvao, System.Decimal SoMetra, System.Decimal SoKgra, System.Decimal Saihongthucte, System.DateTime Thoigianbatdau, System.DateTime Thoigianketthuc, System.Decimal Thoigianchuanbi, System.Decimal Thoigianhacuon, System.Decimal Thoigiancatdau, System.Decimal Thoigiandoilenh, System.Decimal Thoigiansuco, System.Decimal Phein, System.Decimal Pheghep, System.Decimal Phethoi, System.Decimal Phesx, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.String Tensanpham, System.String Tenmay, System.String Tencongnhan, System.Decimal Nangsuat, )//ko co mahieu
		{
			KetquatuaEntity _KetquatuaEntity = new KetquatuaEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_KetquatuaEntity.Ngay = Ngay;
				
				_KetquatuaEntity.Ca = Ca;
				
				_KetquatuaEntity.Mamay = Mamay;
				
				_KetquatuaEntity.Lenhtua = Lenhtua;
				
				_KetquatuaEntity.Masanpham = Masanpham;
				
				_KetquatuaEntity.Macongnhan = Macongnhan;
				
				_KetquatuaEntity.Daurain = Daurain;
				
				_KetquatuaEntity.SoMetvao = SoMetvao;
				
				_KetquatuaEntity.SoKgvao = SoKgvao;
				
				_KetquatuaEntity.SoMetra = SoMetra;
				
				_KetquatuaEntity.SoKgra = SoKgra;
				
				_KetquatuaEntity.Saihongthucte = Saihongthucte;
				
				_KetquatuaEntity.Thoigianbatdau = Thoigianbatdau;
				
				_KetquatuaEntity.Thoigianketthuc = Thoigianketthuc;
				
				_KetquatuaEntity.Thoigianchuanbi = Thoigianchuanbi;
				
				_KetquatuaEntity.Thoigianhacuon = Thoigianhacuon;
				
				_KetquatuaEntity.Thoigiancatdau = Thoigiancatdau;
				
				_KetquatuaEntity.Thoigiandoilenh = Thoigiandoilenh;
				
				_KetquatuaEntity.Thoigiansuco = Thoigiansuco;
				
				_KetquatuaEntity.Phein = Phein;
				
				_KetquatuaEntity.Pheghep = Pheghep;
				
				_KetquatuaEntity.Phethoi = Phethoi;
				
				_KetquatuaEntity.Phesx = Phesx;
				
				_KetquatuaEntity.Ngaytao = Ngaytao;
				
				_KetquatuaEntity.Nguoitao = Nguoitao;
				
				_KetquatuaEntity.Ngaysua = Ngaysua;
				
				_KetquatuaEntity.Nguoisua = Nguoisua;
				
				_KetquatuaEntity.Tensanpham = Tensanpham;
				
				_KetquatuaEntity.Tenmay = Tenmay;
				
				_KetquatuaEntity.Tencongnhan = Tencongnhan;
				
				_KetquatuaEntity.Nangsuat = Nangsuat;
					

				adapter.SaveEntity(_KetquatuaEntity, true);
			}
			return _KetquatuaEntity;
		}

		public bool Update(KetquatuaEntity _KetquatuaEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(KetquatuaFields.Id == _KetquatuaEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_KetquatuaEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(KetquatuaEntity _KetquatuaEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_KetquatuaEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngay, System.Int32 Ca, System.String Mamay, System.String Lenhtua, System.String Masanpham, System.String Macongnhan, System.Decimal Daurain, System.Decimal SoMetvao, System.Decimal SoKgvao, System.Decimal SoMetra, System.Decimal SoKgra, System.Decimal Saihongthucte, System.DateTime Thoigianbatdau, System.DateTime Thoigianketthuc, System.Decimal Thoigianchuanbi, System.Decimal Thoigianhacuon, System.Decimal Thoigiancatdau, System.Decimal Thoigiandoilenh, System.Decimal Thoigiansuco, System.Decimal Phein, System.Decimal Pheghep, System.Decimal Phethoi, System.Decimal Phesx, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.String Tensanpham, System.String Tenmay, System.String Tencongnhan, System.Decimal Nangsuat)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquatuaEntity _KetquatuaEntity = new KetquatuaEntity(Id);
				if (adapter.FetchEntity(_KetquatuaEntity))
				{
				
					
					
					_KetquatuaEntity.Ngay = Ngay;
					
					_KetquatuaEntity.Ca = Ca;
					
					_KetquatuaEntity.Mamay = Mamay;
					
					_KetquatuaEntity.Lenhtua = Lenhtua;
					
					_KetquatuaEntity.Masanpham = Masanpham;
					
					_KetquatuaEntity.Macongnhan = Macongnhan;
					
					_KetquatuaEntity.Daurain = Daurain;
					
					_KetquatuaEntity.SoMetvao = SoMetvao;
					
					_KetquatuaEntity.SoKgvao = SoKgvao;
					
					_KetquatuaEntity.SoMetra = SoMetra;
					
					_KetquatuaEntity.SoKgra = SoKgra;
					
					_KetquatuaEntity.Saihongthucte = Saihongthucte;
					
					_KetquatuaEntity.Thoigianbatdau = Thoigianbatdau;
					
					_KetquatuaEntity.Thoigianketthuc = Thoigianketthuc;
					
					_KetquatuaEntity.Thoigianchuanbi = Thoigianchuanbi;
					
					_KetquatuaEntity.Thoigianhacuon = Thoigianhacuon;
					
					_KetquatuaEntity.Thoigiancatdau = Thoigiancatdau;
					
					_KetquatuaEntity.Thoigiandoilenh = Thoigiandoilenh;
					
					_KetquatuaEntity.Thoigiansuco = Thoigiansuco;
					
					_KetquatuaEntity.Phein = Phein;
					
					_KetquatuaEntity.Pheghep = Pheghep;
					
					_KetquatuaEntity.Phethoi = Phethoi;
					
					_KetquatuaEntity.Phesx = Phesx;
					
					_KetquatuaEntity.Ngaytao = Ngaytao;
					
					_KetquatuaEntity.Nguoitao = Nguoitao;
					
					_KetquatuaEntity.Ngaysua = Ngaysua;
					
					_KetquatuaEntity.Nguoisua = Nguoisua;
					
					_KetquatuaEntity.Tensanpham = Tensanpham;
					
					_KetquatuaEntity.Tenmay = Tenmay;
					
					_KetquatuaEntity.Tencongnhan = Tencongnhan;
					
					_KetquatuaEntity.Nangsuat = Nangsuat;
						

					adapter.SaveEntity(_KetquatuaEntity, true);
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
				KetquatuaEntity _KetquatuaEntity = new KetquatuaEntity(Id);
				if (adapter.FetchEntity(_KetquatuaEntity))
				{
					adapter.DeleteEntity(_KetquatuaEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("KetquatuaEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgay(System.DateTime Ngay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCa(System.Int32 Ca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamay(System.String Mamay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLenhtua(System.String Lenhtua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Lenhtua == Lenhtua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasanpham(System.String Masanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMacongnhan(System.String Macongnhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDaurain(System.Decimal Daurain)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Daurain == Daurain);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoMetvao(System.Decimal SoMetvao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.SoMetvao == SoMetvao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoKgvao(System.Decimal SoKgvao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.SoKgvao == SoKgvao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoMetra(System.Decimal SoMetra)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.SoMetra == SoMetra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoKgra(System.Decimal SoKgra)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.SoKgra == SoKgra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySaihongthucte(System.Decimal Saihongthucte)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Saihongthucte == Saihongthucte);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianbatdau(System.DateTime Thoigianbatdau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianketthuc(System.DateTime Thoigianketthuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianchuanbi(System.Decimal Thoigianchuanbi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigianchuanbi == Thoigianchuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianhacuon(System.Decimal Thoigianhacuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigianhacuon == Thoigianhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigiancatdau(System.Decimal Thoigiancatdau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigiancatdau == Thoigiancatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigiandoilenh(System.Decimal Thoigiandoilenh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigiandoilenh == Thoigiandoilenh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigiansuco(System.Decimal Thoigiansuco)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhein(System.Decimal Phein)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Phein == Phein);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPheghep(System.Decimal Pheghep)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Pheghep == Pheghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhethoi(System.Decimal Phethoi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Phethoi == Phethoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhesx(System.Decimal Phesx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Phesx == Phesx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensanpham(System.String Tensanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmay(System.String Tenmay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTencongnhan(System.String Tencongnhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNangsuat(System.Decimal Nangsuat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Nangsuat == Nangsuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquatuaEntity", filter);
			}
			return toReturn;
		}		
			
		
		public KetquatuaEntity SelectOne(System.Int64 Id)
		{
			KetquatuaEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquatuaEntity _KetquatuaEntity = new KetquatuaEntity(Id);
				if (adapter.FetchEntity(_KetquatuaEntity))
				{
					toReturn = _KetquatuaEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _KetquatuaCollection = new EntityCollection( new KetquatuaEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, null, 0, null);
			}
			return _KetquatuaCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgay(System.DateTime Ngay)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayRDT(System.DateTime Ngay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCa(System.Int32 Ca)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByCaRDT(System.Int32 Ca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamay(System.String Mamay)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByMamayRDT(System.String Mamay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLenhtua(System.String Lenhtua)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Lenhtua == Lenhtua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByLenhtuaRDT(System.String Lenhtua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Lenhtua == Lenhtua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasanpham(System.String Masanpham)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByMasanphamRDT(System.String Masanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMacongnhan(System.String Macongnhan)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByMacongnhanRDT(System.String Macongnhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDaurain(System.Decimal Daurain)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Daurain == Daurain);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByDaurainRDT(System.Decimal Daurain)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Daurain == Daurain);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoMetvao(System.Decimal SoMetvao)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.SoMetvao == SoMetvao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectBySoMetvaoRDT(System.Decimal SoMetvao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.SoMetvao == SoMetvao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoKgvao(System.Decimal SoKgvao)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.SoKgvao == SoKgvao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectBySoKgvaoRDT(System.Decimal SoKgvao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.SoKgvao == SoKgvao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoMetra(System.Decimal SoMetra)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.SoMetra == SoMetra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectBySoMetraRDT(System.Decimal SoMetra)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.SoMetra == SoMetra);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoKgra(System.Decimal SoKgra)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.SoKgra == SoKgra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectBySoKgraRDT(System.Decimal SoKgra)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.SoKgra == SoKgra);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySaihongthucte(System.Decimal Saihongthucte)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Saihongthucte == Saihongthucte);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectBySaihongthucteRDT(System.Decimal Saihongthucte)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Saihongthucte == Saihongthucte);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianbatdau(System.DateTime Thoigianbatdau)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianbatdauRDT(System.DateTime Thoigianbatdau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianketthuc(System.DateTime Thoigianketthuc)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianketthucRDT(System.DateTime Thoigianketthuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianchuanbi(System.Decimal Thoigianchuanbi)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigianchuanbi == Thoigianchuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianchuanbiRDT(System.Decimal Thoigianchuanbi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigianchuanbi == Thoigianchuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianhacuon(System.Decimal Thoigianhacuon)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigianhacuon == Thoigianhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianhacuonRDT(System.Decimal Thoigianhacuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigianhacuon == Thoigianhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigiancatdau(System.Decimal Thoigiancatdau)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigiancatdau == Thoigiancatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigiancatdauRDT(System.Decimal Thoigiancatdau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigiancatdau == Thoigiancatdau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigiandoilenh(System.Decimal Thoigiandoilenh)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigiandoilenh == Thoigiandoilenh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigiandoilenhRDT(System.Decimal Thoigiandoilenh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigiandoilenh == Thoigiandoilenh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigiansuco(System.Decimal Thoigiansuco)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigiansucoRDT(System.Decimal Thoigiansuco)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhein(System.Decimal Phein)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Phein == Phein);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByPheinRDT(System.Decimal Phein)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Phein == Phein);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPheghep(System.Decimal Pheghep)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Pheghep == Pheghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByPheghepRDT(System.Decimal Pheghep)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Pheghep == Pheghep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhethoi(System.Decimal Phethoi)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Phethoi == Phethoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByPhethoiRDT(System.Decimal Phethoi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Phethoi == Phethoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhesx(System.Decimal Phesx)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Phesx == Phesx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByPhesxRDT(System.Decimal Phesx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Phesx == Phesx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensanpham(System.String Tensanpham)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByTensanphamRDT(System.String Tensanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmay(System.String Tenmay)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmayRDT(System.String Tenmay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTencongnhan(System.String Tencongnhan)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByTencongnhanRDT(System.String Tencongnhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNangsuat(System.Decimal Nangsuat)
		{
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Nangsuat == Nangsuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquatuaCollection, filter, 0, null);
			}
			return _KetquatuaCollection;
		}
		// Return DataTable
		public DataTable SelectByNangsuatRDT(System.Decimal Nangsuat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquatuaFields.Nangsuat == Nangsuat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
