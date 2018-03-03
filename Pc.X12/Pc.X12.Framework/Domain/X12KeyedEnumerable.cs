using System;
using System.Collections.Generic;
using System.Linq;

namespace Pc.X12.Framework.Domain
{
    public class X12KeyedEnumerable : List<IKeyedEntity<string>>, IX12KeyedEnumerable
    {
        public X12KeyedEnumerable(IEnumerable<IKeyedEntity<string>> collection)
            : base(collection)
        { }

        public object this[string key] 
        {
            get
            {
                if (string.IsNullOrEmpty(key))
                    throw new ArgumentNullException(nameof(key));
                
                return this.FirstOrDefault(x => x.Key.Equals(key, StringComparison.OrdinalIgnoreCase));
            }
        }

        object IKeyedEnumerable<string>.this[int index] => base[index];
    }

    public class X12KeyedEnumerable<TValue> : List<TValue>, IX12KeyedEnumerable<TValue>
        where TValue : IKeyedEntity<string>
    {
        public TValue this[string key] 
        {
            get
            {
                if (string.IsNullOrEmpty(key))
                    throw new ArgumentNullException(nameof(key));

                return this.FirstOrDefault(x => x.Key.Equals(key, StringComparison.OrdinalIgnoreCase));
            }
        }

        object IKeyedEnumerable<string>.this[int index] => base[index];

        object IKeyedEnumerable<string>.this[string key] => this[key];

        public X12KeyedEnumerable(IEnumerable<TValue> collection)
            : base(collection)
        {}
    }
}
