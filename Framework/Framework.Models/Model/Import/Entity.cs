﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 26/Nov/2015
// Company: Coop4Creativity
// Description: 
// ============================================================================

using Framework.Core.Extensions;
using Framework.Core.Patterns;
using System;
using System.Collections.Generic;

namespace Framework.Models.Model.Import
{
    public class Entity :
        IName<string>
    {
        //
        // PROPERTIES
        //

        public string Name { get; set; }

        public Value<string> Display { get; set; }

        public Value<string> Description { get; set; }

        public IDictionary<string, Property> Properties { get; set; }

        public IDictionary<string, Query> Queries { get; set; }
        //
        // CONSTRUCTORS
        // 

        public Entity()
        {
            Name = default(string);
            Description = default(Value<string>);
            Properties = null;
            Queries = null;
        }
    }
}
