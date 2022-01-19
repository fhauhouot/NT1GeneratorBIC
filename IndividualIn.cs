using FileHelpers;
using System.Xml.Serialization;

namespace NT1Generator
{
    [DelimitedRecord(";")]
    public class IndividualIn
    {
        [FieldDelimiter(";")]
        public string CustomerCode;

        [FieldDelimiter(";")]
        public string PresentSurname;

        [FieldDelimiter(";")]
        public string FirstName;

        [FieldDelimiter(";")]
        public string FullName;

        [FieldDelimiter(";")]
        public string MothersMaidenName;

        [FieldDelimiter(";")]
        public string ClassificationOfIndividual;

        [FieldDelimiter(";")]
        public string Gender;

        [FieldDelimiter(";")]
        public string DateOfBirth;

        [FieldDelimiter(";")]
        public string CountryOfBirth;

        [FieldDelimiter(";")]
        public string PlaceOfBirth;

        [FieldDelimiter(";")]
        public string MaritalStatus;

        [FieldDelimiter(";")]
        public string Residency;

        [FieldDelimiter(";")]
        public string Nationality;

        [FieldDelimiter(";")]
        public string ProfessionalCategory;

        [FieldDelimiter(";")]
        public string PaiementIncident;

        [XmlElement(IsNullable = false)]
        [FieldDelimiter(";")]
        public string NationalID;

        [XmlElement(IsNullable = false)]
        [FieldDelimiter(";")]
        public string NationalIDIssueDate;

        [XmlElement(IsNullable = false)]
        [FieldDelimiter(";")]
        public string NationalIDExpirationDate;

        [XmlElement(IsNullable = false)]
        [FieldDelimiter(";")]
        public string NationalIDIssuerCountry;

        [XmlElement(IsNullable = true)]
        [FieldDelimiter(";")]
        public string PassportNumber;

        [XmlElement(IsNullable = true)]
        [FieldDelimiter(";")]
        public string PassportIssueDate;

        [XmlElement(IsNullable = true)]
        [FieldDelimiter(";")]
        public string PassportExpirationDate;

        [XmlElement(IsNullable = true)]
        [FieldDelimiter(";")]
        public string PassportIssuerCountry;

        [XmlElement(IsNullable = false)]
        [FieldDelimiter(";")]
        public string ConsularCard;

        [XmlElement(IsNullable = false)]
        [FieldDelimiter(";")]
        public string ConsularCardIssueDate;

        [XmlElement(IsNullable = false)]
        [FieldDelimiter(";")]
        public string ConsularCardExpirationDate;

        [XmlElement(IsNullable = false)]
        [FieldDelimiter(";")]
        public string ConsularCardIssuerCountry;

        [XmlElement(IsNullable = false)]
        [FieldDelimiter(";")]
        public string IdDocumentNumber;

        [XmlElement(IsNullable = false)]
        [FieldDelimiter(";")]
        public string IdDocumentIssueDate;

        [XmlElement(IsNullable = false)]
        [FieldDelimiter(";")]
        public string IdDocumentExpirationDate;

        [XmlElement(IsNullable = false)]
        [FieldDelimiter(";")]
        public string IdDocumentIssuerCountry;

        [XmlElement(IsNullable = false)]
        [FieldDelimiter(";")]
        public string IdDocumentIssuerAuthority;

        [FieldDelimiter(";")]
        public string AddressLine;

        [FieldDelimiter(";")]
        public string MobilePhone;
    }
}
