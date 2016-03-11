﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@cybermap.pt)
// Create date: 08/Mar/2016
// Company: Cybermap Lta.
// Description:
// ============================================================================

namespace Framework.Web.Model.Routing
{
    public class PageRoute
    {
        //
        // PROPERTIES
        //

        public string Name { get; set; }

        public string FriendlyUrl { get; set; }

        public string Location { get; set; }

        //
        // CONSTRUCTORS
        // 

        public PageRoute(string name, string friendly, string location)
        {
            Name = name;
            FriendlyUrl = friendly;
            Location = location;
        }

        public PageRoute() : this(string.Empty, string.Empty, string.Empty) { }
    }
}