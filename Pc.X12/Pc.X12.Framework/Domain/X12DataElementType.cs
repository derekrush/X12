using System;
namespace Pc.X12.Framework.Domain
{
    //Type          Code    Data Element Type Description
    //Numeric       Nn      Numeric value with a predefined implied decimal point
    //Decimal       R       Numeric with an explicit decimal place
    //Identifier    ID      A unique coded value from a predetermined list
    //String        AN      A sequence of basic or extended characters
    //Date          DT      A standard date in the format YYMMDD
    //Time          TM      A time in the format HHMMSSd...d
    //Binary        B       Numeric sequence of binary octets
    //Fixed String  FS      Space-padded sequence of basic or extended characters

    public class X12DataElementType
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
}
