using System.Configuration;
using System.Web.Configuration;
using System.Web.Mvc;


namespace AwesomeWebApp.Controllers
{
    public class LocalCacheController : Controller
    {
        // GET: CdnDemo
        public ActionResult Index()
        {
            ViewBag.LocalCacheReady = true;

            string value = null;
            if((value=System.Environment.GetEnvironmentVariable("WEBSITE_LOCALCACHE_READY")) == null)
            { ViewBag.LocalCacheReady = false; }

            return View();
        }
    }
}