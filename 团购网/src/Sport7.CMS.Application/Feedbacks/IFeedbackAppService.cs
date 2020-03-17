using System.Threading.Tasks;
using Sport7.Application.Dtos;
using Sport7.Application.Services;
using Sport7.CMS.Feedbacks.Dto;

namespace Sport7.CMS.Feedbacks
{
    public interface IFeedbackAppService : IApplicationService
    {
        Task CreateFeedback(CreateFeedbackInput input);
        PagedResultDto<FeedbackListDto> GetFeedbackList(FeedbackListInput input);
        Task DeleteFeedback(DeleteInput input);
    }
}
