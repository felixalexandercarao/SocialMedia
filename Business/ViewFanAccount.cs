using System;
using System.Collections.Generic;
using System.Text;
using Repository;
using Entity;

namespace Business
{
    public class ViewFanAccount
    {
        public void viewFanAccount(List<FanAccount> fanAccountList)
        {

            foreach (FanAccount FA in fanAccountList)
            {
                Console.WriteLine("Name: {0} || Type: {1} || ID: {2}", FA.FanAccountName, FA.FanAccountType, FA.ID);
            }
        }
    }
}