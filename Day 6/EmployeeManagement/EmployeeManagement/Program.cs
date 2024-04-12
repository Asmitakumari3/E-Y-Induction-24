// See https://aka.ms/new-console-template for more information
using EmployeeManagement;

Console.WriteLine("Employee Management");

//first object from emp class 
//values for properties - hardcoded, but we can take it from user, useing console.readline();


Employee empObj1 = new Employee(101, "Rohit", 10000, "Sales", true);
//empObj1.empNo = 1;
//empObj1.empName = "Rohit";
//empObj1.empDesigation = "Sales";
//empObj1.empSalary = 10000;
//empObj1.empIsPermenant = true;

Console.WriteLine("Employee Number : " + empObj1.empNo);
Console.WriteLine("Employee Name : " + empObj1.empName);
Console.WriteLine("Employee Designation : " + empObj1.empDesigation);
Console.WriteLine("Employee Salary : " + empObj1.empSalary);
Console.WriteLine("Employee Is Permenant : " + (empObj1.empIsPermenant?"Yes":"No"));

empObj1.ChangeDegisgnation("Sales Manager");
Console.WriteLine("Employee Designation : " + empObj1.empDesigation);
Console.WriteLine(empObj1.CalculateBonus(20));


Manager manObj = new Manager(); //what is the name ??, designation, salary ??
                                //it will be the one which is provided in base keyword, we have provided default value, and same will               
                                   //get inherited to all the manager object, which can be changed but not recommeded





