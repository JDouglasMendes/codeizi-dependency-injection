using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Codeizi.DI.Functional.Test.Injectables.Transient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Codeizi.DI.Functional.Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransientController : ControllerBase
    {
        private readonly ITransientContract _contract;
        private readonly TransientIndividualService _serviceType;

        public TransientController(
            ITransientContract contract,
            TransientIndividualService serviceType)
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
