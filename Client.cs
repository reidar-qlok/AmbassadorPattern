using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbassadorPattern
{
    public class Client
    {
        private readonly IServiceAmbassador _ambassador;

        public Client(IServiceAmbassador ambassador)
        {
            _ambassador = ambassador;
        }

        public void DoSomething()
        {
            // Perform some actions
            _ambassador.DoSomething();
            // Continue with other actions
        }
    }
}
