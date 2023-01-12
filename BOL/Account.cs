namespace BOL;


public enum Account_Type {
    Saving,
    Current,
    Demat
}


public class Account:Customer
{
   
    private int account_no;
    private Account_Type type;
    private string? account_Branch;
    private double account_Balance;

    /*
A nullable type is a type that can represent the normal range of values for its underlying value type, plus an additional null value.
 In this case, string? is a nullable version of the string type, which means it can hold any string value, or the null value.

The ? syntax is used to denote a nullable type. It is equivalent to using the Nullable<T> structure,
 where T is the underlying value type.
    */

    static int Account_Number=100000;
    
    
    public Account_Type Type{
        get{return type;}
        set{type=value;}

    }
    public string? Account_Branch{
        get{return account_Branch;}
        set{account_Branch=value;}

    }
    public double Account_Balance{
        get{return account_Balance;}
        set{account_Balance=value;}

    }

    public Account(Account_Type Accttype, string branch, double balance, string name, string addr, string pan, long mob):base(name,addr, pan, mob){
        if (Accttype==Account_Type.Saving || Accttype ==Account_Type.Current || Accttype == Account_Type.Demat) {
            this.Type = Accttype;
        } else {
             throw new ArgumentException("Invalid value for MyEnum");
        }
        this.Account_Branch=branch;
        this.Account_Balance=balance;
        this.account_no=Account_Number;
        Account_Number++;


    }
    


}
