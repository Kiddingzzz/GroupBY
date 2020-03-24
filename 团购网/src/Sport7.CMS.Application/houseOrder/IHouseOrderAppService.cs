using Sport7.Application.Dtos;
using Sport7.CMS.houseOrder.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport7.CMS.houseOrder
{
  public  interface IHouseOrderAppService
    {
        /// <summary>
        /// 订单添加
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task AddHouserOrder(OrderInput input);

        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        Task<ListResultDto<houseOrderOut>> GetHouseOrderlist(Guid userid);
    }
}
