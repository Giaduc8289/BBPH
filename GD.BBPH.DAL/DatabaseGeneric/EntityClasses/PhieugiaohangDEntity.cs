///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Monday, October 31, 2022 5:06:48 PM
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
	/// Entity class which represents the entity 'PhieugiaohangD'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class PhieugiaohangDEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations


		private PhieugiaohangHEntity _phieugiaohangH;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name PhieugiaohangH</summary>
			public static readonly string PhieugiaohangH = "PhieugiaohangH";



		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static PhieugiaohangDEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public PhieugiaohangDEntity():base("PhieugiaohangDEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public PhieugiaohangDEntity(IEntityFields2 fields):base("PhieugiaohangDEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PhieugiaohangDEntity</param>
		public PhieugiaohangDEntity(IValidator validator):base("PhieugiaohangDEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="id">PK value for PhieugiaohangD which data should be fetched into this PhieugiaohangD object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public PhieugiaohangDEntity(System.Int64 id):base("PhieugiaohangDEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for PhieugiaohangD which data should be fetched into this PhieugiaohangD object</param>
		/// <param name="validator">The custom validator object for this PhieugiaohangDEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public PhieugiaohangDEntity(System.Int64 id, IValidator validator):base("PhieugiaohangDEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected PhieugiaohangDEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{


				_phieugiaohangH = (PhieugiaohangHEntity)info.GetValue("_phieugiaohangH", typeof(PhieugiaohangHEntity));
				if(_phieugiaohangH!=null)
				{
					_phieugiaohangH.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((PhieugiaohangDFieldIndex)fieldIndex)
			{
				case PhieugiaohangDFieldIndex.Sophieu:
					DesetupSyncPhieugiaohangH(true, false);
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
				case "PhieugiaohangH":
					this.PhieugiaohangH = (PhieugiaohangHEntity)entity;
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
			return PhieugiaohangDEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "PhieugiaohangH":
					toReturn.Add(PhieugiaohangDEntity.Relations.PhieugiaohangHEntityUsingSophieu);
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
				case "PhieugiaohangH":
					SetupSyncPhieugiaohangH(relatedEntity);
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
				case "PhieugiaohangH":
					DesetupSyncPhieugiaohangH(false, true);
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
			if(_phieugiaohangH!=null)
			{
				toReturn.Add(_phieugiaohangH);
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


				info.AddValue("_phieugiaohangH", (!this.MarkedForDeletion?_phieugiaohangH:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(PhieugiaohangDFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(PhieugiaohangDFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new PhieugiaohangDRelations().GetAllRelations();
		}
		



		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'PhieugiaohangH' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPhieugiaohangH()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PhieugiaohangHFields.Sophieu, null, ComparisonOperator.Equal, this.Sophieu));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(GD.BBPH.DAL.EntityType.PhieugiaohangDEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(PhieugiaohangDEntityFactory));
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
			toReturn.Add("PhieugiaohangH", _phieugiaohangH);



			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_phieugiaohangH!=null)
			{
				_phieugiaohangH.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{



			_phieugiaohangH = null;

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

			_fieldsCustomProperties.Add("Sophieu", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaygiao", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Madon", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DonchitietId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaydat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Makhach", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenkhach", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Loaihang", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Masp", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenhang", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Soluong", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Dongia", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thanhtien", fieldHashtable);
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

		/// <summary> Removes the sync logic for member _phieugiaohangH</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPhieugiaohangH(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _phieugiaohangH, new PropertyChangedEventHandler( OnPhieugiaohangHPropertyChanged ), "PhieugiaohangH", PhieugiaohangDEntity.Relations.PhieugiaohangHEntityUsingSophieu, true, signalRelatedEntity, "PhieugiaohangD", resetFKFields, new int[] { (int)PhieugiaohangDFieldIndex.Sophieu } );		
			_phieugiaohangH = null;
		}

		/// <summary> setups the sync logic for member _phieugiaohangH</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPhieugiaohangH(IEntity2 relatedEntity)
		{
			if(_phieugiaohangH!=relatedEntity)
			{
				DesetupSyncPhieugiaohangH(true, true);
				_phieugiaohangH = (PhieugiaohangHEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _phieugiaohangH, new PropertyChangedEventHandler( OnPhieugiaohangHPropertyChanged ), "PhieugiaohangH", PhieugiaohangDEntity.Relations.PhieugiaohangHEntityUsingSophieu, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPhieugiaohangHPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this PhieugiaohangDEntity</param>
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
		public  static PhieugiaohangDRelations Relations
		{
			get	{ return new PhieugiaohangDRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}



		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PhieugiaohangH' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPhieugiaohangH
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(PhieugiaohangHEntityFactory))),
					(IEntityRelation)GetRelationsForField("PhieugiaohangH")[0], (int)GD.BBPH.DAL.EntityType.PhieugiaohangDEntity, (int)GD.BBPH.DAL.EntityType.PhieugiaohangHEntity, 0, null, null, null, null, "PhieugiaohangH", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return PhieugiaohangDEntity.CustomProperties;}
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
			get { return PhieugiaohangDEntity.FieldsCustomProperties;}
		}

		/// <summary> The Id property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 Id
		{
			get { return (System.Int64)GetValue((int)PhieugiaohangDFieldIndex.Id, true); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.Id, value); }
		}

		/// <summary> The Sophieu property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Sophieu"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Sophieu
		{
			get { return (System.String)GetValue((int)PhieugiaohangDFieldIndex.Sophieu, true); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.Sophieu, value); }
		}

		/// <summary> The Ngaygiao property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Ngaygiao"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaygiao
		{
			get { return (Nullable<System.DateTime>)GetValue((int)PhieugiaohangDFieldIndex.Ngaygiao, false); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.Ngaygiao, value); }
		}

		/// <summary> The Madon property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Madon"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Madon
		{
			get { return (System.String)GetValue((int)PhieugiaohangDFieldIndex.Madon, true); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.Madon, value); }
		}

		/// <summary> The DonchitietId property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Donchitiet_Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int64> DonchitietId
		{
			get { return (Nullable<System.Int64>)GetValue((int)PhieugiaohangDFieldIndex.DonchitietId, false); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.DonchitietId, value); }
		}

		/// <summary> The Ngaydat property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Ngaydat"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaydat
		{
			get { return (Nullable<System.DateTime>)GetValue((int)PhieugiaohangDFieldIndex.Ngaydat, false); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.Ngaydat, value); }
		}

		/// <summary> The Makhach property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Makhach"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Makhach
		{
			get { return (System.String)GetValue((int)PhieugiaohangDFieldIndex.Makhach, true); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.Makhach, value); }
		}

		/// <summary> The Tenkhach property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Tenkhach"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tenkhach
		{
			get { return (System.String)GetValue((int)PhieugiaohangDFieldIndex.Tenkhach, true); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.Tenkhach, value); }
		}

		/// <summary> The Loaihang property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Loaihang"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Loaihang
		{
			get { return (System.String)GetValue((int)PhieugiaohangDFieldIndex.Loaihang, true); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.Loaihang, value); }
		}

		/// <summary> The Masp property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Masp"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Masp
		{
			get { return (System.String)GetValue((int)PhieugiaohangDFieldIndex.Masp, true); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.Masp, value); }
		}

		/// <summary> The Tenhang property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Tenhang"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tenhang
		{
			get { return (System.String)GetValue((int)PhieugiaohangDFieldIndex.Tenhang, true); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.Tenhang, value); }
		}

		/// <summary> The Soluong property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Soluong"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Soluong
		{
			get { return (Nullable<System.Decimal>)GetValue((int)PhieugiaohangDFieldIndex.Soluong, false); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.Soluong, value); }
		}

		/// <summary> The Dongia property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Dongia"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Dongia
		{
			get { return (Nullable<System.Decimal>)GetValue((int)PhieugiaohangDFieldIndex.Dongia, false); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.Dongia, value); }
		}

		/// <summary> The Thanhtien property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Thanhtien"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Thanhtien
		{
			get { return (Nullable<System.Decimal>)GetValue((int)PhieugiaohangDFieldIndex.Thanhtien, false); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.Thanhtien, value); }
		}

		/// <summary> The Ghichu property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Ghichu"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Ghichu
		{
			get { return (System.String)GetValue((int)PhieugiaohangDFieldIndex.Ghichu, true); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.Ghichu, value); }
		}

		/// <summary> The Ngaytao property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Ngaytao"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaytao
		{
			get { return (Nullable<System.DateTime>)GetValue((int)PhieugiaohangDFieldIndex.Ngaytao, false); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.Ngaytao, value); }
		}

		/// <summary> The Nguoitao property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Nguoitao"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoitao
		{
			get { return (System.String)GetValue((int)PhieugiaohangDFieldIndex.Nguoitao, true); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.Nguoitao, value); }
		}

		/// <summary> The Ngaysua property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Ngaysua"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaysua
		{
			get { return (Nullable<System.DateTime>)GetValue((int)PhieugiaohangDFieldIndex.Ngaysua, false); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.Ngaysua, value); }
		}

		/// <summary> The Nguoisua property of the Entity PhieugiaohangD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "phieugiaohang_d"."Nguoisua"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoisua
		{
			get { return (System.String)GetValue((int)PhieugiaohangDFieldIndex.Nguoisua, true); }
			set	{ SetValue((int)PhieugiaohangDFieldIndex.Nguoisua, value); }
		}



		/// <summary> Gets / sets related entity of type 'PhieugiaohangHEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual PhieugiaohangHEntity PhieugiaohangH
		{
			get
			{
				return _phieugiaohangH;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncPhieugiaohangH(value);
				}
				else
				{
					if(value==null)
					{
						if(_phieugiaohangH != null)
						{
							_phieugiaohangH.UnsetRelatedEntity(this, "PhieugiaohangD");
						}
					}
					else
					{
						if(_phieugiaohangH!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "PhieugiaohangD");
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
			get { return (int)GD.BBPH.DAL.EntityType.PhieugiaohangDEntity; }
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
