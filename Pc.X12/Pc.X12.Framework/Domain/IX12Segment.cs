using System;

namespace Pc.X12.Framework.Domain
{
    public interface IX12Segment : IKeyedEntity<string>
    {
        IX12SegmentSpec Spec { get; }
        IX12KeyedEnumerable<IX12DataElement> HeaderElements { get; }
        IX12KeyedEnumerable<IX12DataElement> FooterElements { get; }
        IX12KeyedEnumerable MessageElements { get; }
    }

    public interface IX12Segment<TMessage> : IX12Segment
    {
        new IX12KeyedEnumerable<TMessage> MessageElements { get; }
    }
}
