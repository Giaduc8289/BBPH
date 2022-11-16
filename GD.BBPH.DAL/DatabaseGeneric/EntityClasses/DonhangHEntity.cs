﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Wednesday, November 16, 2022 10:18:25 AM
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
	/// Entity class which represents the entity 'DonhangH'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class DonhangHEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<DonhangDEntity> _donhangD;
		private EntityCollection<PhieugiaohangHEntity> _phieugiaohangH;

		private DmkhachEntity _dmkhach;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name Dmkhach</summary>
			public static readonly string Dmkhach = "Dmkhach";
			/// <summary>Member name DonhangD</summary>
			public static readonly string DonhangD = "DonhangD";
			/// <summary>Member name PhieugiaohangH</summary>
			public static readonly string PhieugiaohangH = "PhieugiaohangH";


		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static DonhangHEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public DonhangHEntity():base("DonhangHEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public DonhangHEntity(IEntityFields2 fields):base("DonhangHEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this DonhangHEntity</param>
		public DonhangHEntity(IValidator validator):base("DonhangHEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="madon">PK value for DonhangH which data should be fetched into this DonhangH object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DonhangHEntity(System.String madon):base("DonhangHEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.Madon = madon;
		}

		/// <summary> CTor</summary>
		/// <param name="madon">PK value for DonhangH which data should be fetched into this DonhangH object</param>
		/// <param name="validator">The custom validator object for this DonhangHEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DonhangHEntity(System.String madon, IValidator validator):base("DonhangHEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.Madon = madon;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected DonhangHEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_donhangD = (EntityCollection<DonhangDEntity>)info.GetValue("_donhangD", typeof(EntityCollection<DonhangDEntity>));
				_phieugiaohangH = (EntityCollection<PhieugiaohangHEntity>)info.GetValue("_phieugiaohangH", typeof(EntityCollection<PhieugiaohangHEntity>));

				_dmkhach = (DmkhachEntity)info.GetValue("_dmkhach", typeof(DmkhachEntity));
				if(_dmkhach!=null)
				{
					_dmkhach.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((DonhangHFieldIndex)fieldIndex)
			{
				case DonhangHFieldIndex.Makhach:
					DesetupSyncDmkhach(true, false);
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
				case "Dmkhach":
					this.Dmkhach = (DmkhachEntity)entity;
					break;
				case "DonhangD":
					this.DonhangD.Add((DonhangDEntity)entity);
					break;
				case "PhieugiaohangH":
					this.PhieugiaohangH.Add((PhieugiaohangHEntity)entity);
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
			return DonhangHEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Dmkhach":
					toReturn.Add(DonhangHEntity.Relations.DmkhachEntityUsingMakhach);
					break;
				case "DonhangD":
					toReturn.Add(DonhangHEntity.Relations.DonhangDEntityUsingMadon);
					break;
				case "PhieugiaohangH":
					toReturn.Add(DonhangHEntity.Relations.PhieugiaohangHEntityUsingMadon);
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
				case "Dmkhach":
					SetupSyncDmkhach(relatedEntity);
					break;
				case "DonhangD":
					this.DonhangD.Add((DonhangDEntity)relatedEntity);
					break;
				case "PhieugiaohangH":
					this.PhieugiaohangH.Add((PhieugiaohangHEntity)relatedEntity);
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
				case "Dmkhach":
					DesetupSyncDmkhach(false, true);
					break;
				case "DonhangD":
					base.PerformRelatedEntityRemoval(this.DonhangD, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PhieugiaohangH":
					base.PerformRelatedEntityRemoval(this.PhieugiaohangH, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_dmkhach!=null)
			{
				toReturn.Add(_dmkhach);
			}

			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.DonhangD);
			toReturn.Add(this.PhieugiaohangH);

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
				info.AddValue("_donhangD", ((_donhangD!=null) && (_donhangD.Count>0) && !this.MarkedForDeletion)?_donhangD:null);
				info.AddValue("_phieugiaohangH", ((_phieugiaohangH!=null) && (_phieugiaohangH.Count>0) && !this.MarkedForDeletion)?_phieugiaohangH:null);

				info.AddValue("_dmkhach", (!this.MarkedForDeletion?_dmkhach:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(DonhangHFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(DonhangHFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new DonhangHRelations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DonhangD' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDonhangD()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DonhangDFields.Madon, null, ComparisonOperator.Equal, this.Madon));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'PhieugiaohangH' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPhieugiaohangH()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PhieugiaohangHFields.Madon, null, ComparisonOperator.Equal, this.Madon));
			return bucket;
		}


		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Dmkhach' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDmkhach()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DmkhachFields.Makhach, null, ComparisonOperator.Equal, this.Makhach));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(GD.BBPH.DAL.EntityType.DonhangHEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(DonhangHEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._donhangD);
			collectionsQueue.Enqueue(this._phieugiaohangH);

		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._donhangD = (EntityCollection<DonhangDEntity>) collectionsQueue.Dequeue();
			this._phieugiaohangH = (EntityCollection<PhieugiaohangHEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._donhangD != null)
			{
				return true;
			}
			if (this._phieugiaohangH != null)
			{
				return true;
			}

			return base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DonhangDEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DonhangDEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PhieugiaohangHEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PhieugiaohangHEntityFactory))) : null);

		}
#endif
		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Dmkhach", _dmkhach);
			toReturn.Add("DonhangD", _donhangD);
			toReturn.Add("PhieugiaohangH", _phieugiaohangH);


			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_donhangD!=null)
			{
				_donhangD.ActiveContext = base.ActiveContext;
			}
			if(_phieugiaohangH!=null)
			{
				_phieugiaohangH.ActiveContext = base.ActiveContext;
			}

			if(_dmkhach!=null)
			{
				_dmkhach.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_donhangD = null;
			_phieugiaohangH = null;

			_dmkhach = null;

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

			_fieldsCustomProperties.Add("Madon", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaydat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Makhach", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenkhach", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Sobaogia", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaybaogia", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Userid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tennv", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ghichu", fieldHashtable);
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

		/// <summary> Removes the sync logic for member _dmkhach</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncDmkhach(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _dmkhach, new PropertyChangedEventHandler( OnDmkhachPropertyChanged ), "Dmkhach", DonhangHEntity.Relations.DmkhachEntityUsingMakhach, true, signalRelatedEntity, "DonhangH", resetFKFields, new int[] { (int)DonhangHFieldIndex.Makhach } );		
			_dmkhach = null;
		}

		/// <summary> setups the sync logic for member _dmkhach</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncDmkhach(IEntity2 relatedEntity)
		{
			if(_dmkhach!=relatedEntity)
			{
				DesetupSyncDmkhach(true, true);
				_dmkhach = (DmkhachEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _dmkhach, new PropertyChangedEventHandler( OnDmkhachPropertyChanged ), "Dmkhach", DonhangHEntity.Relations.DmkhachEntityUsingMakhach, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnDmkhachPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this DonhangHEntity</param>
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
		public  static DonhangHRelations Relations
		{
			get	{ return new DonhangHRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DonhangD' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDonhangD
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<DonhangDEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DonhangDEntityFactory))),
					(IEntityRelation)GetRelationsForField("DonhangD")[0], (int)GD.BBPH.DAL.EntityType.DonhangHEntity, (int)GD.BBPH.DAL.EntityType.DonhangDEntity, 0, null, null, null, null, "DonhangD", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PhieugiaohangH' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPhieugiaohangH
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<PhieugiaohangHEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PhieugiaohangHEntityFactory))),
					(IEntityRelation)GetRelationsForField("PhieugiaohangH")[0], (int)GD.BBPH.DAL.EntityType.DonhangHEntity, (int)GD.BBPH.DAL.EntityType.PhieugiaohangHEntity, 0, null, null, null, null, "PhieugiaohangH", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}


		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Dmkhach' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDmkhach
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(DmkhachEntityFactory))),
					(IEntityRelation)GetRelationsForField("Dmkhach")[0], (int)GD.BBPH.DAL.EntityType.DonhangHEntity, (int)GD.BBPH.DAL.EntityType.DmkhachEntity, 0, null, null, null, null, "Dmkhach", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return DonhangHEntity.CustomProperties;}
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
			get { return DonhangHEntity.FieldsCustomProperties;}
		}

		/// <summary> The Madon property of the Entity DonhangH<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "donhang_h"."Madon"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String Madon
		{
			get { return (System.String)GetValue((int)DonhangHFieldIndex.Madon, true); }
			set	{ SetValue((int)DonhangHFieldIndex.Madon, value); }
		}

		/// <summary> The Ngaydat property of the Entity DonhangH<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "donhang_h"."Ngaydat"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaydat
		{
			get { return (Nullable<System.DateTime>)GetValue((int)DonhangHFieldIndex.Ngaydat, false); }
			set	{ SetValue((int)DonhangHFieldIndex.Ngaydat, value); }
		}

		/// <summary> The Makhach property of the Entity DonhangH<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "donhang_h"."Makhach"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Makhach
		{
			get { return (System.String)GetValue((int)DonhangHFieldIndex.Makhach, true); }
			set	{ SetValue((int)DonhangHFieldIndex.Makhach, value); }
		}

		/// <summary> The Tenkhach property of the Entity DonhangH<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "donhang_h"."Tenkhach"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Tenkhach
		{
			get { return (System.String)GetValue((int)DonhangHFieldIndex.Tenkhach, true); }
			set	{ SetValue((int)DonhangHFieldIndex.Tenkhach, value); }
		}

		/// <summary> The Sobaogia property of the Entity DonhangH<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "donhang_h"."Sobaogia"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Sobaogia
		{
			get { return (System.String)GetValue((int)DonhangHFieldIndex.Sobaogia, true); }
			set	{ SetValue((int)DonhangHFieldIndex.Sobaogia, value); }
		}

		/// <summary> The Ngaybaogia property of the Entity DonhangH<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "donhang_h"."Ngaybaogia"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaybaogia
		{
			get { return (Nullable<System.DateTime>)GetValue((int)DonhangHFieldIndex.Ngaybaogia, false); }
			set	{ SetValue((int)DonhangHFieldIndex.Ngaybaogia, value); }
		}

		/// <summary> The Userid property of the Entity DonhangH<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "donhang_h"."Userid"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Userid
		{
			get { return (System.String)GetValue((int)DonhangHFieldIndex.Userid, true); }
			set	{ SetValue((int)DonhangHFieldIndex.Userid, value); }
		}

		/// <summary> The Tennv property of the Entity DonhangH<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "donhang_h"."Tennv"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tennv
		{
			get { return (System.String)GetValue((int)DonhangHFieldIndex.Tennv, true); }
			set	{ SetValue((int)DonhangHFieldIndex.Tennv, value); }
		}

		/// <summary> The Ghichu property of the Entity DonhangH<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "donhang_h"."Ghichu"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Ghichu
		{
			get { return (System.String)GetValue((int)DonhangHFieldIndex.Ghichu, true); }
			set	{ SetValue((int)DonhangHFieldIndex.Ghichu, value); }
		}

		/// <summary> The Ngaytao property of the Entity DonhangH<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "donhang_h"."Ngaytao"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaytao
		{
			get { return (Nullable<System.DateTime>)GetValue((int)DonhangHFieldIndex.Ngaytao, false); }
			set	{ SetValue((int)DonhangHFieldIndex.Ngaytao, value); }
		}

		/// <summary> The Nguoitao property of the Entity DonhangH<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "donhang_h"."Nguoitao"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoitao
		{
			get { return (System.String)GetValue((int)DonhangHFieldIndex.Nguoitao, true); }
			set	{ SetValue((int)DonhangHFieldIndex.Nguoitao, value); }
		}

		/// <summary> The Ngaysua property of the Entity DonhangH<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "donhang_h"."Ngaysua"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaysua
		{
			get { return (Nullable<System.DateTime>)GetValue((int)DonhangHFieldIndex.Ngaysua, false); }
			set	{ SetValue((int)DonhangHFieldIndex.Ngaysua, value); }
		}

		/// <summary> The Nguoisua property of the Entity DonhangH<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "donhang_h"."Nguoisua"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoisua
		{
			get { return (System.String)GetValue((int)DonhangHFieldIndex.Nguoisua, true); }
			set	{ SetValue((int)DonhangHFieldIndex.Nguoisua, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DonhangDEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(DonhangDEntity))]
		public virtual EntityCollection<DonhangDEntity> DonhangD
		{
			get
			{
				if(_donhangD==null)
				{
					_donhangD = new EntityCollection<DonhangDEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DonhangDEntityFactory)));
					_donhangD.SetContainingEntityInfo(this, "DonhangH");
				}
				return _donhangD;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PhieugiaohangHEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(PhieugiaohangHEntity))]
		public virtual EntityCollection<PhieugiaohangHEntity> PhieugiaohangH
		{
			get
			{
				if(_phieugiaohangH==null)
				{
					_phieugiaohangH = new EntityCollection<PhieugiaohangHEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PhieugiaohangHEntityFactory)));
					_phieugiaohangH.SetContainingEntityInfo(this, "DonhangH");
				}
				return _phieugiaohangH;
			}
		}


		/// <summary> Gets / sets related entity of type 'DmkhachEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual DmkhachEntity Dmkhach
		{
			get
			{
				return _dmkhach;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncDmkhach(value);
				}
				else
				{
					if(value==null)
					{
						if(_dmkhach != null)
						{
							_dmkhach.UnsetRelatedEntity(this, "DonhangH");
						}
					}
					else
					{
						if(_dmkhach!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "DonhangH");
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
			get { return (int)GD.BBPH.DAL.EntityType.DonhangHEntity; }
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
