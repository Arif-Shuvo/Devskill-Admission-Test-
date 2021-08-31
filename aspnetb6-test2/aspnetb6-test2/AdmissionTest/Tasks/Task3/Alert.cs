using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Alert
    {
        public event Action<string> Trigger;

        public void Raise(string message)
        {
            Trigger.Invoke(message);
        }
    }
}
