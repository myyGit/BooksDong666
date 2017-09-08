using QX_Frame.App.Base;
using QX_Frame.Data.Entities;
using System;
using System.Linq.Expressions;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-10 16:13:46
 **/

namespace QX_Frame.Data.QueryObject
{
	/// <summary>
	///class TB_BookQueryObject
	/// </summary>
	public class TB_BookQueryObject:WcfQueryObject<DB_QX_Frame_MS_CMS, TB_Book>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_BookQueryObject()
		{}

		// PK（identity）  
		public Guid BookUid { get;set; }

		// 
		public String Title { get;set; }

		// 其他名称
		public String Title2 { get;set; }

		// 
		public Int32 Volume { get;set; }

		// 
		public String Dynasty { get;set; }

		// 
		public Int32 CategoryId { get;set; }

		// 
		public String Functionary { get;set; }

		// 
		public String Publisher { get;set; }

		// 
		public String Version { get;set; }

		// 
		public String FromBF49 { get;set; }

		// 
		public String FromAF49 { get;set; }

		// 
		public String ImageUris { get;set; }

		// 
		public String Notice { get;set; }
        public String NameFan { get; set; }
        public String NameJian { get; set; }
        public Int32 CategoryId2 { get; set; }
        /// <summary>
        /// 查询的输入参数
        /// </summary>
        public String TxtTitle2 { get; set; }
        public String NameFan2 { get; set; }
        public String NameJian2 { get; set; }
        //query condition // null default
        public override Expression<Func<TB_Book, bool>> QueryCondition {get { return base.QueryCondition; } set { base.QueryCondition = value; } }

		//query condition func // true default //if QueryCondition != null this will be override !!!
		protected override Expression<Func<TB_Book, bool>> QueryConditionFunc()
		{
			Expression<Func<TB_Book, bool>> func = t => true;

			if (!string.IsNullOrEmpty(""))
			{
				func = func.And(t => true);
			}
            if (!string.IsNullOrEmpty(this.Title))
            {
                switch (this.CategoryId)  //0:全部  1：书名  2：作者  3：出版者   4：朝代  5：其他名称
                {
                    case 0:
                        func.And(tt => tt.Title.Contains(this.Title) || tt.Title.Contains(this.NameFan) || tt.Title.Contains(this.NameJian)
                                     || tt.Functionary.Contains(this.Title) || tt.Functionary.Contains(this.NameFan) || tt.Functionary.Contains(this.NameJian)
                                     || tt.Publisher.Contains(this.Title) || tt.Publisher.Contains(this.NameFan) || tt.Publisher.Contains(this.NameJian)
                                     || tt.Dynasty.Contains(this.Title) || tt.Dynasty.Contains(this.NameFan) || tt.Dynasty.Contains(this.NameJian)
                                     || tt.Title2.Contains(this.Title) || tt.Title2.Contains(this.NameFan) || tt.Title2.Contains(this.NameJian));
                        break;
                    case 1: func.And(tt => tt.Title.Contains(this.Title) || tt.Title.Contains(this.NameFan) || tt.Title.Contains(this.NameJian)); break;
                    case 2: func.And(tt => tt.Functionary.Contains(this.Title) || tt.Functionary.Contains(this.NameFan) || tt.Functionary.Contains(this.NameJian)); break;
                    case 3: func.And(tt => tt.Publisher.Contains(this.Title) || tt.Publisher.Contains(this.NameFan) || tt.Publisher.Contains(this.NameJian)); break;
                    case 4: func.And(tt => tt.Dynasty.Contains(this.Title) || tt.Dynasty.Contains(this.NameFan) || tt.Dynasty.Contains(this.NameJian)); break;
                    case 5: func.And(tt => tt.Title2.Contains(this.Title) || tt.Title2.Contains(this.NameFan) || tt.Title2.Contains(this.NameJian)); break;
                    default:
                        break;
                }
            }
            
            //if (this.CategoryId2 != 0)
            //{
            //    func = func.And(tt => tt.CategoryId == this.CategoryId2);
            //}

            if (!string.IsNullOrEmpty(this.TxtTitle2))
            {
                switch (this.CategoryId2)  //0:全部  1：书名  2：作者  3：出版者   4：朝代  5：其他名称
                {
                    case 0:
                        func.And(tt => tt.Title.Contains(this.TxtTitle2) || tt.Title.Contains(this.NameFan2) || tt.Title.Contains(this.NameJian2)
                                     || tt.Functionary.Contains(this.TxtTitle2) || tt.Functionary.Contains(this.NameFan2) || tt.Functionary.Contains(this.NameJian2)
                                     || tt.Publisher.Contains(this.TxtTitle2) || tt.Publisher.Contains(this.NameFan2) || tt.Publisher.Contains(this.NameJian2)
                                     || tt.Dynasty.Contains(this.TxtTitle2) || tt.Dynasty.Contains(this.NameFan2) || tt.Dynasty.Contains(this.NameJian2)
                                     || tt.Title2.Contains(this.TxtTitle2) || tt.Title2.Contains(this.NameFan2) || tt.Title2.Contains(this.NameJian2));
                        break;
                    case 1: func.And(tt => tt.Title.Contains(this.TxtTitle2) || tt.Title.Contains(this.NameFan2) || tt.Title.Contains(this.NameJian2));break;
                    case 2: func.And(tt => tt.Functionary.Contains(this.TxtTitle2) || tt.Functionary.Contains(this.NameFan2) || tt.Functionary.Contains(this.NameJian2)); break;
                    case 3: func.And(tt => tt.Publisher.Contains(this.TxtTitle2) || tt.Publisher.Contains(this.NameFan2) || tt.Publisher.Contains(this.NameJian2)); break;
                    case 4: func.And(tt => tt.Dynasty.Contains(this.TxtTitle2) || tt.Dynasty.Contains(this.NameFan2) || tt.Dynasty.Contains(this.NameJian2)); break;
                    case 5: func.And(tt => tt.Title2.Contains(this.TxtTitle2) || tt.Title2.Contains(this.NameFan2) || tt.Title2.Contains(this.NameJian2)); break;
                    default:
                        break;
                }
            }

            return func;
		}
	}
}
