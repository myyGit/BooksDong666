/*********************************************************
 * CopyRight: QIXIAO CODE BUILDER. 
 * Version:4.2.0
 * Author:qixiao(柒小)
 * Create:2017-09-07 14:51:27
 * Update:2017-09-07 14:51:27
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
	/// public class TB_ConstellationName
	/// </summary>
	[Serializable]
	[Table(TableName = "TB_ConstellationName")]
	public class TB_ConstellationName: Entity<DB_QX_Frame_MS_User, TB_ConstellationName>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_ConstellationName(){}

		// PK（identity）  星座Id
		[Key]
		public Int32 ConstellationId { get;set; }
		// 星座名称
		[Column]
		public String ConstellationName { get;set; }
	}
}
