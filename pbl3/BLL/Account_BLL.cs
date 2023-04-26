using pbl3.DAL;
using pbl3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3.BLL
{
    public class Account_BLL
    {
        private static Account_BLL instance;
        public static Account_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Account_BLL();
                }
                return instance;
            }

        }
        public Account GetAccountByUserName(String User)
        {
            foreach (Account a in Account_DAL.Instance.GetAccounts())
            {
                if (User == a.UserName)
                {
                    return a;
                }
            }
            return null;
        }
        public bool CheckAccount(String User, String Pass)
        {
            foreach (Account a in Account_DAL.Instance.GetAccounts())
            {
                if (User == a.UserName && Pass == a.Password)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddAccount(Account account)
        {
            Account_DAL.Instance.AddAccount(account);
        }
    }
}
