using SanBox.DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox.Command
{
    public class DispatchCommand : Notification
    {
        [Required]
        public string CoorlationId { get; set; }
       
    }
}
