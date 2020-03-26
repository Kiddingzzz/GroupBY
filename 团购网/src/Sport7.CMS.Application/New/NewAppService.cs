using Sport7.Application.Dtos;
using Sport7.Application.Services;
using Sport7.CMS.New.Dto;
using Sport7.CMS.News;
using Sport7.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport7.CMS.New
{
    public class NewAppService : ApplicationService, INewAppService
    {
        public readonly IRepository<HouseNews, Guid> _newRepository;

        public NewAppService(IRepository<HouseNews, Guid> newRepository)
        {
            _newRepository = newRepository;
        }

        /// <summary>
        /// 获取新闻列表
        /// </summary>
        public async Task<PagedResultDto<NewsListOutput>> GetNewsList(SearchNewsInput input)
        {
            DateTime time1 = DateTime.Now;  
            var query = from a in _newRepository
                        select new NewsListOutput
                        {
                            Id = a.Id,
                            Abstract = a.Abstract,
                            GenereMange = a.GenereMange,
                            HouseTitle = a.HouseTitle,
                            PulishTime = a.PulishTime,
                            CreationTime = a.PulishTime,
                            HeaderImg = a.HeaderImg,
                            ts = a.PulishTime - time1,
                            Days = (a.PulishTime - time1).Days,
                            hours = (a.PulishTime - time1).Hours,
                            Minutes = (a.PulishTime - time1).Minutes,
                            temp = -((a.PulishTime - time1).Days == 0 ? (a.PulishTime - time1).Hours == 0 ? (a.PulishTime - time1).Minutes : (a.PulishTime - time1).Hours : (a.PulishTime - DateTime.Now).Days),
                            def = (a.PulishTime - time1).Days == 0 ? (a.PulishTime - time1).Hours == 0 ? Convert.ToString(-(a.PulishTime - time1).Minutes + "分钟前")
                            : Convert.ToString(-(a.PulishTime - time1).Hours) + "小时前"
                            : Convert.ToString(-(a.PulishTime - time1).Days) + "天前",
                        };
            var result = query.OrderByDescending(t=>t.PulishTime).PageBy(input).ToList();
            return new PagedResultDto<NewsListOutput>(query.Count(),result);
        }

        /// <summary>
        /// 获取详情新闻
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<NewsDetail> GetNews(Guid id)
        {
            var query = from a in _newRepository.Where(a => a.Id == id)
                        select new NewsDetail
                        {
                            Abstract = a.Abstract,
                            Content = a.Content,
                            GenereMange = a.GenereMange,
                            HouseTitle = a.HouseTitle,
                            PulishTime = a.PulishTime,
                            HeaderImg = a.HeaderImg,
                        };
            return await Task.FromResult(query.FirstOrDefault());
        }
    }
}
