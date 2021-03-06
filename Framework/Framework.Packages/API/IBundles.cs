﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 25/Mar/2016
// Company: Coop4Creativity
// Description: 
// ============================================================================

using Framework.Core.Api;

namespace Framework.Packages.Api
{
    public interface IBundles : ICommon
    {
        //
        // Take a list of packages and return the bundled content of
        // all files that are of a particular mime type.
        // @param names the names for the packages.
        // @param mimeType The mime type of the files to bundle.
        // @param minify Should the content be returned minified
        // @param ctx The execution context.
        //

        string GetBundleContent(string names, string mimeType, TypeOfContentFormat minify, object ctx);
    }
}
