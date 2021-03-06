﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICSharpCore.Protocols
{
    /// <summary>
    /// https://jupyter-client.readthedocs.io/en/stable/messaging.html#kernel-info
    /// </summary>
    public class ContentOfKernelInfoReply
    {
        [JsonProperty("protocol_version")]
        public string ProtocolVersion { get; set; }

        [JsonProperty("implementation")]
        public string Implementation { get; set; }

        [JsonProperty("implementation_version")]
        public string ImplementationVersion { get; set; }

        [JsonProperty("language_info")]
        public ContentOfLanguageInfo LanguageInfo { get; set; }

        [JsonProperty("banner")]
        public string Banner { get; set; }

        public ContentOfKernelInfoReply()
        {
            Implementation = "ICSharpCore";
            ImplementationVersion = "0.1.0";
            ProtocolVersion = "5.2";
            LanguageInfo = new ContentOfLanguageInfo();
        }
    }
}
