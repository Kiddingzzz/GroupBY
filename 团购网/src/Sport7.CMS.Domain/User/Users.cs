using Sport7.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sport7.CMS.User
{
    [Table("Users")]
    public class Users : FullAuditedEntity<Guid>
    {
        /// <summary>
        ///     电话号码
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        ///     姓名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        ///     联系方式
        /// </summary>
        public string ContentWay { get; set; }  
    }
}
