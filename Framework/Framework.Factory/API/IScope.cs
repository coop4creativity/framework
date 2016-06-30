﻿// ============================================================================
// Project: Framework
// Name/Class: IScope
// Author: João Carreiro (joao.carreiro@cybermap.pt)
// Create date: 26/Nov/2015
// Company: Coop4Creativity
// Description: 
// ============================================================================

using Framework.Factory.Patterns;

namespace Framework.Factory.API
{
    public interface IScope : ICommon
    {
        //
        // PROPERTIES
        //

        IHub Hub { get; }

        //
        // Method to return a new scope based on the current scope.
        // @return A new derived runtime scope.
        //

        IScope New();
    }
}
