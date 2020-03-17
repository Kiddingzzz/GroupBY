using System;
using System.Collections.Generic;
using System.Text;
using Sport7.Application.Dtos;
using Sport7.AutoMapper;

namespace Sport7.CMS.Feedbacks.Dto
{
    [AutoMapTo(typeof(Feedback))]
    public class CreateFeedbackInput
    {
        public int Score { get; set; }
        public string Content { get; set; }
        public string Contact { get; set; }
        public string ImageList { get; set; }
    }

    public class  FeedbackListInput : PagedAndSortedResultRequestDto
    {
        public string Contact { get; set; }
    }

    public class DeleteInput
    {
        public List<Guid> Ids { get; set; }
    }
}
