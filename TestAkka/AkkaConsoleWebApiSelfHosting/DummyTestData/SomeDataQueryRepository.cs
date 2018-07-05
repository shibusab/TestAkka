using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAkka.DummyTestData
{
    public class SomeDataQueryRepository
    {
        public List<SomeData> ReadFromCsvFile()
        {
            List<SomeData> values = File.ReadAllLines(@"DummyTestData\SomeData.csv")
                                           .Skip(1)
                                           .Select(v => SomeData.FromCsv(v))
                                           .ToList();
            return values;
        }
    }
}
