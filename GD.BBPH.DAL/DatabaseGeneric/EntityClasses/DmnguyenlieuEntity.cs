///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Tuesday, December 13, 2022 5:49:30 PM
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
	/// Entity class which represents the entity 'Dmnguyenlieu'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class DmnguyenlieuEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations


		private DmnhomnguyenlieuEntity _dmnhomnguyenlieu;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name Dmnhomnguyenlieu</summary>
			public static readonly string Dmnhomnguyenlieu = "Dmnhomnguyenlieu";



		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static DmnguyenlieuEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public DmnguyenlieuEntity():base("DmnguyenlieuEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public DmnguyenlieuEntity(IEntityFields2 fields):base("DmnguyenlieuEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this DmnguyenlieuEntity</param>
		public DmnguyenlieuEntity(IValidator validator):base("DmnguyenlieuEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Dmnguyenlieu which data should be fetched into this Dmnguyenlieu object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DmnguyenlieuEntity(System.Int64 id):base("DmnguyenlieuEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Dmnguyenlieu which data should be fetched into this Dmnguyenlieu object</param>
		/// <param name="validator">The custom validator object for this DmnguyenlieuEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DmnguyenlieuEntity(System.Int64 id, IValidator validator):base("DmnguyenlieuEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected DmnguyenlieuEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{


				_dmnhomnguyenlieu = (DmnhomnguyenlieuEntity)info.GetValue("_dmnhomnguyenlieu", typeof(DmnhomnguyenlieuEntity));
				if(_dmnhomnguyenlieu!=null)
				{
					_dmnhomnguyenlieu.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((DmnguyenlieuFieldIndex)fieldIndex)
			{
				case DmnguyenlieuFieldIndex.Manhom:
					DesetupSyncDmnhomnguyenlieu(true, false);
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
				case "Dmnhomnguyenlieu":
					this.Dmnhomnguyenlieu = (DmnhomnguyenlieuEntity)entity;
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
			return DmnguyenlieuEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Dmnhomnguyenlieu":
					toReturn.Add(DmnguyenlieuEntity.Relations.DmnhomnguyenlieuEntityUsingManhom);
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
				case "Dmnhomnguyenlieu":
					SetupSyncDmnhomnguyenlieu(relatedEntity);
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
				case "Dmnhomnguyenlieu":
					DesetupSyncDmnhomnguyenlieu(false, true);
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
			if(_dmnhomnguyenlieu!=null)
			{
				toReturn.Add(_dmnhomnguyenlieu);
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


				info.AddValue("_dmnhomnguyenlieu", (!this.MarkedForDeletion?_dmnhomnguyenlieu:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(DmnguyenlieuFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(DmnguyenlieuFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new DmnguyenlieuRelations().GetAllRelations();
		}
		



		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Dmnhomnguyenlieu' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDmnhomnguyenlieu()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DmnhomnguyenlieuFields.Manhom, null, ComparisonOperator.Equal, this.Manhom));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(GD.BBPH.DAL.EntityType.DmnguyenlieuEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(DmnguyenlieuEntityFactory));
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
			toReturn.Add("Dmnhomnguyenlieu", _dmnhomnguyenlieu);



			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_dmnhomnguyenlieu!=null)
			{
				_dmnhomnguyenlieu.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{



			_dmnhomnguyenlieu = null;

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

			_fieldsCustomProperties.Add("Manl", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tennl", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenrutgon", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Manhom", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tennhom", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Gia", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngay", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Giahientai", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tang", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Giam", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaytao", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nguoitao", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaysua", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nguoisua", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tonkhotoithieu", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _dmnhomnguyenlieu</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncDmnhomnguyenlieu(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _dmnhomnguyenlieu, new PropertyChangedEventHandler( OnDmnhomnguyenlieuPropertyChanged ), "Dmnhomnguyenlieu", DmnguyenlieuEntity.Relations.DmnhomnguyenlieuEntityUsingManhom, true, signalRelatedEntity, "Dmnguyenlieu", resetFKFields, new int[] { (int)DmnguyenlieuFieldIndex.Manhom } );		
			_dmnhomnguyenlieu = null;
		}

		/// <summary> setups the sync logic for member _dmnhomnguyenlieu</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncDmnhomnguyenlieu(IEntity2 relatedEntity)
		{
			if(_dmnhomnguyenlieu!=relatedEntity)
			{
				DesetupSyncDmnhomnguyenlieu(true, true);
				_dmnhomnguyenlieu = (DmnhomnguyenlieuEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _dmnhomnguyenlieu, new PropertyChangedEventHandler( OnDmnhomnguyenlieuPropertyChanged ), "Dmnhomnguyenlieu", DmnguyenlieuEntity.Relations.DmnhomnguyenlieuEntityUsingManhom, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnDmnhomnguyenlieuPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this DmnguyenlieuEntity</param>
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
		public  static DmnguyenlieuRelations Relations
		{
			get	{ return new DmnguyenlieuRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}



		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Dmnhomnguyenlieu' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDmnhomnguyenlieu
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(DmnhomnguyenlieuEntityFactory))),
					(IEntityRelation)GetRelationsForField("Dmnhomnguyenlieu")[0], (int)GD.BBPH.DAL.EntityType.DmnguyenlieuEntity, (int)GD.BBPH.DAL.EntityType.DmnhomnguyenlieuEntity, 0, null, null, null, null, "Dmnhomnguyenlieu", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return DmnguyenlieuEntity.CustomProperties;}
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
			get { return DmnguyenlieuEntity.FieldsCustomProperties;}
		}

		/// <summary> The Id property of the Entity Dmnguyenlieu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dmnguyenlieu"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 Id
		{
			get { return (System.Int64)GetValue((int)DmnguyenlieuFieldIndex.Id, true); }
			set	{ SetValue((int)DmnguyenlieuFieldIndex.Id, value); }
		}

		/// <summary> The Manl property of the Entity Dmnguyenlieu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dmnguyenlieu"."Manl"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Manl
		{
			get { return (System.String)GetValue((int)DmnguyenlieuFieldIndex.Manl, true); }
			set	{ SetValue((int)DmnguyenlieuFieldIndex.Manl, value); }
		}

		/// <summary> The Tennl property of the Entity Dmnguyenlieu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dmnguyenlieu"."Tennl"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tennl
		{
			get { return (System.String)GetValue((int)DmnguyenlieuFieldIndex.Tennl, true); }
			set	{ SetValue((int)DmnguyenlieuFieldIndex.Tennl, value); }
		}

		/// <summary> The Tenrutgon property of the Entity Dmnguyenlieu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dmnguyenlieu"."Tenrutgon"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tenrutgon
		{
			get { return (System.String)GetValue((int)DmnguyenlieuFieldIndex.Tenrutgon, true); }
			set	{ SetValue((int)DmnguyenlieuFieldIndex.Tenrutgon, value); }
		}

		/// <summary> The Manhom property of the Entity Dmnguyenlieu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dmnguyenlieu"."Manhom"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Manhom
		{
			get { return (System.String)GetValue((int)DmnguyenlieuFieldIndex.Manhom, true); }
			set	{ SetValue((int)DmnguyenlieuFieldIndex.Manhom, value); }
		}

		/// <summary> The Tennhom property of the Entity Dmnguyenlieu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dmnguyenlieu"."Tennhom"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tennhom
		{
			get { return (System.String)GetValue((int)DmnguyenlieuFieldIndex.Tennhom, true); }
			set	{ SetValue((int)DmnguyenlieuFieldIndex.Tennhom, value); }
		}

		/// <summary> The Gia property of the Entity Dmnguyenlieu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dmnguyenlieu"."Gia"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Gia
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DmnguyenlieuFieldIndex.Gia, false); }
			set	{ SetValue((int)DmnguyenlieuFieldIndex.Gia, value); }
		}

		/// <summary> The Ngay property of the Entity Dmnguyenlieu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dmnguyenlieu"."Ngay"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngay
		{
			get { return (Nullable<System.DateTime>)GetValue((int)DmnguyenlieuFieldIndex.Ngay, false); }
			set	{ SetValue((int)DmnguyenlieuFieldIndex.Ngay, value); }
		}

		/// <summary> The Giahientai property of the Entity Dmnguyenlieu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dmnguyenlieu"."Giahientai"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Giahientai
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DmnguyenlieuFieldIndex.Giahientai, false); }
			set	{ SetValue((int)DmnguyenlieuFieldIndex.Giahientai, value); }
		}

		/// <summary> The Tang property of the Entity Dmnguyenlieu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dmnguyenlieu"."Tang"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Tang
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DmnguyenlieuFieldIndex.Tang, false); }
			set	{ SetValue((int)DmnguyenlieuFieldIndex.Tang, value); }
		}

		/// <summary> The Giam property of the Entity Dmnguyenlieu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dmnguyenlieu"."Giam"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Giam
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DmnguyenlieuFieldIndex.Giam, false); }
			set	{ SetValue((int)DmnguyenlieuFieldIndex.Giam, value); }
		}

		/// <summary> The Ngaytao property of the Entity Dmnguyenlieu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dmnguyenlieu"."Ngaytao"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaytao
		{
			get { return (Nullable<System.DateTime>)GetValue((int)DmnguyenlieuFieldIndex.Ngaytao, false); }
			set	{ SetValue((int)DmnguyenlieuFieldIndex.Ngaytao, value); }
		}

		/// <summary> The Nguoitao property of the Entity Dmnguyenlieu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dmnguyenlieu"."Nguoitao"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoitao
		{
			get { return (System.String)GetValue((int)DmnguyenlieuFieldIndex.Nguoitao, true); }
			set	{ SetValue((int)DmnguyenlieuFieldIndex.Nguoitao, value); }
		}

		/// <summary> The Ngaysua property of the Entity Dmnguyenlieu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dmnguyenlieu"."Ngaysua"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaysua
		{
			get { return (Nullable<System.DateTime>)GetValue((int)DmnguyenlieuFieldIndex.Ngaysua, false); }
			set	{ SetValue((int)DmnguyenlieuFieldIndex.Ngaysua, value); }
		}

		/// <summary> The Nguoisua property of the Entity Dmnguyenlieu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dmnguyenlieu"."Nguoisua"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoisua
		{
			get { return (System.String)GetValue((int)DmnguyenlieuFieldIndex.Nguoisua, true); }
			set	{ SetValue((int)DmnguyenlieuFieldIndex.Nguoisua, value); }
		}

		/// <summary> The Tonkhotoithieu property of the Entity Dmnguyenlieu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dmnguyenlieu"."Tonkhotoithieu"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Tonkhotoithieu
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DmnguyenlieuFieldIndex.Tonkhotoithieu, false); }
			set	{ SetValue((int)DmnguyenlieuFieldIndex.Tonkhotoithieu, value); }
		}



		/// <summary> Gets / sets related entity of type 'DmnhomnguyenlieuEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual DmnhomnguyenlieuEntity Dmnhomnguyenlieu
		{
			get
			{
				return _dmnhomnguyenlieu;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncDmnhomnguyenlieu(value);
				}
				else
				{
					if(value==null)
					{
						if(_dmnhomnguyenlieu != null)
						{
							_dmnhomnguyenlieu.UnsetRelatedEntity(this, "Dmnguyenlieu");
						}
					}
					else
					{
						if(_dmnhomnguyenlieu!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "Dmnguyenlieu");
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
			get { return (int)GD.BBPH.DAL.EntityType.DmnguyenlieuEntity; }
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
