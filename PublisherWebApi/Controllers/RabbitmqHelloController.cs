using MassTransit;
using Microsoft.AspNetCore.Mvc;
using RabbitmqShared.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublisherWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RabbitmqHelloController : ControllerBase
    {
        private readonly IBus _bus;
        public RabbitmqHelloController(IBus bus)
        {
            _bus = bus;
        }

        [HttpPost("send-product")]
        public async Task<IActionResult> CommandSend()
        {
            var product = new Product()
            {
                Name = "Computer",
                Price = 2500
            };

            await _bus.Publish(product);

            //var url = new Uri("localhost/send-product");
            //var endpoint = await _bus.GetSendEndpoint(url);
            //await endpoint.Send(product);
            return Ok("Hello, Send Product Complete ");
        }
    }
}
