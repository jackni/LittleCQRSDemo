using CQRSlite.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox.DataStore.Models
{
    public class DispatchEvent : IEvent
    {
        [Required]
        [Index("IX_EventId", IsUnique = true)]
        public Guid Id { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
        public int Version { get; set; }

        [MaxLength(250)]
        public string EventContent { get; set; }
    }
}
