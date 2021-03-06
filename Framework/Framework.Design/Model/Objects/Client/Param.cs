﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 18/Jul/2016
// Company: Coop4Creativity
// Description: 
// ============================================================================

using Framework.Core.Types.Specialized;
using Framework.Core.Patterns;

namespace Framework.Design.Model.Objects.Client
{
    public class Param<TUser> : ABaseClassWithID<Id, TUser>
    {
        //
        // PROPERTIES
        //

        public KindOfParam Kind { get; set; }

        public string Description { get; set; }
        
        //
        // CONSTRUCTORS
        // 

        public Param() : base()
        {
            Kind = default(KindOfParam);
            Description = default(string);
        }
    }
}
