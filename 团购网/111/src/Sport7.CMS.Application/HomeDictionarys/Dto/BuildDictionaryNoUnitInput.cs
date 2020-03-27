using Sport7.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.HomeDictionarys.Dto
{
    [AutoMapTo(typeof(HomeDictionaryss))]
    public class BuildDictionaryNoUnitInput
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

        public List<DongNumeberlist> dongs { get; set; }
    }
    [AutoMapTo(typeof(HomeDong))]
    public class DongNumeberlist
    {
        /// <summary>
        /// 楼盘栋数
        /// </summary>
        public virtual string BuildingNumber { get; set; }

        public List<HomeUnitlist> homelist { get; set; }
    }

    [AutoMapTo(typeof(HomeUnit))]
    public class HomeUnitlist
    {

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
