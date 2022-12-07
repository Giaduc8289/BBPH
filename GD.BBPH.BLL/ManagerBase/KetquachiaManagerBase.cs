


/*
'===============================================================================
'  GD.BBPH.BL.KetquachiaManagerBase
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
	public class KetquachiaManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngay="Ngay";				
		
		public const String Field_Ca="Ca";				
		
		public const String Field_Mamay="Mamay";				
		
		public const String Field_Masanpham="Masanpham";				
		
		public const String Field_Macongnhan="Macongnhan";				
		
		public const String Field_Tensanpham="Tensanpham";				
		
		public const String Field_Tenmay="Tenmay";				
		
		public const String Field_Tencongnhan="Tencongnhan";				
		
		public const String Field_Dauraghep="Dauraghep";				
		
		public const String Field_Sometvao="Sometvao";				
		
		public const String Field_Sokgvao="Sokgvao";				
		
		public const String Field_Thoigianbatdau="Thoigianbatdau";				
		
		public const String Field_Thoigianketthuc="Thoigianketthuc";				
		
		public const String Field_Thoigianlencuon="Thoigianlencuon";				
		
		public const String Field_Thoigianhacuon="Thoigianhacuon";				
		
		public const String Field_Solanhacuon="Solanhacuon";				
		
		public const String Field_Thoigiancatdau="Thoigiancatdau";				
		
		public const String Field_Thoigiandoilenh="Thoigiandoilenh";				
		
		public const String Field_Thoigiansuco="Thoigiansuco";				
		
		public const String Field_Phein="Phein";				
		
		public const String Field_Pheghep="Pheghep";				
		
		public const String Field_Phechia="Phechia";				
		
		public const String Field_PhethoiNcc="PhethoiNcc";				
		
		public const String Field_Phesx="Phesx";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
		public const String Field_Nangsuat="Nangsuat";				
		
		public const String Field_Tylesaihong="Tylesaihong";				
		
		public const String Field_Socuon="Socuon";				
		
		public const String Field_Matruongca="Matruongca";				
		
		public const String Field_Tentruongca="Tentruongca";				
		
		public const String Field_Tocdodinhmuc="Tocdodinhmuc";				
		
		public const String Field_Lydosuco="Lydosuco";				
		
		public const String Field_Sometra="Sometra";				
		
		public const String Field_Sokgra="Sokgra";				
		
		public const String Field_Solenhsx="Solenhsx";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquachiaManagerBase()
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
			
			dt.Columns.Add(Field_Masanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Macongnhan,typeof(System.String));
			
			dt.Columns.Add(Field_Tensanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmay,typeof(System.String));
			
			dt.Columns.Add(Field_Tencongnhan,typeof(System.String));
			
			dt.Columns.Add(Field_Dauraghep,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sometvao,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sokgvao,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigianbatdau,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigianketthuc,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigianlencuon,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigianhacuon,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Solanhacuon,typeof(System.Int32));
			
			dt.Columns.Add(Field_Thoigiancatdau,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigiandoilenh,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigiansuco,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phein,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Pheghep,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phechia,typeof(System.Decimal));
			
			dt.Columns.Add(Field_PhethoiNcc,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phesx,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
			
			dt.Columns.Add(Field_Nangsuat,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Tylesaihong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Socuon,typeof(System.Int32));
			
			dt.Columns.Add(Field_Matruongca,typeof(System.String));
			
			dt.Columns.Add(Field_Tentruongca,typeof(System.String));
			
			dt.Columns.Add(Field_Tocdodinhmuc,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Lydosuco,typeof(System.String));
			
			dt.Columns.Add(Field_Sometra,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sokgra,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Solenhsx,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(KetquachiaEntity _KetquachiaEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_KetquachiaEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngay]=_KetquachiaEntity.Ngay;
			}
			catch { }
			
			try
			{
				r[Field_Ca]=_KetquachiaEntity.Ca;
			}
			catch { }
			
			try
			{
				r[Field_Mamay]=_KetquachiaEntity.Mamay;
			}
			catch { }
			
			try
			{
				r[Field_Masanpham]=_KetquachiaEntity.Masanpham;
			}
			catch { }
			
			try
			{
				r[Field_Macongnhan]=_KetquachiaEntity.Macongnhan;
			}
			catch { }
			
			try
			{
				r[Field_Tensanpham]=_KetquachiaEntity.Tensanpham;
			}
			catch { }
			
			try
			{
				r[Field_Tenmay]=_KetquachiaEntity.Tenmay;
			}
			catch { }
			
			try
			{
				r[Field_Tencongnhan]=_KetquachiaEntity.Tencongnhan;
			}
			catch { }
			
			try
			{
				r[Field_Dauraghep]=_KetquachiaEntity.Dauraghep;
			}
			catch { }
			
			try
			{
				r[Field_Sometvao]=_KetquachiaEntity.Sometvao;
			}
			catch { }
			
			try
			{
				r[Field_Sokgvao]=_KetquachiaEntity.Sokgvao;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianbatdau]=_KetquachiaEntity.Thoigianbatdau;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianketthuc]=_KetquachiaEntity.Thoigianketthuc;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianlencuon]=_KetquachiaEntity.Thoigianlencuon;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianhacuon]=_KetquachiaEntity.Thoigianhacuon;
			}
			catch { }
			
			try
			{
				r[Field_Solanhacuon]=_KetquachiaEntity.Solanhacuon;
			}
			catch { }
			
			try
			{
				r[Field_Thoigiancatdau]=_KetquachiaEntity.Thoigiancatdau;
			}
			catch { }
			
			try
			{
				r[Field_Thoigiandoilenh]=_KetquachiaEntity.Thoigiandoilenh;
			}
			catch { }
			
			try
			{
				r[Field_Thoigiansuco]=_KetquachiaEntity.Thoigiansuco;
			}
			catch { }
			
			try
			{
				r[Field_Phein]=_KetquachiaEntity.Phein;
			}
			catch { }
			
			try
			{
				r[Field_Pheghep]=_KetquachiaEntity.Pheghep;
			}
			catch { }
			
			try
			{
				r[Field_Phechia]=_KetquachiaEntity.Phechia;
			}
			catch { }
			
			try
			{
				r[Field_PhethoiNcc]=_KetquachiaEntity.PhethoiNcc;
			}
			catch { }
			
			try
			{
				r[Field_Phesx]=_KetquachiaEntity.Phesx;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_KetquachiaEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_KetquachiaEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_KetquachiaEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_KetquachiaEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Nangsuat]=_KetquachiaEntity.Nangsuat;
			}
			catch { }
			
			try
			{
				r[Field_Tylesaihong]=_KetquachiaEntity.Tylesaihong;
			}
			catch { }
			
			try
			{
				r[Field_Socuon]=_KetquachiaEntity.Socuon;
			}
			catch { }
			
			try
			{
				r[Field_Matruongca]=_KetquachiaEntity.Matruongca;
			}
			catch { }
			
			try
			{
				r[Field_Tentruongca]=_KetquachiaEntity.Tentruongca;
			}
			catch { }
			
			try
			{
				r[Field_Tocdodinhmuc]=_KetquachiaEntity.Tocdodinhmuc;
			}
			catch { }
			
			try
			{
				r[Field_Lydosuco]=_KetquachiaEntity.Lydosuco;
			}
			catch { }
			
			try
			{
				r[Field_Sometra]=_KetquachiaEntity.Sometra;
			}
			catch { }
			
			try
			{
				r[Field_Sokgra]=_KetquachiaEntity.Sokgra;
			}
			catch { }
			
			try
			{
				r[Field_Solenhsx]=_KetquachiaEntity.Solenhsx;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public KetquachiaEntity Convert(DataRow r)
		{	
			
			KetquachiaEntity _KetquachiaEntity=new KetquachiaEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_KetquachiaEntity.Ngay= System.DateTime.Parse(r[Field_Ngay].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Ca= System.Int32.Parse(r[Field_Ca].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Mamay= r[Field_Mamay].ToString();						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Masanpham= r[Field_Masanpham].ToString();						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Macongnhan= r[Field_Macongnhan].ToString();						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Tensanpham= r[Field_Tensanpham].ToString();						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Tenmay= r[Field_Tenmay].ToString();						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Tencongnhan= r[Field_Tencongnhan].ToString();						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Dauraghep= System.Decimal.Parse(r[Field_Dauraghep].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Sometvao= System.Decimal.Parse(r[Field_Sometvao].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Sokgvao= System.Decimal.Parse(r[Field_Sokgvao].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Thoigianbatdau= System.DateTime.Parse(r[Field_Thoigianbatdau].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Thoigianketthuc= System.DateTime.Parse(r[Field_Thoigianketthuc].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Thoigianlencuon= System.Decimal.Parse(r[Field_Thoigianlencuon].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Thoigianhacuon= System.Decimal.Parse(r[Field_Thoigianhacuon].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Solanhacuon= System.Int32.Parse(r[Field_Solanhacuon].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Thoigiancatdau= System.Decimal.Parse(r[Field_Thoigiancatdau].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Thoigiandoilenh= System.Decimal.Parse(r[Field_Thoigiandoilenh].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Thoigiansuco= System.Decimal.Parse(r[Field_Thoigiansuco].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Phein= System.Decimal.Parse(r[Field_Phein].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Pheghep= System.Decimal.Parse(r[Field_Pheghep].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Phechia= System.Decimal.Parse(r[Field_Phechia].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.PhethoiNcc= System.Decimal.Parse(r[Field_PhethoiNcc].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Phesx= System.Decimal.Parse(r[Field_Phesx].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Nangsuat= System.Decimal.Parse(r[Field_Nangsuat].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Tylesaihong= System.Decimal.Parse(r[Field_Tylesaihong].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Socuon= System.Int32.Parse(r[Field_Socuon].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Matruongca= r[Field_Matruongca].ToString();						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Tentruongca= r[Field_Tentruongca].ToString();						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Tocdodinhmuc= System.Decimal.Parse(r[Field_Tocdodinhmuc].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Lydosuco= r[Field_Lydosuco].ToString();						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Sometra= System.Decimal.Parse(r[Field_Sometra].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Sokgra= System.Decimal.Parse(r[Field_Sokgra].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Solenhsx= r[Field_Solenhsx].ToString();						
			}
			catch { }
									
									
			return _KetquachiaEntity;
		}			
		
		public KetquachiaEntity Convert_Entity(KetquachiaEntity _KetquachiaEntity,KetquachiaEntity _KetquachiaEntity_XML)
		{	
			
			
			_KetquachiaEntity.Id= _KetquachiaEntity_XML.Id;
			
			_KetquachiaEntity.Ngay= _KetquachiaEntity_XML.Ngay;
			
			_KetquachiaEntity.Ca= _KetquachiaEntity_XML.Ca;
			
			_KetquachiaEntity.Mamay= _KetquachiaEntity_XML.Mamay;
			
			_KetquachiaEntity.Masanpham= _KetquachiaEntity_XML.Masanpham;
			
			_KetquachiaEntity.Macongnhan= _KetquachiaEntity_XML.Macongnhan;
			
			_KetquachiaEntity.Tensanpham= _KetquachiaEntity_XML.Tensanpham;
			
			_KetquachiaEntity.Tenmay= _KetquachiaEntity_XML.Tenmay;
			
			_KetquachiaEntity.Tencongnhan= _KetquachiaEntity_XML.Tencongnhan;
			
			_KetquachiaEntity.Dauraghep= _KetquachiaEntity_XML.Dauraghep;
			
			_KetquachiaEntity.Sometvao= _KetquachiaEntity_XML.Sometvao;
			
			_KetquachiaEntity.Sokgvao= _KetquachiaEntity_XML.Sokgvao;
			
			_KetquachiaEntity.Thoigianbatdau= _KetquachiaEntity_XML.Thoigianbatdau;
			
			_KetquachiaEntity.Thoigianketthuc= _KetquachiaEntity_XML.Thoigianketthuc;
			
			_KetquachiaEntity.Thoigianlencuon= _KetquachiaEntity_XML.Thoigianlencuon;
			
			_KetquachiaEntity.Thoigianhacuon= _KetquachiaEntity_XML.Thoigianhacuon;
			
			_KetquachiaEntity.Solanhacuon= _KetquachiaEntity_XML.Solanhacuon;
			
			_KetquachiaEntity.Thoigiancatdau= _KetquachiaEntity_XML.Thoigiancatdau;
			
			_KetquachiaEntity.Thoigiandoilenh= _KetquachiaEntity_XML.Thoigiandoilenh;
			
			_KetquachiaEntity.Thoigiansuco= _KetquachiaEntity_XML.Thoigiansuco;
			
			_KetquachiaEntity.Phein= _KetquachiaEntity_XML.Phein;
			
			_KetquachiaEntity.Pheghep= _KetquachiaEntity_XML.Pheghep;
			
			_KetquachiaEntity.Phechia= _KetquachiaEntity_XML.Phechia;
			
			_KetquachiaEntity.PhethoiNcc= _KetquachiaEntity_XML.PhethoiNcc;
			
			_KetquachiaEntity.Phesx= _KetquachiaEntity_XML.Phesx;
			
			_KetquachiaEntity.Ngaytao= _KetquachiaEntity_XML.Ngaytao;
			
			_KetquachiaEntity.Nguoitao= _KetquachiaEntity_XML.Nguoitao;
			
			_KetquachiaEntity.Ngaysua= _KetquachiaEntity_XML.Ngaysua;
			
			_KetquachiaEntity.Nguoisua= _KetquachiaEntity_XML.Nguoisua;
			
			_KetquachiaEntity.Nangsuat= _KetquachiaEntity_XML.Nangsuat;
			
			_KetquachiaEntity.Tylesaihong= _KetquachiaEntity_XML.Tylesaihong;
			
			_KetquachiaEntity.Socuon= _KetquachiaEntity_XML.Socuon;
			
			_KetquachiaEntity.Matruongca= _KetquachiaEntity_XML.Matruongca;
			
			_KetquachiaEntity.Tentruongca= _KetquachiaEntity_XML.Tentruongca;
			
			_KetquachiaEntity.Tocdodinhmuc= _KetquachiaEntity_XML.Tocdodinhmuc;
			
			_KetquachiaEntity.Lydosuco= _KetquachiaEntity_XML.Lydosuco;
			
			_KetquachiaEntity.Sometra= _KetquachiaEntity_XML.Sometra;
			
			_KetquachiaEntity.Sokgra= _KetquachiaEntity_XML.Sokgra;
			
			_KetquachiaEntity.Solenhsx= _KetquachiaEntity_XML.Solenhsx;
									
				
			return _KetquachiaEntity;
		}	
		
		public String InsertV2(KetquachiaEntity _KetquachiaEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new KetquachiaManagerBase()).Insert(_KetquachiaEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_KetquachiaEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngay,_KetquachiaEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KetquachiaEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KetquachiaEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KetquachiaEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongnhan,_KetquachiaEntity.Macongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_KetquachiaEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmay,_KetquachiaEntity.Tenmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongnhan,_KetquachiaEntity.Tencongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dauraghep,_KetquachiaEntity.Dauraghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometvao,_KetquachiaEntity.Sometvao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgvao,_KetquachiaEntity.Sokgvao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianbatdau,_KetquachiaEntity.Thoigianbatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianketthuc,_KetquachiaEntity.Thoigianketthuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianlencuon,_KetquachiaEntity.Thoigianlencuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianhacuon,_KetquachiaEntity.Thoigianhacuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Solanhacuon,_KetquachiaEntity.Solanhacuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiancatdau,_KetquachiaEntity.Thoigiancatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiandoilenh,_KetquachiaEntity.Thoigiandoilenh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiansuco,_KetquachiaEntity.Thoigiansuco);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phein,_KetquachiaEntity.Phein);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Pheghep,_KetquachiaEntity.Pheghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phechia,_KetquachiaEntity.Phechia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_PhethoiNcc,_KetquachiaEntity.PhethoiNcc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phesx,_KetquachiaEntity.Phesx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KetquachiaEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KetquachiaEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KetquachiaEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KetquachiaEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nangsuat,_KetquachiaEntity.Nangsuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tylesaihong,_KetquachiaEntity.Tylesaihong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Socuon,_KetquachiaEntity.Socuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Matruongca,_KetquachiaEntity.Matruongca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tentruongca,_KetquachiaEntity.Tentruongca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tocdodinhmuc,_KetquachiaEntity.Tocdodinhmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lydosuco,_KetquachiaEntity.Lydosuco);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometra,_KetquachiaEntity.Sometra);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgra,_KetquachiaEntity.Sokgra);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Solenhsx,_KetquachiaEntity.Solenhsx);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(KetquachiaEntity _KetquachiaEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new KetquachiaManagerBase()).Update(_KetquachiaEntity);
			r.SetField(Field_Id,_KetquachiaEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngay,_KetquachiaEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KetquachiaEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KetquachiaEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KetquachiaEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongnhan,_KetquachiaEntity.Macongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_KetquachiaEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmay,_KetquachiaEntity.Tenmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongnhan,_KetquachiaEntity.Tencongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dauraghep,_KetquachiaEntity.Dauraghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometvao,_KetquachiaEntity.Sometvao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgvao,_KetquachiaEntity.Sokgvao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianbatdau,_KetquachiaEntity.Thoigianbatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianketthuc,_KetquachiaEntity.Thoigianketthuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianlencuon,_KetquachiaEntity.Thoigianlencuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianhacuon,_KetquachiaEntity.Thoigianhacuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Solanhacuon,_KetquachiaEntity.Solanhacuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiancatdau,_KetquachiaEntity.Thoigiancatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiandoilenh,_KetquachiaEntity.Thoigiandoilenh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiansuco,_KetquachiaEntity.Thoigiansuco);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phein,_KetquachiaEntity.Phein);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Pheghep,_KetquachiaEntity.Pheghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phechia,_KetquachiaEntity.Phechia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_PhethoiNcc,_KetquachiaEntity.PhethoiNcc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phesx,_KetquachiaEntity.Phesx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KetquachiaEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KetquachiaEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KetquachiaEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KetquachiaEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nangsuat,_KetquachiaEntity.Nangsuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tylesaihong,_KetquachiaEntity.Tylesaihong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Socuon,_KetquachiaEntity.Socuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Matruongca,_KetquachiaEntity.Matruongca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tentruongca,_KetquachiaEntity.Tentruongca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tocdodinhmuc,_KetquachiaEntity.Tocdodinhmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lydosuco,_KetquachiaEntity.Lydosuco);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometra,_KetquachiaEntity.Sometra);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgra,_KetquachiaEntity.Sokgra);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Solenhsx,_KetquachiaEntity.Solenhsx);
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

		public KetquachiaEntity Insert(KetquachiaEntity KetquachiaEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(KetquachiaEntity, true);
			}
			return KetquachiaEntity;
		}

		public KetquachiaEntity Insert(System.Int64  Id, System.DateTime  Ngay, System.Int32  Ca, System.String  Mamay, System.String  Masanpham, System.String  Macongnhan, System.String  Tensanpham, System.String  Tenmay, System.String  Tencongnhan, System.Decimal  Dauraghep, System.Decimal  Sometvao, System.Decimal  Sokgvao, System.DateTime  Thoigianbatdau, System.DateTime  Thoigianketthuc, System.Decimal  Thoigianlencuon, System.Decimal  Thoigianhacuon, System.Int32  Solanhacuon, System.Decimal  Thoigiancatdau, System.Decimal  Thoigiandoilenh, System.Decimal  Thoigiansuco, System.Decimal  Phein, System.Decimal  Pheghep, System.Decimal  Phechia, System.Decimal  PhethoiNcc, System.Decimal  Phesx, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.Decimal  Nangsuat, System.Decimal  Tylesaihong, System.Int32  Socuon, System.String  Matruongca, System.String  Tentruongca, System.Decimal  Tocdodinhmuc, System.String  Lydosuco, System.Decimal  Sometra, System.Decimal  Sokgra, System.String  Solenhsx)
		{
			KetquachiaEntity _KetquachiaEntity = new KetquachiaEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KetquachiaEntity.Id = Id;
				
				_KetquachiaEntity.Ngay = Ngay;
				
				_KetquachiaEntity.Ca = Ca;
				
				_KetquachiaEntity.Mamay = Mamay;
				
				_KetquachiaEntity.Masanpham = Masanpham;
				
				_KetquachiaEntity.Macongnhan = Macongnhan;
				
				_KetquachiaEntity.Tensanpham = Tensanpham;
				
				_KetquachiaEntity.Tenmay = Tenmay;
				
				_KetquachiaEntity.Tencongnhan = Tencongnhan;
				
				_KetquachiaEntity.Dauraghep = Dauraghep;
				
				_KetquachiaEntity.Sometvao = Sometvao;
				
				_KetquachiaEntity.Sokgvao = Sokgvao;
				
				_KetquachiaEntity.Thoigianbatdau = Thoigianbatdau;
				
				_KetquachiaEntity.Thoigianketthuc = Thoigianketthuc;
				
				_KetquachiaEntity.Thoigianlencuon = Thoigianlencuon;
				
				_KetquachiaEntity.Thoigianhacuon = Thoigianhacuon;
				
				_KetquachiaEntity.Solanhacuon = Solanhacuon;
				
				_KetquachiaEntity.Thoigiancatdau = Thoigiancatdau;
				
				_KetquachiaEntity.Thoigiandoilenh = Thoigiandoilenh;
				
				_KetquachiaEntity.Thoigiansuco = Thoigiansuco;
				
				_KetquachiaEntity.Phein = Phein;
				
				_KetquachiaEntity.Pheghep = Pheghep;
				
				_KetquachiaEntity.Phechia = Phechia;
				
				_KetquachiaEntity.PhethoiNcc = PhethoiNcc;
				
				_KetquachiaEntity.Phesx = Phesx;
				
				_KetquachiaEntity.Ngaytao = Ngaytao;
				
				_KetquachiaEntity.Nguoitao = Nguoitao;
				
				_KetquachiaEntity.Ngaysua = Ngaysua;
				
				_KetquachiaEntity.Nguoisua = Nguoisua;
				
				_KetquachiaEntity.Nangsuat = Nangsuat;
				
				_KetquachiaEntity.Tylesaihong = Tylesaihong;
				
				_KetquachiaEntity.Socuon = Socuon;
				
				_KetquachiaEntity.Matruongca = Matruongca;
				
				_KetquachiaEntity.Tentruongca = Tentruongca;
				
				_KetquachiaEntity.Tocdodinhmuc = Tocdodinhmuc;
				
				_KetquachiaEntity.Lydosuco = Lydosuco;
				
				_KetquachiaEntity.Sometra = Sometra;
				
				_KetquachiaEntity.Sokgra = Sokgra;
				
				_KetquachiaEntity.Solenhsx = Solenhsx;
					
					
				adapter.SaveEntity(_KetquachiaEntity, true);
			}
			return _KetquachiaEntity;
		}

		public KetquachiaEntity Insert(System.DateTime Ngay, System.Int32 Ca, System.String Mamay, System.String Masanpham, System.String Macongnhan, System.String Tensanpham, System.String Tenmay, System.String Tencongnhan, System.Decimal Dauraghep, System.Decimal Sometvao, System.Decimal Sokgvao, System.DateTime Thoigianbatdau, System.DateTime Thoigianketthuc, System.Decimal Thoigianlencuon, System.Decimal Thoigianhacuon, System.Int32 Solanhacuon, System.Decimal Thoigiancatdau, System.Decimal Thoigiandoilenh, System.Decimal Thoigiansuco, System.Decimal Phein, System.Decimal Pheghep, System.Decimal Phechia, System.Decimal PhethoiNcc, System.Decimal Phesx, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Nangsuat, System.Decimal Tylesaihong, System.Int32 Socuon, System.String Matruongca, System.String Tentruongca, System.Decimal Tocdodinhmuc, System.String Lydosuco, System.Decimal Sometra, System.Decimal Sokgra, System.String Solenhsx)//ko co mahieu
		{
			KetquachiaEntity _KetquachiaEntity = new KetquachiaEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_KetquachiaEntity.Ngay = Ngay;
				
				_KetquachiaEntity.Ca = Ca;
				
				_KetquachiaEntity.Mamay = Mamay;
				
				_KetquachiaEntity.Masanpham = Masanpham;
				
				_KetquachiaEntity.Macongnhan = Macongnhan;
				
				_KetquachiaEntity.Tensanpham = Tensanpham;
				
				_KetquachiaEntity.Tenmay = Tenmay;
				
				_KetquachiaEntity.Tencongnhan = Tencongnhan;
				
				_KetquachiaEntity.Dauraghep = Dauraghep;
				
				_KetquachiaEntity.Sometvao = Sometvao;
				
				_KetquachiaEntity.Sokgvao = Sokgvao;
				
				_KetquachiaEntity.Thoigianbatdau = Thoigianbatdau;
				
				_KetquachiaEntity.Thoigianketthuc = Thoigianketthuc;
				
				_KetquachiaEntity.Thoigianlencuon = Thoigianlencuon;
				
				_KetquachiaEntity.Thoigianhacuon = Thoigianhacuon;
				
				_KetquachiaEntity.Solanhacuon = Solanhacuon;
				
				_KetquachiaEntity.Thoigiancatdau = Thoigiancatdau;
				
				_KetquachiaEntity.Thoigiandoilenh = Thoigiandoilenh;
				
				_KetquachiaEntity.Thoigiansuco = Thoigiansuco;
				
				_KetquachiaEntity.Phein = Phein;
				
				_KetquachiaEntity.Pheghep = Pheghep;
				
				_KetquachiaEntity.Phechia = Phechia;
				
				_KetquachiaEntity.PhethoiNcc = PhethoiNcc;
				
				_KetquachiaEntity.Phesx = Phesx;
				
				_KetquachiaEntity.Ngaytao = Ngaytao;
				
				_KetquachiaEntity.Nguoitao = Nguoitao;
				
				_KetquachiaEntity.Ngaysua = Ngaysua;
				
				_KetquachiaEntity.Nguoisua = Nguoisua;
				
				_KetquachiaEntity.Nangsuat = Nangsuat;
				
				_KetquachiaEntity.Tylesaihong = Tylesaihong;
				
				_KetquachiaEntity.Socuon = Socuon;
				
				_KetquachiaEntity.Matruongca = Matruongca;
				
				_KetquachiaEntity.Tentruongca = Tentruongca;
				
				_KetquachiaEntity.Tocdodinhmuc = Tocdodinhmuc;
				
				_KetquachiaEntity.Lydosuco = Lydosuco;
				
				_KetquachiaEntity.Sometra = Sometra;
				
				_KetquachiaEntity.Sokgra = Sokgra;
				
				_KetquachiaEntity.Solenhsx = Solenhsx;
					

				adapter.SaveEntity(_KetquachiaEntity, true);
			}
			return _KetquachiaEntity;
		}

		public bool Update(KetquachiaEntity _KetquachiaEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(KetquachiaFields.Id == _KetquachiaEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_KetquachiaEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(KetquachiaEntity _KetquachiaEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_KetquachiaEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngay, System.Int32 Ca, System.String Mamay, System.String Masanpham, System.String Macongnhan, System.String Tensanpham, System.String Tenmay, System.String Tencongnhan, System.Decimal Dauraghep, System.Decimal Sometvao, System.Decimal Sokgvao, System.DateTime Thoigianbatdau, System.DateTime Thoigianketthuc, System.Decimal Thoigianlencuon, System.Decimal Thoigianhacuon, System.Int32 Solanhacuon, System.Decimal Thoigiancatdau, System.Decimal Thoigiandoilenh, System.Decimal Thoigiansuco, System.Decimal Phein, System.Decimal Pheghep, System.Decimal Phechia, System.Decimal PhethoiNcc, System.Decimal Phesx, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Nangsuat, System.Decimal Tylesaihong, System.Int32 Socuon, System.String Matruongca, System.String Tentruongca, System.Decimal Tocdodinhmuc, System.String Lydosuco, System.Decimal Sometra, System.Decimal Sokgra, System.String Solenhsx)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquachiaEntity _KetquachiaEntity = new KetquachiaEntity(Id);
				if (adapter.FetchEntity(_KetquachiaEntity))
				{
				
					
					
					_KetquachiaEntity.Ngay = Ngay;
					
					_KetquachiaEntity.Ca = Ca;
					
					_KetquachiaEntity.Mamay = Mamay;
					
					_KetquachiaEntity.Masanpham = Masanpham;
					
					_KetquachiaEntity.Macongnhan = Macongnhan;
					
					_KetquachiaEntity.Tensanpham = Tensanpham;
					
					_KetquachiaEntity.Tenmay = Tenmay;
					
					_KetquachiaEntity.Tencongnhan = Tencongnhan;
					
					_KetquachiaEntity.Dauraghep = Dauraghep;
					
					_KetquachiaEntity.Sometvao = Sometvao;
					
					_KetquachiaEntity.Sokgvao = Sokgvao;
					
					_KetquachiaEntity.Thoigianbatdau = Thoigianbatdau;
					
					_KetquachiaEntity.Thoigianketthuc = Thoigianketthuc;
					
					_KetquachiaEntity.Thoigianlencuon = Thoigianlencuon;
					
					_KetquachiaEntity.Thoigianhacuon = Thoigianhacuon;
					
					_KetquachiaEntity.Solanhacuon = Solanhacuon;
					
					_KetquachiaEntity.Thoigiancatdau = Thoigiancatdau;
					
					_KetquachiaEntity.Thoigiandoilenh = Thoigiandoilenh;
					
					_KetquachiaEntity.Thoigiansuco = Thoigiansuco;
					
					_KetquachiaEntity.Phein = Phein;
					
					_KetquachiaEntity.Pheghep = Pheghep;
					
					_KetquachiaEntity.Phechia = Phechia;
					
					_KetquachiaEntity.PhethoiNcc = PhethoiNcc;
					
					_KetquachiaEntity.Phesx = Phesx;
					
					_KetquachiaEntity.Ngaytao = Ngaytao;
					
					_KetquachiaEntity.Nguoitao = Nguoitao;
					
					_KetquachiaEntity.Ngaysua = Ngaysua;
					
					_KetquachiaEntity.Nguoisua = Nguoisua;
					
					_KetquachiaEntity.Nangsuat = Nangsuat;
					
					_KetquachiaEntity.Tylesaihong = Tylesaihong;
					
					_KetquachiaEntity.Socuon = Socuon;
					
					_KetquachiaEntity.Matruongca = Matruongca;
					
					_KetquachiaEntity.Tentruongca = Tentruongca;
					
					_KetquachiaEntity.Tocdodinhmuc = Tocdodinhmuc;
					
					_KetquachiaEntity.Lydosuco = Lydosuco;
					
					_KetquachiaEntity.Sometra = Sometra;
					
					_KetquachiaEntity.Sokgra = Sokgra;
					
					_KetquachiaEntity.Solenhsx = Solenhsx;
						

					adapter.SaveEntity(_KetquachiaEntity, true);
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
				KetquachiaEntity _KetquachiaEntity = new KetquachiaEntity(Id);
				if (adapter.FetchEntity(_KetquachiaEntity))
				{
					adapter.DeleteEntity(_KetquachiaEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("KetquachiaEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgay(System.DateTime Ngay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCa(System.Int32 Ca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamay(System.String Mamay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasanpham(System.String Masanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMacongnhan(System.String Macongnhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensanpham(System.String Tensanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmay(System.String Tenmay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTencongnhan(System.String Tencongnhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDauraghep(System.Decimal Dauraghep)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Dauraghep == Dauraghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySometvao(System.Decimal Sometvao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Sometvao == Sometvao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokgvao(System.Decimal Sokgvao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Sokgvao == Sokgvao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianbatdau(System.DateTime Thoigianbatdau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianketthuc(System.DateTime Thoigianketthuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianlencuon(System.Decimal Thoigianlencuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianlencuon == Thoigianlencuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianhacuon(System.Decimal Thoigianhacuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianhacuon == Thoigianhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySolanhacuon(System.Int32 Solanhacuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Solanhacuon == Solanhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigiancatdau(System.Decimal Thoigiancatdau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigiancatdau == Thoigiancatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigiandoilenh(System.Decimal Thoigiandoilenh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigiandoilenh == Thoigiandoilenh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigiansuco(System.Decimal Thoigiansuco)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhein(System.Decimal Phein)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Phein == Phein);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPheghep(System.Decimal Pheghep)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Pheghep == Pheghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhechia(System.Decimal Phechia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Phechia == Phechia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhethoiNcc(System.Decimal PhethoiNcc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.PhethoiNcc == PhethoiNcc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhesx(System.Decimal Phesx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Phesx == Phesx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNangsuat(System.Decimal Nangsuat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Nangsuat == Nangsuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTylesaihong(System.Decimal Tylesaihong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Tylesaihong == Tylesaihong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySocuon(System.Int32 Socuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Socuon == Socuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMatruongca(System.String Matruongca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Matruongca == Matruongca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTentruongca(System.String Tentruongca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Tentruongca == Tentruongca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTocdodinhmuc(System.Decimal Tocdodinhmuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Tocdodinhmuc == Tocdodinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLydosuco(System.String Lydosuco)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Lydosuco == Lydosuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySometra(System.Decimal Sometra)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Sometra == Sometra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokgra(System.Decimal Sokgra)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Sokgra == Sokgra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySolenhsx(System.String Solenhsx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
			
		
		public KetquachiaEntity SelectOne(System.Int64 Id)
		{
			KetquachiaEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquachiaEntity _KetquachiaEntity = new KetquachiaEntity(Id);
				if (adapter.FetchEntity(_KetquachiaEntity))
				{
					toReturn = _KetquachiaEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _KetquachiaCollection = new EntityCollection( new KetquachiaEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, null, 0, null);
			}
			return _KetquachiaCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgay(System.DateTime Ngay)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayRDT(System.DateTime Ngay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCa(System.Int32 Ca)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByCaRDT(System.Int32 Ca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamay(System.String Mamay)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByMamayRDT(System.String Mamay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasanpham(System.String Masanpham)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByMasanphamRDT(System.String Masanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMacongnhan(System.String Macongnhan)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByMacongnhanRDT(System.String Macongnhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensanpham(System.String Tensanpham)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByTensanphamRDT(System.String Tensanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmay(System.String Tenmay)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmayRDT(System.String Tenmay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTencongnhan(System.String Tencongnhan)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByTencongnhanRDT(System.String Tencongnhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDauraghep(System.Decimal Dauraghep)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Dauraghep == Dauraghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByDauraghepRDT(System.Decimal Dauraghep)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Dauraghep == Dauraghep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySometvao(System.Decimal Sometvao)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Sometvao == Sometvao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectBySometvaoRDT(System.Decimal Sometvao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Sometvao == Sometvao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokgvao(System.Decimal Sokgvao)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Sokgvao == Sokgvao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgvaoRDT(System.Decimal Sokgvao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Sokgvao == Sokgvao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianbatdau(System.DateTime Thoigianbatdau)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianbatdauRDT(System.DateTime Thoigianbatdau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianketthuc(System.DateTime Thoigianketthuc)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianketthucRDT(System.DateTime Thoigianketthuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianlencuon(System.Decimal Thoigianlencuon)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianlencuon == Thoigianlencuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianlencuonRDT(System.Decimal Thoigianlencuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianlencuon == Thoigianlencuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianhacuon(System.Decimal Thoigianhacuon)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianhacuon == Thoigianhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianhacuonRDT(System.Decimal Thoigianhacuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianhacuon == Thoigianhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySolanhacuon(System.Int32 Solanhacuon)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Solanhacuon == Solanhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectBySolanhacuonRDT(System.Int32 Solanhacuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Solanhacuon == Solanhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigiancatdau(System.Decimal Thoigiancatdau)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigiancatdau == Thoigiancatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigiancatdauRDT(System.Decimal Thoigiancatdau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigiancatdau == Thoigiancatdau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigiandoilenh(System.Decimal Thoigiandoilenh)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigiandoilenh == Thoigiandoilenh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigiandoilenhRDT(System.Decimal Thoigiandoilenh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigiandoilenh == Thoigiandoilenh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigiansuco(System.Decimal Thoigiansuco)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigiansucoRDT(System.Decimal Thoigiansuco)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhein(System.Decimal Phein)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Phein == Phein);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByPheinRDT(System.Decimal Phein)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Phein == Phein);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPheghep(System.Decimal Pheghep)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Pheghep == Pheghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByPheghepRDT(System.Decimal Pheghep)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Pheghep == Pheghep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhechia(System.Decimal Phechia)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Phechia == Phechia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByPhechiaRDT(System.Decimal Phechia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Phechia == Phechia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhethoiNcc(System.Decimal PhethoiNcc)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.PhethoiNcc == PhethoiNcc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByPhethoiNccRDT(System.Decimal PhethoiNcc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.PhethoiNcc == PhethoiNcc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhesx(System.Decimal Phesx)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Phesx == Phesx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByPhesxRDT(System.Decimal Phesx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Phesx == Phesx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNangsuat(System.Decimal Nangsuat)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Nangsuat == Nangsuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByNangsuatRDT(System.Decimal Nangsuat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Nangsuat == Nangsuat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTylesaihong(System.Decimal Tylesaihong)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Tylesaihong == Tylesaihong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByTylesaihongRDT(System.Decimal Tylesaihong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Tylesaihong == Tylesaihong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySocuon(System.Int32 Socuon)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Socuon == Socuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectBySocuonRDT(System.Int32 Socuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Socuon == Socuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMatruongca(System.String Matruongca)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Matruongca == Matruongca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByMatruongcaRDT(System.String Matruongca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Matruongca == Matruongca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTentruongca(System.String Tentruongca)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Tentruongca == Tentruongca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByTentruongcaRDT(System.String Tentruongca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Tentruongca == Tentruongca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTocdodinhmuc(System.Decimal Tocdodinhmuc)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Tocdodinhmuc == Tocdodinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByTocdodinhmucRDT(System.Decimal Tocdodinhmuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Tocdodinhmuc == Tocdodinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLydosuco(System.String Lydosuco)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Lydosuco == Lydosuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByLydosucoRDT(System.String Lydosuco)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Lydosuco == Lydosuco);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySometra(System.Decimal Sometra)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Sometra == Sometra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectBySometraRDT(System.Decimal Sometra)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Sometra == Sometra);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokgra(System.Decimal Sokgra)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Sokgra == Sokgra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgraRDT(System.Decimal Sokgra)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Sokgra == Sokgra);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySolenhsx(System.String Solenhsx)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectBySolenhsxRDT(System.String Solenhsx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(KetquachiaFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
