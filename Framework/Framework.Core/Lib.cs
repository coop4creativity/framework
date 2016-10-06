﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 18/Mar/2016
// Company: Coop4Creativity
// Description: 
// ============================================================================

using Framework.Core.Extensions;
using System.Reflection;

namespace Framework
{
    public static class Lib
    {
        // 
        // Default Xml namespace for the base namespace.
        //

        public const string DEFAULT_XML_NAMESPACE = "http://framework.coop4creativity.pt";

        //
        // Static methods for assembly/lib values.
        //

        public static string GetDefaultErrorPrefix(Assembly executingAssembly)
        {
            return executingAssembly.GetName().Name;
        }

        public static string GetDefaultXmlNamespace(Assembly executingAssembly)
        {
            return DEFAULT_XML_NAMESPACE + "/" + GetDefaultErrorPrefix(executingAssembly).RightOf(".").Replace('.', '/').ToLower();
        }

        public static string GetConfigSectionName(Assembly executingAssembly)
        {
            string assemblyName = GetDefaultErrorPrefix(executingAssembly);
            return assemblyName.IsNotNullAndEmpty() ? char.ToLower(assemblyName[0]) + assemblyName.Substring(1) : assemblyName;
        }
    }
}
