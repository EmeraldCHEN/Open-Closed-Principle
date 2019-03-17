
namespace OCP_Library.Account
{
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0,1)}{person.LastName}@corp.com";

            output.IsManager = true;

            return output;
        }
    }
}
