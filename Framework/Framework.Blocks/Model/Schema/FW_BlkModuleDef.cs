﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@cybermap.pt)
// Create date: 20/Mar/2016
// Company: Cybermap Lta.
// Description: 
// ============================================================================

using Framework.Core.Patterns;
using System.Collections.Generic;

namespace Framework.Blocks.Model.Schema
{
    public class FW_BlkModuleDef : IID<int>
    {
        //
        // PROPERTIES
        //

        public int ID { get; set; }

        public string Name { get; set; }

        public ICollection<FW_BlkBlockDef> Blocks { get; set; }

        public ICollection<FW_BlkModuleDef> Modules { get; set; }

        //
        // CONSTRUCTORS
        //

        public FW_BlkModuleDef()
        {
            ID = default(int);
            Name = default(string);
            Blocks = default(ICollection<FW_BlkBlockDef>);
            Modules = default(ICollection<FW_BlkModuleDef>);
        }
    }
}