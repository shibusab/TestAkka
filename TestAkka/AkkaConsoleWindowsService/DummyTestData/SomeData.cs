using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAkka.DummyTestData
{
    public class SomeData
    {
        public string GEO_id { get; set; }
        public string GEO_id2 { get; set; }
        public string GEO_displaylabel { get; set; }
        public string NAICS_id { get; set; }
        public string NAICS_display_label { get; set; }
        public string YEAR_id { get; set; }
        public string RCPTOTI { get; set; }
        public string ESTAB { get; set; }
        public string ECTGE20 { get; set; }
        public string EMP { get; set; }
        public string PAYANN { get; set; }
        public string EMPAVPW { get; set; }
        public string HOURS { get; set; }
        public string PAYANPW { get; set; }
        public string CSTMTOT { get; set; }
        public string RCPTOT { get; set; }
        public string VALADD { get; set; }
        public string CEXTOT { get; set; }

        public static SomeData FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            SomeData someData = new SomeData();
            someData.GEO_id = Convert.ToString(values[0]);
            someData.GEO_id2 = Convert.ToString(values[1]);
            someData.GEO_displaylabel = Convert.ToString(values[2]);
            someData.NAICS_id = Convert.ToString(values[3]);
            someData.NAICS_display_label = Convert.ToString(values[4]);
            someData.YEAR_id = Convert.ToString(values[5]);
            someData.RCPTOTI = Convert.ToString(values[6]);
            someData.ESTAB = Convert.ToString(values[7]);
            someData.ECTGE20 = Convert.ToString(values[8]);
            someData.EMP = Convert.ToString(values[9]);
            someData.PAYANN = Convert.ToString(values[10]);
            someData.EMPAVPW = Convert.ToString(values[11]);
            someData.HOURS = Convert.ToString(values[12]);
            someData.PAYANPW = Convert.ToString(values[13]);
            someData.CSTMTOT = Convert.ToString(values[14]);
            someData.RCPTOT = Convert.ToString(values[15]);
            someData.VALADD = Convert.ToString(values[16]);
            someData.CEXTOT = Convert.ToString(values[17]);
            return someData;
        }
    }
}
//    Geographic identifier code Id2 Geographic area name	2012 NAICS code Meaning of 2012 NAICS code  Year Percent estimated Number of establishments    Establishments with 20 employees or more Number of employees Annual payroll($1,000) Production workers average for year Production workers annual hours(1,000) Production workers annual wages($1,000)    Total cost of materials($1,000)    Total value of shipments and receipts for services($1,000) Value added($1,000)    Total capital expenditures($1,000)
