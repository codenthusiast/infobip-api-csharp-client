using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace Infobip.Api.Model.Sms.Mt.Send
{
    /// <summary>
    /// This is a generated class and is not intended for modification!
    /// </summary>
    public class SMSResponse
    {
        [JsonProperty("bulkId")]
        public string BulkId { get; set; }

        [JsonProperty("trackingProcessKey")]
        public string TrackingProcessKey { get; set; }

        [JsonProperty("messages")]
        public List<SMSResponseDetails> Messages { get; set; }


    }
}