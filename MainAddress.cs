using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NT1Generator
{
    public class MainAddress
    {
        [XmlElement(IsNullable = false)]
        public string POBox { get; set; }
        [XmlElement(IsNullable = false)]
        public string Street { get; set; }
        [XmlElement(IsNullable = false)]
        public string NumberOfBuilding { get; set; }
        [XmlElement(IsNullable = false)]
        public string City { get; set; }
        [XmlElement(IsNullable = false)]
        public string Region { get; set; }
        [XmlElement(IsNullable = false)]
        public string District { get; set; }
        [XmlElement(IsNullable = false)]
        public string Country { get; set; }
        [XmlElement(IsNullable = false)]
        public string GPS { get; set; }
        public string AddressLine { get; set; }
    }
}
