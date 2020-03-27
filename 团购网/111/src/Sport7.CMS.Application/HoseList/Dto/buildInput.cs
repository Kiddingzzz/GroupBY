using Sport7.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.HoseList.Dto
{
    public class buildInput: PagedAndSortedResultRequestDto
    {
        /// <summary>
        /// 搜索名字
        /// </summary>
        public string SearchName { get; set; }

        /// <summary>
        /// 楼盘名称
        /// </summary>
        public string BuildName { get; set; }
        
        /// <summary>
        /// 片区
        /// </summary>
        public string Pianqu { get; set; }
    }
}
