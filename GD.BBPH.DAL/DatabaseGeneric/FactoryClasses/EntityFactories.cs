///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Wednesday, October 5, 2022 2:27:30 PM
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using GD.BBPH.DAL.EntityClasses;
using GD.BBPH.DAL.HelperClasses;
using GD.BBPH.DAL.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.BBPH.DAL.FactoryClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase2 : EntityFactoryCore2
	{
		private string _entityName;
		private GD.BBPH.DAL.EntityType _typeOfEntity;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		public EntityFactoryBase2(string entityName, GD.BBPH.DAL.EntityType typeOfEntity)
		{
			_entityName = entityName;
			_typeOfEntity = typeOfEntity;
		}
		
		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields2 object for the entity to create.</summary>
		/// <returns>Empty IEntityFields2 object.</returns>
		public override IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(_typeOfEntity);
		}
		
		/// <summary>Creates a new entity instance using the GeneralEntityFactory in the generated code, using the passed in entitytype value</summary>
		/// <param name="entityTypeValue">The entity type value of the entity to create an instance for.</param>
		/// <returns>new IEntity instance</returns>
		public override IEntity2 CreateEntityFromEntityTypeValue(int entityTypeValue)
		{
			return GeneralEntityFactory.Create((GD.BBPH.DAL.EntityType)entityTypeValue);
		}

		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <param name="objectAlias">The object alias to use for the elements in the relations.</param>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetHierarchyRelations(_entityName, objectAlias);
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public override IEntityFactory2 GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity) 
		{
			IEntityFactory2 toReturn = (IEntityFactory2)InheritanceInfoProviderSingleton.GetInstance().GetEntityFactory(_entityName, fieldValues, entityFieldStartIndexesPerEntity);
			if(toReturn == null)
			{
				toReturn = this;
			}
			return toReturn;
		}
		
		/// <summary>Gets a predicateexpression which filters on the entity with type belonging to this factory.</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <param name="objectAlias">The object alias to use for the predicate(s).</param>
		/// <returns>ready to use predicateexpression, or an empty predicate expression if the belonging entity isn't a hierarchical type.</returns>
		public override IPredicateExpression GetEntityTypeFilter(bool negate, string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter(this.ForEntityName, objectAlias, negate);
		}
				
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public override string ForEntityName 
		{ 
			get { return _entityName; }
		}
	}
	
	/// <summary>Factory to create new, empty CongsuatmayEntity objects.</summary>
	[Serializable]
	public partial class CongsuatmayEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public CongsuatmayEntityFactory() : base("CongsuatmayEntity", GD.BBPH.DAL.EntityType.CongsuatmayEntity) { }

		/// <summary>Creates a new, empty CongsuatmayEntity object.</summary>
		/// <returns>A new, empty CongsuatmayEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new CongsuatmayEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCongsuatmay
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new CongsuatmayEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CongsuatmayEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCongsuatmayUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<CongsuatmayEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty CtptmangDEntity objects.</summary>
	[Serializable]
	public partial class CtptmangDEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public CtptmangDEntityFactory() : base("CtptmangDEntity", GD.BBPH.DAL.EntityType.CtptmangDEntity) { }

		/// <summary>Creates a new, empty CtptmangDEntity object.</summary>
		/// <returns>A new, empty CtptmangDEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new CtptmangDEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCtptmangD
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new CtptmangDEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CtptmangDEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCtptmangDUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<CtptmangDEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty CtptmangHEntity objects.</summary>
	[Serializable]
	public partial class CtptmangHEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public CtptmangHEntityFactory() : base("CtptmangHEntity", GD.BBPH.DAL.EntityType.CtptmangHEntity) { }

		/// <summary>Creates a new, empty CtptmangHEntity object.</summary>
		/// <returns>A new, empty CtptmangHEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new CtptmangHEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCtptmangH
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new CtptmangHEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CtptmangHEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCtptmangHUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<CtptmangHEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DinhmucthoigianEntity objects.</summary>
	[Serializable]
	public partial class DinhmucthoigianEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DinhmucthoigianEntityFactory() : base("DinhmucthoigianEntity", GD.BBPH.DAL.EntityType.DinhmucthoigianEntity) { }

		/// <summary>Creates a new, empty DinhmucthoigianEntity object.</summary>
		/// <returns>A new, empty DinhmucthoigianEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DinhmucthoigianEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDinhmucthoigian
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DinhmucthoigianEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DinhmucthoigianEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDinhmucthoigianUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DinhmucthoigianEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DmbophanEntity objects.</summary>
	[Serializable]
	public partial class DmbophanEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DmbophanEntityFactory() : base("DmbophanEntity", GD.BBPH.DAL.EntityType.DmbophanEntity) { }

		/// <summary>Creates a new, empty DmbophanEntity object.</summary>
		/// <returns>A new, empty DmbophanEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DmbophanEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmbophan
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DmbophanEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DmbophanEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmbophanUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DmbophanEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DmcapmaEntity objects.</summary>
	[Serializable]
	public partial class DmcapmaEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DmcapmaEntityFactory() : base("DmcapmaEntity", GD.BBPH.DAL.EntityType.DmcapmaEntity) { }

		/// <summary>Creates a new, empty DmcapmaEntity object.</summary>
		/// <returns>A new, empty DmcapmaEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DmcapmaEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmcapma
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DmcapmaEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DmcapmaEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmcapmaUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DmcapmaEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DmchucvuEntity objects.</summary>
	[Serializable]
	public partial class DmchucvuEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DmchucvuEntityFactory() : base("DmchucvuEntity", GD.BBPH.DAL.EntityType.DmchucvuEntity) { }

		/// <summary>Creates a new, empty DmchucvuEntity object.</summary>
		/// <returns>A new, empty DmchucvuEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DmchucvuEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmchucvu
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DmchucvuEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DmchucvuEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmchucvuUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DmchucvuEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DmcongdoanEntity objects.</summary>
	[Serializable]
	public partial class DmcongdoanEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DmcongdoanEntityFactory() : base("DmcongdoanEntity", GD.BBPH.DAL.EntityType.DmcongdoanEntity) { }

		/// <summary>Creates a new, empty DmcongdoanEntity object.</summary>
		/// <returns>A new, empty DmcongdoanEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DmcongdoanEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmcongdoan
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DmcongdoanEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DmcongdoanEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmcongdoanUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DmcongdoanEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DmcongnhanEntity objects.</summary>
	[Serializable]
	public partial class DmcongnhanEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DmcongnhanEntityFactory() : base("DmcongnhanEntity", GD.BBPH.DAL.EntityType.DmcongnhanEntity) { }

		/// <summary>Creates a new, empty DmcongnhanEntity object.</summary>
		/// <returns>A new, empty DmcongnhanEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DmcongnhanEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmcongnhan
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DmcongnhanEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DmcongnhanEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmcongnhanUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DmcongnhanEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DmdongmayEntity objects.</summary>
	[Serializable]
	public partial class DmdongmayEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DmdongmayEntityFactory() : base("DmdongmayEntity", GD.BBPH.DAL.EntityType.DmdongmayEntity) { }

		/// <summary>Creates a new, empty DmdongmayEntity object.</summary>
		/// <returns>A new, empty DmdongmayEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DmdongmayEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmdongmay
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DmdongmayEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DmdongmayEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmdongmayUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DmdongmayEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DmhangEntity objects.</summary>
	[Serializable]
	public partial class DmhangEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DmhangEntityFactory() : base("DmhangEntity", GD.BBPH.DAL.EntityType.DmhangEntity) { }

		/// <summary>Creates a new, empty DmhangEntity object.</summary>
		/// <returns>A new, empty DmhangEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DmhangEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmhang
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DmhangEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DmhangEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmhangUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DmhangEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DmkhachEntity objects.</summary>
	[Serializable]
	public partial class DmkhachEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DmkhachEntityFactory() : base("DmkhachEntity", GD.BBPH.DAL.EntityType.DmkhachEntity) { }

		/// <summary>Creates a new, empty DmkhachEntity object.</summary>
		/// <returns>A new, empty DmkhachEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DmkhachEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmkhach
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DmkhachEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DmkhachEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmkhachUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DmkhachEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DmkhoEntity objects.</summary>
	[Serializable]
	public partial class DmkhoEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DmkhoEntityFactory() : base("DmkhoEntity", GD.BBPH.DAL.EntityType.DmkhoEntity) { }

		/// <summary>Creates a new, empty DmkhoEntity object.</summary>
		/// <returns>A new, empty DmkhoEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DmkhoEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmkho
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DmkhoEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DmkhoEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmkhoUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DmkhoEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DmlydonhapxuatEntity objects.</summary>
	[Serializable]
	public partial class DmlydonhapxuatEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DmlydonhapxuatEntityFactory() : base("DmlydonhapxuatEntity", GD.BBPH.DAL.EntityType.DmlydonhapxuatEntity) { }

		/// <summary>Creates a new, empty DmlydonhapxuatEntity object.</summary>
		/// <returns>A new, empty DmlydonhapxuatEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DmlydonhapxuatEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmlydonhapxuat
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DmlydonhapxuatEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DmlydonhapxuatEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmlydonhapxuatUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DmlydonhapxuatEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DmmangEntity objects.</summary>
	[Serializable]
	public partial class DmmangEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DmmangEntityFactory() : base("DmmangEntity", GD.BBPH.DAL.EntityType.DmmangEntity) { }

		/// <summary>Creates a new, empty DmmangEntity object.</summary>
		/// <returns>A new, empty DmmangEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DmmangEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmmang
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DmmangEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DmmangEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmmangUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DmmangEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DmmauEntity objects.</summary>
	[Serializable]
	public partial class DmmauEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DmmauEntityFactory() : base("DmmauEntity", GD.BBPH.DAL.EntityType.DmmauEntity) { }

		/// <summary>Creates a new, empty DmmauEntity object.</summary>
		/// <returns>A new, empty DmmauEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DmmauEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmmau
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DmmauEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DmmauEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmmauUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DmmauEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DmmayEntity objects.</summary>
	[Serializable]
	public partial class DmmayEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DmmayEntityFactory() : base("DmmayEntity", GD.BBPH.DAL.EntityType.DmmayEntity) { }

		/// <summary>Creates a new, empty DmmayEntity object.</summary>
		/// <returns>A new, empty DmmayEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DmmayEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmmay
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DmmayEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DmmayEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmmayUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DmmayEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DmnguyenlieuEntity objects.</summary>
	[Serializable]
	public partial class DmnguyenlieuEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DmnguyenlieuEntityFactory() : base("DmnguyenlieuEntity", GD.BBPH.DAL.EntityType.DmnguyenlieuEntity) { }

		/// <summary>Creates a new, empty DmnguyenlieuEntity object.</summary>
		/// <returns>A new, empty DmnguyenlieuEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DmnguyenlieuEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmnguyenlieu
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DmnguyenlieuEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DmnguyenlieuEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmnguyenlieuUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DmnguyenlieuEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DmnhomnguyenlieuEntity objects.</summary>
	[Serializable]
	public partial class DmnhomnguyenlieuEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DmnhomnguyenlieuEntityFactory() : base("DmnhomnguyenlieuEntity", GD.BBPH.DAL.EntityType.DmnhomnguyenlieuEntity) { }

		/// <summary>Creates a new, empty DmnhomnguyenlieuEntity object.</summary>
		/// <returns>A new, empty DmnhomnguyenlieuEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DmnhomnguyenlieuEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmnhomnguyenlieu
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DmnhomnguyenlieuEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DmnhomnguyenlieuEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmnhomnguyenlieuUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DmnhomnguyenlieuEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DmquycachEntity objects.</summary>
	[Serializable]
	public partial class DmquycachEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DmquycachEntityFactory() : base("DmquycachEntity", GD.BBPH.DAL.EntityType.DmquycachEntity) { }

		/// <summary>Creates a new, empty DmquycachEntity object.</summary>
		/// <returns>A new, empty DmquycachEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DmquycachEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmquycach
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DmquycachEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DmquycachEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmquycachUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DmquycachEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DmtaikhoanEntity objects.</summary>
	[Serializable]
	public partial class DmtaikhoanEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DmtaikhoanEntityFactory() : base("DmtaikhoanEntity", GD.BBPH.DAL.EntityType.DmtaikhoanEntity) { }

		/// <summary>Creates a new, empty DmtaikhoanEntity object.</summary>
		/// <returns>A new, empty DmtaikhoanEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DmtaikhoanEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmtaikhoan
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DmtaikhoanEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DmtaikhoanEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmtaikhoanUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DmtaikhoanEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty LogbackupEntity objects.</summary>
	[Serializable]
	public partial class LogbackupEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public LogbackupEntityFactory() : base("LogbackupEntity", GD.BBPH.DAL.EntityType.LogbackupEntity) { }

		/// <summary>Creates a new, empty LogbackupEntity object.</summary>
		/// <returns>A new, empty LogbackupEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new LogbackupEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLogbackup
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new LogbackupEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new LogbackupEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLogbackupUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<LogbackupEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty MenuEntity objects.</summary>
	[Serializable]
	public partial class MenuEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public MenuEntityFactory() : base("MenuEntity", GD.BBPH.DAL.EntityType.MenuEntity) { }

		/// <summary>Creates a new, empty MenuEntity object.</summary>
		/// <returns>A new, empty MenuEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new MenuEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMenu
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MenuEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new MenuEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMenuUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MenuEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty MenuroleEntity objects.</summary>
	[Serializable]
	public partial class MenuroleEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public MenuroleEntityFactory() : base("MenuroleEntity", GD.BBPH.DAL.EntityType.MenuroleEntity) { }

		/// <summary>Creates a new, empty MenuroleEntity object.</summary>
		/// <returns>A new, empty MenuroleEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new MenuroleEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMenurole
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MenuroleEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new MenuroleEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMenuroleUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MenuroleEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty RolesEntity objects.</summary>
	[Serializable]
	public partial class RolesEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public RolesEntityFactory() : base("RolesEntity", GD.BBPH.DAL.EntityType.RolesEntity) { }

		/// <summary>Creates a new, empty RolesEntity object.</summary>
		/// <returns>A new, empty RolesEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new RolesEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRoles
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new RolesEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new RolesEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRolesUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<RolesEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty ThamsoEntity objects.</summary>
	[Serializable]
	public partial class ThamsoEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public ThamsoEntityFactory() : base("ThamsoEntity", GD.BBPH.DAL.EntityType.ThamsoEntity) { }

		/// <summary>Creates a new, empty ThamsoEntity object.</summary>
		/// <returns>A new, empty ThamsoEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new ThamsoEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewThamso
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new ThamsoEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ThamsoEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewThamsoUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<ThamsoEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty UsersEntity objects.</summary>
	[Serializable]
	public partial class UsersEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public UsersEntityFactory() : base("UsersEntity", GD.BBPH.DAL.EntityType.UsersEntity) { }

		/// <summary>Creates a new, empty UsersEntity object.</summary>
		/// <returns>A new, empty UsersEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new UsersEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUsers
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new UsersEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new UsersEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUsersUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<UsersEntity>(this);
		}
		

		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses  entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity2 Create(GD.BBPH.DAL.EntityType entityTypeToCreate)
		{
			IEntityFactory2 factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case GD.BBPH.DAL.EntityType.CongsuatmayEntity:
					factoryToUse = new CongsuatmayEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.CtptmangDEntity:
					factoryToUse = new CtptmangDEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.CtptmangHEntity:
					factoryToUse = new CtptmangHEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.DinhmucthoigianEntity:
					factoryToUse = new DinhmucthoigianEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.DmbophanEntity:
					factoryToUse = new DmbophanEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.DmcapmaEntity:
					factoryToUse = new DmcapmaEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.DmchucvuEntity:
					factoryToUse = new DmchucvuEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.DmcongdoanEntity:
					factoryToUse = new DmcongdoanEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.DmcongnhanEntity:
					factoryToUse = new DmcongnhanEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.DmdongmayEntity:
					factoryToUse = new DmdongmayEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.DmhangEntity:
					factoryToUse = new DmhangEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.DmkhachEntity:
					factoryToUse = new DmkhachEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.DmkhoEntity:
					factoryToUse = new DmkhoEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.DmlydonhapxuatEntity:
					factoryToUse = new DmlydonhapxuatEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.DmmangEntity:
					factoryToUse = new DmmangEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.DmmauEntity:
					factoryToUse = new DmmauEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.DmmayEntity:
					factoryToUse = new DmmayEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.DmnguyenlieuEntity:
					factoryToUse = new DmnguyenlieuEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.DmnhomnguyenlieuEntity:
					factoryToUse = new DmnhomnguyenlieuEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.DmquycachEntity:
					factoryToUse = new DmquycachEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.DmtaikhoanEntity:
					factoryToUse = new DmtaikhoanEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.LogbackupEntity:
					factoryToUse = new LogbackupEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.MenuEntity:
					factoryToUse = new MenuEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.MenuroleEntity:
					factoryToUse = new MenuroleEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.RolesEntity:
					factoryToUse = new RolesEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.ThamsoEntity:
					factoryToUse = new ThamsoEntityFactory();
					break;
				case GD.BBPH.DAL.EntityType.UsersEntity:
					factoryToUse = new UsersEntityFactory();
					break;
			}
			IEntity2 toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}		
	}
		
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class EntityFactoryFactory
	{
#if CF
		/// <summary>Gets the factory of the entity with the GD.BBPH.DAL.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(GD.BBPH.DAL.EntityType typeOfEntity)
		{
			return GeneralEntityFactory.Create(typeOfEntity).GetEntityFactory();
		}
#else
		private static Dictionary<Type, IEntityFactory2> _factoryPerType = new Dictionary<Type, IEntityFactory2>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			Array entityTypeValues = Enum.GetValues(typeof(GD.BBPH.DAL.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity2 dummy = GeneralEntityFactory.Create((GD.BBPH.DAL.EntityType)entityTypeValue);
				_factoryPerType.Add(dummy.GetType(), dummy.GetEntityFactory());
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(Type typeOfEntity)
		{
			IEntityFactory2 toReturn = null;
			_factoryPerType.TryGetValue(typeOfEntity, out toReturn);
			return toReturn;
		}

		/// <summary>Gets the factory of the entity with the GD.BBPH.DAL.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(GD.BBPH.DAL.EntityType typeOfEntity)
		{
			return GetFactory(GeneralEntityFactory.Create(typeOfEntity).GetType());
		}
#endif		
	}
		
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator2
	{
		/// <summary>Gets the factory of the Entity type with the GD.BBPH.DAL.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(int entityTypeValue)
		{
			return (IEntityFactory2)this.GetFactoryImpl(entityTypeValue);
		}
		
		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(Type typeOfEntity)
		{
			return (IEntityFactory2)this.GetFactoryImpl(typeOfEntity);
		}

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields2 CreateResultsetFields(int numberOfFields)
		{
			return new ResultsetFields(numberOfFields);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand)
		{
			return new DynamicRelation(leftOperand);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (GD.BBPH.DAL.EntityType)Enum.Parse(typeof(GD.BBPH.DAL.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperandEntityName">Name of the entity which is used as the left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((GD.BBPH.DAL.EntityType)Enum.Parse(typeof(GD.BBPH.DAL.EntityType), leftOperandEntityName, false), joinType, (GD.BBPH.DAL.EntityType)Enum.Parse(typeof(GD.BBPH.DAL.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Obtains the inheritance info provider instance from the singleton </summary>
		/// <returns>The singleton instance of the inheritance info provider</returns>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the GD.BBPH.DAL.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return EntityFactoryFactory.GetFactory((GD.BBPH.DAL.EntityType)entityTypeValue);
		}
#if !CF		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity);
		}
#endif
	}
}
