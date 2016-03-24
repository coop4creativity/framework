﻿// ============================================================================
// Project: Framework
// Name/Class:
// Author: João Carreiro (joao.carreiro@cybermap.pt)
// Create date: 21/Mar/2016
// Company: Cybermap Lta.
// Description:
// ============================================================================

using Framework.Factory.Patterns;

namespace Framework.Blocks.API
{
    public interface IStore : ICommon
    {
        //
        // Load configuration settings for the store.
        // This will load all settings but also the 
        // data domains that are defined on the configuration
        // store.
        //

        void LoadConfiguration();

        //
        // EVALUATE
        // Evaluate components.
        //

        object Block_Evaluate(string blockID, object args);
    }
}
