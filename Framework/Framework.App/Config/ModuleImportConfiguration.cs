﻿// ============================================================================
// Project: Framework
// Name/Class: Configuration base element.
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 26/Nov/2015
// Company: Coop4Creativity
// Description: Configuration objects.
// ============================================================================

using System.Configuration;

namespace Framework.App.Config
{
    public class ModuleImportElementCollection : ConfigurationElementCollection
    {
        public ModuleImportElement this[int index]
        {
            get { return (ModuleImportElement)BaseGet(index); }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        public void Add(ModuleImportElement itemConfig)
        {
            BaseAdd(itemConfig);
        }

        public void Clear()
        {
            BaseClear();
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new ModuleImportElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ModuleImportElement)element).Type;
        }

        public void Remove(ModuleImportElement itemConfig)
        {
            BaseRemove(itemConfig.Type);
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

    public class ModuleImportElement : TypeElement { }
}
