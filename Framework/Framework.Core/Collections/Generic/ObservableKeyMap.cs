﻿// ============================================================================
// Project: Framework
// Name/Class: ObservableKeyMap
// Author: João Carreiro (joao.carreiro@coop4creativity.com)
// Create date: 26/Nov/2015
// Company: Coop4Creativity
// Description: Mapping structure for key interface elements.
// ============================================================================

using Framework.Core.Extensions;
using Framework.Core.Patterns;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace Framework.Core.Collections.Generic
{
    public class ObservableKeyMap<K, T> :
        ObservableGenericMap<K, T>,
        INotifyCollectionChanged,
        INotifyPropertyChanged,
        IDictionary<K, T> where T : IKey<K>
    {
        //
        // PROPERTIES
        //

        //
        // Key generator property. This object is used 
        // for generating the key for the registered objects.
        //

        public IKeyGenerator<K> KeyGenerator { get; set; }

        //
        // CONSTRUCTORS
        //

        public ObservableKeyMap() : this(null) { }

        public ObservableKeyMap(IKeyGenerator<K> keygen)
            : base()
        {
            KeyGenerator = keygen;
        }

        //
        // Register the mappings found in another object key map.
        // Take all the mappings found in the external object key
        // map and import into this object key map.
        //

        public void Register(ObservableKeyMap<K, T> map, bool update = true)
        {
            this.Register(map.ValuesAsList(), update);
        }

        //
        // Register a dictionary of mappings in this object key map. The keys
        // are extracted from the values found in the dictionary.
        //

        public new void Register(IDictionary<K, T> dict, bool update = true)
        {
            this.Register(dict.Values.ToList(), update);
        }

        //
        // Register a list of values. The keys are extracted from the 
        // value objects.
        //

        public void Register(IList<T> lst, bool update = true)
        {
            lst.Apply<T>(v => this.Register(v, update));
        }

        //
        // Register a new value. The key is extracted from the supplied value.
        //

        public K Register(T value, bool update = true)
        {
            return base.Register(value.Key, value, update);
        }

        //
        // Take an existent object key map and add all of its
        // values to this key map. Additional keys are generated 
        // for the new values.
        //

        public void New(ObservableKeyMap<K, T> map)
        {
            this.New(map.ValuesAsList());
        }

        //
        // Take a dictionary of values and add them to this mapping.
        // Additional keys are generated for each value added.
        //

        public void New(IDictionary<K, T> dict)
        {
            this.New(dict.Values.ToList());
        }

        //
        // Add a list of values to this mapping.
        // New keys are generated for each value.
        //

        public void New(IList<T> lst)
        {
            lst.Apply<T>(v => this.New(v));
        }

        //
        // Register a single value in this object key map.
        // Generate a new key, set the input object key to
        // this enerated value.
        //

        public K New(T value)
        {
            //
            // First check if the key generator is valid.
            //

            if (KeyGenerator.IsNull())
            {
                throw new ArgumentException("key generator is null or invalid!");
            }

            // 
            // Generate a new key for the value.
            //

            K newKey = KeyGenerator.GetKey();

            // 
            // Change the object key property.
            //

            value.Key = newKey;

            // 
            // Register it.
            //

            return this.Register(value);
        }

        //
        // REMOVE
        // Remove objects from mapping.
        //

        public new void Unregister(K key, bool quiet = true)
        {
            base.Unregister(key, quiet);
        }

        //
        // Unregister a list of object values. Extract the key from
        // the object and unregister it from this mapping.
        //

        public void Unregister(IList<T> lst, bool quiet = false)
        {
            lst.Apply<T>(v => Unregister(v, quiet));
        }

        //
        // Unregister a single value from this object map.
        //

        public void Unregister(T value, bool quiet = true)
        {
            base.Unregister(value.Key, quiet);
        }
    }
}
