using OCP_Library.Account; // MUST using directive or an assembly reference

namespace OCP_Library.Applicants
{
    public class PersonModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new Accounts();
    }
}

