using Entity;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class PersonalAccountList
    {
        public List<PersonalAccount> personalAccountList { get; set; }
        public PersonalAccountList()
        {
            this.personalAccountList = new List<PersonalAccount>()
            {
                new PersonalAccount()
                {
                    PersonalAccountName ="Lex Carao",
                    PersonalAccountAge =22,
                    ID="PA-001",
                    Privacy="Public",
                    DateCreated= DateTime.Today
                },
                new PersonalAccount()
                {
                    PersonalAccountName ="Dino Reyes",
                    PersonalAccountAge =29,
                    ID="PA-002",
                    Privacy="Public",
                    DateCreated= DateTime.Today
                },
                new PersonalAccount()
                {
                    PersonalAccountName ="Melrose Mejidana",
                    PersonalAccountAge =21,
                    ID="PA-003",
                    Privacy="Public",
                    DateCreated= DateTime.Today
                }
            };
        }

        public List<PersonalAccount> GetPersonalAccountList()
        {
            return this.personalAccountList;
        }

        public void AddPersonalAccount(PersonalAccount pa)
        {
            this.personalAccountList.Add(pa);
        }
        public void DeletePersonalAccount(string deleteID)
        {
            this.personalAccountList.RemoveAll(s=>s.ID== deleteID);
        }
    }
}
