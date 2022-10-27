///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Thursday, October 27, 2022 10:17:27 AM
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
	/// Entity class which represents the entity 'Dmkhach'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class DmkhachEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<BaogiaHEntity> _baogiaH;
		private EntityCollection<DonhangHEntity> _donhangH;



		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{

			/// <summary>Member name BaogiaH</summary>
			public static readonly string BaogiaH = "BaogiaH";
			/// <summary>Member name DonhangH</summary>
			public static readonly string DonhangH = "DonhangH";


		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static DmkhachEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public DmkhachEntity():base("DmkhachEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public DmkhachEntity(IEntityFields2 fields):base("DmkhachEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this DmkhachEntity</param>
		public DmkhachEntity(IValidator validator):base("DmkhachEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="makhach">PK value for Dmkhach which data should be fetched into this Dmkhach object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DmkhachEntity(System.String makhach):base("DmkhachEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.Makhach = makhach;
		}

		/// <summary> CTor</summary>
		/// <param name="makhach">PK value for Dmkhach which data should be fetched into this Dmkhach object</param>
		/// <param name="validator">The custom validator object for this DmkhachEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DmkhachEntity(System.String makhach, IValidator validator):base("DmkhachEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.Makhach = makhach;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected DmkhachEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_baogiaH = (EntityCollection<BaogiaHEntity>)info.GetValue("_baogiaH", typeof(EntityCollection<BaogiaHEntity>));
				_donhangH = (EntityCollection<DonhangHEntity>)info.GetValue("_donhangH", typeof(EntityCollection<DonhangHEntity>));



				base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((DmkhachFieldIndex)fieldIndex)
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

				case "BaogiaH":
					this.BaogiaH.Add((BaogiaHEntity)entity);
					break;
				case "DonhangH":
					this.DonhangH.Add((DonhangHEntity)entity);
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
			return DmkhachEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "BaogiaH":
					toReturn.Add(DmkhachEntity.Relations.BaogiaHEntityUsingMakhach);
					break;
				case "DonhangH":
					toReturn.Add(DmkhachEntity.Relations.DonhangHEntityUsingMakhach);
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

				case "BaogiaH":
					this.BaogiaH.Add((BaogiaHEntity)relatedEntity);
					break;
				case "DonhangH":
					this.DonhangH.Add((DonhangHEntity)relatedEntity);
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

				case "BaogiaH":
					base.PerformRelatedEntityRemoval(this.BaogiaH, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "DonhangH":
					base.PerformRelatedEntityRemoval(this.DonhangH, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(this.BaogiaH);
			toReturn.Add(this.DonhangH);

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
				info.AddValue("_baogiaH", ((_baogiaH!=null) && (_baogiaH.Count>0) && !this.MarkedForDeletion)?_baogiaH:null);
				info.AddValue("_donhangH", ((_donhangH!=null) && (_donhangH.Count>0) && !this.MarkedForDeletion)?_donhangH:null);



			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(DmkhachFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(DmkhachFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new DmkhachRelations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'BaogiaH' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBaogiaH()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BaogiaHFields.Makhach, null, ComparisonOperator.Equal, this.Makhach));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DonhangH' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDonhangH()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DonhangHFields.Makhach, null, ComparisonOperator.Equal, this.Makhach));
			return bucket;
		}



	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(GD.BBPH.DAL.EntityType.DmkhachEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(DmkhachEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._baogiaH);
			collectionsQueue.Enqueue(this._donhangH);

		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._baogiaH = (EntityCollection<BaogiaHEntity>) collectionsQueue.Dequeue();
			this._donhangH = (EntityCollection<DonhangHEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._baogiaH != null)
			{
				return true;
			}
			if (this._donhangH != null)
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
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BaogiaHEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BaogiaHEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DonhangHEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DonhangHEntityFactory))) : null);

		}
#endif
		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();

			toReturn.Add("BaogiaH", _baogiaH);
			toReturn.Add("DonhangH", _donhangH);


			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_baogiaH!=null)
			{
				_baogiaH.ActiveContext = base.ActiveContext;
			}
			if(_donhangH!=null)
			{
				_donhangH.ActiveContext = base.ActiveContext;
			}



		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_baogiaH = null;
			_donhangH = null;



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

			_fieldsCustomProperties.Add("Makhach", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenkhach", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenrutgon", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Truyenthong", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Diachi", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Sodienthoai", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Email", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tknganhang", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tennganhang", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Noidia", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tennguoilh", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Chucvu", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Sodienthoailh", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thongtinbosung", fieldHashtable);
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
		/// <param name="validator">The validator object for this DmkhachEntity</param>
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
		public  static DmkhachRelations Relations
		{
			get	{ return new DmkhachRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BaogiaH' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBaogiaH
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<BaogiaHEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BaogiaHEntityFactory))),
					(IEntityRelation)GetRelationsForField("BaogiaH")[0], (int)GD.BBPH.DAL.EntityType.DmkhachEntity, (int)GD.BBPH.DAL.EntityType.BaogiaHEntity, 0, null, null, null, null, "BaogiaH", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DonhangH' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDonhangH
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<DonhangHEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DonhangHEntityFactory))),
					(IEntityRelation)GetRelationsForField("DonhangH")[0], (int)GD.BBPH.DAL.EntityType.DmkhachEntity, (int)GD.BBPH.DAL.EntityType.DonhangHEntity, 0, null, null, null, null, "DonhangH", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}




		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return DmkhachEntity.CustomProperties;}
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
			get { return DmkhachEntity.FieldsCustomProperties;}
		}

		/// <summary> The Makhach property of the Entity Dmkhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmkhach"."Makhach"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String Makhach
		{
			get { return (System.String)GetValue((int)DmkhachFieldIndex.Makhach, true); }
			set	{ SetValue((int)DmkhachFieldIndex.Makhach, value); }
		}

		/// <summary> The Tenkhach property of the Entity Dmkhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmkhach"."Tenkhach"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Tenkhach
		{
			get { return (System.String)GetValue((int)DmkhachFieldIndex.Tenkhach, true); }
			set	{ SetValue((int)DmkhachFieldIndex.Tenkhach, value); }
		}

		/// <summary> The Tenrutgon property of the Entity Dmkhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmkhach"."Tenrutgon"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tenrutgon
		{
			get { return (System.String)GetValue((int)DmkhachFieldIndex.Tenrutgon, true); }
			set	{ SetValue((int)DmkhachFieldIndex.Tenrutgon, value); }
		}

		/// <summary> The Truyenthong property of the Entity Dmkhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmkhach"."Truyenthong"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Truyenthong
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DmkhachFieldIndex.Truyenthong, false); }
			set	{ SetValue((int)DmkhachFieldIndex.Truyenthong, value); }
		}

		/// <summary> The Diachi property of the Entity Dmkhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmkhach"."Diachi"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Diachi
		{
			get { return (System.String)GetValue((int)DmkhachFieldIndex.Diachi, true); }
			set	{ SetValue((int)DmkhachFieldIndex.Diachi, value); }
		}

		/// <summary> The Sodienthoai property of the Entity Dmkhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmkhach"."Sodienthoai"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Sodienthoai
		{
			get { return (System.String)GetValue((int)DmkhachFieldIndex.Sodienthoai, true); }
			set	{ SetValue((int)DmkhachFieldIndex.Sodienthoai, value); }
		}

		/// <summary> The Email property of the Entity Dmkhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmkhach"."Email"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Email
		{
			get { return (System.String)GetValue((int)DmkhachFieldIndex.Email, true); }
			set	{ SetValue((int)DmkhachFieldIndex.Email, value); }
		}

		/// <summary> The Tknganhang property of the Entity Dmkhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmkhach"."Tknganhang"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tknganhang
		{
			get { return (System.String)GetValue((int)DmkhachFieldIndex.Tknganhang, true); }
			set	{ SetValue((int)DmkhachFieldIndex.Tknganhang, value); }
		}

		/// <summary> The Tennganhang property of the Entity Dmkhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmkhach"."Tennganhang"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tennganhang
		{
			get { return (System.String)GetValue((int)DmkhachFieldIndex.Tennganhang, true); }
			set	{ SetValue((int)DmkhachFieldIndex.Tennganhang, value); }
		}

		/// <summary> The Noidia property of the Entity Dmkhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmkhach"."Noidia"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Noidia
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DmkhachFieldIndex.Noidia, false); }
			set	{ SetValue((int)DmkhachFieldIndex.Noidia, value); }
		}

		/// <summary> The Tennguoilh property of the Entity Dmkhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmkhach"."Tennguoilh"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tennguoilh
		{
			get { return (System.String)GetValue((int)DmkhachFieldIndex.Tennguoilh, true); }
			set	{ SetValue((int)DmkhachFieldIndex.Tennguoilh, value); }
		}

		/// <summary> The Chucvu property of the Entity Dmkhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmkhach"."chucvu"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Chucvu
		{
			get { return (System.String)GetValue((int)DmkhachFieldIndex.Chucvu, true); }
			set	{ SetValue((int)DmkhachFieldIndex.Chucvu, value); }
		}

		/// <summary> The Sodienthoailh property of the Entity Dmkhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmkhach"."Sodienthoailh"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Sodienthoailh
		{
			get { return (System.String)GetValue((int)DmkhachFieldIndex.Sodienthoailh, true); }
			set	{ SetValue((int)DmkhachFieldIndex.Sodienthoailh, value); }
		}

		/// <summary> The Thongtinbosung property of the Entity Dmkhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmkhach"."thongtinbosung"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Thongtinbosung
		{
			get { return (System.String)GetValue((int)DmkhachFieldIndex.Thongtinbosung, true); }
			set	{ SetValue((int)DmkhachFieldIndex.Thongtinbosung, value); }
		}

		/// <summary> The Ngaytao property of the Entity Dmkhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmkhach"."Ngaytao"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaytao
		{
			get { return (Nullable<System.DateTime>)GetValue((int)DmkhachFieldIndex.Ngaytao, false); }
			set	{ SetValue((int)DmkhachFieldIndex.Ngaytao, value); }
		}

		/// <summary> The Nguoitao property of the Entity Dmkhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmkhach"."Nguoitao"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoitao
		{
			get { return (System.String)GetValue((int)DmkhachFieldIndex.Nguoitao, true); }
			set	{ SetValue((int)DmkhachFieldIndex.Nguoitao, value); }
		}

		/// <summary> The Ngaysua property of the Entity Dmkhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmkhach"."Ngaysua"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaysua
		{
			get { return (Nullable<System.DateTime>)GetValue((int)DmkhachFieldIndex.Ngaysua, false); }
			set	{ SetValue((int)DmkhachFieldIndex.Ngaysua, value); }
		}

		/// <summary> The Nguoisua property of the Entity Dmkhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dmkhach"."Nguoisua"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoisua
		{
			get { return (System.String)GetValue((int)DmkhachFieldIndex.Nguoisua, true); }
			set	{ SetValue((int)DmkhachFieldIndex.Nguoisua, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BaogiaHEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(BaogiaHEntity))]
		public virtual EntityCollection<BaogiaHEntity> BaogiaH
		{
			get
			{
				if(_baogiaH==null)
				{
					_baogiaH = new EntityCollection<BaogiaHEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BaogiaHEntityFactory)));
					_baogiaH.SetContainingEntityInfo(this, "Dmkhach");
				}
				return _baogiaH;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DonhangHEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(DonhangHEntity))]
		public virtual EntityCollection<DonhangHEntity> DonhangH
		{
			get
			{
				if(_donhangH==null)
				{
					_donhangH = new EntityCollection<DonhangHEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DonhangHEntityFactory)));
					_donhangH.SetContainingEntityInfo(this, "Dmkhach");
				}
				return _donhangH;
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
			get { return (int)GD.BBPH.DAL.EntityType.DmkhachEntity; }
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
