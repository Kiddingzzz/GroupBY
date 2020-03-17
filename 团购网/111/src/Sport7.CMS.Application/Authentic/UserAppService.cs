using Sport7.Application.Services;
using Sport7.CMS.Authentic.Dto;
using Sport7.CMS.Host.Controllers.Model;
using Sport7.CMS.TokenAuthentic;
using Sport7.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sport7.CMS.Authentic.Dto.UserAllInput;

namespace Sport7.CMS.Authentic
{
    public class UserAppService : ApplicationService,IUserAppService
    {
        public readonly IRepository<UserSession, Guid> _userRepository;
        public readonly IRepository<UserInfer, Guid> _userInfoRepository;
        public readonly IRepository<DanganInfer, Guid> _danganRepository;

        public UserAppService(
            IRepository<UserSession, Guid> userRepository,
            IRepository<UserInfer, Guid> userInfoRepository,
            IRepository<DanganInfer, Guid> danganRepository
            )
        {
            _userRepository = userRepository;
            _userInfoRepository = userInfoRepository;
            _danganRepository = danganRepository;
        }

        /// <summary>
        /// 用户登录验证
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<AuthenticateResultModel> Authentic(AuthenticateModel model)
        {
            var loginResult = _userRepository.FirstOrDefault(a => a.UserName == model.UserNameOrEmailAddress || a.Password == model.Password);
            if (loginResult == null)
                throw new UserFriendlyException($"您输入的密码错误，请检查。");

            return new AuthenticateResultModel
            {
                UserId = loginResult.Id,
                UserName = loginResult.UserName,
                Tenant = "万盛区体育馆",
                Avator = "./assets/tmp/img/avatar.jpg",
            };
        }

        /// <summary>
        /// 获取用户信息和部门及职位
        /// </summary>
        public async Task<UserInformationOutput> getUserInfor(Guid Id)
        {
            var query = from a in _userRepository
                        where a.Id == Id
                        select new UserInformationOutput
                        {
                            EmailAddress = a.EmailAddress,
                            WeexId = a.WeexId,
                            WeexAvtor = a.WeexAvtor,
                            WeexNumber = a.WeexNumber,
                            ManagerMent = a.ManagerMent,
                            Izhiwei = a.Izhiwei,
                            UserName = a.UserName,
                            WeexUserName = a.WeexUserName,
                            TenantId = a.TenantId,
                        };
            return await Task.FromResult(query.FirstOrDefault());
        }

        /// <summary>
        /// 新增一条用户
        /// </summary>
        public async Task AddUserInfer(UserAllInput input)
        {
            var UserDetail = ObjectMapper.Map<UserAllInput, UserSession>(input);
            UserDetail.Id = GuidGenerator.Create();

            var UserInfo = ObjectMapper.Map<Userins, UserInfer>(input.userins);
            UserInfo.Id = GuidGenerator.Create();
            await _userInfoRepository.InsertAsync(UserInfo);

            var Dangan = ObjectMapper.Map<Danganins, DanganInfer>(input.danganins);
            Dangan.Id = GuidGenerator.Create();
            await _danganRepository.InsertAsync(Dangan);

            await _userRepository.InsertAsync(UserDetail);
        }
    }
}
