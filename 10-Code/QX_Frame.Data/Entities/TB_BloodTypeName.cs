/*********************************************************
 * CopyRight: QIXIAO CODE BUILDER. 
 * Version:4.2.0
 * Author:qixiao(柒小)
 * Create:2017-09-07 14:49:43
 * Update:2017-09-07 14:49:43
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
	/// public class TB_BloodTypeName
	/// </summary>
	[Serializable]
	[Table(TableName = "TB_BloodTypeName")]
	public class TB_BloodTypeName: Entity<DB_QX_Frame_MS_User, TB_BloodTypeName>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_BloodTypeName(){}

		// PK（identity）  血型Id
		[Key]
		public Int32 BloodTypeId { get;set; }
		// 血型名称
		[Column]
		public String BloodTypeName { get;set; }
	}
}
