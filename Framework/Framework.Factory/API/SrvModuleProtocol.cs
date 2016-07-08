﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joaopaulocarreiro@gmail.com)
// Create date: 06/July/2016
// Company: Coop4Creativity
// Description: 
// ============================================================================

using Framework.Factory.Model.Config;
using Framework.Factory.Model.Runtime;
using Framework.Factory.Patterns;
using System.Collections.Generic;
using System.Reflection;
using Framework.Core.Extensions;

namespace Framework.Factory.API
{
    public class SrvModuleProtocol<TConfig> : ACommon, IModuleProtocol where TConfig : ModuleProtocolConfiguration
    {
        //
        // PROPERTIES
        //

        public IEnumerable<Service> Services { get { return GetListOfUserServices(); } }

        //
        // PROPERTIES (INTERNAL)
        //

        protected TConfig Config { get; set; }

        protected string ConfigSectionName { get; set; }

        protected Assembly Assembly { get; set; }

        //
        // CONSTRUCTOR
        //

        public SrvModuleProtocol(string configSectionName, Assembly executingAssembly)
        {
            ConfigSectionName = configSectionName;
            Assembly = executingAssembly;
        }

        //
        // API
        //

        public void LoadConfig()
        {
            //
            // Load from the system configuration spec
            //

            Config = (TConfig)System.Configuration.ConfigurationManager.GetSection(ConfigSectionName);
        }

        protected IEnumerable<Service> GetListOfUserServices()
        {
            return null != Config ? Config.Services.Map<ServiceElement, Service>(Transforms.Config2Service) : null;
        }
    }
}