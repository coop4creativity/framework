﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 18/Jul/2016
// Company: Coop4Creativity
// Description: 
// ============================================================================

using Framework.Core.Types.Specialized;
using Framework.Core.Patterns;

namespace Framework.Design.Model.Objects.Client
{
    public class Fragment<TUser> : ABaseClassWithID<Id, TUser>
    {
        //
        // PROPERTIES
        //

        public string Description { get; set; }

        public ParamSet<TUser> Params { get; set; }

        public Model<TUser> Model { get; set; }

        public View<TUser> View { get; set; }

        public Controller<TUser> Controller { get; set; }

        //
        // CONSTRUCTORS
        // 

        public Fragment() : base()
        {
            Description = default(string);
            Params = default(ParamSet<TUser>);
            Model = default(Model<TUser>);
            View = default(View<TUser>);
            Controller = default(Controller<TUser>);
        }
    }
}
