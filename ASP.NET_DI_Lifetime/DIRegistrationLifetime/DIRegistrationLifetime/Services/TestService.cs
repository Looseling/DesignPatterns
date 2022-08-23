using DIRegistrationLifetime.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIRegistrationLifetime.Services
{
    public class TestService : ISingletonService, IScopedService, ITransientService
    {
        public string ServiceUniqueIdentifier { get; } = Guid.NewGuid().ToString(); 
    }
}
