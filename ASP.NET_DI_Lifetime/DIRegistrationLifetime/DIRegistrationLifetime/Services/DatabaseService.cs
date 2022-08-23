using DIRegistrationLifetime.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIRegistrationLifetime.Services
{
    public class DatabaseService 
    {
        private readonly ISingletonService _singleton;
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;

        public DatabaseService(ITransientService transientService,
                              ISingletonService singleton,
                              IScopedService scopedService)
        {
            _transientService = transientService;
            _singleton = singleton;
            _scopedService = scopedService;
        }

        public void Save()
        {
            Console.WriteLine("\n||||||| Database Service |||||||");

            Console.WriteLine($"Singleton UID:\t\t{_singleton.ServiceUniqueIdentifier}");
            Console.WriteLine($"Scoped UID:\t\t{_scopedService.ServiceUniqueIdentifier}");
            Console.WriteLine($"Transient UID:\t\t{_transientService.ServiceUniqueIdentifier}");
        }

    }
}
