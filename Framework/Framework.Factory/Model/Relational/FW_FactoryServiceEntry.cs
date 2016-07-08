﻿// ============================================================================
// Project: Framework
// Name/Class: Service
// Author: João Carreiro (joaopaulocarreiro@gmail.com)
// Create date: 03/Aug/2015
// Company: Coop4Creativity
// Description: Service specification class.
// ============================================================================

using Framework.Core.Extensions;
using Framework.Core.Patterns;
using System;
using System.Collections.Generic;

namespace Framework.Factory.Model.Relational
{
    public class FW_FactoryServiceEntry : 
        IID<int>, 
        IName<string>, 
        ITypeName<string>, 
        IAuditable<string>
    {
        //
        // PROPERTIES
        //

        public int ID { get; set; }

        public string Module { get; set; }

        public bool Unique { get; set; }

        public bool Default { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Contract { get; set; }

        public string TypeName { get; set; }

        public virtual ICollection<FW_FactorySetting> Settings { get; set; }

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

        public FW_FactoryServiceEntry()
        {
            //
            // Basic info.
            //

            ID = default(int);
            Module = default(string);
            Unique = default(bool);
            Default = default(bool);
            Name = default(string);
            Description = default(string);
            Contract = default(string);
            TypeName = default(string);
            Settings = default(ICollection<FW_FactorySetting>);

            //
            // Audits
            //

            AuditableExtensions.Init(this, default(string));
        }
    }
}
