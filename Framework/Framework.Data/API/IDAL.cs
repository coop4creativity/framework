﻿// ============================================================================
// Project: Framework
// Name/Class: Data Access Layer
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 31/May/2016
// Company: Coop4Creativity
// Description: Data Access Layer service contract.
// ============================================================================

using Framework.Core.Types.Specialized;
using Framework.Core.Api;

namespace Framework.Data.Api
{
    public interface IDal<TUser> : ICommon
    {
        //
        // Schema Access Data Layer Service.
        //

        ISchema<TUser> Schema { get; set; }

        IRuntime<TUser> Runtime { get; set; }

        //
        // Data Access Layer API
        //

        object Create(string entity, object value);

        object Create(Id entity, object value);

        object Query(string entity, string name, object args);

        object Update(string entity, object value);

        object Update(Id entity, object value);

        object Delete(string entity, object value);

        object Delete(Id entity, object value);
    }
}