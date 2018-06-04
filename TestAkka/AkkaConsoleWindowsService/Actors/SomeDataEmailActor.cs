using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAkka.DummyTestData;
using TestAkka.Messages;

namespace TestAkka.Actors
{
    public class SomeDataEmailActor:ReceiveActor
    {
        public SomeDataEmailActor()
        {
            Receive<SomeDataMessage>(emailData => SaveAndEmail());
        }

        private void SaveAndEmail()
        {
            var emailData = new SomeDataQueryRepository().ReadFromCsvFile();

            Console.WriteLine(string.Format("Received {0} lines ", emailData.Count));
        }
    }
}
