using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanBoxApi.MessageBus
{
    public interface ICommandBus<T> where T: class
     {
        Task QueueCommand(T command);

        //Task DeQueueCommand(T command);

        //Task ReQueueCommand(T command); //this will be in the retry, and will have a new version of command.
    }
}
