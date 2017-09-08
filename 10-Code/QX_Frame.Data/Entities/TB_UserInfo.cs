/*********************************************************
 * CopyRight: QIXIAO CODE BUILDER. 
 * Version:4.2.0
 * Author:qixiao(柒小)
 * Create:2017-09-07 14:52:06
 * Update:2017-09-07 14:52:06
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
	/// public class TB_UserInfo
	/// </summary>
	[Serializable]
	[Table(TableName = "TB_UserInfo")]
	public class TB_UserInfo: Entity<DB_QX_Frame_MS_User, TB_UserInfo>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_UserInfo(){}

		// PK（identity）  Uid
		[Key]
		public Guid UserUid { get;set; }
		// 登录名
		[Column]
		public String LoginId { get;set; }
		// 昵称
		[Column]
		public String NickName { get;set; }
		// 头像地址
		[Column]
		public String HeadImageUrl { get;set; }
		// 年龄
		[Column]
		public Int32 Age { get;set; }
		// 性别
		[Column]
		public Int32 SexId { get;set; }

        [ForeignTable(ForeignKeyFieldName = "SexId")]
        public TB_SexName TB_SexName { get; set; }
                                           // 出生日期
        [Column]
		public DateTime? Birthday { get;set; }
		// 血型
		[Column]
		public Int32 BloodTypeId { get;set; }

        [ForeignTable(ForeignKeyFieldName = "BloodTypeId")]
        public TB_BloodTypeName TB_BloodTypeName { get; set; }
                                           // 地址
        [Column]
		public String Address { get;set; }
		// 职位
		[Column]
		public String Position { get;set; }
		// 学校
		[Column]
		public String School { get;set; }
		// 公司
		[Column]
		public String Company { get;set; }
		// 星座
		[Column]
		public Int32 ConstellationId { get;set; }

        [ForeignTable(ForeignKeyFieldName = "ConstellationId")]
        public TB_ConstellationName TB_ConstellationName { get; set; }
                                           // 生肖
        [Column]
		public Int32 ChineseZodiacId { get;set; }

        [ForeignTable(ForeignKeyFieldName = "ChineseZodiacId")]
        public TB_ChineseZodiacName TB_ChineseZodiacName { get; set; }
        // 个性签名
        [Column]
		public String PersonalizedSignature { get;set; }
		// 个人说明
		[Column]
		public String PersonalizedDescription { get;set; }
		// 注册日期
		[Column]
		public DateTime RegisterTime { get;set; }
	}
}
