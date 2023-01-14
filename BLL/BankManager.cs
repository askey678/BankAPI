namespace BLL;
using BOL;
using DAL.connected;


public class BankManager
{

    public List<Account> GetAllAccountsMg(){
        List<Account> AccountList = new List<Account>();
        AccountList=DBManager.GetAllAccounts();
        return AccountList;
    }

    public Account GetAccountMg(Account acc){
      Account account=acc;
      Console.WriteLine("askey"+account.Account_Balance);
        return account;
    }


}
