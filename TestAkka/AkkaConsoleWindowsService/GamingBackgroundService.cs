using Akka.Actor;
using Akka.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAkka.Actors;
using TestAkka.Messages;

namespace TestAkka
{
    public class GamingBackgroundService
    {
        ActorSystem gamingSystem=null;
        public void Start()
        {
            var gamingSystem = ActorSystem.Create("GamingSystem");
            PullSavedAndActiveActors(gamingSystem);
        }

        public void Stop()
        {
            gamingSystem.Terminate();
        }


        private void PullSavedAndActiveActors(ActorSystem actorSystem)
        {
            if(null == actorSystem)
            {
                throw new NullReferenceException("Missing Gaming System");
            }
            var someDataEmailActor = actorSystem.ActorOf<SomeDataEmailActor>();
            actorSystem.Scheduler.ScheduleTellRepeatedly(TimeSpan.FromSeconds(0), TimeSpan.FromSeconds(5), someDataEmailActor, new SomeDataMessage(), someDataEmailActor);
            // var pingActor = actorSystem.ActorOf<PingActor>();
            //actorSystem.Scheduler.ScheduleTellRepeatedly(TimeSpan.FromSeconds(0), TimeSpan.FromSeconds(5), pingActor, new PingMessage(DateTime.Now.ToString() + "\n"), pingActor);
        }
    }
}
