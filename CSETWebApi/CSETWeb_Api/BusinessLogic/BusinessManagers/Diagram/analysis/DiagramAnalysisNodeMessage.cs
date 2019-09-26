﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CSETWeb_Api.BusinessManagers.Diagram.Analysis
{
    public class DiagramAnalysisNodeMessage : IDiagramAnalysisNodeMessage
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public NetworkComponent Component { get; internal set; }
        public int Number { get; internal set; }
        public string redDot { get; set; }
        public string label { get; set; }
        public string id { get; set; }
        public string layerId { get; set; }
        public string value { get; set; }
        
        public string vertex { get; set; }
        public string parent { get; set; }
        
        public HashSet<String> SetMessages { get; set; }
        public int MessageIdentifier { get; set; }

        public DiagramAnalysisNodeMessage()
        {
            SetMessages = new HashSet<string>();
            redDot = "1";
            Number = 1;
            label = "";
            id = Guid.NewGuid().ToString();
            layerId = "0";
            value = Number.ToString();        
            vertex = "1";
            parent = "0";
        }

        public void AddMessage(String message)
        {
            SetMessages.Add(message);
        }

        public String Message
        {
            get
            {
                return String.Join("\n\n", SetMessages);
            }
        }

        public string NodeId1 { get; set; }

        public string NodeId2 { get; set; }
    }
}
