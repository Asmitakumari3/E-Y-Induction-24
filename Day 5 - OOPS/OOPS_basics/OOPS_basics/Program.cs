

using Investment;
using OOPS_basics;
using OOPS_basics.Accounts;
using OOPS_basics.Investment;
#region rough code
//BankAccount acc = new BankAccount();

//Employee emp1 = new Employee();



//BankAccount bankAccount2 = new BankAccount();
//BankAccount bankAccount3 = new BankAccount();
//BankAccount bankAccount4 = new BankAccount();



//Console.WriteLine("Welcome to OOPS");
#endregion




//create a new object of Employee



Employee empObj = new Employee();
empObj.DisplayEmployeeInfo();
double result = empObj.IcrementSalary();

Console.WriteLine("New Salary is " + result);

Console.WriteLine("Enter First Number");
int n1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second Number");
int n2 =Convert.ToInt32(Console.ReadLine());

int addResult = empObj.Add(n1, n2);
Console.WriteLine("Addition is " + addResult);

GOLD
