using Sport7.CMS.Authentic.Dto;
using Sport7.CMS.Host.Controllers.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport7.CMS.Authentic
{
    public interface IUserAppService
    {
        Task<UserInformationOutput> getUserInfor(Guid Id);

        /// <summary>
        /// 用户登录验证
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<AuthenticateResultModel> Authentic(AuthenticateModel model);

        /// <summary>
        /// 新增一条用户
        /// </summary>
        Task AddUserInfer(UserAllInput input);
    }
}
