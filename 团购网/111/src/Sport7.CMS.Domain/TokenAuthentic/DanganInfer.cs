using Sport7.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.TokenAuthentic
{
    public class DanganInfer : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// 籍贯
        /// </summary>
        public string Jiguan { get; set; }

        /// <summary>
        /// 英文名
        /// </summary>
        public string EnglishName { get; set; }

        /// <summary>
        /// 曾用名
        /// </summary>
        public string RecentlyName { get; set; }

        /// <summary>
        ///  简拼
        /// </summary>
        public string SimpleName { get; set; }

        /// <summary>
        /// 微信
        /// </summary>
        public string WeiXinName{ get; set; }

        /// <summary>
        /// qq
        /// </summary>
        public string QQ { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 家庭电话
        /// </summary>
        public string HousePhone { get; set; }

        /// <summary>
        /// 婚姻
        /// </summary>
        public string Married { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        public string Minzu { get; set; }

        /// <summary>
        /// 紧急联系人
        /// </summary>
        public string SeverPeople { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// 最高学历
        /// </summary>
        public string Study { get; set; }

        /// <summary>
        /// 工作年限
        /// </summary>
        public string Working { get; set; }

        /// <summary>
        /// 籍贯地址
        /// </summary>
        public string JiguanAddress { get; set; }

        /// <summary>
        /// 户　　口
        /// </summary>
        public string Hukou { get; set; }

        /// <summary>
        /// 政治面貌
        /// </summary>
        public string ZhengzhiMianmao { get; set; }
        
        /// <summary>
        /// 现居地址
        /// </summary>
        public string RecentHouse { get; set; }

        /// <summary>
        /// 社保号
        /// </summary>
        public string ShebaoNumber { get; set; }

        /// <summary>
        /// 公积金号
        /// </summary>
        public string GongjijinNumber { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        public string KaihuBank { get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        public string BankNumber { get; set; }

        /// <summary>
        /// 个人简介
        /// </summary>
        public string PeopleJianjie { get; set; }

        /// <summary>
        /// 兴趣爱好
        /// </summary>
        public string Love { get; set; }

        /// <summary>
        /// 推荐人
        /// </summary>
        public string TuijianRen { get; set; }

        /// <summary>
        /// 招聘渠道
        /// </summary>
        public string Qudao { get; set; }
    }
}
