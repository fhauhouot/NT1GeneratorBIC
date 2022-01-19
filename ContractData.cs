using System;
using System.Xml.Serialization;

namespace NT1Generator
{
    public class ContractData
    {
       
        [XmlIgnore]
        public String ContractCode{ get; set; }
        public String Consented { get; set; }
        public String ConsentCode{ get; set; }      
        public String Branch { get; set; }
        public String PhaseOfContract { get; set; }
        public String ContractStatus { get; set; }   
        public String TypeOfContract { get; set; }     
        public String PurposeOfFinancing { get; set; }   
        public String InterestRate { get; set; }     
        public String CurrencyOfContract { get; set; }
        public TotalAmount TotalAmount { get; set; }       
        public InstallmentAmount InstallmentAmount { get; set; }      
        public String NumberOfInstallments{ get; set; }  
        public OutstandingAmount OutstandingAmount { get; set; }      
        public PastDueAmount PastDueAmount { get; set; }     
        public String PastDueDays{ get; set; }      
        public String NumberOfDueInstallments{ get; set; }     
        public TotalMonthlyPayment TotalMonthlyPayment { get; set; }      
        public String PaymentPeriodicity{ get; set; }       
        public String StartDate{ get; set; }    
        public String ExpectedEndDate{ get; set; }
        [XmlElement(IsNullable = false)]
        public String RealEndDate{ get; set; }
        public String NegativeStatusOfContract { get; set; }
        public String EffectiveCreditRate { get; set; }
        public String ContractLifetime { get; set; }
        public String StateOfContract { get; set; }
        public String BelongsToGroup { get; set; }
        public String NatureOfGrantedCredit { get; set; }
        public String CreditTerm { get; set; }
        public String CreditType { get; set; }    
        public String RecipientType { get; set; }
        public String InitialCreditTerm { get; set; }

    }
}
