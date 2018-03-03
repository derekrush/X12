using System;

namespace Pc.X12.Framework.Domain
{
    public interface IUniqueEntity
    {
        object Id {get;}
    }

    public interface IUniqueEntity<TId> : IUniqueEntity
    {
        new TId Id {get;}
    }
}