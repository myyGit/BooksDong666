/*********************************************************
 * CopyRight: QIXIAO CODE BUILDER. 
 * Version:4.2.0
 * Author:qixiao(柒小)
 * Create:2017-09-07 14:51:47
 * Update:2017-09-07 14:51:47
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
	/// public class TB_SexName
	/// </summary>
	[Serializable]
	[Table(TableName = "TB_SexName")]
	public class TB_SexName: Entity<DB_QX_Frame_MS_User, TB_SexName>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_SexName(){}

		// PK（identity）  性别Id
		[Key]
		public Int32 SexId { get;set; }
		// 性别名称
		[Column]
		public String SexName { get;set; }
	}
}
