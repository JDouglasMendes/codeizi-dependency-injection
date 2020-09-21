using Codeizi.DI.Functional.Test.Injectables.Transient;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Codeizi.DI.Functional.Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransientController : ControllerBase
    {
        private readonly ITransientContract _contract;
        private readonly TransientIndividualService _serviceType;
        private readonly InjectableTransienteSingle _injectableTransienteSingle;

        public TransientController(
            ITransientContract contract,
            TransientIndividualService serviceType,
            InjectableTransienteSingle injectableTransienteSingle)
        {
            _contract = contract ?? throw new ArgumentException(nameof(contract));
            _serviceType = serviceType ?? throw new ArgumentException(nameof(serviceType));
            _injectableTransienteSingle = injectableTransienteSingle ?? throw new ArgumentException(nameof(_injectableTransienteSingle));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<string>
            {
                _contract.ToString(),
                _serviceType.ToString(),
                _injectableTransienteSingle.ToString(),
            });
        }
    }
}