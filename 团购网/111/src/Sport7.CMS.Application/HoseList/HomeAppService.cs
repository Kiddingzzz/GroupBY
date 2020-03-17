using Sport7.Application.Services;
using Sport7.CMS.Home;
using Sport7.CMS.HoseList.Dto;
using Sport7.Domain.Repositories;
using Sport7.ObjectMapping;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Sport7.Application.Dtos;

namespace Sport7.CMS.HoseList
{
    public class HomeAppService : ApplicationService, IHomeAppService
    {
        public readonly IRepository<HomeList, Guid> _homeListRepository;
        public readonly IRepository<HouseInformation, Guid> _houseInformationRepository;
        public readonly IRepository<OwnerInfor, Guid> _ownerInforRepository;
        public readonly IRepository<UpdateHouse, Guid> _updateHouses;


        public HomeAppService(
            IRepository<HomeList, Guid> homeListRepository,
            IRepository<HouseInformation, Guid> houseInformationRepository,
            IRepository<OwnerInfor, Guid> ownerInforRepository,
            IRepository<UpdateHouse, Guid> updateHouses
            )
        {
            _homeListRepository = homeListRepository;
            _houseInformationRepository = houseInformationRepository;
            _ownerInforRepository = ownerInforRepository;
            _updateHouses = updateHouses;
        }

        /// <summary>
        ///新建房源
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task AddHomeDetail(HouseInput input)
        {
            var houseDetail = ObjectMapper.Map<HouseInput, HomeList>(input);
            houseDetail.Id = GuidGenerator.Create();
            //houseDetail.Housecode = query.Housecode - 0 + 1;

            var houseInf = ObjectMapper.Map<HomeInf, HouseInformation>(input.homeInfs);
            houseInf.Id = GuidGenerator.Create();
            houseInf.HomeListId = houseDetail.Id;
            if(houseInf.Price!=0)
                houseInf.CenterPrice = houseInf.Price / houseDetail.BuildArea;
            if (houseInf.RecentMoney != 0)
                houseInf.MonthRecentMoney = houseInf.RecentMoney / 30;
            await _houseInformationRepository.InsertAsync(houseInf);

            var owenerInf = ObjectMapper.Map<OwnerInf, OwnerInfor>(input.OwnerInfs);
            owenerInf.Id = GuidGenerator.Create();
            owenerInf.HomeListId = houseDetail.Id;
            await _ownerInforRepository.InsertAsync(owenerInf);

            await _homeListRepository.InsertAsync(houseDetail);
        }

        /// <summary>
        /// 修改房源
        /// </summary>
        /// <param name="input"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task ModifyHomeDetail(HouseInput input,Guid id)
        {
            var mhome = _homeListRepository.FirstOrDefault(a => a.Id == id);
            var mhouseInfo = _houseInformationRepository.FirstOrDefault(a => a.HomeListId == id);
            var mOwner = _ownerInforRepository.FirstOrDefault(a => a.HomeListId == id);
            var houseDetail = ObjectMapper.Map<HouseInput, HomeList>(input,mhome);
            //houseDetail.Housecode = query.Housecode - 0 + 1;

            var houseInf = ObjectMapper.Map<HomeInf, HouseInformation>(input.homeInfs, mhouseInfo);
            if (houseInf.Price != 0)
                houseInf.CenterPrice = houseInf.Price / mhome.BuildArea;
            if (houseInf.RecentMoney != 0)
                houseInf.MonthRecentMoney = houseInf.RecentMoney / 30;
            await _houseInformationRepository.UpdateAsync(houseInf);

            var owenerInf = ObjectMapper.Map<OwnerInf, OwnerInfor>(input.OwnerInfs,mOwner);
            await _ownerInforRepository.UpdateAsync(owenerInf);

            await _homeListRepository.UpdateAsync(houseDetail);
        }
        /// <summary>
        /// 获取跟进信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ListResultDto<updateHouseOutput>> GetUpdate(Guid id)
        {
            var query = from a in _updateHouses where a.HomeListId == id
                        join b in _homeListRepository on a.HomeListId equals b.Id
                        join c in _houseInformationRepository on b.Id equals c.HomeListId
                        select new updateHouseOutput
                        {
                            Comment = a.Comment,
                            CommentTime = a.CreationTime,
                            JXWPerson = b.JXWPerson,
                        };
            return new ListResultDto<updateHouseOutput>(query.ToList());
        }

        /// <summary>
        /// 获取客户以及房源信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<UpdateInfoCustomerOutupt> GetUpdateInfo(Guid id)
        {
            var updateInfor = _updateHouses.FirstOrDefault(t => t.HomeListId == id);
            if (updateInfor == null)
            {
                var query = from a in _homeListRepository
                            where a.Id == id
                            join b in _houseInformationRepository on a.Id equals b.HomeListId
                            join c in _ownerInforRepository on a.Id equals c.HomeListId
                            //join d in _updateHouses on a.Id equals d.HomeListId
                            select new UpdateInfoCustomerOutupt
                            {
                                BuildName = a.BuildName,
                                BuildUnit = a.BuildUnit,
                                BuildNumber = a.BuildNumber,
                                BuildArea = a.BuildArea,
                                CoverArea = a.CoverArea,
                                Fang = a.Fang,
                                OwnerName = c.OwnerName,
                                phoneNumber1 = c.phoneNumber1,
                                phoneNumber2 = c.phoneNumber2,
                                Sex = c.Sex,
                                HouseStay = b.HouseStay,
                                Price = b.Price,
                                BrightSpot = a.BrightSpot,
                                creationTime = a.CreationTime,
                                LoginName = b.LoginName,
                                Orientation = a.Orientation,
                                Renovation = a.Renovation,
                                Affiliated = a.Affiliated,
                                BuildFoolr = a.BuildFoolr,
                                Buydate = b.Buydate,
                                CenterPrice = b.CenterPrice,
                                chanquan = b.chanquan,
                                Chufang = a.Chufang,
                                DiyaStatu = b.DiyaStatu,
                                Elevator = a.Elevator,
                                getHomer = b.getHomer,
                                GetName = b.GetName,
                                HouseStructure = a.HouseStructure,
                                JXWPerson = a.JXWPerson,
                                //LastTime = d.CreationTime,
                                LookWay = b.LookWay,
                                Note = b.Note,
                                Paymethod = b.Paymethod,
                                PropertyFee = a.PropertyFee,
                                RecentMoney = b.RecentMoney,
                                Reprice = b.Reprice,
                                Ting = a.Ting,
                                Wei = a.Wei,
                                Yangtai = a.Yangtai,
                                years = b.years,
                                HouseID = b.HouseID,
                                KeyCode = b.KeyCode,
                                AffiliatedArea = a.AffiliatedArea,
                                HouseStatu = a.HouseStatu,
                                Pianqu = a.Pianqu,
                                Purpose = a.Purpose,
                                Address = c.Address,
                                FloorPrice = b.FloorPrice,
                                IentityCard = c.IentityCard,
                            };
                return await Task.FromResult(query.FirstOrDefault());
            }
            else {
                var query = from a in _homeListRepository
                            where a.Id == id
                            join b in _houseInformationRepository on a.Id equals b.HomeListId
                            join c in _ownerInforRepository on a.Id equals c.HomeListId
                            join d in _updateHouses.OrderByDescending(t=>t.CreationTime) on a.Id equals d.HomeListId
                            select new UpdateInfoCustomerOutupt
                            {
                                BuildName = a.BuildName,
                                BuildUnit = a.BuildUnit,
                                BuildNumber = a.BuildNumber,
                                BuildArea = a.BuildArea,
                                CoverArea = a.CoverArea,
                                Fang = a.Fang,
                                OwnerName = c.OwnerName,
                                phoneNumber1 = c.phoneNumber1,
                                phoneNumber2 = c.phoneNumber2,
                                Sex = c.Sex,
                                HouseStay = b.HouseStay,
                                Price = b.Price,
                                BrightSpot = a.BrightSpot,
                                creationTime = a.CreationTime,
                                LoginName = b.LoginName,
                                Orientation = a.Orientation,
                                Renovation = a.Renovation,
                                Affiliated = a.Affiliated,
                                BuildFoolr = a.BuildFoolr,
                                Buydate = b.Buydate,
                                CenterPrice = b.CenterPrice,
                                chanquan = b.chanquan,
                                Chufang = a.Chufang,
                                DiyaStatu = b.DiyaStatu,
                                Elevator = a.Elevator,
                                getHomer = b.getHomer,
                                GetName = b.GetName,
                                HouseStructure = a.HouseStructure,
                                JXWPerson = a.JXWPerson,
                                LastTime = d.CreationTime,
                                LookWay = b.LookWay,
                                Note = b.Note,
                                Paymethod = b.Paymethod,
                                PropertyFee = a.PropertyFee,
                                RecentMoney = b.RecentMoney,
                                Reprice = b.Reprice,
                                Ting = a.Ting,
                                Wei = a.Wei,
                                Yangtai = a.Yangtai,
                                years = b.years,
                                HouseID = b.HouseID,
                                KeyCode = b.KeyCode,
                                AffiliatedArea = a.AffiliatedArea,
                                HouseStatu = a.HouseStatu,
                                Pianqu = a.Pianqu,
                                Purpose = a.Purpose,
                                Address = c.Address,
                                FloorPrice = b.FloorPrice,
                                IentityCard = c.IentityCard,
                            };
                return await Task.FromResult(query.FirstOrDefault());
            }

        }

        /// <summary>
        ///  新建跟进信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task AddUpdateTitle(UpdateInput input)
        {
            var title = new UpdateHouse()
            {
                Id = GuidGenerator.Create(),
                HomeListId = input.HouseListId,
                Comment = input.Comment,
                //UpdatePerson = input.UpdatePerson
            };
            await _updateHouses.InsertAsync(title);
        }
        /// <summary>
        ///获取售房源列表
        /// </summary>
        /// <param name="output"></param>
        /// <returns></returns>
        public async Task<ListResultDto<HouseOutput>> GetSaleBuildList(buildInput input)
        {
            var query = from a in _homeListRepository.Where(a => a.HouseStatu == "售")
                        join b in _houseInformationRepository on a.Id equals b.HomeListId
                        join c in _ownerInforRepository on a.Id equals c.HomeListId
                        select new HouseOutput
                        {
                            Id = a.Id,
                            Housecode = a.Housecode,
                            HouseStatu = a.HouseStatu,
                            Pianqu = a.Pianqu,
                            BuildName = a.BuildName,
                            BuildUnit = a.BuildUnit,
                            BuildNumber = a.BuildNumber,
                            BuildFoolr = a.BuildFoolr,
                            BuildArea = a.BuildArea,
                            Orientation = a.Orientation,
                            Renovation = a.Renovation,
                            Purpose = a.Purpose,
                            Price = b.Price,
                            RecentMoney = b.RecentMoney,
                            MonthRecentMoney = b.MonthRecentMoney,
                            LoginName = b.LoginName,
                            JXWPerson = a.JXWPerson,
                            OwnerName = c.OwnerName,
                            phoneNumber1 = c.phoneNumber1,
                        };
            query = query.WhereIf(!input.SearchName.IsNullOrEmpty(), 
                t => t.LoginName.Contains(input.SearchName) || 
                t.BuildName.Contains(input.SearchName) || 
                t.Pianqu.Contains(input.SearchName) ||
                t.OwnerName.Contains(input.SearchName)||
                t.phoneNumber1.Contains(input.SearchName)
                );
            return new ListResultDto<HouseOutput>(query.ToList());
        }

        /// <summary>
        ///获取租房源列表
        /// </summary>
        /// <param name="output"></param>
        /// <returns></returns>
        public Task<PagedResultDto<HouseOutput>> GetBorrowBuildList(buildInput input)
        {
            var query = from a in _homeListRepository.Where(a => a.HouseStatu == "租")
                        join b in _houseInformationRepository on a.Id equals b.HomeListId
                        join c in _ownerInforRepository on a.Id equals c.HomeListId
                        select new HouseOutput
                        {
                            Id = a.Id,
                            Housecode = a.Housecode,
                            HouseStatu = a.HouseStatu,
                            Pianqu = a.Pianqu,
                            BuildName = a.BuildName,
                            BuildUnit = a.BuildUnit,
                            BuildNumber = a.BuildNumber,
                            BuildFoolr = a.BuildFoolr,
                            BuildArea = a.BuildArea,
                            Orientation = a.Orientation,
                            Renovation = a.Renovation,
                            Purpose = a.Purpose,
                            Price = b.Price,
                            RecentMoney = b.RecentMoney,
                            MonthRecentMoney = b.MonthRecentMoney,
                            LoginName = b.LoginName,
                            JXWPerson = a.JXWPerson,
                        };
            query = query.WhereIf(!input.SearchName.IsNullOrEmpty(), t => t.BuildName.Contains(input.SearchName))
                         .WhereIf(!input.SearchName.IsNullOrEmpty(), t => t.LoginName.Contains(input.SearchName))
                         .WhereIf(!input.SearchName.IsNullOrEmpty(), t => t.Pianqu.Contains(input.SearchName));
            var result = query.OrderByDescending(t => t.CreationTime).PageBy(input).ToList();
            return Task.FromResult(new PagedResultDto<HouseOutput>(query.Count(), result));
        }
    }
}
