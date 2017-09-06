using QX_Frame.App.Base;
using QX_Frame.Data.Entities;
using System;
using System.Linq.Expressions;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-10 16:13:48
 **/

namespace QX_Frame.Data.QueryObject
{
	/// <summary>
	///class TB_CategoryQueryObject
	/// </summary>
	public class TB_CategoryQueryObject:WcfQueryObject<DB_QX_Frame_MS_CMS, TB_Category>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_CategoryQueryObject()
		{}

		// PK（identity）  分类Id
		public Int32 CategoryId { get;set; }

		// 分类名称
		public String CategoryName { get;set; }

		//query condition // null default
		public override Expression<Func<TB_Category, bool>> QueryCondition {get { return base.QueryCondition; } set { base.QueryCondition = value; } }

		//query condition func // true default //if QueryCondition != null this will be override !!!
		protected override Expression<Func<TB_Category, bool>> QueryConditionFunc()
		{
			Expression<Func<TB_Category, bool>> func = t => true;

			if (!string.IsNullOrEmpty(""))
			{
				func = func.And(t => true);
			}

			return func;
		}
	}
}
