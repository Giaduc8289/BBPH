﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Tuesday, October 11, 2022 3:09:08 PM
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using GD.BBPH.DAL;
using GD.BBPH.DAL.HelperClasses;
using GD.BBPH.DAL.FactoryClasses;
using GD.BBPH.DAL.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.BBPH.DAL.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>
	/// Entity class which represents the entity 'CtptmangD'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class CtptmangDEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations


		private CtptmangHEntity _ctptmangH;
		private DmnguyenlieuEntity _dmnguyenlieu;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name CtptmangH</summary>
			public static readonly string CtptmangH = "CtptmangH";
			/// <summary>Member name Dmnguyenlieu</summary>
			public static readonly string Dmnguyenlieu = "Dmnguyenlieu";



		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CtptmangDEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public CtptmangDEntity():base("CtptmangDEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public CtptmangDEntity(IEntityFields2 fields):base("CtptmangDEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this CtptmangDEntity</param>
		public CtptmangDEntity(IValidator validator):base("CtptmangDEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="id">PK value for CtptmangD which data should be fetched into this CtptmangD object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CtptmangDEntity(System.Int64 id):base("CtptmangDEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for CtptmangD which data should be fetched into this CtptmangD object</param>
		/// <param name="validator">The custom validator object for this CtptmangDEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CtptmangDEntity(System.Int64 id, IValidator validator):base("CtptmangDEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected CtptmangDEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{


				_ctptmangH = (CtptmangHEntity)info.GetValue("_ctptmangH", typeof(CtptmangHEntity));
				if(_ctptmangH!=null)
				{
					_ctptmangH.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_dmnguyenlieu = (DmnguyenlieuEntity)info.GetValue("_dmnguyenlieu", typeof(DmnguyenlieuEntity));
				if(_dmnguyenlieu!=null)
				{
					_dmnguyenlieu.AfterSave+=new EventHandler(OnEntityAfterSave);
				}

				base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((CtptmangDFieldIndex)fieldIndex)
			{
				case CtptmangDFieldIndex.IdH:
					DesetupSyncCtptmangH(true, false);
					break;
				case CtptmangDFieldIndex.Manl:
					DesetupSyncDmnguyenlieu(true, false);
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}
				
		/// <summary>Gets the inheritance info provider instance of the project this entity instance is located in. </summary>
		/// <returns>ready to use inheritance info provider instance.</returns>
		protected override IInheritanceInfoProvider GetInheritanceInfoProvider()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity2 entity)
		{
			switch(propertyName)
			{
				case "CtptmangH":
					this.CtptmangH = (CtptmangHEntity)entity;
					break;
				case "Dmnguyenlieu":
					this.Dmnguyenlieu = (DmnguyenlieuEntity)entity;
					break;



				default:
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return CtptmangDEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "CtptmangH":
					toReturn.Add(CtptmangDEntity.Relations.CtptmangHEntityUsingIdH);
					break;
				case "Dmnguyenlieu":
					toReturn.Add(CtptmangDEntity.Relations.DmnguyenlieuEntityUsingManl);
					break;



				default:

					break;				
			}
			return toReturn;
		}
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it
		/// will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override bool CheckOneWayRelations(string propertyName)
		{
			// use template trick to calculate the # of single-sided / oneway relations
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));



				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity2 relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "CtptmangH":
					SetupSyncCtptmangH(relatedEntity);
					break;
				case "Dmnguyenlieu":
					SetupSyncDmnguyenlieu(relatedEntity);
					break;


				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void UnsetRelatedEntity(IEntity2 relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "CtptmangH":
					DesetupSyncCtptmangH(false, true);
					break;
				case "Dmnguyenlieu":
					DesetupSyncDmnguyenlieu(false, true);
					break;


				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		public override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();

			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		public override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			if(_ctptmangH!=null)
			{
				toReturn.Add(_ctptmangH);
			}
			if(_dmnguyenlieu!=null)
			{
				toReturn.Add(_dmnguyenlieu);
			}

			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();


			return toReturn;
		}
		


		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{


				info.AddValue("_ctptmangH", (!this.MarkedForDeletion?_ctptmangH:null));
				info.AddValue("_dmnguyenlieu", (!this.MarkedForDeletion?_dmnguyenlieu:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(CtptmangDFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(CtptmangDFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new CtptmangDRelations().GetAllRelations();
		}
		



		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'CtptmangH' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCtptmangH()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CtptmangHFields.Id, null, ComparisonOperator.Equal, this.IdH));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Dmnguyenlieu' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDmnguyenlieu()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DmnguyenlieuFields.Manl, null, ComparisonOperator.Equal, this.Manl));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(GD.BBPH.DAL.EntityType.CtptmangDEntity);
		}

		/// <summary>
		/// Creates the ITypeDefaultValue instance used to provide default values for value types which aren't of type nullable(of T)
		/// </summary>
		/// <returns></returns>
		protected override ITypeDefaultValue CreateTypeDefaultValueProvider()
		{
			return new TypeDefaultValue();
		}

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(CtptmangDEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);


		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);


		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{


			return base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);


		}
#endif
		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("CtptmangH", _ctptmangH);
			toReturn.Add("Dmnguyenlieu", _dmnguyenlieu);



			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_ctptmangH!=null)
			{
				_ctptmangH.ActiveContext = base.ActiveContext;
			}
			if(_dmnguyenlieu!=null)
			{
				_dmnguyenlieu.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{



			_ctptmangH = null;
			_dmnguyenlieu = null;

			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();

			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IdH", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Mact", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenct", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Manl", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tennguyenlieu", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Trongluong", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tyle", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaytao", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nguoitao", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaysua", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nguoisua", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _ctptmangH</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCtptmangH(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _ctptmangH, new PropertyChangedEventHandler( OnCtptmangHPropertyChanged ), "CtptmangH", CtptmangDEntity.Relations.CtptmangHEntityUsingIdH, true, signalRelatedEntity, "CtptmangD", resetFKFields, new int[] { (int)CtptmangDFieldIndex.IdH } );		
			_ctptmangH = null;
		}

		/// <summary> setups the sync logic for member _ctptmangH</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCtptmangH(IEntity2 relatedEntity)
		{
			if(_ctptmangH!=relatedEntity)
			{
				DesetupSyncCtptmangH(true, true);
				_ctptmangH = (CtptmangHEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _ctptmangH, new PropertyChangedEventHandler( OnCtptmangHPropertyChanged ), "CtptmangH", CtptmangDEntity.Relations.CtptmangHEntityUsingIdH, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCtptmangHPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _dmnguyenlieu</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncDmnguyenlieu(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _dmnguyenlieu, new PropertyChangedEventHandler( OnDmnguyenlieuPropertyChanged ), "Dmnguyenlieu", CtptmangDEntity.Relations.DmnguyenlieuEntityUsingManl, true, signalRelatedEntity, "CtptmangD", resetFKFields, new int[] { (int)CtptmangDFieldIndex.Manl } );		
			_dmnguyenlieu = null;
		}

		/// <summary> setups the sync logic for member _dmnguyenlieu</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncDmnguyenlieu(IEntity2 relatedEntity)
		{
			if(_dmnguyenlieu!=relatedEntity)
			{
				DesetupSyncDmnguyenlieu(true, true);
				_dmnguyenlieu = (DmnguyenlieuEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _dmnguyenlieu, new PropertyChangedEventHandler( OnDmnguyenlieuPropertyChanged ), "Dmnguyenlieu", CtptmangDEntity.Relations.DmnguyenlieuEntityUsingManl, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnDmnguyenlieuPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this CtptmangDEntity</param>
		/// <param name="fields">Fields of this entity</param>
		protected virtual void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			base.Fields = fields;
			base.IsNew=true;
			base.Validator = validator;
			InitClassMembers();

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CtptmangDRelations Relations
		{
			get	{ return new CtptmangDRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}



		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CtptmangH' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCtptmangH
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CtptmangHEntityFactory))),
					(IEntityRelation)GetRelationsForField("CtptmangH")[0], (int)GD.BBPH.DAL.EntityType.CtptmangDEntity, (int)GD.BBPH.DAL.EntityType.CtptmangHEntity, 0, null, null, null, null, "CtptmangH", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Dmnguyenlieu' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDmnguyenlieu
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(DmnguyenlieuEntityFactory))),
					(IEntityRelation)GetRelationsForField("Dmnguyenlieu")[0], (int)GD.BBPH.DAL.EntityType.CtptmangDEntity, (int)GD.BBPH.DAL.EntityType.DmnguyenlieuEntity, 0, null, null, null, null, "Dmnguyenlieu", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CtptmangDEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value
		/// pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return CtptmangDEntity.FieldsCustomProperties;}
		}

		/// <summary> The Id property of the Entity CtptmangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ctptmang_d"."id"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 Id
		{
			get { return (System.Int64)GetValue((int)CtptmangDFieldIndex.Id, true); }
			set	{ SetValue((int)CtptmangDFieldIndex.Id, value); }
		}

		/// <summary> The IdH property of the Entity CtptmangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ctptmang_d"."id_h"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int64> IdH
		{
			get { return (Nullable<System.Int64>)GetValue((int)CtptmangDFieldIndex.IdH, false); }
			set	{ SetValue((int)CtptmangDFieldIndex.IdH, value); }
		}

		/// <summary> The Mact property of the Entity CtptmangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ctptmang_d"."Mact"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Mact
		{
			get { return (System.String)GetValue((int)CtptmangDFieldIndex.Mact, true); }
			set	{ SetValue((int)CtptmangDFieldIndex.Mact, value); }
		}

		/// <summary> The Tenct property of the Entity CtptmangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ctptmang_d"."Tenct"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Tenct
		{
			get { return (System.String)GetValue((int)CtptmangDFieldIndex.Tenct, true); }
			set	{ SetValue((int)CtptmangDFieldIndex.Tenct, value); }
		}

		/// <summary> The Manl property of the Entity CtptmangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ctptmang_d"."Manl"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Manl
		{
			get { return (System.String)GetValue((int)CtptmangDFieldIndex.Manl, true); }
			set	{ SetValue((int)CtptmangDFieldIndex.Manl, value); }
		}

		/// <summary> The Tennguyenlieu property of the Entity CtptmangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ctptmang_d"."Tennguyenlieu"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Tennguyenlieu
		{
			get { return (System.String)GetValue((int)CtptmangDFieldIndex.Tennguyenlieu, true); }
			set	{ SetValue((int)CtptmangDFieldIndex.Tennguyenlieu, value); }
		}

		/// <summary> The Trongluong property of the Entity CtptmangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ctptmang_d"."Trongluong"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Trongluong
		{
			get { return (Nullable<System.Decimal>)GetValue((int)CtptmangDFieldIndex.Trongluong, false); }
			set	{ SetValue((int)CtptmangDFieldIndex.Trongluong, value); }
		}

		/// <summary> The Tyle property of the Entity CtptmangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ctptmang_d"."Tyle"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Tyle
		{
			get { return (Nullable<System.Decimal>)GetValue((int)CtptmangDFieldIndex.Tyle, false); }
			set	{ SetValue((int)CtptmangDFieldIndex.Tyle, value); }
		}

		/// <summary> The Ngaytao property of the Entity CtptmangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ctptmang_d"."Ngaytao"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaytao
		{
			get { return (Nullable<System.DateTime>)GetValue((int)CtptmangDFieldIndex.Ngaytao, false); }
			set	{ SetValue((int)CtptmangDFieldIndex.Ngaytao, value); }
		}

		/// <summary> The Nguoitao property of the Entity CtptmangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ctptmang_d"."Nguoitao"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoitao
		{
			get { return (System.String)GetValue((int)CtptmangDFieldIndex.Nguoitao, true); }
			set	{ SetValue((int)CtptmangDFieldIndex.Nguoitao, value); }
		}

		/// <summary> The Ngaysua property of the Entity CtptmangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ctptmang_d"."Ngaysua"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaysua
		{
			get { return (Nullable<System.DateTime>)GetValue((int)CtptmangDFieldIndex.Ngaysua, false); }
			set	{ SetValue((int)CtptmangDFieldIndex.Ngaysua, value); }
		}

		/// <summary> The Nguoisua property of the Entity CtptmangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ctptmang_d"."Nguoisua"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoisua
		{
			get { return (System.String)GetValue((int)CtptmangDFieldIndex.Nguoisua, true); }
			set	{ SetValue((int)CtptmangDFieldIndex.Nguoisua, value); }
		}



		/// <summary> Gets / sets related entity of type 'CtptmangHEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual CtptmangHEntity CtptmangH
		{
			get
			{
				return _ctptmangH;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCtptmangH(value);
				}
				else
				{
					if(value==null)
					{
						if(_ctptmangH != null)
						{
							_ctptmangH.UnsetRelatedEntity(this, "CtptmangD");
						}
					}
					else
					{
						if(_ctptmangH!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "CtptmangD");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'DmnguyenlieuEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual DmnguyenlieuEntity Dmnguyenlieu
		{
			get
			{
				return _dmnguyenlieu;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncDmnguyenlieu(value);
				}
				else
				{
					if(value==null)
					{
						if(_dmnguyenlieu != null)
						{
							_dmnguyenlieu.UnsetRelatedEntity(this, "CtptmangD");
						}
					}
					else
					{
						if(_dmnguyenlieu!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "CtptmangD");
						}
					}
				}
			}
		}

	
		
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the GD.BBPH.DAL.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)GD.BBPH.DAL.EntityType.CtptmangDEntity; }
		}
		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
