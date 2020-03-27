using Sport7.AutoMapper;
using Sport7.CMS.Home;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.HoseList.Dto
{
    //[AutoMapTo(typeof(UpdateHouse))]
    public class updateHouseOutput
    {
        /// <summary>
        /// 评论内容
        /// </summary>
        public virtual string Comment { get; set; }

        /// <summary>
        /// 评论时间
        /// </summary>
        public virtual DateTime CommentTime { get; set; }

        /// <summary>
        /// 登记人
        /// </summary>
        public virtual string JXWPerson { get; set; }
    }
}
