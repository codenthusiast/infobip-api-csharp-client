using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace Infobip.Api.Model.Sms.Mt.Send.Textual
{
    /// <summary>
    /// This is a generated class and is not intended for modification!
    /// </summary>
    public class SMSTextualRequest
    {
        [JsonProperty("operatorClientId")]
        public string OperatorClientId { get; set; }

        [JsonProperty("campaignId")]
        public string CampaignId { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public List<string> To { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("transliteration")]
        public string Transliteration { get; set; }


    }
}