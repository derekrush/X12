using System;
using Pc.X12.Framework.Domain;

namespace Pc.X12.Framework.Services
{
    public interface IX12SegmentFactory
    {
        IX12Segment Create(
            IX12SegmentSpec spec,
            IKeyedEnumerable<string, IX12DataElement> headerElements,
            IKeyedEnumerable<string> messageElements,
            IKeyedEnumerable<string, IX12DataElement> footerElements);
    }
}
