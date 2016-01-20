namespace Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NServiceBus;

    public class ProcessCommand : IEvent
    {
        public string CommandName { get; set; }
    }

    public class AggregateOneProcessed : IEvent
    {
        public string EventName { get; set; }
    }

    public class AggregateTwoProcessed : IEvent
    {
        public string EventName { get; set; }
    }
}
