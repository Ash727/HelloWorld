// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string firstName = "Sue";
//Console.Write("How old are you:");
Exception invalidThrown = new Exception("Invalid Fromat");
int age; 
do
{
    Console.Write("How old are you:");
    bool valid = int.TryParse(Console.ReadLine(), out age);

    if (!valid)
    {
        Console.WriteLine("Thats not a correct Number Format");
        return;
    }

    switch (age)
    {
        case >= 0 and < 18:
            Console.WriteLine("You are a child");
            firstName = "Sue";
            break;
        case > 18 and < 66:
            Console.WriteLine("You should have a JOB");
            break;
        case >= 66:
            Console.WriteLine("Hopepfully you are retired or retiring soon ");
            break;
        default:
            Console.WriteLine("Age was not  an expected range");
            break;
    }
} while (age < 18);

Console.ReadLine();



