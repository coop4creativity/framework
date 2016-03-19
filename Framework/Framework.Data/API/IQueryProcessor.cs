﻿// ============================================================================
// Project: Framework
// Name/Class:
// Author: João Carreiro (joao.carreiro@cybermap.pt)
// Create date: 10/Mar/2016
// Company: Cybermap Lta.
// Description:
// ============================================================================

using Framework.Data.Model.Query;
using Framework.Factory.Patterns;

namespace Framework.Data.API
{
    public interface IQueryProcessor : ICommon
    {
        Expression Parse(string input);
    }
}
