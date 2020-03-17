using Sport7.Application.Services;
using Sport7.CMS.HomeDictionary;
using Sport7.CMS.HomeDictionarys.Dto;
using Sport7.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport7.CMS.HomeDictionarys
{
    public class HomeDictionaryAppService : ApplicationService, IHomeDictionaryAppService
    {
        public readonly IRepository<HomeDictionaryss, Guid> _homeDictionaryRepository;
        public readonly IRepository<HomeDong, Guid> _homeDongRepository;
        public readonly IRepository<HomeUnit, Guid> _homeUnitRepository;
        public readonly IRepository<HomeLayer, Guid> _homeLyaersRepository;
        public readonly IRepository<HomeNoUnit, Guid> _homeNoUnitRepository;

        public HomeDictionaryAppService(
            IRepository<HomeDictionaryss, Guid> homeDictionaryRepository,
            IRepository<HomeDong, Guid> homeDongRepository,
            IRepository<HomeUnit, Guid> homeUnitRepository,
            IRepository<HomeLayer, Guid> homeLyaersRepository,
            IRepository<HomeNoUnit, Guid> homeNoUnitRepository
            )
        {
            _homeDictionaryRepository = homeDictionaryRepository;
            _homeDongRepository = homeDongRepository;
            _homeUnitRepository = homeUnitRepository;
            _homeLyaersRepository = homeLyaersRepository;
            _homeNoUnitRepository = homeNoUnitRepository;
        }

        /// <summary>
        /// 新增楼盘字典(有单元)
        /// </summary>
        /// <returns></returns>
        public async Task AddBuild(BuildDictionaryInput input)
        {
            var itemDongNumber = ObjectMapper.Map<BuildDictionaryInput, HomeDictionaryss>(input);
            itemDongNumber.Id = GuidGenerator.Create();

            foreach (var item in input.dongNumbers)
            {
                var itemDongshu = ObjectMapper.Map<DongNumber, HomeDong>(item);
                itemDongshu.Id = GuidGenerator.Create();
                itemDongshu.HomeDictinaryId = itemDongNumber.Id;

                await _homeDongRepository.InsertAsync(itemDongshu);

                foreach (var itemLayer in item.homeUnits)
                {
                    var itemlayer = ObjectMapper.Map<HomeUnits, HomeUnit>(itemLayer);
                    itemlayer.Id = GuidGenerator.Create();
                    itemlayer.HomeDongId = itemDongshu.Id;
                    itemlayer.HomeDictinaryId = itemDongNumber.Id;

                    await _homeUnitRepository.InsertAsync(itemlayer);
                }
            }

            await _homeDictionaryRepository.InsertAsync(itemDongNumber);
        }
        
        /// <summary>
        /// 创建楼盘字典(无单元)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task AddBuildNounit(BuildDictionaryNoUnitInput input)
        {
            var itemDongNumber = ObjectMapper.Map<BuildDictionaryNoUnitInput, HomeDictionaryss>(input);
            itemDongNumber.Id = GuidGenerator.Create();

            foreach (var item in input.dongs)
            {
                var itemDongshu = ObjectMapper.Map<DongNumeberlist, HomeDong>(item);
                itemDongshu.Id = GuidGenerator.Create();
                itemDongshu.HomeDictinaryId = itemDongNumber.Id;

                await _homeDongRepository.InsertAsync(itemDongshu);

                foreach (var itemUnit in item.homelist)
                {
                    var itemUnits = ObjectMapper.Map<HomeUnitlist, HomeNoUnit>(itemUnit);
                    itemUnits.Id = GuidGenerator.Create();
                    itemUnits.HomeDongId = itemDongshu.Id;
                    itemUnits.HomeDictinaryId = itemDongNumber.Id;
                    itemUnits.IsUnit = false;

                    await _homeNoUnitRepository.InsertAsync(itemUnits);
                }
            }
            await _homeDictionaryRepository.InsertAsync(itemDongNumber); 
        }

        /// <summary>
        /// 删除楼盘字典(有单元)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteHomeBuild(Guid id)
        {
            var item = await _homeDictionaryRepository.FindAsync(id);
            var itemList = _homeDongRepository.Where(x => x.HomeDictinaryId == item.Id);
            var itemUnit = _homeUnitRepository.Where(x => x.HomeDictinaryId == item.Id);
            foreach (var query in itemList)
            {
                foreach (var queryList in itemUnit)
                {
                    await _homeUnitRepository.DeleteAsync(queryList);
                }
                await _homeDongRepository.DeleteAsync(query);
            }
            await _homeDictionaryRepository.DeleteAsync(item);
        }

        /// <summary>
        /// 删除楼盘字典(无单元)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteHomeBuildNoUnit(Guid id)
        {
            var item = await _homeDictionaryRepository.FindAsync(id);
            var itemList = _homeDongRepository.Where(x => x.HomeDictinaryId == item.Id);
            var itemUnit = _homeNoUnitRepository.Where(x => x.HomeDictinaryId == item.Id);
            foreach (var query in itemList)
            {
                foreach (var queryList in itemUnit)
                {
                    await _homeNoUnitRepository.DeleteAsync(queryList);
                }
                await _homeDongRepository.DeleteAsync(query);
            }
            await _homeDictionaryRepository.DeleteAsync(item);
        }
    }
}
