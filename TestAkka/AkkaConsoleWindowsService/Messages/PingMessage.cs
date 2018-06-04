using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAkka.Messages
{
    public class PingMessage
    {
        public string Message { get; }

        public PingMessage(string message)
        {
            Message = message;
        }
    }
}
