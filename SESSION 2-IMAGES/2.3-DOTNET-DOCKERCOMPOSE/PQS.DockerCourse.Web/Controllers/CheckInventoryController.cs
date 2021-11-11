using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PQS.DockerCourse.Messaging.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PQS.DockerCourse.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckInventoryController :
        ControllerBase
    {
        readonly IRequestClient<CheckInventory> _client;

        public CheckInventoryController(IRequestClient<CheckInventory> client)
        {
            _client = client;
        }

        [HttpGet("{sku}")]
        public async Task<IActionResult> Get(string sku)
        {
            Response<InventoryStatus> response = await _client.GetResponse<InventoryStatus>(new { sku });

            return Ok(response.Message);
        }
    }
}
