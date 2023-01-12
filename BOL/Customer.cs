using System.ComponentModel.DataAnnotations;

namespace BOL;

public class Customer{
private int customer_Id;
// [Required]
private string customer_Name;
private string customer_Address;
private string customer_PAN;
private long customer_Mobile;

public string Customer_Name{
        get{return customer_Name;}
        set{customer_Name=value;}

    }
    public string Customer_Address{
        get{return customer_Address;}
        set{customer_Address=value;}

    }
    public string Customer_PAN{
        get{return customer_PAN;}
        set{customer_PAN=value;}

    }
    public long Customer_Mobile{
        get{return customer_Mobile;}
        set{customer_Mobile=value;}

    }
    public int Customer_Id{
        get{return customer_Id;}
        set{customer_Id=value;}

    }
   
    static int Customer_ID=001;
    

public Customer(){
    this.customer_Name="customer name";
    this.customer_Id=00001;
    this.customer_Address="My Address";
    this.customer_PAN="My PAN card";
    this.customer_Mobile=999999999;
}
public Customer(string name, string addr, string pan, long mob){
    this.customer_Name=name;
    this.customer_Address=addr;
    this.customer_PAN=pan;
    this.customer_Mobile=mob;
    this.customer_Id=Customer_ID;
    Customer_ID++;
}
}