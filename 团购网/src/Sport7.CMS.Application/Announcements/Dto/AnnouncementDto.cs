﻿using Announcements;
using Sport7.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.Announcements.Dto
{
    [AutoMapFrom(typeof(Announcement))]
    public class AnnouncementDto
    {
        public Guid Id { get; set; }

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
        public string ShortDescription { get; set; }

        /// <summary>
        ///     详情描述
        /// </summary>
        public string Description { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
