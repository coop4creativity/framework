﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 04/Oct/2015
// Company: Coop4Creativity
// Description:
// ============================================================================

using Framework.Data.Api;
using Framework.Data.Model.Objects;
using System.Web.Http;
using Framework.Core.Patterns;

namespace Framework.Data.Patterns
{
    public abstract class AController<TUser> : AController
    {
        //
        // SCHEMA-ACCESS-LAYER
        // Entry points for data definition layer.
        //

        [ActionName("schema.init"), HttpGet, HttpPost, HttpPut]
        public IHttpActionResult SCHEMA_InitCluster([FromUri] string id)
        {
            return ApplyNoReturn(() => { Scope.Hub.Get<IStore<TUser>>().Runtime.GetDataContext(id).CreateModel(); });
        }

        [ActionName("schema.create"), HttpPost, HttpPut]
        public IHttpActionResult SCHEMA_CreateCluster([FromBody] Cluster<TUser> cluster)
        {
            return ApplyNoReturn(() => { Scope.Hub.Get<IStore<TUser>>().Schema.Create(cluster); });
        }

        [ActionName("schema.get"), HttpPost, HttpPut]
        public IHttpActionResult SCHEMA_GetCluster([FromBody] string id)
        {
            return ApplyNoReturn(() => { Scope.Hub.Get<IStore<TUser>>().Schema.Get<Cluster<TUser>>(id); });
        }

        [ActionName("schema.update"), HttpPost, HttpPut]
        public IHttpActionResult SCHEMA_UpdateCluster([FromBody] Cluster<TUser> cluster)
        {
            return ApplyNoReturn(() => { Scope.Hub.Get<IStore<TUser>>().Schema.Update(cluster); });
        }

        [ActionName("schema.delete"), HttpPost, HttpPut]
        public IHttpActionResult SCHEMA_DeleteCluster([FromBody] string cluster)
        {
            return ApplyNoReturn(() => { Scope.Hub.Get<IStore<TUser>>().Schema.Delete<Cluster<TUser>>(cluster); });
        }

        //
        // DATA-ACCESS-LAYER
        // Entry points for data manipulation.
        //

        [ActionName("dal.create"), HttpPost, HttpPut]
        public IHttpActionResult DAL_Create([FromUri] string id)
        {
            return ApplyAndReturn(() => { return Scope.Hub.Get<IStore<TUser>>().Dal.Create(id, Request.Content.ReadAsStringAsync().Result); });
        }

        [ActionName("dal.query"), HttpGet]
        public IHttpActionResult DAL_Query([FromUri] string id, [FromUri] string name)
        {
            return ApplyAndReturn(() => { return Scope.Hub.Get<IStore<TUser>>().Dal.Query(id, name, Request.Content.ReadAsStringAsync().Result); });
        }

        [ActionName("dal.update"), HttpPost]
        public IHttpActionResult DAL_Update([FromUri] string id)
        {
            return ApplyAndReturn(() => { return Scope.Hub.Get<IStore<TUser>>().Dal.Update(id, Request.Content.ReadAsStringAsync().Result); });
        }

        [ActionName("dal.delete"), HttpDelete, HttpPost, HttpPut]
        public IHttpActionResult DAL_Delete([FromUri] string id)
        {
            return ApplyAndReturn(() => { return Scope.Hub.Get<IStore<TUser>>().Dal.Delete(id, Request.Content.ReadAsStringAsync().Result); });
        }
    }
}