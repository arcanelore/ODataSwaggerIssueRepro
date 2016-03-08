using Microsoft.OData.Edm;
using ODataTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace ODataTesting
{
    /// <summary>
    /// WebApi support class for doing route and handler registration
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// WebApi route and handler registration
        /// </summary>
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //Make Routes Case Insensitive
            config.EnableCaseInsensitive(true);
            config.EnableUnqualifiedNameCall(true);

            // Base V1 OData Route
            var odataRoute = config.MapODataServiceRoute(
                routeName: "ODataRouteV1",
                routePrefix: "odata/v1/{testid}",
                model: GetModel());
        }

        private static IEdmModel GetModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();

            builder.EntitySet<TestModel>("TestModel");
            return builder.GetEdmModel();
        }
    }
}
