﻿// ============================================================================
// Project: Framework
// Name/Class: Configuration for Clusters.
// Author: João Carreiro (joao.carreiro@cybermap.pt)
// Create date: 26/Nov/2015
// Company: Cybermap Lta.
// Description: Configuration objects.
// ============================================================================

using System.Configuration;

namespace Framework.Data.Config
{
    public class ClusterElementCollection : ConfigurationElementCollection
    {
        public ClusterElementCollection() { }

        public ClusterElement this[int index]
        {
            get { return (ClusterElement)BaseGet(index); }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        public void Add(ClusterElement itemConfig)
        {
            BaseAdd(itemConfig);
        }

        public void Clear()
        {
            BaseClear();
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new ClusterElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ClusterElement)element).Name;
        }

        public void Remove(ClusterElement itemConfig)
        {
            BaseRemove(itemConfig.Name);
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        public void Remove(string name)
        {
            BaseRemove(name);
        }
    }

    public class ClusterElement : BaseElement
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
