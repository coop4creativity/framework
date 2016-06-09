﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@cybermap.pt)
// Create date: 26/Nov/2015
// Company: Cybermap Lta.
// Description: 
// ============================================================================

using Framework.Core.Extensions;
using Framework.Core.Patterns;
using System;
using System.Collections.Generic;

namespace Framework.Types.Model.Schema
{
    public class FW_TypCluster :
        IOwner<int>,
        IID<int>,
        IName<string>,
        IDescription<string>,
        IAuditable<string>
    {
        //
        // Info
        //

        public int Owner { get; set; }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<FW_TypTypeDef> TypeDefs { get; set; }
      
        //
        // Audits
        //

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        //
        // CONSTRUCTORS
        // 

        public FW_TypCluster()
        {
            //
            // Info
            //

            Owner = -1;
            ID = -1;
            Name = string.Empty;
            Description = string.Empty;
            TypeDefs = null;
          

            //
            // Audits
            //

            AuditableExtensions.Init(this, string.Empty);
        }
    }
}