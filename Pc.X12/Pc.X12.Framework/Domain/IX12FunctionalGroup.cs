using System;
using System.Collections.Generic;

namespace Pc.X12.Framework.Domain
{
    public interface IX12FunctionalGroup : IX12Segment<IX12TransactionSet>
    {
        string Version { get; }
        string TransactionTypeKey { get; }
    }
}
