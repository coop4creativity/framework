﻿// ============================================================================
// Project: Framework
// Name/Class: Configuration for Data Contextx.
// Author: João Carreiro (joao.carreiro@cybermap.pt)
// Create date: 26/Nov/2015
// Company: Cybermap Lta.
// Description: Configuration objects.
// ============================================================================

using System.Configuration;

namespace Framework.Data.Config
{
    public class DataContextElement : BaseElement
    {   
        //
        // Settings
        //

        [ConfigurationProperty(Property.SETTINGS, IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(SettingElementCollection))]
        public SettingElementCollection Settings
        {
            get { return (SettingElementCollection)this[Property.SETTINGS]; }
        }
    }
}