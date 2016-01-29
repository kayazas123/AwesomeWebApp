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
            ViewBag.LocalCacheFlag = true;

            string LocalCacheFlag = null;

            if ((LocalCacheFlag = WebConfigurationManager.AppSettings["WEBSITE_LOCAL_CACHE_OPTION"]) == null)
            { ViewBag.LocalCacheFlag = false; }

            string value = null;
            if((value=System.Environment.GetEnvironmentVariable("WEBSITE_LOCALCACHE_READY")) == null)
            { ViewBag.LocalCacheReady = false; }

            

            return View();
        }
    }
}