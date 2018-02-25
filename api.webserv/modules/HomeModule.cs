using Nancy;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.webserv.modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule(ILogger logger)
        {
            logger.Debug("Its module");
            Get["/"] = p => "Hello from plural sight";

        }
    }
}