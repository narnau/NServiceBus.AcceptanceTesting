using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    #region Events
    public class OrderAccepted : IEvent
    {
        public int OrderId { get; set; }
    }
    #endregion

    #region Commands
    public class RegisterOrder : ICommand
    {
        public int OrderId { get; set; }

        public string CustomerName { get; set; }

        public decimal Amount { get; set; }
    }

    public class OtherOrder : ICommand
    {
        public int OrderId { get; set; }
    }
    #endregion
}
