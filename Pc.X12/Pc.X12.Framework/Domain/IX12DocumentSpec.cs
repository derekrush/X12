using System;
namespace Pc.X12.Framework.Domain
{
    public interface IX12DocumentSpec
    {
        IX12DocumentDelimiterSpec DelimiterSpec { get; }
        IX12InterchangeEnvelopeSpec InterchangeEnvelopeSpec { get; }
    }
}
