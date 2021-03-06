﻿// ============================================================================
// Project: Framework
// Name/Class: Module
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 03/Aug/2015
// Company: Coop4Creativity
// Description: Module specification class.
// ============================================================================

using Framework.Core.Patterns;
using Framework.Core.Types.Specialized;
using System.Collections.Generic;

namespace Framework.Core.Types.Specialized
{
    public class Module : 
        IName<string>, 
        ITypeName<string>
    {
        //
        // PROPERTIES
        //

        public string Name { get; set; }

        public string Description { get; set; }

        public string TypeName { get; set; }    

        //
        // CONSTRUCTORS
        // 

        public Module()
        {
            Name = default(string);
            Description = default(string); 
            TypeName = default(string);
        }
    }
}
