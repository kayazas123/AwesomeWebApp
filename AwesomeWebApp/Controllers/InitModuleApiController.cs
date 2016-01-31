using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AwesomeWebApp.Controllers
{
    public class InitModuleApiController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            int SleepTime = 10000;

            Trace.TraceInformation("*** start fake app warm-up for {0}",SleepTime);
            System.Threading.Thread.Sleep(SleepTime);
            Trace.TraceInformation("*** fake app warm-up complete successfuly");

            return new string[] { "fake app warm-up complete successfuly", "Sleep time "+SleepTime };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"> 
        /// * -> upon any number return instance id;
        /// 1234 -> perform System.Exit() to 'crash the site'  </param>
        /// anythig else, just ignore
        /// <returns></returns>
        public IEnumerable<string> Get(int task)
        {
            if (task == 1234)
            {
                //crash the app
                System.Environment.Exit(0);
            }

            string instanceID = null;
            instanceID = Environment.GetEnvironmentVariable("WEBSITES_INSTANCE_ID") ?? "localhost" + Environment.MachineName; 


            return new string[] { "VM Instance ID", instanceID };
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}