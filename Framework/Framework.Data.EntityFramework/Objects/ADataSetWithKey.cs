﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 26/Fev/2016
// Company: Coop4Creativity
// Description:
// ============================================================================

using Framework.Core.Patterns;
using Framework.Data.Api;
using System;

namespace Framework.Data.EntityFramework.Objects
{
    public abstract class ADataSetWithKey<TItem, TID> : 
        BaseGenericDataSet<TItem>, 
        IGenericDataSet<TItem> 
        where TItem : class, IID<TID>
    {    
        //
        // CRUDs
        //   

        public override object Update(TItem item)
        {
            throw new NotImplementedException();
        }
    }
}
