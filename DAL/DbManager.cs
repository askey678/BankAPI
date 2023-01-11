namespace DAL;

    using BOL;
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;

    public class DBManager
    {
        public static string conString = @"server=localhost;port=3306;user=root; password=akash@123;database=bank";       

        public static List<Account> GetAllAccounts()
        {
            List<Account> allAccounts = new List<Account>();

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = conString;

            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                string query = "SELECT acc.type, acc.branch, acc.balance, cust.name, cust.address, cust.PAN, cust.mobile FROM account acct, customer cust where cust.id=acct.cust_id";
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["Account_no"].ToString());
                    Account_Type type = (Account_Type)Enum.Parse(typeof(Account_Type), reader["type"].ToString(), true);
                    string branch = reader["branch"].ToString();
                    double balance = double.Parse(reader["balance"].ToString());
                    string name = reader["name"].ToString();
                    string addr = reader["address"].ToString();
                    string pan = reader["PAN"].ToString();
                    long mob = long.Parse(reader["mobile"].ToString());

                    Account acc = new Account(type, branch, balance, name, addr, pan, mob);
                    allAccounts.Add(acc);
                    Console.WriteLine(acc.ToString());
                }
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                throw;
            }
            finally
            {
                con.Close();
            }

            return allAccounts;
        }
    }

