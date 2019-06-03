using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class AddPersonalAccount
    {
        public void NewPersonalAccount(string NameInput,int AgeInput, List<PersonalAccount> personalAccountList)
        {
            PersonalAccount newPersonalAccount = new PersonalAccount
            {
                PersonalAccountAge = AgeInput,
                PersonalAccountName = NameInput,
                ID = "PA-004",
                DateCreated = DateTime.Now,
                Privacy = "Public"
            };
            personalAccountList.Add(newPersonalAccount);
        }
    }
}
