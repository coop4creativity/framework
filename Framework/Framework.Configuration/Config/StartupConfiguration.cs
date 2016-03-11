﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@cybermap.pt)
// Create date: 26/Nov/2015
// Company: Cybermap Lta.
// Description: 
// ============================================================================

using System.Configuration;

namespace Framework.Configuration.Config
{
    public class StartupConfiguration : ConfigurationSection
    {        
        //
        // BOOT-SEQUENCE
        // Ordered list of services and method to run at startup.
        //

        [ConfigurationProperty(Constants.SEQUENCE, IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(MethodCallElementCollection))]
        public MethodCallElementCollection Sequence
        {
            get { return (MethodCallElementCollection)this[Constants.SEQUENCE]; }
        }
    }
}