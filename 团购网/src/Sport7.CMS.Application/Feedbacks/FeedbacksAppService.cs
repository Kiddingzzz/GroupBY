using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Sport7.Application.Dtos;
using Sport7.Application.Services;
using Sport7.CMS.Feedbacks.Dto;
using Sport7.Domain.Repositories;

namespace Sport7.CMS.Feedbacks
{
    public class FeedbackAppService : ApplicationService, IFeedbackAppService
    {
        private readonly IRepository<Feedback, Guid> _feedbackRepository;

        public FeedbackAppService(IRepository<Feedback, Guid> feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        /// <summary>
        ///     添加问题反馈
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task CreateFeedback(CreateFeedbackInput input)
        {
            var feedback = ObjectMapper.Map<CreateFeedbackInput, Feedback>(input);

            await _feedbackRepository.InsertAsync(feedback);
        }

        /// <summary>
        ///     获取问题反馈列表
        /// </summary>
        /// <returns></returns>
        public PagedResultDto<FeedbackListDto> GetFeedbackList(FeedbackListInput input)
        {
            var query = _feedbackRepository.OrderBy(t => t.CreationTime).ProjectTo<FeedbackListDto>();

            query = query
                .WhereIf(!input.Contact.IsNullOrWhiteSpace(), item => item.Contact.Contains(input.Contact));

            var totalCount = query.Count();

            return new PagedResultDto<FeedbackListDto>(totalCount, query.OrderByDescending(t => t.CreationTime).PageBy(input).ToList());
        }
        public async Task DeleteFeedback(DeleteInput input)
        {
            foreach (var id in input.Ids)
            {
                var comment = _feedbackRepository.FirstOrDefault(x => x.Id == id);
                if (comment == null)
                    throw new UserFriendlyException("未找到该评论");

                await _feedbackRepository.DeleteAsync(comment);
            }
        }

    }


}
