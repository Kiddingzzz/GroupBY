using Announcements;
using Sport7.Application.Dtos;
using Sport7.Application.Services;
using Sport7.CMS.Announcements.Dto;
using Sport7.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Sport7.AutoMapper;
using Sport7.CMS.Settings;
using Sport7.SettingManagement;
using Sport7.Settings;

namespace Sport7.CMS.Announcements
{
    public class AnnouncementAppService : ApplicationService, IAnnouncementAppService
    {
        private readonly IRepository<Announcement, Guid> _announcementRepository;
        private readonly ISettingManager _settingManager;

        public AnnouncementAppService(
            IRepository<Announcement, Guid> announcementRepository,
            ISettingManager settingManager)
        {
            _announcementRepository = announcementRepository;
            _settingManager = settingManager;
        }

        /// <summary>
        ///     添加官方公告
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task CreateAnnouncement(CreateAnnouncementInput input)
        {
            var notice = ObjectMapper.Map<CreateAnnouncementInput, Announcement>(input);

            await _announcementRepository.InsertAsync(notice);

            //await _settingManager.SetAsync(CMSSettings.AnnouncementUpdatedTimeStamp, Clock.Now.ToTimeStamp().ToString(), GlobalSettingValueProvider.ProviderName, "");
        }

        /// <summary>
        /// 获取更新的时间戳, 用于播放时进行比较
        /// </summary>
        /// <returns></returns>
        public async Task<int> GetUpdatedTimeStampAsync()
        {
            return int.Parse(await SettingProvider.GetOrNullAsync(CMSSettings.AnnouncementUpdatedTimeStamp));
        }

        public async Task DeleteAnnouncement(Guid id)
        {
            await _announcementRepository.DeleteAsync(id);
        }

        public async Task UpdateAnnouncement(UpdataAnnouncementInput input)
        {
            var ground = _announcementRepository.FirstOrDefault(x => x.Id == input.Id);
            if (ground == null)
                throw new UserFriendlyException("该公告不存在！");

            var newGround = ObjectMapper.Map(input, ground);

            await _announcementRepository.UpdateAsync(newGround);
            //await _settingManager.SetAsync(CMSSettings.AnnouncementUpdatedTimeStamp, Clock.Now.ToTimeStamp().ToString(), GlobalSettingValueProvider.ProviderName, "");
        }

        /// <summary>
        ///     获取官方公告
        /// </summary>
        /// <returns></returns>
        public PagedResultDto<AnnouncementListDto> GetAnnouncementList(AnnouncementListInput input)
        {
            var query = _announcementRepository.OrderBy(t => t.CreationTime).ProjectTo<AnnouncementListDto>();
            
            query = query
                .WhereIf(!input.Title.IsNullOrWhiteSpace(), item => item.Title.Contains(input.Title));

            var totalCount = query.Count();

            return new PagedResultDto<AnnouncementListDto>(totalCount, query.OrderByDescending(t=>t.CreationTime).PageBy(input).ToList());
        }


        public Task<AnnouncementDto> GetAnnouncementById(Guid id)
        {

            var query = _announcementRepository.FirstOrDefault(t => t.Id == id);
            if (query == null)
                throw new UserFriendlyException("该公告不存在！");

            var output = new AnnouncementDto();

            return Task.FromResult(ObjectMapper.Map(query, output));
        }


    }
}
