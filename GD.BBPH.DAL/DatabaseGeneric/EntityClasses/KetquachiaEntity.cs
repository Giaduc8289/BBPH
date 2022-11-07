///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Monday, November 7, 2022 8:32:42 AM
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
	/// Entity class which represents the entity 'Ketquachia'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class KetquachiaEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations




		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{




		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static KetquachiaEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public KetquachiaEntity():base("KetquachiaEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public KetquachiaEntity(IEntityFields2 fields):base("KetquachiaEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this KetquachiaEntity</param>
		public KetquachiaEntity(IValidator validator):base("KetquachiaEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Ketquachia which data should be fetched into this Ketquachia object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public KetquachiaEntity(System.Int64 id):base("KetquachiaEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Ketquachia which data should be fetched into this Ketquachia object</param>
		/// <param name="validator">The custom validator object for this KetquachiaEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public KetquachiaEntity(System.Int64 id, IValidator validator):base("KetquachiaEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected KetquachiaEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{




				base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((KetquachiaFieldIndex)fieldIndex)
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




				default:
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return KetquachiaEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{




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




			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(KetquachiaFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(KetquachiaFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new KetquachiaRelations().GetAllRelations();
		}
		




	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(GD.BBPH.DAL.EntityType.KetquachiaEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(KetquachiaEntityFactory));
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




			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{




		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{





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

			_fieldsCustomProperties.Add("Lenh", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Masanpham", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Macongnhan", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tensanpham", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenmay", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tencongnhan", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Dauraghep", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Sometvao", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Sokgvao", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thoigianbatdau", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thoigianketthuc", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thoigianlencuon", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thoigianhacuon", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Solanhacuon", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thoigiancatdau", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thoigiandoilenh", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thoigiansuco", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Phein", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Pheghep", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Phechia", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("PhethoiNcc", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Phesx", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaytao", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nguoitao", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaysua", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nguoisua", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nangsuat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tylesaihong", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Socuon", fieldHashtable);
		}
		#endregion



		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this KetquachiaEntity</param>
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
		public  static KetquachiaRelations Relations
		{
			get	{ return new KetquachiaRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}





		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return KetquachiaEntity.CustomProperties;}
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
			get { return KetquachiaEntity.FieldsCustomProperties;}
		}

		/// <summary> The Id property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 Id
		{
			get { return (System.Int64)GetValue((int)KetquachiaFieldIndex.Id, true); }
			set	{ SetValue((int)KetquachiaFieldIndex.Id, value); }
		}

		/// <summary> The Ngay property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Ngay"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngay
		{
			get { return (Nullable<System.DateTime>)GetValue((int)KetquachiaFieldIndex.Ngay, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Ngay, value); }
		}

		/// <summary> The Ca property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Ca"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Ca
		{
			get { return (Nullable<System.Int32>)GetValue((int)KetquachiaFieldIndex.Ca, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Ca, value); }
		}

		/// <summary> The Mamay property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Mamay"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Mamay
		{
			get { return (System.String)GetValue((int)KetquachiaFieldIndex.Mamay, true); }
			set	{ SetValue((int)KetquachiaFieldIndex.Mamay, value); }
		}

		/// <summary> The Lenh property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Lenh"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Lenh
		{
			get { return (System.String)GetValue((int)KetquachiaFieldIndex.Lenh, true); }
			set	{ SetValue((int)KetquachiaFieldIndex.Lenh, value); }
		}

		/// <summary> The Masanpham property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Masanpham"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Masanpham
		{
			get { return (System.String)GetValue((int)KetquachiaFieldIndex.Masanpham, true); }
			set	{ SetValue((int)KetquachiaFieldIndex.Masanpham, value); }
		}

		/// <summary> The Macongnhan property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Macongnhan"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Macongnhan
		{
			get { return (System.String)GetValue((int)KetquachiaFieldIndex.Macongnhan, true); }
			set	{ SetValue((int)KetquachiaFieldIndex.Macongnhan, value); }
		}

		/// <summary> The Tensanpham property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Tensanpham"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tensanpham
		{
			get { return (System.String)GetValue((int)KetquachiaFieldIndex.Tensanpham, true); }
			set	{ SetValue((int)KetquachiaFieldIndex.Tensanpham, value); }
		}

		/// <summary> The Tenmay property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Tenmay"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tenmay
		{
			get { return (System.String)GetValue((int)KetquachiaFieldIndex.Tenmay, true); }
			set	{ SetValue((int)KetquachiaFieldIndex.Tenmay, value); }
		}

		/// <summary> The Tencongnhan property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Tencongnhan"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tencongnhan
		{
			get { return (System.String)GetValue((int)KetquachiaFieldIndex.Tencongnhan, true); }
			set	{ SetValue((int)KetquachiaFieldIndex.Tencongnhan, value); }
		}

		/// <summary> The Dauraghep property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Dauraghep"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Dauraghep
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquachiaFieldIndex.Dauraghep, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Dauraghep, value); }
		}

		/// <summary> The Sometvao property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Sometvao"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Sometvao
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquachiaFieldIndex.Sometvao, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Sometvao, value); }
		}

		/// <summary> The Sokgvao property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Sokgvao"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Sokgvao
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquachiaFieldIndex.Sokgvao, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Sokgvao, value); }
		}

		/// <summary> The Thoigianbatdau property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Thoigianbatdau"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Thoigianbatdau
		{
			get { return (Nullable<System.DateTime>)GetValue((int)KetquachiaFieldIndex.Thoigianbatdau, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Thoigianbatdau, value); }
		}

		/// <summary> The Thoigianketthuc property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Thoigianketthuc"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Thoigianketthuc
		{
			get { return (Nullable<System.DateTime>)GetValue((int)KetquachiaFieldIndex.Thoigianketthuc, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Thoigianketthuc, value); }
		}

		/// <summary> The Thoigianlencuon property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Thoigianlencuon"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Thoigianlencuon
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquachiaFieldIndex.Thoigianlencuon, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Thoigianlencuon, value); }
		}

		/// <summary> The Thoigianhacuon property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Thoigianhacuon"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Thoigianhacuon
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquachiaFieldIndex.Thoigianhacuon, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Thoigianhacuon, value); }
		}

		/// <summary> The Solanhacuon property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Solanhacuon"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Solanhacuon
		{
			get { return (Nullable<System.Int32>)GetValue((int)KetquachiaFieldIndex.Solanhacuon, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Solanhacuon, value); }
		}

		/// <summary> The Thoigiancatdau property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Thoigiancatdau"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Thoigiancatdau
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquachiaFieldIndex.Thoigiancatdau, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Thoigiancatdau, value); }
		}

		/// <summary> The Thoigiandoilenh property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Thoigiandoilenh"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Thoigiandoilenh
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquachiaFieldIndex.Thoigiandoilenh, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Thoigiandoilenh, value); }
		}

		/// <summary> The Thoigiansuco property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Thoigiansuco"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Thoigiansuco
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquachiaFieldIndex.Thoigiansuco, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Thoigiansuco, value); }
		}

		/// <summary> The Phein property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Phein"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Phein
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquachiaFieldIndex.Phein, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Phein, value); }
		}

		/// <summary> The Pheghep property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Pheghep"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Pheghep
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquachiaFieldIndex.Pheghep, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Pheghep, value); }
		}

		/// <summary> The Phechia property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Phechia"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Phechia
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquachiaFieldIndex.Phechia, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Phechia, value); }
		}

		/// <summary> The PhethoiNcc property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."PhethoiNCC"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> PhethoiNcc
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquachiaFieldIndex.PhethoiNcc, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.PhethoiNcc, value); }
		}

		/// <summary> The Phesx property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Phesx"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Phesx
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquachiaFieldIndex.Phesx, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Phesx, value); }
		}

		/// <summary> The Ngaytao property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Ngaytao"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaytao
		{
			get { return (Nullable<System.DateTime>)GetValue((int)KetquachiaFieldIndex.Ngaytao, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Ngaytao, value); }
		}

		/// <summary> The Nguoitao property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Nguoitao"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoitao
		{
			get { return (System.String)GetValue((int)KetquachiaFieldIndex.Nguoitao, true); }
			set	{ SetValue((int)KetquachiaFieldIndex.Nguoitao, value); }
		}

		/// <summary> The Ngaysua property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Ngaysua"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaysua
		{
			get { return (Nullable<System.DateTime>)GetValue((int)KetquachiaFieldIndex.Ngaysua, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Ngaysua, value); }
		}

		/// <summary> The Nguoisua property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Nguoisua"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoisua
		{
			get { return (System.String)GetValue((int)KetquachiaFieldIndex.Nguoisua, true); }
			set	{ SetValue((int)KetquachiaFieldIndex.Nguoisua, value); }
		}

		/// <summary> The Nangsuat property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Nangsuat"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Nangsuat
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquachiaFieldIndex.Nangsuat, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Nangsuat, value); }
		}

		/// <summary> The Tylesaihong property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Tylesaihong"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Tylesaihong
		{
			get { return (Nullable<System.Decimal>)GetValue((int)KetquachiaFieldIndex.Tylesaihong, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Tylesaihong, value); }
		}

		/// <summary> The Socuon property of the Entity Ketquachia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Ketquachia"."Socuon"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Socuon
		{
			get { return (Nullable<System.Int32>)GetValue((int)KetquachiaFieldIndex.Socuon, false); }
			set	{ SetValue((int)KetquachiaFieldIndex.Socuon, value); }
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
			get { return (int)GD.BBPH.DAL.EntityType.KetquachiaEntity; }
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
