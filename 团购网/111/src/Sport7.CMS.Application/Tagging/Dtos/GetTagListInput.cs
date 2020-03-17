using System;
using System.Collections.Generic;

namespace Sport7.CMS.Tagging.Dtos
{
    public class GetTagListInput
    {
        public IEnumerable<Guid> Ids { get; set; }
    }
}