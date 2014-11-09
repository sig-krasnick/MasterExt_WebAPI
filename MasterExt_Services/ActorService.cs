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
        readonly sakilaEntities _repository = new sakilaEntities();
        public List<actor> GetActors()
        {
            List<actor> actors = _repository.actors.ToList();
            return actors;
        }

        public actor GetActor(int id)
        {
            return _repository.actors.FirstOrDefault(x => x.actor_id == id);
        }
    }
}
