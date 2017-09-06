using QX_Frame.App.Base;
using QX_Frame.Data.Entities;
using System;
using System.Linq.Expressions;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:38:40
 **/

namespace QX_Frame.Data.QueryObject
{
	/// <summary>
	///class TB_BloodTypeNameQueryObject
	/// </summary>
	public class TB_BloodTypeNameQueryObject:WcfQueryObject<DB_QX_Frame_MS_User, TB_BloodTypeName>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_BloodTypeNameQueryObject()
		{}

		// PK（identity）  血型Id
		public Int32 BloodTypeId { get;set; }

		// 血型名称
		public String BloodTypeName { get;set; }

		//query condition // null default
		public override Expression<Func<TB_BloodTypeName, bool>> QueryCondition {get { return base.QueryCondition; } set { base.QueryCondition = value; } }

		//query condition func // true default //if QueryCondition != null this will be override !!!
		protected override Expression<Func<TB_BloodTypeName, bool>> QueryConditionFunc()
		{
			Expression<Func<TB_BloodTypeName, bool>> func = t => true;

			if (!string.IsNullOrEmpty(""))
			{
				func = func.And(t => true);
			}

			return func;
		}
	}
}
