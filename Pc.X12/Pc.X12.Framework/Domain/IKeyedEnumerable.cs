using System;
using System.Collections;
using System.Collections.Generic;

namespace Pc.X12.Framework.Domain
{
    public interface IKeyedEnumerable<in TKey> : IEnumerable
    {
        object this[int index] { get; }
        object this[TKey key] { get; }
    }

    public interface IKeyedEnumerable<in TKey, out TValue> : IKeyedEnumerable<TKey>, IEnumerable<TValue>
    {
        new TValue this[int index] { get; }
        new TValue this[TKey key] { get; }
    }
}
