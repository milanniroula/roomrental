using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.webserv.modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            System.Diagnostics.Debug.WriteLine("Its to debug a system");
            Get["/"] = p => "Hello from plural sight";

        }
    }
}