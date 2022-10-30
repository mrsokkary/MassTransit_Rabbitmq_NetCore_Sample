using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;
using RabbitmqShared.Contracts;

namespace ConsumerWebApi.Consumers
{
    public class ProductConsumer : IConsumer<Product>
    {
        public async Task Consume(ConsumeContext<Product> context)
        {
            var product =  context.Message;
        }
    }
}
