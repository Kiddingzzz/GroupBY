using System;
using System.Collections.Generic;
using Sport7.Application.Dtos;

namespace Sport7.CMS.Posts
{
    public class BlogUserDto : EntityDto<Guid>
    {
        public Guid? TenantId { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public Dictionary<string, object> ExtraProperties { get; set; }
    }
}
