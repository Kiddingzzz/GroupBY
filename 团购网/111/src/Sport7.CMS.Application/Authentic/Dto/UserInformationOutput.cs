using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.Authentic.Dto
{
    public class UserInformationOutput
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string EmailAddress { get; set; }

        public Guid? TenantId { get; set; }

        /// <summary>
        /// 微信用户Id
        /// </summary>
        public string WeexId { get; set; }

        /// <summary>
        /// 微信头像
        /// </summary>
        public string WeexAvtor { get; set; }

        /// <summary>
        /// 微信用户名
        /// </summary>
        public string WeexUserName { get; set; }

        /// <summary>
        /// 微信用户号
        /// </summary>
        public string WeexNumber { get; set; }

        /// <summary>
        /// 所属部门
        /// </summary>
        public string ManagerMent { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        public string Izhiwei { get; set; }
    }
}
