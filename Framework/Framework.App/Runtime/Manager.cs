﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 26/Nov/2015
// Company: Coop4Creativity
// Description: Factory runtime static object.
// ============================================================================

using Framework.App.Api;
using Framework.App.Config;
using Framework.Core.Api;
using Framework.Core.Extensions;
using Framework.Core.Types.Specialized;
using Framework.Utils.Api;
using Owin;
using System;
using System.Collections.Generic;

namespace Framework.App.Runtime
{
    public static class Manager
    {
        //
        // PROPERTIES
        //

        public static IContainer Container { get { return __Container; } }

        public static IScope Scope { get { return __Scope; } }

        public static IHost Host { get { return __Host; } }

        public static IModuleEntry Modules { get { return __Modules; } }

        //
        // CONSTRUCTORS
        //

        static Manager() { }

        //
        // Initialize the data manager services.
        // 

        public static void Init(IAppBuilder app)
        {
            LoadConfig(app);
            LoadModules(app);
            Startup(app);
        }

        //
        // Load the initial configuration for factory library.
        //

        public static void LoadConfig(IAppBuilder app)
        {
            //
            // Load from the system configuration.
            //

            __Config = (Config.Lib)System.Configuration.ConfigurationManager.GetSection(Config.Lib.DEFAULT_CONFIG_SECTION_NAME);

            //
            // Load configuration for the service hub.
            // If this is not found then no frameowrk exists.
            // This class will be the heart of the framework services.
            //            

            if (null != __Config)
            {
                if (null != __Config.Hub)
                {
                    //
                    // Instantiate the hub service.
                    // Load the hub service entry into the hub... :-)
                    // 

                    Service container = Core.Helpers.ConfigHelper.Config2Service(__Config.Hub);
                    __Container = Core.Reflection.Activator.CreateGenericInstance<IContainer>(container.TypeName);
                    __Container.Init();
                    __Container.Load(container);

                    //
                    // Load core services into hub.
                    //

                    if (null != __Config.Services)
                    {
                        __Container.Load(__Config.Services.Map<Core.Config.ServiceElement, Service>(Core.Helpers.ConfigHelper.Config2Service));
                    }

                    //
                    // Setup the Scope service, load it
                    // and set it on the hub.
                    //

                    __Scope = __Container.GetUnique<IScope>();
                    __Container.Scope = __Scope;

                    //
                    // Setup the host service.
                    //

                    __Host = __Container.GetUnique<IHost>();

                    //
                    // Setup the module manager service.
                    //

                    __Modules = __Container.GetUnique<IModuleEntry>();                   

                }
                else
                {
                    //
                    // ERROR: Hub service specification was not found in factory configuration!
                    //

                    throw new Exception("Container service specification was not found in factory configuration!");
                }
            }
            else
            {
                //
                // ERROR: Configuration section for factory not found!
                //

                throw new Exception("Configuration section for factory not found!");
            }
        }

        //
        // Method to boot the application.
        // This will be called only one time.
        // When the application starts.
        //

        public static void Startup(IAppBuilder app)
        {
            //
            // Run all services and all methods defined in sequence.
            //         

            if (null != __Config.Sequence)
            {
                IEnumerable<MethodCall> bootSequence = __Config.Sequence.Map<MethodCallElement, MethodCall>(App.Api.Transforms.Config2MethodCall);

                bootSequence.Apply(call =>
                {
                    __Scope.Hub.GetUnique<IReflected>().Run(call.Service, call.Method);
                });
            }
        }

        //
        // Method to load all the modules into the module manager.
        // The module manager will load the inport artifacts into
        // the runtime syste,
        //

        public static void LoadModules(IAppBuilder app)
        {
            if (null != __Config.Modules)
            {
                __Modules.Load(__Config.Modules.Map<ModuleImportElement, Core.Types.Specialized.Module>(App.Api.Transforms.Config2Module));
            }
        }

        //
        // HELPERS 
        //     

        private static IContainer __Container;
        private static IScope __Scope;
        private static IHost __Host;
        private static IModuleEntry __Modules;
        private static Config.Lib __Config;
    }
}