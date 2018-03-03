using System;
using Pc.X12.Framework.Domain;

namespace Pc.X12.Framework.Exceptions
{
    public class SegmentEnvelopeException : Exception
    {
        public IX12SegmentSpec Spec { get; }
        private readonly string _location;
        public override string Message => $"Validation failed for spec envelope {Spec.Key}:{_location}.";

        public SegmentEnvelopeException(IX12SegmentSpec spec, string location = null)
        {
            Spec = spec;
            _location = location;
        }
    }
}
