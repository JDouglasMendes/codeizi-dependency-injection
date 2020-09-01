using Codeizi.DI.Functional.Test.Injectables;
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

        public ScopedController(
            IContract contract,
            ScopedIndividualService serviceType)
        {
            _contract = contract ?? throw new ArgumentException(nameof(contract));
            _serviceType = serviceType ?? throw new ArgumentException(nameof(_serviceType));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<string>
            {
                _contract.ToString(),
                _serviceType.ToString()
            });
        }
    }
}