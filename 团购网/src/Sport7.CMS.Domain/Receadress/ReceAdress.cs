﻿using Sport7.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sport7.CMS.Receadress
{
    [Table("ReceAdress")]
    public class ReceAdress : FullAuditedEntity<Guid>
    {
        public Guid Userid { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string  RecePeople { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public string ReceTel { get; set; }

        /// <summary>
        /// 所在地区
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        public string DetAdress { get; set; }


        /// <summary>
        /// 是否选中地址
        /// </summary>
        public bool defaultAdress{ get; set; }

    }
}
