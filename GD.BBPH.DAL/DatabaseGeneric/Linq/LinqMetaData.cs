///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Friday, September 30, 2022 9:36:17 AM
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
				case GD.BBPH.DAL.EntityType.DmmayEntity:
					toReturn = this.Dmmay;
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
				case GD.BBPH.DAL.EntityType.RolesEntity:
					toReturn = this.Roles;
					break;
				case GD.BBPH.DAL.EntityType.ThamsoEntity:
					toReturn = this.Thamso;
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
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmmayEntity instances in the database.</summary>
		public DataSource2<DmmayEntity> Dmmay
		{
			get { return new DataSource2<DmmayEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
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