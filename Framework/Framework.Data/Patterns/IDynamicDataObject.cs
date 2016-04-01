﻿// ============================================================================
// Project: Framework
// Name/Class: IProviderDataObject
// Author: João Carreiro (joao.carreiro@cybermap.pt)
// Create date: 26/Nov/2015
// Company: Cybermap Lta.
// Description: Generic single object data source.
// ============================================================================

using Framework.Factory.Patterns;
using System;

namespace Framework.Data.Patterns
{
    public interface IDynamicDataObject : ICommon
    {
        //
        // PROPERTIES
        //

        Type Entity { get; set; }

        //
        // API
        //
        //
        // Set the object value.
        //

        void Set(object item);

        //
        // Get object value.
        //

        object Get();

        //
        // Save changes to data source.
        //

        void Save();
    }
}