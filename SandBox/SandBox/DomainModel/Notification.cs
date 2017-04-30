using Newtonsoft.Json;
using SandBox.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SanBox.DomainModel
{
    //[DataContract]
    public class Notification : Command
    {
        [JsonProperty(Required = Required.Always )] 
        public string Source { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Target { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string ChannelType { get; set; }

        [JsonProperty(Required = Required.AllowNull)]
        public DeviceType DeviceType { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Receipiant { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Sender { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Subject { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string MessageBody { get; set; }

        [JsonProperty(Required = Required.AllowNull)]
        public string AttachmentUrl { get; set; }

    }
}