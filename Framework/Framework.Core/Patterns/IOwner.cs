﻿// ============================================================================
// Project: Framework
// Name/Class: IOwner
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 26/Nov/2015
// Company: Coop4Creativity
// Description: Pattern for classes that need require an owner.
// ============================================================================                    

namespace Framework.Core.Patterns
{
    public interface IOwner<T>
    {
        T Owner { get; set; }
    }
}
