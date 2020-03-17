using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.Imgs.Dto
{
    public class ImglistOutput
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
    }
}
