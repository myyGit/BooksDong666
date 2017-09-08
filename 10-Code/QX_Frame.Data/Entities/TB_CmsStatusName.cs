/*********************************************************
 * CopyRight: QIXIAO CODE BUILDER. 
 * Version:4.2.0
 * Author:qixiao(柒小)
 * Create:2017-09-07 14:51:09
 * Update:2017-09-07 14:51:09
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
	/// public class TB_CmsStatusName
	/// </summary>
	[Serializable]
	[Table(TableName = "TB_CmsStatusName")]
	public class TB_CmsStatusName: Entity<DB_QX_Frame_MS_CMS, TB_CmsStatusName>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_CmsStatusName(){}

		// PK（identity）  
		[Key]
		public Int32 StatusId { get;set; }
		// 
		[Column]
		public String StatusName { get;set; }
	}
}
