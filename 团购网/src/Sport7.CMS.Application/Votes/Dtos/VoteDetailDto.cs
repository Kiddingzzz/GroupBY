using Sport7.AutoMapper;
using Sport7.CMS.VoteOptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.Votes.Dtos
{
    [AutoMapFrom(typeof(VoteDetail))]
    public class VoteDetailDto
    {
        /// <summary>
        ///  投票Id
        /// </summary>
        public virtual Guid Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 票数
        /// </summary>
        public int TotalTickets { get; set; }
    }

    [AutoMapFrom(typeof(VoteDetail))]
    public class VoteDetailOutput
    {
        /// <summary>
        ///  投票Id
        /// </summary>
        public virtual Guid Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 内容 
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 截至日期
        /// </summary>
        public DateTime Endtime { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// 票数
        /// </summary>
        public int TotalTickets { get; set; }

        public List<VoteList> VoteLists { get; set; }
    }

    [AutoMapFrom(typeof(VoteDetailOption))]
    public class VoteList
    {
        /// <summary>
        /// 选项内容
        /// </summary>
        public virtual string OptionContent { get; set; }

        public virtual Guid VoteDetailId { get; set; }


    }
}
