using System;
using System.Collections.Generic;
namespace Pc.X12.Framework.Domain
{
    public interface IX12InterchangeEnvelope : IX12Segment<IX12FunctionalGroup>
    {
        string Sender { get; }
        string Receiver { get; }
        string Date { get; }
        string Time { get; }
    }
}
