using Codeizi.DI.Functional.Test.Injectables;
using Codeizi.DI.Functional.Test.Injectables.Scoped;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Codeizi.DI.Functional.Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScopedController : ControllerBase
    {
        private readonly IContract _contract;
        private readonly ScopedIndividualService _serviceType;
        private readonly ScopedInjectableSingle _scopedInjectableSingle;
        public ScopedController(
            IContract contract,
            ScopedIndividualService serviceType,
            ScopedInjectableSingle scopedInjectableSingle)
        {
            _contract = contract ?? throw new ArgumentException(null, nameof(contract));
            _serviceType = serviceType ?? throw new ArgumentException(null, nameof(serviceType));
            _scopedInjectableSingle = scopedInjectableSingle ?? throw new ArgumentException(null, nameof(scopedInjectableSingle));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<string>
            {
                _contract.ToString(),
                _serviceType.ToString(),
                _scopedInjectableSingle.ToString()
            });
        }
    }
}