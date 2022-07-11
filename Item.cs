using FileHelpers;
using System;
using System.Xml.Serialization;

namespace NT1Generator
{
    [Serializable]
    [DelimitedRecord(";")]
    public class Item
    {

        [FieldDelimiter(";")]
        [XmlAttribute("EntityCode")]
        public string EntityCode { get; set; }

        [FieldDelimiter(";")]
        [XmlAttribute("Severity")]
        public string Severity { get; set; }

        [FieldDelimiter(";")]
        [XmlAttribute("MessageSource")]
        public string MessageSource { get; set; }

        [FieldDelimiter(";")]
        [XmlElement("ErrorCode")]
        public string ErrorCode { get; set; }

        [FieldDelimiter(";")]
        [XmlElement("Message")]
        public string Message { get; set; }    

    }
}
