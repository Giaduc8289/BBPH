///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Thursday, October 6, 2022 9:04:16 AM
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using GD.BBPH.DAL;
using GD.BBPH.DAL.FactoryClasses;
using GD.BBPH.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.BBPH.DAL.RelationClasses
{
	/// <summary>Implements the static Relations variant for the entity: PhieugiaohangH. </summary>
	public partial class PhieugiaohangHRelations
	{
		/// <summary>CTor</summary>
		public PhieugiaohangHRelations()
		{
		}

		/// <summary>Gets all relations of the PhieugiaohangHEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.PhieugiaohangDEntityUsingSophieu);

			toReturn.Add(this.DonhangHEntityUsingMadon);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between PhieugiaohangHEntity and PhieugiaohangDEntity over the 1:n relation they have, using the relation between the fields:
		/// PhieugiaohangH.Sophieu - PhieugiaohangD.Sophieu
		/// </summary>
		public virtual IEntityRelation PhieugiaohangDEntityUsingSophieu
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PhieugiaohangD" , true);
				relation.AddEntityFieldPair(PhieugiaohangHFields.Sophieu, PhieugiaohangDFields.Sophieu);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PhieugiaohangHEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PhieugiaohangDEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between PhieugiaohangHEntity and DonhangHEntity over the m:1 relation they have, using the relation between the fields:
		/// PhieugiaohangH.Madon - DonhangH.Madon
		/// </summary>
		public virtual IEntityRelation DonhangHEntityUsingMadon
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "DonhangH", false);
				relation.AddEntityFieldPair(DonhangHFields.Madon, PhieugiaohangHFields.Madon);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DonhangHEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PhieugiaohangHEntity", true);
				return relation;
			}
		}

		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}

		#endregion

		#region Included Code

		#endregion
	}
}
