using FileHelpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace NT1Generator
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string rootDeclarationDirectory = @"C:\\Users\\fabrice.hauhouot\\OneDrive - MANSA BANK\\Projets et chantiers\\BIC\\Declarations_BIC\\202206\\";
                string declarationFileName = "240515280720_202206_M_DEF_2_XML";

                XmlSerializer serializer;

                Console.WriteLine("Bonjour, veuillez choisir l'option de traitement que vous souhaitez : \n");

                Console.WriteLine("a) Traitement du fichier aller");
                Console.WriteLine("b) Traitement du fichier retour ");
                Console.WriteLine("q) Quitter\n");
                Console.WriteLine("Votre choix : ");

                var answer = Console.ReadLine();

                if (answer.Trim().ToLower() == "a")
                {
                    FileHelperEngine<CompanyIn> companiesEngine = new FileHelperEngine<CompanyIn>();
                    FileHelperEngine<ContractDataIn> contractsEngine = new FileHelperEngine<ContractDataIn>();                    
                    FileHelperEngine <CollateralIn> collateralsEngine = new FileHelperEngine<CollateralIn>();
                    FileHelperEngine<SubjectRole> subjectrolesEngine = new FileHelperEngine<SubjectRole>();
                    FileHelperEngine<IndividualIn> individualsEngine = new FileHelperEngine<IndividualIn>();
                    
                    var companiesIn = companiesEngine.ReadFile(rootDeclarationDirectory + "companies.csv").ToList();
                    var contractDatasIn = contractsEngine.ReadFile(rootDeclarationDirectory + "contracts.csv").ToList();
                    var collateralsIn = collateralsEngine.ReadFile(rootDeclarationDirectory + "collaterals.csv").ToList();
                    var subjectroles = subjectrolesEngine.ReadFile(rootDeclarationDirectory + "subjectroles.csv").ToList();
                    var individualsIn = individualsEngine.ReadFile(rootDeclarationDirectory + "individuals.csv").ToList();
                               
                    List<Contract> contracts = new List<Contract>();
                    List<Company> companies = new List<Company>();
                    List<Individual> individuals = new List<Individual>();
                    List<Collateral> collaterals = new List<Collateral>();
                    List<ContractData> contractDatas = new List<ContractData>();

                    IdentificationNumbers identificationNumbers;
                    Contacts contacts;
                    MainAddress mainAddress;
                    CollateralValue collateralValue;
                    TotalMonthlyPayment totalMonthlyPayment;
                    TotalAmount totalAmount;
                    PastDueAmount pastDueAmount;
                    OutstandingAmount outstandingAmount;
                    InstallmentAmount installmentAmount;

                    Dictionary<string, string> RegistrationNumbers = new Dictionary<string, string>();

                    RegistrationNumbers.Add("384000042", "CISAS2019M2303");
                    RegistrationNumbers.Add("384002415", "CIABJ2019B21427");
                    RegistrationNumbers.Add("384002907", "CIABJ2019M04450");
                    RegistrationNumbers.Add("384002599", "CIABJ2020B11503");
                    RegistrationNumbers.Add("384000027", "CISAS2019M2766");
                    RegistrationNumbers.Add("384001415", "CIABJ2017B15751");

                    Company company;
                    foreach (CompanyIn companyIn in companiesIn)
                    {
                        company = new Company();

                        company.BusinessStatus = companyIn.BusinessStatus;
                        company.CompanyName = companyIn.CompanyName;
                        company.CustomerCode = companyIn.CustomerCode;
                        company.EstablishmentDate = companyIn.EstablishmentDate;
                    
                        if (companyIn.IndustrySector == "ProductionAndDistributionOfWaterSanitationWasteTreatmentAndD")
                        {
                            company.IndustrySector = "ProductionAndDistributionOfWaterSanitationWasteTreatmentAndDepollution";
                        }
                        else
                        {
                            company.IndustrySector = companyIn.IndustrySector;
                        }

                        if (companyIn.LegalForm == "AnonimousSociety")
                        {
                            company.LegalForm = "JointLiabilityCompany";
                        }
                        else
                        {
                            company.LegalForm = companyIn.LegalForm;
                        }
                        
                        company.TradeName = companyIn.TradeName;
                        company.EconomicStatus = companyIn.EconomicStatus;
                        company.Residency = companyIn.Residency;
                        company.Nationality = companyIn.Nationality;

                        if (String.IsNullOrEmpty(companyIn.Sigle))
                        {
                            company.Sigle = companyIn.TradeName;
                        }
                        else
                        {
                            company.Sigle = companyIn.TradeName;
                        }
                        
                        company.AnnualSales = "0";
                        company.NumberOfEmployees = "0";
                        company.PaiementIncident = "0";

                        identificationNumbers = new IdentificationNumbers();

                        if (RegistrationNumbers.ContainsKey(company.CustomerCode))
                            identificationNumbers.RegistrationNumber = RegistrationNumbers[company.CustomerCode];
                        else 
                            identificationNumbers.RegistrationNumber = companyIn.RegistrationNumber;

                        identificationNumbers.RegistrationNumberIssuerCountry = companyIn.RegistrationNumberCountry;
                        identificationNumbers.TaxNumber = companyIn.TaxNumber;
                        identificationNumbers.TaxNumberIssuerCountry = companyIn.TaxNumberIssuerCountry;
                        company.IdentificationNumbers = identificationNumbers;

                        contacts = new Contacts();
                        contacts.MobilePhone = companyIn.MobilePhone;
                        if (company.CustomerCode == "384002390") contacts.MobilePhone = "+22645304430";


                        company.Contacts = contacts;

                        mainAddress = new MainAddress();
                        mainAddress.City = null;
                        mainAddress.Country = null;
                        mainAddress.District = null;
                        mainAddress.GPS = null;
                        mainAddress.NumberOfBuilding = null;
                        mainAddress.POBox = null;
                        mainAddress.Region = null;
                        mainAddress.Street = null;
                        mainAddress.AddressLine = companyIn.AddressLine.Trim();
                        company.MainAddress = mainAddress;

                        companies.Add(company);
                    }

                    Individual individual;
                    foreach (IndividualIn individualIn in individualsIn)
                    {
                        individual = new Individual();
                        individual.CustomerCode = individualIn.CustomerCode;
                        individual.PresentSurname = individualIn.PresentSurname;
                        individual.FirstName = individualIn.FirstName;
                        individual.FullName = individualIn.FullName;
                        individual.MothersMaidenName = individualIn.MothersMaidenName;
                        individual.ClassificationOfIndividual = individualIn.ClassificationOfIndividual;
                        individual.Gender = individualIn.Gender;
                        individual.DateOfBirth = individualIn.DateOfBirth;
                        individual.PlaceOfBirth = individualIn.PlaceOfBirth;
                        individual.Residency = individualIn.Residency;
                        individual.Nationality = individualIn.Nationality;
                        individual.MaritalStatus = individualIn.MaritalStatus;
                        individual.PhoneNumber = individualIn.MobilePhone;
                        individual.ProfessionalCategory = "Employee";
                        individual.PaiementIncident = "0";

                        identificationNumbers = new IdentificationNumbers();

                        // NationalID
                        if (!String.IsNullOrEmpty(individualIn.NationalID))
                            identificationNumbers.NationalID = individualIn.NationalID;
                        if (!String.IsNullOrEmpty(individualIn.NationalIDIssueDate))
                            identificationNumbers.NationalIDIssueDate = individualIn.NationalIDIssueDate;
                        if (!String.IsNullOrEmpty(individualIn.NationalIDExpirationDate))
                            identificationNumbers.NationalIDExpirationDate = individualIn.NationalIDExpirationDate;
                        if (!String.IsNullOrEmpty(individualIn.NationalIDIssuerCountry))
                            identificationNumbers.NationalIDIssuerCountry = individualIn.NationalIDIssuerCountry;

                        if (individual.CustomerCode == "384001561")
                        {
                            individual.Nationality = "SN";
                            identificationNumbers.NationalIDIssuerCountry = "SN";
                        }

                        // PassportNumber
                        if (!String.IsNullOrEmpty(individualIn.PassportNumber))
                            identificationNumbers.PassportNumber = individualIn.PassportNumber;
                        if (!String.IsNullOrEmpty(individualIn.PassportIssueDate))
                            identificationNumbers.PassportIssueDate = individualIn.PassportIssueDate;
                        if (!String.IsNullOrEmpty(individualIn.PassportExpirationDate))
                            identificationNumbers.PassportExpirationDate = individualIn.PassportExpirationDate;
                        if (!String.IsNullOrEmpty(individualIn.PassportIssuerCountry))
                            identificationNumbers.PassportIssuerCountry = individualIn.PassportIssuerCountry;

                        // ConsularCard
                        if (!String.IsNullOrEmpty(individualIn.ConsularCard))
                            identificationNumbers.ConsularCard = individualIn.ConsularCard;
                        if (!String.IsNullOrEmpty(individualIn.ConsularCardIssueDate))
                            identificationNumbers.ConsularCardIssueDate = individualIn.ConsularCardIssueDate;
                        if (!String.IsNullOrEmpty(individualIn.ConsularCardExpirationDate))
                            identificationNumbers.ConsularCardExpirationDate = individualIn.ConsularCardExpirationDate;
                        if (!String.IsNullOrEmpty(individualIn.ConsularCardIssuerCountry))
                            identificationNumbers.ConsularCardIssuerCountry = individualIn.ConsularCardIssuerCountry;

                        // IdDocumentNumber
                        if (!String.IsNullOrEmpty(individualIn.IdDocumentNumber))
                            identificationNumbers.IdDocumentNumber = individualIn.IdDocumentNumber;
                        if (!String.IsNullOrEmpty(individualIn.IdDocumentIssueDate))
                            identificationNumbers.IdDocumentIssueDate = individualIn.IdDocumentIssueDate;
                        if (!String.IsNullOrEmpty(individualIn.IdDocumentExpirationDate))
                            identificationNumbers.IdDocumentExpirationDate = individualIn.IdDocumentExpirationDate;
                        if (!String.IsNullOrEmpty(individualIn.IdDocumentIssuerCountry))
                            identificationNumbers.IdDocumentIssuerCountry = individualIn.IdDocumentIssuerCountry;
                        if (!String.IsNullOrEmpty(individualIn.IdDocumentIssuerAuthority))
                            identificationNumbers.IdDocumentIssuerAuthority = individualIn.IdDocumentIssuerAuthority;

                        individual.IdentificationNumbers = identificationNumbers;

                        contacts = new Contacts();
                        contacts.MobilePhone = individualIn.MobilePhone;
                        individual.Contacts = contacts;

                        mainAddress = new MainAddress();
                        mainAddress.AddressLine = individualIn.AddressLine;
                        individual.MainAddress = mainAddress;

                        individuals.Add(individual);
                    }

                    Collateral collateral;
                    foreach (CollateralIn collateralIn in collateralsIn)
                    {
                        collateral = new Collateral();

                        collateral.CollateralCode = collateralIn.CollateralCode;
                        collateral.CollateralDescription = collateralIn.CollateralDescription;
                        collateral.CollateralType = collateralIn.CollateralType;
                        collateral.ContractCode = collateralIn.ContractCode;

                        //CultureInfo culture = new CultureInfo("fr-FR");
                        //DateTime dateTime = Convert.ToDateTime(collateralIn.ValuationDate, culture);
                        collateral.ValuationDate = collateralIn.ValuationDate;

                        collateralValue = new CollateralValue();
                        collateralValue.Value = collateralIn.CollateralValue;
                        collateralValue.Currency = "XOF";
                        collateral.CollateralValue = collateralValue;

                        collaterals.Add(collateral);
                    }

                    ContractData contractData;
                    foreach (ContractDataIn contractDataIn in contractDatasIn)
                    {
                        contractData = new ContractData();

                        contractData.ConsentCode = contractDataIn.ConsentCode;
                        contractData.ContractCode = contractDataIn.ContractCode;
                        contractData.Branch = contractDataIn.Branch;
                        contractData.PhaseOfContract = contractDataIn.PhaseOfContract;
                        contractData.ContractStatus = contractDataIn.ContractStatus;
                        contractData.TypeOfContract = contractDataIn.TypeOfContract;
                        contractData.PurposeOfFinancing = contractDataIn.PurposeOfFinancing;
                        contractData.InterestRate = contractDataIn.InterestRate.Replace(',', '.');
                        contractData.CurrencyOfContract = contractDataIn.CurrencyOfContract;
                        contractData.NumberOfInstallments = contractDataIn.NumberOfInstallments;
                        contractData.PastDueDays = contractDataIn.PastDueDays;
                        contractData.NumberOfDueInstallments = contractDataIn.NumberOfDueInstallments;
                        contractData.PaymentPeriodicity = contractDataIn.PaymentPeriodicity;
                        contractData.StartDate = contractDataIn.StartDate;
                        contractData.ExpectedEndDate = contractDataIn.ExpectedEndDate;
                        contractData.RealEndDate = contractDataIn.RealEndDate;

                        contractData.Consented = contractDataIn.Consented == "O" ? "Yes" : "No";
                        contractData.RecipientType = contractDataIn.RecipientType;
                        contractData.CreditType = contractDataIn.CreditType;
                        contractData.InitialCreditTerm = contractDataIn.InitialCreditTerm;
                        contractData.CreditTerm = contractDataIn.CreditTerm;
                        contractData.NatureOfGrantedCredit = contractDataIn.NatureOfGrantedCredit;
                        contractData.StateOfContract = contractDataIn.StateOfContract;
                        contractData.EffectiveCreditRate = contractDataIn.EffectiveCreditRate.Replace(',', '.');
                        contractData.ContractLifetime = contractDataIn.ContractLifeTime;
                        contractData.BelongsToGroup = contractDataIn.BelongsToGroup;
                        contractData.NegativeStatusOfContract = contractDataIn.NegativeStatusOfContract;

                        totalMonthlyPayment = new TotalMonthlyPayment();
                        totalMonthlyPayment.Currency = "XOF";
                        totalMonthlyPayment.Value = contractDataIn.TotalMonthlyPayment;
                        contractData.TotalMonthlyPayment = totalMonthlyPayment;

                        totalAmount = new TotalAmount();
                        totalAmount.Currency = "XOF";
                        totalAmount.Value = contractDataIn.TotalAmount;
                        contractData.TotalAmount = totalAmount;

                        pastDueAmount = new PastDueAmount();
                        outstandingAmount = new OutstandingAmount();
                        pastDueAmount.Currency = "XOF";
                        outstandingAmount.Currency = "XOF";

                        if (contractData.ContractStatus == "SettledInAdvance" || contractData.ContractStatus == "SettledOnTime")
                        {
                            pastDueAmount.Value = "0";
                            outstandingAmount.Value = "0";
                        }
                        else
                        {
                            pastDueAmount.Value = String.IsNullOrEmpty(contractDataIn.PastDueAmount) ? "0" : contractDataIn.PastDueAmount; 
                            outstandingAmount.Value = String.IsNullOrEmpty(contractDataIn.OutstandingAmount) ? "0" : contractDataIn.OutstandingAmount;
                        }

                        contractData.PastDueAmount = pastDueAmount;
                        contractData.OutstandingAmount = outstandingAmount;

                        installmentAmount = new InstallmentAmount();
                        installmentAmount.Currency = "XOF";
                        installmentAmount.Value = contractDataIn.InstallmentAmount;
                        contractData.InstallmentAmount = installmentAmount;

                        contractDatas.Add(contractData);
                    }

                    foreach (var contractDataFinal in contractDatas)
                    {
                        Contract contract = new Contract();
                        contract.ContractCode = contractDataFinal.ContractCode;

                        contract.ContractData = contractDataFinal;
                        contract.Collaterals = collaterals.Where(c => c.ContractCode == contractDataFinal.ContractCode).ToList();
                        contract.Company = companies.Where(c => c.CustomerCode == contractDataFinal.ConsentCode).FirstOrDefault();
                        contract.Individual = individuals.Where(i => i.CustomerCode == contractDataFinal.ConsentCode).FirstOrDefault();
                        contract.SubjectRole = subjectroles.Where(s => s.ContractCode == contractDataFinal.ContractCode).FirstOrDefault();

                        contracts.Add(contract);
                    }

                    Batch batch = new Batch();
                    batch.BatchIdentifier = declarationFileName;
                    batch.Contracts = contracts;

                    serializer = new XmlSerializer(typeof(Batch));
                    serializer.Serialize(File.Create(rootDeclarationDirectory + "contracts.xml"), batch);
                    
                }

                else if (answer.Trim().ToLower() == "b")
                {
                    serializer = new XmlSerializer(typeof(BatchResponse));
                    BatchResponse batchResponse;

                    using (FileStream fileStream = new FileStream(rootDeclarationDirectory + "Data.XML", FileMode.Open))
                    {
                        batchResponse = (BatchResponse)serializer.Deserialize(fileStream);
                    }

                    FileHelperEngine<Item> itemsEngine = new FileHelperEngine<Item>();
                    itemsEngine.WriteFile(rootDeclarationDirectory + "Data.CSV", batchResponse.Items/*.Where(i => i.Severity == "ERREUR")*/.ToList());
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }        
        }
    }
}
