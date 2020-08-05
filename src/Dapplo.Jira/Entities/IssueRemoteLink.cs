using System;
using System.Collections.Generic;
using System.Text;

namespace Dapplo.Jira.Entities
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents the RemoteLinks collection returned by the API for an Issue
    /// </summary>
    [JsonObject()]
    public class IssueRemoteLink
    {
        /// <summary>
        /// The collection of Links
        /// </summary>
        [JsonProperty("object")]
        public RemoteLinks Link { get; set; }
    }
}
