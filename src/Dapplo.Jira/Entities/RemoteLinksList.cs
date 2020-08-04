using System;
using System.Collections.Generic;
using System.Text;

namespace Dapplo.Jira.Entities
{
    using Newtonsoft.Json;

    [JsonObject()]
    public class IssueRemoteLink
    {
        [JsonProperty("object")]
        RemoteLinks Link { get; set; }
    }
}
