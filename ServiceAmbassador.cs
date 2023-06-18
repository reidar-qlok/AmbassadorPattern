using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbassadorPattern
{
    public class ServiceAmbassador : IServiceAmbassador
    {
        private readonly IService _service;

        public ServiceAmbassador(IService service)
        {
            _service = service;
        }

        public void DoSomething()
        {
            // Perform any necessary transformations or adaptations
            _service.DoSomething();
        }
    }
}
