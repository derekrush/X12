using System;
using Pc.X12.Framework.Domain;

namespace Pc.X12.Framework.Services
{
    public abstract class X12ParserBase : IParser<IX12Segment>
    {
        protected readonly IX12SegmentSpec Spec;
        protected readonly IX12SegmentFactory Factory;

        public X12ParserBase(IX12SegmentSpec spec, IX12SegmentFactory factory)
        {
            Spec = spec;
            Factory = factory;
        }

        object IParser.Parse(string input)
        {
            return Parse(input);
        }

        public IX12Segment Parse(string input)
        {
            var header = ParseHeader(Spec.HeaderSpecs, input);
            var message = ParseMessage(Spec.MessageSpecs, input);
            var footer = ParseFooter(Spec.FooterSpecs, input);

            return Factory.Create(Spec, header, message, footer);
        }

        protected abstract IKeyedEnumerable<string, IX12DataElement> ParseHeader(IX12KeyedEnumerable<IX12DataElementSpec> headerSpecs, string input);
        protected abstract IKeyedEnumerable<string> ParseMessage(IX12KeyedEnumerable messageSpecs, string iput);
        protected abstract IKeyedEnumerable<string, IX12DataElement> ParseFooter(IX12KeyedEnumerable<IX12DataElementSpec> footerSpecs, string input);
    }
}
