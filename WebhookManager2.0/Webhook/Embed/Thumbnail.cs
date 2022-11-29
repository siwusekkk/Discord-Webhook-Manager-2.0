using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebhookManager2._0.Webhook.Embed
{
    class Thumbnail
    {
        [JsonProperty("url")]
        public string url { get; set; }
    }
}
