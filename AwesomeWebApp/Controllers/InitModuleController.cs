using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AwesomeWebApp.Controllers
{
    public class InitModuleController : Controller
    {

        // GET: CdnDemo
        public ActionResult Index(string task)
        {

            //default behaivor 
            if(string.IsNullOrEmpty(task))
            {
                int SleepTime = 10000;
                int threadID = System.Threading.Thread.CurrentThread.ManagedThreadId;

                Trace.TraceInformation("Thread: {0}\tbefore sleeping for {1} msec", threadID, SleepTime);
                System.Threading.Thread.Sleep(SleepTime);
                Trace.TraceInformation("Thread: {0}\tafter sleeping for {1} msec", threadID, SleepTime);

                //string.Format("thread {0} \t slept for {1} msec",threadID, SleepTime);
                ViewBag.message = string.Format("thread {0} \t slept for {1} msec", threadID, SleepTime);
            }

            ViewBag.test = "test";
            return View();
        }
    }
}