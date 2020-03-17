using Sport7.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.HomeDictionarys.Dto
{
    [AutoMapTo(typeof(HomeDictionaryss))]
    public class BuildDictionaryInput
    {
        /// <summary>
        /// 楼盘名称
        /// </summary>
        public virtual string DictionaryName { get; set; }

        /// <summary>
        /// 楼盘栋数
        /// </summary>
        public virtual string BuildingNumber { get; set; }

        /// <summary>
        /// 层数
        /// </summary>
        public virtual int NumberLayer { get; set; }

        /// <summary>
        /// 单元
        /// </summary>
        public virtual int Unit { get; set; }

        public List<DongNumber> dongNumbers { get; set; }
    }
    [AutoMapTo(typeof(HomeDong))]
    public class DongNumber
    {
        /// <summary>
        /// 楼盘栋数
        /// </summary>
        public virtual string BuildingNumber { get; set; }

        public List<HomeUnits> homeUnits { get; set; }
    }
    [AutoMapTo(typeof(HomeUnit))]
    public class HomeUnits
    {
        /// <summary>
        /// 单元
        /// </summary>
        public virtual int Unit { get; set; }

        /// <summary>
        /// 层数
        /// </summary>
        public virtual int NumberLayer { get; set; }

        /// <summary>
        /// 有无单元
        /// </summary>
        public virtual bool IsUnit { get; set; }
    }
}
