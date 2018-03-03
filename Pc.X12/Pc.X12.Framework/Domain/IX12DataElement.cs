using System;
namespace Pc.X12.Framework.Domain
{
    public interface IX12DataElement : IKeyedEntity<string>
    {
        IX12DataElementSpec Spec { get; }

        string Value { get; }
    }
}
