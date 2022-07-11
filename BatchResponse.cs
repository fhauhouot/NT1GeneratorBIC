using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NT1Generator
{
    [Serializable()]
    [XmlRoot("BatchResponse", Namespace = "http://creditinfo.com/CB5")]
    public class BatchResponse
    {
        [XmlArray]
        public List<Item> Items { get; set; }
    }
}
