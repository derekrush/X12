using System;
namespace Pc.X12.Framework.Domain
{
    public interface IX12FunctionalGroupSpec : IX12SegmentSpec
    {
        IX12InterchangeEnvelopeSpec InterchangeEnvelopeSpec { get; }
        IX12TransactionSetSpec TransactionSetSpec { get; }
    }
}
