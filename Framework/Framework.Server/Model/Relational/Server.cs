﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joaopaulocarreiro@gmail.com)
// Create date: 06/July/2016
// Company: Coop4Creativity
// Description:
// ============================================================================

using Framework.Core.Patterns;
using Framework.Data.Patterns;
using System.Collections.Generic;

namespace Framework.Server.Model.Relational
{
    public class Server : ABaseClassWithID<string, string>, IOwner<string>
    {
        //
        // PROPERTIES
        //

        public string Owner { get; set; }

        public string Description { get; set; }

        public ICollection<Module> Modules { get; set; }

        //
        // CONSTRUCTORS
        //

        public Server()
        {
            Owner = default(string);
            Description = default(string);
            Modules = default(ICollection<Module>);
        }
    }
}
