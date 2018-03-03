using System;

namespace Pc.X12.Framework.Domain
{
    public class X12DocumentSpec : IX12DocumentSpec
    {
        public IX12DocumentDelimiterSpec DelimiterSpec { get; set; }
        public IX12InterchangeEnvelopeSpec InterchangeEnvelopeSpec { get; set; }
    }
}
