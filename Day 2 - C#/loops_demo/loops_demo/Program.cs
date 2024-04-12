//Console.WriteLine("Welcome to Learning Loops ");


#region Simple For Loop
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Hello World" + i);
//}
#endregion

#region Print a table

//Console.WriteLine("Put a Number to print the table ");
//int tableToPrint = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i < 11; i++)
//{
//    Console.WriteLine(tableToPrint + " * " + i + " = " + (tableToPrint * i));
//}

//Console.WriteLine("Thank you for useing my code");

#endregion

#region Numbers summary
//int userNumber = 20;
//int addition = 0;
//int evenNumbers = 0;
//int oddNumbers = 0;
//int negativeNumbers = 0;

//for (int i = 1; i <= userNumber ; i++)
//{
//    Console.WriteLine("Enter a Number : " + i);
//    int value = Convert.ToInt32(Console.ReadLine());

//    addition = addition + value;
//    if (value % 2 == 0)
//    {
//        evenNumbers++;
//    }
//    else if (value % 2 == 1)
//    { 
//        oddNumbers++;
//    }
//    if (value < 0) 
//    {
//        negativeNumbers++;
//    }

//}
//Console.WriteLine("----------Summary-----------------");
//Console.WriteLine("Addition of numbers " + addition);
//Console.WriteLine("Even Numbers " + evenNumbers);
//Console.WriteLine("Ödd Numbers " + oddNumbers);
//Console.WriteLine("Negative Numbers " + negativeNumbers);
#endregion

#region While Loop
//Console.WriteLine("Please enter number");
//int userNumber = Convert.ToInt32(Console.ReadLine());

//while (userNumber > 0)
//{
//    Console.WriteLine("Thank you for the Positive Number");
//    Console.WriteLine("Please enter number");
//    userNumber = Convert.ToInt32(Console.ReadLine());


//}
#endregion

using System.Runtime.CompilerServices;

Console.WriteLine("!!~~~~~~~~~~~~~~~~~~ Welcome to CitiBank ~~~~~~~~~~~~~!!");


bool continueTransaction = true;
int userChoice;

while (continueTransaction == true)
{
    Console.WriteLine("1. Login To Account");
    Console.WriteLine("2. Create a New Account");
    Console.WriteLine("3. Withdraw");
    Console.WriteLine("4. Deposit");
    Console.WriteLine("5. Transfer");
    Console.WriteLine("6. Pay Bill");
    Console.WriteLine("7. Change Password");
    Console.WriteLine("8. Exit");

    userChoice = Convert.ToInt32(Console.ReadLine());

    switch (userChoice)
    {
        case 1:
            Console.WriteLine("Please Enter Secret Pin");
            Console.WriteLine("Welcome to Banking");
            break;
        case 2:
            Console.WriteLine("Read all the user information");
            Console.WriteLine("New Account created, thank you for all the information");
            break;
        case 3:
            Console.WriteLine("Enter Amount you want to Widraw");
            Console.WriteLine("Withdraw Successfull");
            break;
        case 4:
            Console.WriteLine("Enter Amount you want to Deposit");
            Console.WriteLine("Deposit Successfull");
            break;
        case 5:
            Console.WriteLine("Transfer Initialted");
            break;
        case 6:
            Console.WriteLine("Choose a Bill to Pay");
            Console.WriteLine("A.Electricity Bill");
            Console.WriteLine("B.Creditcard Bill");
            Console.WriteLine("C.Gas Bill");
            string billChoice = "A";
            switch (billChoice) 
            {
                case "A":
                    Console.WriteLine("Electricity Bill Paid");
                    break;
                case "B":
                    Console.WriteLine("Credit Card Paid");
                    break;
                case "C":
                    Console.WriteLine("Gas Bill Paid");
                    break;
                default:
                    Console.WriteLine("Biller Not found");
                    break;

            }
            break; 
        case 7:
            Console.WriteLine("Password Changed");
            break;
        case 8:
            continueTransaction = false;
            Console.WriteLine("Thank you for Banking, see you soon again");
            break;
        default:
            continueTransaction = false;
            Console.WriteLine("Sorry wrong option, login again, Thank you for Banking ");
            break;
    }  

}







