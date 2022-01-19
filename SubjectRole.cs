using FileHelpers;
using System.Xml.Serialization;

namespace NT1Generator
{
    [DelimitedRecord(";")]
    public class SubjectRole
    {
        [FieldDelimiter(";")]
        [XmlIgnore]
        public string ContractCode;
        [FieldDelimiter(";")]
        public string CustomerCode;
        [FieldDelimiter(";")]
        public string RoleOfCustomer;
    }
}
