using System;
namespace Pc.X12.Framework.Domain
{
    public interface IX12KeyedEnumerable : IKeyedEnumerable<string>
    {
    }

    public interface IX12KeyedEnumerable<TValue> : IX12KeyedEnumerable, IKeyedEnumerable<string, TValue>
    {
        
    }
}
