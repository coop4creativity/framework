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

namespace Framework.Data.Model.Mem
{
    public class QueryInfo
    {
        public string ID { get; set; }

        public string Domain { get; set; }

        public string Cluster { get; set; }

        public string Context { get; set; }

        public string Entity { get; set; }

        public TypeOfDataQuery Kind { get; set; }

        public string Query { get; set; }

        public string Callback { get; set; }

        //
        // Original query specification.
        //

        [JsonIgnore]
        public DataQuery Original { get; set; }

        //
        // CONSTRUCTOR
        //

        public QueryInfo()
        {
            ID = null;
            Domain = default(string);
            Cluster = default(string);
            Context = default(string);
            Entity = default(string);
            Kind = TypeOfDataQuery.UNKNOWN;
            Query = default(string);
            Callback = default(string);

            Original = default(DataQuery);
        }
    }
}
