// See https://aka.ms/new-console-template for more information
using Exception_handling_demo;

Console.WriteLine("Hello, World!");





try
{
    Calculate calObj = new Calculate();

    Console.WriteLine("Enter First Number");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter Second Number");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int result = calObj.DivideNumbers(num1, num2);
    Console.WriteLine(result);
}
catch (Exception es)
{
    Console.WriteLine(es.Message);
}
finally // this is a neural block - wether there is error or no, finally block will always execute
        // we use finally block to clear resources, reference eg. myfile.close(), reader.Close(), conn.Close()r; etc...
        //it is also optional block
{
    Console.WriteLine("Thank you");
}
