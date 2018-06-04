using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAkka.DummyTestData;

namespace TestAkka.Messages
{
    public class SomeDataMessage
    {
        public List<SomeData> Data { get; }

        public SomeDataMessage(List<SomeData> data)
        {
            Data = data;
        }

        public SomeDataMessage()
        {
        }
    }
}
