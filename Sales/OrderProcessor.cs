using Messages;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    public class OrderProcessor: IHandleMessages<RegisterOrder>, IHandleMessages<OtherOrder>, IHandleMessages<OrderAccepted>
    {
        public IBus Bus { get; set; }

        public void Handle(RegisterOrder message)
        {
            Debug.WriteLine("Received order {0}", message.OrderId);

            Bus.Send<OtherOrder>(m => m.OrderId = message.OrderId);
        }

        public void Handle(OtherOrder message)
        {
            Debug.WriteLine("Processing...");
            Bus.Publish<OrderAccepted>(m => m.OrderId = message.OrderId);
        }

        public void Handle(OrderAccepted message)
        {
            Debug.WriteLine("OrderAccepted");
        }
    }
}
