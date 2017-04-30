using SandBox.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace SanBox.MessageBus
{
    public class CommandBus : ICommandBus<DispatchCommand>
    {
        public CommandBus()
        {
            //here we will inject the broker.
        }

        Task ICommandBus<DispatchCommand>.QueueCommand(DispatchCommand command)
        {
            throw new NotImplementedException();
        }
    }
}