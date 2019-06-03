using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Business
{
    public class DeletePersonalAccount
{
        public void deletePersonalAccount(string DeleteID, List<PersonalAccount> personalAccountList)
        {
            personalAccountList.RemoveAll(s => DeleteID == s.ID);
        }
    }
}
