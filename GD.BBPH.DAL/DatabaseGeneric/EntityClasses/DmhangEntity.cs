///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Wednesday, October 5, 2022 8:29:25 PM
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
	/// Entity class which represents the entity 'Dmhang'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class DmhangEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<BaogiaDEntity> _baogiaD;
		private EntityCollection<BaogiaHEntity> _baogiaHcollectionViaBaogiaD;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{

			/// <summary>Member name BaogiaD</summary>
			public static readonly string BaogiaD = "BaogiaD";
			/// <summary>Member name BaogiaHcollectionViaBaogiaD</summary>
			public static readonly string BaogiaHcollectionViaBaogiaD = "BaogiaHcollectionViaBaogiaD";

		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static DmhangEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public DmhangEntity():base("DmhangEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public DmhangEntity(IEntityFields2 fields):base("DmhangEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this DmhangEntity</param>
		public DmhangEntity(IValidator validator):base("DmhangEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="masp">PK value for Dmhang which data should be fetched into this Dmhang object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DmhangEntity(System.String masp):base("DmhangEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.Masp = masp;
		}

		/// <summary> CTor</summary>
		/// <param name="masp">PK value for Dmhang which data should be fetched into this Dmhang object</param>
		/// <param name="validator">The custom validator object for this DmhangEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DmhangEntity(System.String masp, IValidator validator):base("DmhangEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.Masp = masp;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected DmhangEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_baogiaD = (EntityCollection<BaogiaDEntity>)info.GetValue("_baogiaD", typeof(EntityCollection<BaogiaDEntity>));
				_baogiaHcollectionViaBaogiaD = (EntityCollection<BaogiaHEntity>)info.GetValue("_baogiaHcollectionViaBaogiaD", typeof(EntityCollection<BaogiaHEntity>));


				base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((DmhangFieldIndex)fieldIndex)
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

				case "BaogiaD":
					this.BaogiaD.Add((BaogiaDEntity)entity);
					break;
				case "BaogiaHcollectionViaBaogiaD":
					this.BaogiaHcollectionViaBaogiaD.IsReadOnly = false;
					this.BaogiaHcollectionViaBaogiaD.Add((BaogiaHEntity)entity);
					this.BaogiaHcollectionViaBaogiaD.IsReadOnly = true;
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
			return DmhangEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "BaogiaD":
					toReturn.Add(DmhangEntity.Relations.BaogiaDEntityUsingMasp);
					break;
				case "BaogiaHcollectionViaBaogiaD":
					toReturn.Add(DmhangEntity.Relations.BaogiaDEntityUsingMasp, "DmhangEntity__", "BaogiaD_", JoinHint.None);
					toReturn.Add(BaogiaDEntity.Relations.BaogiaHEntityUsingSobaogia, "BaogiaD_", string.Empty, JoinHint.None);
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

				case "BaogiaD":
					this.BaogiaD.Add((BaogiaDEntity)relatedEntity);
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

				case "BaogiaD":
					base.PerformRelatedEntityRemoval(this.BaogiaD, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(this.BaogiaD);

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
				info.AddValue("_baogiaD", ((_baogiaD!=null) && (_baogiaD.Count>0) && !this.MarkedForDeletion)?_baogiaD:null);
				info.AddValue("_baogiaHcollectionViaBaogiaD", ((_baogiaHcollectionViaBaogiaD!=null) && (_baogiaHcollectionViaBaogiaD.Count>0) && !this.MarkedForDeletion)?_baogiaHcollectionViaBaogiaD:null);


			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(DmhangFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(DmhangFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new DmhangRelations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'BaogiaD' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBaogiaD()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BaogiaDFields.Masp, null, ComparisonOperator.Equal, this.Masp));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'BaogiaH' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBaogiaHcollectionViaBaogiaD()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("BaogiaHcollectionViaBaogiaD"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DmhangFields.Masp, null, ComparisonOperator.Equal, this.Masp, "DmhangEntity__"));
			return bucket;
		}


	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(GD.BBPH.DAL.EntityType.DmhangEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(DmhangEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._baogiaD);
			collectionsQueue.Enqueue(this._baogiaHcollectionViaBaogiaD);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._baogiaD = (EntityCollection<BaogiaDEntity>) collectionsQueue.Dequeue();
			this._baogiaHcollectionViaBaogiaD = (EntityCollection<BaogiaHEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._baogiaD != null)
			{
				return true;
			}
			if (this._baogiaHcollectionViaBaogiaD != null)
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
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BaogiaDEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BaogiaDEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BaogiaHEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BaogiaHEntityFactory))) : null);
		}
#endif
		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();

			toReturn.Add("BaogiaD", _baogiaD);
			toReturn.Add("BaogiaHcollectionViaBaogiaD", _baogiaHcollectionViaBaogiaD);

			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_baogiaD!=null)
			{
				_baogiaD.ActiveContext = base.ActiveContext;
			}
			if(_baogiaHcollectionViaBaogiaD!=null)
			{
				_baogiaHcollectionViaBaogiaD.ActiveContext = base.ActiveContext;
			}


		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_baogiaD = null;
			_baogiaHcollectionViaBaogiaD = null;


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

			_fieldsCustomProperties.Add("Masp", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tensp", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Makhach", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenkhach", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Kichthuoc", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Khoiluongmuc", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Sohinh", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Cautrucin", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Somau", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Loaimuc", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Kichthuoctruc", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Vitri", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Quycachdonggoi", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Loaithung", fieldHashtable);
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
		/// <param name="validator">The validator object for this DmhangEntity</param>
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
		public  static DmhangRelations Relations
		{
			get	{ return new DmhangRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BaogiaD' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBaogiaD
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<BaogiaDEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BaogiaDEntityFactory))),
					(IEntityRelation)GetRelationsForField("BaogiaD")[0], (int)GD.BBPH.DAL.EntityType.DmhangEntity, (int)GD.BBPH.DAL.EntityType.BaogiaDEntity, 0, null, null, null, null, "BaogiaD", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BaogiaH' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBaogiaHcollectionViaBaogiaD
		{
			get
			{
				IEntityRelation intermediateRelation = DmhangEntity.Relations.BaogiaDEntityUsingMasp;
				intermediateRelation.SetAliases(string.Empty, "BaogiaD_");
				return new PrefetchPathElement2(new EntityCollection<BaogiaHEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BaogiaHEntityFactory))), intermediateRelation,
					(int)GD.BBPH.DAL.EntityType.DmhangEntity, (int)GD.BBPH.DAL.EntityType.BaogiaHEntity, 0, null, null, GetRelationsForField("BaogiaHcollectionViaBaogiaD"), null, "BaogiaHcollectionViaBaogiaD", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return DmhangEntity.CustomProperties;}
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
			get { return DmhangEntity.FieldsCustomProperties;}
		}

		/// <summary> The Masp property of the Entity Dmhang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmhang"."Masp"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String Masp
		{
			get { return (System.String)GetValue((int)DmhangFieldIndex.Masp, true); }
			set	{ SetValue((int)DmhangFieldIndex.Masp, value); }
		}

		/// <summary> The Tensp property of the Entity Dmhang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmhang"."Tensp"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Tensp
		{
			get { return (System.String)GetValue((int)DmhangFieldIndex.Tensp, true); }
			set	{ SetValue((int)DmhangFieldIndex.Tensp, value); }
		}

		/// <summary> The Makhach property of the Entity Dmhang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmhang"."Makhach"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Makhach
		{
			get { return (System.String)GetValue((int)DmhangFieldIndex.Makhach, true); }
			set	{ SetValue((int)DmhangFieldIndex.Makhach, value); }
		}

		/// <summary> The Tenkhach property of the Entity Dmhang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmhang"."Tenkhach"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tenkhach
		{
			get { return (System.String)GetValue((int)DmhangFieldIndex.Tenkhach, true); }
			set	{ SetValue((int)DmhangFieldIndex.Tenkhach, value); }
		}

		/// <summary> The Kichthuoc property of the Entity Dmhang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmhang"."kichthuoc"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Kichthuoc
		{
			get { return (System.String)GetValue((int)DmhangFieldIndex.Kichthuoc, true); }
			set	{ SetValue((int)DmhangFieldIndex.Kichthuoc, value); }
		}

		/// <summary> The Khoiluongmuc property of the Entity Dmhang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmhang"."Khoiluongmuc"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Khoiluongmuc
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DmhangFieldIndex.Khoiluongmuc, false); }
			set	{ SetValue((int)DmhangFieldIndex.Khoiluongmuc, value); }
		}

		/// <summary> The Sohinh property of the Entity Dmhang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmhang"."Sohinh"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Sohinh
		{
			get { return (Nullable<System.Int32>)GetValue((int)DmhangFieldIndex.Sohinh, false); }
			set	{ SetValue((int)DmhangFieldIndex.Sohinh, value); }
		}

		/// <summary> The Cautrucin property of the Entity Dmhang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmhang"."Cautrucin"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Cautrucin
		{
			get { return (System.String)GetValue((int)DmhangFieldIndex.Cautrucin, true); }
			set	{ SetValue((int)DmhangFieldIndex.Cautrucin, value); }
		}

		/// <summary> The Somau property of the Entity Dmhang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmhang"."Somau"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Somau
		{
			get { return (Nullable<System.Int32>)GetValue((int)DmhangFieldIndex.Somau, false); }
			set	{ SetValue((int)DmhangFieldIndex.Somau, value); }
		}

		/// <summary> The Loaimuc property of the Entity Dmhang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmhang"."Loaimuc"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Loaimuc
		{
			get { return (System.String)GetValue((int)DmhangFieldIndex.Loaimuc, true); }
			set	{ SetValue((int)DmhangFieldIndex.Loaimuc, value); }
		}

		/// <summary> The Kichthuoctruc property of the Entity Dmhang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmhang"."Kichthuoctruc"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Kichthuoctruc
		{
			get { return (System.String)GetValue((int)DmhangFieldIndex.Kichthuoctruc, true); }
			set	{ SetValue((int)DmhangFieldIndex.Kichthuoctruc, value); }
		}

		/// <summary> The Vitri property of the Entity Dmhang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmhang"."Vitri"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Vitri
		{
			get { return (System.String)GetValue((int)DmhangFieldIndex.Vitri, true); }
			set	{ SetValue((int)DmhangFieldIndex.Vitri, value); }
		}

		/// <summary> The Quycachdonggoi property of the Entity Dmhang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmhang"."Quycachdonggoi"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Quycachdonggoi
		{
			get { return (System.String)GetValue((int)DmhangFieldIndex.Quycachdonggoi, true); }
			set	{ SetValue((int)DmhangFieldIndex.Quycachdonggoi, value); }
		}

		/// <summary> The Loaithung property of the Entity Dmhang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmhang"."Loaithung"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Loaithung
		{
			get { return (System.String)GetValue((int)DmhangFieldIndex.Loaithung, true); }
			set	{ SetValue((int)DmhangFieldIndex.Loaithung, value); }
		}

		/// <summary> The Ngaytao property of the Entity Dmhang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmhang"."Ngaytao"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaytao
		{
			get { return (Nullable<System.DateTime>)GetValue((int)DmhangFieldIndex.Ngaytao, false); }
			set	{ SetValue((int)DmhangFieldIndex.Ngaytao, value); }
		}

		/// <summary> The Nguoitao property of the Entity Dmhang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmhang"."Nguoitao"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoitao
		{
			get { return (System.String)GetValue((int)DmhangFieldIndex.Nguoitao, true); }
			set	{ SetValue((int)DmhangFieldIndex.Nguoitao, value); }
		}

		/// <summary> The Ngaysua property of the Entity Dmhang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmhang"."Ngaysua"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaysua
		{
			get { return (Nullable<System.DateTime>)GetValue((int)DmhangFieldIndex.Ngaysua, false); }
			set	{ SetValue((int)DmhangFieldIndex.Ngaysua, value); }
		}

		/// <summary> The Nguoisua property of the Entity Dmhang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmhang"."Nguoisua"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoisua
		{
			get { return (System.String)GetValue((int)DmhangFieldIndex.Nguoisua, true); }
			set	{ SetValue((int)DmhangFieldIndex.Nguoisua, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BaogiaDEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(BaogiaDEntity))]
		public virtual EntityCollection<BaogiaDEntity> BaogiaD
		{
			get
			{
				if(_baogiaD==null)
				{
					_baogiaD = new EntityCollection<BaogiaDEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BaogiaDEntityFactory)));
					_baogiaD.SetContainingEntityInfo(this, "Dmhang");
				}
				return _baogiaD;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BaogiaHEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(BaogiaHEntity))]
		public virtual EntityCollection<BaogiaHEntity> BaogiaHcollectionViaBaogiaD
		{
			get
			{
				if(_baogiaHcollectionViaBaogiaD==null)
				{
					_baogiaHcollectionViaBaogiaD = new EntityCollection<BaogiaHEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BaogiaHEntityFactory)));
					_baogiaHcollectionViaBaogiaD.IsReadOnly=true;
				}
				return _baogiaHcollectionViaBaogiaD;
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
			get { return (int)GD.BBPH.DAL.EntityType.DmhangEntity; }
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
