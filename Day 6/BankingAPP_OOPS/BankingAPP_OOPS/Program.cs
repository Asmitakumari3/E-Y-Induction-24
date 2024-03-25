// See https://aka.ms/new-console-template for more information
using BankingAPP_OOPS;

Console.WriteLine("Hello, World!");



Savings sav = new Savings(101, "Karan", "Savings", true, 5000); //This is a savings acc

Current cur = new Current(); //This is a current acc
PF pf = new PF(); //this is a PF acc


//BankAccount acc = new BankAccount(101,"Nikhil","BankAccount",true,5000); //what type of account is this
                                     //this is not a real world entity
                                     //thus we should not allow creation of Bankaccount object
                                     //Thus we will mark this class a abstract class
                                     //you cannot create an instance of abstract class


Salary sal = new  Salary();