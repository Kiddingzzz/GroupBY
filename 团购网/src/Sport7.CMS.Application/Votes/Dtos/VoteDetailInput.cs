using Sport7.AutoMapper;
using Sport7.CMS.VoteOptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.Votes.Dtos
{
    

    [AutoMapTo(typeof(VoteDetail))]
    public class VoteDetailInput
    {
       // public Guid Id { get; set; }
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
        public DateTime Endtime { get; set; }

        /// <summary>
        /// 是否匿名
        /// </summary>
        public bool isName { get; set; }


        /// <summary>
        /// 票数
        /// </summary>
        public int TotalTickets { get; set; }


       // public Guid? TenantId { get; set; }

        public List<VoteDetailSection> VoteSections { get; set; }

    }

    [AutoMapTo(typeof(VoteDetailOption))]
    public class VoteDetailSection
    {
        /// <summary>
        /// 选项内容
        /// </summary>
        public virtual string OptionContent { get; set; }

      //  public virtual Guid VoteDetailId { get; set; }


    }


}
