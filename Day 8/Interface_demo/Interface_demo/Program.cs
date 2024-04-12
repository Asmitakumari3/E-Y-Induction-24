// See https://aka.ms/new-console-template for more information
using Interface_demo;

Console.WriteLine("Hello, World!");

//ITransaction transaction = new ITransaction();

BankAccount account = new BankAccount(); //this object will have all the methods from
                            // all the interfaces which are implemented

ITransaction bkObj = new BankAccount(); //this obj will only methods from ITransaction


