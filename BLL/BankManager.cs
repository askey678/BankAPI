namespace BLL;
using BOL;
using DAL;


public class BankManager
{

    public List<Account> GetAllAccountsMg(){
        List<Account> AccountList = new List<Account>();
        AccountList=DBManager.GetAllAccounts();
        return AccountList;
    }

}
