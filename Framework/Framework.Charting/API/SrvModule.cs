﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joaopaulocarreiro@gmail.com)
// Create date: 06/July/2016
// Company: Coop4Creativity
// Description: 
// ============================================================================

using Framework.Charting.Model.Config;

namespace Framework.Charting.API
{
    public class SrvModule : Factory.API.SrvModule<LibConfiguration>, Factory.API.IModuleProtocol
    {
        //
        // CONSTRUCTOR
        //    

        public SrvModule() : base(Constants.SECTION, System.Reflection.Assembly.GetExecutingAssembly()) { }
    }
}
