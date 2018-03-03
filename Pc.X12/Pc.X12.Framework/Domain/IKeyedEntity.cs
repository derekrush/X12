using System;
namespace Pc.X12.Framework.Domain
{
    public interface IKeyedEntity
    {
        object Key { get; }
    }

    public interface IKeyedEntity<TKey> : IKeyedEntity
    {
        new TKey Key { get; }
    }
}
