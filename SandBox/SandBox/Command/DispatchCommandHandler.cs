using CQRSlite.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSlite.Messages;

namespace SandBox.Command
{
    public class DispatchCommandHandler: IDispatchCommandHandler
    {
        public Task Handle(DispatchCommand message)
        {
            throw new NotImplementedException();
        }

    }
}
