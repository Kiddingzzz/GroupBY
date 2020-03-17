using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sport7.CMS.Host.Controllers.Model
{
    public class AuthenticateResultModel
    {
        public int ExpireInSeconds { get; set; }

        public Guid UserId { get; set; }

        public string UserName { get; set; }

        public string Tenant { get; set; }

        public string Avator { get; set; }
    }
}
