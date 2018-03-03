using System;
namespace Pc.X12.Framework.Domain
{
    public interface IX12DocumentSpec
    {
        //Adding comment...
        IX12DocumentDelimiterSpec DelimiterSpec { get; }
        IX12InterchangeEnvelopeSpec InterchangeEnvelopeSpec { get; }
    }
}
