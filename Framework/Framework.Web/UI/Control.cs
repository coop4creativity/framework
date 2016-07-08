﻿// ============================================================================
// Project: Framework
// Name/Class: Control
// Author: João Carreiro (joaopaulocarreiro@gmail.com)
// Create date: 15/Abr/2014
// Company: Coop4Creativity
// Description: Base control definition.
// ============================================================================

using Framework.Factory;
using Framework.Factory.API;
using System;

namespace Framework.Web.UI
{
    public class Control : System.Web.UI.Control
    {
        //
        // PROPERTIES
        // Control properties for subclasses.
        //

        public IScope Scope { get; protected set; }

        //
        // ONINIT
        // Event handler.
        //

        protected override void OnInit(EventArgs e)
        {
            //
            // Initialize base control.
            //

            base.OnInit(e);

            //
            // Get the context for the control.
            //

            Scope = Manager.Hub.GetUnique<IScope>().New();
        }
    }
}
