using Sport7.Application.Dtos;
using Sport7.CMS.New.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport7.CMS.New
{
    public interface INewAppService
    {
        /// <summary>
        /// 获取新闻列表
        /// </summary>
        Task<PagedResultDto<NewsListOutput>> GetNewsList(SearchNewsInput input);

        /// <summary>
        /// 获取详情新闻
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<NewsDetail> GetNews(Guid id);
    }
}
