using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterExt_DAL;

namespace MasterExt_Services
{
    public class ActorServices
    {
        readonly sakilaEntities repository = new sakilaEntities();
        public List<actor> GetActors()
        {
            List<actor> actors = repository.actors.ToList();
            return actors;
        }

        public actor GetActor(int id)
        {
            return repository.actors.FirstOrDefault(x => x.actor_id == id);
        }
    }
}
