///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Tuesday, November 15, 2022 9:35:06 AM
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
	/// <summary>Implements the static Relations variant for the entity: DonhangH. </summary>
	public partial class DonhangHRelations
	{
		/// <summary>CTor</summary>
		public DonhangHRelations()
		{
		}

		/// <summary>Gets all relations of the DonhangHEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.DonhangDEntityUsingMadon);
			toReturn.Add(this.PhieugiaohangHEntityUsingMadon);

			toReturn.Add(this.DmkhachEntityUsingMakhach);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between DonhangHEntity and DonhangDEntity over the 1:n relation they have, using the relation between the fields:
		/// DonhangH.Madon - DonhangD.Madon
		/// </summary>
		public virtual IEntityRelation DonhangDEntityUsingMadon
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "DonhangD" , true);
				relation.AddEntityFieldPair(DonhangHFields.Madon, DonhangDFields.Madon);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DonhangHEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DonhangDEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between DonhangHEntity and PhieugiaohangHEntity over the 1:n relation they have, using the relation between the fields:
		/// DonhangH.Madon - PhieugiaohangH.Madon
		/// </summary>
		public virtual IEntityRelation PhieugiaohangHEntityUsingMadon
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PhieugiaohangH" , true);
				relation.AddEntityFieldPair(DonhangHFields.Madon, PhieugiaohangHFields.Madon);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DonhangHEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PhieugiaohangHEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between DonhangHEntity and DmkhachEntity over the m:1 relation they have, using the relation between the fields:
		/// DonhangH.Makhach - Dmkhach.Makhach
		/// </summary>
		public virtual IEntityRelation DmkhachEntityUsingMakhach
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Dmkhach", false);
				relation.AddEntityFieldPair(DmkhachFields.Makhach, DonhangHFields.Makhach);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmkhachEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DonhangHEntity", true);
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
