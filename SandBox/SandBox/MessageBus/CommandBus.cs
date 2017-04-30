using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using SandBox.Command;

namespace SanBox.MessageBus
{
    public class CommandBus : ICommandBus
    {
        public CommandBus()
        {
            //here we will inject the broker.
        }

        public Task QueueCommand<DispatchCommand>(DispatchCommand command)
        {
            throw new NotImplementedException();
        }

        //public Task QueueCommand<DispatchCommand>(DispatchCommand command)
        //{
        //    throw new NotImplementedException();
        //}
    }
}