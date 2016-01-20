using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Messages;

using NServiceBus;

namespace Command
{
    public class RunCommand
    {
        public IBus Bus { get; set; }

        public RunCommand()
        {
            Bus.Publish<ProcessCommand>();
        }
    }
}
