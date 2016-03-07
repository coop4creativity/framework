﻿// ============================================================================
// Project: Framework
// Name/Class: Transform
// Author: João Carreiro (joao.carreiro@cybermap.pt)
// Create date: 26/Nov/2015
// Company: Cybermap Lta.
// Description: Transform configuration objects into runtime objects.
// ============================================================================

using Framework.Configuration.Model;
using Framework.Core.Extensions;
using System.Collections.Generic;

namespace Framework.Configuration.Config
{
    public static class Transforms
    {       
        //
        // META
        //

        public static Meta ToMeta(this MetaElement elm)
        {
            Meta meta = new Meta();
            meta.Name = elm.Name;
            meta.Description = elm.Description;
            meta.Version = elm.Version;
            meta.Icon = elm.Icon;
            meta.Authors = elm.Authors.SplitNoEmpty(";").Map(new List<string>(), v => { return v.Trim(); });
            return meta;
        }
    }
}
