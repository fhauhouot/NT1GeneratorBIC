using System.Collections.Generic;
using System.Xml.Serialization;

namespace NT1Generator
{
    public class Contract
    {
        public string ContractCode { get; set; } 
        public ContractData ContractData { get; set; }

        [XmlArray]
        public List<Collateral> Collaterals { get; set; }

        public Company Company { get; set; }

        public Individual Individual { get; set; }

        public SubjectRole SubjectRole { get; set; }
    }
}
