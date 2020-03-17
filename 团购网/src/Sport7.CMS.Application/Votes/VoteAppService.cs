using Sport7.Application.Services;
using Sport7.Domain.Repositories;
using System;
using Sport7.CMS.Vote;
using Sport7.CMS.Votes;
using System.Threading.Tasks;
using Sport7.CMS.Votes.Dtos;
using Sport7.CMS.VoteOptions;
using Sport7.Application.Dtos;
using System.Linq;
using System.Linq.Dynamic.Core;
using AutoMapper.QueryableExtensions;

namespace Votes
{
    public class VoteAppService : ApplicationService,IVoteAppService
    {
        private readonly IRepository<VoteDetail, Guid> _voteDetailRepository;
        private readonly IRepository<VoteDetailOption, Guid> _voteDetailOptions;

        public VoteAppService(IRepository<VoteDetail, Guid> voteDetailRepository,
            IRepository<VoteDetailOption, Guid> voteDetailOptions
            )
        {
            _voteDetailRepository = voteDetailRepository;
            _voteDetailOptions = voteDetailOptions;
        }


        /// <summary>
        ///新建投票
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task AddVoteDetail(VoteDetailInput input)
        {
            var voteDetail = ObjectMapper.Map<VoteDetailInput, VoteDetail>(input);
            voteDetail.Id = GuidGenerator.Create();
            foreach (var item in input.VoteSections)
            {
                var voteOption = ObjectMapper.Map<VoteDetailSection, VoteDetailOption>(item);
                voteOption.Id = GuidGenerator.Create();
                voteOption.VoteDetailId = voteDetail.Id;
                await _voteDetailOptions.InsertAsync(voteOption);
            }
            await _voteDetailRepository.InsertAsync(voteDetail);
        }

        /// <summary>
        ///获取投票列表
        /// </summary>
        /// <param name="output"></param>
        /// <returns></returns>
        public async Task<ListResultDto<VoteDetailDto>> GetVoteDetailList()
        {
            var query = from a in _voteDetailRepository
                        select new VoteDetailDto
                           {
                            Id = a.Id,
                            Title = a.Title,
                            TotalTickets = a.TotalTickets
                        };
            return new ListResultDto<VoteDetailDto>(query.ToList());
        }

        /// <summary>
        ///获取投票详情列表
        /// </summary>
        /// <param name="output"></param>
        /// <returns></returns>
        public async Task<VoteDetailOutput> GetVoteDetailOutput(Guid id)
        {
            var query = from a in _voteDetailRepository.Where(a=>a.Id == id)
                        join b in _voteDetailOptions on a.Id equals b.VoteDetailId
                        select new VoteList
                        {
                            OptionContent = b.OptionContent,
                            VoteDetailId = a.Id,
                        };
            var votinItem = _voteDetailRepository.FirstOrDefault(s => s.Id == id);
            var voteDetailOutput = new VoteDetailOutput()
            {
                Id = votinItem.Id,
                Content = votinItem.Content,
                CreationTime = votinItem.CreationTime,
                Endtime = votinItem.Endtime,
                Title = votinItem.Title,
                TotalTickets = votinItem.TotalTickets,
                VoteLists =query.ToList()
            };

            return await Task.FromResult(voteDetailOutput);
        }
    }
}
