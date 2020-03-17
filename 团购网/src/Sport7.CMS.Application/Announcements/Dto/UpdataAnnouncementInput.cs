using Announcements;
using Sport7.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sport7.CMS.Announcements.Dto
{
    [AutoMapTo(typeof(Announcement))]
    public class UpdataAnnouncementInput
    {
        public Guid Id { get;  set; }
        /// <summary>
        ///     展示顺序
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        ///     公告标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///     简短描述
        /// </summary>
        [StringLength(2000)]
        public string ShortDescription { get; set; }

        /// <summary>
        ///     详情描述
        /// </summary>
        public string Description { get; set; }
    }
}
