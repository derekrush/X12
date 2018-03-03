using System;
using System.Collections;
using System.Collections.Generic;

namespace Pc.X12.Framework.Domain
{
    public interface IX12SegmentSpec : IKeyedEntity<string>
    {
        IX12DocumentSpec DocumentSpec { get; }

        string HeaderKey { get; }
        IX12KeyedEnumerable<IX12DataElementSpec> HeaderSpecs { get; }

        string FooterKey { get; }
        IX12KeyedEnumerable<IX12DataElementSpec> FooterSpecs { get; }

        IX12KeyedEnumerable MessageSpecs { get; }
    }
}
