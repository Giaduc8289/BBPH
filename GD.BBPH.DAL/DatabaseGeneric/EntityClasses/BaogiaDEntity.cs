﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Tuesday, November 15, 2022 9:35:07 AM
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
	/// Entity class which represents the entity 'BaogiaD'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class BaogiaDEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations


		private BaogiaHEntity _baogiaH;

		
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



		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static BaogiaDEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public BaogiaDEntity():base("BaogiaDEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public BaogiaDEntity(IEntityFields2 fields):base("BaogiaDEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this BaogiaDEntity</param>
		public BaogiaDEntity(IValidator validator):base("BaogiaDEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="id">PK value for BaogiaD which data should be fetched into this BaogiaD object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public BaogiaDEntity(System.Int64 id):base("BaogiaDEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for BaogiaD which data should be fetched into this BaogiaD object</param>
		/// <param name="validator">The custom validator object for this BaogiaDEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public BaogiaDEntity(System.Int64 id, IValidator validator):base("BaogiaDEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected BaogiaDEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{


				_baogiaH = (BaogiaHEntity)info.GetValue("_baogiaH", typeof(BaogiaHEntity));
				if(_baogiaH!=null)
				{
					_baogiaH.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((BaogiaDFieldIndex)fieldIndex)
			{
				case BaogiaDFieldIndex.Sobaogia:
					DesetupSyncBaogiaH(true, false);
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
				case "BaogiaH":
					this.BaogiaH = (BaogiaHEntity)entity;
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
			return BaogiaDEntity.GetRelationsForField(fieldName);
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
					toReturn.Add(BaogiaDEntity.Relations.BaogiaHEntityUsingSobaogia);
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
					SetupSyncBaogiaH(relatedEntity);
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
					DesetupSyncBaogiaH(false, true);
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
			if(_baogiaH!=null)
			{
				toReturn.Add(_baogiaH);
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


				info.AddValue("_baogiaH", (!this.MarkedForDeletion?_baogiaH:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(BaogiaDFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(BaogiaDFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new BaogiaDRelations().GetAllRelations();
		}
		



		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'BaogiaH' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBaogiaH()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BaogiaHFields.Sobaogia, null, ComparisonOperator.Equal, this.Sobaogia));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(GD.BBPH.DAL.EntityType.BaogiaDEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(BaogiaDEntityFactory));
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
			toReturn.Add("BaogiaH", _baogiaH);



			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_baogiaH!=null)
			{
				_baogiaH.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{



			_baogiaH = null;

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

			_fieldsCustomProperties.Add("Sobaogia", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Masp", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tensp", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Maspcuakhach", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Doday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Rong", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Dai", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Trongluong", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Loaimuc", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenqcdonggoi", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenqcloaithung", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenqcthanhpham", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Mota", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DongiakhongVat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DongiaVat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaytao", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nguoitao", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaysua", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nguoisua", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Cautruc", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _baogiaH</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncBaogiaH(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _baogiaH, new PropertyChangedEventHandler( OnBaogiaHPropertyChanged ), "BaogiaH", BaogiaDEntity.Relations.BaogiaHEntityUsingSobaogia, true, signalRelatedEntity, "BaogiaD", resetFKFields, new int[] { (int)BaogiaDFieldIndex.Sobaogia } );		
			_baogiaH = null;
		}

		/// <summary> setups the sync logic for member _baogiaH</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncBaogiaH(IEntity2 relatedEntity)
		{
			if(_baogiaH!=relatedEntity)
			{
				DesetupSyncBaogiaH(true, true);
				_baogiaH = (BaogiaHEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _baogiaH, new PropertyChangedEventHandler( OnBaogiaHPropertyChanged ), "BaogiaH", BaogiaDEntity.Relations.BaogiaHEntityUsingSobaogia, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnBaogiaHPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this BaogiaDEntity</param>
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
		public  static BaogiaDRelations Relations
		{
			get	{ return new BaogiaDRelations(); }
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
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(BaogiaHEntityFactory))),
					(IEntityRelation)GetRelationsForField("BaogiaH")[0], (int)GD.BBPH.DAL.EntityType.BaogiaDEntity, (int)GD.BBPH.DAL.EntityType.BaogiaHEntity, 0, null, null, null, null, "BaogiaH", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return BaogiaDEntity.CustomProperties;}
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
			get { return BaogiaDEntity.FieldsCustomProperties;}
		}

		/// <summary> The Id property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 Id
		{
			get { return (System.Int64)GetValue((int)BaogiaDFieldIndex.Id, true); }
			set	{ SetValue((int)BaogiaDFieldIndex.Id, value); }
		}

		/// <summary> The Sobaogia property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Sobaogia"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Sobaogia
		{
			get { return (System.String)GetValue((int)BaogiaDFieldIndex.Sobaogia, true); }
			set	{ SetValue((int)BaogiaDFieldIndex.Sobaogia, value); }
		}

		/// <summary> The Masp property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Masp"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Masp
		{
			get { return (System.String)GetValue((int)BaogiaDFieldIndex.Masp, true); }
			set	{ SetValue((int)BaogiaDFieldIndex.Masp, value); }
		}

		/// <summary> The Tensp property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Tensp"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tensp
		{
			get { return (System.String)GetValue((int)BaogiaDFieldIndex.Tensp, true); }
			set	{ SetValue((int)BaogiaDFieldIndex.Tensp, value); }
		}

		/// <summary> The Maspcuakhach property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Maspcuakhach"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Maspcuakhach
		{
			get { return (System.String)GetValue((int)BaogiaDFieldIndex.Maspcuakhach, true); }
			set	{ SetValue((int)BaogiaDFieldIndex.Maspcuakhach, value); }
		}

		/// <summary> The Doday property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Doday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Doday
		{
			get { return (Nullable<System.Decimal>)GetValue((int)BaogiaDFieldIndex.Doday, false); }
			set	{ SetValue((int)BaogiaDFieldIndex.Doday, value); }
		}

		/// <summary> The Rong property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Rong"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Rong
		{
			get { return (Nullable<System.Decimal>)GetValue((int)BaogiaDFieldIndex.Rong, false); }
			set	{ SetValue((int)BaogiaDFieldIndex.Rong, value); }
		}

		/// <summary> The Dai property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Dai"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Dai
		{
			get { return (Nullable<System.Decimal>)GetValue((int)BaogiaDFieldIndex.Dai, false); }
			set	{ SetValue((int)BaogiaDFieldIndex.Dai, value); }
		}

		/// <summary> The Trongluong property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Trongluong"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Trongluong
		{
			get { return (Nullable<System.Decimal>)GetValue((int)BaogiaDFieldIndex.Trongluong, false); }
			set	{ SetValue((int)BaogiaDFieldIndex.Trongluong, value); }
		}

		/// <summary> The Loaimuc property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Loaimuc"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Loaimuc
		{
			get { return (System.String)GetValue((int)BaogiaDFieldIndex.Loaimuc, true); }
			set	{ SetValue((int)BaogiaDFieldIndex.Loaimuc, value); }
		}

		/// <summary> The Tenqcdonggoi property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Tenqcdonggoi"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tenqcdonggoi
		{
			get { return (System.String)GetValue((int)BaogiaDFieldIndex.Tenqcdonggoi, true); }
			set	{ SetValue((int)BaogiaDFieldIndex.Tenqcdonggoi, value); }
		}

		/// <summary> The Tenqcloaithung property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Tenqcloaithung"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tenqcloaithung
		{
			get { return (System.String)GetValue((int)BaogiaDFieldIndex.Tenqcloaithung, true); }
			set	{ SetValue((int)BaogiaDFieldIndex.Tenqcloaithung, value); }
		}

		/// <summary> The Tenqcthanhpham property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Tenqcthanhpham"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tenqcthanhpham
		{
			get { return (System.String)GetValue((int)BaogiaDFieldIndex.Tenqcthanhpham, true); }
			set	{ SetValue((int)BaogiaDFieldIndex.Tenqcthanhpham, value); }
		}

		/// <summary> The Mota property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Mota"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Mota
		{
			get { return (System.String)GetValue((int)BaogiaDFieldIndex.Mota, true); }
			set	{ SetValue((int)BaogiaDFieldIndex.Mota, value); }
		}

		/// <summary> The DongiakhongVat property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."DongiakhongVAT"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> DongiakhongVat
		{
			get { return (Nullable<System.Int32>)GetValue((int)BaogiaDFieldIndex.DongiakhongVat, false); }
			set	{ SetValue((int)BaogiaDFieldIndex.DongiakhongVat, value); }
		}

		/// <summary> The DongiaVat property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."DongiaVAT"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> DongiaVat
		{
			get { return (Nullable<System.Int32>)GetValue((int)BaogiaDFieldIndex.DongiaVat, false); }
			set	{ SetValue((int)BaogiaDFieldIndex.DongiaVat, value); }
		}

		/// <summary> The Ngaytao property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Ngaytao"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaytao
		{
			get { return (Nullable<System.DateTime>)GetValue((int)BaogiaDFieldIndex.Ngaytao, false); }
			set	{ SetValue((int)BaogiaDFieldIndex.Ngaytao, value); }
		}

		/// <summary> The Nguoitao property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Nguoitao"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoitao
		{
			get { return (System.String)GetValue((int)BaogiaDFieldIndex.Nguoitao, true); }
			set	{ SetValue((int)BaogiaDFieldIndex.Nguoitao, value); }
		}

		/// <summary> The Ngaysua property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Ngaysua"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaysua
		{
			get { return (Nullable<System.DateTime>)GetValue((int)BaogiaDFieldIndex.Ngaysua, false); }
			set	{ SetValue((int)BaogiaDFieldIndex.Ngaysua, value); }
		}

		/// <summary> The Nguoisua property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Nguoisua"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoisua
		{
			get { return (System.String)GetValue((int)BaogiaDFieldIndex.Nguoisua, true); }
			set	{ SetValue((int)BaogiaDFieldIndex.Nguoisua, value); }
		}

		/// <summary> The Cautruc property of the Entity BaogiaD<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "baogia_d"."Cautruc"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Cautruc
		{
			get { return (System.String)GetValue((int)BaogiaDFieldIndex.Cautruc, true); }
			set	{ SetValue((int)BaogiaDFieldIndex.Cautruc, value); }
		}



		/// <summary> Gets / sets related entity of type 'BaogiaHEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual BaogiaHEntity BaogiaH
		{
			get
			{
				return _baogiaH;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncBaogiaH(value);
				}
				else
				{
					if(value==null)
					{
						if(_baogiaH != null)
						{
							_baogiaH.UnsetRelatedEntity(this, "BaogiaD");
						}
					}
					else
					{
						if(_baogiaH!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "BaogiaD");
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
			get { return (int)GD.BBPH.DAL.EntityType.BaogiaDEntity; }
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
