using Sport7.Application.Dtos;
using Sport7.CMS.Imgs.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport7.CMS.Imgs
{
    public interface IFileHomeAppService
    {
        /// <summary>
        /// 存储图片
        /// </summary>
        Task AddPicture(ImgInput input);

        /// <summary>
        /// 获取图片列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ListResultDto<ImglistOutput>> GetPicture(Guid id);
    }
}
