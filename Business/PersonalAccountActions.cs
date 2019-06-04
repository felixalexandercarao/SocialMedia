using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;
namespace Business
{
    public class PersonalAccountActions
    {
        Repository.PersonalAccountList PAL = new Repository.PersonalAccountList();
        public void NewPersonalAccount(string NameInput, int AgeInput)
        {
            PersonalAccount newPersonalAccount = new PersonalAccount
            {
                PersonalAccountAge = AgeInput,
                PersonalAccountName = NameInput,
                ID = "PA-004",
                DateCreated = DateTime.Now,
                Privacy = "Public"
            };
            PAL.AddPersonalAccount(newPersonalAccount);
        }

        public void deletePersonalAccount(string DeleteID)
        {
            PAL.DeletePersonalAccount(DeleteID);
        }

        public List<PersonalAccount> viewPersonalAccount()
        {
            return PAL.GetPersonalAccountList();
        }
    }
}
