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
            //return instnace ID
            else if(task == "1")
            {
                string instanceID = null;
                instanceID = Environment.GetEnvironmentVariable("WEBSITE_INSTANCE_ID") ?? "localhost -" + Environment.MachineName;

                ViewBag.message = instanceID;
            }
            // crash the app
            else if(task =="1234")
            {
                System.Environment.Exit(0);
            }

            ViewBag.test = "test";
            return View();
        }
    }
}