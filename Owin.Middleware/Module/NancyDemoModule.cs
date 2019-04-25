using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.Owin;

namespace Owin.Middleware.Module
{
    public class NancyDemoModule : NancyModule 
    {
        public NancyDemoModule()
        {
            Get["/nancy"] = o =>
            {
                var env = Context.GetOwinEnvironment();
                return "Hello from nancy! You requested: " + env["owin.RequestPath"];
            };
        }
    }
}