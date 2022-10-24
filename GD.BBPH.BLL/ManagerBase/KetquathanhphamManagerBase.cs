


/*
'===============================================================================
'  GD.BBPH.BL.KetquathanhphamManagerBase
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
	public class KetquathanhphamManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngay="Ngay";				
		
		public const String Field_Ca="Ca";				
		
		public const String Field_Mamay="Mamay";				
		
		public const String Field_SoLsx="SoLsx";				
		
		public const String Field_Masanpham="Masanpham";				
		
		public const String Field_Macongnhan="Macongnhan";				
		
		public const String Field_Tensanpham="Tensanpham";				
		
		public const String Field_Tenmay="Tenmay";				
		
		public const String Field_Tencongnhan="Tencongnhan";				
		
		public const String Field_SoMetvao="SoMetvao";				
		
		public const String Field_SoKgvao="SoKgvao";				
		
		public const String Field_Thoigianbatdau="Thoigianbatdau";				
		
		public const String Field_Thoigianketthuc="Thoigianketthuc";				
		
		public const String Field_Thoigianchuanbi="Thoigianchuanbi";				
		
		public const String Field_Thoigianhacuon="Thoigianhacuon";				
		
		public const String Field_Thoigiancatdau="Thoigiancatdau";				
		
		public const String Field_Thoigiansuco="Thoigiansuco";				
		
		public const String Field_Dgnangsuat="Dgnangsuat";				
		
		public const String Field_Dmtui="Dmtui";				
		
		public const String Field_Ttetui="Ttetui";				
		
		public const String Field_Kiemtra="Kiemtra";				
		
		public const String Field_Phein="Phein";				
		
		public const String Field_Pheghep="Pheghep";				
		
		public const String Field_Phechia="Phechia";				
		
		public const String Field_Phebien="Phebien";				
		
		public const String Field_Phethoi="Phethoi";				
		
		public const String Field_Phechinhmay="Phechinhmay";				
		
		public const String Field_Phekhac="Phekhac";				
		
		public const String Field_Titrongtui="Titrongtui";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
		public const String Field_Socon="Socon";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquathanhphamManagerBase()
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
			
			dt.Columns.Add(Field_SoLsx,typeof(System.String));
			
			dt.Columns.Add(Field_Masanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Macongnhan,typeof(System.String));
			
			dt.Columns.Add(Field_Tensanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmay,typeof(System.String));
			
			dt.Columns.Add(Field_Tencongnhan,typeof(System.String));
			
			dt.Columns.Add(Field_SoMetvao,typeof(System.Decimal));
			
			dt.Columns.Add(Field_SoKgvao,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigianbatdau,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigianketthuc,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigianchuanbi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigianhacuon,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigiancatdau,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigiansuco,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dgnangsuat,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dmtui,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ttetui,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Kiemtra,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phein,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Pheghep,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phechia,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phebien,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phethoi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phechinhmay,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phekhac,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Titrongtui,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
			
			dt.Columns.Add(Field_Socon,typeof(System.Int32));
									
		            
			return dt;			
		}
		public DataRow Convert(KetquathanhphamEntity _KetquathanhphamEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_KetquathanhphamEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngay]=_KetquathanhphamEntity.Ngay;
			}
			catch { }
			
			try
			{
				r[Field_Ca]=_KetquathanhphamEntity.Ca;
			}
			catch { }
			
			try
			{
				r[Field_Mamay]=_KetquathanhphamEntity.Mamay;
			}
			catch { }
			
			try
			{
				r[Field_SoLsx]=_KetquathanhphamEntity.SoLsx;
			}
			catch { }
			
			try
			{
				r[Field_Masanpham]=_KetquathanhphamEntity.Masanpham;
			}
			catch { }
			
			try
			{
				r[Field_Macongnhan]=_KetquathanhphamEntity.Macongnhan;
			}
			catch { }
			
			try
			{
				r[Field_Tensanpham]=_KetquathanhphamEntity.Tensanpham;
			}
			catch { }
			
			try
			{
				r[Field_Tenmay]=_KetquathanhphamEntity.Tenmay;
			}
			catch { }
			
			try
			{
				r[Field_Tencongnhan]=_KetquathanhphamEntity.Tencongnhan;
			}
			catch { }
			
			try
			{
				r[Field_SoMetvao]=_KetquathanhphamEntity.SoMetvao;
			}
			catch { }
			
			try
			{
				r[Field_SoKgvao]=_KetquathanhphamEntity.SoKgvao;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianbatdau]=_KetquathanhphamEntity.Thoigianbatdau;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianketthuc]=_KetquathanhphamEntity.Thoigianketthuc;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianchuanbi]=_KetquathanhphamEntity.Thoigianchuanbi;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianhacuon]=_KetquathanhphamEntity.Thoigianhacuon;
			}
			catch { }
			
			try
			{
				r[Field_Thoigiancatdau]=_KetquathanhphamEntity.Thoigiancatdau;
			}
			catch { }
			
			try
			{
				r[Field_Thoigiansuco]=_KetquathanhphamEntity.Thoigiansuco;
			}
			catch { }
			
			try
			{
				r[Field_Dgnangsuat]=_KetquathanhphamEntity.Dgnangsuat;
			}
			catch { }
			
			try
			{
				r[Field_Dmtui]=_KetquathanhphamEntity.Dmtui;
			}
			catch { }
			
			try
			{
				r[Field_Ttetui]=_KetquathanhphamEntity.Ttetui;
			}
			catch { }
			
			try
			{
				r[Field_Kiemtra]=_KetquathanhphamEntity.Kiemtra;
			}
			catch { }
			
			try
			{
				r[Field_Phein]=_KetquathanhphamEntity.Phein;
			}
			catch { }
			
			try
			{
				r[Field_Pheghep]=_KetquathanhphamEntity.Pheghep;
			}
			catch { }
			
			try
			{
				r[Field_Phechia]=_KetquathanhphamEntity.Phechia;
			}
			catch { }
			
			try
			{
				r[Field_Phebien]=_KetquathanhphamEntity.Phebien;
			}
			catch { }
			
			try
			{
				r[Field_Phethoi]=_KetquathanhphamEntity.Phethoi;
			}
			catch { }
			
			try
			{
				r[Field_Phechinhmay]=_KetquathanhphamEntity.Phechinhmay;
			}
			catch { }
			
			try
			{
				r[Field_Phekhac]=_KetquathanhphamEntity.Phekhac;
			}
			catch { }
			
			try
			{
				r[Field_Titrongtui]=_KetquathanhphamEntity.Titrongtui;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_KetquathanhphamEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_KetquathanhphamEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_KetquathanhphamEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_KetquathanhphamEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Socon]=_KetquathanhphamEntity.Socon;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public KetquathanhphamEntity Convert(DataRow r)
		{	
			
			KetquathanhphamEntity _KetquathanhphamEntity=new KetquathanhphamEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_KetquathanhphamEntity.Ngay= System.DateTime.Parse(r[Field_Ngay].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Ca= System.Int32.Parse(r[Field_Ca].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Mamay= r[Field_Mamay].ToString();						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.SoLsx= r[Field_SoLsx].ToString();						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Masanpham= r[Field_Masanpham].ToString();						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Macongnhan= r[Field_Macongnhan].ToString();						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Tensanpham= r[Field_Tensanpham].ToString();						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Tenmay= r[Field_Tenmay].ToString();						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Tencongnhan= r[Field_Tencongnhan].ToString();						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.SoMetvao= System.Decimal.Parse(r[Field_SoMetvao].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.SoKgvao= System.Decimal.Parse(r[Field_SoKgvao].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Thoigianbatdau= System.DateTime.Parse(r[Field_Thoigianbatdau].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Thoigianketthuc= System.DateTime.Parse(r[Field_Thoigianketthuc].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Thoigianchuanbi= System.Decimal.Parse(r[Field_Thoigianchuanbi].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Thoigianhacuon= System.Decimal.Parse(r[Field_Thoigianhacuon].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Thoigiancatdau= System.Decimal.Parse(r[Field_Thoigiancatdau].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Thoigiansuco= System.Decimal.Parse(r[Field_Thoigiansuco].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Dgnangsuat= System.Decimal.Parse(r[Field_Dgnangsuat].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Dmtui= System.Decimal.Parse(r[Field_Dmtui].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Ttetui= System.Decimal.Parse(r[Field_Ttetui].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Kiemtra= System.Decimal.Parse(r[Field_Kiemtra].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Phein= System.Decimal.Parse(r[Field_Phein].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Pheghep= System.Decimal.Parse(r[Field_Pheghep].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Phechia= System.Decimal.Parse(r[Field_Phechia].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Phebien= System.Decimal.Parse(r[Field_Phebien].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Phethoi= System.Decimal.Parse(r[Field_Phethoi].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Phechinhmay= System.Decimal.Parse(r[Field_Phechinhmay].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Phekhac= System.Decimal.Parse(r[Field_Phekhac].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Titrongtui= System.Decimal.Parse(r[Field_Titrongtui].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_KetquathanhphamEntity.Socon= System.Int32.Parse(r[Field_Socon].ToString());						
			}
			catch { }
									
									
			return _KetquathanhphamEntity;
		}			
		
		public KetquathanhphamEntity Convert_Entity(KetquathanhphamEntity _KetquathanhphamEntity,KetquathanhphamEntity _KetquathanhphamEntity_XML)
		{	
			
			
			_KetquathanhphamEntity.Id= _KetquathanhphamEntity_XML.Id;
			
			_KetquathanhphamEntity.Ngay= _KetquathanhphamEntity_XML.Ngay;
			
			_KetquathanhphamEntity.Ca= _KetquathanhphamEntity_XML.Ca;
			
			_KetquathanhphamEntity.Mamay= _KetquathanhphamEntity_XML.Mamay;
			
			_KetquathanhphamEntity.SoLsx= _KetquathanhphamEntity_XML.SoLsx;
			
			_KetquathanhphamEntity.Masanpham= _KetquathanhphamEntity_XML.Masanpham;
			
			_KetquathanhphamEntity.Macongnhan= _KetquathanhphamEntity_XML.Macongnhan;
			
			_KetquathanhphamEntity.Tensanpham= _KetquathanhphamEntity_XML.Tensanpham;
			
			_KetquathanhphamEntity.Tenmay= _KetquathanhphamEntity_XML.Tenmay;
			
			_KetquathanhphamEntity.Tencongnhan= _KetquathanhphamEntity_XML.Tencongnhan;
			
			_KetquathanhphamEntity.SoMetvao= _KetquathanhphamEntity_XML.SoMetvao;
			
			_KetquathanhphamEntity.SoKgvao= _KetquathanhphamEntity_XML.SoKgvao;
			
			_KetquathanhphamEntity.Thoigianbatdau= _KetquathanhphamEntity_XML.Thoigianbatdau;
			
			_KetquathanhphamEntity.Thoigianketthuc= _KetquathanhphamEntity_XML.Thoigianketthuc;
			
			_KetquathanhphamEntity.Thoigianchuanbi= _KetquathanhphamEntity_XML.Thoigianchuanbi;
			
			_KetquathanhphamEntity.Thoigianhacuon= _KetquathanhphamEntity_XML.Thoigianhacuon;
			
			_KetquathanhphamEntity.Thoigiancatdau= _KetquathanhphamEntity_XML.Thoigiancatdau;
			
			_KetquathanhphamEntity.Thoigiansuco= _KetquathanhphamEntity_XML.Thoigiansuco;
			
			_KetquathanhphamEntity.Dgnangsuat= _KetquathanhphamEntity_XML.Dgnangsuat;
			
			_KetquathanhphamEntity.Dmtui= _KetquathanhphamEntity_XML.Dmtui;
			
			_KetquathanhphamEntity.Ttetui= _KetquathanhphamEntity_XML.Ttetui;
			
			_KetquathanhphamEntity.Kiemtra= _KetquathanhphamEntity_XML.Kiemtra;
			
			_KetquathanhphamEntity.Phein= _KetquathanhphamEntity_XML.Phein;
			
			_KetquathanhphamEntity.Pheghep= _KetquathanhphamEntity_XML.Pheghep;
			
			_KetquathanhphamEntity.Phechia= _KetquathanhphamEntity_XML.Phechia;
			
			_KetquathanhphamEntity.Phebien= _KetquathanhphamEntity_XML.Phebien;
			
			_KetquathanhphamEntity.Phethoi= _KetquathanhphamEntity_XML.Phethoi;
			
			_KetquathanhphamEntity.Phechinhmay= _KetquathanhphamEntity_XML.Phechinhmay;
			
			_KetquathanhphamEntity.Phekhac= _KetquathanhphamEntity_XML.Phekhac;
			
			_KetquathanhphamEntity.Titrongtui= _KetquathanhphamEntity_XML.Titrongtui;
			
			_KetquathanhphamEntity.Ngaytao= _KetquathanhphamEntity_XML.Ngaytao;
			
			_KetquathanhphamEntity.Nguoitao= _KetquathanhphamEntity_XML.Nguoitao;
			
			_KetquathanhphamEntity.Ngaysua= _KetquathanhphamEntity_XML.Ngaysua;
			
			_KetquathanhphamEntity.Nguoisua= _KetquathanhphamEntity_XML.Nguoisua;
			
			_KetquathanhphamEntity.Socon= _KetquathanhphamEntity_XML.Socon;
									
				
			return _KetquathanhphamEntity;
		}	
		
		public String InsertV2(KetquathanhphamEntity _KetquathanhphamEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new KetquathanhphamManagerBase()).Insert(_KetquathanhphamEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_KetquathanhphamEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngay,_KetquathanhphamEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KetquathanhphamEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KetquathanhphamEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_SoLsx,_KetquathanhphamEntity.SoLsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KetquathanhphamEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongnhan,_KetquathanhphamEntity.Macongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_KetquathanhphamEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmay,_KetquathanhphamEntity.Tenmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongnhan,_KetquathanhphamEntity.Tencongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_SoMetvao,_KetquathanhphamEntity.SoMetvao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_SoKgvao,_KetquathanhphamEntity.SoKgvao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianbatdau,_KetquathanhphamEntity.Thoigianbatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianketthuc,_KetquathanhphamEntity.Thoigianketthuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianchuanbi,_KetquathanhphamEntity.Thoigianchuanbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianhacuon,_KetquathanhphamEntity.Thoigianhacuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiancatdau,_KetquathanhphamEntity.Thoigiancatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiansuco,_KetquathanhphamEntity.Thoigiansuco);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dgnangsuat,_KetquathanhphamEntity.Dgnangsuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dmtui,_KetquathanhphamEntity.Dmtui);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ttetui,_KetquathanhphamEntity.Ttetui);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kiemtra,_KetquathanhphamEntity.Kiemtra);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phein,_KetquathanhphamEntity.Phein);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Pheghep,_KetquathanhphamEntity.Pheghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phechia,_KetquathanhphamEntity.Phechia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phebien,_KetquathanhphamEntity.Phebien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phethoi,_KetquathanhphamEntity.Phethoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phechinhmay,_KetquathanhphamEntity.Phechinhmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phekhac,_KetquathanhphamEntity.Phekhac);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Titrongtui,_KetquathanhphamEntity.Titrongtui);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KetquathanhphamEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KetquathanhphamEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KetquathanhphamEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KetquathanhphamEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Socon,_KetquathanhphamEntity.Socon);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(KetquathanhphamEntity _KetquathanhphamEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new KetquathanhphamManagerBase()).Update(_KetquathanhphamEntity);
			r.SetField(Field_Id,_KetquathanhphamEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngay,_KetquathanhphamEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KetquathanhphamEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KetquathanhphamEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_SoLsx,_KetquathanhphamEntity.SoLsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KetquathanhphamEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongnhan,_KetquathanhphamEntity.Macongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_KetquathanhphamEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmay,_KetquathanhphamEntity.Tenmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongnhan,_KetquathanhphamEntity.Tencongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_SoMetvao,_KetquathanhphamEntity.SoMetvao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_SoKgvao,_KetquathanhphamEntity.SoKgvao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianbatdau,_KetquathanhphamEntity.Thoigianbatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianketthuc,_KetquathanhphamEntity.Thoigianketthuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianchuanbi,_KetquathanhphamEntity.Thoigianchuanbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianhacuon,_KetquathanhphamEntity.Thoigianhacuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiancatdau,_KetquathanhphamEntity.Thoigiancatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiansuco,_KetquathanhphamEntity.Thoigiansuco);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dgnangsuat,_KetquathanhphamEntity.Dgnangsuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dmtui,_KetquathanhphamEntity.Dmtui);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ttetui,_KetquathanhphamEntity.Ttetui);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kiemtra,_KetquathanhphamEntity.Kiemtra);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phein,_KetquathanhphamEntity.Phein);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Pheghep,_KetquathanhphamEntity.Pheghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phechia,_KetquathanhphamEntity.Phechia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phebien,_KetquathanhphamEntity.Phebien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phethoi,_KetquathanhphamEntity.Phethoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phechinhmay,_KetquathanhphamEntity.Phechinhmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phekhac,_KetquathanhphamEntity.Phekhac);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Titrongtui,_KetquathanhphamEntity.Titrongtui);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KetquathanhphamEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KetquathanhphamEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KetquathanhphamEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KetquathanhphamEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Socon,_KetquathanhphamEntity.Socon);
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

		public KetquathanhphamEntity Insert(KetquathanhphamEntity KetquathanhphamEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(KetquathanhphamEntity, true);
			}
			return KetquathanhphamEntity;
		}

		public KetquathanhphamEntity Insert(System.Int64  Id, System.DateTime  Ngay, System.Int32  Ca, System.String  Mamay, System.String  SoLsx, System.String  Masanpham, System.String  Macongnhan, System.String  Tensanpham, System.String  Tenmay, System.String  Tencongnhan, System.Decimal  SoMetvao, System.Decimal  SoKgvao, System.DateTime  Thoigianbatdau, System.DateTime  Thoigianketthuc, System.Decimal  Thoigianchuanbi, System.Decimal  Thoigianhacuon, System.Decimal  Thoigiancatdau, System.Decimal  Thoigiansuco, System.Decimal  Dgnangsuat, System.Decimal  Dmtui, System.Decimal  Ttetui, System.Decimal  Kiemtra, System.Decimal  Phein, System.Decimal  Pheghep, System.Decimal  Phechia, System.Decimal  Phebien, System.Decimal  Phethoi, System.Decimal  Phechinhmay, System.Decimal  Phekhac, System.Decimal  Titrongtui, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.Int32  Socon)
		{
			KetquathanhphamEntity _KetquathanhphamEntity = new KetquathanhphamEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KetquathanhphamEntity.Id = Id;
				
				_KetquathanhphamEntity.Ngay = Ngay;
				
				_KetquathanhphamEntity.Ca = Ca;
				
				_KetquathanhphamEntity.Mamay = Mamay;
				
				_KetquathanhphamEntity.SoLsx = SoLsx;
				
				_KetquathanhphamEntity.Masanpham = Masanpham;
				
				_KetquathanhphamEntity.Macongnhan = Macongnhan;
				
				_KetquathanhphamEntity.Tensanpham = Tensanpham;
				
				_KetquathanhphamEntity.Tenmay = Tenmay;
				
				_KetquathanhphamEntity.Tencongnhan = Tencongnhan;
				
				_KetquathanhphamEntity.SoMetvao = SoMetvao;
				
				_KetquathanhphamEntity.SoKgvao = SoKgvao;
				
				_KetquathanhphamEntity.Thoigianbatdau = Thoigianbatdau;
				
				_KetquathanhphamEntity.Thoigianketthuc = Thoigianketthuc;
				
				_KetquathanhphamEntity.Thoigianchuanbi = Thoigianchuanbi;
				
				_KetquathanhphamEntity.Thoigianhacuon = Thoigianhacuon;
				
				_KetquathanhphamEntity.Thoigiancatdau = Thoigiancatdau;
				
				_KetquathanhphamEntity.Thoigiansuco = Thoigiansuco;
				
				_KetquathanhphamEntity.Dgnangsuat = Dgnangsuat;
				
				_KetquathanhphamEntity.Dmtui = Dmtui;
				
				_KetquathanhphamEntity.Ttetui = Ttetui;
				
				_KetquathanhphamEntity.Kiemtra = Kiemtra;
				
				_KetquathanhphamEntity.Phein = Phein;
				
				_KetquathanhphamEntity.Pheghep = Pheghep;
				
				_KetquathanhphamEntity.Phechia = Phechia;
				
				_KetquathanhphamEntity.Phebien = Phebien;
				
				_KetquathanhphamEntity.Phethoi = Phethoi;
				
				_KetquathanhphamEntity.Phechinhmay = Phechinhmay;
				
				_KetquathanhphamEntity.Phekhac = Phekhac;
				
				_KetquathanhphamEntity.Titrongtui = Titrongtui;
				
				_KetquathanhphamEntity.Ngaytao = Ngaytao;
				
				_KetquathanhphamEntity.Nguoitao = Nguoitao;
				
				_KetquathanhphamEntity.Ngaysua = Ngaysua;
				
				_KetquathanhphamEntity.Nguoisua = Nguoisua;
				
				_KetquathanhphamEntity.Socon = Socon;
					
					
				adapter.SaveEntity(_KetquathanhphamEntity, true);
			}
			return _KetquathanhphamEntity;
		}

		public KetquathanhphamEntity Insert(System.DateTime Ngay, System.Int32 Ca, System.String Mamay, System.String SoLsx, System.String Masanpham, System.String Macongnhan, System.String Tensanpham, System.String Tenmay, System.String Tencongnhan, System.Decimal SoMetvao, System.Decimal SoKgvao, System.DateTime Thoigianbatdau, System.DateTime Thoigianketthuc, System.Decimal Thoigianchuanbi, System.Decimal Thoigianhacuon, System.Decimal Thoigiancatdau, System.Decimal Thoigiansuco, System.Decimal Dgnangsuat, System.Decimal Dmtui, System.Decimal Ttetui, System.Decimal Kiemtra, System.Decimal Phein, System.Decimal Pheghep, System.Decimal Phechia, System.Decimal Phebien, System.Decimal Phethoi, System.Decimal Phechinhmay, System.Decimal Phekhac, System.Decimal Titrongtui, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Int32 Socon)//ko co mahieu
		{
			KetquathanhphamEntity _KetquathanhphamEntity = new KetquathanhphamEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_KetquathanhphamEntity.Ngay = Ngay;
				
				_KetquathanhphamEntity.Ca = Ca;
				
				_KetquathanhphamEntity.Mamay = Mamay;
				
				_KetquathanhphamEntity.SoLsx = SoLsx;
				
				_KetquathanhphamEntity.Masanpham = Masanpham;
				
				_KetquathanhphamEntity.Macongnhan = Macongnhan;
				
				_KetquathanhphamEntity.Tensanpham = Tensanpham;
				
				_KetquathanhphamEntity.Tenmay = Tenmay;
				
				_KetquathanhphamEntity.Tencongnhan = Tencongnhan;
				
				_KetquathanhphamEntity.SoMetvao = SoMetvao;
				
				_KetquathanhphamEntity.SoKgvao = SoKgvao;
				
				_KetquathanhphamEntity.Thoigianbatdau = Thoigianbatdau;
				
				_KetquathanhphamEntity.Thoigianketthuc = Thoigianketthuc;
				
				_KetquathanhphamEntity.Thoigianchuanbi = Thoigianchuanbi;
				
				_KetquathanhphamEntity.Thoigianhacuon = Thoigianhacuon;
				
				_KetquathanhphamEntity.Thoigiancatdau = Thoigiancatdau;
				
				_KetquathanhphamEntity.Thoigiansuco = Thoigiansuco;
				
				_KetquathanhphamEntity.Dgnangsuat = Dgnangsuat;
				
				_KetquathanhphamEntity.Dmtui = Dmtui;
				
				_KetquathanhphamEntity.Ttetui = Ttetui;
				
				_KetquathanhphamEntity.Kiemtra = Kiemtra;
				
				_KetquathanhphamEntity.Phein = Phein;
				
				_KetquathanhphamEntity.Pheghep = Pheghep;
				
				_KetquathanhphamEntity.Phechia = Phechia;
				
				_KetquathanhphamEntity.Phebien = Phebien;
				
				_KetquathanhphamEntity.Phethoi = Phethoi;
				
				_KetquathanhphamEntity.Phechinhmay = Phechinhmay;
				
				_KetquathanhphamEntity.Phekhac = Phekhac;
				
				_KetquathanhphamEntity.Titrongtui = Titrongtui;
				
				_KetquathanhphamEntity.Ngaytao = Ngaytao;
				
				_KetquathanhphamEntity.Nguoitao = Nguoitao;
				
				_KetquathanhphamEntity.Ngaysua = Ngaysua;
				
				_KetquathanhphamEntity.Nguoisua = Nguoisua;
				
				_KetquathanhphamEntity.Socon = Socon;
					

				adapter.SaveEntity(_KetquathanhphamEntity, true);
			}
			return _KetquathanhphamEntity;
		}

		public bool Update(KetquathanhphamEntity _KetquathanhphamEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(KetquathanhphamFields.Id == _KetquathanhphamEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_KetquathanhphamEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(KetquathanhphamEntity _KetquathanhphamEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_KetquathanhphamEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngay, System.Int32 Ca, System.String Mamay, System.String SoLsx, System.String Masanpham, System.String Macongnhan, System.String Tensanpham, System.String Tenmay, System.String Tencongnhan, System.Decimal SoMetvao, System.Decimal SoKgvao, System.DateTime Thoigianbatdau, System.DateTime Thoigianketthuc, System.Decimal Thoigianchuanbi, System.Decimal Thoigianhacuon, System.Decimal Thoigiancatdau, System.Decimal Thoigiansuco, System.Decimal Dgnangsuat, System.Decimal Dmtui, System.Decimal Ttetui, System.Decimal Kiemtra, System.Decimal Phein, System.Decimal Pheghep, System.Decimal Phechia, System.Decimal Phebien, System.Decimal Phethoi, System.Decimal Phechinhmay, System.Decimal Phekhac, System.Decimal Titrongtui, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Int32 Socon)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquathanhphamEntity _KetquathanhphamEntity = new KetquathanhphamEntity(Id);
				if (adapter.FetchEntity(_KetquathanhphamEntity))
				{
				
					
					
					_KetquathanhphamEntity.Ngay = Ngay;
					
					_KetquathanhphamEntity.Ca = Ca;
					
					_KetquathanhphamEntity.Mamay = Mamay;
					
					_KetquathanhphamEntity.SoLsx = SoLsx;
					
					_KetquathanhphamEntity.Masanpham = Masanpham;
					
					_KetquathanhphamEntity.Macongnhan = Macongnhan;
					
					_KetquathanhphamEntity.Tensanpham = Tensanpham;
					
					_KetquathanhphamEntity.Tenmay = Tenmay;
					
					_KetquathanhphamEntity.Tencongnhan = Tencongnhan;
					
					_KetquathanhphamEntity.SoMetvao = SoMetvao;
					
					_KetquathanhphamEntity.SoKgvao = SoKgvao;
					
					_KetquathanhphamEntity.Thoigianbatdau = Thoigianbatdau;
					
					_KetquathanhphamEntity.Thoigianketthuc = Thoigianketthuc;
					
					_KetquathanhphamEntity.Thoigianchuanbi = Thoigianchuanbi;
					
					_KetquathanhphamEntity.Thoigianhacuon = Thoigianhacuon;
					
					_KetquathanhphamEntity.Thoigiancatdau = Thoigiancatdau;
					
					_KetquathanhphamEntity.Thoigiansuco = Thoigiansuco;
					
					_KetquathanhphamEntity.Dgnangsuat = Dgnangsuat;
					
					_KetquathanhphamEntity.Dmtui = Dmtui;
					
					_KetquathanhphamEntity.Ttetui = Ttetui;
					
					_KetquathanhphamEntity.Kiemtra = Kiemtra;
					
					_KetquathanhphamEntity.Phein = Phein;
					
					_KetquathanhphamEntity.Pheghep = Pheghep;
					
					_KetquathanhphamEntity.Phechia = Phechia;
					
					_KetquathanhphamEntity.Phebien = Phebien;
					
					_KetquathanhphamEntity.Phethoi = Phethoi;
					
					_KetquathanhphamEntity.Phechinhmay = Phechinhmay;
					
					_KetquathanhphamEntity.Phekhac = Phekhac;
					
					_KetquathanhphamEntity.Titrongtui = Titrongtui;
					
					_KetquathanhphamEntity.Ngaytao = Ngaytao;
					
					_KetquathanhphamEntity.Nguoitao = Nguoitao;
					
					_KetquathanhphamEntity.Ngaysua = Ngaysua;
					
					_KetquathanhphamEntity.Nguoisua = Nguoisua;
					
					_KetquathanhphamEntity.Socon = Socon;
						

					adapter.SaveEntity(_KetquathanhphamEntity, true);
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
				KetquathanhphamEntity _KetquathanhphamEntity = new KetquathanhphamEntity(Id);
				if (adapter.FetchEntity(_KetquathanhphamEntity))
				{
					adapter.DeleteEntity(_KetquathanhphamEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgay(System.DateTime Ngay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCa(System.Int32 Ca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamay(System.String Mamay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoLsx(System.String SoLsx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.SoLsx == SoLsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasanpham(System.String Masanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMacongnhan(System.String Macongnhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensanpham(System.String Tensanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmay(System.String Tenmay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTencongnhan(System.String Tencongnhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoMetvao(System.Decimal SoMetvao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.SoMetvao == SoMetvao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoKgvao(System.Decimal SoKgvao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.SoKgvao == SoKgvao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianbatdau(System.DateTime Thoigianbatdau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianketthuc(System.DateTime Thoigianketthuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianchuanbi(System.Decimal Thoigianchuanbi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Thoigianchuanbi == Thoigianchuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianhacuon(System.Decimal Thoigianhacuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Thoigianhacuon == Thoigianhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigiancatdau(System.Decimal Thoigiancatdau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Thoigiancatdau == Thoigiancatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigiansuco(System.Decimal Thoigiansuco)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDgnangsuat(System.Decimal Dgnangsuat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Dgnangsuat == Dgnangsuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDmtui(System.Decimal Dmtui)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Dmtui == Dmtui);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTtetui(System.Decimal Ttetui)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Ttetui == Ttetui);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKiemtra(System.Decimal Kiemtra)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Kiemtra == Kiemtra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhein(System.Decimal Phein)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Phein == Phein);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPheghep(System.Decimal Pheghep)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Pheghep == Pheghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhechia(System.Decimal Phechia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Phechia == Phechia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhebien(System.Decimal Phebien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Phebien == Phebien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhethoi(System.Decimal Phethoi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Phethoi == Phethoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhechinhmay(System.Decimal Phechinhmay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Phechinhmay == Phechinhmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhekhac(System.Decimal Phekhac)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Phekhac == Phekhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTitrongtui(System.Decimal Titrongtui)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Titrongtui == Titrongtui);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySocon(System.Int32 Socon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Socon == Socon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquathanhphamEntity", filter);
			}
			return toReturn;
		}		
			
		
		public KetquathanhphamEntity SelectOne(System.Int64 Id)
		{
			KetquathanhphamEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquathanhphamEntity _KetquathanhphamEntity = new KetquathanhphamEntity(Id);
				if (adapter.FetchEntity(_KetquathanhphamEntity))
				{
					toReturn = _KetquathanhphamEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection( new KetquathanhphamEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, null, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgay(System.DateTime Ngay)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayRDT(System.DateTime Ngay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCa(System.Int32 Ca)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByCaRDT(System.Int32 Ca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamay(System.String Mamay)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByMamayRDT(System.String Mamay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoLsx(System.String SoLsx)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.SoLsx == SoLsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectBySoLsxRDT(System.String SoLsx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.SoLsx == SoLsx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasanpham(System.String Masanpham)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByMasanphamRDT(System.String Masanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMacongnhan(System.String Macongnhan)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByMacongnhanRDT(System.String Macongnhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensanpham(System.String Tensanpham)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByTensanphamRDT(System.String Tensanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmay(System.String Tenmay)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmayRDT(System.String Tenmay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTencongnhan(System.String Tencongnhan)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByTencongnhanRDT(System.String Tencongnhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoMetvao(System.Decimal SoMetvao)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.SoMetvao == SoMetvao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectBySoMetvaoRDT(System.Decimal SoMetvao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.SoMetvao == SoMetvao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoKgvao(System.Decimal SoKgvao)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.SoKgvao == SoKgvao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectBySoKgvaoRDT(System.Decimal SoKgvao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.SoKgvao == SoKgvao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianbatdau(System.DateTime Thoigianbatdau)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianbatdauRDT(System.DateTime Thoigianbatdau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianketthuc(System.DateTime Thoigianketthuc)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianketthucRDT(System.DateTime Thoigianketthuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianchuanbi(System.Decimal Thoigianchuanbi)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Thoigianchuanbi == Thoigianchuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianchuanbiRDT(System.Decimal Thoigianchuanbi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Thoigianchuanbi == Thoigianchuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianhacuon(System.Decimal Thoigianhacuon)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Thoigianhacuon == Thoigianhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianhacuonRDT(System.Decimal Thoigianhacuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Thoigianhacuon == Thoigianhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigiancatdau(System.Decimal Thoigiancatdau)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Thoigiancatdau == Thoigiancatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigiancatdauRDT(System.Decimal Thoigiancatdau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Thoigiancatdau == Thoigiancatdau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigiansuco(System.Decimal Thoigiansuco)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigiansucoRDT(System.Decimal Thoigiansuco)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDgnangsuat(System.Decimal Dgnangsuat)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Dgnangsuat == Dgnangsuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByDgnangsuatRDT(System.Decimal Dgnangsuat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Dgnangsuat == Dgnangsuat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDmtui(System.Decimal Dmtui)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Dmtui == Dmtui);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByDmtuiRDT(System.Decimal Dmtui)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Dmtui == Dmtui);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTtetui(System.Decimal Ttetui)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Ttetui == Ttetui);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByTtetuiRDT(System.Decimal Ttetui)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Ttetui == Ttetui);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKiemtra(System.Decimal Kiemtra)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Kiemtra == Kiemtra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByKiemtraRDT(System.Decimal Kiemtra)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Kiemtra == Kiemtra);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhein(System.Decimal Phein)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Phein == Phein);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByPheinRDT(System.Decimal Phein)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Phein == Phein);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPheghep(System.Decimal Pheghep)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Pheghep == Pheghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByPheghepRDT(System.Decimal Pheghep)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Pheghep == Pheghep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhechia(System.Decimal Phechia)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Phechia == Phechia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByPhechiaRDT(System.Decimal Phechia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Phechia == Phechia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhebien(System.Decimal Phebien)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Phebien == Phebien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByPhebienRDT(System.Decimal Phebien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Phebien == Phebien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhethoi(System.Decimal Phethoi)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Phethoi == Phethoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByPhethoiRDT(System.Decimal Phethoi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Phethoi == Phethoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhechinhmay(System.Decimal Phechinhmay)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Phechinhmay == Phechinhmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByPhechinhmayRDT(System.Decimal Phechinhmay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Phechinhmay == Phechinhmay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhekhac(System.Decimal Phekhac)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Phekhac == Phekhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByPhekhacRDT(System.Decimal Phekhac)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Phekhac == Phekhac);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTitrongtui(System.Decimal Titrongtui)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Titrongtui == Titrongtui);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByTitrongtuiRDT(System.Decimal Titrongtui)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Titrongtui == Titrongtui);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySocon(System.Int32 Socon)
		{
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Socon == Socon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquathanhphamCollection, filter, 0, null);
			}
			return _KetquathanhphamCollection;
		}
		// Return DataTable
		public DataTable SelectBySoconRDT(System.Int32 Socon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquathanhphamCollection = new EntityCollection(new KetquathanhphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquathanhphamFields.Socon == Socon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquathanhphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
