﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 26/Mar/2016
// Company: Coop4Creativity
// Description: 
// ============================================================================

using Framework.Core.Api;
using Framework.Core.Extensions;
using Framework.Types.Specialized;
using Framework.Web.Api;
using Framework.Web.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;

namespace Framework.Web.Controls
{
    [ToolboxData("<{0}:Include runat=\"server\"></{0}:Include>")]
    public class Include : Controls.Control
    {
        //
        // PROPERTIES
        //

        public WebResource.TypeOfResource Type { get; set; }

        public string Folder { get; set; }

        public string Pattern { get; set; }

        public bool Recursive { get; set; }

        public bool NoCache { get; set; }

        public string NoCacheParameter { get; set; }

        //
        // CONSTRUCTORS
        //

        public Include()
        {
            Type = WebResource.TypeOfResource.SCRIPT;
            Recursive = false;
            NoCache = false;
            NoCacheParameter = "_dummy";
        }

        //
        // ON-PRE-RENDER
        // Event handler.
        //

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            //
            // Get current date for no cache processing.
            //

            string currDateInString = DateTime.Now.ToString("ddMMyyyyhhmmssffff");

            //
            // Get all the files (their paths that is) that are to be included..
            //

            string basePath = Container.Get<IHost>().PhysicalPath;
            string baseFolder = Path.Combine(basePath, Folder);
            IList<string> files = Core.Helpers.DirectoryHelper.GetFiles(baseFolder, Pattern, Recursive);

            //
            // transform the file path into urls...
            //

            string baseUrl = VirtualPathUtility.AppendTrailingSlash(Folder);

            IList<string> urls = files.Map(file =>
            {
                string relative = file.Substring(basePath.Length).ReplaceChars("\\", "/");
                return Container.Get<IResolver>().ResolveUrl("~/" + relative);
            });


            //
            // Add the resource here
            //

            urls.Apply(url =>
            {
                //
                // Create the web resource.
                //

                WebResource webResx = new WebResource();
                webResx.Type = Type;
                webResx.Source = WebResource.TypeOfSource.REMOTE;
                webResx.Value = __ProcessCacheUrl(Container.Get<IResolver>().ResolveUrl(url), currDateInString);

                //
                // Generate the tag.
                //

                Controls.Add(new LiteralControl(webResx.GenerateHtml()));
            });
        }

        //
        // Method to add a nocache parameter to the url.
        //

        private string __ProcessCacheUrl(string url, string currDateInString)
        {
            string processedUrl = url;

            if (NoCache)
            {
                url += '?' + NoCacheParameter + "=" + currDateInString;
            }

            return processedUrl;
        }
    }
}
