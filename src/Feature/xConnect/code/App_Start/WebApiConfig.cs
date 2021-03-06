﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Helixbase.Feature.xConnect
{
    public class WebApiConfig
    {
        public void Process(Sitecore.Pipelines.PipelineArgs args)
        {
            var config = GlobalConfiguration.Configuration;
            var mvcRoutes = RouteTable.Routes;

            config.Routes.MapHttpRoute(
                name: "Feature.xConnect.AddContact",
                routeTemplate: "xConnect/Contact",
                defaults: new { controller = "XConnectApi", action = "AddContact" }
                );

            config.Routes.MapHttpRoute(
               name: "Feature.xConnect.AddGoogleInteraction",
               routeTemplate: "xConnect/GoogleInteraction",
               defaults: new { controller = "XConnectApi", action = "AddGoogleInteraction" }
               );

            config.Routes.MapHttpRoute(
               name: "Feature.xConnect.GetContact",
               routeTemplate: "xConnet/ContactInfo",
               defaults: new { controller = "XConnectApi", action = "GetContact" }
               );
        }
    }
}