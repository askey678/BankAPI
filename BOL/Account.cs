namespace BOL;


public enum Account_Type {
    Saving,
    Current,
    Demat
}

public class Account:Customer
{
   
    private int Account_No{get; set;}
    private Account_Type Type{get; set;}
    private string? Account_Branch{get; set;}
    private double Account_Balance{get; set;}

    /*
A nullable type is a type that can represent the normal range of values for its underlying value type, plus an additional null value.
 In this case, string? is a nullable version of the string type, which means it can hold any string value, or the null value.

The ? syntax is used to denote a nullable type. It is equivalent to using the Nullable<T> structure,
 where T is the underlying value type.
    */

    public Account(Account_Type Accttype, string branch, double balance, string name, int id, string addr, string pan, long mob):base(name, id, addr, pan, mob){
        if (Accttype==Account_Type.Saving || Accttype ==Account_Type.Current || Accttype == Account_Type.Demat) {
            this.Type = Accttype;
        } else {
             throw new ArgumentException("Invalid value for MyEnum");
        }
        this.Account_Branch=branch;
        this.Account_Balance=balance;


    }
    


}
