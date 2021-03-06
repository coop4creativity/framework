﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 06/July/2016
// Company: Coop4Creativity
// Description:
// ============================================================================

using Framework.Core.Patterns;

namespace Framework.Client.Model.Relational
{
    public class Client : ABaseClassWithID<string, int>, IOwner<string>
    {
        //
        // PROPERTIES
        //

        public string Owner { get; set; }

        public string Description { get; set; }

        //
        // CONSTRUCTORS
        //

        public Client()
        {
            Owner = default(string);
            Description = default(string);
        }
    }
}
