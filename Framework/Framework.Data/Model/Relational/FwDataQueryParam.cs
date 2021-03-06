﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 14/Aug/2015
// Company: Coop4Creativity
// Description: 
// ============================================================================

using Framework.Core.Patterns;

namespace Framework.Data.Model.Relational
{
    public class FwDataQueryParam : ABaseClassWithID<int, string>      
    {
        //
        // INFO
        //

        public string Name { get; set; }

        public string TypeName { get; set; }

        public bool Required { get; set; }

        public string Default { get; set; }

        //
        // CONSTRUCTORS
        // 

        public FwDataQueryParam()
        {
            Name = default(string);
            TypeName = default(string);
            Required = default(bool);
            Default = default(string);        
        }
    }
}
