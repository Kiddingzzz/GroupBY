using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.HoseList.Dto
{
    public class HomePageProduct
    {
        /// <summary>
        /// 售
        /// </summary>
        public List<HouseOutput> SaleSelect { get; set; }
        
        /// <summary>
        /// 租
        /// </summary>
        public List<HouseOutput> BrowworSelect { get; set; }

        /// <summary>
        /// 租售
        /// </summary>
        public List<HouseOutput> SaleBrowwor { get; set; }

        /// <summary>
        /// 资料
        /// </summary>
        public List<HouseOutput> DisDetail { get; set; }
    }
}
