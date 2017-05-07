using SanBox.DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SanBoxApi.Models
{
    public class PushMessage
    {
        [Required]
        public DeviceType DeviceType { get; set; }

        [Required]
        public string PushToken { get; set; }

        [MaxLength(200)]
        public string Message { get; set; }
    }
}