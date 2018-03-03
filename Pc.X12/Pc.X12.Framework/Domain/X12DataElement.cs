using System;
namespace Pc.X12.Framework.Domain
{
    public class X12DataElement : IX12DataElement
    {
        public IX12DataElementSpec Spec { get; set; }

        public string Value { get; set; }

        public string Key => Spec.Name;

        object IKeyedEntity.Key => Key;
    }
}
