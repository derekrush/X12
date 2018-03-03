using System;
namespace Pc.X12.Framework.Domain
{
    public interface IX12DataElementSpec
    {
        IX12FunctionalGroupSpec GroupSpec { get; }
        string Description { get; }
        int MaxLength { get; }
        int MinLength { get; }
        string Name { get; }
        bool IsRequired { get; }
        X12DataElementType DataElementType { get; }
    }
}
