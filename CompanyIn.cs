using FileHelpers;

namespace NT1Generator
{
    [DelimitedRecord(";")]
    public class CompanyIn
    {
        [FieldDelimiter(";")]
        public string CustomerCode;

        [FieldDelimiter(";")]
        public string CompanyName;

        [FieldDelimiter(";")]
        public string TradeName;

        [FieldDelimiter(";")]
        public string LegalForm;

        [FieldDelimiter(";")]
        public string BusinessStatus;

        [FieldDelimiter(";")]
        public string EstablishmentDate;

        [FieldDelimiter(";")]
        public string IndustrySector;

        [FieldDelimiter(";")]
        public string EconomicStatus;

        [FieldDelimiter(";")]
        public string Residency;

        [FieldDelimiter(";")]
        public string Nationality;

        [FieldDelimiter(";")]
        public string Sigle;

        [FieldDelimiter(";")]
        public string RegistrationNumber;

        [FieldDelimiter(";")]
        public string RegistrationNumberCountry;

        [FieldDelimiter(";")]
        public string TaxNumber;

        [FieldDelimiter(";")]
        public string TaxNumberIssuerCountry;

        [FieldDelimiter(";")]
        public string AddressLine;

        [FieldDelimiter(";")]
        public string MobilePhone;
    }
}
