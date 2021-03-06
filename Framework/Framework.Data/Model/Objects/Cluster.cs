﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 13/Jul/2016
// Company: Coop4Creativity
// Description: 
// ============================================================================

using System.Collections.Generic;

namespace Framework.Data.Model.Objects
{
    public class Cluster<TUser> : ASchemaObject<TUser>
    {
        //
        // PROPERTIES
        //

        public int Owner { get; set; }

        public ICollection<Context<TUser>> Contexts { get; set; }

        public ICollection<Setting<TUser>> Settings { get; set; }

        //
        // CONSTRUCTORS
        // 

        public Cluster()
        {
            Owner = default(int);
            Contexts = null;
            Settings = null;
        }
    }
}
