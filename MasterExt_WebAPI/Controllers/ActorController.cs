using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.OData;
using MasterExt_DAL;
using MasterExt_Services;

namespace MasterExt_WebAPI.Controllers
{
    public class ActorController : ODataController
    {
        [Queryable]
         [Route("api/actors")]
        public IQueryable GetActors()
        {
            try
            {
                List<actor> actors = new ActorServices().GetActors();
                var list = new List<actor>();
                foreach (var actor in actors)
                {
                    list.Add(new actor()
                    {
                        actor_id = actor.actor_id,
                        first_name = actor.first_name,
                        last_name = actor.last_name
                    }
                        );
                }
                list = list.OrderBy(x => x.last_name).ThenBy(x => x.first_name).ToList();
                return list.AsQueryable();
            }
            catch (Exception ex)
            {
                //return BadRequest(ex.Message);
                throw;
            }
          
        }
    }
}
