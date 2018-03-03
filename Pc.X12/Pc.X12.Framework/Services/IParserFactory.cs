using System;
using Pc.X12.Framework.Domain;

namespace Pc.X12.Framework.Services
{
    public interface IParserFactory
    {
        IParser GetParser<TSpec>(TSpec spec);
    }
}
