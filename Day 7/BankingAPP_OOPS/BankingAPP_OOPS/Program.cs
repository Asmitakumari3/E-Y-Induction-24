// See https://aka.ms/new-console-template for more information
using BankingAPP_OOPS;

Console.WriteLine("Hello, World!");


Savings savObj = new Savings();
savObj.accBalance = 15000;

Current curObj = new Current();
curObj.accBalance = 25000;

Console.WriteLine(savObj.Withdraw(18000));


