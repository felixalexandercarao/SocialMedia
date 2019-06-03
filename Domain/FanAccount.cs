using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{ 
    public class FanAccount:BaseClass
    {
        public string FanAccountName { get; set; }
        public string FanAccountType { get; set; }

        public void test()
        {
            PersonalAccount c = new PersonalAccount()
            {
                PersonalAccountName = "Lex Carao",
                PersonalAccountAge = 22,
                ID = "PA-001",
                Privacy = "Public",
                DateCreated = DateTime.Today
            };
        }
    }
}
