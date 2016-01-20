namespace Process
{

    using System;
    using Messages;
    using NServiceBus;

    public class AggregateTwo
    {
        public void Process(IBus bus)
        {
            Console.WriteLine("Do some stuff and send event to notify that AggregateTwo is processed");

            bus.Publish<AggregateTwoProcessed>(e => e.EventName = "AggregateTwoProcessed");
        }
    }
}