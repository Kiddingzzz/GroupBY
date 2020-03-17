using Sport7.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.Feedbacks.Dto
{
    [AutoMapFrom(typeof(Feedback))]
    public class FeedbackListDto: CreateFeedbackInput
    {
        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
