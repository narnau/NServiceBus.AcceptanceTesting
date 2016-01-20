namespace Process
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Messages;
    using NServiceBus;

    public class AggregateOne
    {
        public void Process(IBus bus)
        {
            Console.WriteLine("Do some stuff and send event to notify that AggregateOne is processed");

            bus.Publish<AggregateOneProcessed>(e => e.EventName = "AggregateOneProcessed");
        }
    }
}
