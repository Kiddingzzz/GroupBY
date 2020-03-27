using Sport7.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.Imgs.Dto
{
    [AutoMapTo(typeof(UploadImg))]
    public class ImgInput
    {
        /// <summary>
        /// 图片地址
        /// </summary>
        public virtual string Url { get; set; }

        /// <summary>
        /// uid
        /// </summary>
        public virtual string Uid { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public virtual string Status { get; set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        public virtual Guid? TenantId { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        public virtual string Path { get; set; }

        /// <summary>
        /// 房源列表ID
        /// </summary>
        public virtual Guid HouseId { get; set; }
    }
}
