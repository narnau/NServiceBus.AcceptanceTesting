
namespace Process
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Messages;
    using NServiceBus;

    public class HandlerProcess : IHandleMessages<ProcessCommand>, IHandleMessages<AggregateOneProcessed>
    {
        private readonly AggregateOne aggregateOne;
        private readonly AggregateTwo aggregateTwo;

        public IBus Bus { get; set; }

        public HandlerProcess()
        {
            this.aggregateOne = new AggregateOne();
            this.aggregateTwo = new AggregateTwo();
        }

        public void Handle(ProcessCommand message)
        {
            this.aggregateOne.Process(this.Bus);
        }

        public void Handle(AggregateOneProcessed message)
        {
            this.aggregateTwo.Process(this.Bus);
        }
    }
}
