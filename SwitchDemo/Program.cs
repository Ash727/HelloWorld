// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string firstName = "Sue";
int age = 43;


switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine("You are a child");
        firstName = "Sue";
        break;
    case > 18 and < 66:
        Console.WriteLine("You should have a JOB");
        break;
    case >=66:
        Console.WriteLine("Hopepfully you are retired or retiring soon ");
        break;
    default:
        Console.WriteLine("Age was not  an expected range");
        break;
}
Console.ReadLine();

