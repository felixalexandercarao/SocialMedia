using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using System.Linq;
namespace Business
{
    public class DeleteFanAccount
    {
        public void deleteFanAccount(string DeleteID, List<FanAccount> fanAccountList)
        {
            fanAccountList.RemoveAll(s => DeleteID == s.ID);
        }
    }
}
