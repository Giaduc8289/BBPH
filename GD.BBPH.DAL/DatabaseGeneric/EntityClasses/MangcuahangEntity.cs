///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Monday, November 7, 2022 12:40:33 AM
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
	/// Entity class which represents the entity 'Mangcuahang'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class MangcuahangEntity : CommonEntityBase, ISerializable
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
		static MangcuahangEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public MangcuahangEntity():base("MangcuahangEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public MangcuahangEntity(IEntityFields2 fields):base("MangcuahangEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this MangcuahangEntity</param>
		public MangcuahangEntity(IValidator validator):base("MangcuahangEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Mangcuahang which data should be fetched into this Mangcuahang object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MangcuahangEntity(System.Int64 id):base("MangcuahangEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Mangcuahang which data should be fetched into this Mangcuahang object</param>
		/// <param name="validator">The custom validator object for this MangcuahangEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MangcuahangEntity(System.Int64 id, IValidator validator):base("MangcuahangEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected MangcuahangEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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
			switch((MangcuahangFieldIndex)fieldIndex)
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
			return MangcuahangEntity.GetRelationsForField(fieldName);
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
		public bool TestOriginalFieldValueForNull(MangcuahangFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(MangcuahangFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new MangcuahangRelations().GetAllRelations();
		}
		




	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(GD.BBPH.DAL.EntityType.MangcuahangEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(MangcuahangEntityFactory));
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

			_fieldsCustomProperties.Add("Masp", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tensp", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Mangin", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Mamang", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenmang", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Maloaikeo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenloaikeo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Maloaidongran", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenloaidongran", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Dinhmuckeokho", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Dinhmucdongrankho", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tylekeokho", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tyledongrankho", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tylekeo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tyledongran", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Dinhmuckeouot", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Dinhmucdongranuot", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Dinhmucdungmoi", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaytao", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nguoitao", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaysua", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nguoisua", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Doday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Maloaimang", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenloaimang", fieldHashtable);
		}
		#endregion



		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this MangcuahangEntity</param>
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
		public  static MangcuahangRelations Relations
		{
			get	{ return new MangcuahangRelations(); }
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
			get { return MangcuahangEntity.CustomProperties;}
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
			get { return MangcuahangEntity.FieldsCustomProperties;}
		}

		/// <summary> The Id property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 Id
		{
			get { return (System.Int64)GetValue((int)MangcuahangFieldIndex.Id, true); }
			set	{ SetValue((int)MangcuahangFieldIndex.Id, value); }
		}

		/// <summary> The Masp property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Masp"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Masp
		{
			get { return (System.String)GetValue((int)MangcuahangFieldIndex.Masp, true); }
			set	{ SetValue((int)MangcuahangFieldIndex.Masp, value); }
		}

		/// <summary> The Tensp property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Tensp"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tensp
		{
			get { return (System.String)GetValue((int)MangcuahangFieldIndex.Tensp, true); }
			set	{ SetValue((int)MangcuahangFieldIndex.Tensp, value); }
		}

		/// <summary> The Mangin property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Mangin"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Mangin
		{
			get { return (Nullable<System.Boolean>)GetValue((int)MangcuahangFieldIndex.Mangin, false); }
			set	{ SetValue((int)MangcuahangFieldIndex.Mangin, value); }
		}

		/// <summary> The Mamang property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Mamang"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Mamang
		{
			get { return (System.String)GetValue((int)MangcuahangFieldIndex.Mamang, true); }
			set	{ SetValue((int)MangcuahangFieldIndex.Mamang, value); }
		}

		/// <summary> The Tenmang property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Tenmang"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tenmang
		{
			get { return (System.String)GetValue((int)MangcuahangFieldIndex.Tenmang, true); }
			set	{ SetValue((int)MangcuahangFieldIndex.Tenmang, value); }
		}

		/// <summary> The Maloaikeo property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Maloaikeo"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Maloaikeo
		{
			get { return (System.String)GetValue((int)MangcuahangFieldIndex.Maloaikeo, true); }
			set	{ SetValue((int)MangcuahangFieldIndex.Maloaikeo, value); }
		}

		/// <summary> The Tenloaikeo property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Tenloaikeo"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tenloaikeo
		{
			get { return (System.String)GetValue((int)MangcuahangFieldIndex.Tenloaikeo, true); }
			set	{ SetValue((int)MangcuahangFieldIndex.Tenloaikeo, value); }
		}

		/// <summary> The Maloaidongran property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Maloaidongran"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Maloaidongran
		{
			get { return (System.String)GetValue((int)MangcuahangFieldIndex.Maloaidongran, true); }
			set	{ SetValue((int)MangcuahangFieldIndex.Maloaidongran, value); }
		}

		/// <summary> The Tenloaidongran property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Tenloaidongran"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tenloaidongran
		{
			get { return (System.String)GetValue((int)MangcuahangFieldIndex.Tenloaidongran, true); }
			set	{ SetValue((int)MangcuahangFieldIndex.Tenloaidongran, value); }
		}

		/// <summary> The Dinhmuckeokho property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Dinhmuckeokho"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Dinhmuckeokho
		{
			get { return (Nullable<System.Decimal>)GetValue((int)MangcuahangFieldIndex.Dinhmuckeokho, false); }
			set	{ SetValue((int)MangcuahangFieldIndex.Dinhmuckeokho, value); }
		}

		/// <summary> The Dinhmucdongrankho property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Dinhmucdongrankho"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Dinhmucdongrankho
		{
			get { return (Nullable<System.Decimal>)GetValue((int)MangcuahangFieldIndex.Dinhmucdongrankho, false); }
			set	{ SetValue((int)MangcuahangFieldIndex.Dinhmucdongrankho, value); }
		}

		/// <summary> The Tylekeokho property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Tylekeokho"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Tylekeokho
		{
			get { return (Nullable<System.Decimal>)GetValue((int)MangcuahangFieldIndex.Tylekeokho, false); }
			set	{ SetValue((int)MangcuahangFieldIndex.Tylekeokho, value); }
		}

		/// <summary> The Tyledongrankho property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Tyledongrankho"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Tyledongrankho
		{
			get { return (Nullable<System.Decimal>)GetValue((int)MangcuahangFieldIndex.Tyledongrankho, false); }
			set	{ SetValue((int)MangcuahangFieldIndex.Tyledongrankho, value); }
		}

		/// <summary> The Tylekeo property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Tylekeo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Tylekeo
		{
			get { return (Nullable<System.Decimal>)GetValue((int)MangcuahangFieldIndex.Tylekeo, false); }
			set	{ SetValue((int)MangcuahangFieldIndex.Tylekeo, value); }
		}

		/// <summary> The Tyledongran property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Tyledongran"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Tyledongran
		{
			get { return (Nullable<System.Decimal>)GetValue((int)MangcuahangFieldIndex.Tyledongran, false); }
			set	{ SetValue((int)MangcuahangFieldIndex.Tyledongran, value); }
		}

		/// <summary> The Dinhmuckeouot property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Dinhmuckeouot"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Dinhmuckeouot
		{
			get { return (Nullable<System.Decimal>)GetValue((int)MangcuahangFieldIndex.Dinhmuckeouot, false); }
			set	{ SetValue((int)MangcuahangFieldIndex.Dinhmuckeouot, value); }
		}

		/// <summary> The Dinhmucdongranuot property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Dinhmucdongranuot"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Dinhmucdongranuot
		{
			get { return (Nullable<System.Decimal>)GetValue((int)MangcuahangFieldIndex.Dinhmucdongranuot, false); }
			set	{ SetValue((int)MangcuahangFieldIndex.Dinhmucdongranuot, value); }
		}

		/// <summary> The Dinhmucdungmoi property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Dinhmucdungmoi"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Dinhmucdungmoi
		{
			get { return (Nullable<System.Decimal>)GetValue((int)MangcuahangFieldIndex.Dinhmucdungmoi, false); }
			set	{ SetValue((int)MangcuahangFieldIndex.Dinhmucdungmoi, value); }
		}

		/// <summary> The Ngaytao property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Ngaytao"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaytao
		{
			get { return (Nullable<System.DateTime>)GetValue((int)MangcuahangFieldIndex.Ngaytao, false); }
			set	{ SetValue((int)MangcuahangFieldIndex.Ngaytao, value); }
		}

		/// <summary> The Nguoitao property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Nguoitao"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoitao
		{
			get { return (System.String)GetValue((int)MangcuahangFieldIndex.Nguoitao, true); }
			set	{ SetValue((int)MangcuahangFieldIndex.Nguoitao, value); }
		}

		/// <summary> The Ngaysua property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Ngaysua"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaysua
		{
			get { return (Nullable<System.DateTime>)GetValue((int)MangcuahangFieldIndex.Ngaysua, false); }
			set	{ SetValue((int)MangcuahangFieldIndex.Ngaysua, value); }
		}

		/// <summary> The Nguoisua property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Nguoisua"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoisua
		{
			get { return (System.String)GetValue((int)MangcuahangFieldIndex.Nguoisua, true); }
			set	{ SetValue((int)MangcuahangFieldIndex.Nguoisua, value); }
		}

		/// <summary> The Doday property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Doday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Doday
		{
			get { return (Nullable<System.Decimal>)GetValue((int)MangcuahangFieldIndex.Doday, false); }
			set	{ SetValue((int)MangcuahangFieldIndex.Doday, value); }
		}

		/// <summary> The Maloaimang property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Maloaimang"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Maloaimang
		{
			get { return (System.String)GetValue((int)MangcuahangFieldIndex.Maloaimang, true); }
			set	{ SetValue((int)MangcuahangFieldIndex.Maloaimang, value); }
		}

		/// <summary> The Tenloaimang property of the Entity Mangcuahang<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "mangcuahang"."Tenloaimang"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tenloaimang
		{
			get { return (System.String)GetValue((int)MangcuahangFieldIndex.Tenloaimang, true); }
			set	{ SetValue((int)MangcuahangFieldIndex.Tenloaimang, value); }
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
			get { return (int)GD.BBPH.DAL.EntityType.MangcuahangEntity; }
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
