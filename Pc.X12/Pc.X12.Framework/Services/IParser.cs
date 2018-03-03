using System;

namespace Pc.X12.Framework.Services
{
    public interface IParser
    {
        object Parse(string input);
    }

    public interface IParser<out T> : IParser
    {
        new T Parse(string input);
    }
}