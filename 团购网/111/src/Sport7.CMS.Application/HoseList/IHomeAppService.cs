using Sport7.Application.Dtos;
using Sport7.CMS.HoseList.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport7.CMS.HoseList
{
    public interface IHomeAppService
    {
        /// <summary>
        ///新建房源
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task AddHomeDetail(HouseInput input);

        /// <summary>
        /// 修改房源
        /// </summary>
        /// <param name="input"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task ModifyHomeDetail(HouseInput input, Guid id);

        /// <summary>
        ///获取售房源列表
        /// </summary>
        /// <param name="output"></param>
        /// <returns></returns>
        Task<ListResultDto<HouseOutput>> GetSaleBuildList(buildInput input);

        /// <summary>
        ///获取租房源列表
        /// </summary>
        /// <param name="output"></param>
        /// <returns></returns>
        Task<PagedResultDto<HouseOutput>> GetBorrowBuildList(buildInput input);

        /// <summary>
        ///  新建跟进信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task AddUpdateTitle(UpdateInput input);

        /// <summary>
        /// 获取跟进信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ListResultDto<updateHouseOutput>> GetUpdate(Guid id);

        /// <summary>
        /// 获取客户以及房源信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<UpdateInfoCustomerOutupt> GetUpdateInfo(Guid id);
    }
}
