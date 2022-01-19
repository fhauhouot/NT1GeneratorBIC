using System.Xml.Serialization;

namespace NT1Generator
{
    public class IdentificationNumbers
    {
        // Company
        //RegistrationNumber
        [XmlElement(IsNullable = false)]
        public string RegistrationNumber { get; set; }

        [XmlElement(IsNullable = false)]
        public string RegistrationNumberIssuerCountry { get; set; }

        [XmlElement(IsNullable = false)]
        public string TaxNumber { get; set; }

        [XmlElement(IsNullable = false)]
        public string TaxNumberIssuerCountry { get; set; }

        // Individual
        //NationalID
        [XmlElement(IsNullable = false)]
        public string NationalID { get; set; }

        [XmlElement(IsNullable = false)]
        public string NationalIDIssueDate { get; set; }

        [XmlElement(IsNullable = false)]
        public string NationalIDExpirationDate { get; set; }

        [XmlElement(IsNullable = false)]
        public string NationalIDIssuerCountry { get; set; }

        //PassportNumber
        [XmlElement(IsNullable = false)]
        public string PassportNumber { get; set; }

        [XmlElement(IsNullable = false)]
        public string PassportIssueDate { get; set; }

        [XmlElement(IsNullable = false)]
        public string PassportExpirationDate{ get; set; }

        [XmlElement(IsNullable = false)]
        public string PassportIssuerCountry { get; set; }

        //ConsularCard
        [XmlElement(IsNullable = false)]
        public string ConsularCard { get; set; }

        [XmlElement(IsNullable = false)]
        public string ConsularCardIssueDate { get; set; }

        [XmlElement(IsNullable = false)]
        public string ConsularCardExpirationDate { get; set; }

        [XmlElement(IsNullable = false)]
        public string ConsularCardIssuerCountry { get; set; }

        // BIN
        [XmlElement(IsNullable = false)]
        public string BIN { get; set; }

        [XmlElement(IsNullable = false)]
        public string BINIssuerCountry { get; set; }

        //IdDocumentNumber
        [XmlElement(IsNullable = false)]
        public string IdDocumentNumber { get; set; }

        [XmlElement(IsNullable = false)]
        public string IdDocumentIssueDate { get; set; }

        [XmlElement(IsNullable = false)]
        public string IdDocumentExpirationDate { get; set; }

        [XmlElement(IsNullable = false)]
        public string IdDocumentIssuerCountry { get; set; }

        [XmlElement(IsNullable = false)]
        public string IdDocumentIssuerAuthority { get; set; }
    }
}
