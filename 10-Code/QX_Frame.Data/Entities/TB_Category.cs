/*********************************************************
 * CopyRight: QIXIAO CODE BUILDER. 
 * Version:4.2.0
 * Author:qixiao(柒小)
 * Create:2017-09-07 14:50:52
 * Update:2017-09-07 14:50:52
 * E-mail: dong@qixiao.me | wd8622088@foxmail.com 
 * GitHub: https://github.com/dong666 
 * Personal web site: http://qixiao.me 
 * Technical WebSit: http://www.cnblogs.com/qixiaoyizhan/ 
 * Description:
 * Thx , Best Regards ~
 *********************************************************/

using System;
using QX_Frame.App.Base;
using QX_Frame.Bantina.Bankinate;

namespace QX_Frame.Data.Entities
{
	/// <summary>
	/// public class TB_Category
	/// </summary>
	[Serializable]
	[Table(TableName = "TB_Category")]
	public class TB_Category: Entity<DB_QX_Frame_MS_CMS, TB_Category>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_Category(){}

		// PK（identity）  分类Id
		[Key]
		[AutoIncrease]
		public Int32 CategoryId { get;set; }
		// 分类名称
		[Column]
		public String CategoryName { get;set; }
	}
}
