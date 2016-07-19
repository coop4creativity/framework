﻿// ============================================================================
// Project: Framework
// Name/Class: Configuration for Settings.
// Author: João Carreiro (joaopaulocarreiro@gmail.com)
// Create date: 26/Nov/2015
// Company: Coop4Creativity
// Description: Configuration objects.
// ============================================================================

using System.Configuration;

namespace Framework.Core.Model.Config
{
    public class SettingElementCollection : ConfigurationElementCollection
    {
        public SettingElementCollection() { }

        public SettingElement this[int index]
        {
            get { return (SettingElement)BaseGet(index); }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        public void Add(SettingElement serviceConfig)
        {
            BaseAdd(serviceConfig);
        }

        public void Clear()
        {
            BaseClear();
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new SettingElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((SettingElement)element).Name;
        }

        public void Remove(SettingElement serviceConfig)
        {
            BaseRemove(serviceConfig.Name);
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

    public class SettingElement : BaseElement {

        //
        // Value
        //

        [ConfigurationProperty(Constants.VALUE, DefaultValue = "", IsRequired = true)]
        public string Value
        {
            get { return (string)this[Constants.VALUE]; }
            set { this[Constants.VALUE] = value; }
        }
    }
}