using System;
namespace Pc.X12.Framework.Domain
{
    public interface IX12TransactionSetSpec : IX12SegmentSpec
    {
        IX12FunctionalGroupSpec FunctionalGroupSpec { get; }
        IX12DataElementSpec DataElementSpec { get; }
    }
}
