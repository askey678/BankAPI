using System.ComponentModel.DataAnnotations;

namespace BOL;

public class Customer{
    private int customer_Id{get; set;}

[Required]
private string customer_Name{get; set;}
private string customer_Address{get; set;}
private string customer_PAN{get; set;}
private long customer_Mobile{get; set;}

public Customer(){
    this.customer_Name="customer name";
    this.customer_Id=00001;
    this.customer_Address="My Address";
    this.customer_PAN="My PAN card";
    this.customer_Mobile=999999999;
}
public Customer(string name, int id, string addr, string pan, long mob){
    this.customer_Name=name;
    this.customer_Id=id;
    this.customer_Address=addr;
    this.customer_PAN=pan;
    this.customer_Mobile=mob;
}
}