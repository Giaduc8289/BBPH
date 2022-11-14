


/*
'===============================================================================
'  GD.BBPH.BL.KetquahoanthienManagerBase
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
	public class KetquahoanthienManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngay="Ngay";				
		
		public const String Field_Ca="Ca";				
		
		public const String Field_Mamay="Mamay";				
		
		public const String Field_Tenmay="Tenmay";				
		
		public const String Field_Lenhhoanthien="Lenhhoanthien";				
		
		public const String Field_Masanpham="Masanpham";				
		
		public const String Field_Tensanpham="Tensanpham";				
		
		public const String Field_Macongnhan="Macongnhan";				
		
		public const String Field_Tencongnhan="Tencongnhan";				
		
		public const String Field_Daurachiaghep="Daurachiaghep";				
		
		public const String Field_Dauvaomet="Dauvaomet";				
		
		public const String Field_Dauvaokg="Dauvaokg";				
		
		public const String Field_Thoigianbatdau="Thoigianbatdau";				
		
		public const String Field_Thoigianketthuc="Thoigianketthuc";				
		
		public const String Field_Thoigianchuanbi="Thoigianchuanbi";				
		
		public const String Field_Thoigianlenhacuon="Thoigianlenhacuon";				
		
		public const String Field_Thoigiancatdau="Thoigiancatdau";				
		
		public const String Field_Thoigiansuco="Thoigiansuco";				
		
		public const String Field_Ketquatui="Ketquatui";				
		
		public const String Field_Phein="Phein";				
		
		public const String Field_Pheghep="Pheghep";				
		
		public const String Field_Phechia="Phechia";				
		
		public const String Field_Phebien="Phebien";				
		
		public const String Field_Phethoi="Phethoi";				
		
		public const String Field_Phechinhmay="Phechinhmay";				
		
		public const String Field_Phekhac="Phekhac";				
		
		public const String Field_Kiemtra="Kiemtra";				
		
		public const String Field_Chatluongtui="Chatluongtui";				
		
		public const String Field_Nangsuat="Nangsuat";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
		public const String Field_Matruongca="Matruongca";				
		
		public const String Field_Tentruongca="Tentruongca";				
		
		public const String Field_Tocdodinhmuc="Tocdodinhmuc";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquahoanthienManagerBase()
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
			
			dt.Columns.Add(Field_Tenmay,typeof(System.String));
			
			dt.Columns.Add(Field_Lenhhoanthien,typeof(System.String));
			
			dt.Columns.Add(Field_Masanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Tensanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Macongnhan,typeof(System.String));
			
			dt.Columns.Add(Field_Tencongnhan,typeof(System.String));
			
			dt.Columns.Add(Field_Daurachiaghep,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dauvaomet,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dauvaokg,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigianbatdau,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigianketthuc,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigianchuanbi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigianlenhacuon,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigiancatdau,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigiansuco,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ketquatui,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phein,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Pheghep,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phechia,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phebien,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phethoi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phechinhmay,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phekhac,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Kiemtra,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Chatluongtui,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Nangsuat,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
			
			dt.Columns.Add(Field_Matruongca,typeof(System.String));
			
			dt.Columns.Add(Field_Tentruongca,typeof(System.String));
			
			dt.Columns.Add(Field_Tocdodinhmuc,typeof(System.Decimal));
									
		            
			return dt;			
		}
		public DataRow Convert(KetquahoanthienEntity _KetquahoanthienEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_KetquahoanthienEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngay]=_KetquahoanthienEntity.Ngay;
			}
			catch { }
			
			try
			{
				r[Field_Ca]=_KetquahoanthienEntity.Ca;
			}
			catch { }
			
			try
			{
				r[Field_Mamay]=_KetquahoanthienEntity.Mamay;
			}
			catch { }
			
			try
			{
				r[Field_Tenmay]=_KetquahoanthienEntity.Tenmay;
			}
			catch { }
			
			try
			{
				r[Field_Lenhhoanthien]=_KetquahoanthienEntity.Lenhhoanthien;
			}
			catch { }
			
			try
			{
				r[Field_Masanpham]=_KetquahoanthienEntity.Masanpham;
			}
			catch { }
			
			try
			{
				r[Field_Tensanpham]=_KetquahoanthienEntity.Tensanpham;
			}
			catch { }
			
			try
			{
				r[Field_Macongnhan]=_KetquahoanthienEntity.Macongnhan;
			}
			catch { }
			
			try
			{
				r[Field_Tencongnhan]=_KetquahoanthienEntity.Tencongnhan;
			}
			catch { }
			
			try
			{
				r[Field_Daurachiaghep]=_KetquahoanthienEntity.Daurachiaghep;
			}
			catch { }
			
			try
			{
				r[Field_Dauvaomet]=_KetquahoanthienEntity.Dauvaomet;
			}
			catch { }
			
			try
			{
				r[Field_Dauvaokg]=_KetquahoanthienEntity.Dauvaokg;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianbatdau]=_KetquahoanthienEntity.Thoigianbatdau;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianketthuc]=_KetquahoanthienEntity.Thoigianketthuc;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianchuanbi]=_KetquahoanthienEntity.Thoigianchuanbi;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianlenhacuon]=_KetquahoanthienEntity.Thoigianlenhacuon;
			}
			catch { }
			
			try
			{
				r[Field_Thoigiancatdau]=_KetquahoanthienEntity.Thoigiancatdau;
			}
			catch { }
			
			try
			{
				r[Field_Thoigiansuco]=_KetquahoanthienEntity.Thoigiansuco;
			}
			catch { }
			
			try
			{
				r[Field_Ketquatui]=_KetquahoanthienEntity.Ketquatui;
			}
			catch { }
			
			try
			{
				r[Field_Phein]=_KetquahoanthienEntity.Phein;
			}
			catch { }
			
			try
			{
				r[Field_Pheghep]=_KetquahoanthienEntity.Pheghep;
			}
			catch { }
			
			try
			{
				r[Field_Phechia]=_KetquahoanthienEntity.Phechia;
			}
			catch { }
			
			try
			{
				r[Field_Phebien]=_KetquahoanthienEntity.Phebien;
			}
			catch { }
			
			try
			{
				r[Field_Phethoi]=_KetquahoanthienEntity.Phethoi;
			}
			catch { }
			
			try
			{
				r[Field_Phechinhmay]=_KetquahoanthienEntity.Phechinhmay;
			}
			catch { }
			
			try
			{
				r[Field_Phekhac]=_KetquahoanthienEntity.Phekhac;
			}
			catch { }
			
			try
			{
				r[Field_Kiemtra]=_KetquahoanthienEntity.Kiemtra;
			}
			catch { }
			
			try
			{
				r[Field_Chatluongtui]=_KetquahoanthienEntity.Chatluongtui;
			}
			catch { }
			
			try
			{
				r[Field_Nangsuat]=_KetquahoanthienEntity.Nangsuat;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_KetquahoanthienEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_KetquahoanthienEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_KetquahoanthienEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_KetquahoanthienEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Matruongca]=_KetquahoanthienEntity.Matruongca;
			}
			catch { }
			
			try
			{
				r[Field_Tentruongca]=_KetquahoanthienEntity.Tentruongca;
			}
			catch { }
			
			try
			{
				r[Field_Tocdodinhmuc]=_KetquahoanthienEntity.Tocdodinhmuc;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public KetquahoanthienEntity Convert(DataRow r)
		{	
			
			KetquahoanthienEntity _KetquahoanthienEntity=new KetquahoanthienEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_KetquahoanthienEntity.Ngay= System.DateTime.Parse(r[Field_Ngay].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Ca= System.Int32.Parse(r[Field_Ca].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Mamay= r[Field_Mamay].ToString();						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Tenmay= r[Field_Tenmay].ToString();						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Lenhhoanthien= r[Field_Lenhhoanthien].ToString();						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Masanpham= r[Field_Masanpham].ToString();						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Tensanpham= r[Field_Tensanpham].ToString();						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Macongnhan= r[Field_Macongnhan].ToString();						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Tencongnhan= r[Field_Tencongnhan].ToString();						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Daurachiaghep= System.Decimal.Parse(r[Field_Daurachiaghep].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Dauvaomet= System.Decimal.Parse(r[Field_Dauvaomet].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Dauvaokg= System.Decimal.Parse(r[Field_Dauvaokg].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Thoigianbatdau= System.DateTime.Parse(r[Field_Thoigianbatdau].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Thoigianketthuc= System.DateTime.Parse(r[Field_Thoigianketthuc].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Thoigianchuanbi= System.Decimal.Parse(r[Field_Thoigianchuanbi].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Thoigianlenhacuon= System.Decimal.Parse(r[Field_Thoigianlenhacuon].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Thoigiancatdau= System.Decimal.Parse(r[Field_Thoigiancatdau].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Thoigiansuco= System.Decimal.Parse(r[Field_Thoigiansuco].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Ketquatui= System.Decimal.Parse(r[Field_Ketquatui].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Phein= System.Decimal.Parse(r[Field_Phein].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Pheghep= System.Decimal.Parse(r[Field_Pheghep].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Phechia= System.Decimal.Parse(r[Field_Phechia].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Phebien= System.Decimal.Parse(r[Field_Phebien].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Phethoi= System.Decimal.Parse(r[Field_Phethoi].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Phechinhmay= System.Decimal.Parse(r[Field_Phechinhmay].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Phekhac= System.Decimal.Parse(r[Field_Phekhac].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Kiemtra= System.Decimal.Parse(r[Field_Kiemtra].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Chatluongtui= System.Decimal.Parse(r[Field_Chatluongtui].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Nangsuat= System.Decimal.Parse(r[Field_Nangsuat].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Matruongca= r[Field_Matruongca].ToString();						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Tentruongca= r[Field_Tentruongca].ToString();						
			}
			catch { }
			
			try
			{
				_KetquahoanthienEntity.Tocdodinhmuc= System.Decimal.Parse(r[Field_Tocdodinhmuc].ToString());						
			}
			catch { }
									
									
			return _KetquahoanthienEntity;
		}			
		
		public KetquahoanthienEntity Convert_Entity(KetquahoanthienEntity _KetquahoanthienEntity,KetquahoanthienEntity _KetquahoanthienEntity_XML)
		{	
			
			
			_KetquahoanthienEntity.Id= _KetquahoanthienEntity_XML.Id;
			
			_KetquahoanthienEntity.Ngay= _KetquahoanthienEntity_XML.Ngay;
			
			_KetquahoanthienEntity.Ca= _KetquahoanthienEntity_XML.Ca;
			
			_KetquahoanthienEntity.Mamay= _KetquahoanthienEntity_XML.Mamay;
			
			_KetquahoanthienEntity.Tenmay= _KetquahoanthienEntity_XML.Tenmay;
			
			_KetquahoanthienEntity.Lenhhoanthien= _KetquahoanthienEntity_XML.Lenhhoanthien;
			
			_KetquahoanthienEntity.Masanpham= _KetquahoanthienEntity_XML.Masanpham;
			
			_KetquahoanthienEntity.Tensanpham= _KetquahoanthienEntity_XML.Tensanpham;
			
			_KetquahoanthienEntity.Macongnhan= _KetquahoanthienEntity_XML.Macongnhan;
			
			_KetquahoanthienEntity.Tencongnhan= _KetquahoanthienEntity_XML.Tencongnhan;
			
			_KetquahoanthienEntity.Daurachiaghep= _KetquahoanthienEntity_XML.Daurachiaghep;
			
			_KetquahoanthienEntity.Dauvaomet= _KetquahoanthienEntity_XML.Dauvaomet;
			
			_KetquahoanthienEntity.Dauvaokg= _KetquahoanthienEntity_XML.Dauvaokg;
			
			_KetquahoanthienEntity.Thoigianbatdau= _KetquahoanthienEntity_XML.Thoigianbatdau;
			
			_KetquahoanthienEntity.Thoigianketthuc= _KetquahoanthienEntity_XML.Thoigianketthuc;
			
			_KetquahoanthienEntity.Thoigianchuanbi= _KetquahoanthienEntity_XML.Thoigianchuanbi;
			
			_KetquahoanthienEntity.Thoigianlenhacuon= _KetquahoanthienEntity_XML.Thoigianlenhacuon;
			
			_KetquahoanthienEntity.Thoigiancatdau= _KetquahoanthienEntity_XML.Thoigiancatdau;
			
			_KetquahoanthienEntity.Thoigiansuco= _KetquahoanthienEntity_XML.Thoigiansuco;
			
			_KetquahoanthienEntity.Ketquatui= _KetquahoanthienEntity_XML.Ketquatui;
			
			_KetquahoanthienEntity.Phein= _KetquahoanthienEntity_XML.Phein;
			
			_KetquahoanthienEntity.Pheghep= _KetquahoanthienEntity_XML.Pheghep;
			
			_KetquahoanthienEntity.Phechia= _KetquahoanthienEntity_XML.Phechia;
			
			_KetquahoanthienEntity.Phebien= _KetquahoanthienEntity_XML.Phebien;
			
			_KetquahoanthienEntity.Phethoi= _KetquahoanthienEntity_XML.Phethoi;
			
			_KetquahoanthienEntity.Phechinhmay= _KetquahoanthienEntity_XML.Phechinhmay;
			
			_KetquahoanthienEntity.Phekhac= _KetquahoanthienEntity_XML.Phekhac;
			
			_KetquahoanthienEntity.Kiemtra= _KetquahoanthienEntity_XML.Kiemtra;
			
			_KetquahoanthienEntity.Chatluongtui= _KetquahoanthienEntity_XML.Chatluongtui;
			
			_KetquahoanthienEntity.Nangsuat= _KetquahoanthienEntity_XML.Nangsuat;
			
			_KetquahoanthienEntity.Ngaytao= _KetquahoanthienEntity_XML.Ngaytao;
			
			_KetquahoanthienEntity.Nguoitao= _KetquahoanthienEntity_XML.Nguoitao;
			
			_KetquahoanthienEntity.Ngaysua= _KetquahoanthienEntity_XML.Ngaysua;
			
			_KetquahoanthienEntity.Nguoisua= _KetquahoanthienEntity_XML.Nguoisua;
			
			_KetquahoanthienEntity.Matruongca= _KetquahoanthienEntity_XML.Matruongca;
			
			_KetquahoanthienEntity.Tentruongca= _KetquahoanthienEntity_XML.Tentruongca;
			
			_KetquahoanthienEntity.Tocdodinhmuc= _KetquahoanthienEntity_XML.Tocdodinhmuc;
									
				
			return _KetquahoanthienEntity;
		}	
		
		public String InsertV2(KetquahoanthienEntity _KetquahoanthienEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new KetquahoanthienManagerBase()).Insert(_KetquahoanthienEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_KetquahoanthienEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngay,_KetquahoanthienEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KetquahoanthienEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KetquahoanthienEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmay,_KetquahoanthienEntity.Tenmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhhoanthien,_KetquahoanthienEntity.Lenhhoanthien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KetquahoanthienEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_KetquahoanthienEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongnhan,_KetquahoanthienEntity.Macongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongnhan,_KetquahoanthienEntity.Tencongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Daurachiaghep,_KetquahoanthienEntity.Daurachiaghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dauvaomet,_KetquahoanthienEntity.Dauvaomet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dauvaokg,_KetquahoanthienEntity.Dauvaokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianbatdau,_KetquahoanthienEntity.Thoigianbatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianketthuc,_KetquahoanthienEntity.Thoigianketthuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianchuanbi,_KetquahoanthienEntity.Thoigianchuanbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianlenhacuon,_KetquahoanthienEntity.Thoigianlenhacuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiancatdau,_KetquahoanthienEntity.Thoigiancatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiansuco,_KetquahoanthienEntity.Thoigiansuco);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ketquatui,_KetquahoanthienEntity.Ketquatui);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phein,_KetquahoanthienEntity.Phein);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Pheghep,_KetquahoanthienEntity.Pheghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phechia,_KetquahoanthienEntity.Phechia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phebien,_KetquahoanthienEntity.Phebien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phethoi,_KetquahoanthienEntity.Phethoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phechinhmay,_KetquahoanthienEntity.Phechinhmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phekhac,_KetquahoanthienEntity.Phekhac);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kiemtra,_KetquahoanthienEntity.Kiemtra);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chatluongtui,_KetquahoanthienEntity.Chatluongtui);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nangsuat,_KetquahoanthienEntity.Nangsuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KetquahoanthienEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KetquahoanthienEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KetquahoanthienEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KetquahoanthienEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Matruongca,_KetquahoanthienEntity.Matruongca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tentruongca,_KetquahoanthienEntity.Tentruongca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tocdodinhmuc,_KetquahoanthienEntity.Tocdodinhmuc);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(KetquahoanthienEntity _KetquahoanthienEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new KetquahoanthienManagerBase()).Update(_KetquahoanthienEntity);
			r.SetField(Field_Id,_KetquahoanthienEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngay,_KetquahoanthienEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KetquahoanthienEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KetquahoanthienEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmay,_KetquahoanthienEntity.Tenmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhhoanthien,_KetquahoanthienEntity.Lenhhoanthien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KetquahoanthienEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_KetquahoanthienEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongnhan,_KetquahoanthienEntity.Macongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongnhan,_KetquahoanthienEntity.Tencongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Daurachiaghep,_KetquahoanthienEntity.Daurachiaghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dauvaomet,_KetquahoanthienEntity.Dauvaomet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dauvaokg,_KetquahoanthienEntity.Dauvaokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianbatdau,_KetquahoanthienEntity.Thoigianbatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianketthuc,_KetquahoanthienEntity.Thoigianketthuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianchuanbi,_KetquahoanthienEntity.Thoigianchuanbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianlenhacuon,_KetquahoanthienEntity.Thoigianlenhacuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiancatdau,_KetquahoanthienEntity.Thoigiancatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiansuco,_KetquahoanthienEntity.Thoigiansuco);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ketquatui,_KetquahoanthienEntity.Ketquatui);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phein,_KetquahoanthienEntity.Phein);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Pheghep,_KetquahoanthienEntity.Pheghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phechia,_KetquahoanthienEntity.Phechia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phebien,_KetquahoanthienEntity.Phebien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phethoi,_KetquahoanthienEntity.Phethoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phechinhmay,_KetquahoanthienEntity.Phechinhmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phekhac,_KetquahoanthienEntity.Phekhac);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kiemtra,_KetquahoanthienEntity.Kiemtra);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chatluongtui,_KetquahoanthienEntity.Chatluongtui);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nangsuat,_KetquahoanthienEntity.Nangsuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KetquahoanthienEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KetquahoanthienEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KetquahoanthienEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KetquahoanthienEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Matruongca,_KetquahoanthienEntity.Matruongca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tentruongca,_KetquahoanthienEntity.Tentruongca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tocdodinhmuc,_KetquahoanthienEntity.Tocdodinhmuc);
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

		public KetquahoanthienEntity Insert(KetquahoanthienEntity KetquahoanthienEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(KetquahoanthienEntity, true);
			}
			return KetquahoanthienEntity;
		}

		public KetquahoanthienEntity Insert(System.Int64  Id, System.DateTime  Ngay, System.Int32  Ca, System.String  Mamay, System.String  Tenmay, System.String  Lenhhoanthien, System.String  Masanpham, System.String  Tensanpham, System.String  Macongnhan, System.String  Tencongnhan, System.Decimal  Daurachiaghep, System.Decimal  Dauvaomet, System.Decimal  Dauvaokg, System.DateTime  Thoigianbatdau, System.DateTime  Thoigianketthuc, System.Decimal  Thoigianchuanbi, System.Decimal  Thoigianlenhacuon, System.Decimal  Thoigiancatdau, System.Decimal  Thoigiansuco, System.Decimal  Ketquatui, System.Decimal  Phein, System.Decimal  Pheghep, System.Decimal  Phechia, System.Decimal  Phebien, System.Decimal  Phethoi, System.Decimal  Phechinhmay, System.Decimal  Phekhac, System.Decimal  Kiemtra, System.Decimal  Chatluongtui, System.Decimal  Nangsuat, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.String  Matruongca, System.String  Tentruongca, System.Decimal  Tocdodinhmuc)
		{
			KetquahoanthienEntity _KetquahoanthienEntity = new KetquahoanthienEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KetquahoanthienEntity.Id = Id;
				
				_KetquahoanthienEntity.Ngay = Ngay;
				
				_KetquahoanthienEntity.Ca = Ca;
				
				_KetquahoanthienEntity.Mamay = Mamay;
				
				_KetquahoanthienEntity.Tenmay = Tenmay;
				
				_KetquahoanthienEntity.Lenhhoanthien = Lenhhoanthien;
				
				_KetquahoanthienEntity.Masanpham = Masanpham;
				
				_KetquahoanthienEntity.Tensanpham = Tensanpham;
				
				_KetquahoanthienEntity.Macongnhan = Macongnhan;
				
				_KetquahoanthienEntity.Tencongnhan = Tencongnhan;
				
				_KetquahoanthienEntity.Daurachiaghep = Daurachiaghep;
				
				_KetquahoanthienEntity.Dauvaomet = Dauvaomet;
				
				_KetquahoanthienEntity.Dauvaokg = Dauvaokg;
				
				_KetquahoanthienEntity.Thoigianbatdau = Thoigianbatdau;
				
				_KetquahoanthienEntity.Thoigianketthuc = Thoigianketthuc;
				
				_KetquahoanthienEntity.Thoigianchuanbi = Thoigianchuanbi;
				
				_KetquahoanthienEntity.Thoigianlenhacuon = Thoigianlenhacuon;
				
				_KetquahoanthienEntity.Thoigiancatdau = Thoigiancatdau;
				
				_KetquahoanthienEntity.Thoigiansuco = Thoigiansuco;
				
				_KetquahoanthienEntity.Ketquatui = Ketquatui;
				
				_KetquahoanthienEntity.Phein = Phein;
				
				_KetquahoanthienEntity.Pheghep = Pheghep;
				
				_KetquahoanthienEntity.Phechia = Phechia;
				
				_KetquahoanthienEntity.Phebien = Phebien;
				
				_KetquahoanthienEntity.Phethoi = Phethoi;
				
				_KetquahoanthienEntity.Phechinhmay = Phechinhmay;
				
				_KetquahoanthienEntity.Phekhac = Phekhac;
				
				_KetquahoanthienEntity.Kiemtra = Kiemtra;
				
				_KetquahoanthienEntity.Chatluongtui = Chatluongtui;
				
				_KetquahoanthienEntity.Nangsuat = Nangsuat;
				
				_KetquahoanthienEntity.Ngaytao = Ngaytao;
				
				_KetquahoanthienEntity.Nguoitao = Nguoitao;
				
				_KetquahoanthienEntity.Ngaysua = Ngaysua;
				
				_KetquahoanthienEntity.Nguoisua = Nguoisua;
				
				_KetquahoanthienEntity.Matruongca = Matruongca;
				
				_KetquahoanthienEntity.Tentruongca = Tentruongca;
				
				_KetquahoanthienEntity.Tocdodinhmuc = Tocdodinhmuc;
					
					
				adapter.SaveEntity(_KetquahoanthienEntity, true);
			}
			return _KetquahoanthienEntity;
		}

		public KetquahoanthienEntity Insert(System.DateTime Ngay, System.Int32 Ca, System.String Mamay, System.String Tenmay, System.String Lenhhoanthien, System.String Masanpham, System.String Tensanpham, System.String Macongnhan, System.String Tencongnhan, System.Decimal Daurachiaghep, System.Decimal Dauvaomet, System.Decimal Dauvaokg, System.DateTime Thoigianbatdau, System.DateTime Thoigianketthuc, System.Decimal Thoigianchuanbi, System.Decimal Thoigianlenhacuon, System.Decimal Thoigiancatdau, System.Decimal Thoigiansuco, System.Decimal Ketquatui, System.Decimal Phein, System.Decimal Pheghep, System.Decimal Phechia, System.Decimal Phebien, System.Decimal Phethoi, System.Decimal Phechinhmay, System.Decimal Phekhac, System.Decimal Kiemtra, System.Decimal Chatluongtui, System.Decimal Nangsuat, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.String Matruongca, System.String Tentruongca, System.Decimal Tocdodinhmuc)//ko co mahieu
		{
			KetquahoanthienEntity _KetquahoanthienEntity = new KetquahoanthienEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_KetquahoanthienEntity.Ngay = Ngay;
				
				_KetquahoanthienEntity.Ca = Ca;
				
				_KetquahoanthienEntity.Mamay = Mamay;
				
				_KetquahoanthienEntity.Tenmay = Tenmay;
				
				_KetquahoanthienEntity.Lenhhoanthien = Lenhhoanthien;
				
				_KetquahoanthienEntity.Masanpham = Masanpham;
				
				_KetquahoanthienEntity.Tensanpham = Tensanpham;
				
				_KetquahoanthienEntity.Macongnhan = Macongnhan;
				
				_KetquahoanthienEntity.Tencongnhan = Tencongnhan;
				
				_KetquahoanthienEntity.Daurachiaghep = Daurachiaghep;
				
				_KetquahoanthienEntity.Dauvaomet = Dauvaomet;
				
				_KetquahoanthienEntity.Dauvaokg = Dauvaokg;
				
				_KetquahoanthienEntity.Thoigianbatdau = Thoigianbatdau;
				
				_KetquahoanthienEntity.Thoigianketthuc = Thoigianketthuc;
				
				_KetquahoanthienEntity.Thoigianchuanbi = Thoigianchuanbi;
				
				_KetquahoanthienEntity.Thoigianlenhacuon = Thoigianlenhacuon;
				
				_KetquahoanthienEntity.Thoigiancatdau = Thoigiancatdau;
				
				_KetquahoanthienEntity.Thoigiansuco = Thoigiansuco;
				
				_KetquahoanthienEntity.Ketquatui = Ketquatui;
				
				_KetquahoanthienEntity.Phein = Phein;
				
				_KetquahoanthienEntity.Pheghep = Pheghep;
				
				_KetquahoanthienEntity.Phechia = Phechia;
				
				_KetquahoanthienEntity.Phebien = Phebien;
				
				_KetquahoanthienEntity.Phethoi = Phethoi;
				
				_KetquahoanthienEntity.Phechinhmay = Phechinhmay;
				
				_KetquahoanthienEntity.Phekhac = Phekhac;
				
				_KetquahoanthienEntity.Kiemtra = Kiemtra;
				
				_KetquahoanthienEntity.Chatluongtui = Chatluongtui;
				
				_KetquahoanthienEntity.Nangsuat = Nangsuat;
				
				_KetquahoanthienEntity.Ngaytao = Ngaytao;
				
				_KetquahoanthienEntity.Nguoitao = Nguoitao;
				
				_KetquahoanthienEntity.Ngaysua = Ngaysua;
				
				_KetquahoanthienEntity.Nguoisua = Nguoisua;
				
				_KetquahoanthienEntity.Matruongca = Matruongca;
				
				_KetquahoanthienEntity.Tentruongca = Tentruongca;
				
				_KetquahoanthienEntity.Tocdodinhmuc = Tocdodinhmuc;
					

				adapter.SaveEntity(_KetquahoanthienEntity, true);
			}
			return _KetquahoanthienEntity;
		}

		public bool Update(KetquahoanthienEntity _KetquahoanthienEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(KetquahoanthienFields.Id == _KetquahoanthienEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_KetquahoanthienEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(KetquahoanthienEntity _KetquahoanthienEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_KetquahoanthienEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngay, System.Int32 Ca, System.String Mamay, System.String Tenmay, System.String Lenhhoanthien, System.String Masanpham, System.String Tensanpham, System.String Macongnhan, System.String Tencongnhan, System.Decimal Daurachiaghep, System.Decimal Dauvaomet, System.Decimal Dauvaokg, System.DateTime Thoigianbatdau, System.DateTime Thoigianketthuc, System.Decimal Thoigianchuanbi, System.Decimal Thoigianlenhacuon, System.Decimal Thoigiancatdau, System.Decimal Thoigiansuco, System.Decimal Ketquatui, System.Decimal Phein, System.Decimal Pheghep, System.Decimal Phechia, System.Decimal Phebien, System.Decimal Phethoi, System.Decimal Phechinhmay, System.Decimal Phekhac, System.Decimal Kiemtra, System.Decimal Chatluongtui, System.Decimal Nangsuat, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.String Matruongca, System.String Tentruongca, System.Decimal Tocdodinhmuc)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquahoanthienEntity _KetquahoanthienEntity = new KetquahoanthienEntity(Id);
				if (adapter.FetchEntity(_KetquahoanthienEntity))
				{
				
					
					
					_KetquahoanthienEntity.Ngay = Ngay;
					
					_KetquahoanthienEntity.Ca = Ca;
					
					_KetquahoanthienEntity.Mamay = Mamay;
					
					_KetquahoanthienEntity.Tenmay = Tenmay;
					
					_KetquahoanthienEntity.Lenhhoanthien = Lenhhoanthien;
					
					_KetquahoanthienEntity.Masanpham = Masanpham;
					
					_KetquahoanthienEntity.Tensanpham = Tensanpham;
					
					_KetquahoanthienEntity.Macongnhan = Macongnhan;
					
					_KetquahoanthienEntity.Tencongnhan = Tencongnhan;
					
					_KetquahoanthienEntity.Daurachiaghep = Daurachiaghep;
					
					_KetquahoanthienEntity.Dauvaomet = Dauvaomet;
					
					_KetquahoanthienEntity.Dauvaokg = Dauvaokg;
					
					_KetquahoanthienEntity.Thoigianbatdau = Thoigianbatdau;
					
					_KetquahoanthienEntity.Thoigianketthuc = Thoigianketthuc;
					
					_KetquahoanthienEntity.Thoigianchuanbi = Thoigianchuanbi;
					
					_KetquahoanthienEntity.Thoigianlenhacuon = Thoigianlenhacuon;
					
					_KetquahoanthienEntity.Thoigiancatdau = Thoigiancatdau;
					
					_KetquahoanthienEntity.Thoigiansuco = Thoigiansuco;
					
					_KetquahoanthienEntity.Ketquatui = Ketquatui;
					
					_KetquahoanthienEntity.Phein = Phein;
					
					_KetquahoanthienEntity.Pheghep = Pheghep;
					
					_KetquahoanthienEntity.Phechia = Phechia;
					
					_KetquahoanthienEntity.Phebien = Phebien;
					
					_KetquahoanthienEntity.Phethoi = Phethoi;
					
					_KetquahoanthienEntity.Phechinhmay = Phechinhmay;
					
					_KetquahoanthienEntity.Phekhac = Phekhac;
					
					_KetquahoanthienEntity.Kiemtra = Kiemtra;
					
					_KetquahoanthienEntity.Chatluongtui = Chatluongtui;
					
					_KetquahoanthienEntity.Nangsuat = Nangsuat;
					
					_KetquahoanthienEntity.Ngaytao = Ngaytao;
					
					_KetquahoanthienEntity.Nguoitao = Nguoitao;
					
					_KetquahoanthienEntity.Ngaysua = Ngaysua;
					
					_KetquahoanthienEntity.Nguoisua = Nguoisua;
					
					_KetquahoanthienEntity.Matruongca = Matruongca;
					
					_KetquahoanthienEntity.Tentruongca = Tentruongca;
					
					_KetquahoanthienEntity.Tocdodinhmuc = Tocdodinhmuc;
						

					adapter.SaveEntity(_KetquahoanthienEntity, true);
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
				KetquahoanthienEntity _KetquahoanthienEntity = new KetquahoanthienEntity(Id);
				if (adapter.FetchEntity(_KetquahoanthienEntity))
				{
					adapter.DeleteEntity(_KetquahoanthienEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgay(System.DateTime Ngay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCa(System.Int32 Ca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamay(System.String Mamay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmay(System.String Tenmay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLenhhoanthien(System.String Lenhhoanthien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Lenhhoanthien == Lenhhoanthien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasanpham(System.String Masanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensanpham(System.String Tensanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMacongnhan(System.String Macongnhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTencongnhan(System.String Tencongnhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDaurachiaghep(System.Decimal Daurachiaghep)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Daurachiaghep == Daurachiaghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDauvaomet(System.Decimal Dauvaomet)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Dauvaomet == Dauvaomet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDauvaokg(System.Decimal Dauvaokg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Dauvaokg == Dauvaokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianbatdau(System.DateTime Thoigianbatdau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianketthuc(System.DateTime Thoigianketthuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianchuanbi(System.Decimal Thoigianchuanbi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Thoigianchuanbi == Thoigianchuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianlenhacuon(System.Decimal Thoigianlenhacuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Thoigianlenhacuon == Thoigianlenhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigiancatdau(System.Decimal Thoigiancatdau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Thoigiancatdau == Thoigiancatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigiansuco(System.Decimal Thoigiansuco)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKetquatui(System.Decimal Ketquatui)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Ketquatui == Ketquatui);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhein(System.Decimal Phein)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Phein == Phein);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPheghep(System.Decimal Pheghep)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Pheghep == Pheghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhechia(System.Decimal Phechia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Phechia == Phechia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhebien(System.Decimal Phebien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Phebien == Phebien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhethoi(System.Decimal Phethoi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Phethoi == Phethoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhechinhmay(System.Decimal Phechinhmay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Phechinhmay == Phechinhmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhekhac(System.Decimal Phekhac)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Phekhac == Phekhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKiemtra(System.Decimal Kiemtra)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Kiemtra == Kiemtra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByChatluongtui(System.Decimal Chatluongtui)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Chatluongtui == Chatluongtui);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNangsuat(System.Decimal Nangsuat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Nangsuat == Nangsuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMatruongca(System.String Matruongca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Matruongca == Matruongca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTentruongca(System.String Tentruongca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Tentruongca == Tentruongca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTocdodinhmuc(System.Decimal Tocdodinhmuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Tocdodinhmuc == Tocdodinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquahoanthienEntity", filter);
			}
			return toReturn;
		}		
			
		
		public KetquahoanthienEntity SelectOne(System.Int64 Id)
		{
			KetquahoanthienEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquahoanthienEntity _KetquahoanthienEntity = new KetquahoanthienEntity(Id);
				if (adapter.FetchEntity(_KetquahoanthienEntity))
				{
					toReturn = _KetquahoanthienEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection( new KetquahoanthienEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, null, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgay(System.DateTime Ngay)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayRDT(System.DateTime Ngay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCa(System.Int32 Ca)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByCaRDT(System.Int32 Ca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamay(System.String Mamay)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByMamayRDT(System.String Mamay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmay(System.String Tenmay)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmayRDT(System.String Tenmay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLenhhoanthien(System.String Lenhhoanthien)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Lenhhoanthien == Lenhhoanthien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByLenhhoanthienRDT(System.String Lenhhoanthien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Lenhhoanthien == Lenhhoanthien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasanpham(System.String Masanpham)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByMasanphamRDT(System.String Masanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensanpham(System.String Tensanpham)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByTensanphamRDT(System.String Tensanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMacongnhan(System.String Macongnhan)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByMacongnhanRDT(System.String Macongnhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTencongnhan(System.String Tencongnhan)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByTencongnhanRDT(System.String Tencongnhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDaurachiaghep(System.Decimal Daurachiaghep)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Daurachiaghep == Daurachiaghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByDaurachiaghepRDT(System.Decimal Daurachiaghep)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Daurachiaghep == Daurachiaghep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDauvaomet(System.Decimal Dauvaomet)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Dauvaomet == Dauvaomet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByDauvaometRDT(System.Decimal Dauvaomet)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Dauvaomet == Dauvaomet);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDauvaokg(System.Decimal Dauvaokg)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Dauvaokg == Dauvaokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByDauvaokgRDT(System.Decimal Dauvaokg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Dauvaokg == Dauvaokg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianbatdau(System.DateTime Thoigianbatdau)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianbatdauRDT(System.DateTime Thoigianbatdau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianketthuc(System.DateTime Thoigianketthuc)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianketthucRDT(System.DateTime Thoigianketthuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianchuanbi(System.Decimal Thoigianchuanbi)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Thoigianchuanbi == Thoigianchuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianchuanbiRDT(System.Decimal Thoigianchuanbi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Thoigianchuanbi == Thoigianchuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianlenhacuon(System.Decimal Thoigianlenhacuon)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Thoigianlenhacuon == Thoigianlenhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianlenhacuonRDT(System.Decimal Thoigianlenhacuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Thoigianlenhacuon == Thoigianlenhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigiancatdau(System.Decimal Thoigiancatdau)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Thoigiancatdau == Thoigiancatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigiancatdauRDT(System.Decimal Thoigiancatdau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Thoigiancatdau == Thoigiancatdau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigiansuco(System.Decimal Thoigiansuco)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigiansucoRDT(System.Decimal Thoigiansuco)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKetquatui(System.Decimal Ketquatui)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Ketquatui == Ketquatui);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByKetquatuiRDT(System.Decimal Ketquatui)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Ketquatui == Ketquatui);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhein(System.Decimal Phein)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Phein == Phein);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByPheinRDT(System.Decimal Phein)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Phein == Phein);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPheghep(System.Decimal Pheghep)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Pheghep == Pheghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByPheghepRDT(System.Decimal Pheghep)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Pheghep == Pheghep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhechia(System.Decimal Phechia)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Phechia == Phechia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByPhechiaRDT(System.Decimal Phechia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Phechia == Phechia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhebien(System.Decimal Phebien)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Phebien == Phebien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByPhebienRDT(System.Decimal Phebien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Phebien == Phebien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhethoi(System.Decimal Phethoi)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Phethoi == Phethoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByPhethoiRDT(System.Decimal Phethoi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Phethoi == Phethoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhechinhmay(System.Decimal Phechinhmay)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Phechinhmay == Phechinhmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByPhechinhmayRDT(System.Decimal Phechinhmay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Phechinhmay == Phechinhmay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhekhac(System.Decimal Phekhac)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Phekhac == Phekhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByPhekhacRDT(System.Decimal Phekhac)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Phekhac == Phekhac);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKiemtra(System.Decimal Kiemtra)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Kiemtra == Kiemtra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByKiemtraRDT(System.Decimal Kiemtra)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Kiemtra == Kiemtra);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByChatluongtui(System.Decimal Chatluongtui)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Chatluongtui == Chatluongtui);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByChatluongtuiRDT(System.Decimal Chatluongtui)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Chatluongtui == Chatluongtui);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNangsuat(System.Decimal Nangsuat)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Nangsuat == Nangsuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByNangsuatRDT(System.Decimal Nangsuat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Nangsuat == Nangsuat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMatruongca(System.String Matruongca)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Matruongca == Matruongca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByMatruongcaRDT(System.String Matruongca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Matruongca == Matruongca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTentruongca(System.String Tentruongca)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Tentruongca == Tentruongca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByTentruongcaRDT(System.String Tentruongca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Tentruongca == Tentruongca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTocdodinhmuc(System.Decimal Tocdodinhmuc)
		{
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Tocdodinhmuc == Tocdodinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquahoanthienCollection, filter, 0, null);
			}
			return _KetquahoanthienCollection;
		}
		// Return DataTable
		public DataTable SelectByTocdodinhmucRDT(System.Decimal Tocdodinhmuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquahoanthienFields.Tocdodinhmuc == Tocdodinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(KetquahoanthienFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
