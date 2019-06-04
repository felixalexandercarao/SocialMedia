using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class FanAccountList
    {
        public List<FanAccount> fanAccountList { get; set; }
        public FanAccountList()
        {
            this.fanAccountList = new List<FanAccount>()
            {
                new FanAccount()
                {
                    FanAccountName="Beliebers",
                    FanAccountType="Person",
                    ID="FA-001",
                    Privacy="Public",
                    DateCreated=DateTime.Today
                },
                new FanAccount()
                {
                    FanAccountName="Lakers Fan Page",
                    FanAccountType="Sports Team",
                    ID="FA-002",
                    Privacy="Public",
                    DateCreated=DateTime.Today
                },
                new FanAccount()
                {
                    FanAccountName="Daigo Fan Page",
                    FanAccountType="Person",
                    ID="FA-003",
                    Privacy="Public",
                    DateCreated=DateTime.Today
                }
            };
        }
        public List<FanAccount> GetFanAccountList()
        {
            return this.fanAccountList;
        }

        public void AddFanAccount(FanAccount fa)
        {
            this.fanAccountList.Add(fa);
        }
        public void DeleteFanAccount(string deleteID)
        {
            this.fanAccountList.RemoveAll(s => s.ID == deleteID);
        }
    }
}
