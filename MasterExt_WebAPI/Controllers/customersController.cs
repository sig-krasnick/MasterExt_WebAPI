using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using MasterExt_DAL;
using Microsoft.Data.OData;

namespace MasterExt_WebAPI.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using MasterExt_DAL;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<customer>("customers");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class customersController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/customers
        [EnableQuery]
        public IQueryable<customer> Getcustomers(ODataQueryOptions<customer> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                throw;
                //return BadRequest(ex.Message);
            }
            return new sakilaEntities().customers.AsQueryable();

//           return Ok<IQueryable>(customers);
 //           return StatusCode(HttpStatusCode.NotImplemented);
        }

        // GET: odata/customers(5)
        public IHttpActionResult Getcustomer([FromODataUri] int key, ODataQueryOptions<customer> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<customer>(customer);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/customers(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<customer> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(customer);

            // TODO: Save the patched entity.

            // return Updated(customer);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/customers
        public IHttpActionResult Post(customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(customer);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/customers(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<customer> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(customer);

            // TODO: Save the patched entity.

            // return Updated(customer);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/customers(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }
    }
}
