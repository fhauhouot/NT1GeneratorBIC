using FileHelpers;
using System.Xml.Serialization;

namespace NT1Generator
{
    [DelimitedRecord(";")]
    public class ContractDataIn
    {
        [FieldDelimiter(";")]
        [XmlIgnore]
        public string ContractCode;

        [FieldDelimiter(";")]
        public string ConsentCode;

        [FieldDelimiter(";")]
        public string Branch;

        [FieldDelimiter(";")]
        public string PhaseOfContract;

        [FieldDelimiter(";")]
        public string ContractStatus;

        [FieldDelimiter(";")]
        public string TypeOfContract;

        [FieldDelimiter(";")]
        public string PurposeOfFinancing;

        [FieldDelimiter(";")]
        public string InterestRate;

        [FieldDelimiter(";")]
        public string CurrencyOfContract;

        [FieldDelimiter(";")]
        public string TotalAmount;

        [FieldDelimiter(";")]
        public string InstallmentAmount;

        [FieldDelimiter(";")]
        public string NumberOfInstallments;

        [FieldDelimiter(";")]
        public string OutstandingAmount;

        [FieldDelimiter(";")]
        public string PastDueAmount;

        [FieldDelimiter(";")]
        public string PastDueDays;

        [FieldDelimiter(";")]
        public string NumberOfDueInstallments;

        [FieldDelimiter(";")]
        public string TotalMonthlyPayment;

        [FieldDelimiter(";")]
        public string PaymentPeriodicity;

        [FieldDelimiter(";")]
        public string StartDate;

        [FieldDelimiter(";")]
        public string ExpectedEndDate;

        [FieldDelimiter(";")]
        public string RealEndDate;

        [FieldDelimiter(";")]
        public string Consented;

        [FieldDelimiter(";")]
        public string RecipientType;

        [FieldDelimiter(";")]
        public string CreditType;

        [FieldDelimiter(";")]
        public string InitialCreditTerm;

        [FieldDelimiter(";")]
        public string CreditTerm;

        [FieldDelimiter(";")]
        public string NatureOfGrantedCredit;

        [FieldDelimiter(";")]
        public string StateOfContract;

        [FieldDelimiter(";")]
        public string EffectiveCreditRate;

        [FieldDelimiter(";")]
        public string ContractLifeTime;

        [FieldDelimiter(";")]
        public string BelongsToGroup;

        [FieldDelimiter(";")]
        public string NegativeStatusOfContract;
    }
}
