

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



int totalGuest = 0;
Console.WriteLine("Please Enter How many guest you have");

totalGuest =Convert.ToInt32(Console.ReadLine());
string[] guestName = new string[totalGuest];
int maleGuest = 0;
int femaleGuest = 0;
for (int i = 0; i < totalGuest; i++)
{
    Console.WriteLine("Please Enter Name of Guest #" + (i + 1) );
    guestName[i] = Console.ReadLine();

    Console.WriteLine("Male / Female ? ");
    string gender = Console.ReadLine();
    if (gender == "Male")
    {
        guestName[i] = "Mr." + guestName[i];
        maleGuest++;
    }
    else
    {
        guestName[i] = "Mrs." + guestName[i];
        femaleGuest++;
    }

}


Console.WriteLine("Total Guest : " + totalGuest);
Console.WriteLine("Male Guest : " + maleGuest);
Console.WriteLine("Female Guest : " + femaleGuest);

for (int i = 0; i < totalGuest; i++)
{
    Console.WriteLine(guestName[i]);
}

























