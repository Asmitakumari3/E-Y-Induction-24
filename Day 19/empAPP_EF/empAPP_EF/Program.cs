// See https://aka.ms/new-console-template for more information
using empAPP_EF.DB;
Console.WriteLine("Hello, World!");


EmployeeInfoDbEfContext db = new EmployeeInfoDbEfContext();

var emp = from a in db.EmployeeInfos
          where a.EmpSalary > 25000
          select a;

foreach (var item in emp)
{
    Console.WriteLine(item.EmpNo);
    Console.WriteLine(item.EmpName);
    Console.WriteLine(item.EmpDesignation);
    Console.WriteLine(" -------------------- ");
}