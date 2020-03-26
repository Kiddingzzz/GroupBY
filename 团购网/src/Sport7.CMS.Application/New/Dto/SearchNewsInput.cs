using Sport7.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.New.Dto
{
    public class SearchNewsInput : PagedAndSortedResultRequestDto
    {

        public string Content { get; set; }
    }
}
