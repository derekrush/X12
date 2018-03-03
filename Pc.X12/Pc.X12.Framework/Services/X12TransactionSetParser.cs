using System;
using System.Collections.Generic;
using Pc.X12.Framework.Domain;
using System.Linq;
using Pc.X12.Framework.Exceptions;

namespace Pc.X12.Framework.Services
{
    public class X12TransactionSetParser : X12ParserBase
    {
        
        public X12TransactionSetParser(IX12TransactionSetSpec spec, IX12SegmentFactory factory)
            : base(spec, factory)
        {
        }

        protected override IKeyedEnumerable<string, IX12DataElement> ParseFooter(IX12KeyedEnumerable<IX12DataElementSpec> footerSpecs, string input)
        {
            if (!footerSpecs?.Any() ?? true)
                return null;
            
            var segmentTerminator = Spec.DocumentSpec.DelimiterSpec.SegmentTerminator;

            var splits = input.Split(segmentTerminator);
            var footerText = splits.Last();

            if (!footerText.StartsWith(Spec.FooterKey, StringComparison.OrdinalIgnoreCase))
                throw new SegmentEnvelopeException(Spec, "Footer");
            
            var dataElementDelimiter = Spec.DocumentSpec.DelimiterSpec.DataElementSeparator;
            var resultSplits = footerText.Split(dataElementDelimiter);

            var list = new List<IX12DataElement>();
            for (int i = 0; i < footerSpecs.Count(); i++)
            {
                var spec = footerSpecs[i];
                var value = resultSplits[i];

                list.Add(new X12DataElement { Spec = spec, Value = value });
            }

            return new X12KeyedEnumerable<IX12DataElement>(list);
        }

        protected override IKeyedEnumerable<string, IX12DataElement> ParseHeader(IX12KeyedEnumerable<IX12DataElementSpec> headerSpecs, string input)
        {
            throw new NotImplementedException();
        }

        protected override IKeyedEnumerable<string> ParseMessage(IX12KeyedEnumerable messageSpecs, string iput)
        {
            throw new NotImplementedException();
        }
    }
}
