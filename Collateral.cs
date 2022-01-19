using System;
using System.Xml.Serialization;

namespace NT1Generator
{
    public class Collateral
    {
        [XmlIgnore]
        public String ContractCode { get; set; }
        public String CollateralCode { get; set; }
        public String CollateralType { get; set; }
        public String CollateralDescription { get; set; }
        public CollateralValue CollateralValue { get; set; }
        public String ValuationDate { get; set; }

    }
}
