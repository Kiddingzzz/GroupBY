using Sport7.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.Announcements.Dto
{
    public class AnnouncementListInput : PagedAndSortedResultRequestDto
    {
        public string Title { get; set; }
    }
}
