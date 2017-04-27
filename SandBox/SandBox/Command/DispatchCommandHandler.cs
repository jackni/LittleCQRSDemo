using CQRSlite.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSlite.Messages;

namespace SandBox.Command
{
    public class DispatchCommandHandler: ICommandHandler<EmailSendCommand>, ICommandHandler<SMSSendCommand>
    {
        Task IHandler<SMSSendCommand>.Handle(SMSSendCommand message)
        {
            throw new NotImplementedException();
        }

        Task IHandler<EmailSendCommand>.Handle(EmailSendCommand message)
        {
            throw new NotImplementedException();
        }
    }
}
