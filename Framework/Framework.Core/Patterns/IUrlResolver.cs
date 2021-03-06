﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 26/Nov/2015
// Company: Coop4Creativity
// Description: 
// ============================================================================        

using System;

namespace Framework.Core.Patterns
{
    public interface IUrlResolver
    {
        string BaseUrl { get; set; }

        string Resolve(string uri);
    }
}
