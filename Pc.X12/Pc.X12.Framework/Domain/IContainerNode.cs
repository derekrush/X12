using System;
using System.Collections.Generic;

namespace Pc.X12.Framework.Domain
{
    public interface IContainerNode : INode
    {
        IEnumerable<INode> Nodes { get; }
    }
}
