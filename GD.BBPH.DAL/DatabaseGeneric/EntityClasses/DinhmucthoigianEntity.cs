﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Sunday, November 6, 2022 4:00:15 PM
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
	/// Entity class which represents the entity 'Dinhmucthoigian'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class DinhmucthoigianEntity : CommonEntityBase, ISerializable
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
		static DinhmucthoigianEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public DinhmucthoigianEntity():base("DinhmucthoigianEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public DinhmucthoigianEntity(IEntityFields2 fields):base("DinhmucthoigianEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this DinhmucthoigianEntity</param>
		public DinhmucthoigianEntity(IValidator validator):base("DinhmucthoigianEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="madmtg">PK value for Dinhmucthoigian which data should be fetched into this Dinhmucthoigian object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DinhmucthoigianEntity(System.String madmtg):base("DinhmucthoigianEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.Madmtg = madmtg;
		}

		/// <summary> CTor</summary>
		/// <param name="madmtg">PK value for Dinhmucthoigian which data should be fetched into this Dinhmucthoigian object</param>
		/// <param name="validator">The custom validator object for this DinhmucthoigianEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DinhmucthoigianEntity(System.String madmtg, IValidator validator):base("DinhmucthoigianEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.Madmtg = madmtg;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected DinhmucthoigianEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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
			switch((DinhmucthoigianFieldIndex)fieldIndex)
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
			return DinhmucthoigianEntity.GetRelationsForField(fieldName);
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
		public bool TestOriginalFieldValueForNull(DinhmucthoigianFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(DinhmucthoigianFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new DinhmucthoigianRelations().GetAllRelations();
		}
		




	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(GD.BBPH.DAL.EntityType.DinhmucthoigianEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(DinhmucthoigianEntityFactory));
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

			_fieldsCustomProperties.Add("Madmtg", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tendinhmuc", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Mamay", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Madongmay", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Macongdoan", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Dodaytu", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Dodayden", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Khotu", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Khoden", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Chieudaitu", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Chieudaiden", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Somauma", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Sohinhma", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Maloaimang", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Maqcthanhpham", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Dauca", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Daucuon", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Doilenh", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Lencuon", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Xuongcuon", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thaythietbi", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Dungmay", fieldHashtable);
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
		/// <param name="validator">The validator object for this DinhmucthoigianEntity</param>
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
		public  static DinhmucthoigianRelations Relations
		{
			get	{ return new DinhmucthoigianRelations(); }
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
			get { return DinhmucthoigianEntity.CustomProperties;}
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
			get { return DinhmucthoigianEntity.FieldsCustomProperties;}
		}

		/// <summary> The Madmtg property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Madmtg"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String Madmtg
		{
			get { return (System.String)GetValue((int)DinhmucthoigianFieldIndex.Madmtg, true); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Madmtg, value); }
		}

		/// <summary> The Tendinhmuc property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Tendinhmuc"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Tendinhmuc
		{
			get { return (System.String)GetValue((int)DinhmucthoigianFieldIndex.Tendinhmuc, true); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Tendinhmuc, value); }
		}

		/// <summary> The Mamay property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Mamay"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Mamay
		{
			get { return (System.String)GetValue((int)DinhmucthoigianFieldIndex.Mamay, true); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Mamay, value); }
		}

		/// <summary> The Madongmay property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Madongmay"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Madongmay
		{
			get { return (System.String)GetValue((int)DinhmucthoigianFieldIndex.Madongmay, true); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Madongmay, value); }
		}

		/// <summary> The Macongdoan property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Macongdoan"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Macongdoan
		{
			get { return (System.String)GetValue((int)DinhmucthoigianFieldIndex.Macongdoan, true); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Macongdoan, value); }
		}

		/// <summary> The Dodaytu property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Dodaytu"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Dodaytu
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DinhmucthoigianFieldIndex.Dodaytu, false); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Dodaytu, value); }
		}

		/// <summary> The Dodayden property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Dodayden"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Dodayden
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DinhmucthoigianFieldIndex.Dodayden, false); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Dodayden, value); }
		}

		/// <summary> The Khotu property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Khotu"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Khotu
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DinhmucthoigianFieldIndex.Khotu, false); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Khotu, value); }
		}

		/// <summary> The Khoden property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Khoden"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Khoden
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DinhmucthoigianFieldIndex.Khoden, false); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Khoden, value); }
		}

		/// <summary> The Chieudaitu property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Chieudaitu"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Chieudaitu
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DinhmucthoigianFieldIndex.Chieudaitu, false); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Chieudaitu, value); }
		}

		/// <summary> The Chieudaiden property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Chieudaiden"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Chieudaiden
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DinhmucthoigianFieldIndex.Chieudaiden, false); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Chieudaiden, value); }
		}

		/// <summary> The Somauma property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Somauma"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Somauma
		{
			get { return (System.String)GetValue((int)DinhmucthoigianFieldIndex.Somauma, true); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Somauma, value); }
		}

		/// <summary> The Sohinhma property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Sohinhma"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Sohinhma
		{
			get { return (System.String)GetValue((int)DinhmucthoigianFieldIndex.Sohinhma, true); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Sohinhma, value); }
		}

		/// <summary> The Maloaimang property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Maloaimang"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Maloaimang
		{
			get { return (System.String)GetValue((int)DinhmucthoigianFieldIndex.Maloaimang, true); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Maloaimang, value); }
		}

		/// <summary> The Maqcthanhpham property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Maqcthanhpham"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Maqcthanhpham
		{
			get { return (System.String)GetValue((int)DinhmucthoigianFieldIndex.Maqcthanhpham, true); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Maqcthanhpham, value); }
		}

		/// <summary> The Dauca property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Dauca"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Dauca
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DinhmucthoigianFieldIndex.Dauca, false); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Dauca, value); }
		}

		/// <summary> The Daucuon property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Daucuon"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Daucuon
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DinhmucthoigianFieldIndex.Daucuon, false); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Daucuon, value); }
		}

		/// <summary> The Doilenh property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Doilenh"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Doilenh
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DinhmucthoigianFieldIndex.Doilenh, false); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Doilenh, value); }
		}

		/// <summary> The Lencuon property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Lencuon"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Lencuon
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DinhmucthoigianFieldIndex.Lencuon, false); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Lencuon, value); }
		}

		/// <summary> The Xuongcuon property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Xuongcuon"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Xuongcuon
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DinhmucthoigianFieldIndex.Xuongcuon, false); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Xuongcuon, value); }
		}

		/// <summary> The Thaythietbi property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Thaythietbi"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Thaythietbi
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DinhmucthoigianFieldIndex.Thaythietbi, false); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Thaythietbi, value); }
		}

		/// <summary> The Dungmay property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Dungmay"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Dungmay
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DinhmucthoigianFieldIndex.Dungmay, false); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Dungmay, value); }
		}

		/// <summary> The Ngaytao property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Ngaytao"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaytao
		{
			get { return (Nullable<System.DateTime>)GetValue((int)DinhmucthoigianFieldIndex.Ngaytao, false); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Ngaytao, value); }
		}

		/// <summary> The Nguoitao property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Nguoitao"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoitao
		{
			get { return (System.String)GetValue((int)DinhmucthoigianFieldIndex.Nguoitao, true); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Nguoitao, value); }
		}

		/// <summary> The Ngaysua property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Ngaysua"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaysua
		{
			get { return (Nullable<System.DateTime>)GetValue((int)DinhmucthoigianFieldIndex.Ngaysua, false); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Ngaysua, value); }
		}

		/// <summary> The Nguoisua property of the Entity Dinhmucthoigian<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "dinhmucthoigian"."Nguoisua"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoisua
		{
			get { return (System.String)GetValue((int)DinhmucthoigianFieldIndex.Nguoisua, true); }
			set	{ SetValue((int)DinhmucthoigianFieldIndex.Nguoisua, value); }
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
			get { return (int)GD.BBPH.DAL.EntityType.DinhmucthoigianEntity; }
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
