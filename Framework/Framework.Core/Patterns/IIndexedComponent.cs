// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 26/Nov/2015
// Company: Coop4Creativity
// Description: Interface that any component must implement
//              so that it can be indexed by an id or by a name.
// ============================================================================

namespace Framework.Core.Patterns
{
    public interface IIndexedComponent<TKey> : IID<TKey>
    {
        //
        // Creates a string key based on the id.
        //

        string BuildKey();
    }
}
