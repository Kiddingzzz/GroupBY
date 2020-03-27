using Sport7.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.TokenAuthentic
{
    public class UserInfer : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 员工编号
        /// </summary>
        public string StaffNumber { get; set; }

        /// <summary>
        /// 员工性别
        /// </summary>
        public string Sex { get; set; }


        /// <summary>
        /// 手机号码
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 办公号码
        /// </summary>
        public string DoworkNumber { get; set; }

        /// <summary>
        /// 公司短号
        /// </summary>
        public string CompanyNumber { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string IDCard { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        public string BirthdayDate { get; set; }

        /// <summary>
        /// 入职日期
        /// </summary>
        public string IncompanyDate { get; set; }

        /// <summary>
        /// 岗位状态
        /// </summary>
        public string Statu { get; set; }

        /// <summary>
        /// 试用期限
        /// </summary>
        public string TrateDate { get; set; }


        public int UserId { get; set; }
    }
}
