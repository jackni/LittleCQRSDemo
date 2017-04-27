using SandBox.DataStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox.DataStore
{
    public class DispatchEventContext : DbContext
    {
        public DbSet<DispatchEvent> DispatchEvents { get; set; }
    }
}
