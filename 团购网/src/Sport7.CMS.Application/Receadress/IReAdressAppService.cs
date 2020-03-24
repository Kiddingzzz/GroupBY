using Sport7.Application.Dtos;
using Sport7.CMS.Receadress.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport7.CMS.Receadress
{
   public interface IReAdressAppService
    {
        /// <summary>
        /// 添加地址
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task AddAdress(AdressInput input);

         /// <summary>
         /// 编辑地址信息
         /// </summary>
         /// <param name="input"></param>
         /// <returns></returns>
        Task ModifyAdress(ModifyInput input);

        /// <summary>
        /// 修改默认地址
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task ModifyDefaut(Defatuinput input);

        /// <summary>
        /// 删除地址
        /// </summary>
        /// <param name="AdressId"></param>
        /// <returns></returns>
        Task DeleAdress(Guid AdressId);

        /// <summary>
        /// 查询地址信息列表
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        Task<ListResultDto<AdressOutput>> GetAdressList(Guid userid);
    }
}
