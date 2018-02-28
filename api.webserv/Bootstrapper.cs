using System.Collections.Generic;
using System.Web;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using NLog;
using Nancy.Authentication.Stateless;
namespace api.webserv
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);
            var logger = container.Resolve<ILogger>();
            logger.Info("Applciation started at " + HttpRuntime.AppDomainAppPath);
           
        }

        protected override void RegisterInstances(TinyIoCContainer container, IEnumerable<InstanceRegistration> instanceRegistrations)
        {
            base.RegisterInstances(container, instanceRegistrations);
            container.Register(typeof(ILogger), (c, o) => LogManager.GetCurrentClassLogger());


        }

        protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {

            var logger = container.Resolve<ILogger>();
            base.RequestStartup(container, pipelines, context);
            logger.Debug("request has started at " + context.Request.Url);
            logger.Info("Applciation started at " + HttpRuntime.AppDomainAppPath);
            var configuration =
              new StatelessAuthenticationConfiguration(nancyContext =>
              {
                    //for now, we will pull the apiKey from the querystring,
                    //but you can pull it from any part of the NancyContext
                    var apiKey = (string)nancyContext.Request.Query.ApiKey.Value;

                  //get the user identity however you choose to (for now, using a static class/method)
                  return UserDatabase.GetUserFromApiKey(apiKey);
              });
            StatelessAuthentication.Enable(pipelines, configuration);
        }

        
        


    }
}