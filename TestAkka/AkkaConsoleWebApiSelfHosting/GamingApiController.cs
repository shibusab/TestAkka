using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;
using TestAkka.DummyTestData;

namespace AkkaConsoleWebApiSelfHosting
{
    public class GamingApiController:ApiController
    {
        [HttpGet]
        public SomeData GetSomeData()
        {
            Console.WriteLine(Request.RequestUri);
            return new SomeDataQueryRepository().ReadFromCsvFile()[0];

        }

        [HttpGet]
        public List<SomeData> GetAllOfSomeData( SomeData data)
        {
            Console.WriteLine(Request.RequestUri);
            return new SomeDataQueryRepository().ReadFromCsvFile();

        }
    }
}
