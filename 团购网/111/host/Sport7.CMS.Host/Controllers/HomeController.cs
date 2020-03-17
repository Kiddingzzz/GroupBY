using Microsoft.AspNetCore.Mvc;
using Sport7.AspNetCore.Mvc;

namespace Sport7.CMS.Host.Controllers
{
    public class HomeController : Sport7Controller
    {
        public ActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}

