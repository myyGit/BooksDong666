/*********************************************************
 * CopyRight: QIXIAO CODE BUILDER. 
 * Version:4.2.0
 * Author:qixiao(柒小)
 * Create:2017-09-07 14:51:42
 * Update:2017-09-07 14:51:42
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
	/// public class TB_LimitCode
	/// </summary>
	[Serializable]
	[Table(TableName = "TB_LimitCode")]
	public class TB_LimitCode: Entity<DB_QX_Frame_MS_User, TB_LimitCode>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_LimitCode(){}

		// PK（identity）  权限代码
		[Key]
		[AutoIncrease]
		public Int32 LimitCodeId { get;set; }
		// 权限描述
		[Column]
		public String LimitDescription { get;set; }
	}
}
