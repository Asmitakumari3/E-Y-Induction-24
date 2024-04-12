

using System.Collections;

Console.WriteLine("Welcome to Collection Demo");

string name = "Nikhil";
name = "Kenny";

//when we want to store multiple value in a single variable, we use collections
//Sometime we know how many values we want to store, eg total students in a session, thus we will use 1 of the collection
//sometimes I dont know, how many will be there, use a different collection
//sometime we dont know what type of values will be stored in a collection

//10- int
//Ten - String
//sometimes we want to Identity the values, want to make sure they are unique, recognize them by, GPN no 
//Array
//ArrayList
//List
//Dictionary




//Array - use this when you know how many values you will store and which data type you will store
#region Array 1
//int[] myNumbers = new int[5];

//myNumbers[0] = 10;
//myNumbers[1] = 20;
//myNumbers[2] = 30;
//myNumbers[3] = 40;
//myNumbers[4] = 50;

//double total = 0;

//for (int i = 0; i < myNumbers.Length; i++)
//{
//    Console.WriteLine(myNumbers[i]);
//    total += myNumbers[i];
//}

//Console.WriteLine("Total of Array " + total);
#endregion

#region Array Int
//int favNumber = 0;
//Console.WriteLine("Enter Your Fav Number, between 1 and 20");
//favNumber = Convert.ToInt32(Console.ReadLine());

//int[] allNumbers = new int[favNumber];
//int totalOfAllNumber = 0;
//int evenNumbers = 0;
//int oddNumbers = 0;
//int totalNumbers = 0;
//int negativeNumbers = 0;

//for (int i = 0; i < allNumbers.Length; i++)
//{
//    Console.WriteLine("Enter Number " + (i +1 ));
//    allNumbers[i] = Convert.ToInt32(Console.ReadLine());

//    totalOfAllNumber = totalOfAllNumber + allNumbers[i];

//    if (allNumbers[i] < 0)
//    {
//        negativeNumbers++;
//    }

//    if (allNumbers[i] % 2 == 0)
//    {
//        evenNumbers++;
//    }
//    else
//    {
//        oddNumbers++;
//    }
//    totalNumbers++;
//}

//Console.WriteLine("Total Numbers entered : " + totalNumbers);
//Console.WriteLine("Sum of All the numbers : " + totalOfAllNumber);
//Console.WriteLine("Even Numbers : " + evenNumbers);
//Console.WriteLine("Odd Numbers : " + oddNumbers);
#endregion


#region guest Array - string
//int totalGuest = 0;
//Console.WriteLine("Please Enter How many guest you have");

//totalGuest =Convert.ToInt32(Console.ReadLine());
//string[] guestName = new string[totalGuest];
//int maleGuest = 0;
//int femaleGuest = 0;
//for (int i = 0; i < totalGuest; i++)
//{
//    Console.WriteLine("Please Enter Name of Guest #" + (i + 1) );
//    guestName[i] = Console.ReadLine();

//    Console.WriteLine("Male / Female ? ");
//    string gender = Console.ReadLine();
//    if (gender == "Male")
//    {
//        guestName[i] = "Mr." + guestName[i];
//        maleGuest++;
//    }
//    else
//    {
//        guestName[i] = "Mrs." + guestName[i];
//        femaleGuest++;
//    }

//}


//Console.WriteLine("Total Guest : " + totalGuest);
//Console.WriteLine("Male Guest : " + maleGuest);
//Console.WriteLine("Female Guest : " + femaleGuest);

//for (int i = 0; i < totalGuest; i++)
//{
//    Console.WriteLine(guestName[i]);
//}

#endregion

#region Array methods

//string[] array = new string[5];

//array[0] = "Nikhil";
//array[1] = "Arun";
//array[2] = "Karan";
//array[3] = "Mohan";
//array[4] = "Sumit";

//Console.WriteLine(array[3].ElementAt(3));
#endregion


//Array has below drawbacks
// If has to be of fixed size at the time of initilization
//if you get more values then initilized array, it will throw error/exception
//and if you provide less values, it will waste the memory

//Array are strongly typed, meaning you cannot work with multiple types in an array
//i.e if array is of string type, we can store only string and not other data types

//Instead we can use Arraylist which will be a solution to above problems

#region ArrayList
//ArrayList myList = new ArrayList();
//myList.Add("Nikhil");
//myList.Add(30);
//myList.Add(true);
//myList.Add(6.8);
//myList.Add("Mumbai");

//foreach (var item in myList)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Arraylist Dynamic
//Console.WriteLine("Please enter the value you want to ");
//ArrayList userValues = new ArrayList();

//bool continueTakeingValues = true;

//while (continueTakeingValues)
//{
//    var val = Console.ReadLine();
//    userValues.Add(val);
//    if(val == "")
//    {
//        continueTakeingValues=false;
//    }

//}

//foreach (var item in userValues)
//{
//    Console.WriteLine(item);
//}
#endregion


//if you want to have only specific type of data, but you do not know how many
//If I know the datatype, but I dont know the size, I can use List
#region List
//List<string> friends = new List<string>();
//friends.Add("Rohan");
//friends.Add("Rohan 1");
//friends.Add("Rohan 2");
//friends.Add("Rohan 3");
//friends.Add("Rohan 4");
//friends.Add("Rohan 5");
//friends.Add("Rohan 6");
//friends.Add("Rohan 7");
//friends.Add("Rohan 8");
//friends.Add("Rohan 9");
//friends.Add("Rohan 10");
//friends.Add("Rohan 11");
//friends.Add("Rohan 12");
//friends.Add("Rohan 13");
//friends.Add("Rohan 14");
//friends.Add("Rohan 15");
//friends.Add("Rohan 16");
//friends.Add(Console.ReadLine());
//friends.Add(Console.ReadLine());

//foreach (var item in friends)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("Total Friends : " + friends.Count);
#endregion

//sometimes we need to have a key and value, fir identity
//Thus we have dictionary

#region Dictionary
//Dictionary<int,string> studentInfo = new Dictionary<int,string>();

//studentInfo.Add(101, "Nikhil");
//studentInfo.Add(102, "Rohan");
//studentInfo.Add(103, "Mohan");
//studentInfo.Add(104, "Aarti");
//string value = Console.ReadLine();
//studentInfo.Add(105, value);
//foreach (var item in studentInfo)
//{
//    Console.WriteLine(item.Key + " - " + item.Value);
//}
#endregion

#region Dictionary Demo
//Dictionary<int,string> employeeList = new Dictionary<int,string>();
//int autoNumberKey = 0;

//bool continueTakeingValue = true;
//while (continueTakeingValue)
//{
//    Console.WriteLine("Enter Employee Name");
//    string employeeName = Console.ReadLine();
//    Console.WriteLine("Enter Employee Designation HR/Developer/DBA only");
//    string employeeDesignation = Console.ReadLine();
//    if (employeeName == "")
//    {
//        continueTakeingValue = false;
//    }
//    else
//    {
//        autoNumberKey++;
//        employeeList.Add(autoNumberKey, employeeName);
//    }
//}
//Console.Clear();
//Console.WriteLine("Total Employees " + employeeList.Count);
//Console.WriteLine("Press Enter to view the list");
//Console.ReadLine();

//foreach (var item in employeeList)
//{
//    Console.WriteLine("Employee Number : " + item.Key);
//    Console.WriteLine("Employee Name   : " + item.Value);
//    Console.WriteLine("---------------------------------------------");
//}
#endregion

























