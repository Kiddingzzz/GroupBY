using Sport7.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.houseOrder.Dto
{
    [AutoMapTo(typeof(HouseOrder))]
    public   class HOrderInput
    {
        public Guid UserId { get; set; }
        public string houseTitle { get; set; }
        public string ImgHeard { get; set; }
        public string HousePrice { get; set; }
        public bool HouseType { get; set; }
        public Guid Houseid { get; set; }
    }
}
