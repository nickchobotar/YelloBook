using System;

enum AccountState
{
    New,
    Active,
    UnderAudit,
    Frozen,
    Closed
} ;

  //A structure is a collection of C# variables which you want to 
    //    treat as a single entity. In C# a lump of data would 
    //    be called a structure and each part of it would be called a field.

struct Account  // Structure
{
    public AccountState State;  
    public string Name;   // these are fields
    public string Address;
    public int AccountNumber;
    public int Balance;
    public int Overdraft;
} ;

class BankProgram
{

    public static void PrintAccount(Account a)
    {
        Console.WriteLine("Name: " + a.Name);
        Console.WriteLine("Address: " + a.Address);
        Console.WriteLine("Balance: " + a.Balance);
    }

    public static void Main()
    {
        const int MAX_CUST = 100;
        Account[] Bank = new Account[MAX_CUST];
        Bank[0].Name = "Rob";
        Bank[0].Address = "Robs House";
        Bank[0].State = AccountState.Active;
        Bank[0].Balance = 1000000;
        
	PrintAccount(Bank[0]);
	        
	Bank[1].Name = "Jim";
        Bank[1].Address = "Jim's House";
        Bank[1].State = AccountState.Frozen;
        Bank[1].Balance = 0;
        
	PrintAccount(Bank[1]);
    }
}
