
using OOPS_Basics2;

Console.WriteLine("Hello, World!");

Calculations calObj = new Calculations();
//int addResult = calObj.Add(10, 20, 30);

//Console.WriteLine(calObj.Add("Nikhil", "Shah"));

//Console.WriteLine(addResult);

//int result = calObj.Add(10, 20, 30, 40, 50, 60, 70, 70, 50, 30);
//Console.WriteLine(result);

//Console.WriteLine(calObj.AddEmployee("Jay","Shah"));
//Console.WriteLine(calObj.AddEmployee("Ankita","Jaiswal",dept:"HR"));
//Console.WriteLine(calObj.AddEmployee("Hussain","Ahmed",dept:"Development",designation:"Front End programmer"));
//Console.WriteLine(calObj.AddEmployee("Prachi","Shah","Development","UI Designer"));

Console.WriteLine(calObj.CalculateNumbers(20, 10, OperationType.Add));




//Employee employeeObj = new Employee();

//employeeObj.EmpNo = 105; // this is the set part
//Console.WriteLine(employeeObj.EmpNo); //this is get part which will return value stored in v_empNo








Console.WriteLine("How many employees you want to generate ? ");
int totalEmpObjs = Convert.ToInt32(Console.ReadLine());

List<Employee> empList = new List<Employee>();
Employee empObj = new Employee();

for (int i = 0; i < totalEmpObjs; i++)
{
    empObj = new Employee();
    empObj.EmpNo = i;
 
    Console.WriteLine("Enter name of employee no " + (i + 1));
    empObj.EmpName = Console.ReadLine();
    Console.WriteLine("Enter Salary");

    empObj.EmployeeSalary = Convert.ToDouble(Console.ReadLine());

    empList.Add(empObj);   
}

double totalSalary = 0;
foreach (var item in empList)
{
    totalSalary = totalSalary + item.EmployeeSalary;
    Console.WriteLine(item.EmpNo);
    Console.WriteLine(item.EmpName);
    Console.WriteLine("------------------------------");

}

Console.WriteLine("Total Salary Paid is " + totalSalary);















