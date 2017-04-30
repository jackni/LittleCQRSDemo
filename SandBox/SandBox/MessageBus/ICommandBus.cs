using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanBox.MessageBus
{
    public interface ICommandBus
    {
        Task QueueCommand<T>(T command);

        //Task DeQueueCommand(T command);

        //Task ReQueueCommand(T command); //this will be in the retry, and will have a new version of command.
    }
}
