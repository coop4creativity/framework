﻿// ============================================================================
// Project: Framework
// Name/Class:
// Author: João Carreiro (joaopaulocarreiro@gmail.com)
// Create date: 16/Jul/2016
// Company: Coop4Creativity
// Description:
// ============================================================================

namespace Framework.Data.API
{
    public interface IStore<TUser> : Factory.Patterns.ICommon
    {
        //
        // Data Schema Access Layer Service.
        //

        ISchema<TUser> Schema { get; }

        //
        // Data Access Layer Service.
        //

        IDal<TUser> Dal { get; }


        //
        // Runtime Layer Service.
        //

        IRuntime<TUser> Runtime { get; }
    }
}
