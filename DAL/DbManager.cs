namespace DAL;
using BOL;
public class DbManager
{

public static List<Account> GetAllAccounts (){
    List<Account> allAccounts = new List<Account>();
    allAccounts.Add( new Account(Account_Type.Saving, "New York", 1000.00, "John Smith", 12345, "123 Main Street", "ABC123", 5555555555));
    allAccounts.Add( new Account(Account_Type.Current, "New Delhi", 1000.00, "Akash Smith", 12345, "123 Main Street", "ABC123", 44444455555));
    allAccounts.Add( new Account(Account_Type.Saving, "Pune", 1000.00, "Sushil Smith", 12345, "123 Main Street", "ABC123", 66665555555));
    allAccounts.Add( new Account(Account_Type.Saving, "Jaipur ", 1000.00, "Only Smith", 12345, "123 Main Street", "ABC123", 777777777777));
    allAccounts.Add( new Account(Account_Type.Saving, "New Mumbai", 1000.00, "John Smith", 12345, "123 Main Street", "ABC123", 5555555555));
    allAccounts.Add( new Account(Account_Type.Demat, "New York", 1000.00, "John Smith", 12345, "123 Main Street", "ABC123", 101010101101));
    allAccounts.Add( new Account(Account_Type.Saving, "New York", 1000.00, "John Smith", 12345, "123 Main Street", "ABC123", 202020202202));
    allAccounts.Add( new Account(Account_Type.Saving, "New York", 1000.00, "John Smith", 12345, "123 Main Street", "ABC123", 5555555555));
    allAccounts.Add( new Account(Account_Type.Saving, "New York", 1000.00, "John Smith", 12345, "123 Main Street", "ABC123", 5555555555));
    allAccounts.Add( new Account(Account_Type.Current, "New York", 1000.00, "John Smith", 12345, "123 Main Street", "ABC123", 5555555555));
    allAccounts.Add( new Account(Account_Type.Saving, "New York", 1000.00, "John Smith", 12345, "123 Main Street", "ABC123", 5555555555));
    allAccounts.Add( new Account(Account_Type.Saving, "New York", 1000.00, "John Smith", 12345, "123 Main Street", "ABC123", 5555555555));
    allAccounts.Add( new Account(Account_Type.Saving, "New York", 1000.00, "John Smith", 12345, "123 Main Street", "ABC123", 5555555555));
    allAccounts.Add( new Account(Account_Type.Saving, "New York", 1000.00, "John Smith", 12345, "123 Main Street", "ABC123", 5555555555));
    allAccounts.Add( new Account(Account_Type.Saving, "New York", 1000.00, "John Smith", 12345, "123 Main Street", "ABC123", 5555555555));
    allAccounts.Add( new Account(Account_Type.Saving, "New York", 1000.00, "John Smith", 12345, "123 Main Street", "ABC123", 5555555555));
    allAccounts.Add( new Account(Account_Type.Saving, "New York", 1000.00, "John Smith", 12345, "123 Main Street", "ABC123", 5555555555));
    allAccounts.Add( new Account(Account_Type.Saving, "New York", 1000.00, "John Smith", 12345, "123 Main Street", "ABC123", 5555555555));
    allAccounts.Add( new Account(Account_Type.Saving, "New York", 1000.00, "John Smith", 12345, "123 Main Street", "ABC123", 5555555555));
    allAccounts.Add( new Account(Account_Type.Saving, "New York", 1000.00, "John Smith", 12345, "123 Main Street", "ABC123", 5555555555));
    
    return allAccounts;

}
}
