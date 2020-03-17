using Sport7.Application.Dtos;
using Sport7.Application.Services;
using Sport7.CMS.Announcements.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport7.CMS.Announcements
{
    public interface IAnnouncementAppService : IApplicationService
    {
        Task CreateAnnouncement(CreateAnnouncementInput input);
        Task DeleteAnnouncement(Guid id);
        Task UpdateAnnouncement(UpdataAnnouncementInput input);
        PagedResultDto<AnnouncementListDto> GetAnnouncementList(AnnouncementListInput input);
        Task<AnnouncementDto> GetAnnouncementById(Guid id);

        Task<int> GetUpdatedTimeStampAsync();
    }
}
