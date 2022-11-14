﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Monday, November 14, 2022 2:47:55 PM
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
	/// Entity class which represents the entity 'Ketquahoanthien'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class KetquahoanthienEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations


		private DmmayEntity _dmmay;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name Dmmay</summary>
			public static readonly string Dmmay = "Dmmay";



		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static KetquahoanthienEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public KetquahoanthienEntity():base("KetquahoanthienEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public KetquahoanthienEntity(IEntityFields2 fields):base("KetquahoanthienEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this KetquahoanthienEntity</param>
		public KetquahoanthienEntity(IValidator validator):base("KetquahoanthienEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Ketquahoanthien which data should be fetched into this Ketquahoanthien object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public KetquahoanthienEntity(System.Int64 id):base("KetquahoanthienEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Ketquahoanthien which data should be fetched into this Ketquahoanthien object</param>
		/// <param name="validator">The custom validator object for this KetquahoanthienEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public KetquahoanthienEntity(System.Int64 id, IValidator validator):base("KetquahoanthienEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected KetquahoanthienEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{


				_dmmay = (DmmayEntity)info.GetValue("_dmmay", typeof(DmmayEntity));
				if(_dmmay!=null)
				{
					_dmmay.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((KetquahoanthienFieldIndex)fieldIndex)
			{
				case KetquahoanthienFieldIndex.Mamay:
					DesetupSyncDmmay(true, false);
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
				case "Dmmay":
					this.Dmmay = (DmmayEntity)entity;
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
			return KetquahoanthienEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Dmmay":
					toReturn.Add(KetquahoanthienEntity.Relations.DmmayEntityUsingMamay);
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
				case "Dmmay":
					SetupSyncDmmay(relatedEntity);
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
				case "Dmmay":
					DesetupSyncDmmay(false, true);
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
			if(_dmmay!=null)
			{
				toReturn.Add(_dmmay);
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


				info.AddValue("_dmmay", (!this.MarkedForDeletion?_dmmay:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(KetquahoanthienFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(KetquahoanthienFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new KetquahoanthienRelations().GetAllRelations();
		}
		



		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Dmmay' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDmmay()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DmmayFields.Mamay, null, ComparisonOperator.Equal, this.Mamay));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(GD.BBPH.DAL.EntityType.KetquahoanthienEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(KetquahoanthienEntityFactory));
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
			toReturn.Add("Dmmay", _dmmay);



			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_dmmay!=null)
			{
				_dmmay.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{



			_dmmay = null;

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

			_fieldsCustomProperties.Add("Ngay", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ca", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Mamay", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenmay", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Lenhhoanthien", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Masanpham", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tensanpham", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Macongnhan", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tencongnhan", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Daurachiaghep", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Dauvaomet", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Dauvaokg", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thoigianbatdau", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thoigianketthuc", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thoigianchuanbi", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thoigianlenhacuon", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thoigiancatdau", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thoigiansuco", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ketquatui", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Phein", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Pheghep", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Phechia", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Phebien", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Phethoi", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Phechinhmay", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Phekhac", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Kiemtra", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Chatluongtui", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nangsuat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaytao", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nguoitao", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaysua", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nguoisua", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Matruongca", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tentruongca", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tocdodinhmuc", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _dmmay</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncDmmay(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _dmmay, new PropertyChangedEventHandler( OnDmmayPropertyChanged ), "Dmmay", KetquahoanthienEntity.Relations.DmmayEntityUsingMamay, true, signalRelatedEntity, "Ketquahoanthien", resetFKFields, new int[] { (int)KetquahoanthienFieldIndex.Mamay } );		
			_dmmay = null;
		}

		/// <summary> setups the sync logic for member _dmmay</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncDmmay(IEntity2 relatedEntity)
		{
			if(_dmmay!=relatedEntity)
			{
				DesetupSyncDmmay(true, true);
				_dmmay = (DmmayEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _dmmay, new PropertyChangedEventHandler( OnDmmayPropertyChanged ), "Dmmay", KetquahoanthienEntity.Relations.DmmayEntityUsingMamay, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnDmmayPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this KetquahoanthienEntity</param>
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
		public  static KetquahoanthienRelations Relations
		{
			get	{ return new KetquahoanthienRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}



		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Dmmay' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDmmay
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(DmmayEntityFactory))),
					(IEntityRelation)GetRelationsForField("Dmmay")[0], (int)GD.BBPH.DAL.EntityType.KetquahoanthienEntity, (int)GD.BBPH.DAL.EntityType.DmmayEntity, 0, null, null, null, null, "Dmmay", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return KetquahoanthienEntity.CustomProperties;}
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
			get { return KetquahoanthienEntity.FieldsCustomProperties;}
		}

		/// <summary> The Id property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 Id
		{
			get { return (System.Int64)GetValue((int)KetquahoanthienFieldIndex.Id, true); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Id, value); }
		}

		/// <summary> The Ngay property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Ngay"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngay
		{
			get { return (Nullable<System.DateTime>)GetValue((int)KetquahoanthienFieldIndex.Ngay, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Ngay, value); }
		}

		/// <summary> The Ca property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Ca"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Ca
		{
			get { return (Nullable<System.Int32>)GetValue((int)KetquahoanthienFieldIndex.Ca, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Ca, value); }
		}

		/// <summary> The Mamay property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Mamay"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Mamay
		{
			get { return (System.String)GetValue((int)KetquahoanthienFieldIndex.Mamay, true); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Mamay, value); }
		}

		/// <summary> The Tenmay property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Tenmay"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tenmay
		{
			get { return (System.String)GetValue((int)KetquahoanthienFieldIndex.Tenmay, true); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Tenmay, value); }
		}

		/// <summary> The Lenhhoanthien property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Lenhhoanthien"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Lenhhoanthien
		{
			get { return (System.String)GetValue((int)KetquahoanthienFieldIndex.Lenhhoanthien, true); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Lenhhoanthien, value); }
		}

		/// <summary> The Masanpham property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Masanpham"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Masanpham
		{
			get { return (System.String)GetValue((int)KetquahoanthienFieldIndex.Masanpham, true); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Masanpham, value); }
		}

		/// <summary> The Tensanpham property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Tensanpham"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tensanpham
		{
			get { return (System.String)GetValue((int)KetquahoanthienFieldIndex.Tensanpham, true); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Tensanpham, value); }
		}

		/// <summary> The Macongnhan property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Macongnhan"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Macongnhan
		{
			get { return (System.String)GetValue((int)KetquahoanthienFieldIndex.Macongnhan, true); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Macongnhan, value); }
		}

		/// <summary> The Tencongnhan property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Tencongnhan"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tencongnhan
		{
			get { return (System.String)GetValue((int)KetquahoanthienFieldIndex.Tencongnhan, true); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Tencongnhan, value); }
		}

		/// <summary> The Daurachiaghep property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Daurachiaghep"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Daurachiaghep
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Daurachiaghep, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Daurachiaghep, value); }
		}

		/// <summary> The Dauvaomet property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Dauvaomet"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Dauvaomet
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Dauvaomet, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Dauvaomet, value); }
		}

		/// <summary> The Dauvaokg property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Dauvaokg"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Dauvaokg
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Dauvaokg, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Dauvaokg, value); }
		}

		/// <summary> The Thoigianbatdau property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Thoigianbatdau"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Thoigianbatdau
		{
			get { return (Nullable<System.DateTime>)GetValue((int)KetquahoanthienFieldIndex.Thoigianbatdau, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Thoigianbatdau, value); }
		}

		/// <summary> The Thoigianketthuc property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Thoigianketthuc"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Thoigianketthuc
		{
			get { return (Nullable<System.DateTime>)GetValue((int)KetquahoanthienFieldIndex.Thoigianketthuc, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Thoigianketthuc, value); }
		}

		/// <summary> The Thoigianchuanbi property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Thoigianchuanbi"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Thoigianchuanbi
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Thoigianchuanbi, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Thoigianchuanbi, value); }
		}

		/// <summary> The Thoigianlenhacuon property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Thoigianlenhacuon"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Thoigianlenhacuon
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Thoigianlenhacuon, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Thoigianlenhacuon, value); }
		}

		/// <summary> The Thoigiancatdau property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Thoigiancatdau"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Thoigiancatdau
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Thoigiancatdau, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Thoigiancatdau, value); }
		}

		/// <summary> The Thoigiansuco property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Thoigiansuco"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Thoigiansuco
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Thoigiansuco, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Thoigiansuco, value); }
		}

		/// <summary> The Ketquatui property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Ketquatui"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Ketquatui
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Ketquatui, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Ketquatui, value); }
		}

		/// <summary> The Phein property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Phein"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Phein
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Phein, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Phein, value); }
		}

		/// <summary> The Pheghep property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Pheghep"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Pheghep
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Pheghep, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Pheghep, value); }
		}

		/// <summary> The Phechia property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Phechia"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Phechia
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Phechia, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Phechia, value); }
		}

		/// <summary> The Phebien property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Phebien"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Phebien
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Phebien, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Phebien, value); }
		}

		/// <summary> The Phethoi property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Phethoi"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Phethoi
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Phethoi, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Phethoi, value); }
		}

		/// <summary> The Phechinhmay property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Phechinhmay"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Phechinhmay
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Phechinhmay, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Phechinhmay, value); }
		}

		/// <summary> The Phekhac property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Phekhac"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Phekhac
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Phekhac, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Phekhac, value); }
		}

		/// <summary> The Kiemtra property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Kiemtra"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Kiemtra
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Kiemtra, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Kiemtra, value); }
		}

		/// <summary> The Chatluongtui property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Chatluongtui"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Chatluongtui
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Chatluongtui, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Chatluongtui, value); }
		}

		/// <summary> The Nangsuat property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Nangsuat"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Nangsuat
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Nangsuat, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Nangsuat, value); }
		}

		/// <summary> The Ngaytao property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Ngaytao"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaytao
		{
			get { return (Nullable<System.DateTime>)GetValue((int)KetquahoanthienFieldIndex.Ngaytao, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Ngaytao, value); }
		}

		/// <summary> The Nguoitao property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Nguoitao"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoitao
		{
			get { return (System.String)GetValue((int)KetquahoanthienFieldIndex.Nguoitao, true); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Nguoitao, value); }
		}

		/// <summary> The Ngaysua property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Ngaysua"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaysua
		{
			get { return (Nullable<System.DateTime>)GetValue((int)KetquahoanthienFieldIndex.Ngaysua, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Ngaysua, value); }
		}

		/// <summary> The Nguoisua property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Nguoisua"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoisua
		{
			get { return (System.String)GetValue((int)KetquahoanthienFieldIndex.Nguoisua, true); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Nguoisua, value); }
		}

		/// <summary> The Matruongca property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Matruongca"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Matruongca
		{
			get { return (System.String)GetValue((int)KetquahoanthienFieldIndex.Matruongca, true); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Matruongca, value); }
		}

		/// <summary> The Tentruongca property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Tentruongca"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tentruongca
		{
			get { return (System.String)GetValue((int)KetquahoanthienFieldIndex.Tentruongca, true); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Tentruongca, value); }
		}

		/// <summary> The Tocdodinhmuc property of the Entity Ketquahoanthien<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquahoanthien"."Tocdodinhmuc"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Tocdodinhmuc
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquahoanthienFieldIndex.Tocdodinhmuc, false); }
			set	{ SetValue((int)KetquahoanthienFieldIndex.Tocdodinhmuc, value); }
		}



		/// <summary> Gets / sets related entity of type 'DmmayEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual DmmayEntity Dmmay
		{
			get
			{
				return _dmmay;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncDmmay(value);
				}
				else
				{
					if(value==null)
					{
						if(_dmmay != null)
						{
							_dmmay.UnsetRelatedEntity(this, "Ketquahoanthien");
						}
					}
					else
					{
						if(_dmmay!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "Ketquahoanthien");
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
			get { return (int)GD.BBPH.DAL.EntityType.KetquahoanthienEntity; }
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
