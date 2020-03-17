using Sport7.CMS.VoteOptions;
using Sport7.Domain.Entities;
using Sport7.Domain.Entities.Auditing;
using Sport7.MultiTenancy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sport7.CMS.Votes
{
    /// <summary>
    ///     新建投票
    /// </summary>
    [Table("VoteDetail")]
    public class VoteDetail : FullAuditedEntity<Guid>, IMultiTenant
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// 内容 
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 是否单选    
        /// </summary>
        public bool IsSingle { get; set; }

        /// <summary>
        /// 参与权限
        /// </summary>
        public string Participatory { get; set; }

        /// <summary>
        /// 查看权限
        /// </summary>
        public string Lookup { get; set; }

        /// <summary>
        /// 上传图片
        /// </summary>
        public string ImgList { get; set; }

        /// <summary>
        /// 截至日期
        /// </summary>
        public DateTime Endtime { get;set;}

        /// <summary>
        /// 是否匿名
        /// </summary>
        public bool isName { get; set; }
        /// <summary>
        /// 票数
        /// </summary>
        public int TotalTickets { get; set; }

        public Guid? TenantId { get; set; }
        public ICollection<VoteDetailOption> VoteLists;
    }
}
