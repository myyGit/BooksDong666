/*********************************************************
 * CopyRight: QIXIAO CODE BUILDER. 
 * Version:4.2.0
 * Author:qixiao(柒小)
 * Create:2017-09-07 14:50:57
 * Update:2017-09-07 14:50:57
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
	/// public class TB_ChineseZodiacName
	/// </summary>
	[Serializable]
	[Table(TableName = "TB_ChineseZodiacName")]
	public class TB_ChineseZodiacName: Entity<DB_QX_Frame_MS_User, TB_ChineseZodiacName>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_ChineseZodiacName(){}

		// PK（identity）  生肖Id
		[Key]
		public Int32 ChineseZodiacId { get;set; }
		// 生肖名称
		[Column]
		public String ChineseZodiacName { get;set; }
	}
}
