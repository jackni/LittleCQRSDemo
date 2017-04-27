using CQRSlite.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox.Command
{
    public abstract class Command : ICommand
    {
        public Guid Id { get; set; }
        public int ExpectedVersion { get; set; }
    }
}
