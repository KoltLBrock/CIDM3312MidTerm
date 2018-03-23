using System.Collections.Generic;
//repository, needs to be used
namespace EXAMMidTerm.Models{
    public static class Repository{
        private static List<LoginViewModel> accounts = new List<LoginViewModel>();
        public static IEnumerable<LoginViewModel> Accounts{
            get {
                return accounts;
            }
        }
        public static void AddAccount(LoginViewModel account){
            accounts.Add(account);
        }
    }
}