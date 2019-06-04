using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using Repository;
namespace Business
{
    class FanAccountActions
    {
        FanAccountList FAL = new FanAccountList();
        public List<FanAccount> fanAccountList()
        {

            return FAL.GetFanAccountList();
        }

        public void NewFanAccount(string NameInput, string TypeInput)
        {
            FanAccount newFanAccount = new FanAccount
            {
                FanAccountType = TypeInput,
                FanAccountName = NameInput,
                ID = "FA-004",
                DateCreated = DateTime.Now,
                Privacy = "Public"
            };
            FAL.AddFanAccount(newFanAccount);
        }

        public void deleteFanAccount(string DeleteID)
        {
            FAL.DeleteFanAccount(DeleteID);
        }
    }
}
