using Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Repository;
namespace Business
{
    public class AddFanAccount
    {
        public void NewFanAccount(string NameInput, string TypeInput, List<FanAccount> fanAccountList)
        {
            FanAccount newFanAccount = new FanAccount
            {
                FanAccountType = TypeInput,
                FanAccountName = NameInput,
                ID = "FA-004",
                DateCreated = DateTime.Now,
                Privacy = "Public"
            };
            fanAccountList.Add(newFanAccount);

        }
    }
}
