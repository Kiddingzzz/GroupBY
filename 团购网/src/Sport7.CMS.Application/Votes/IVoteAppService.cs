using Sport7.Application.Dtos;
using Sport7.CMS.Votes.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport7.CMS.Vote
{
    public interface IVoteAppService
    {
        /// <summary>
        /// 新建投票
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task AddVoteDetail(VoteDetailInput input);

        /// <summary>
        /// 获取投票列表
        /// </summary>
        Task<ListResultDto<VoteDetailDto>> GetVoteDetailList();

        /// <summary>
        ///获取投票详情列表
        /// </summary>
        /// <param name="output"></param>
        /// <returns></returns>
        Task<VoteDetailOutput> GetVoteDetailOutput(Guid id);
    }
}
