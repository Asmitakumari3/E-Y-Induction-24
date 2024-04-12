// See https://aka.ms/new-console-template for more information
using Static_demo;


#region HardCode
//EmployeeInfo emp1 = new EmployeeInfo(name, designation);

//EmployeeInfo emp2 = new EmployeeInfo("Ravi", designation);

//EmployeeInfo emp3 = new EmployeeInfo("Trisha", designation);

//EmployeeInfo emp4 = new EmployeeInfo("Sumit", designation);

//EmployeeInfo emp5 = new EmployeeInfo("John", designation);


//Console.WriteLine("Employee Number " + emp1.empNo);
//Console.WriteLine("Employee Designation " + emp1.empDesignation);
//Console.WriteLine("Employee Name " + emp1.empName);

//Console.WriteLine("Employee Number " + emp2.empNo);
//Console.WriteLine("Employee Designation " + emp2.empDesignation);
//Console.WriteLine("Employee Name " + emp2.empName);

//Console.WriteLine("Employee Number " + emp3.empNo);
//Console.WriteLine("Employee Designation " + emp3.empDesignation);
//Console.WriteLine("Employee Name " + emp3.empName);

//Console.WriteLine("Employee Number " + emp4.empNo);
//Console.WriteLine("Employee Designation " + emp4.empDesignation);
//Console.WriteLine("Employee Name " + emp4.empName);

//Console.WriteLine("Employee Number " + emp5.empNo);
//Console.WriteLine("Employee Designation " + emp5.empDesignation);
//Console.WriteLine("Employee Name " + emp5.empName);


#endregion


List<EmployeeInfo> eList = new List<EmployeeInfo>();

bool moreObjs = true;

while (moreObjs)
{
    Console.WriteLine("Enter Name");
    string eName = Console.ReadLine();


    Console.WriteLine("Enter Designation");
    string eDesignation= Console.ReadLine();


    EmployeeInfo empObj = new EmployeeInfo(eName,eDesignation);
      eList.Add(empObj);
    Console.WriteLine("Employee Created, Emp No " + empObj.empNo);

    Console.WriteLine("-----------------");
    Console.WriteLine("Add More Employees ? ");
  
    Console.WriteLine("1.yes ");
    Console.WriteLine("2.No ");
    int more = Convert.ToInt32(Console.ReadLine());
    if (more == 2)
    {
        moreObjs = false;
    }
}





