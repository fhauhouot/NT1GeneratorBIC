using System;

namespace NT1Generator
{
    public class Individual
    {
        public String CustomerCode { get; set; }
        public String PresentSurname { get; set; }
        public String FirstName { get; set; }
        public String FullName { get; set; }
        public String MothersMaidenName { get; set; }
        public String ClassificationOfIndividual { get; set; }
        public String Gender { get; set; }
        public String DateOfBirth { get; set; }
        public String PlaceOfBirth { get; set; }
        public String MaritalStatus { get; set; }
        public String Residency { get; set; }
        public String Nationality { get; set; }
        public String Employment { get; set; }
        public String Education { get; set; }
        public String BusinessName { get; set; }
        public String PhoneNumber { get; set; }
        public String ProfessionalCategory { get; set; }
        public String PaiementIncident { get; set; }


        public IdentificationNumbers IdentificationNumbers { get; set; }
        public MainAddress MainAddress { get; set; }
        public Contacts Contacts { get; set; }
    }
}
