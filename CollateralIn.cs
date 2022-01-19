using FileHelpers;
using System;

namespace NT1Generator
{
    [DelimitedRecord(";")]
    public class CollateralIn
    {
        [FieldDelimiter(";")]
        public String ContractCode;

        [FieldDelimiter(";")]
        public string CollateralCode;

        [FieldDelimiter(";")]
        public String CollateralType;

        [FieldDelimiter(";")]
        public String CollateralDescription;

        [FieldDelimiter(";")]
        public String CollateralValue;

        [FieldDelimiter(";")]
        public String ValuationDate;
    }
}
