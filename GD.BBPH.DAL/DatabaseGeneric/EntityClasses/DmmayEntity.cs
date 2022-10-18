///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Monday, October 17, 2022 2:56:16 PM
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
	/// Entity class which represents the entity 'Dmmay'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class DmmayEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<KetquaghepEntity> _ketquaghep;
		private EntityCollection<KetquainEntity> _ketquain;
		private EntityCollection<KetquathoiEntity> _ketquathoi;
		private EntityCollection<KetquatuaEntity> _ketquatua;



		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{

			/// <summary>Member name Ketquaghep</summary>
			public static readonly string Ketquaghep = "Ketquaghep";
			/// <summary>Member name Ketquain</summary>
			public static readonly string Ketquain = "Ketquain";
			/// <summary>Member name Ketquathoi</summary>
			public static readonly string Ketquathoi = "Ketquathoi";
			/// <summary>Member name Ketquatua</summary>
			public static readonly string Ketquatua = "Ketquatua";


		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static DmmayEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public DmmayEntity():base("DmmayEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public DmmayEntity(IEntityFields2 fields):base("DmmayEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this DmmayEntity</param>
		public DmmayEntity(IValidator validator):base("DmmayEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="mamay">PK value for Dmmay which data should be fetched into this Dmmay object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DmmayEntity(System.String mamay):base("DmmayEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.Mamay = mamay;
		}

		/// <summary> CTor</summary>
		/// <param name="mamay">PK value for Dmmay which data should be fetched into this Dmmay object</param>
		/// <param name="validator">The custom validator object for this DmmayEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DmmayEntity(System.String mamay, IValidator validator):base("DmmayEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.Mamay = mamay;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected DmmayEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_ketquaghep = (EntityCollection<KetquaghepEntity>)info.GetValue("_ketquaghep", typeof(EntityCollection<KetquaghepEntity>));
				_ketquain = (EntityCollection<KetquainEntity>)info.GetValue("_ketquain", typeof(EntityCollection<KetquainEntity>));
				_ketquathoi = (EntityCollection<KetquathoiEntity>)info.GetValue("_ketquathoi", typeof(EntityCollection<KetquathoiEntity>));
				_ketquatua = (EntityCollection<KetquatuaEntity>)info.GetValue("_ketquatua", typeof(EntityCollection<KetquatuaEntity>));



				base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((DmmayFieldIndex)fieldIndex)
			{
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

				case "Ketquaghep":
					this.Ketquaghep.Add((KetquaghepEntity)entity);
					break;
				case "Ketquain":
					this.Ketquain.Add((KetquainEntity)entity);
					break;
				case "Ketquathoi":
					this.Ketquathoi.Add((KetquathoiEntity)entity);
					break;
				case "Ketquatua":
					this.Ketquatua.Add((KetquatuaEntity)entity);
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
			return DmmayEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "Ketquaghep":
					toReturn.Add(DmmayEntity.Relations.KetquaghepEntityUsingMamay);
					break;
				case "Ketquain":
					toReturn.Add(DmmayEntity.Relations.KetquainEntityUsingMamay);
					break;
				case "Ketquathoi":
					toReturn.Add(DmmayEntity.Relations.KetquathoiEntityUsingMamay);
					break;
				case "Ketquatua":
					toReturn.Add(DmmayEntity.Relations.KetquatuaEntityUsingMamay);
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

				case "Ketquaghep":
					this.Ketquaghep.Add((KetquaghepEntity)relatedEntity);
					break;
				case "Ketquain":
					this.Ketquain.Add((KetquainEntity)relatedEntity);
					break;
				case "Ketquathoi":
					this.Ketquathoi.Add((KetquathoiEntity)relatedEntity);
					break;
				case "Ketquatua":
					this.Ketquatua.Add((KetquatuaEntity)relatedEntity);
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

				case "Ketquaghep":
					base.PerformRelatedEntityRemoval(this.Ketquaghep, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Ketquain":
					base.PerformRelatedEntityRemoval(this.Ketquain, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Ketquathoi":
					base.PerformRelatedEntityRemoval(this.Ketquathoi, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Ketquatua":
					base.PerformRelatedEntityRemoval(this.Ketquatua, relatedEntity, signalRelatedEntityManyToOne);
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


			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.Ketquaghep);
			toReturn.Add(this.Ketquain);
			toReturn.Add(this.Ketquathoi);
			toReturn.Add(this.Ketquatua);

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
				info.AddValue("_ketquaghep", ((_ketquaghep!=null) && (_ketquaghep.Count>0) && !this.MarkedForDeletion)?_ketquaghep:null);
				info.AddValue("_ketquain", ((_ketquain!=null) && (_ketquain.Count>0) && !this.MarkedForDeletion)?_ketquain:null);
				info.AddValue("_ketquathoi", ((_ketquathoi!=null) && (_ketquathoi.Count>0) && !this.MarkedForDeletion)?_ketquathoi:null);
				info.AddValue("_ketquatua", ((_ketquatua!=null) && (_ketquatua.Count>0) && !this.MarkedForDeletion)?_ketquatua:null);



			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(DmmayFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(DmmayFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new DmmayRelations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Ketquaghep' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoKetquaghep()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(KetquaghepFields.Mamay, null, ComparisonOperator.Equal, this.Mamay));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Ketquain' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoKetquain()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(KetquainFields.Mamay, null, ComparisonOperator.Equal, this.Mamay));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Ketquathoi' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoKetquathoi()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(KetquathoiFields.Mamay, null, ComparisonOperator.Equal, this.Mamay));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Ketquatua' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoKetquatua()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(KetquatuaFields.Mamay, null, ComparisonOperator.Equal, this.Mamay));
			return bucket;
		}



	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(GD.BBPH.DAL.EntityType.DmmayEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(DmmayEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._ketquaghep);
			collectionsQueue.Enqueue(this._ketquain);
			collectionsQueue.Enqueue(this._ketquathoi);
			collectionsQueue.Enqueue(this._ketquatua);

		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._ketquaghep = (EntityCollection<KetquaghepEntity>) collectionsQueue.Dequeue();
			this._ketquain = (EntityCollection<KetquainEntity>) collectionsQueue.Dequeue();
			this._ketquathoi = (EntityCollection<KetquathoiEntity>) collectionsQueue.Dequeue();
			this._ketquatua = (EntityCollection<KetquatuaEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._ketquaghep != null)
			{
				return true;
			}
			if (this._ketquain != null)
			{
				return true;
			}
			if (this._ketquathoi != null)
			{
				return true;
			}
			if (this._ketquatua != null)
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
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<KetquaghepEntity>(EntityFactoryCache2.GetEntityFactory(typeof(KetquaghepEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<KetquainEntity>(EntityFactoryCache2.GetEntityFactory(typeof(KetquainEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<KetquathoiEntity>(EntityFactoryCache2.GetEntityFactory(typeof(KetquathoiEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<KetquatuaEntity>(EntityFactoryCache2.GetEntityFactory(typeof(KetquatuaEntityFactory))) : null);

		}
#endif
		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();

			toReturn.Add("Ketquaghep", _ketquaghep);
			toReturn.Add("Ketquain", _ketquain);
			toReturn.Add("Ketquathoi", _ketquathoi);
			toReturn.Add("Ketquatua", _ketquatua);


			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_ketquaghep!=null)
			{
				_ketquaghep.ActiveContext = base.ActiveContext;
			}
			if(_ketquain!=null)
			{
				_ketquain.ActiveContext = base.ActiveContext;
			}
			if(_ketquathoi!=null)
			{
				_ketquathoi.ActiveContext = base.ActiveContext;
			}
			if(_ketquatua!=null)
			{
				_ketquatua.ActiveContext = base.ActiveContext;
			}



		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_ketquaghep = null;
			_ketquain = null;
			_ketquathoi = null;
			_ketquatua = null;



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

			_fieldsCustomProperties.Add("Mamay", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenmay", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Madm", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Vitri", fieldHashtable);
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



		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this DmmayEntity</param>
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
		public  static DmmayRelations Relations
		{
			get	{ return new DmmayRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Ketquaghep' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathKetquaghep
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<KetquaghepEntity>(EntityFactoryCache2.GetEntityFactory(typeof(KetquaghepEntityFactory))),
					(IEntityRelation)GetRelationsForField("Ketquaghep")[0], (int)GD.BBPH.DAL.EntityType.DmmayEntity, (int)GD.BBPH.DAL.EntityType.KetquaghepEntity, 0, null, null, null, null, "Ketquaghep", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Ketquain' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathKetquain
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<KetquainEntity>(EntityFactoryCache2.GetEntityFactory(typeof(KetquainEntityFactory))),
					(IEntityRelation)GetRelationsForField("Ketquain")[0], (int)GD.BBPH.DAL.EntityType.DmmayEntity, (int)GD.BBPH.DAL.EntityType.KetquainEntity, 0, null, null, null, null, "Ketquain", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Ketquathoi' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathKetquathoi
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<KetquathoiEntity>(EntityFactoryCache2.GetEntityFactory(typeof(KetquathoiEntityFactory))),
					(IEntityRelation)GetRelationsForField("Ketquathoi")[0], (int)GD.BBPH.DAL.EntityType.DmmayEntity, (int)GD.BBPH.DAL.EntityType.KetquathoiEntity, 0, null, null, null, null, "Ketquathoi", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Ketquatua' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathKetquatua
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<KetquatuaEntity>(EntityFactoryCache2.GetEntityFactory(typeof(KetquatuaEntityFactory))),
					(IEntityRelation)GetRelationsForField("Ketquatua")[0], (int)GD.BBPH.DAL.EntityType.DmmayEntity, (int)GD.BBPH.DAL.EntityType.KetquatuaEntity, 0, null, null, null, null, "Ketquatua", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}




		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return DmmayEntity.CustomProperties;}
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
			get { return DmmayEntity.FieldsCustomProperties;}
		}

		/// <summary> The Mamay property of the Entity Dmmay<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmmay"."Mamay"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String Mamay
		{
			get { return (System.String)GetValue((int)DmmayFieldIndex.Mamay, true); }
			set	{ SetValue((int)DmmayFieldIndex.Mamay, value); }
		}

		/// <summary> The Tenmay property of the Entity Dmmay<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmmay"."Tenmay"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Tenmay
		{
			get { return (System.String)GetValue((int)DmmayFieldIndex.Tenmay, true); }
			set	{ SetValue((int)DmmayFieldIndex.Tenmay, value); }
		}

		/// <summary> The Madm property of the Entity Dmmay<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmmay"."Madm"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Madm
		{
			get { return (System.String)GetValue((int)DmmayFieldIndex.Madm, true); }
			set	{ SetValue((int)DmmayFieldIndex.Madm, value); }
		}

		/// <summary> The Vitri property of the Entity Dmmay<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmmay"."Vitri"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Vitri
		{
			get { return (System.String)GetValue((int)DmmayFieldIndex.Vitri, true); }
			set	{ SetValue((int)DmmayFieldIndex.Vitri, value); }
		}

		/// <summary> The Ngaytao property of the Entity Dmmay<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmmay"."Ngaytao"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaytao
		{
			get { return (Nullable<System.DateTime>)GetValue((int)DmmayFieldIndex.Ngaytao, false); }
			set	{ SetValue((int)DmmayFieldIndex.Ngaytao, value); }
		}

		/// <summary> The Nguoitao property of the Entity Dmmay<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmmay"."Nguoitao"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoitao
		{
			get { return (System.String)GetValue((int)DmmayFieldIndex.Nguoitao, true); }
			set	{ SetValue((int)DmmayFieldIndex.Nguoitao, value); }
		}

		/// <summary> The Ngaysua property of the Entity Dmmay<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmmay"."Ngaysua"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaysua
		{
			get { return (Nullable<System.DateTime>)GetValue((int)DmmayFieldIndex.Ngaysua, false); }
			set	{ SetValue((int)DmmayFieldIndex.Ngaysua, value); }
		}

		/// <summary> The Nguoisua property of the Entity Dmmay<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmmay"."Nguoisua"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoisua
		{
			get { return (System.String)GetValue((int)DmmayFieldIndex.Nguoisua, true); }
			set	{ SetValue((int)DmmayFieldIndex.Nguoisua, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'KetquaghepEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(KetquaghepEntity))]
		public virtual EntityCollection<KetquaghepEntity> Ketquaghep
		{
			get
			{
				if(_ketquaghep==null)
				{
					_ketquaghep = new EntityCollection<KetquaghepEntity>(EntityFactoryCache2.GetEntityFactory(typeof(KetquaghepEntityFactory)));
					_ketquaghep.SetContainingEntityInfo(this, "Dmmay");
				}
				return _ketquaghep;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'KetquainEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(KetquainEntity))]
		public virtual EntityCollection<KetquainEntity> Ketquain
		{
			get
			{
				if(_ketquain==null)
				{
					_ketquain = new EntityCollection<KetquainEntity>(EntityFactoryCache2.GetEntityFactory(typeof(KetquainEntityFactory)));
					_ketquain.SetContainingEntityInfo(this, "Dmmay");
				}
				return _ketquain;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'KetquathoiEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(KetquathoiEntity))]
		public virtual EntityCollection<KetquathoiEntity> Ketquathoi
		{
			get
			{
				if(_ketquathoi==null)
				{
					_ketquathoi = new EntityCollection<KetquathoiEntity>(EntityFactoryCache2.GetEntityFactory(typeof(KetquathoiEntityFactory)));
					_ketquathoi.SetContainingEntityInfo(this, "Dmmay");
				}
				return _ketquathoi;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'KetquatuaEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(KetquatuaEntity))]
		public virtual EntityCollection<KetquatuaEntity> Ketquatua
		{
			get
			{
				if(_ketquatua==null)
				{
					_ketquatua = new EntityCollection<KetquatuaEntity>(EntityFactoryCache2.GetEntityFactory(typeof(KetquatuaEntityFactory)));
					_ketquatua.SetContainingEntityInfo(this, "Dmmay");
				}
				return _ketquatua;
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
			get { return (int)GD.BBPH.DAL.EntityType.DmmayEntity; }
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
