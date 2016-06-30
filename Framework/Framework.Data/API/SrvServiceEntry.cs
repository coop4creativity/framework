﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@cybermap.pt)
// Create date: 26/Nov/2015
// Company: Coop4Creativity
// Description: 
// ============================================================================

using Framework.Data.Patterns;
using Framework.Factory.API;
using Framework.Factory.Model.Schema;
using Framework.Factory.Patterns;
using System.Collections.Generic;
using System.Linq;

namespace Framework.Data.API
{
    public class SrvServiceEntry : ACommon, IServiceEntry
    {
        private IGenericDataSet<ServiceEntry> DataLayer = null;

        public object Create(ServiceEntry srv)
        {
            return DataLayer.Create(srv);
        }

        public ServiceEntry GetByName(string name)
        {
            return DataLayer.Queryable().Where(i => i.Name == name).FirstOrDefault();
        }

        public IEnumerable<ServiceEntry> GetByContract(string contract)
        {
            return DataLayer.Queryable().Where(i => i.Contract == contract).ToList();
        }

        public ServiceEntry GetByTypeName(string type)
        {
            return DataLayer.Queryable().Where(i => i.TypeName == type).FirstOrDefault();
        }
    }
}
