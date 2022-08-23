using DIRegistrationLifetime.Services;
using DIRegistrationLifetime.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIRegistrationLifetime.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        private readonly ISingletonService _singleton;
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;
        private readonly DatabaseService _databaseService;


        public TestController(ITransientService transientService,
                              ISingletonService singleton,
                              IScopedService scopedService, DatabaseService databaseService)
        {
            _transientService = transientService;
            _singleton = singleton;
            _scopedService = scopedService;
            _databaseService = databaseService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            Console.WriteLine("\n||||||| Test Controller |||||||");

            Console.WriteLine($"Singleton UID:\t\t{_singleton.ServiceUniqueIdentifier}");
            Console.WriteLine($"Scoped UID:\t\t{_scopedService.ServiceUniqueIdentifier}");
            Console.WriteLine($"Transient UID:\t\t{_transientService.ServiceUniqueIdentifier}");

            _databaseService.Save();

            return Ok();
        }


    }
}
