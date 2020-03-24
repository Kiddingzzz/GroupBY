using Sport7.Application.Dtos;
using Sport7.Application.Services;
using Sport7.CMS.House;
using Sport7.CMS.houseOrder.Dto;
using Sport7.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport7.CMS.houseOrder
{
  public  class HouseOrderAppService : ApplicationService, IHouseOrderAppService
    {
        public readonly IRepository<HouseOrder, Guid> _OrderRepository;
        public readonly IRepository<HouseInfer, Guid> _houseRepository;
        public HouseOrderAppService(IRepository<HouseInfer, Guid> houseRepository, IRepository<HouseOrder, Guid> OrderRepository)
        {
            _houseRepository = houseRepository;
            _OrderRepository = OrderRepository;
        }

        /// <summary>
        /// 订单添加
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task AddHouserOrder(OrderInput input)
        {
            var query = _houseRepository.FirstOrDefault(a=>a.Id==input.Houseid);
            HOrderInput hOrderInput = new HOrderInput
            {
                UserId=input.Userid,
                houseTitle=query.FloorName,
                ImgHeard=query.ImgHeader,
                Houseid=input.Houseid,
                HousePrice=query.FloorPrice,
                HouseType=true
            };
            var houseorder = ObjectMapper.Map<HOrderInput, HouseOrder>(hOrderInput);
            houseorder.Id = GuidGenerator.Create();
            await _OrderRepository.InsertAsync(houseorder);

        }


        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public async Task<ListResultDto<houseOrderOut>> GetHouseOrderlist(Guid userid)
        {
            var query = from a in _OrderRepository.Where(a => a.UserId == userid && a.HouseType == true)
                        select new houseOrderOut
                        { 
                          houseTitle=a.houseTitle,
                          HouseType=a.HouseType,
                          ImgHeard=a.ImgHeard,
                          Houseid=a.Houseid,
                          HousePrice=a.HousePrice
                        };
            return new ListResultDto<houseOrderOut>(query.ToList());
        }
    }
}
