using FileHelpers;

namespace NT1Generator
{
    public class Company
    {
        public string CustomerCode;
        public string CompanyName;
        public string TradeName;
        public string Residency;
        public string Nationality;
        public string Sigle;
        public string EconomicStatus;
        public string AnnualSales;
        public string LegalForm;
        public string BusinessStatus;
        public string EstablishmentDate;
        public string NumberOfEmployees;
        public string IndustrySector;
        public string PaiementIncident;

        public IdentificationNumbers IdentificationNumbers { get; set; }
        public MainAddress MainAddress { get; set; }
        public Contacts Contacts { get; set; }
    }
}
