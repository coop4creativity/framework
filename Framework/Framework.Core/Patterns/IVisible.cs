﻿// ============================================================================
// Project: Framework
// Name/Class: IVisible
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 26/Nov/2015
// Company: Coop4Creativity
// Description: Pattern for classes that need a visibility state.
// ============================================================================                    

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Framework.Core.Patterns
{
    //
    // Visibility state options.
    //

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeOfVisibility
    {
        UNKNOWN,
        ACTIVE,
        DELETED
    }

    public interface IVisible
    {
        TypeOfVisibility Visibility { get; set; }
    }
}
