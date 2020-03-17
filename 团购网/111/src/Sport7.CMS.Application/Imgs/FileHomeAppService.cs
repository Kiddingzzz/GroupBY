using Microsoft.AspNetCore.Http;
using Sport7.Application.Dtos;
using Sport7.Application.Services;
using Sport7.CMS.Imgs.Dto;
using Sport7.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport7.CMS.Imgs
{
    public class FileHomeAppService : ApplicationService, IFileHomeAppService
    {
        private readonly IRepository<UploadImg, Guid> _imgsrepository;

        public FileHomeAppService(
            IRepository<UploadImg, Guid> imgsrepository
            )
        {
            _imgsrepository = imgsrepository;
        }

        /// <summary>
        /// 存储图片
        /// </summary>
        public async Task AddPicture(ImgInput input)
        {
            var PictureItem = ObjectMapper.Map<ImgInput,UploadImg>(input);
            PictureItem.Id = GuidGenerator.Create();
            await _imgsrepository.InsertAsync(PictureItem);
        }

        /// <summary>
        /// 获取图片列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ListResultDto<ImglistOutput>> GetPicture(Guid id)
        {
            var query = from a in _imgsrepository
                        where a.HouseId == id
                        select new ImglistOutput
                        {
                            Status = a.Status,
                            Name = a.Name,
                            Uid = a.Uid,
                            Url = a.Url
                        };
            return new ListResultDto<ImglistOutput>(query.ToList());
        }
    }
}
