

Console.WriteLine("Welcome to C# Programming");


#region First example
//datatypes 
//they are divided as 2
//1. primitive datatypes --- String, int, double, char,bool etc..the 1 which are provided by .net core/framework 
//2. Custom datatype / user defined datatypes /UDT - created by developers with the help of class

//bool isPermenantEmployee = false;
//string myName = "Nikhil Shah";
//string myCity = "Mumbai";
//int myVehicles = 2;

//Console.WriteLine("My Name is : " + myName);
//Console.WriteLine("I am from : " + myCity);
//Console.WriteLine("I have " + myVehicles + " Vehicles");
//Console.WriteLine("Am I Permenant Employee ? : " + isPermenantEmployee);
#endregion

#region Read user values
//string guestName;
//double age;
//string guestCity;

//Console.WriteLine("Please tell us your Name ");
//guestName = Console.ReadLine();

//Console.WriteLine("How old are you ");
//age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Which city are you from ");
//guestCity = Console.ReadLine();

//Console.WriteLine("Hello " + guestName + " you are " + age + " and " + guestCity + " is a wonderful city ");
#endregion

#region Calculation

#region Variables
//double firstNumber;
//double secondNumber;
//double addition;
//double subtraction;
//double multiplication;
//double division;
#endregion

#region Read user numbers
//Console.WriteLine("Please Enter First Number");
//firstNumber = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Please Enter Second Number");
//secondNumber = Convert.ToDouble(Console.ReadLine());
//#endregion

//#region Calculate numbers
//addition = firstNumber + secondNumber;
//subtraction = firstNumber - secondNumber;
//multiplication = firstNumber * secondNumber;
//division = firstNumber / secondNumber;
//#endregion

//#region Display calculated numbers
//Console.WriteLine("Addition of Numbers are : " + addition);
//Console.WriteLine("Subtraction of Numbers are : " + subtraction);
//Console.WriteLine("Multiplication of numbers are : " + multiplication);
//Console.WriteLine("Division of Numbers are : " + division);
#endregion

#endregion

#region If Condition

//int firstNumber;
//int secondNumber;
//int subtraction;

//Console.WriteLine("Enter First Positive Number");
//firstNumber = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Second Positive Number");
//secondNumber = Convert.ToInt32(Console.ReadLine());

//if (firstNumber < 0 || secondNumber < 0)
//{
//    Console.WriteLine("We process Positive Number only");
//}
//else if (secondNumber > firstNumber)
//{
//    Console.WriteLine("This will result in negative result, we do not process negative values");
//}
//else
//{
//    subtraction = firstNumber - secondNumber;

//    Console.WriteLine("Subtraction is : " + subtraction);
//}



#endregion

#region Switch Case
string city;
Console.WriteLine("Please enter your City");
city = Console.ReadLine();

switch (city)
{
	case "Mumbai":
		Console.WriteLine(city + " is locatted in Maharashtra ");
        Console.WriteLine("Is famous for buildings and is a financial capital of country");
        break;
	case "Kolkatta":
		Console.WriteLine(city + " is located in West Bengal");
        Console.WriteLine(city + " is famous for Bridges, food and culture");
        Console.WriteLine(city + " is known for Durga Pujo");
        break;
    case "Bangalore":
        Console.WriteLine(city + " is located in Karnataka");
        Console.WriteLine(city + " is Information technology capital of the country");
        break;
    default:
        Console.WriteLine("City Information not available");
        break;
}
#endregion

