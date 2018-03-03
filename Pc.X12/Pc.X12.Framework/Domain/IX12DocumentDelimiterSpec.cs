using System;
namespace Pc.X12.Framework.Domain
{
    public interface IX12DocumentDelimiterSpec
    {
        char ComponentElementSeparator { get; }
        char DataElementSeparator { get; }
        char SegmentTerminator { get; }
    }
}
