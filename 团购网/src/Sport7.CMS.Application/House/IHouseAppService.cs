using Sport7.Application.Dtos;
using Sport7.CMS.House.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport7.CMS.House
{
    public interface IHouseAppService
    {
        /// <summary>
        /// 获取房屋列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ListResultDto<HouseListLookOutput>> GetHouseList();

        /// <summary>
        /// 获取房屋详情信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<HouseOutput> GetHouseDetail(Guid id);
    }
}
