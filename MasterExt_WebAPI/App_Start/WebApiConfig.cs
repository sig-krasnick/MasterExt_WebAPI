using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;
using MasterExt_DAL;

namespace MasterExt_WebAPI
{
    public static class WebApiConfig
    {
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

            config.AddODataQueryFilter();
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<customer>("customers");
            builder.EntitySet<address>("addresses");
            builder.EntitySet<city>("cities");
            builder.EntitySet<country>("countries");
            builder.EntitySet<staff>("staffs");
            builder.EntitySet<store>("stores");
            builder.EntitySet<payment>("payments");
            builder.EntitySet<rental>("rentals");
            builder.EntitySet<inventory>("inventories");
            builder.EntitySet<film>("films");
            builder.EntitySet<film_actor>("film_actors");
            builder.EntitySet<film_category>("film_categorys");
            builder.EntitySet<film_list>("film_lists");
            builder.EntitySet<film_text>("film_texts");
            builder.EntitySet<actor>("actors");
            builder.EntitySet<language>("languages");
            builder.EntitySet<Group>("groups");
            builder.EntitySet<customer_list>("customer_lists");
            builder.EntitySet<staff_list>("staff_lists");
            builder.EntitySet<category>("categories");

            config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
        }
    }
}
