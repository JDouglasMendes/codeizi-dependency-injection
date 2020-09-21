using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Codeizi.DI.Functional.Test.Injectables.Singleton;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Codeizi.DI.Functional.Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        private readonly ISingletonContract _contract;
        private readonly SingletonIndividualService _serviceType;
        private readonly InjectableSingletonSingle _injectableSingletonSingle;

        public SingletonController(
            ISingletonContract contract,
            SingletonIndividualService serviceType,
            InjectableSingletonSingle injectableSingletonSingle)
        {
            _contract = contract ?? throw new ArgumentException(nameof(contract));
            _serviceType = serviceType ?? throw new ArgumentException(nameof(serviceType));
            _injectableSingletonSingle = injectableSingletonSingle ?? throw new ArgumentException(nameof(injectableSingletonSingle));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<string>
            {
                _contract.ToString(),
                _serviceType.ToString(),
                _injectableSingletonSingle.ToString() 
            });
        }
    }
}
