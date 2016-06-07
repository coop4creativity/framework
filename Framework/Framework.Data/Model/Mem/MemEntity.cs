﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@cybermap.pt)
// Create date: 17/Mar/2016
// Company: Cybermap Lta.
// Description: 
// ============================================================================

using Framework.Data.Model.Schema;
using Newtonsoft.Json;
using System;

namespace Framework.Data.Model.Mem
{
    public class MemEntity
    {  
        public string ID { get; set; }

        public Type Type { get; set; }

        public string Cluster { get; set; }

        public string Context { get; set; }

        //
        // Entity definition used in context.
        //

        [JsonIgnore]
        public FW_DataEntity Original { get; set; }

        public FW_DataEntity Instance { get; set; }

        //
        // CONSTRUCTOR
        //

        public MemEntity()
        {
            ID = default(string);
            Type = default(Type);
            Cluster = default(string);
            Context = default(string);
            Original = null;
            Instance = null;            
        }
    }
}
