﻿// ============================================================================
// Project: Framework
// Name/Class: AController
// Author: João Carreiro (joao.carreiro@cybermap.pt)
// Create date: 26/Nov/2015
// Company: Cybermap Lta.
// Description: Base Api controller class.
// ============================================================================

using Framework.Core.Exceptions;
using Framework.Factory.API;
using System;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace Framework.Factory.Patterns
{
    public abstract class AController : ApiController
    {
        //
        // PROPERTIES
        // Page properties for subclasses.
        //

        public IScope Scope { get; private set; }

        //
        // CONSTRUCTORS
        //

        public AController() : base() { }

        //
        // INIT
        // Controller initialization.
        //

        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            Scope = Runtime.Scope.New();
        }

        //
        // HELPERS
        //

        protected IHttpActionResult __RunCode(Func<object> handler)
        {
            IHttpActionResult output = default(IHttpActionResult);

            try
            {
                return Ok(handler());
            }
            catch (InternalException ex0)
            {
                output = BadRequest(ex0.Message);
            }
            catch (FatalException ex1)
            {
                output = BadRequest(ex1.Message);
            }
            catch (UnauthorizedException)
            {
                output = Unauthorized();
            }
            catch (Exception ex2)
            {
                output = BadRequest(ex2.Message);
            }

            return output;
        }
    }
}