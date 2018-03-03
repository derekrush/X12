using System;

namespace Pc.X12.Framework.Domain
{
    public interface IX12InterchangeEnvelopeSpec : IX12SegmentSpec
    {
        IX12FunctionalGroupSpec FuctionalGroupSpec { get; }
    }
}
