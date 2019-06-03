using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Business
{
    public class ViewPersonalAccount
    {
        public void viewPersonalAccount(List<PersonalAccount> personalAccountList)
        {
            foreach (PersonalAccount PA in personalAccountList)
            {
                Console.WriteLine("Name: {0} || Age: {1} || ID: {2} || Date Created: {3}", PA.PersonalAccountName, PA.PersonalAccountAge, PA.ID,PA.DateCreated);
            }
        }
    }
}
