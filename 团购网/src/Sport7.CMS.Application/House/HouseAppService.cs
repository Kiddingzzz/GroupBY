using Sport7.Application.Dtos;
using Sport7.Application.Services;
using Sport7.CMS.House.Dto;
using Sport7.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace Sport7.CMS.House
{
    public class HouseAppService : ApplicationService, IHouseAppService
    {
        public readonly IRepository<HouseInfer, Guid> _houseRepository;

        public HouseAppService(IRepository<HouseInfer, Guid> houseRepository)
        {
            _houseRepository = houseRepository;
        }

        /// <summary>
        /// 新增房屋
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task AddHouse(HouseInput input)
        {
            var houseDetail = ObjectMapper.Map<HouseInput, HouseInfer>(input);
            houseDetail.Id = GuidGenerator.Create();
            await _houseRepository.InsertAsync(houseDetail);
        }

        /// <summary>
        /// 获取房屋列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ListResultDto<HouseListLookOutput>> GetHouseList()
        {
            var query = from a in _houseRepository.OrderByDescending(t => t.CreationTime)
                        select new HouseListLookOutput
                        {
                            Id = a.Id,
                            Address = a.Address,
                            Area = a.Area,
                            FloorName = a.FloorName,
                            FloorPrice = a.FloorPrice,
                            Tags = a.Tags,
                            ImgHeader = a.ImgHeader,
                            VTImg = a.VTImg,
                        };
            return new ListResultDto<HouseListLookOutput>(query.ToList());
        }

        /// <summary>
        /// 获取房屋详情信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<HouseOutput> GetHouseDetail(Guid id)
        {
            var query = _houseRepository.FirstOrDefault(a => a.Id == id);
            var HouseItem = new HouseOutput()
            {
                Address = query.Address,
                Alias = query.Alias,
                AllVideo = query.AllVideo,
                Apartment = query.Apartment,
                ApartMentImgList = query.ApartMentImgList,
                Area = query.Area,
                FloorName = query.FloorName,
                FloorPrice = query.FloorPrice,
                ImgList = query.ImgList,
                Onfoot = query.Onfoot,
                OpeningTime = query.OpeningTime,
                ShapanImgList = query.ShapanImgList,
                Tags = query.Tags,
                Video = query.Video,
                VTImg = query.VTImg,
            };
            return await Task.FromResult(HouseItem);
        }
    }
}
