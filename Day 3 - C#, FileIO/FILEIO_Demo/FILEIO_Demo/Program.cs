using System.IO;


Console.WriteLine("File IO Demo");

#region Demo 1
//FileStream myFile = new FileStream("myIntro.txt",FileMode.Create,FileAccess.Write); //this will create a new file and you will have write permission on it
////we need a pen to write into a file

//StreamWriter myPen = new StreamWriter(myFile);

//myPen.WriteLine("Hello and Welcome to My Intro");
//myPen.WriteLine("My name is Nikhil");
//myPen.WriteLine("I am from Mumbai");
//myPen.WriteLine("I am a Programmer by Profession");
//myPen.WriteLine("Thank you");


//myPen.Close();
//myFile.Close();

//Console.WriteLine("Details Written inside the file");
#endregion

#region Write to File 1

//Console.WriteLine("Please Tell Us Your Name");
//string guestName = Console.ReadLine();

//FileStream userFile = new FileStream(guestName + ".txt",FileMode.Create,FileAccess.Write);
//StreamWriter userWriter = new StreamWriter(userFile);

//string info;
//Console.WriteLine("Tell Us Your Full Name");
//info = Console.ReadLine();
//userWriter.WriteLine("Name : " + info);

//Console.WriteLine("Tell Us Your City");
//info = Console.ReadLine();
//userWriter.WriteLine("City : " + info);

//Console.WriteLine("Tell Us Your Fav Dish");
//info = Console.ReadLine();
//userWriter.WriteLine("Dish : " + info);

//Console.WriteLine("Tell Us Your Fav Sports");
//info = Console.ReadLine();
//userWriter.WriteLine("Sport : " + info);

//Console.WriteLine("Tell Us Your Fav Movie");
//info = Console.ReadLine();
//userWriter.WriteLine("Movie : " + info);

//Console.WriteLine("Tell Us More About us");
//info = Console.ReadLine();
//userWriter.WriteLine("Description : " + info);

//userWriter.Close();
//userFile.Close();

//Console.WriteLine("Thank you " + guestName + " For the Details");

#endregion

#region Read a File
//FileStream myFile = new FileStream("Nidhi.txt",FileMode.Open,FileAccess.Read);

//StreamReader readMyFile = new StreamReader(myFile);

//string details = readMyFile.ReadToEnd();
//Console.WriteLine(details);

//readMyFile.Close();
//myFile.Close();
#endregion

#region Read A user file
//Console.WriteLine("Enter Name of the person you want to know the details about");

//string name= Console.ReadLine();

//if (File.Exists(name + ".txt"))
//{

//    FileStream userFile = new FileStream(name + ".txt", FileMode.Open, FileAccess.Read);
//    StreamReader readUserFile = new StreamReader(userFile);

//    Console.WriteLine(readUserFile.ReadToEnd());

//    readUserFile.Close();
//    userFile.Close();
//}
//else
//{
//    Console.WriteLine("Sorry File Not found");
//}
#endregion

#region Login Check

//Console.WriteLine("Welcome to EMS");
//Console.WriteLine("Please Press Enter to Login");
//Console.ReadLine();


//string username;
//string password;

//Console.WriteLine("Enter User Name");
//username = Console.ReadLine();

//Console.WriteLine("Enter Password");
//password = Console.ReadLine();

//if (username == null || password == null)
//{
//    Console.WriteLine("Please Enter Values properly, blank values will not be processd");
//}
//else
//{
//    FileStream credFile = new FileStream(@"E:\cred.txt", FileMode.Open, FileAccess.Read);
//    StreamReader read = new StreamReader(credFile);


//    string fileUsername = read.ReadLine();
//    string filePassword = read.ReadLine();

//    if (username == fileUsername && password == filePassword)
//    {
//        Console.WriteLine("Welcome " + username);
//    }
//    else
//    {
//        Console.WriteLine("Invalid Credentials");
//    }
//    read.Close();
//    credFile.Close();
//}

#endregion

#region Read a Specific Line
//FileStream myFile = new FileStream(@"E:\cred.txt",FileMode.Open,FileAccess.Read);
//StreamReader sr = new StreamReader(myFile);

//int lineIWantToRead = 5;


//for (int i = 0; i < lineIWantToRead + 1; i++)
//{
//    sr.ReadLine();
//    if(i == 5)
//    {
//        Console.WriteLine(sr.ReadLine());
//    }
//}
#endregion

#region Read and Increment the number

//string fileName = "autonumber.txt";

//if (File.Exists(fileName))
//{
//    //we will read the number from file and increment it and store it back to the same file
//    FileStream read_numberFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
//    StreamReader readNumber = new StreamReader(read_numberFile);
//    int value = Convert.ToInt32(readNumber.ReadLine());
//    Console.WriteLine(value);

//    Console.WriteLine("Number From File : " + value);

//    readNumber.Close();
//    read_numberFile.Close();

//    value++; //strore this number back to file

//    FileStream writeNumberFile = new FileStream(fileName,FileMode.Create, FileAccess.Write);
//    StreamWriter writeNumber = new StreamWriter(writeNumberFile);
//    writeNumber.Write(value);
//    writeNumber.Close();
//    writeNumberFile.Close();

//    Console.WriteLine("Number Saved to File : " + value);


//}
//else
//{
//    //let system create a new file, add a default number to it and save the file, we will read it next time
//    FileStream writeDefaulNumberFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
//    StreamWriter writeDEfaultNumber = new StreamWriter(writeDefaulNumberFile);
//    writeDEfaultNumber.Write(1);
//    writeDEfaultNumber.Close();
//    writeDefaulNumberFile.Close();
//    Console.WriteLine("New File created and Number is set to 1");

//}

#endregion


















