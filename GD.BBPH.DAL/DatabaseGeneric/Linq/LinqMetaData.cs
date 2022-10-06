///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Thursday, October 6, 2022 9:04:15 AM
// Code is generated using templates: SD.TemplateBindings.Linq
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using GD.BBPH.DAL;
using GD.BBPH.DAL.EntityClasses;
using GD.BBPH.DAL.FactoryClasses;
using GD.BBPH.DAL.HelperClasses;
using GD.BBPH.DAL.RelationClasses;

namespace GD.BBPH.DAL.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public class LinqMetaData: ILinqMetaData
	{
		#region Class Member Declarations
		private IDataAccessAdapter _adapterToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the IDataAccessAdapter object to use empty. To be able to execute the query, an IDataAccessAdapter instance
		/// is required, and has to be set on the LLBLGenProProvider2 object in the query to execute. </summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse) : this (adapterToUse, null)
		{
		}

		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse, FunctionMappingStore customFunctionMappings)
		{
			_adapterToUse = adapterToUse;
			_customFunctionMappings = customFunctionMappings;
		}
	
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			IDataSource toReturn = null;
			switch((GD.BBPH.DAL.EntityType)typeOfEntity)
			{
				case GD.BBPH.DAL.EntityType.BaogiaDEntity:
					toReturn = this.BaogiaD;
					break;
				case GD.BBPH.DAL.EntityType.BaogiaHEntity:
					toReturn = this.BaogiaH;
					break;
				case GD.BBPH.DAL.EntityType.CongsuatmayEntity:
					toReturn = this.Congsuatmay;
					break;
				case GD.BBPH.DAL.EntityType.CtptmangDEntity:
					toReturn = this.CtptmangD;
					break;
				case GD.BBPH.DAL.EntityType.CtptmangHEntity:
					toReturn = this.CtptmangH;
					break;
				case GD.BBPH.DAL.EntityType.DinhmucthoigianEntity:
					toReturn = this.Dinhmucthoigian;
					break;
				case GD.BBPH.DAL.EntityType.DmbophanEntity:
					toReturn = this.Dmbophan;
					break;
				case GD.BBPH.DAL.EntityType.DmcapmaEntity:
					toReturn = this.Dmcapma;
					break;
				case GD.BBPH.DAL.EntityType.DmchucvuEntity:
					toReturn = this.Dmchucvu;
					break;
				case GD.BBPH.DAL.EntityType.DmcongdoanEntity:
					toReturn = this.Dmcongdoan;
					break;
				case GD.BBPH.DAL.EntityType.DmcongnhanEntity:
					toReturn = this.Dmcongnhan;
					break;
				case GD.BBPH.DAL.EntityType.DmdongmayEntity:
					toReturn = this.Dmdongmay;
					break;
				case GD.BBPH.DAL.EntityType.DmhangEntity:
					toReturn = this.Dmhang;
					break;
				case GD.BBPH.DAL.EntityType.DmkhachEntity:
					toReturn = this.Dmkhach;
					break;
				case GD.BBPH.DAL.EntityType.DmkhoEntity:
					toReturn = this.Dmkho;
					break;
				case GD.BBPH.DAL.EntityType.DmlydonhapxuatEntity:
					toReturn = this.Dmlydonhapxuat;
					break;
				case GD.BBPH.DAL.EntityType.DmmangEntity:
					toReturn = this.Dmmang;
					break;
				case GD.BBPH.DAL.EntityType.DmmauEntity:
					toReturn = this.Dmmau;
					break;
				case GD.BBPH.DAL.EntityType.DmmayEntity:
					toReturn = this.Dmmay;
					break;
				case GD.BBPH.DAL.EntityType.DmnguyenlieuEntity:
					toReturn = this.Dmnguyenlieu;
					break;
				case GD.BBPH.DAL.EntityType.DmnhomnguyenlieuEntity:
					toReturn = this.Dmnhomnguyenlieu;
					break;
				case GD.BBPH.DAL.EntityType.DmquycachEntity:
					toReturn = this.Dmquycach;
					break;
				case GD.BBPH.DAL.EntityType.DmtaikhoanEntity:
					toReturn = this.Dmtaikhoan;
					break;
				case GD.BBPH.DAL.EntityType.DonhangDEntity:
					toReturn = this.DonhangD;
					break;
				case GD.BBPH.DAL.EntityType.DonhangHEntity:
					toReturn = this.DonhangH;
					break;
				case GD.BBPH.DAL.EntityType.HangtralaiEntity:
					toReturn = this.Hangtralai;
					break;
				case GD.BBPH.DAL.EntityType.LogbackupEntity:
					toReturn = this.Logbackup;
					break;
				case GD.BBPH.DAL.EntityType.MenuEntity:
					toReturn = this.Menu;
					break;
				case GD.BBPH.DAL.EntityType.MenuroleEntity:
					toReturn = this.Menurole;
					break;
				case GD.BBPH.DAL.EntityType.PhieugiaohangDEntity:
					toReturn = this.PhieugiaohangD;
					break;
				case GD.BBPH.DAL.EntityType.PhieugiaohangHEntity:
					toReturn = this.PhieugiaohangH;
					break;
				case GD.BBPH.DAL.EntityType.RolesEntity:
					toReturn = this.Roles;
					break;
				case GD.BBPH.DAL.EntityType.ThamsoEntity:
					toReturn = this.Thamso;
					break;
				case GD.BBPH.DAL.EntityType.ThanhphanmauEntity:
					toReturn = this.Thanhphanmau;
					break;
				case GD.BBPH.DAL.EntityType.UsersEntity:
					toReturn = this.Users;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
		}

		/// <summary>returns the datasource to use in a Linq query when targeting BaogiaDEntity instances in the database.</summary>
		public DataSource2<BaogiaDEntity> BaogiaD
		{
			get { return new DataSource2<BaogiaDEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting BaogiaHEntity instances in the database.</summary>
		public DataSource2<BaogiaHEntity> BaogiaH
		{
			get { return new DataSource2<BaogiaHEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CongsuatmayEntity instances in the database.</summary>
		public DataSource2<CongsuatmayEntity> Congsuatmay
		{
			get { return new DataSource2<CongsuatmayEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CtptmangDEntity instances in the database.</summary>
		public DataSource2<CtptmangDEntity> CtptmangD
		{
			get { return new DataSource2<CtptmangDEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CtptmangHEntity instances in the database.</summary>
		public DataSource2<CtptmangHEntity> CtptmangH
		{
			get { return new DataSource2<CtptmangHEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DinhmucthoigianEntity instances in the database.</summary>
		public DataSource2<DinhmucthoigianEntity> Dinhmucthoigian
		{
			get { return new DataSource2<DinhmucthoigianEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmbophanEntity instances in the database.</summary>
		public DataSource2<DmbophanEntity> Dmbophan
		{
			get { return new DataSource2<DmbophanEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmcapmaEntity instances in the database.</summary>
		public DataSource2<DmcapmaEntity> Dmcapma
		{
			get { return new DataSource2<DmcapmaEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmchucvuEntity instances in the database.</summary>
		public DataSource2<DmchucvuEntity> Dmchucvu
		{
			get { return new DataSource2<DmchucvuEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmcongdoanEntity instances in the database.</summary>
		public DataSource2<DmcongdoanEntity> Dmcongdoan
		{
			get { return new DataSource2<DmcongdoanEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmcongnhanEntity instances in the database.</summary>
		public DataSource2<DmcongnhanEntity> Dmcongnhan
		{
			get { return new DataSource2<DmcongnhanEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmdongmayEntity instances in the database.</summary>
		public DataSource2<DmdongmayEntity> Dmdongmay
		{
			get { return new DataSource2<DmdongmayEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmhangEntity instances in the database.</summary>
		public DataSource2<DmhangEntity> Dmhang
		{
			get { return new DataSource2<DmhangEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmkhachEntity instances in the database.</summary>
		public DataSource2<DmkhachEntity> Dmkhach
		{
			get { return new DataSource2<DmkhachEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmkhoEntity instances in the database.</summary>
		public DataSource2<DmkhoEntity> Dmkho
		{
			get { return new DataSource2<DmkhoEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmlydonhapxuatEntity instances in the database.</summary>
		public DataSource2<DmlydonhapxuatEntity> Dmlydonhapxuat
		{
			get { return new DataSource2<DmlydonhapxuatEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmmangEntity instances in the database.</summary>
		public DataSource2<DmmangEntity> Dmmang
		{
			get { return new DataSource2<DmmangEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmmauEntity instances in the database.</summary>
		public DataSource2<DmmauEntity> Dmmau
		{
			get { return new DataSource2<DmmauEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmmayEntity instances in the database.</summary>
		public DataSource2<DmmayEntity> Dmmay
		{
			get { return new DataSource2<DmmayEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmnguyenlieuEntity instances in the database.</summary>
		public DataSource2<DmnguyenlieuEntity> Dmnguyenlieu
		{
			get { return new DataSource2<DmnguyenlieuEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmnhomnguyenlieuEntity instances in the database.</summary>
		public DataSource2<DmnhomnguyenlieuEntity> Dmnhomnguyenlieu
		{
			get { return new DataSource2<DmnhomnguyenlieuEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmquycachEntity instances in the database.</summary>
		public DataSource2<DmquycachEntity> Dmquycach
		{
			get { return new DataSource2<DmquycachEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmtaikhoanEntity instances in the database.</summary>
		public DataSource2<DmtaikhoanEntity> Dmtaikhoan
		{
			get { return new DataSource2<DmtaikhoanEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DonhangDEntity instances in the database.</summary>
		public DataSource2<DonhangDEntity> DonhangD
		{
			get { return new DataSource2<DonhangDEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DonhangHEntity instances in the database.</summary>
		public DataSource2<DonhangHEntity> DonhangH
		{
			get { return new DataSource2<DonhangHEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting HangtralaiEntity instances in the database.</summary>
		public DataSource2<HangtralaiEntity> Hangtralai
		{
			get { return new DataSource2<HangtralaiEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting LogbackupEntity instances in the database.</summary>
		public DataSource2<LogbackupEntity> Logbackup
		{
			get { return new DataSource2<LogbackupEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MenuEntity instances in the database.</summary>
		public DataSource2<MenuEntity> Menu
		{
			get { return new DataSource2<MenuEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MenuroleEntity instances in the database.</summary>
		public DataSource2<MenuroleEntity> Menurole
		{
			get { return new DataSource2<MenuroleEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PhieugiaohangDEntity instances in the database.</summary>
		public DataSource2<PhieugiaohangDEntity> PhieugiaohangD
		{
			get { return new DataSource2<PhieugiaohangDEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PhieugiaohangHEntity instances in the database.</summary>
		public DataSource2<PhieugiaohangHEntity> PhieugiaohangH
		{
			get { return new DataSource2<PhieugiaohangHEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting RolesEntity instances in the database.</summary>
		public DataSource2<RolesEntity> Roles
		{
			get { return new DataSource2<RolesEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ThamsoEntity instances in the database.</summary>
		public DataSource2<ThamsoEntity> Thamso
		{
			get { return new DataSource2<ThamsoEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ThanhphanmauEntity instances in the database.</summary>
		public DataSource2<ThanhphanmauEntity> Thanhphanmau
		{
			get { return new DataSource2<ThanhphanmauEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting UsersEntity instances in the database.</summary>
		public DataSource2<UsersEntity> Users
		{
			get { return new DataSource2<UsersEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		
		#region Class Property Declarations
		/// <summary> Gets / sets the IDataAccessAdapter to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public IDataAccessAdapter AdapterToUse
		{
			get { return _adapterToUse;}
			set { _adapterToUse = value;}
		}

		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings
		{
			get { return _customFunctionMappings; }
			set { _customFunctionMappings = value; }
		}
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse
		{
			get { return _contextToUse;}
			set { _contextToUse = value;}
		}
		#endregion
	}
}