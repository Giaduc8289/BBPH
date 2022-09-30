﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Friday, September 30, 2022 2:52:39 PM
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
	/// <summary>Implements the static Relations variant for the entity: CtptmangH. </summary>
	public partial class CtptmangHRelations
	{
		/// <summary>CTor</summary>
		public CtptmangHRelations()
		{
		}

		/// <summary>Gets all relations of the CtptmangHEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CtptmangDEntityUsingIdH);
			toReturn.Add(this.DmmangEntityUsingMactpt);


			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CtptmangHEntity and CtptmangDEntity over the 1:n relation they have, using the relation between the fields:
		/// CtptmangH.Mactpt - CtptmangD.IdH
		/// </summary>
		public virtual IEntityRelation CtptmangDEntityUsingIdH
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CtptmangD" , true);
				relation.AddEntityFieldPair(CtptmangHFields.Mactpt, CtptmangDFields.IdH);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CtptmangHEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CtptmangDEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CtptmangHEntity and DmmangEntity over the 1:n relation they have, using the relation between the fields:
		/// CtptmangH.Mactpt - Dmmang.Mactpt
		/// </summary>
		public virtual IEntityRelation DmmangEntityUsingMactpt
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Dmmang" , true);
				relation.AddEntityFieldPair(CtptmangHFields.Mactpt, DmmangFields.Mactpt);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CtptmangHEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmmangEntity", false);
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
