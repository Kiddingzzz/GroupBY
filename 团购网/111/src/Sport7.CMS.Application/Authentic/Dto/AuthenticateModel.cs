using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sport7.CMS.Host.Controllers.Model
{
    public class AuthenticateModel
    {
        [Required]
        public string UserNameOrEmailAddress { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberClient { get; set; }
    }
}
