using Sport7.CMS.HomeDictionarys.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport7.CMS.HomeDictionary
{
    public interface IHomeDictionaryAppService
    {
        /// <summary>
        /// 新增楼盘字典(有单元)
        /// </summary>
        /// <returns></returns>
        Task AddBuild(BuildDictionaryInput input);

        /// <summary>
        /// 创建楼盘字典(无单元)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task AddBuildNounit(BuildDictionaryNoUnitInput input);

        /// <summary>
        /// 删除楼盘字典(有单元)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteHomeBuild(Guid id);

        /// <summary>
        /// 删除楼盘字典(无单元)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteHomeBuildNoUnit(Guid id);


    }
}
