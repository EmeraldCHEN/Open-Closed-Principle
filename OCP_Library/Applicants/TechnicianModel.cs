
using OCP_Library.Account;

// namespace OCP_Library 
// --> Drag the item into the folder instead of creating the item inside the folder so the namespace is not as below
// namespaces can be changed directly
namespace OCP_Library.Applicants
{
    public class TechnicianModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new Accounts();
    }
}
