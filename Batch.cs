using System.Collections.Generic;
using System.Xml.Serialization;

namespace NT1Generator
{
    [XmlRoot(Namespace = "http://creditinfo.com/schemas/CB5/WestAfrica/contract", IsNullable = false)]
    public class Batch
    {
        public string BatchIdentifier { get; set; }

        [XmlArray]
        public List<Contract> Contracts { get; set; }
    }
}
