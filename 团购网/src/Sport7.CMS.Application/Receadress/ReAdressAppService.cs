using Sport7.Application.Dtos;
using Sport7.Application.Services;
using Sport7.CMS.Receadress.Dto;
using Sport7.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport7.CMS.Receadress
{
   public class ReAdressAppService : ApplicationService, IReAdressAppService
    {
        public readonly IRepository<ReceAdress, Guid> _ReceAdressRepository;
        public ReAdressAppService(IRepository<ReceAdress, Guid> ReceAdressRepository)
        {
            _ReceAdressRepository = ReceAdressRepository;
           
        }

        /// <summary>
        /// 添加地址
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task AddAdress(AdressInput input)
        {
            var adressinsert = ObjectMapper.Map<AdressInput, ReceAdress>(input);
            adressinsert.Id = GuidGenerator.Create();
            await _ReceAdressRepository.InsertAsync(adressinsert);

            var query = _ReceAdressRepository.Where(a => a.Userid == input.Userid&&a.Id!=adressinsert.Id).ToList();
            for (int i = 0; i < query.Count; i++)
            {
                if (query[i].defaultAdress == true) {
                    query[i].defaultAdress = false;
                    await _ReceAdressRepository.UpdateAsync(query[i]);
                }

            }
        }

        /// <summary>
        /// 编辑地址信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task ModifyAdress(ModifyInput input)
        {
            var query = _ReceAdressRepository.FirstOrDefault(a => a.Id == input.id);
            query.RecePeople = input.RecePeople;
            query.ReceTel = input.ReceTel;
            query.Adress = input.Adress;
            query.DetAdress = input.DetAdress;
            await _ReceAdressRepository.UpdateAsync(query);
        }

        /// <summary>
        /// 修改默认地址
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task ModifyDefaut(Defatuinput input)
        {
            var query = _ReceAdressRepository.FirstOrDefault(a => a.Id == input.id);
            query.defaultAdress = input.defaultAdress;
            await _ReceAdressRepository.UpdateAsync(query);
        }

        /// <summary>
        /// 删除地址
        /// </summary>
        /// <param name="AdressId"></param>
        /// <returns></returns>
        public async Task DeleAdress(Guid AdressId)
        {
            var query = _ReceAdressRepository.FirstOrDefault(a => a.Id == AdressId);
            await _ReceAdressRepository.DeleteAsync(query);
        }

        /// <summary>
        /// 查询地址信息列表
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public async Task<ListResultDto<AdressOutput>> GetAdressList(Guid userid)
        {
            var query = from a in _ReceAdressRepository.Where(a => a.Userid == userid)
                        select new AdressOutput
                        {
                          RecePeople=a.RecePeople,
                          ReceTel=a.ReceTel,
                          id=a.Id,
                          Userid=a.Userid,
                          Adress=a.Adress,
                          DetAdress=a.DetAdress,
                          defaultAdress=a.defaultAdress
                          
                        };
            return new ListResultDto<AdressOutput>(query.ToList());

        }


    }
}
